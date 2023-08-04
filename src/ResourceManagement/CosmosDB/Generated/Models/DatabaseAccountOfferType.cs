// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for DatabaseAccountOfferType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DatabaseAccountOfferType
    {
        [EnumMember(Value = "Standard")]
        Standard
    }
    internal static class DatabaseAccountOfferTypeEnumExtension
    {
        internal static string ToSerializedValue(this DatabaseAccountOfferType? value)
        {
            return value == null ? null : ((DatabaseAccountOfferType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this DatabaseAccountOfferType value)
        {
            switch( value )
            {
                case DatabaseAccountOfferType.Standard:
                    return "Standard";
            }
            return null;
        }

        internal static DatabaseAccountOfferType? ParseDatabaseAccountOfferType(this string value)
        {
            switch( value )
            {
                case "Standard":
                    return DatabaseAccountOfferType.Standard;
            }
            return null;
        }
    }
}