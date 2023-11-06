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
using Azure.ResourceManager.AgFoodPlatform;

namespace Azure.ResourceManager.AgFoodPlatform.Mocking
{
    /// <summary> A class to add extension methods to TenantResource. </summary>
    public partial class MockableAgFoodPlatformTenantResource : ArmResource
    {
        /// <summary> Initializes a new instance of the <see cref="MockableAgFoodPlatformTenantResource"/> class for mocking. </summary>
        protected MockableAgFoodPlatformTenantResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="MockableAgFoodPlatformTenantResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal MockableAgFoodPlatformTenantResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
        }

        private string GetApiVersionOrNull(ResourceType resourceType)
        {
            TryGetApiVersion(resourceType, out string apiVersion);
            return apiVersion;
        }

        /// <summary> Gets a collection of FarmBeatsExtensionResources in the TenantResource. </summary>
        /// <returns> An object representing collection of FarmBeatsExtensionResources and their operations over a FarmBeatsExtensionResource. </returns>
        public virtual FarmBeatsExtensionCollection GetFarmBeatsExtensions()
        {
            return GetCachedClient(client => new FarmBeatsExtensionCollection(client, Id));
        }

        /// <summary>
        /// Get farmBeats extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/{farmBeatsExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual async Task<Response<FarmBeatsExtensionResource>> GetFarmBeatsExtensionAsync(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            return await GetFarmBeatsExtensions().GetAsync(farmBeatsExtensionId, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Get farmBeats extension.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/providers/Microsoft.AgFoodPlatform/farmBeatsExtensionDefinitions/{farmBeatsExtensionId}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>FarmBeatsExtensions_Get</description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="farmBeatsExtensionId"> farmBeatsExtensionId to be queried. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="farmBeatsExtensionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="farmBeatsExtensionId"/> is an empty string, and was expected to be non-empty. </exception>
        [ForwardsClientCalls]
        public virtual Response<FarmBeatsExtensionResource> GetFarmBeatsExtension(string farmBeatsExtensionId, CancellationToken cancellationToken = default)
        {
            return GetFarmBeatsExtensions().Get(farmBeatsExtensionId, cancellationToken);
        }
    }
}
