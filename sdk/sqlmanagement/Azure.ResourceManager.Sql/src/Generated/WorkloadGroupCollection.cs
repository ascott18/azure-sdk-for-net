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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing collection of WorkloadGroup and their operations over its parent. </summary>
    public partial class WorkloadGroupCollection : ArmCollection, IEnumerable<WorkloadGroup>, IAsyncEnumerable<WorkloadGroup>

    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly WorkloadGroupsRestOperations _workloadGroupsRestClient;

        /// <summary> Initializes a new instance of the <see cref="WorkloadGroupCollection"/> class for mocking. </summary>
        protected WorkloadGroupCollection()
        {
        }

        /// <summary> Initializes a new instance of WorkloadGroupCollection class. </summary>
        /// <param name="parent"> The resource representing the parent resource. </param>
        internal WorkloadGroupCollection(ArmResource parent) : base(parent)
        {
            _clientDiagnostics = new ClientDiagnostics(ClientOptions);
            _workloadGroupsRestClient = new WorkloadGroupsRestOperations(_clientDiagnostics, Pipeline, ClientOptions, BaseUri);
        }

        /// <summary> Gets the valid resource type for this object. </summary>
        protected override ResourceType ValidResourceType => SqlDatabase.ResourceType;

        // Collection level operations.

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_CreateOrUpdate
        /// <summary> Creates or updates a workload group. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="parameters"> The requested workload group state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public virtual WorkloadGroupCreateOrUpdateOperation CreateOrUpdate(string workloadGroupName, WorkloadGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _workloadGroupsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters, cancellationToken);
                var operation = new WorkloadGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _workloadGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_CreateOrUpdate
        /// <summary> Creates or updates a workload group. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="parameters"> The requested workload group state. </param>
        /// <param name="waitForCompletion"> Waits for the completion of the long running operations. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> or <paramref name="parameters"/> is null. </exception>
        public async virtual Task<WorkloadGroupCreateOrUpdateOperation> CreateOrUpdateAsync(string workloadGroupName, WorkloadGroupData parameters, bool waitForCompletion = true, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _workloadGroupsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters, cancellationToken).ConfigureAwait(false);
                var operation = new WorkloadGroupCreateOrUpdateOperation(Parent, _clientDiagnostics, Pipeline, _workloadGroupsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, parameters).Request, response);
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

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Gets a workload group. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<WorkloadGroup> Get(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = _workloadGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken);
                if (response.Value == null)
                    throw _clientDiagnostics.CreateRequestFailedException(response.GetRawResponse());
                return Response.FromValue(new WorkloadGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups/{workloadGroupName}
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_Get
        /// <summary> Gets a workload group. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public async virtual Task<Response<WorkloadGroup>> GetAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.Get");
            scope.Start();
            try
            {
                var response = await _workloadGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw await _clientDiagnostics.CreateRequestFailedExceptionAsync(response.GetRawResponse()).ConfigureAwait(false);
                return Response.FromValue(new WorkloadGroup(Parent, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<WorkloadGroup> GetIfExists(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.GetIfExists");
            scope.Start();
            try
            {
                var response = _workloadGroupsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken);
                return response.Value == null
                    ? Response.FromValue<WorkloadGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new WorkloadGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public async virtual Task<Response<WorkloadGroup>> GetIfExistsAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.GetIfExistsAsync");
            scope.Start();
            try
            {
                var response = await _workloadGroupsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, workloadGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return response.Value == null
                    ? Response.FromValue<WorkloadGroup>(null, response.GetRawResponse())
                    : Response.FromValue(new WorkloadGroup(this, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public virtual Response<bool> Exists(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.Exists");
            scope.Start();
            try
            {
                var response = GetIfExists(workloadGroupName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Tries to get details for this resource from the service. </summary>
        /// <param name="workloadGroupName"> The name of the workload group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workloadGroupName"/> is null. </exception>
        public async virtual Task<Response<bool>> ExistsAsync(string workloadGroupName, CancellationToken cancellationToken = default)
        {
            if (workloadGroupName == null)
            {
                throw new ArgumentNullException(nameof(workloadGroupName));
            }

            using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.ExistsAsync");
            scope.Start();
            try
            {
                var response = await GetIfExistsAsync(workloadGroupName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_ListByDatabase
        /// <summary> Gets the list of workload groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="WorkloadGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<WorkloadGroup> GetAll(CancellationToken cancellationToken = default)
        {
            Page<WorkloadGroup> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadGroupsRestClient.ListByDatabase(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<WorkloadGroup> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = _workloadGroupsRestClient.ListByDatabaseNextPage(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// RequestPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/workloadGroups
        /// ContextualPath: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}
        /// OperationId: WorkloadGroups_ListByDatabase
        /// <summary> Gets the list of workload groups. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="WorkloadGroup" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<WorkloadGroup> GetAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<WorkloadGroup>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadGroupsRestClient.ListByDatabaseAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<WorkloadGroup>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("WorkloadGroupCollection.GetAll");
                scope.Start();
                try
                {
                    var response = await _workloadGroupsRestClient.ListByDatabaseNextPageAsync(nextLink, Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, Id.Name, cancellationToken: cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value.Select(value => new WorkloadGroup(Parent, value)), response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        IEnumerator<WorkloadGroup> IEnumerable<WorkloadGroup>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<WorkloadGroup> IAsyncEnumerable<WorkloadGroup>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }

        // Builders.
        // public ArmBuilder<Azure.Core.ResourceIdentifier, WorkloadGroup, WorkloadGroupData> Construct() { }
    }
}
