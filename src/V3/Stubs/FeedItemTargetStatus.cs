// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/feed_item_target_status.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/feed_item_target_status.proto</summary>
  public static partial class FeedItemTargetStatusReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/feed_item_target_status.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FeedItemTargetStatusReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9mZWVkX2l0ZW1fdGFy",
            "Z2V0X3N0YXR1cy5wcm90bxIdZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuZW51",
            "bXMaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJvdG8iagoYRmVlZEl0ZW1U",
            "YXJnZXRTdGF0dXNFbnVtIk4KFEZlZWRJdGVtVGFyZ2V0U3RhdHVzEg8KC1VO",
            "U1BFQ0lGSUVEEAASCwoHVU5LTk9XThABEgsKB0VOQUJMRUQQAhILCgdSRU1P",
            "VkVEEANC7gEKIWNvbS5nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtc0IZ",
            "RmVlZEl0ZW1UYXJnZXRTdGF0dXNQcm90b1ABWkJnb29nbGUuZ29sYW5nLm9y",
            "Zy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9nb29nbGVhZHMvdjMvZW51bXM7",
            "ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdvb2dsZUFkcy5WMy5FbnVtc8oC",
            "HUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXEVudW1z6gIhR29vZ2xlOjpBZHM6",
            "Okdvb2dsZUFkczo6VjM6OkVudW1zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.FeedItemTargetStatusEnum), global::Google.Ads.GoogleAds.V3.Enums.FeedItemTargetStatusEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.FeedItemTargetStatusEnum.Types.FeedItemTargetStatus) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing possible statuses of a feed item target.
  /// </summary>
  public sealed partial class FeedItemTargetStatusEnum : pb::IMessage<FeedItemTargetStatusEnum> {
    private static readonly pb::MessageParser<FeedItemTargetStatusEnum> _parser = new pb::MessageParser<FeedItemTargetStatusEnum>(() => new FeedItemTargetStatusEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<FeedItemTargetStatusEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.FeedItemTargetStatusReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTargetStatusEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTargetStatusEnum(FeedItemTargetStatusEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public FeedItemTargetStatusEnum Clone() {
      return new FeedItemTargetStatusEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as FeedItemTargetStatusEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(FeedItemTargetStatusEnum other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(FeedItemTargetStatusEnum other) {
      if (other == null) {
        return;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the FeedItemTargetStatusEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Possible statuses of a feed item target.
      /// </summary>
      public enum FeedItemTargetStatus {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// Feed item target is enabled.
        /// </summary>
        [pbr::OriginalName("ENABLED")] Enabled = 2,
        /// <summary>
        /// Feed item target has been removed.
        /// </summary>
        [pbr::OriginalName("REMOVED")] Removed = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
