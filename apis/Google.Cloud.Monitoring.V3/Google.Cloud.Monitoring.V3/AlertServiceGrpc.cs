// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/monitoring/v3/alert_service.proto
// </auto-generated>
// Original file comments:
// Copyright 2018 Google LLC
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
#pragma warning disable 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Google.Cloud.Monitoring.V3 {
  /// <summary>
  /// The AlertPolicyService API is used to manage (list, create, delete,
  /// edit) alert policies in Stackdriver Monitoring. An alerting policy is
  /// a description of the conditions under which some aspect of your
  /// system is considered to be "unhealthy" and the ways to notify
  /// people or services about this state. In addition to using this API, alert
  /// policies can also be managed through
  /// [Stackdriver Monitoring](https://cloud.google.com/monitoring/docs/),
  /// which can be reached by clicking the "Monitoring" tab in
  /// [Cloud Console](https://console.cloud.google.com/).
  /// </summary>
  public static partial class AlertPolicyService
  {
    static readonly string __ServiceName = "google.monitoring.v3.AlertPolicyService";

    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest> __Marshaller_ListAlertPoliciesRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse> __Marshaller_ListAlertPoliciesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest> __Marshaller_GetAlertPolicyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.AlertPolicy> __Marshaller_AlertPolicy = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.AlertPolicy.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest> __Marshaller_CreateAlertPolicyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest> __Marshaller_DeleteAlertPolicyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest> __Marshaller_UpdateAlertPolicyRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest, global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse> __Method_ListAlertPolicies = new grpc::Method<global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest, global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ListAlertPolicies",
        __Marshaller_ListAlertPoliciesRequest,
        __Marshaller_ListAlertPoliciesResponse);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest, global::Google.Cloud.Monitoring.V3.AlertPolicy> __Method_GetAlertPolicy = new grpc::Method<global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest, global::Google.Cloud.Monitoring.V3.AlertPolicy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetAlertPolicy",
        __Marshaller_GetAlertPolicyRequest,
        __Marshaller_AlertPolicy);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest, global::Google.Cloud.Monitoring.V3.AlertPolicy> __Method_CreateAlertPolicy = new grpc::Method<global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest, global::Google.Cloud.Monitoring.V3.AlertPolicy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateAlertPolicy",
        __Marshaller_CreateAlertPolicyRequest,
        __Marshaller_AlertPolicy);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteAlertPolicy = new grpc::Method<global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteAlertPolicy",
        __Marshaller_DeleteAlertPolicyRequest,
        __Marshaller_Empty);

    static readonly grpc::Method<global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest, global::Google.Cloud.Monitoring.V3.AlertPolicy> __Method_UpdateAlertPolicy = new grpc::Method<global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest, global::Google.Cloud.Monitoring.V3.AlertPolicy>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateAlertPolicy",
        __Marshaller_UpdateAlertPolicyRequest,
        __Marshaller_AlertPolicy);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Cloud.Monitoring.V3.AlertServiceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of AlertPolicyService</summary>
    public abstract partial class AlertPolicyServiceBase
    {
      /// <summary>
      /// Lists the existing alerting policies for the project.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse> ListAlertPolicies(global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Gets a single alerting policy.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.AlertPolicy> GetAlertPolicy(global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Creates a new alerting policy.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.AlertPolicy> CreateAlertPolicy(global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Deletes an alerting policy.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAlertPolicy(global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// Updates an alerting policy. You can either replace the entire policy with
      /// a new one or replace only certain fields in the current alerting policy by
      /// specifying the fields to be updated via `updateMask`. Returns the
      /// updated alerting policy.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Google.Cloud.Monitoring.V3.AlertPolicy> UpdateAlertPolicy(global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for AlertPolicyService</summary>
    public partial class AlertPolicyServiceClient : grpc::ClientBase<AlertPolicyServiceClient>
    {
      /// <summary>Creates a new client for AlertPolicyService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public AlertPolicyServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for AlertPolicyService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public AlertPolicyServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected AlertPolicyServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected AlertPolicyServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Lists the existing alerting policies for the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse ListAlertPolicies(global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAlertPolicies(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the existing alerting policies for the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse ListAlertPolicies(global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ListAlertPolicies, null, options, request);
      }
      /// <summary>
      /// Lists the existing alerting policies for the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse> ListAlertPoliciesAsync(global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return ListAlertPoliciesAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Lists the existing alerting policies for the project.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.ListAlertPoliciesResponse> ListAlertPoliciesAsync(global::Google.Cloud.Monitoring.V3.ListAlertPoliciesRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ListAlertPolicies, null, options, request);
      }
      /// <summary>
      /// Gets a single alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.AlertPolicy GetAlertPolicy(global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAlertPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a single alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.AlertPolicy GetAlertPolicy(global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetAlertPolicy, null, options, request);
      }
      /// <summary>
      /// Gets a single alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.AlertPolicy> GetAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetAlertPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Gets a single alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.AlertPolicy> GetAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.GetAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetAlertPolicy, null, options, request);
      }
      /// <summary>
      /// Creates a new alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.AlertPolicy CreateAlertPolicy(global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAlertPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.AlertPolicy CreateAlertPolicy(global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CreateAlertPolicy, null, options, request);
      }
      /// <summary>
      /// Creates a new alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.AlertPolicy> CreateAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CreateAlertPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Creates a new alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.AlertPolicy> CreateAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.CreateAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CreateAlertPolicy, null, options, request);
      }
      /// <summary>
      /// Deletes an alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAlertPolicy(global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAlertPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Protobuf.WellKnownTypes.Empty DeleteAlertPolicy(global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteAlertPolicy, null, options, request);
      }
      /// <summary>
      /// Deletes an alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return DeleteAlertPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Deletes an alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Protobuf.WellKnownTypes.Empty> DeleteAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.DeleteAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteAlertPolicy, null, options, request);
      }
      /// <summary>
      /// Updates an alerting policy. You can either replace the entire policy with
      /// a new one or replace only certain fields in the current alerting policy by
      /// specifying the fields to be updated via `updateMask`. Returns the
      /// updated alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.AlertPolicy UpdateAlertPolicy(global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAlertPolicy(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an alerting policy. You can either replace the entire policy with
      /// a new one or replace only certain fields in the current alerting policy by
      /// specifying the fields to be updated via `updateMask`. Returns the
      /// updated alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Google.Cloud.Monitoring.V3.AlertPolicy UpdateAlertPolicy(global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpdateAlertPolicy, null, options, request);
      }
      /// <summary>
      /// Updates an alerting policy. You can either replace the entire policy with
      /// a new one or replace only certain fields in the current alerting policy by
      /// specifying the fields to be updated via `updateMask`. Returns the
      /// updated alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.AlertPolicy> UpdateAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UpdateAlertPolicyAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Updates an alerting policy. You can either replace the entire policy with
      /// a new one or replace only certain fields in the current alerting policy by
      /// specifying the fields to be updated via `updateMask`. Returns the
      /// updated alerting policy.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Google.Cloud.Monitoring.V3.AlertPolicy> UpdateAlertPolicyAsync(global::Google.Cloud.Monitoring.V3.UpdateAlertPolicyRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpdateAlertPolicy, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override AlertPolicyServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new AlertPolicyServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(AlertPolicyServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ListAlertPolicies, serviceImpl.ListAlertPolicies)
          .AddMethod(__Method_GetAlertPolicy, serviceImpl.GetAlertPolicy)
          .AddMethod(__Method_CreateAlertPolicy, serviceImpl.CreateAlertPolicy)
          .AddMethod(__Method_DeleteAlertPolicy, serviceImpl.DeleteAlertPolicy)
          .AddMethod(__Method_UpdateAlertPolicy, serviceImpl.UpdateAlertPolicy).Build();
    }

  }
}
#endregion
