// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.KeyVault.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Parameters for creating or updating a vault
    /// </summary>
    public partial class VaultCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the VaultCreateOrUpdateParameters
        /// class.
        /// </summary>
        public VaultCreateOrUpdateParameters()
        {
            Properties = new VaultProperties();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VaultCreateOrUpdateParameters
        /// class.
        /// </summary>
        /// <param name="location">The supported Azure location where the key
        /// vault should be created.</param>
        /// <param name="properties">Properties of the vault</param>
        /// <param name="tags">The tags that will be assigned to the key
        /// vault.</param>
        public VaultCreateOrUpdateParameters(string location, VaultProperties properties, IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Tags = tags;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the supported Azure location where the key vault
        /// should be created.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the tags that will be assigned to the key vault.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets properties of the vault
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public VaultProperties Properties { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
            if (Properties == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Properties");
            }
            if (Properties != null)
            {
                Properties.Validate();
            }
        }
    }
}
