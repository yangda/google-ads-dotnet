// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/mobile_device_constant_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/mobile_device_constant_service.proto</summary>
  public static partial class MobileDeviceConstantServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/mobile_device_constant_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MobileDeviceConstantServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9tb2JpbGVfZGV2",
            "aWNlX2NvbnN0YW50X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYzLnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNv",
            "dXJjZXMvbW9iaWxlX2RldmljZV9jb25zdGFudC5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8iPAoeR2V0TW9iaWxl",
            "RGV2aWNlQ29uc3RhbnRSZXF1ZXN0EhoKDXJlc291cmNlX25hbWUYASABKAlC",
            "A+BBAjKWAgobTW9iaWxlRGV2aWNlQ29uc3RhbnRTZXJ2aWNlEtkBChdHZXRN",
            "b2JpbGVEZXZpY2VDb25zdGFudBJALmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LnNlcnZpY2VzLkdldE1vYmlsZURldmljZUNvbnN0YW50UmVxdWVzdBo3Lmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNlcy5Nb2JpbGVEZXZpY2VD",
            "b25zdGFudCJDgtPkkwItEisvdjMve3Jlc291cmNlX25hbWU9bW9iaWxlRGV2",
            "aWNlQ29uc3RhbnRzLyp92kENcmVzb3VyY2VfbmFtZRobykEYZ29vZ2xlYWRz",
            "Lmdvb2dsZWFwaXMuY29tQocCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMu",
            "djMuc2VydmljZXNCIE1vYmlsZURldmljZUNvbnN0YW50U2VydmljZVByb3Rv",
            "UAFaSGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRz",
            "L2dvb2dsZWFkcy92My9zZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2ds",
            "ZS5BZHMuR29vZ2xlQWRzLlYzLlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29n",
            "bGVBZHNcVjNcU2VydmljZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpW",
            "Mzo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.MobileDeviceConstantReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetMobileDeviceConstantRequest), global::Google.Ads.GoogleAds.V3.Services.GetMobileDeviceConstantRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [MobileDeviceConstantService.GetMobileDeviceConstant][google.ads.googleads.v3.services.MobileDeviceConstantService.GetMobileDeviceConstant].
  /// </summary>
  public sealed partial class GetMobileDeviceConstantRequest : pb::IMessage<GetMobileDeviceConstantRequest> {
    private static readonly pb::MessageParser<GetMobileDeviceConstantRequest> _parser = new pb::MessageParser<GetMobileDeviceConstantRequest>(() => new GetMobileDeviceConstantRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetMobileDeviceConstantRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.MobileDeviceConstantServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMobileDeviceConstantRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMobileDeviceConstantRequest(GetMobileDeviceConstantRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetMobileDeviceConstantRequest Clone() {
      return new GetMobileDeviceConstantRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. Resource name of the mobile device to fetch.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetMobileDeviceConstantRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetMobileDeviceConstantRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetMobileDeviceConstantRequest other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
