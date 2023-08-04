// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.PrivateDns.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for VirtualNetworkLinksOperations.
    /// </summary>
    public static partial class VirtualNetworkLinksOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a virtual network link to the specified Private DNS
            /// zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='virtualNetworkLinkName'>
            /// The name of the virtual network link.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the virtual network link to the Private DNS zone. Omit this
            /// value to always overwrite the current virtual network link. Specify the
            /// last-seen ETag value to prevent accidentally overwriting any concurrent
            /// changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new virtual network link to the Private DNS zone to
            /// be created, but to prevent updating an existing link. Other values will be
            /// ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkLinkInner> CreateOrUpdateAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, string virtualNetworkLinkName, VirtualNetworkLinkInner parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateZoneName, virtualNetworkLinkName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a virtual network link to the specified Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='virtualNetworkLinkName'>
            /// The name of the virtual network link.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the virtual network link to the Private DNS zone. Omit this
            /// value to always overwrite the current virtual network link. Specify the
            /// last-seen ETag value to prevent accidentally overwriting any concurrent
            /// changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkLinkInner> UpdateAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, string virtualNetworkLinkName, VirtualNetworkLinkInner parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, privateZoneName, virtualNetworkLinkName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a virtual network link to the specified Private DNS zone. WARNING:
            /// In case of a registration virtual network, all auto-registered DNS records
            /// in the zone for the virtual network will also be deleted. This operation
            /// cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='virtualNetworkLinkName'>
            /// The name of the virtual network link.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the virtual network link to the Private DNS zone. Omit this
            /// value to always delete the current zone. Specify the last-seen ETag value
            /// to prevent accidentally deleting any concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, string virtualNetworkLinkName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, privateZoneName, virtualNetworkLinkName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Gets a virtual network link to the specified Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='virtualNetworkLinkName'>
            /// The name of the virtual network link.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkLinkInner> GetAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, string virtualNetworkLinkName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, privateZoneName, virtualNetworkLinkName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the virtual network links to the specified Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='top'>
            /// The maximum number of virtual network links to return. If not specified,
            /// returns up to 100 virtual network links.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkLinkInner>> ListAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, privateZoneName, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a virtual network link to the specified Private DNS
            /// zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='virtualNetworkLinkName'>
            /// The name of the virtual network link.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the CreateOrUpdate operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the virtual network link to the Private DNS zone. Omit this
            /// value to always overwrite the current virtual network link. Specify the
            /// last-seen ETag value to prevent accidentally overwriting any concurrent
            /// changes.
            /// </param>
            /// <param name='ifNoneMatch'>
            /// Set to '*' to allow a new virtual network link to the Private DNS zone to
            /// be created, but to prevent updating an existing link. Other values will be
            /// ignored.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkLinkInner> BeginCreateOrUpdateAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, string virtualNetworkLinkName, VirtualNetworkLinkInner parameters, string ifMatch = default(string), string ifNoneMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, privateZoneName, virtualNetworkLinkName, parameters, ifMatch, ifNoneMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Updates a virtual network link to the specified Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='virtualNetworkLinkName'>
            /// The name of the virtual network link.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Update operation.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the virtual network link to the Private DNS zone. Omit this
            /// value to always overwrite the current virtual network link. Specify the
            /// last-seen ETag value to prevent accidentally overwriting any concurrent
            /// changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<VirtualNetworkLinkInner> BeginUpdateAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, string virtualNetworkLinkName, VirtualNetworkLinkInner parameters, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, privateZoneName, virtualNetworkLinkName, parameters, ifMatch, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a virtual network link to the specified Private DNS zone. WARNING:
            /// In case of a registration virtual network, all auto-registered DNS records
            /// in the zone for the virtual network will also be deleted. This operation
            /// cannot be undone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='privateZoneName'>
            /// The name of the Private DNS zone (without a terminating dot).
            /// </param>
            /// <param name='virtualNetworkLinkName'>
            /// The name of the virtual network link.
            /// </param>
            /// <param name='ifMatch'>
            /// The ETag of the virtual network link to the Private DNS zone. Omit this
            /// value to always delete the current zone. Specify the last-seen ETag value
            /// to prevent accidentally deleting any concurrent changes.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IVirtualNetworkLinksOperations operations, string resourceGroupName, string privateZoneName, string virtualNetworkLinkName, string ifMatch = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, privateZoneName, virtualNetworkLinkName, ifMatch, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Lists the virtual network links to the specified Private DNS zone.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<VirtualNetworkLinkInner>> ListNextAsync(this IVirtualNetworkLinksOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
