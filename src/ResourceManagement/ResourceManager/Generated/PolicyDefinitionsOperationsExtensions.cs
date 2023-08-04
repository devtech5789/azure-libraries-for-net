// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceManager.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PolicyDefinitionsOperations.
    /// </summary>
    public static partial class PolicyDefinitionsOperationsExtensions
    {
            /// <summary>
            /// Creates or updates a policy definition in a subscription.
            /// </summary>
            /// <remarks>
            /// This operation creates or updates a policy definition in the given
            /// subscription with the given name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The name of the policy definition to create.
            /// </param>
            /// <param name='parameters'>
            /// The policy definition properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyDefinitionInner> CreateOrUpdateAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, PolicyDefinitionInner parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(policyDefinitionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a policy definition in a subscription.
            /// </summary>
            /// <remarks>
            /// This operation deletes the policy definition in the given subscription with
            /// the given name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The name of the policy definition to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(policyDefinitionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieves a policy definition in a subscription.
            /// </summary>
            /// <remarks>
            /// This operation retrieves the policy definition in the given subscription
            /// with the given name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The name of the policy definition to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyDefinitionInner> GetAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(policyDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves a built-in policy definition.
            /// </summary>
            /// <remarks>
            /// This operation retrieves the built-in policy definition with the given
            /// name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The name of the built-in policy definition to get.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyDefinitionInner> GetBuiltInAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetBuiltInWithHttpMessagesAsync(policyDefinitionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates or updates a policy definition in a management group.
            /// </summary>
            /// <remarks>
            /// This operation creates or updates a policy definition in the given
            /// management group with the given name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The name of the policy definition to create.
            /// </param>
            /// <param name='parameters'>
            /// The policy definition properties.
            /// </param>
            /// <param name='managementGroupId'>
            /// The ID of the management group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyDefinitionInner> CreateOrUpdateAtManagementGroupAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, PolicyDefinitionInner parameters, string managementGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateAtManagementGroupWithHttpMessagesAsync(policyDefinitionName, parameters, managementGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a policy definition in a management group.
            /// </summary>
            /// <remarks>
            /// This operation deletes the policy definition in the given management group
            /// with the given name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The name of the policy definition to delete.
            /// </param>
            /// <param name='managementGroupId'>
            /// The ID of the management group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAtManagementGroupAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, string managementGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteAtManagementGroupWithHttpMessagesAsync(policyDefinitionName, managementGroupId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Retrieve a policy definition in a management group.
            /// </summary>
            /// <remarks>
            /// This operation retrieves the policy definition in the given management
            /// group with the given name.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='policyDefinitionName'>
            /// The name of the policy definition to get.
            /// </param>
            /// <param name='managementGroupId'>
            /// The ID of the management group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicyDefinitionInner> GetAtManagementGroupAsync(this IPolicyDefinitionsOperations operations, string policyDefinitionName, string managementGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAtManagementGroupWithHttpMessagesAsync(policyDefinitionName, managementGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves policy definitions in a subscription
            /// </summary>
            /// <remarks>
            /// This operation retrieves a list of all the policy definitions in a given
            /// subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyDefinitionInner>> ListAsync(this IPolicyDefinitionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve built-in policy definitions
            /// </summary>
            /// <remarks>
            /// This operation retrieves a list of all the built-in policy definitions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyDefinitionInner>> ListBuiltInAsync(this IPolicyDefinitionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBuiltInWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve policy definitions in a management group
            /// </summary>
            /// <remarks>
            /// This operation retrieves a list of all the policy definitions in a given
            /// management group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managementGroupId'>
            /// The ID of the management group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyDefinitionInner>> ListByManagementGroupAsync(this IPolicyDefinitionsOperations operations, string managementGroupId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByManagementGroupWithHttpMessagesAsync(managementGroupId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves policy definitions in a subscription
            /// </summary>
            /// <remarks>
            /// This operation retrieves a list of all the policy definitions in a given
            /// subscription.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyDefinitionInner>> ListNextAsync(this IPolicyDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve built-in policy definitions
            /// </summary>
            /// <remarks>
            /// This operation retrieves a list of all the built-in policy definitions.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyDefinitionInner>> ListBuiltInNextAsync(this IPolicyDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListBuiltInNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieve policy definitions in a management group
            /// </summary>
            /// <remarks>
            /// This operation retrieves a list of all the policy definitions in a given
            /// management group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<PolicyDefinitionInner>> ListByManagementGroupNextAsync(this IPolicyDefinitionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByManagementGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
