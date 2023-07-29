// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SpoolPendingTransactions.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace TransactionProcessing.Server.Protos {

  /// <summary>Holder for reflection information generated from Protos/SpoolPendingTransactions.proto</summary>
  public static partial class SpoolPendingTransactionsReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/SpoolPendingTransactions.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SpoolPendingTransactionsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVQcm90b3MvU3Bvb2xQZW5kaW5nVHJhbnNhY3Rpb25zLnByb3RvGh9nb29n",
            "bGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvIhwKGlBlbmRpbmdUcmFuc2Fj",
            "dGlvbnNSZXF1ZXN0ItoBCgtUcmFuc2FjdGlvbhIWCg50cmFuc2FjdGlvbl9p",
            "ZBgBIAEoBRIOCgZhbW91bnQYAiABKAMSEgoKc2VuZGVyX3JlZhgDIAEoCRIU",
            "CgxyZWNlaXZlcl9yZWYYBCABKAkSFAoMaXNfY29tcGxldGVkGAUgASgIEi8K",
            "C2NyZWF0ZV9kYXRlGAYgASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
            "cBIyCg5wcm9jZXNzZWRfZGF0ZRgHIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5U",
            "aW1lc3RhbXAiJQoQUHJvY2Vzc2luZ1N0YXR1cxIRCglpc1N1Y2Nlc3MYASAB",
            "KAgyXAoYU3Bvb2xQZW5kaW5nVHJhbnNhY3Rpb25zEkAKEUZldGNoVHJhbnNh",
            "Y3Rpb25zEhsuUGVuZGluZ1RyYW5zYWN0aW9uc1JlcXVlc3QaDC5UcmFuc2Fj",
            "dGlvbjABQiaqAiNUcmFuc2FjdGlvblByb2Nlc3NpbmcuU2VydmVyLlByb3Rv",
            "c2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::TransactionProcessing.Server.Protos.PendingTransactionsRequest), global::TransactionProcessing.Server.Protos.PendingTransactionsRequest.Parser, null, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TransactionProcessing.Server.Protos.Transaction), global::TransactionProcessing.Server.Protos.Transaction.Parser, new[]{ "TransactionId", "Amount", "SenderRef", "ReceiverRef", "IsCompleted", "CreateDate", "ProcessedDate" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::TransactionProcessing.Server.Protos.ProcessingStatus), global::TransactionProcessing.Server.Protos.ProcessingStatus.Parser, new[]{ "IsSuccess" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PendingTransactionsRequest : pb::IMessage<PendingTransactionsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PendingTransactionsRequest> _parser = new pb::MessageParser<PendingTransactionsRequest>(() => new PendingTransactionsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PendingTransactionsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TransactionProcessing.Server.Protos.SpoolPendingTransactionsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PendingTransactionsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PendingTransactionsRequest(PendingTransactionsRequest other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PendingTransactionsRequest Clone() {
      return new PendingTransactionsRequest(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PendingTransactionsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PendingTransactionsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(PendingTransactionsRequest other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
        }
      }
    }
    #endif

  }

  public sealed partial class Transaction : pb::IMessage<Transaction>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Transaction> _parser = new pb::MessageParser<Transaction>(() => new Transaction());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Transaction> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TransactionProcessing.Server.Protos.SpoolPendingTransactionsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Transaction() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Transaction(Transaction other) : this() {
      transactionId_ = other.transactionId_;
      amount_ = other.amount_;
      senderRef_ = other.senderRef_;
      receiverRef_ = other.receiverRef_;
      isCompleted_ = other.isCompleted_;
      createDate_ = other.createDate_ != null ? other.createDate_.Clone() : null;
      processedDate_ = other.processedDate_ != null ? other.processedDate_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Transaction Clone() {
      return new Transaction(this);
    }

    /// <summary>Field number for the "transaction_id" field.</summary>
    public const int TransactionIdFieldNumber = 1;
    private int transactionId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TransactionId {
      get { return transactionId_; }
      set {
        transactionId_ = value;
      }
    }

    /// <summary>Field number for the "amount" field.</summary>
    public const int AmountFieldNumber = 2;
    private long amount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long Amount {
      get { return amount_; }
      set {
        amount_ = value;
      }
    }

    /// <summary>Field number for the "sender_ref" field.</summary>
    public const int SenderRefFieldNumber = 3;
    private string senderRef_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SenderRef {
      get { return senderRef_; }
      set {
        senderRef_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "receiver_ref" field.</summary>
    public const int ReceiverRefFieldNumber = 4;
    private string receiverRef_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ReceiverRef {
      get { return receiverRef_; }
      set {
        receiverRef_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "is_completed" field.</summary>
    public const int IsCompletedFieldNumber = 5;
    private bool isCompleted_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsCompleted {
      get { return isCompleted_; }
      set {
        isCompleted_ = value;
      }
    }

    /// <summary>Field number for the "create_date" field.</summary>
    public const int CreateDateFieldNumber = 6;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateDate {
      get { return createDate_; }
      set {
        createDate_ = value;
      }
    }

    /// <summary>Field number for the "processed_date" field.</summary>
    public const int ProcessedDateFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp processedDate_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ProcessedDate {
      get { return processedDate_; }
      set {
        processedDate_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Transaction);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Transaction other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (TransactionId != other.TransactionId) return false;
      if (Amount != other.Amount) return false;
      if (SenderRef != other.SenderRef) return false;
      if (ReceiverRef != other.ReceiverRef) return false;
      if (IsCompleted != other.IsCompleted) return false;
      if (!object.Equals(CreateDate, other.CreateDate)) return false;
      if (!object.Equals(ProcessedDate, other.ProcessedDate)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (TransactionId != 0) hash ^= TransactionId.GetHashCode();
      if (Amount != 0L) hash ^= Amount.GetHashCode();
      if (SenderRef.Length != 0) hash ^= SenderRef.GetHashCode();
      if (ReceiverRef.Length != 0) hash ^= ReceiverRef.GetHashCode();
      if (IsCompleted != false) hash ^= IsCompleted.GetHashCode();
      if (createDate_ != null) hash ^= CreateDate.GetHashCode();
      if (processedDate_ != null) hash ^= ProcessedDate.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (TransactionId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(TransactionId);
      }
      if (Amount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Amount);
      }
      if (SenderRef.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SenderRef);
      }
      if (ReceiverRef.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ReceiverRef);
      }
      if (IsCompleted != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCompleted);
      }
      if (createDate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateDate);
      }
      if (processedDate_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ProcessedDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (TransactionId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(TransactionId);
      }
      if (Amount != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Amount);
      }
      if (SenderRef.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SenderRef);
      }
      if (ReceiverRef.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(ReceiverRef);
      }
      if (IsCompleted != false) {
        output.WriteRawTag(40);
        output.WriteBool(IsCompleted);
      }
      if (createDate_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(CreateDate);
      }
      if (processedDate_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(ProcessedDate);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (TransactionId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TransactionId);
      }
      if (Amount != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Amount);
      }
      if (SenderRef.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SenderRef);
      }
      if (ReceiverRef.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ReceiverRef);
      }
      if (IsCompleted != false) {
        size += 1 + 1;
      }
      if (createDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateDate);
      }
      if (processedDate_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProcessedDate);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Transaction other) {
      if (other == null) {
        return;
      }
      if (other.TransactionId != 0) {
        TransactionId = other.TransactionId;
      }
      if (other.Amount != 0L) {
        Amount = other.Amount;
      }
      if (other.SenderRef.Length != 0) {
        SenderRef = other.SenderRef;
      }
      if (other.ReceiverRef.Length != 0) {
        ReceiverRef = other.ReceiverRef;
      }
      if (other.IsCompleted != false) {
        IsCompleted = other.IsCompleted;
      }
      if (other.createDate_ != null) {
        if (createDate_ == null) {
          CreateDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateDate.MergeFrom(other.CreateDate);
      }
      if (other.processedDate_ != null) {
        if (processedDate_ == null) {
          ProcessedDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ProcessedDate.MergeFrom(other.ProcessedDate);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            TransactionId = input.ReadInt32();
            break;
          }
          case 16: {
            Amount = input.ReadInt64();
            break;
          }
          case 26: {
            SenderRef = input.ReadString();
            break;
          }
          case 34: {
            ReceiverRef = input.ReadString();
            break;
          }
          case 40: {
            IsCompleted = input.ReadBool();
            break;
          }
          case 50: {
            if (createDate_ == null) {
              CreateDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateDate);
            break;
          }
          case 58: {
            if (processedDate_ == null) {
              ProcessedDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProcessedDate);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            TransactionId = input.ReadInt32();
            break;
          }
          case 16: {
            Amount = input.ReadInt64();
            break;
          }
          case 26: {
            SenderRef = input.ReadString();
            break;
          }
          case 34: {
            ReceiverRef = input.ReadString();
            break;
          }
          case 40: {
            IsCompleted = input.ReadBool();
            break;
          }
          case 50: {
            if (createDate_ == null) {
              CreateDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateDate);
            break;
          }
          case 58: {
            if (processedDate_ == null) {
              ProcessedDate = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ProcessedDate);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class ProcessingStatus : pb::IMessage<ProcessingStatus>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProcessingStatus> _parser = new pb::MessageParser<ProcessingStatus>(() => new ProcessingStatus());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ProcessingStatus> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::TransactionProcessing.Server.Protos.SpoolPendingTransactionsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessingStatus() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessingStatus(ProcessingStatus other) : this() {
      isSuccess_ = other.isSuccess_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ProcessingStatus Clone() {
      return new ProcessingStatus(this);
    }

    /// <summary>Field number for the "isSuccess" field.</summary>
    public const int IsSuccessFieldNumber = 1;
    private bool isSuccess_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool IsSuccess {
      get { return isSuccess_; }
      set {
        isSuccess_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ProcessingStatus);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ProcessingStatus other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (IsSuccess != other.IsSuccess) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (IsSuccess != false) hash ^= IsSuccess.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (IsSuccess != false) {
        output.WriteRawTag(8);
        output.WriteBool(IsSuccess);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (IsSuccess != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ProcessingStatus other) {
      if (other == null) {
        return;
      }
      if (other.IsSuccess != false) {
        IsSuccess = other.IsSuccess;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            IsSuccess = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            IsSuccess = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
