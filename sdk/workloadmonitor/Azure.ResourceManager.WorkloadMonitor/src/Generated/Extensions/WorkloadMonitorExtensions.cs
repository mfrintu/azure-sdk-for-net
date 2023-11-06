// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.WorkloadMonitor.Mocking;

namespace Azure.ResourceManager.WorkloadMonitor
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.WorkloadMonitor. </summary>
    public static partial class WorkloadMonitorExtensions
    {
        private static MockableWorkloadMonitorArmClient GetMockableWorkloadMonitorArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableWorkloadMonitorArmClient(client0));
        }

        private static MockableWorkloadMonitorResourceGroupResource GetMockableWorkloadMonitorResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableWorkloadMonitorResourceGroupResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthMonitorResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthMonitorResource.CreateResourceIdentifier" /> to create a <see cref="HealthMonitorResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWorkloadMonitorArmClient.GetHealthMonitorResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthMonitorResource" /> object. </returns>
        public static HealthMonitorResource GetHealthMonitorResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableWorkloadMonitorArmClient(client).GetHealthMonitorResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HealthMonitorStateChangeResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HealthMonitorStateChangeResource.CreateResourceIdentifier" /> to create a <see cref="HealthMonitorStateChangeResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWorkloadMonitorArmClient.GetHealthMonitorStateChangeResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HealthMonitorStateChangeResource" /> object. </returns>
        public static HealthMonitorStateChangeResource GetHealthMonitorStateChangeResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableWorkloadMonitorArmClient(client).GetHealthMonitorStateChangeResource(id);
        }

        /// <summary>
        /// Gets a collection of HealthMonitorResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWorkloadMonitorResourceGroupResource.GetHealthMonitors(string,string,string)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/> or <paramref name="resourceName"/> is an empty string, and was expected to be non-empty. </exception>
        /// <returns> An object representing collection of HealthMonitorResources and their operations over a HealthMonitorResource. </returns>
        public static HealthMonitorCollection GetHealthMonitors(this ResourceGroupResource resourceGroupResource, string providerName, string resourceCollectionName, string resourceName)
        {
            return GetMockableWorkloadMonitorResourceGroupResource(resourceGroupResource).GetHealthMonitors(providerName, resourceCollectionName, resourceName);
        }

        /// <summary>
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWorkloadMonitorResourceGroupResource.GetHealthMonitorAsync(string,string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HealthMonitorResource>> GetHealthMonitorAsync(this ResourceGroupResource resourceGroupResource, string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            return await GetMockableWorkloadMonitorResourceGroupResource(resourceGroupResource).GetHealthMonitorAsync(providerName, resourceCollectionName, resourceName, monitorId, expand, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get the current health status of a monitor of a virtual machine. Optional parameter: $expand (retrieve the monitor's evidence and configuration).
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{providerName}/{resourceCollectionName}/{resourceName}/providers/Microsoft.WorkloadMonitor/monitors/{monitorId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>HealthMonitors_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableWorkloadMonitorResourceGroupResource.GetHealthMonitor(string,string,string,string,string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="providerName"> The provider name (ex: Microsoft.Compute for virtual machines). </param>
        /// <param name="resourceCollectionName"> The resource collection name (ex: virtualMachines for virtual machines). </param>
        /// <param name="resourceName"> The name of the virtual machine. </param>
        /// <param name="monitorId"> The monitor Id of the virtual machine. </param>
        /// <param name="expand"> Optionally expand the monitor’s evidence and/or configuration. Example: $expand=evidence,configuration. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="providerName"/>, <paramref name="resourceCollectionName"/>, <paramref name="resourceName"/> or <paramref name="monitorId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HealthMonitorResource> GetHealthMonitor(this ResourceGroupResource resourceGroupResource, string providerName, string resourceCollectionName, string resourceName, string monitorId, string expand = null, CancellationToken cancellationToken = default)
        {
            return GetMockableWorkloadMonitorResourceGroupResource(resourceGroupResource).GetHealthMonitor(providerName, resourceCollectionName, resourceName, monitorId, expand, cancellationToken);
        }
    }
}
