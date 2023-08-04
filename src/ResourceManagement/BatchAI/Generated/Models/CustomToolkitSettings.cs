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
    using System.Linq;

    /// <summary>
    /// Custom tool kit job settings.
    /// </summary>
    public partial class CustomToolkitSettings
    {
        /// <summary>
        /// Initializes a new instance of the CustomToolkitSettings class.
        /// </summary>
        public CustomToolkitSettings()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CustomToolkitSettings class.
        /// </summary>
        /// <param name="commandLine">Command line.</param>
        public CustomToolkitSettings(string commandLine = default(string))
        {
            CommandLine = commandLine;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets command line.
        /// </summary>
        /// <remarks>
        /// The command line to execute on the master node.
        /// </remarks>
        [JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

    }
}