// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/common/feed_common.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/common/feed_common.proto</summary>
  public static partial class FeedCommonReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/common/feed_common.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedCommonReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvY29tbW9uL2ZlZWRfY29tbW9u",
            "LnByb3RvEh9nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuY29tbW9uImMKBU1v",
            "bmV5EhoKDWN1cnJlbmN5X2NvZGUYAyABKAlIAIgBARIaCg1hbW91bnRfbWlj",
            "cm9zGAQgASgDSAGIAQFCEAoOX2N1cnJlbmN5X2NvZGVCEAoOX2Ftb3VudF9t",
            "aWNyb3NC7wEKI2NvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuY29tbW9u",
            "Qg9GZWVkQ29tbW9uUHJvdG9QAVpFZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJv",
            "dG8vZ29vZ2xlYXBpcy9hZHMvZ29vZ2xlYWRzL3YxMS9jb21tb247Y29tbW9u",
            "ogIDR0FBqgIfR29vZ2xlLkFkcy5Hb29nbGVBZHMuVjExLkNvbW1vbsoCH0dv",
            "b2dsZVxBZHNcR29vZ2xlQWRzXFYxMVxDb21tb27qAiNHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMTE6OkNvbW1vbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Common.Money), global::Google.Ads.GoogleAds.V11.Common.Money.Parser, new[]{ "CurrencyCode", "AmountMicros" }, new[]{ "CurrencyCode", "AmountMicros" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a price in a particular currency.
  /// </summary>
  public sealed partial class Money : pb::IMessage<Money>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Money> _parser = new pb::MessageParser<Money>(() => new Money());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Money> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Common.FeedCommonReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Money() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Money(Money other) : this() {
      _hasBits0 = other._hasBits0;
      currencyCode_ = other.currencyCode_;
      amountMicros_ = other.amountMicros_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Money Clone() {
      return new Money(this);
    }

    /// <summary>Field number for the "currency_code" field.</summary>
    public const int CurrencyCodeFieldNumber = 3;
    private string currencyCode_;
    /// <summary>
    /// Three-character ISO 4217 currency code.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CurrencyCode {
      get { return currencyCode_ ?? ""; }
      set {
        currencyCode_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "currency_code" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasCurrencyCode {
      get { return currencyCode_ != null; }
    }
    /// <summary>Clears the value of the "currency_code" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearCurrencyCode() {
      currencyCode_ = null;
    }

    /// <summary>Field number for the "amount_micros" field.</summary>
    public const int AmountMicrosFieldNumber = 4;
    private long amountMicros_;
    /// <summary>
    /// Amount in micros. One million is equivalent to one unit.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long AmountMicros {
      get { if ((_hasBits0 & 1) != 0) { return amountMicros_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        amountMicros_ = value;
      }
    }
    /// <summary>Gets whether the "amount_micros" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasAmountMicros {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "amount_micros" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearAmountMicros() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Money);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Money other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CurrencyCode != other.CurrencyCode) return false;
      if (AmountMicros != other.AmountMicros) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasCurrencyCode) hash ^= CurrencyCode.GetHashCode();
      if (HasAmountMicros) hash ^= AmountMicros.GetHashCode();
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
      if (HasCurrencyCode) {
        output.WriteRawTag(26);
        output.WriteString(CurrencyCode);
      }
      if (HasAmountMicros) {
        output.WriteRawTag(32);
        output.WriteInt64(AmountMicros);
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
      if (HasCurrencyCode) {
        output.WriteRawTag(26);
        output.WriteString(CurrencyCode);
      }
      if (HasAmountMicros) {
        output.WriteRawTag(32);
        output.WriteInt64(AmountMicros);
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
      if (HasCurrencyCode) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CurrencyCode);
      }
      if (HasAmountMicros) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(AmountMicros);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Money other) {
      if (other == null) {
        return;
      }
      if (other.HasCurrencyCode) {
        CurrencyCode = other.CurrencyCode;
      }
      if (other.HasAmountMicros) {
        AmountMicros = other.AmountMicros;
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
          case 26: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 32: {
            AmountMicros = input.ReadInt64();
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
          case 26: {
            CurrencyCode = input.ReadString();
            break;
          }
          case 32: {
            AmountMicros = input.ReadInt64();
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
