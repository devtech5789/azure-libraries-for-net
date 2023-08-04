// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Network.Fluent.Models
{
    using Microsoft.Azure.Management.ResourceManager;
    using Microsoft.Azure.Management.ResourceManager.Fluent;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Route Filter Resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class RouteFilterInner : Management.ResourceManager.Fluent.Resource
    {
        /// <summary>
        /// Initializes a new instance of the RouteFilterInner class.
        /// </summary>
        public RouteFilterInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RouteFilterInner class.
        /// </summary>
        /// <param name="rules">Collection of RouteFilterRules contained within
        /// a route filter.</param>
        /// <param name="peerings">A collection of references to express route
        /// circuit peerings.</param>
        /// <param name="ipv6Peerings">A collection of references to express
        /// route circuit ipv6 peerings.</param>
        /// <param name="provisioningState">The provisioning state of the route
        /// filter resource. Possible values include: 'Succeeded', 'Updating',
        /// 'Deleting', 'Failed'</param>
        /// <param name="etag">A unique read-only string that changes whenever
        /// the resource is updated.</param>
        public RouteFilterInner(string location = default(string), string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), IList<RouteFilterRuleInner> rules = default(IList<RouteFilterRuleInner>), IList<ExpressRouteCircuitPeeringInner> peerings = default(IList<ExpressRouteCircuitPeeringInner>), IList<ExpressRouteCircuitPeeringInner> ipv6Peerings = default(IList<ExpressRouteCircuitPeeringInner>), ProvisioningState provisioningState = default(ProvisioningState), string etag = default(string))
            : base(location, id, name, type, tags)
        {
            Rules = rules;
            Peerings = peerings;
            Ipv6Peerings = ipv6Peerings;
            ProvisioningState = provisioningState;
            Etag = etag;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collection of RouteFilterRules contained within a
        /// route filter.
        /// </summary>
        [JsonProperty(PropertyName = "properties.rules")]
        public IList<RouteFilterRuleInner> Rules { get; set; }

        /// <summary>
        /// Gets a collection of references to express route circuit peerings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.peerings")]
        public IList<ExpressRouteCircuitPeeringInner> Peerings { get; private set; }

        /// <summary>
        /// Gets a collection of references to express route circuit ipv6
        /// peerings.
        /// </summary>
        [JsonProperty(PropertyName = "properties.ipv6Peerings")]
        public IList<ExpressRouteCircuitPeeringInner> Ipv6Peerings { get; private set; }

        /// <summary>
        /// Gets the provisioning state of the route filter resource. Possible
        /// values include: 'Succeeded', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// Gets a unique read-only string that changes whenever the resource
        /// is updated.
        /// </summary>
        [JsonProperty(PropertyName = "etag")]
        public string Etag { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Rules != null)
            {
                foreach (var element in Rules)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (Peerings != null)
            {
                foreach (var element1 in Peerings)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (Ipv6Peerings != null)
            {
                foreach (var element2 in Ipv6Peerings)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}