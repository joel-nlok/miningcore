using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Miningcore.Blockchain.Ethereum;
using Miningcore.Configuration;
using Miningcore.DaemonInterface;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using ZeroMQ;

namespace Miningcore.Tests.DaemonInterface
{
    public class MockDaemonClient : IDaemonClient
    {
        public void Configure(DaemonEndpointConfig[] endPoints, string digestAuthRealm = null)
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<JToken>[]> ExecuteCmdAllAsync(ILogger logger, string method)
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<TResponse>[]> ExecuteCmdAllAsync<TResponse>(ILogger logger, string method, object payload = null,
            JsonSerializerSettings payloadJsonSerializerSettings = null)
            where TResponse : class
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<JToken>> ExecuteCmdAnyAsync(ILogger logger, string method, bool throwOnError = false)
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<TResponse>> ExecuteCmdAnyAsync<TResponse>(ILogger logger, string method, object payload = null,
            JsonSerializerSettings payloadJsonSerializerSettings = null, bool throwOnError = false)
            where TResponse : class
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<TResponse>> ExecuteCmdAnyAsync<TResponse>(ILogger logger, CancellationToken ct, string method, object payload = null,
            JsonSerializerSettings payloadJsonSerializerSettings = null, bool throwOnError = false)
            where TResponse : class
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<JToken>> ExecuteCmdSingleAsync(ILogger logger, string method)
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<TResponse>> ExecuteCmdSingleAsync<TResponse>(ILogger logger, string method, object payload = null,
            JsonSerializerSettings payloadJsonSerializerSettings = null)
            where TResponse : class
        {
            return Task.FromResult(method switch
            {
                EthCommands.GetPeerCount => new DaemonResponse<TResponse>
                {
                    Response = (TResponse) ($"0x{5:X}" as object)
                },
                _ => throw new NotImplementedException()
            }
            );
        }

        public Task<DaemonResponse<TResponse>> ExecuteCmdSingleAsync<TResponse>(ILogger logger, CancellationToken ct, string method, object payload = null,
            JsonSerializerSettings payloadJsonSerializerSettings = null)
            where TResponse : class
        {
            throw new NotImplementedException();
        }

        public Task<DaemonResponse<JToken>[]> ExecuteBatchAnyAsync(ILogger logger, params DaemonCmd[] batch)
        {
            throw new NotImplementedException();
        }

        public IObservable<byte[]> WebsocketSubscribe(ILogger logger, Dictionary<DaemonEndpointConfig, (int Port, string HttpPath, bool Ssl)> portMap, string method,
            object payload = null, JsonSerializerSettings payloadJsonSerializerSettings = null)
        {
            throw new NotImplementedException();
        }

        IObservable<ZMessage> IDaemonClient.ZmqSubscribe(ILogger logger, Dictionary<DaemonEndpointConfig, (string Socket, string Topic)> portMap)
        {
            throw new NotImplementedException();
        }
    }
}
