// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Management.ResourceManager;
    using Management.ResourceManager.Fluent;
    using Management.ResourceManager.Fluent.Core;

    using Newtonsoft.Json;
    /// <summary>
    /// Defines values for DeallocationOption.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(Management.ResourceManager.Fluent.Core.ExpandableStringEnumConverter<DeallocationOption>))]
    public class DeallocationOption : Management.ResourceManager.Fluent.Core.ExpandableStringEnum<DeallocationOption>
    {
        public static readonly DeallocationOption Requeue = Parse("requeue");
        public static readonly DeallocationOption Terminate = Parse("terminate");
        public static readonly DeallocationOption Waitforjobcompletion = Parse("waitforjobcompletion");
    }
}