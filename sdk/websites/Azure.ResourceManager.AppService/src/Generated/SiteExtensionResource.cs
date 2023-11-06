// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    /// <summary>
    /// A Class representing a SiteExtension along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier" /> you can construct a <see cref="SiteExtensionResource" />
    /// from an instance of <see cref="ArmClient" /> using the GetSiteExtensionResource method.
    /// Otherwise you can get one from its parent resource <see cref="WebSiteResource" /> using the GetSiteExtension method.
    /// </summary>
    public partial class SiteExtensionResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="SiteExtensionResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="name"> The name. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string name)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/extensions/MSDeploy";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _siteExtensionWebAppsClientDiagnostics;
        private readonly WebAppsRestOperations _siteExtensionWebAppsRestClient;
        private readonly MSDeployStatusData _data;

        /// <summary> Initializes a new instance of the <see cref="SiteExtensionResource"/> class for mocking. </summary>
        protected SiteExtensionResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref = "SiteExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal SiteExtensionResource(ArmClient client, MSDeployStatusData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="SiteExtensionResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal SiteExtensionResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _siteExtensionWebAppsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.AppService", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string siteExtensionWebAppsApiVersion);
            _siteExtensionWebAppsRestClient = new WebAppsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, siteExtensionWebAppsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.Web/sites/extensions";

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual MSDeployStatusData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Description for Get the status of the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetMSDeployStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<SiteExtensionResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteExtensionWebAppsClientDiagnostics.CreateScope("SiteExtensionResource.Get");
            scope.Start();
            try
            {
                var response = await _siteExtensionWebAppsRestClient.GetMSDeployStatusAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the status of the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetMSDeployStatus</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<SiteExtensionResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _siteExtensionWebAppsClientDiagnostics.CreateScope("SiteExtensionResource.Get");
            scope.Start();
            try
            {
                var response = _siteExtensionWebAppsRestClient.GetMSDeployStatus(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new SiteExtensionResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Invoke the MSDeploy web app extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateMSDeployOperation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual async Task<ArmOperation<SiteExtensionResource>> CreateOrUpdateAsync(WaitUntil waitUntil, WebAppMSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteExtensionWebAppsClientDiagnostics.CreateScope("SiteExtensionResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = await _siteExtensionWebAppsRestClient.CreateMSDeployOperationAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, msDeploy, cancellationToken).ConfigureAwait(false);
                var operation = new AppServiceArmOperation<SiteExtensionResource>(new SiteExtensionOperationSource(Client), _siteExtensionWebAppsClientDiagnostics, Pipeline, _siteExtensionWebAppsRestClient.CreateCreateMSDeployOperationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Invoke the MSDeploy web app extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/extensions/MSDeploy</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_CreateMSDeployOperation</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="msDeploy"> Details of MSDeploy operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="msDeploy"/> is null. </exception>
        public virtual ArmOperation<SiteExtensionResource> CreateOrUpdate(WaitUntil waitUntil, WebAppMSDeploy msDeploy, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(msDeploy, nameof(msDeploy));

            using var scope = _siteExtensionWebAppsClientDiagnostics.CreateScope("SiteExtensionResource.CreateOrUpdate");
            scope.Start();
            try
            {
                var response = _siteExtensionWebAppsRestClient.CreateMSDeployOperation(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, msDeploy, cancellationToken);
                var operation = new AppServiceArmOperation<SiteExtensionResource>(new SiteExtensionOperationSource(Client), _siteExtensionWebAppsClientDiagnostics, Pipeline, _siteExtensionWebAppsRestClient.CreateCreateMSDeployOperationRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, msDeploy).Request, response, OperationFinalStateVia.Location);
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
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/extensions/MSDeploy/log</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetMSDeployLog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<WebAppMSDeployLog>> GetMSDeployLogAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _siteExtensionWebAppsClientDiagnostics.CreateScope("SiteExtensionResource.GetMSDeployLog");
            scope.Start();
            try
            {
                var response = await _siteExtensionWebAppsRestClient.GetMSDeployLogAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken).ConfigureAwait(false);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Description for Get the MSDeploy Log for the last MSDeploy operation.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Web/sites/{name}/extensions/MSDeploy/log</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>WebApps_GetMSDeployLog</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<WebAppMSDeployLog> GetMSDeployLog(CancellationToken cancellationToken = default)
        {
            using var scope = _siteExtensionWebAppsClientDiagnostics.CreateScope("SiteExtensionResource.GetMSDeployLog");
            scope.Start();
            try
            {
                var response = _siteExtensionWebAppsRestClient.GetMSDeployLog(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Name, cancellationToken);
                return response;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
