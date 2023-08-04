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
    /// Constraints associated with the Job.
    /// </summary>
    public partial class JobPropertiesConstraints
    {
        /// <summary>
        /// Initializes a new instance of the JobPropertiesConstraints class.
        /// </summary>
        public JobPropertiesConstraints()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobPropertiesConstraints class.
        /// </summary>
        /// <param name="maxWallClockTime">Max wall clock time.</param>
        public JobPropertiesConstraints(System.TimeSpan? maxWallClockTime = default(System.TimeSpan?))
        {
            MaxWallClockTime = maxWallClockTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets max wall clock time.
        /// </summary>
        /// <remarks>
        /// Max time the job can run. Default value: 1 week.
        /// </remarks>
        [JsonProperty(PropertyName = "maxWallClockTime")]
        public System.TimeSpan? MaxWallClockTime { get; set; }

    }
}
