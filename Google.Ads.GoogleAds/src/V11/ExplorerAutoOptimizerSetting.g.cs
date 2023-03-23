// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/common/explorer_auto_optimizer_setting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Common {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/common/explorer_auto_optimizer_setting.proto</summary>
  public static partial class ExplorerAutoOptimizerSettingReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/common/explorer_auto_optimizer_setting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ExplorerAutoOptimizerSettingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvY29tbW9uL2V4cGxvcmVyX2F1",
            "dG9fb3B0aW1pemVyX3NldHRpbmcucHJvdG8SH2dvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYxMS5jb21tb24iPgocRXhwbG9yZXJBdXRvT3B0aW1pemVyU2V0dGlu",
            "ZxITCgZvcHRfaW4YAiABKAhIAIgBAUIJCgdfb3B0X2luQoECCiNjb20uZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjExLmNvbW1vbkIhRXhwbG9yZXJBdXRvT3B0",
            "aW1pemVyU2V0dGluZ1Byb3RvUAFaRWdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92MTEvY29tbW9uO2NvbW1v",
            "bqICA0dBQaoCH0dvb2dsZS5BZHMuR29vZ2xlQWRzLlYxMS5Db21tb27KAh9H",
            "b29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcQ29tbW9u6gIjR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjExOjpDb21tb25iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Common.ExplorerAutoOptimizerSetting), global::Google.Ads.GoogleAds.V11.Common.ExplorerAutoOptimizerSetting.Parser, new[]{ "OptIn" }, new[]{ "OptIn" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Settings for the Display Campaign Optimizer, initially named "Explorer".
  /// Learn more about
  /// [automatic targeting](https://support.google.com/google-ads/answer/190596).
  /// </summary>
  public sealed partial class ExplorerAutoOptimizerSetting : pb::IMessage<ExplorerAutoOptimizerSetting>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ExplorerAutoOptimizerSetting> _parser = new pb::MessageParser<ExplorerAutoOptimizerSetting>(() => new ExplorerAutoOptimizerSetting());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ExplorerAutoOptimizerSetting> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Common.ExplorerAutoOptimizerSettingReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExplorerAutoOptimizerSetting() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExplorerAutoOptimizerSetting(ExplorerAutoOptimizerSetting other) : this() {
      _hasBits0 = other._hasBits0;
      optIn_ = other.optIn_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ExplorerAutoOptimizerSetting Clone() {
      return new ExplorerAutoOptimizerSetting(this);
    }

    /// <summary>Field number for the "opt_in" field.</summary>
    public const int OptInFieldNumber = 2;
    private bool optIn_;
    /// <summary>
    /// Indicates whether the optimizer is turned on.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool OptIn {
      get { if ((_hasBits0 & 1) != 0) { return optIn_; } else { return false; } }
      set {
        _hasBits0 |= 1;
        optIn_ = value;
      }
    }
    /// <summary>Gets whether the "opt_in" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasOptIn {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "opt_in" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearOptIn() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ExplorerAutoOptimizerSetting);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ExplorerAutoOptimizerSetting other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (OptIn != other.OptIn) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasOptIn) hash ^= OptIn.GetHashCode();
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
      if (HasOptIn) {
        output.WriteRawTag(16);
        output.WriteBool(OptIn);
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
      if (HasOptIn) {
        output.WriteRawTag(16);
        output.WriteBool(OptIn);
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
      if (HasOptIn) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ExplorerAutoOptimizerSetting other) {
      if (other == null) {
        return;
      }
      if (other.HasOptIn) {
        OptIn = other.OptIn;
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
          case 16: {
            OptIn = input.ReadBool();
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
          case 16: {
            OptIn = input.ReadBool();
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
