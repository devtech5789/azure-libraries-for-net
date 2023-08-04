// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// VpnServerConfigurationsAssociatedWithVirtualWanOperations operations.
    /// </summary>
    public partial interface IVpnServerConfigurationsAssociatedWithVirtualWanOperations
    {
        /// <summary>
        /// Gives the list of VpnServerConfigurations associated with Virtual
        /// Wan in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations
        /// is needed.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VpnServerConfigurationsResponseInner>> ListWithHttpMessagesAsync(string resourceGroupName, string virtualWANName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Gives the list of VpnServerConfigurations associated with Virtual
        /// Wan in a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name.
        /// </param>
        /// <param name='virtualWANName'>
        /// The name of the VirtualWAN whose associated VpnServerConfigurations
        /// is needed.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VpnServerConfigurationsResponseInner>> BeginListWithHttpMessagesAsync(string resourceGroupName, string virtualWANName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
