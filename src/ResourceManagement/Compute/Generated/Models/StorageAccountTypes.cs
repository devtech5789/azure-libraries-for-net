// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for StorageAccountTypes.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<StorageAccountTypes>))]
    public class StorageAccountTypes : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<StorageAccountTypes>
    {
        public static readonly StorageAccountTypes StandardLRS = Parse("Standard_LRS");
        public static readonly StorageAccountTypes PremiumLRS = Parse("Premium_LRS");
        public static readonly StorageAccountTypes StandardSSDLRS = Parse("StandardSSD_LRS");
        public static readonly StorageAccountTypes UltraSSDLRS = Parse("UltraSSD_LRS");
    }
}
