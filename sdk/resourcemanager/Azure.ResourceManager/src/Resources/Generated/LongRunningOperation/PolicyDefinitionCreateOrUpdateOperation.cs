// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> This operation creates or updates a policy definition in the given subscription with the given name. </summary>
    public partial class PolicyDefinitionCreateOrUpdateOperation : Operation<SubscriptionPolicyDefinition>
    {
        private readonly OperationOrResponseInternals<SubscriptionPolicyDefinition> _operation;

        /// <summary> Initializes a new instance of PolicyDefinitionCreateOrUpdateOperation for mocking. </summary>
        protected PolicyDefinitionCreateOrUpdateOperation()
        {
        }

        internal PolicyDefinitionCreateOrUpdateOperation(ArmResource operationsBase, Response<PolicyDefinitionData> response)
        {
            _operation = new OperationOrResponseInternals<SubscriptionPolicyDefinition>(Response.FromValue(new SubscriptionPolicyDefinition(operationsBase, response.Value), response.GetRawResponse()));
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override SubscriptionPolicyDefinition Value => _operation.Value;

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
        public override ValueTask<Response<SubscriptionPolicyDefinition>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<SubscriptionPolicyDefinition>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);
    }
}
