// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v11/resources/customer_manager_link.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.GoogleAds.V11.Resources {

  /// <summary>Holder for reflection information generated from google/ads/googleads/v11/resources/customer_manager_link.proto</summary>
  public static partial class CustomerManagerLinkReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/googleads/v11/resources/customer_manager_link.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerManagerLinkReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cj5nb29nbGUvYWRzL2dvb2dsZWFkcy92MTEvcmVzb3VyY2VzL2N1c3RvbWVy",
            "X21hbmFnZXJfbGluay5wcm90bxIiZ29vZ2xlLmFkcy5nb29nbGVhZHMudjEx",
            "LnJlc291cmNlcxo4Z29vZ2xlL2Fkcy9nb29nbGVhZHMvdjExL2VudW1zL21h",
            "bmFnZXJfbGlua19zdGF0dXMucHJvdG8aH2dvb2dsZS9hcGkvZmllbGRfYmVo",
            "YXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3VyY2UucHJvdG8i3AMKE0N1",
            "c3RvbWVyTWFuYWdlckxpbmsSSwoNcmVzb3VyY2VfbmFtZRgBIAEoCUI04EEF",
            "+kEuCixnb29nbGVhZHMuZ29vZ2xlYXBpcy5jb20vQ3VzdG9tZXJNYW5hZ2Vy",
            "TGluaxJIChBtYW5hZ2VyX2N1c3RvbWVyGAYgASgJQingQQP6QSMKIWdvb2ds",
            "ZWFkcy5nb29nbGVhcGlzLmNvbS9DdXN0b21lckgAiAEBEiEKD21hbmFnZXJf",
            "bGlua19pZBgHIAEoA0ID4EEDSAGIAQESVwoGc3RhdHVzGAUgASgOMkcuZ29v",
            "Z2xlLmFkcy5nb29nbGVhZHMudjExLmVudW1zLk1hbmFnZXJMaW5rU3RhdHVz",
            "RW51bS5NYW5hZ2VyTGlua1N0YXR1czqIAepBhAEKLGdvb2dsZWFkcy5nb29n",
            "bGVhcGlzLmNvbS9DdXN0b21lck1hbmFnZXJMaW5rElRjdXN0b21lcnMve2N1",
            "c3RvbWVyX2lkfS9jdXN0b21lck1hbmFnZXJMaW5rcy97bWFuYWdlcl9jdXN0",
            "b21lcl9pZH1+e21hbmFnZXJfbGlua19pZH1CEwoRX21hbmFnZXJfY3VzdG9t",
            "ZXJCEgoQX21hbmFnZXJfbGlua19pZEKKAgomY29tLmdvb2dsZS5hZHMuZ29v",
            "Z2xlYWRzLnYxMS5yZXNvdXJjZXNCGEN1c3RvbWVyTWFuYWdlckxpbmtQcm90",
            "b1ABWktnb29nbGUuZ29sYW5nLm9yZy9nZW5wcm90by9nb29nbGVhcGlzL2Fk",
            "cy9nb29nbGVhZHMvdjExL3Jlc291cmNlcztyZXNvdXJjZXOiAgNHQUGqAiJH",
            "b29nbGUuQWRzLkdvb2dsZUFkcy5WMTEuUmVzb3VyY2VzygIiR29vZ2xlXEFk",
            "c1xHb29nbGVBZHNcVjExXFJlc291cmNlc+oCJkdvb2dsZTo6QWRzOjpHb29n",
            "bGVBZHM6OlYxMTo6UmVzb3VyY2VzYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.GoogleAds.V11.Resources.CustomerManagerLink), global::Google.Ads.GoogleAds.V11.Resources.CustomerManagerLink.Parser, new[]{ "ResourceName", "ManagerCustomer", "ManagerLinkId", "Status" }, new[]{ "ManagerCustomer", "ManagerLinkId" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents customer-manager link relationship.
  /// </summary>
  public sealed partial class CustomerManagerLink : pb::IMessage<CustomerManagerLink>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerManagerLink> _parser = new pb::MessageParser<CustomerManagerLink>(() => new CustomerManagerLink());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerManagerLink> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.GoogleAds.V11.Resources.CustomerManagerLinkReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerManagerLink() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerManagerLink(CustomerManagerLink other) : this() {
      _hasBits0 = other._hasBits0;
      resourceName_ = other.resourceName_;
      managerCustomer_ = other.managerCustomer_;
      managerLinkId_ = other.managerLinkId_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerManagerLink Clone() {
      return new CustomerManagerLink(this);
    }

    /// <summary>Field number for the "resource_name" field.</summary>
    public const int ResourceNameFieldNumber = 1;
    private string resourceName_ = "";
    /// <summary>
    /// Immutable. Name of the resource.
    /// CustomerManagerLink resource names have the form:
    /// `customers/{customer_id}/customerManagerLinks/{manager_customer_id}~{manager_link_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ResourceName {
      get { return resourceName_; }
      set {
        resourceName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "manager_customer" field.</summary>
    public const int ManagerCustomerFieldNumber = 6;
    private string managerCustomer_;
    /// <summary>
    /// Output only. The manager customer linked to the customer.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ManagerCustomer {
      get { return managerCustomer_ ?? ""; }
      set {
        managerCustomer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "manager_customer" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasManagerCustomer {
      get { return managerCustomer_ != null; }
    }
    /// <summary>Clears the value of the "manager_customer" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearManagerCustomer() {
      managerCustomer_ = null;
    }

    /// <summary>Field number for the "manager_link_id" field.</summary>
    public const int ManagerLinkIdFieldNumber = 7;
    private long managerLinkId_;
    /// <summary>
    /// Output only. ID of the customer-manager link. This field is read only.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long ManagerLinkId {
      get { if ((_hasBits0 & 1) != 0) { return managerLinkId_; } else { return 0L; } }
      set {
        _hasBits0 |= 1;
        managerLinkId_ = value;
      }
    }
    /// <summary>Gets whether the "manager_link_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasManagerLinkId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "manager_link_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearManagerLinkId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus status_ = global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified;
    /// <summary>
    /// Status of the link between the customer and the manager.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerManagerLink);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerManagerLink other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ResourceName != other.ResourceName) return false;
      if (ManagerCustomer != other.ManagerCustomer) return false;
      if (ManagerLinkId != other.ManagerLinkId) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (ResourceName.Length != 0) hash ^= ResourceName.GetHashCode();
      if (HasManagerCustomer) hash ^= ManagerCustomer.GetHashCode();
      if (HasManagerLinkId) hash ^= ManagerLinkId.GetHashCode();
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) hash ^= Status.GetHashCode();
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasManagerCustomer) {
        output.WriteRawTag(50);
        output.WriteString(ManagerCustomer);
      }
      if (HasManagerLinkId) {
        output.WriteRawTag(56);
        output.WriteInt64(ManagerLinkId);
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
      if (ResourceName.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(ResourceName);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
      }
      if (HasManagerCustomer) {
        output.WriteRawTag(50);
        output.WriteString(ManagerCustomer);
      }
      if (HasManagerLinkId) {
        output.WriteRawTag(56);
        output.WriteInt64(ManagerLinkId);
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
      if (ResourceName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ResourceName);
      }
      if (HasManagerCustomer) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ManagerCustomer);
      }
      if (HasManagerLinkId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(ManagerLinkId);
      }
      if (Status != global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerManagerLink other) {
      if (other == null) {
        return;
      }
      if (other.ResourceName.Length != 0) {
        ResourceName = other.ResourceName;
      }
      if (other.HasManagerCustomer) {
        ManagerCustomer = other.ManagerCustomer;
      }
      if (other.HasManagerLinkId) {
        ManagerLinkId = other.ManagerLinkId;
      }
      if (other.Status != global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus.Unspecified) {
        Status = other.Status;
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus) input.ReadEnum();
            break;
          }
          case 50: {
            ManagerCustomer = input.ReadString();
            break;
          }
          case 56: {
            ManagerLinkId = input.ReadInt64();
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
          case 10: {
            ResourceName = input.ReadString();
            break;
          }
          case 40: {
            Status = (global::Google.Ads.GoogleAds.V11.Enums.ManagerLinkStatusEnum.Types.ManagerLinkStatus) input.ReadEnum();
            break;
          }
          case 50: {
            ManagerCustomer = input.ReadString();
            break;
          }
          case 56: {
            ManagerLinkId = input.ReadInt64();
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
