// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/ad_group_simulation_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/ad_group_simulation_service.proto</summary>
  public static partial class AdGroupSimulationServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/ad_group_simulation_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AdGroupSimulationServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkJnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9hZF9ncm91cF9z",
            "aW11bGF0aW9uX3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYzLnNlcnZpY2VzGjtnb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNvdXJj",
            "ZXMvYWRfZ3JvdXBfc2ltdWxhdGlvbi5wcm90bxocZ29vZ2xlL2FwaS9hbm5v",
            "dGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8aH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8iOQobR2V0QWRHcm91cFNpbXVs",
            "YXRpb25SZXF1ZXN0EhoKDXJlc291cmNlX25hbWUYASABKAlCA+BBAjKTAgoY",
            "QWRHcm91cFNpbXVsYXRpb25TZXJ2aWNlEtkBChRHZXRBZEdyb3VwU2ltdWxh",
            "dGlvbhI9Lmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnNlcnZpY2VzLkdldEFk",
            "R3JvdXBTaW11bGF0aW9uUmVxdWVzdBo0Lmdvb2dsZS5hZHMuZ29vZ2xlYWRz",
            "LnYzLnJlc291cmNlcy5BZEdyb3VwU2ltdWxhdGlvbiJMgtPkkwI2EjQvdjMv",
            "e3Jlc291cmNlX25hbWU9Y3VzdG9tZXJzLyovYWRHcm91cFNpbXVsYXRpb25z",
            "Lyp92kENcmVzb3VyY2VfbmFtZRobykEYZ29vZ2xlYWRzLmdvb2dsZWFwaXMu",
            "Y29tQoQCCiRjb20uZ29vZ2xlLmFkcy5nb29nbGVhZHMudjMuc2VydmljZXNC",
            "HUFkR3JvdXBTaW11bGF0aW9uU2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xh",
            "bmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9z",
            "ZXJ2aWNlcztzZXJ2aWNlc6ICA0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRz",
            "LlYzLlNlcnZpY2VzygIgR29vZ2xlXEFkc1xHb29nbGVBZHNcVjNcU2Vydmlj",
            "ZXPqAiRHb29nbGU6OkFkczo6R29vZ2xlQWRzOjpWMzo6U2VydmljZXNiBnBy",
            "b3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.AdGroupSimulationReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetAdGroupSimulationRequest), global::Google.Ads.GoogleAds.V3.Services.GetAdGroupSimulationRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [AdGroupSimulationService.GetAdGroupSimulation][google.ads.googleads.v3.services.AdGroupSimulationService.GetAdGroupSimulation].
  /// </summary>
  public sealed partial class GetAdGroupSimulationRequest : pb::IMessage<GetAdGroupSimulationRequest> {
    private static readonly pb::MessageParser<GetAdGroupSimulationRequest> _parser = new pb::MessageParser<GetAdGroupSimulationRequest>(() => new GetAdGroupSimulationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetAdGroupSimulationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.AdGroupSimulationServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupSimulationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupSimulationRequest(GetAdGroupSimulationRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetAdGroupSimulationRequest Clone() {
      return new GetAdGroupSimulationRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the ad group simulation to fetch.
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
      return Equals(other as GetAdGroupSimulationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetAdGroupSimulationRequest other) {
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
    public void MergeFrom(GetAdGroupSimulationRequest other) {
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
