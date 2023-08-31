// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Autorest.CSharp.Core;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.ContainerRegistry.Models;

namespace Azure.ResourceManager.ContainerRegistry
{
    /// <summary> A class to add extension methods to SubscriptionResource. </summary>
    internal partial class SubscriptionResourceExtensionClient : ArmResource
    {
        private ClientDiagnostics _containerRegistryRegistriesClientDiagnostics;
        private RegistriesRestOperations _containerRegistryRegistriesRestClient;

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class for mocking. </summary>
        protected SubscriptionResourceExtensionClient()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SubscriptionResourceExtensionClient"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SubscriptionResourceExtensionClient(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private ClientDiagnostics ContainerRegistryRegistriesClientDiagnostics => _containerRegistryRegistriesClientDiagnostics ??= new ClientDiagnostics("Azure.ResourceManager.ContainerRegistry", ContainerRegistryResource.ResourceType.Namespace, Diagnostics);
        private RegistriesRestOperations ContainerRegistryRegistriesRestClient => _containerRegistryRegistriesRestClient ??= new RegistriesRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, GetApiVersionOrNull(ContainerRegistryResource.ResourceType));

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<ContainerRegistryNameAvailableResult>> CheckContainerRegistryNameAvailabilityAsync(ContainerRegistryNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ContainerRegistryRegistriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckContainerRegistryNameAvailability");
            scope.Start();
            try
            {
                var response = await ContainerRegistryRegistriesRestClient.CheckNameAvailabilityAsync(Id.SubscriptionId, content, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Checks whether the container registry name is available for use. The name must contain only alphanumeric characters, be globally unique, and between 5 and 50 characters in length.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="content"> The object containing information for the availability request. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<ContainerRegistryNameAvailableResult> CheckContainerRegistryNameAvailability(ContainerRegistryNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            using var scope = ContainerRegistryRegistriesClientDiagnostics.CreateScope("SubscriptionResourceExtensionClient.CheckContainerRegistryNameAvailability");
            scope.Start();
            try
            {
                var response = ContainerRegistryRegistriesRestClient.CheckNameAvailability(Id.SubscriptionId, content, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Lists all the container registries under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ContainerRegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<ContainerRegistryResource> GetContainerRegistriesAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerRegistryRegistriesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerRegistryRegistriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryResource(Client, ContainerRegistryData.DeserializeContainerRegistryData(e)), ContainerRegistryRegistriesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetContainerRegistries", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Lists all the container registries under the specified subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.ContainerRegistry/registries</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Registries_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ContainerRegistryResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<ContainerRegistryResource> GetContainerRegistries(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => ContainerRegistryRegistriesRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => ContainerRegistryRegistriesRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new ContainerRegistryResource(Client, ContainerRegistryData.DeserializeContainerRegistryData(e)), ContainerRegistryRegistriesClientDiagnostics, Pipeline, "SubscriptionResourceExtensionClient.GetContainerRegistries", "value", "nextLink", cancellationToken);
        }
    }
}
