// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/campaign_audience_view_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V3.Services {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v3/services/campaign_audience_view_service.proto</summary>
  public static partial class CampaignAudienceViewServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v3/services/campaign_audience_view_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CampaignAudienceViewServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CkVnb29nbGUvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcy9jYW1wYWlnbl9h",
            "dWRpZW5jZV92aWV3X3NlcnZpY2UucHJvdG8SIGdvb2dsZS5hZHMuZ29vZ2xl",
            "YWRzLnYzLnNlcnZpY2VzGj5nb29nbGUvYWRzL2dvb2dsZWFkcy92My9yZXNv",
            "dXJjZXMvY2FtcGFpZ25fYXVkaWVuY2Vfdmlldy5wcm90bxocZ29vZ2xlL2Fw",
            "aS9hbm5vdGF0aW9ucy5wcm90bxoXZ29vZ2xlL2FwaS9jbGllbnQucHJvdG8a",
            "H2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8iPAoeR2V0Q2FtcGFp",
            "Z25BdWRpZW5jZVZpZXdSZXF1ZXN0EhoKDXJlc291cmNlX25hbWUYASABKAlC",
            "A+BBAjKiAgobQ2FtcGFpZ25BdWRpZW5jZVZpZXdTZXJ2aWNlEuUBChdHZXRD",
            "YW1wYWlnbkF1ZGllbmNlVmlldxJALmdvb2dsZS5hZHMuZ29vZ2xlYWRzLnYz",
            "LnNlcnZpY2VzLkdldENhbXBhaWduQXVkaWVuY2VWaWV3UmVxdWVzdBo3Lmdv",
            "b2dsZS5hZHMuZ29vZ2xlYWRzLnYzLnJlc291cmNlcy5DYW1wYWlnbkF1ZGll",
            "bmNlVmlldyJPgtPkkwI5EjcvdjMve3Jlc291cmNlX25hbWU9Y3VzdG9tZXJz",
            "LyovY2FtcGFpZ25BdWRpZW5jZVZpZXdzLyp92kENcmVzb3VyY2VfbmFtZRob",
            "ykEYZ29vZ2xlYWRzLmdvb2dsZWFwaXMuY29tQocCCiRjb20uZ29vZ2xlLmFk",
            "cy5nb29nbGVhZHMudjMuc2VydmljZXNCIENhbXBhaWduQXVkaWVuY2VWaWV3",
            "U2VydmljZVByb3RvUAFaSGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvYWRzL2dvb2dsZWFkcy92My9zZXJ2aWNlcztzZXJ2aWNlc6IC",
            "A0dBQaoCIEdvb2dsZS5BZHMuR29vZ2xlQWRzLlYzLlNlcnZpY2VzygIgR29v",
            "Z2xlXEFkc1xHb29nbGVBZHNcVjNcU2VydmljZXPqAiRHb29nbGU6OkFkczo6",
            "R29vZ2xlQWRzOjpWMzo6U2VydmljZXNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V3.Resources.CampaignAudienceViewReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V3.Services.GetCampaignAudienceViewRequest), global::Google.Ads.GoogleAds.V3.Services.GetCampaignAudienceViewRequest.Parser, new[]{ "ResourceName" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request message for [CampaignAudienceViewService.GetCampaignAudienceView][google.ads.googleads.v3.services.CampaignAudienceViewService.GetCampaignAudienceView].
  /// </summary>
  public sealed partial class GetCampaignAudienceViewRequest : pb::IMessage<GetCampaignAudienceViewRequest> {
    private static readonly pb::MessageParser<GetCampaignAudienceViewRequest> _parser = new pb::MessageParser<GetCampaignAudienceViewRequest>(() => new GetCampaignAudienceViewRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetCampaignAudienceViewRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V3.Services.CampaignAudienceViewServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignAudienceViewRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignAudienceViewRequest(GetCampaignAudienceViewRequest other) : this() {
      resourceName_ = other.resourceName_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetCampaignAudienceViewRequest Clone() {
      return new GetCampaignAudienceViewRequest(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Required. The resource name of the campaign audience view to fetch.
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
      return Equals(other as GetCampaignAudienceViewRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetCampaignAudienceViewRequest other) {
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
    public void MergeFrom(GetCampaignAudienceViewRequest other) {
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
