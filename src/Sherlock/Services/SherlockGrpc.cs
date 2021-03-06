// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Sherlock.proto
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Sherlock.Services {
  public static partial class SherlockService
  {
    static readonly string __ServiceName = "Sherlock.SherlockService";

    static readonly grpc::Marshaller<global::Sherlock.Services.ClearRequest> __Marshaller_ClearRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.ClearRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sherlock.Services.ClearResponse> __Marshaller_ClearResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.ClearResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sherlock.Services.LogBatch> __Marshaller_LogBatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.LogBatch.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sherlock.Services.TrackLogsResponse> __Marshaller_TrackLogsResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.TrackLogsResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sherlock.Services.MessagesBatch> __Marshaller_MessagesBatch = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.MessagesBatch.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sherlock.Services.TrackMessagesResponse> __Marshaller_TrackMessagesResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.TrackMessagesResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sherlock.Services.TrackedState> __Marshaller_TrackedState = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.TrackedState.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Sherlock.Services.TrackStateResponse> __Marshaller_TrackStateResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Sherlock.Services.TrackStateResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Sherlock.Services.ClearRequest, global::Sherlock.Services.ClearResponse> __Method_Clear = new grpc::Method<global::Sherlock.Services.ClearRequest, global::Sherlock.Services.ClearResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Clear",
        __Marshaller_ClearRequest,
        __Marshaller_ClearResponse);

    static readonly grpc::Method<global::Sherlock.Services.LogBatch, global::Sherlock.Services.TrackLogsResponse> __Method_TrackLogs = new grpc::Method<global::Sherlock.Services.LogBatch, global::Sherlock.Services.TrackLogsResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "TrackLogs",
        __Marshaller_LogBatch,
        __Marshaller_TrackLogsResponse);

    static readonly grpc::Method<global::Sherlock.Services.MessagesBatch, global::Sherlock.Services.TrackMessagesResponse> __Method_TrackMessages = new grpc::Method<global::Sherlock.Services.MessagesBatch, global::Sherlock.Services.TrackMessagesResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "TrackMessages",
        __Marshaller_MessagesBatch,
        __Marshaller_TrackMessagesResponse);

    static readonly grpc::Method<global::Sherlock.Services.TrackedState, global::Sherlock.Services.TrackStateResponse> __Method_TrackState = new grpc::Method<global::Sherlock.Services.TrackedState, global::Sherlock.Services.TrackStateResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "TrackState",
        __Marshaller_TrackedState,
        __Marshaller_TrackStateResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Sherlock.Services.SherlockReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SherlockService</summary>
    public abstract partial class SherlockServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Sherlock.Services.ClearResponse> Clear(global::Sherlock.Services.ClearRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Sherlock.Services.TrackLogsResponse> TrackLogs(grpc::IAsyncStreamReader<global::Sherlock.Services.LogBatch> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Sherlock.Services.TrackMessagesResponse> TrackMessages(grpc::IAsyncStreamReader<global::Sherlock.Services.MessagesBatch> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Sherlock.Services.TrackStateResponse> TrackState(grpc::IAsyncStreamReader<global::Sherlock.Services.TrackedState> requestStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for SherlockService</summary>
    public partial class SherlockServiceClient : grpc::ClientBase<SherlockServiceClient>
    {
      /// <summary>Creates a new client for SherlockService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public SherlockServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for SherlockService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public SherlockServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected SherlockServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected SherlockServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Sherlock.Services.ClearResponse Clear(global::Sherlock.Services.ClearRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Clear(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Sherlock.Services.ClearResponse Clear(global::Sherlock.Services.ClearRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Clear, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Sherlock.Services.ClearResponse> ClearAsync(global::Sherlock.Services.ClearRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ClearAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Sherlock.Services.ClearResponse> ClearAsync(global::Sherlock.Services.ClearRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Clear, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::Sherlock.Services.LogBatch, global::Sherlock.Services.TrackLogsResponse> TrackLogs(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return TrackLogs(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Sherlock.Services.LogBatch, global::Sherlock.Services.TrackLogsResponse> TrackLogs(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_TrackLogs, null, options);
      }
      public virtual grpc::AsyncClientStreamingCall<global::Sherlock.Services.MessagesBatch, global::Sherlock.Services.TrackMessagesResponse> TrackMessages(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return TrackMessages(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Sherlock.Services.MessagesBatch, global::Sherlock.Services.TrackMessagesResponse> TrackMessages(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_TrackMessages, null, options);
      }
      public virtual grpc::AsyncClientStreamingCall<global::Sherlock.Services.TrackedState, global::Sherlock.Services.TrackStateResponse> TrackState(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return TrackState(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Sherlock.Services.TrackedState, global::Sherlock.Services.TrackStateResponse> TrackState(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_TrackState, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override SherlockServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new SherlockServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SherlockServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Clear, serviceImpl.Clear)
          .AddMethod(__Method_TrackLogs, serviceImpl.TrackLogs)
          .AddMethod(__Method_TrackMessages, serviceImpl.TrackMessages)
          .AddMethod(__Method_TrackState, serviceImpl.TrackState).Build();
    }

  }
}
#endregion
