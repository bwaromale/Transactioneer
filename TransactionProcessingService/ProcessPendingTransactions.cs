﻿using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransactionProcessingService.Models;
using TransactionReportingAPI.Data;
using TransactionReportingAPI.Models;

namespace TransactionProcessingService
{
    public class ProcessPendingTransactions
    {
        private readonly TransactionProcessingContext _context;
        private string baseUrl = "https://localhost:7021/api/Transactions/";

        public ProcessPendingTransactions()
        {
            _context = new TransactionProcessingContext(new DbContextOptions<TransactionProcessingContext>());
        }

        public void Run()
        {
            List<Transaction> pendingTransactions = GetPendingTransations();
            ProcessPending(pendingTransactions);
        }
        private List<Transaction> GetPendingTransations()
        {

            List<Transaction> pendingTransactions = new List<Transaction>();

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(baseUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage res = client.GetAsync(baseUrl + "GetPendingTransactions").Result;

                if (res.IsSuccessStatusCode)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    FetchPendingObj fetchPendingResponse = JsonConvert.DeserializeObject<FetchPendingObj>(result);

                    if (fetchPendingResponse.isSuccess == true)
                    {
                        foreach (Transaction transaction in fetchPendingResponse.result)
                        {
                            Transaction pendingTransaction = new Transaction();

                            pendingTransaction.TransactionId = transaction.TransactionId;
                            pendingTransaction.Amount = transaction.Amount;
                            pendingTransaction.SenderRef = transaction.SenderRef;
                            pendingTransaction.ReceiverRef = transaction.ReceiverRef;
                            pendingTransaction.CreateDate = transaction.CreateDate;
                            pendingTransaction.ProcessedDate = transaction.ProcessedDate;
                            pendingTransaction.IsCompleted = transaction.IsCompleted;

                            pendingTransactions.Add(pendingTransaction);
                        }
                    }
                }
            }
            return pendingTransactions;
        }

        private void ProcessPending(List<Transaction> transactions)
        {
            try
            {
                foreach (Transaction transaction in transactions)
                {
                    //verify if sender has sufficient balance to perform transaction
                    Customer customer = _context.Customers.Where(c => c.CustomerRef == transaction.SenderRef && c.Balance >= transaction.Amount).FirstOrDefault();
                    if (customer == null)
                    {
                        continue;
                    }
                    //verify transaction id
                    //fetch using id
                    Transaction verifiedPendingTransaction = _context.Transactions.Where(ct => ct.TransactionId == transaction.TransactionId).FirstOrDefault();
                    if (verifiedPendingTransaction == null)
                    {
                        continue;
                    }
                    //debit the sender
                    bool debit = DebitSender(customer, transaction.Amount);
                    //credit the receiver
                    bool credit = CreditReceiver(transaction.ReceiverRef, transaction.Amount);
                    //update isCompleted to true, and set processing date to datetime.now
                    if (debit && credit)
                    {
                        verifiedPendingTransaction.IsCompleted = true;
                        verifiedPendingTransaction.ProcessedDate = DateTime.Now;
                        _context.Update(verifiedPendingTransaction);
                        _context.SaveChanges();
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception: "+ex.Message);
            }
        }
        private bool DebitSender(Customer customer, decimal amount)
        {
            bool isDebited = false;
            //subtract amount from balance
            decimal newBalance =  customer.Balance - amount;
            customer.Balance = newBalance;

            _context.Update(customer);
            var saveToDb = _context.SaveChanges();
            if(saveToDb == 1)
            {
                isDebited = true;
            }
            return isDebited;
        }
        private bool CreditReceiver(string receiverRef, decimal amount)
        {
            bool isCreditted =  false;

            //fetch receiver
            Customer receiver = _context.Customers.Where(r => r.CustomerRef == receiverRef).FirstOrDefault();
            decimal newBalance = receiver.Balance + amount;

            receiver.Balance = newBalance;
            //update balace
            _context.Update(receiver);
            var saveToDb = _context.SaveChanges();
            if (saveToDb == 1)
            {
                isCreditted = true;
            }
            return isCreditted;
        }
    }
}
