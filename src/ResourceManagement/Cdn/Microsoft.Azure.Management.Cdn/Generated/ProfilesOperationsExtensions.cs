// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Cdn
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class ProfilesOperationsExtensions
    {
            /// <summary>
            /// Lists the CDN Profiles within an Azure subscitption
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IEnumerable<Profile> ListBySubscriptionId(this IProfilesOperations operations)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).ListBySubscriptionIdAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the CDN Profiles within an Azure subscitption
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Profile>> ListBySubscriptionIdAsync( this IProfilesOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListBySubscriptionIdWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Lists the CDN Profiles within a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static IEnumerable<Profile> ListByResourceGroup(this IProfilesOperations operations, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).ListByResourceGroupAsync(resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the CDN Profiles within a resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<Profile>> ListByResourceGroupAsync( this IProfilesOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Gets a CDN profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static Profile Get(this IProfilesOperations operations, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).GetAsync(profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a CDN profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Profile> GetAsync( this IProfilesOperations operations, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetWithHttpMessagesAsync(profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Creates a new CDN Profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='profileProperties'>
            /// Profile properties needed for creation
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static Profile Create(this IProfilesOperations operations, string profileName, ProfileCreateParameters profileProperties, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).CreateAsync(profileName, profileProperties, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN Profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='profileProperties'>
            /// Profile properties needed for creation
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Profile> CreateAsync( this IProfilesOperations operations, string profileName, ProfileCreateParameters profileProperties, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.CreateWithHttpMessagesAsync(profileName, profileProperties, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Creates a new CDN Profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='profileProperties'>
            /// Profile properties needed for creation
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static Profile BeginCreate(this IProfilesOperations operations, string profileName, ProfileCreateParameters profileProperties, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).BeginCreateAsync(profileName, profileProperties, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new CDN Profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='profileProperties'>
            /// Profile properties needed for creation
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Profile> BeginCreateAsync( this IProfilesOperations operations, string profileName, ProfileCreateParameters profileProperties, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.BeginCreateWithHttpMessagesAsync(profileName, profileProperties, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Updates an existing CDN Profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='tags'>
            /// Profile tags
            /// </param>
            public static Profile Update(this IProfilesOperations operations, string profileName, string resourceGroupName, IDictionary<string, string> tags)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).UpdateAsync(profileName, resourceGroupName, tags), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates an existing CDN Profile with the specified parameters
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='tags'>
            /// Profile tags
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Profile> UpdateAsync( this IProfilesOperations operations, string profileName, string resourceGroupName, IDictionary<string, string> tags, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.UpdateWithHttpMessagesAsync(profileName, resourceGroupName, tags, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

            /// <summary>
            /// Deletes an existing CDN Profile with the specified parameters. Deleting a
            /// profile will result in the deletion of all sub resources including
            /// endpoints, origins and CustomDomains
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static void DeleteIfExists(this IProfilesOperations operations, string profileName, string resourceGroupName)
            {
                Task.Factory.StartNew(s => ((IProfilesOperations)s).DeleteIfExistsAsync(profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN Profile with the specified parameters. Deleting a
            /// profile will result in the deletion of all sub resources including
            /// endpoints, origins and CustomDomains
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteIfExistsAsync( this IProfilesOperations operations, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.DeleteIfExistsWithHttpMessagesAsync(profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Deletes an existing CDN Profile with the specified parameters. Deleting a
            /// profile will result in the deletion of all sub resources including
            /// endpoints, origins and CustomDomains
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static void BeginDeleteIfExists(this IProfilesOperations operations, string profileName, string resourceGroupName)
            {
                Task.Factory.StartNew(s => ((IProfilesOperations)s).BeginDeleteIfExistsAsync(profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes an existing CDN Profile with the specified parameters. Deleting a
            /// profile will result in the deletion of all sub resources including
            /// endpoints, origins and CustomDomains
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteIfExistsAsync( this IProfilesOperations operations, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.BeginDeleteIfExistsWithHttpMessagesAsync(profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
            }

            /// <summary>
            /// Generates a dynamic SSO URI used to sign in to the CDN Supplemental Portal
            /// used for advanced management tasks, such as Country Filtering, Advanced
            /// HTTP Reports, and Real-time Stats and Alerts. The SSO URI changes
            /// approximately every 10 minutes.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            public static SsoUri GenerateSsoUri(this IProfilesOperations operations, string profileName, string resourceGroupName)
            {
                return Task.Factory.StartNew(s => ((IProfilesOperations)s).GenerateSsoUriAsync(profileName, resourceGroupName), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Generates a dynamic SSO URI used to sign in to the CDN Supplemental Portal
            /// used for advanced management tasks, such as Country Filtering, Advanced
            /// HTTP Reports, and Real-time Stats and Alerts. The SSO URI changes
            /// approximately every 10 minutes.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='profileName'>
            /// Name of the CDN profile within the resource group
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the resource group within the Azure subscription
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SsoUri> GenerateSsoUriAsync( this IProfilesOperations operations, string profileName, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GenerateSsoUriWithHttpMessagesAsync(profileName, resourceGroupName, null, cancellationToken).ConfigureAwait(false);
                return _result.Body;
            }

    }
}
