// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/googleads/v3/services/campaign_label_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2020 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Ads.GoogleAds.V3.Services {
  /// <summary>
  /// Service to manage labels on campaigns.
  /// </summary>
  public static partial class CampaignLabelService
  {
    static readonly string __ServiceName = "google.ads.googleads.v3.services.CampaignLabelService";

    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest> __Marshaller_google_ads_googleads_v3_services_GetCampaignLabelRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel> __Marshaller_google_ads_googleads_v3_resources_CampaignLabel = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest> __Marshaller_google_ads_googleads_v3_services_MutateCampaignLabelsRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse> __Marshaller_google_ads_googleads_v3_services_MutateCampaignLabelsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest, global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel> __Method_GetCampaignLabel = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest, global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCampaignLabel",
        __Marshaller_google_ads_googleads_v3_services_GetCampaignLabelRequest,
        __Marshaller_google_ads_googleads_v3_resources_CampaignLabel);

    static readonly grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse> __Method_MutateCampaignLabels = new grpc::Method<global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest, global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "MutateCampaignLabels",
        __Marshaller_google_ads_googleads_v3_services_MutateCampaignLabelsRequest,
        __Marshaller_google_ads_googleads_v3_services_MutateCampaignLabelsResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Ads.GoogleAds.V3.Services.CampaignLabelServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CampaignLabelService</summary>
    public abstract partial class CampaignLabelServiceBase
    {
      /// <summary>
      /// Returns the requested campaign-label relationship in full detail.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel> GetCampaignLabel(global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates and removes campaign-label relationships.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse> MutateCampaignLabels(global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for CampaignLabelService</summary>
    public partial class CampaignLabelServiceClient : grpc::ClientBase<CampaignLabelServiceClient>
    {
      /// <summary>Creates a new client for CampaignLabelService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public CampaignLabelServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CampaignLabelService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public CampaignLabelServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected CampaignLabelServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected CampaignLabelServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Returns the requested campaign-label relationship in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel GetCampaignLabel(global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCampaignLabel(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign-label relationship in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel GetCampaignLabel(global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCampaignLabel, null, options, request);
      }
      /// <summary>
      /// Returns the requested campaign-label relationship in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel> GetCampaignLabelAsync(global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCampaignLabelAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Returns the requested campaign-label relationship in full detail.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Resources.CampaignLabel> GetCampaignLabelAsync(global::Google.Ads.GoogleAds.V3.Services.GetCampaignLabelRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCampaignLabel, null, options, request);
      }
      /// <summary>
      /// Creates and removes campaign-label relationships.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse MutateCampaignLabels(global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignLabels(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes campaign-label relationships.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse MutateCampaignLabels(global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_MutateCampaignLabels, null, options, request);
      }
      /// <summary>
      /// Creates and removes campaign-label relationships.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse> MutateCampaignLabelsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return MutateCampaignLabelsAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates and removes campaign-label relationships.
      /// Operation statuses are returned.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsResponse> MutateCampaignLabelsAsync(global::Google.Ads.GoogleAds.V3.Services.MutateCampaignLabelsRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_MutateCampaignLabels, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override CampaignLabelServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CampaignLabelServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(CampaignLabelServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCampaignLabel, serviceImpl.GetCampaignLabel)
          .AddMethod(__Method_MutateCampaignLabels, serviceImpl.MutateCampaignLabels).Build();
    }

    /// <summary>Register service method implementations with a service binder. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CampaignLabelServiceBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCampaignLabel, serviceImpl.GetCampaignLabel);
      serviceBinder.AddMethod(__Method_MutateCampaignLabels, serviceImpl.MutateCampaignLabels);
    }

  }
}
#endregion
