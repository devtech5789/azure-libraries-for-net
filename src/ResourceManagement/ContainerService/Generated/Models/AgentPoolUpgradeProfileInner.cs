// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerService.Fluent.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The list of available upgrades for an agent pool.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class AgentPoolUpgradeProfileInner
    {
        /// <summary>
        /// Initializes a new instance of the AgentPoolUpgradeProfileInner
        /// class.
        /// </summary>
        public AgentPoolUpgradeProfileInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AgentPoolUpgradeProfileInner
        /// class.
        /// </summary>
        /// <param name="kubernetesVersion">Kubernetes version (major, minor,
        /// patch).</param>
        /// <param name="osType">OsType to be used to specify os type. Choose
        /// from Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'</param>
        /// <param name="id">Id of the agent pool upgrade profile.</param>
        /// <param name="name">Name of the agent pool upgrade profile.</param>
        /// <param name="type">Type of the agent pool upgrade profile.</param>
        /// <param name="upgrades">List of orchestrator types and versions
        /// available for upgrade.</param>
        /// <param name="latestNodeImageVersion">LatestNodeImageVersion is the
        /// latest AKS supported node image version.</param>
        public AgentPoolUpgradeProfileInner(string kubernetesVersion, OSType osType, string id = default(string), string name = default(string), string type = default(string), IList<AgentPoolUpgradeProfilePropertiesUpgradesItem> upgrades = default(IList<AgentPoolUpgradeProfilePropertiesUpgradesItem>), string latestNodeImageVersion = default(string))
        {
            Id = id;
            Name = name;
            Type = type;
            KubernetesVersion = kubernetesVersion;
            OsType = osType;
            Upgrades = upgrades;
            LatestNodeImageVersion = latestNodeImageVersion;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets id of the agent pool upgrade profile.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets name of the agent pool upgrade profile.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets type of the agent pool upgrade profile.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets kubernetes version (major, minor, patch).
        /// </summary>
        [JsonProperty(PropertyName = "properties.kubernetesVersion")]
        public string KubernetesVersion { get; set; }

        /// <summary>
        /// Gets or sets osType to be used to specify os type. Choose from
        /// Linux and Windows. Default to Linux. Possible values include:
        /// 'Linux', 'Windows'
        /// </summary>
        [JsonProperty(PropertyName = "properties.osType")]
        public OSType OsType { get; set; }

        /// <summary>
        /// Gets or sets list of orchestrator types and versions available for
        /// upgrade.
        /// </summary>
        [JsonProperty(PropertyName = "properties.upgrades")]
        public IList<AgentPoolUpgradeProfilePropertiesUpgradesItem> Upgrades { get; set; }

        /// <summary>
        /// Gets or sets latestNodeImageVersion is the latest AKS supported
        /// node image version.
        /// </summary>
        [JsonProperty(PropertyName = "properties.latestNodeImageVersion")]
        public string LatestNodeImageVersion { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (KubernetesVersion == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "KubernetesVersion");
            }
            if (OsType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OsType");
            }
        }
    }
}
