// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The disks sku name. Can be Standard_LRS, Premium_LRS, StandardSSD_LRS,
    /// or UltraSSD_LRS.
    /// </summary>
    public partial class DiskSku
    {
        /// <summary>
        /// Initializes a new instance of the DiskSku class.
        /// </summary>
        public DiskSku()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DiskSku class.
        /// </summary>
        /// <param name="name">The sku name. Possible values include:
        /// 'Standard_LRS', 'Premium_LRS', 'StandardSSD_LRS',
        /// 'UltraSSD_LRS'</param>
        /// <param name="tier">The sku tier.</param>
        public DiskSku(DiskStorageAccountTypes name = default(DiskStorageAccountTypes), string tier = default(string))
        {
            Name = name;
            Tier = tier;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the sku name. Possible values include: 'Standard_LRS',
        /// 'Premium_LRS', 'StandardSSD_LRS', 'UltraSSD_LRS'
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public DiskStorageAccountTypes Name { get; set; }

        /// <summary>
        /// Gets the sku tier.
        /// </summary>
        [JsonProperty(PropertyName = "tier")]
        public string Tier { get; private set; }

    }
}
