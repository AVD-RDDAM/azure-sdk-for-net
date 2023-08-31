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
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary>
    /// A class representing a collection of <see cref="SecuritySettingResource" /> and their operations.
    /// Each <see cref="SecuritySettingResource" /> in the collection will belong to the same instance of <see cref="SubscriptionResource" />.
    /// To get a <see cref="SecuritySettingCollection" /> instance call the GetSecuritySettings method from an instance of <see cref="SubscriptionResource" />.
    /// </summary>
    public partial class SecuritySettingCollection : ArmCollection, IEnumerable<SecuritySettingResource>, IAsyncEnumerable<SecuritySettingResource>
    {
        private readonly ClientDiagnostics _securitySettingSettingsClientDiagnostics;
        private readonly SettingsRestOperations _securitySettingSettingsRestClient;

        /// <summary> Initializes a new instance of the <see cref="SecuritySettingCollection"/> class for mocking. </summary>
        protected SecuritySettingCollection()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="SecuritySettingCollection"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the parent resource that is the target of operations. </param>
        internal SecuritySettingCollection(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _securitySettingSettingsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.SecurityCenter", SecuritySettingResource.ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(SecuritySettingResource.ResourceType, out string securitySettingSettingsApiVersion);
            _securitySettingSettingsRestClient = new SettingsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, securitySettingSettingsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != SubscriptionResource.ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, SubscriptionResource.ResourceType), nameof(id));
        }

        /// <summary>
        /// updating settings about different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="data"> Setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<SecuritySettingResource>> CreateOrUpdateAsync(WaitUntil waitUntil, SecuritySettingName settingName, SecuritySettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _securitySettingSettingsRestClient.UpdateAsync(Id.SubscriptionId, settingName, data, cancellationToken).ConfigureAwait(false);
                var operation = new SecurityCenterArmOperation<SecuritySettingResource>(Response.FromValue(new SecuritySettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// updating settings about different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Update</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="data"> Setting object. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<SecuritySettingResource> CreateOrUpdate(WaitUntil waitUntil, SecuritySettingName settingName, SecuritySettingData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingCollection.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _securitySettingSettingsRestClient.Update(Id.SubscriptionId, settingName, data, cancellationToken);
                var operation = new SecurityCenterArmOperation<SecuritySettingResource>(Response.FromValue(new SecuritySettingResource(Client, response), response.GetRawResponse()));
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings of different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SecuritySettingResource>> GetAsync(SecuritySettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingCollection.Get");
            scope.Start();
            try
            {
                var response = await _securitySettingSettingsRestClient.GetAsync(Id.SubscriptionId, settingName, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings of different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SecuritySettingResource> Get(SecuritySettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingCollection.Get");
            scope.Start();
            try
            {
                var response = _securitySettingSettingsRestClient.Get(Id.SubscriptionId, settingName, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SecuritySettingResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Settings about different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="SecuritySettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual AsyncPageable<SecuritySettingResource> GetAllAsync(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securitySettingSettingsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securitySettingSettingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreateAsyncPageable(FirstPageRequest, NextPageRequest, e => new SecuritySettingResource(Client, SecuritySettingData.DeserializeSecuritySettingData(e)), _securitySettingSettingsClientDiagnostics, Pipeline, "SecuritySettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Settings about different configurations in Microsoft Defender for Cloud
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_List</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="SecuritySettingResource" /> that may take multiple service requests to iterate over. </returns>
        public virtual Pageable<SecuritySettingResource> GetAll(CancellationToken cancellationToken = default)
        {
            HttpMessage FirstPageRequest(int? pageSizeHint) => _securitySettingSettingsRestClient.CreateListRequest(Id.SubscriptionId);
            HttpMessage NextPageRequest(int? pageSizeHint, string nextLink) => _securitySettingSettingsRestClient.CreateListNextPageRequest(nextLink, Id.SubscriptionId);
            return GeneratorPageableHelpers.CreatePageable(FirstPageRequest, NextPageRequest, e => new SecuritySettingResource(Client, SecuritySettingData.DeserializeSecuritySettingData(e)), _securitySettingSettingsClientDiagnostics, Pipeline, "SecuritySettingCollection.GetAll", "value", "nextLink", cancellationToken);
        }

        /// <summary>
        /// Checks to see if the resource exists in azure.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<bool>> ExistsAsync(SecuritySettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingCollection.Exists");
            scope.Start();
            try
            {
                var response = await _securitySettingSettingsRestClient.GetAsync(Id.SubscriptionId, settingName, cancellationToken: cancellationToken).ConfigureAwait(false);
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
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.Security/settings/{settingName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Settings_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="settingName"> The name of the setting. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<bool> Exists(SecuritySettingName settingName, CancellationToken cancellationToken = default)
        {
            using var scope = _securitySettingSettingsClientDiagnostics.CreateScope("SecuritySettingCollection.Exists");
            scope.Start();
            try
            {
                var response = _securitySettingSettingsRestClient.Get(Id.SubscriptionId, settingName, cancellationToken: cancellationToken);
                return Response.FromValue(response.Value != null, response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        IEnumerator<SecuritySettingResource> IEnumerable<SecuritySettingResource>.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetAll().GetEnumerator();
        }

        IAsyncEnumerator<SecuritySettingResource> IAsyncEnumerable<SecuritySettingResource>.GetAsyncEnumerator(CancellationToken cancellationToken)
        {
            return GetAllAsync(cancellationToken: cancellationToken).GetAsyncEnumerator(cancellationToken);
        }
    }
}
