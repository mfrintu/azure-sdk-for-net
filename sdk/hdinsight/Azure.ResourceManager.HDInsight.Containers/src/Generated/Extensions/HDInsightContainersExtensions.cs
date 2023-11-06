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
using Azure.ResourceManager.HDInsight.Containers.Mocking;
using Azure.ResourceManager.HDInsight.Containers.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.HDInsight.Containers
{
    /// <summary> A class to add extension methods to Azure.ResourceManager.HDInsight.Containers. </summary>
    public static partial class HDInsightContainersExtensions
    {
        private static MockableHDInsightContainersArmClient GetMockableHDInsightContainersArmClient(ArmClient client)
        {
            return client.GetCachedClient(client0 => new MockableHDInsightContainersArmClient(client0));
        }

        private static MockableHDInsightContainersResourceGroupResource GetMockableHDInsightContainersResourceGroupResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHDInsightContainersResourceGroupResource(client, resource.Id));
        }

        private static MockableHDInsightContainersSubscriptionResource GetMockableHDInsightContainersSubscriptionResource(ArmResource resource)
        {
            return resource.GetCachedClient(client => new MockableHDInsightContainersSubscriptionResource(client, resource.Id));
        }

        /// <summary>
        /// Gets an object representing a <see cref="HDInsightClusterPoolResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HDInsightClusterPoolResource.CreateResourceIdentifier" /> to create a <see cref="HDInsightClusterPoolResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersArmClient.GetHDInsightClusterPoolResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HDInsightClusterPoolResource" /> object. </returns>
        public static HDInsightClusterPoolResource GetHDInsightClusterPoolResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableHDInsightContainersArmClient(client).GetHDInsightClusterPoolResource(id);
        }

        /// <summary>
        /// Gets an object representing a <see cref="HDInsightClusterResource" /> along with the instance operations that can be performed on it but with no data.
        /// You can use <see cref="HDInsightClusterResource.CreateResourceIdentifier" /> to create a <see cref="HDInsightClusterResource" /> <see cref="ResourceIdentifier" /> from its components.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersArmClient.GetHDInsightClusterResource(ResourceIdentifier)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="client"> The <see cref="ArmClient" /> instance the method will execute against. </param>
        /// <param name="id"> The resource ID of the resource to get. </param>
        /// <returns> Returns a <see cref="HDInsightClusterResource" /> object. </returns>
        public static HDInsightClusterResource GetHDInsightClusterResource(this ArmClient client, ResourceIdentifier id)
        {
            return GetMockableHDInsightContainersArmClient(client).GetHDInsightClusterResource(id);
        }

        /// <summary>
        /// Gets a collection of HDInsightClusterPoolResources in the ResourceGroupResource.
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersResourceGroupResource.GetHDInsightClusterPools()"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <returns> An object representing collection of HDInsightClusterPoolResources and their operations over a HDInsightClusterPoolResource. </returns>
        public static HDInsightClusterPoolCollection GetHDInsightClusterPools(this ResourceGroupResource resourceGroupResource)
        {
            return GetMockableHDInsightContainersResourceGroupResource(resourceGroupResource).GetHDInsightClusterPools();
        }

        /// <summary>
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersResourceGroupResource.GetHDInsightClusterPoolAsync(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static async Task<Response<HDInsightClusterPoolResource>> GetHDInsightClusterPoolAsync(this ResourceGroupResource resourceGroupResource, string clusterPoolName, CancellationToken cancellationToken = default)
        {
            return await GetMockableHDInsightContainersResourceGroupResource(resourceGroupResource).GetHDInsightClusterPoolAsync(clusterPoolName, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets a cluster pool.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.HDInsight/clusterpools/{clusterPoolName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_Get</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersResourceGroupResource.GetHDInsightClusterPool(string,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="resourceGroupResource"> The <see cref="ResourceGroupResource" /> instance the method will execute against. </param>
        /// <param name="clusterPoolName"> The name of the cluster pool. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="clusterPoolName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="clusterPoolName"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public static Response<HDInsightClusterPoolResource> GetHDInsightClusterPool(this ResourceGroupResource resourceGroupResource, string clusterPoolName, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersResourceGroupResource(resourceGroupResource).GetHDInsightClusterPool(clusterPoolName, cancellationToken);
        }

        /// <summary>
        /// Gets the list of Cluster Pools within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.GetHDInsightClusterPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightClusterPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HDInsightClusterPoolResource> GetHDInsightClusterPoolsAsync(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).GetHDInsightClusterPoolsAsync(cancellationToken);
        }

        /// <summary>
        /// Gets the list of Cluster Pools within a Subscription.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/clusterpools</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ClusterPools_ListBySubscription</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.GetHDInsightClusterPools(CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightClusterPoolResource" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HDInsightClusterPoolResource> GetHDInsightClusterPools(this SubscriptionResource subscriptionResource, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).GetHDInsightClusterPools(cancellationToken);
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.CheckHDInsightNameAvailability(AzureLocation,HDInsightNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static async Task<Response<HDInsightNameAvailabilityResult>> CheckHDInsightNameAvailabilityAsync(this SubscriptionResource subscriptionResource, AzureLocation location, HDInsightNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return await GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).CheckHDInsightNameAvailabilityAsync(location, content, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Check the availability of the resource name.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/checkNameAvailability</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>Locations_CheckNameAvailability</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.CheckHDInsightNameAvailability(AzureLocation,HDInsightNameAvailabilityContent,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="content"> The name and type of the resource. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="content"/> is null. </exception>
        public static Response<HDInsightNameAvailabilityResult> CheckHDInsightNameAvailability(this SubscriptionResource subscriptionResource, AzureLocation location, HDInsightNameAvailabilityContent content, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).CheckHDInsightNameAvailability(location, content, cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster pool versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterPoolVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterPoolVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.GetAvailableClusterPoolVersionsByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="ClusterPoolVersion" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).GetAvailableClusterPoolVersionsByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster pool versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterPoolVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterPoolVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.GetAvailableClusterPoolVersionsByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="ClusterPoolVersion" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<ClusterPoolVersion> GetAvailableClusterPoolVersionsByLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).GetAvailableClusterPoolVersionsByLocation(location, cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.GetAvailableClusterVersionsByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> An async collection of <see cref="HDInsightClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public static AsyncPageable<HDInsightClusterVersion> GetAvailableClusterVersionsByLocationAsync(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).GetAvailableClusterVersionsByLocationAsync(location, cancellationToken);
        }

        /// <summary>
        /// Returns a list of available cluster versions.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/providers/Microsoft.HDInsight/locations/{location}/availableClusterVersions</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>AvailableClusterVersions_ListByLocation</description>
        /// </item>
        /// </list>
        /// <item>
        /// <term>Mocking</term>
        /// <description>To mock this method, please mock <see cref="MockableHDInsightContainersSubscriptionResource.GetAvailableClusterVersionsByLocation(AzureLocation,CancellationToken)"/> instead.</description>
        /// </item>
        /// </summary>
        /// <param name="subscriptionResource"> The <see cref="SubscriptionResource" /> instance the method will execute against. </param>
        /// <param name="location"> The name of the Azure region. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <returns> A collection of <see cref="HDInsightClusterVersion" /> that may take multiple service requests to iterate over. </returns>
        public static Pageable<HDInsightClusterVersion> GetAvailableClusterVersionsByLocation(this SubscriptionResource subscriptionResource, AzureLocation location, CancellationToken cancellationToken = default)
        {
            return GetMockableHDInsightContainersSubscriptionResource(subscriptionResource).GetAvailableClusterVersionsByLocation(location, cancellationToken);
        }
    }
}
