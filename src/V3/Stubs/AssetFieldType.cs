// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/enums/asset_field_type.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Enums {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/enums/asset_field_type.proto</summary>
  public static partial class AssetFieldTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/enums/asset_field_type.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AssetFieldTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRnb29nbGUvYWRzL2dvb2dsZWFkcy92My9lbnVtcy9hc3NldF9maWVsZF90",
            "eXBlLnByb3RvEh1nb29nbGUuYWRzLmdvb2dsZWFkcy52My5lbnVtcxocZ29v",
            "Z2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90byK1AQoSQXNzZXRGaWVsZFR5cGVF",
            "bnVtIp4BCg5Bc3NldEZpZWxkVHlwZRIPCgtVTlNQRUNJRklFRBAAEgsKB1VO",
            "S05PV04QARIMCghIRUFETElORRACEg8KC0RFU0NSSVBUSU9OEAMSFQoRTUFO",
            "REFUT1JZX0FEX1RFWFQQBBITCg9NQVJLRVRJTkdfSU1BR0UQBRIQCgxNRURJ",
            "QV9CVU5ETEUQBhIRCg1ZT1VUVUJFX1ZJREVPEAdC6AEKIWNvbS5nb29nbGUu",
            "YWRzLmdvb2dsZWFkcy52My5lbnVtc0ITQXNzZXRGaWVsZFR5cGVQcm90b1AB",
            "WkJnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fkcy9n",
            "b29nbGVhZHMvdjMvZW51bXM7ZW51bXOiAgNHQUGqAh1Hb29nbGUuQWRzLkdv",
            "b2dsZUFkcy5WMy5FbnVtc8oCHUdvb2dsZVxBZHNcR29vZ2xlQWRzXFYzXEVu",
            "dW1z6gIhR29vZ2xlOjpBZHM6Okdvb2dsZUFkczo6VjM6OkVudW1zYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Enums.AssetFieldTypeEnum), global::Google.Ads.GoogleAds.V3.Enums.AssetFieldTypeEnum.Parser, null, null, new[]{ typeof(global::Google.Ads.GoogleAds.V3.Enums.AssetFieldTypeEnum.Types.AssetFieldType) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Container for enum describing the possible placements of an asset.
  /// </summary>
  public sealed partial class AssetFieldTypeEnum : pb::IMessage<AssetFieldTypeEnum> {
    private static readonly pb::MessageParser<AssetFieldTypeEnum> _parser = new pb::MessageParser<AssetFieldTypeEnum>(() => new AssetFieldTypeEnum());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AssetFieldTypeEnum> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Enums.AssetFieldTypeReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetFieldTypeEnum() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetFieldTypeEnum(AssetFieldTypeEnum other) : this() {
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AssetFieldTypeEnum Clone() {
      return new AssetFieldTypeEnum(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AssetFieldTypeEnum);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AssetFieldTypeEnum other) {
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
    public void MergeFrom(AssetFieldTypeEnum other) {
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
    /// <summary>Container for nested types declared in the AssetFieldTypeEnum message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Enum describing the possible placements of an asset.
      /// </summary>
      public enum AssetFieldType {
        /// <summary>
        /// Not specified.
        /// </summary>
        [pbr::OriginalName("UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Used for return value only. Represents value unknown in this version.
        /// </summary>
        [pbr::OriginalName("UNKNOWN")] Unknown = 1,
        /// <summary>
        /// The asset is linked for use as a headline.
        /// </summary>
        [pbr::OriginalName("HEADLINE")] Headline = 2,
        /// <summary>
        /// The asset is linked for use as a description.
        /// </summary>
        [pbr::OriginalName("DESCRIPTION")] Description = 3,
        /// <summary>
        /// The asset is linked for use as mandatory ad text.
        /// </summary>
        [pbr::OriginalName("MANDATORY_AD_TEXT")] MandatoryAdText = 4,
        /// <summary>
        /// The asset is linked for use as a marketing image.
        /// </summary>
        [pbr::OriginalName("MARKETING_IMAGE")] MarketingImage = 5,
        /// <summary>
        /// The asset is linked for use as a media bundle.
        /// </summary>
        [pbr::OriginalName("MEDIA_BUNDLE")] MediaBundle = 6,
        /// <summary>
        /// The asset is linked for use as a YouTube video.
        /// </summary>
        [pbr::OriginalName("YOUTUBE_VIDEO")] YoutubeVideo = 7,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
