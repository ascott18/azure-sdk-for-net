// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.CosmosDB;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Update RUs per second of an Azure Cosmos DB Cassandra Keyspace. </summary>
    public partial class CassandraResourceUpdateCassandraKeyspaceThroughputOperation : Operation<DatabaseAccountCassandraKeyspaceThroughputSetting>, IOperationSource<DatabaseAccountCassandraKeyspaceThroughputSetting>
    {
        private readonly OperationInternals<DatabaseAccountCassandraKeyspaceThroughputSetting> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of CassandraResourceUpdateCassandraKeyspaceThroughputOperation for mocking. </summary>
        protected CassandraResourceUpdateCassandraKeyspaceThroughputOperation()
        {
        }

        internal CassandraResourceUpdateCassandraKeyspaceThroughputOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<DatabaseAccountCassandraKeyspaceThroughputSetting>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "CassandraResourceUpdateCassandraKeyspaceThroughputOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override DatabaseAccountCassandraKeyspaceThroughputSetting Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DatabaseAccountCassandraKeyspaceThroughputSetting>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<DatabaseAccountCassandraKeyspaceThroughputSetting>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        DatabaseAccountCassandraKeyspaceThroughputSetting IOperationSource<DatabaseAccountCassandraKeyspaceThroughputSetting>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return new DatabaseAccountCassandraKeyspaceThroughputSetting(_operationBase, ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement));
        }

        async ValueTask<DatabaseAccountCassandraKeyspaceThroughputSetting> IOperationSource<DatabaseAccountCassandraKeyspaceThroughputSetting>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return new DatabaseAccountCassandraKeyspaceThroughputSetting(_operationBase, ThroughputSettingsData.DeserializeThroughputSettingsData(document.RootElement));
        }
    }
}
