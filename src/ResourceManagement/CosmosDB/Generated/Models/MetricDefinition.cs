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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The definition of a metric.
    /// </summary>
    public partial class MetricDefinition
    {
        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        public MetricDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MetricDefinition class.
        /// </summary>
        /// <param name="metricAvailabilities">The list of metric
        /// availabilities for the account.</param>
        /// <param name="primaryAggregationType">The primary aggregation type
        /// of the metric. Possible values include: 'None', 'Average', 'Total',
        /// 'Minimum', 'Maximum', 'Last'</param>
        /// <param name="unit">The unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond', 'Milliseconds'</param>
        /// <param name="resourceUri">The resource uri of the database.</param>
        /// <param name="name">The name information for the metric.</param>
        public MetricDefinition(IList<MetricAvailability> metricAvailabilities = default(IList<MetricAvailability>), PrimaryAggregationType primaryAggregationType = default(PrimaryAggregationType), UnitType unit = default(UnitType), string resourceUri = default(string), MetricName name = default(MetricName))
        {
            MetricAvailabilities = metricAvailabilities;
            PrimaryAggregationType = primaryAggregationType;
            Unit = unit;
            ResourceUri = resourceUri;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the list of metric availabilities for the account.
        /// </summary>
        [JsonProperty(PropertyName = "metricAvailabilities")]
        public IList<MetricAvailability> MetricAvailabilities { get; private set; }

        /// <summary>
        /// Gets the primary aggregation type of the metric. Possible values
        /// include: 'None', 'Average', 'Total', 'Minimum', 'Maximum', 'Last'
        /// </summary>
        [JsonProperty(PropertyName = "primaryAggregationType")]
        public PrimaryAggregationType PrimaryAggregationType { get; private set; }

        /// <summary>
        /// Gets or sets the unit of the metric. Possible values include:
        /// 'Count', 'Bytes', 'Seconds', 'Percent', 'CountPerSecond',
        /// 'BytesPerSecond', 'Milliseconds'
        /// </summary>
        [JsonProperty(PropertyName = "unit")]
        public UnitType Unit { get; set; }

        /// <summary>
        /// Gets the resource uri of the database.
        /// </summary>
        [JsonProperty(PropertyName = "resourceUri")]
        public string ResourceUri { get; private set; }

        /// <summary>
        /// Gets the name information for the metric.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public MetricName Name { get; private set; }

    }
}