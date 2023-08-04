// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for CachingType.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CachingType
    {
        [EnumMember(Value = "none")]
        None,
        [EnumMember(Value = "readonly")]
        Readonly,
        [EnumMember(Value = "readwrite")]
        Readwrite
    }
    internal static class CachingTypeEnumExtension
    {
        internal static string ToSerializedValue(this CachingType? value)
        {
            return value == null ? null : ((CachingType)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this CachingType value)
        {
            switch( value )
            {
                case CachingType.None:
                    return "none";
                case CachingType.Readonly:
                    return "readonly";
                case CachingType.Readwrite:
                    return "readwrite";
            }
            return null;
        }

        internal static CachingType? ParseCachingType(this string value)
        {
            switch( value )
            {
                case "none":
                    return CachingType.None;
                case "readonly":
                    return CachingType.Readonly;
                case "readwrite":
                    return CachingType.Readwrite;
            }
            return null;
        }
    }
}
