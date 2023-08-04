// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for GalleryImageVersionsOperations.
    /// </summary>
    public static partial class GalleryImageVersionsOperationsExtensions
    {
            /// <summary>
            /// Create or update a gallery Image Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image Definition in which the Image Version is to
            /// be created.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery Image Version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the create or update gallery Image Version
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersionInner> CreateOrUpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionInner galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery Image Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image Definition in which the Image Version is to
            /// be updated.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery Image Version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the update gallery Image Version operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersionInner> UpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Retrieves information about a gallery Image Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image Definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery Image Version to be retrieved.
            /// </param>
            /// <param name='expand'>
            /// The expand expression to apply on the operation. Possible values include:
            /// 'ReplicationStatus'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersionInner> GetAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, ReplicationStatusTypes expand = default(ReplicationStatusTypes), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, expand, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery Image Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image Definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery Image Version to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery Image Versions in a gallery Image Definition.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the Shared Image Gallery Image Definition from which the Image
            /// Versions are to be listed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<GalleryImageVersionInner>> ListByGalleryImageAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryImageWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a gallery Image Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image Definition in which the Image Version is to
            /// be created.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery Image Version to be created. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the create or update gallery Image Version
            /// operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersionInner> BeginCreateOrUpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionInner galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update a gallery Image Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image Definition in which the Image Version is to
            /// be updated.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery Image Version to be updated. Needs to follow
            /// semantic version name pattern: The allowed characters are digit and period.
            /// Digits must be within the range of a 32-bit integer. Format:
            /// &lt;MajorVersion&gt;.&lt;MinorVersion&gt;.&lt;Patch&gt;
            /// </param>
            /// <param name='galleryImageVersion'>
            /// Parameters supplied to the update gallery Image Version operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GalleryImageVersionInner> BeginUpdateAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, GalleryImageVersionUpdate galleryImageVersion, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, galleryImageVersion, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a gallery Image Version.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='galleryName'>
            /// The name of the Shared Image Gallery in which the Image Definition resides.
            /// </param>
            /// <param name='galleryImageName'>
            /// The name of the gallery Image Definition in which the Image Version
            /// resides.
            /// </param>
            /// <param name='galleryImageVersionName'>
            /// The name of the gallery Image Version to be deleted.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IGalleryImageVersionsOperations operations, string resourceGroupName, string galleryName, string galleryImageName, string galleryImageVersionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, galleryName, galleryImageName, galleryImageVersionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// List gallery Image Versions in a gallery Image Definition.
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
            public static async Task<IPage<GalleryImageVersionInner>> ListByGalleryImageNextAsync(this IGalleryImageVersionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByGalleryImageNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}