﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using Transactioneer.Models;

namespace Transactioneer.Controllers
{
    public class TransactionsController : Controller
    {
        private string baseUrl = "https://localhost:7021/api/Transactions/";
        public IActionResult TopUpCustomerBalance()
        {
            return View();
        }
        [HttpPost]
        public IActionResult TopUpCustomerBalance(TopUpCustomerRequest topUpDetails)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    
                    HttpResponseMessage res = client.PostAsJsonAsync(baseUrl + "TopUpBalance", topUpDetails).Result;
                   

                    if (res.IsSuccessStatusCode)
                    {
                        var result = res.Content.ReadAsStringAsync().Result;
                        TopUpCustomerResponse topUpCustomerResponse = JsonConvert.DeserializeObject<TopUpCustomerResponse>(result);
                        if (topUpCustomerResponse.IsSuccess)
                        {
                            ViewBag.msg = topUpCustomerResponse.Result;
                            ModelState.Clear();
                        }
                        else
                        {
                            

                            string[] errors = topUpCustomerResponse.ErrorMessages;
                            StringBuilder sb = new StringBuilder();
                            foreach(string  error in errors)
                            {
                                sb.Append(error);
                                sb.Append(" ");
                            }
                            //string errorsMappedToString = errors.Aggregate((current, next) => current + " " + next);
                            string errorsMappedToString = sb.ToString();
                            ViewBag.msg = errorsMappedToString;
                            
                        }
                    }
                    else
                    {

                        ViewBag.msg = "Top Up failed! Contact Support";
                    }
                }
            }
            catch (Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View();
        }
        public IActionResult PostTransaction()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostTransaction(PostTransaction transactionDetails)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage res = client.PostAsJsonAsync(baseUrl + "PostTransaction", transactionDetails).Result;

                    if (res.IsSuccessStatusCode)
                    {
                        var result = res.Content.ReadAsStringAsync().Result;
                        PostTransactionResponse postTransactionResponse = JsonConvert.DeserializeObject<PostTransactionResponse>(result);
                        if (postTransactionResponse.isSuccess)
                        {
                            ViewBag.msg = "Transaction Posted Sucessfully";
                            ModelState.Clear();
                        }
                        else
                        {
                            ViewBag.msg = postTransactionResponse.ErrorMessages.ToString();
                            ModelState.Clear();
                        }
                    }
                    else
                    {
                        ViewBag.msg = "Posting failed! Contact Support";
                    }
                }
            }
            catch(Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View();
        }
        [HttpGet]
        public IActionResult TransactionsReport()
        {
            List<TransactionReport> allTransactionReports = new List<TransactionReport>();
            try
            {
                
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(baseUrl);
                    client.DefaultRequestHeaders.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                    HttpResponseMessage res = client.GetAsync(baseUrl + "GetTransactionsReport").Result;

                    if (res.IsSuccessStatusCode)
                    {
                        var result = res.Content.ReadAsStringAsync().Result;
                        TransactionsReportResponse transactionsReportResponse = JsonConvert.DeserializeObject<TransactionsReportResponse>(result);
                        if (transactionsReportResponse.IsSuccess)
                        {
                            foreach(TransactionReport transactionReport in transactionsReportResponse.Result)
                            {
                                TransactionReport report = new TransactionReport();

                                report.TransactionId = transactionReport.TransactionId;
                                report.SenderName = transactionReport.SenderName;
                                report.SenderRef = transactionReport.SenderRef;
                                report.ReceiverName = transactionReport.ReceiverName;
                                report.ReceiverRef = transactionReport.ReceiverRef;
                                report.Amount = transactionReport.Amount;
                                report.PostedOn = transactionReport.PostedOn;
                                report.ProcessedOn = transactionReport.ProcessedOn;
                                report.Completed = transactionReport.Completed;

                                allTransactionReports.Add(report);
                            }
                        }
                    }
                    else
                    {
                        ViewBag.msg = "Report spooling failed! Contact Support";
                    }
                }
            }
            catch(Exception ex)
            {
                ViewBag.msg = ex.Message;
            }
            return View(allTransactionReports);
        }
        
        
    }
}