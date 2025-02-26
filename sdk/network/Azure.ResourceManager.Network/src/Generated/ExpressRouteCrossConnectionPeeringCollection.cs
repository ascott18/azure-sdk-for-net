// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.Network.Models;

namespace Azure.ResourceManager.Network
{
    /// <summary> A class representing collection of ExpressRouteCrossConnectionPeering and their operations over its parent. </summary>
    public partial class ExpressRouteCrossConnectionPeeringCollection : ArmCollection, IEnumerable<ExpressRouteCrossConnectionPeering>, IAsyncEnumerable<ExpressRouteCrossConnectionPeering>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly ExpressRouteCrossConnectionPeeringsRestOperations _expressRouteCrossConnectionPeeringsRestClient;

        /// <summary> Initializes a new instance of the <see cref="ExpressRouteCrossConnectionPeeringCollection"/> class for mocking. </summary>
        protected ExpressRouteCrossConnectionPeeringCollection()
        {
        }

        /// <summary> Initializes a new instance of ExpressRouteCrossConnectionPeeringCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal ExpressRouteCrossConnectionPeeringCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _expressRouteCrossConnectionPeeringsRestClient = new ExpressRouteCrossConnectionPeeringsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => ExpressRouteCrossConnection.ResourceType;

        // Collection level operations.

        /// <summary> Creates or updates a peering in the specified ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public virtual ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation CreateOrUpdate(string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken);
                var operation = new ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response);
                if (waitForCompletion)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a peering in the specified ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="peeringParameters"> Parameters supplied to the create or update ExpressRouteCrossConnection peering operation. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> or <paramref name="peeringParameters"/> is null. </exception>
        public async virtual Task<ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation> CreateOrUpdateAsync(string peeringName, ExpressRouteCrossConnectionPeeringData peeringParameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }
            if (peeringParameters == null)
            {
                throw new ArgumentNullException(nameof(peeringParameters));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters, cancellationToken).ConfigureAwait(false);
                var operation = new ExpressRouteCrossConnectionPeeringCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _expressRouteCrossConnectionPeeringsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, peeringParameters).Request, response);
                if (waitForCompletion)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified peering for the ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCrossConnectionPeering> Get(string peeringName, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified peering for the ExpressRouteCrossConnection. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCrossConnectionPeering>> GetAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Get");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new ExpressRouteCrossConnectionPeering(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<ExpressRouteCrossConnectionPeering> GetIfExists(string peeringName, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _expressRouteCrossConnectionPeeringsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCrossConnectionPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCrossConnectionPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<ExpressRouteCrossConnectionPeering>> GetIfExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _expressRouteCrossConnectionPeeringsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<ExpressRouteCrossConnectionPeering>(null, response.GetRawResponse())
                    : Response.FromValue(new ExpressRouteCrossConnectionPeering(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public virtual Response<bool> Exists(string peeringName, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(peeringName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="peeringName"> The name of the peering. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="peeringName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string peeringName, CancellationToken cancellationToken = default)
        {
            if (peeringName == null)
            {
                throw new ArgumentNullException(nameof(peeringName));
            }

            using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(peeringName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all peerings in a specified ExpressRouteCrossConnection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ExpressRouteCrossConnectionPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ExpressRouteCrossConnectionPeering> GetAll(CancellationToken cancellationToken = default)
        {
            Page<ExpressRouteCrossConnectionPeering> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCrossConnectionPeeringsRestClient.List(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<ExpressRouteCrossConnectionPeering> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _expressRouteCrossConnectionPeeringsRestClient.ListNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all peerings in a specified ExpressRouteCrossConnection. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ExpressRouteCrossConnectionPeering" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ExpressRouteCrossConnectionPeering> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<ExpressRouteCrossConnectionPeering>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCrossConnectionPeeringsRestClient.ListAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<ExpressRouteCrossConnectionPeering>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("ExpressRouteCrossConnectionPeeringCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _expressRouteCrossConnectionPeeringsRestClient.ListNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new ExpressRouteCrossConnectionPeering(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<ExpressRouteCrossConnectionPeering> IEnumerable<ExpressRouteCrossConnectionPeering>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<ExpressRouteCrossConnectionPeering> IAsyncEnumerable<ExpressRouteCrossConnectionPeering>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, ExpressRouteCrossConnectionPeering, ExpressRouteCrossConnectionPeeringData> Construct() { }
    }
}
