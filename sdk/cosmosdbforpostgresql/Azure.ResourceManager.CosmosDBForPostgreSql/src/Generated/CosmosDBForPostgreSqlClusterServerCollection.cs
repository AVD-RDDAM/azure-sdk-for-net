// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;

namespace Azure.ResourceManager.CosmosDBForPostgreSql
{
    /// <summary>
    /// A class representing a collection of <see cref="CosmosDBForPostgreSqlClusterServerResource" /> and their operations.
    /// Each <see cref="CosmosDBForPostgreSqlClusterServerResource" /> in the collection will belong to the same instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// To get a <see cref="CosmosDBForPostgreSqlClusterServerCollection" /> instance call the GetCosmosDBForPostgreSqlClusterServers method from an instance of <see cref="CosmosDBForPostgreSqlClusterResource" />.
    /// </summary>
    public partial class CosmosDBForPostgreSqlClusterServerCollection : ArmCollection, IEnumerable<CosmosDBForPostgreSqlClusterServerResource>, IAsyncEnumerable<CosmosDBForPostgreSqlClusterServerResource>
    {
        private readonly ClientDiagnostics _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics;
        private readonly ServersRestOperations _cosmosDBForPostgreSqlClusterServerServersRestClient;

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlClusterServerCollection"/> class for mocking. </summary>
        protected CosmosDBForPostgreSqlClusterServerCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CosmosDBForPostgreSqlClusterServerCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal CosmosDBForPostgreSqlClusterServerCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CosmosDBForPostgreSql", CosmosDBForPostgreSqlClusterServerResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(CosmosDBForPostgreSqlClusterServerResource.ResourceType, out string cosmosDBForPostgreSqlClusterServerServersApiVersion);
            _cosmosDBForPostgreSqlClusterServerServersRestClient = new ServersRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cosmosDBForPostgreSqlClusterServerServersApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != CosmosDBForPostgreSqlClusterResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, CosmosDBForPostgreSqlClusterResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// Gets information about a server in cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<CosmosDBForPostgreSqlClusterServerResource>> GetAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics.CreateScope("CosmosDBForPostgreSqlClusterServerCollection.Get");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlClusterServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlClusterServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Gets information about a server in cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<CosmosDBForPostgreSqlClusterServerResource> Get(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics.CreateScope("CosmosDBForPostgreSqlClusterServerCollection.Get");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlClusterServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CosmosDBForPostgreSqlClusterServerResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists servers of a cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="CosmosDBForPostgreSqlClusterServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<CosmosDBForPostgreSqlClusterServerResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlClusterServerServersRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, null, e => new CosmosDBForPostgreSqlClusterServerResource(Client, CosmosDBForPostgreSqlClusterServerData.DeserializeCosmosDBForPostgreSqlClusterServerData(e)), _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlClusterServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Lists servers of a cluster.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/servers</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_ListByCluster</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="CosmosDBForPostgreSqlClusterServerResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<CosmosDBForPostgreSqlClusterServerResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _cosmosDBForPostgreSqlClusterServerServersRestClient.CreateListByClusterRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Name);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, null, e => new CosmosDBForPostgreSqlClusterServerResource(Client, CosmosDBForPostgreSqlClusterServerData.DeserializeCosmosDBForPostgreSqlClusterServerData(e)), _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics, Pipeline, "CosmosDBForPostgreSqlClusterServerCollection.GetAll", "value", null, cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual async Task<Response<bool>> ExistsAsync(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics.CreateScope("CosmosDBForPostgreSqlClusterServerCollection.Exists");
            scope.Start();
            try
            {
                var response = await _cosmosDBForPostgreSqlClusterServerServersRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverName, cancellationToken: cancellationToken).ConfigureAwait(false);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.DBforPostgreSQL/serverGroupsv2/{clusterName}/servers/{serverName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Servers_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="serverName"> The name of the server. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentException"> <paramref name="serverName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <exception cref="ArgumentNullException"> <paramref name="serverName"/> is null. </exception>
        public virtual Response<bool> Exists(string serverName, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(serverName, nameof(serverName));

            using var scope = _cosmosDBForPostgreSqlClusterServerServersClientDiagnostics.CreateScope("CosmosDBForPostgreSqlClusterServerCollection.Exists");
            scope.Start();
            try
            {
                var response = _cosmosDBForPostgreSqlClusterServerServersRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Name, serverName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<CosmosDBForPostgreSqlClusterServerResource> IEnumerable<CosmosDBForPostgreSqlClusterServerResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<CosmosDBForPostgreSqlClusterServerResource> IAsyncEnumerable<CosmosDBForPostgreSqlClusterServerResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
