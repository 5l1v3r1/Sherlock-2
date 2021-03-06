﻿using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Grpc.Core;
using Sherlock.Client;
using Sherlock.Engine.Data;
using Sherlock.Services;

namespace Sherlock.Engine.RpcServices
{
    public class SherlockService : Services.SherlockService.SherlockServiceBase
    {
        private readonly ITrackingEngine _engine;

        public SherlockService(ITrackingEngine engine)
        {
            _engine = engine;
        }

        public override async Task<TrackLogsResponse> TrackLogs(
            IAsyncStreamReader<LogBatch> requestStream,
            ServerCallContext context
        )
        {
            var clientId = context.RequestHeaders.FirstOrDefault(x => x.Key == SherlockConstants.ClientId)?.Value;

            while (await requestStream.MoveNext(CancellationToken.None).ConfigureAwait(false))
            {
                _engine.ProcessBatch(clientId, requestStream.Current.Messages);
            }

            return new TrackLogsResponse();
        }

        public override async Task<TrackMessagesResponse> TrackMessages(IAsyncStreamReader<MessagesBatch> requestStream,
            ServerCallContext context)
        {
            var clientId = context.RequestHeaders.FirstOrDefault(x => x.Key == SherlockConstants.ClientId)?.Value;

            while (await requestStream.MoveNext(CancellationToken.None).ConfigureAwait(false))
            {
                _engine.ProcessBatch(clientId, requestStream.Current.Messages);
            }

            return new TrackMessagesResponse();
        }

        public override async Task<TrackStateResponse> TrackState(
            IAsyncStreamReader<TrackedState> requestStream, ServerCallContext context)
        {
            var clientId = context.RequestHeaders.FirstOrDefault(x => x.Key == SherlockConstants.ClientId)?.Value;

            while (await requestStream.MoveNext(CancellationToken.None).ConfigureAwait(false))
            {
                _engine.ProcessSingle(clientId, requestStream.Current);
            }

            return new TrackStateResponse();
        }

        public override Task<ClearResponse> Clear(ClearRequest request, ServerCallContext context)
        {
            var clientId = context.RequestHeaders.FirstOrDefault(x => x.Key == SherlockConstants.ClientId)?.Value;

            _engine.Clear(clientId);
            return Task.FromResult(new ClearResponse());
        }
    }
}