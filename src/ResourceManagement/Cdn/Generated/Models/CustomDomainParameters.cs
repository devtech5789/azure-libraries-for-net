// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Cdn.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The customDomain JSON object required for custom domain creation or
    /// update.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class CustomDomainParameters
    {
        /// <summary>
        /// Initializes a new instance of the CustomDomainParameters class.
        /// </summary>
        public CustomDomainParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomDomainParameters class.
        /// </summary>
        /// <param name="hostName">The host name of the custom domain. Must be
        /// a domain name.</param>
        public CustomDomainParameters(string hostName)
        {
            HostName = hostName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the host name of the custom domain. Must be a domain
        /// name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.hostName")]
        public string HostName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (HostName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "HostName");
            }
        }
    }
}
