// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/enums/policy_topic_evidence_destination_mismatch_url_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/enums/policy_topic_evidence_destination_mismatch_url_type.proto</summary>
  public static partial class PolicyTopicEvidenceDestinationMismatchUrlTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/enums/policy_topic_evidence_destination_mismatch_url_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PolicyTopicEvidenceDestinationMismatchUrlTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Clhnb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvZW51bXMvcG9saWN5X3RvcGlj",
            "X2V2aWRlbmNlX2Rlc3RpbmF0aW9uX21pc21hdGNoX3VybF90eXBlLnByb3Rv",
            "Eh5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZW51bXMi5AEKMVBvbGljeVRv",
            "cGljRXZpZGVuY2VEZXN0aW5hdGlvbk1pc21hdGNoVXJsVHlwZUVudW0irgEK",
            "LVBvbGljeVRvcGljRXZpZGVuY2VEZXN0aW5hdGlvbk1pc21hdGNoVXJsVHlw",
            "ZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VOS05PV04QARIPCgtESVNQTEFZX1VS",
            "TBACEg0KCUZJTkFMX1VSTBADEhQKEEZJTkFMX01PQklMRV9VUkwQBBIQCgxU",
            "UkFDS0lOR19VUkwQBRIXChNNT0JJTEVfVFJBQ0tJTkdfVVJMEAZCjAIKImNv",
            "bS5nb29nbGUuYWRzLmdvb2dsZWFkcy52MTEuZW51bXNCMlBvbGljeVRvcGlj",
            "RXZpZGVuY2VEZXN0aW5hdGlvbk1pc21hdGNoVXJsVHlwZVByb3RvUAFaQ2dv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2ds",
            "ZWFkcy92MTEvZW51bXM7ZW51bXOiAgNHQUGqAh5Hb29nbGUuQWRzLkdvb2ds",
            "ZUFkcy5WMTEuRW51bXPKAh5Hb29nbGVcQWRzXEdvb2dsZUFkc1xWMTFcRW51",
            "bXPqAiJHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMTE6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum), global::Google.Ads.GoogleAds.V11.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V11.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeEnum.Types.PolicyTopicEvidenceDestinationMismatchUrlType) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible policy topic evidence destination
  /// mismatch url types.
  /// </summary>
  public sealed partial class PolicyTopicEvidenceDestinationMismatchUrlTypeEnum : pb::IMessage<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> _parser = new pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum>(() => new PolicyTopicEvidenceDestinationMismatchUrlTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<PolicyTopicEvidenceDestinationMismatchUrlTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Enums.PolicyTopicEvidenceDestinationMismatchUrlTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public PolicyTopicEvidenceDestinationMismatchUrlTypeEnum Clone() {
      return new PolicyTopicEvidenceDestinationMismatchUrlTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as PolicyTopicEvidenceDestinationMismatchUrlTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) {
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
    public void MergeFrom(PolicyTopicEvidenceDestinationMismatchUrlTypeEnum other) {
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

    #region Nested types
    /// <summary>Container for nested types declared in the PolicyTopicEvidenceDestinationMismatchUrlTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The possible policy topic evidence destination mismatch url types.
      /// </summary>
      public enum PolicyTopicEvidenceDestinationMismatchUrlType {
        /// <summary>
        /// No value has been specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The received value is not known in this version.
        ///
        /// This is a response-only value.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The display url.
        /// </summary>
        [pbr::OriginalName("DISPLAY_URL")] DisplayUrl = 2,
        /// <summary>
        /// The final url.
        /// </summary>
        [pbr::OriginalName("FINAL_URL")] FinalUrl = 3,
        /// <summary>
        /// The final mobile url.
        /// </summary>
        [pbr::OriginalName("FINAL_MOBILE_URL")] FinalMobileUrl = 4,
        /// <summary>
        /// The tracking url template, with substituted desktop url.
        /// </summary>
        [pbr::OriginalName("TRACKING_URL")] TrackingUrl = 5,
        /// <summary>
        /// The tracking url template, with substituted mobile url.
        /// </summary>
        [pbr::OriginalName("MOBILE_TRACKING_URL")] MobileTrackingUrl = 6,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
