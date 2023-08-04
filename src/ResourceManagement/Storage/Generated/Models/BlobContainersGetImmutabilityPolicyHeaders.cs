// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Storage.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for GetImmutabilityPolicy operation.
    /// </summary>
    public partial class BlobContainersGetImmutabilityPolicyHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BlobContainersGetImmutabilityPolicyHeaders class.
        /// </summary>
        public BlobContainersGetImmutabilityPolicyHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BlobContainersGetImmutabilityPolicyHeaders class.
        /// </summary>
        /// <param name="eTag">The ETag HTTP response header. This is an opaque
        /// string. You can use it to detect whether the resource has changed
        /// between requests. In particular, you can pass the ETag to one of
        /// the If-Match or If-None-Match headers.</param>
        public BlobContainersGetImmutabilityPolicyHeaders(string eTag = default(string))
        {
            ETag = eTag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ETag HTTP response header. This is an opaque
        /// string. You can use it to detect whether the resource has changed
        /// between requests. In particular, you can pass the ETag to one of
        /// the If-Match or If-None-Match headers.
        /// </summary>
        [JsonProperty(PropertyName = "ETag")]
        public string ETag { get; set; }

    }
}
