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
    using Newtonsoft.Json;
    using System.Linq;

    public partial class ManagedClusterPodIdentity
    {
        /// <summary>
        /// Initializes a new instance of the ManagedClusterPodIdentity class.
        /// </summary>
        public ManagedClusterPodIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedClusterPodIdentity class.
        /// </summary>
        /// <param name="name">Name of the pod identity.</param>
        /// <param name="namespaceProperty">Namespace of the pod
        /// identity.</param>
        /// <param name="identity">Information of the user assigned
        /// identity.</param>
        /// <param name="provisioningState">The current provisioning state of
        /// the pod identity. Possible values include: 'Assigned', 'Updating',
        /// 'Deleting', 'Failed'</param>
        public ManagedClusterPodIdentity(string name, string namespaceProperty, UserAssignedIdentity identity, ManagedClusterPodIdentityProvisioningState provisioningState = default(ManagedClusterPodIdentityProvisioningState), ManagedClusterPodIdentityProvisioningInfo provisioningInfo = default(ManagedClusterPodIdentityProvisioningInfo))
        {
            Name = name;
            NamespaceProperty = namespaceProperty;
            Identity = identity;
            ProvisioningState = provisioningState;
            ProvisioningInfo = provisioningInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the pod identity.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets namespace of the pod identity.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

        /// <summary>
        /// Gets or sets information of the user assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public UserAssignedIdentity Identity { get; set; }

        /// <summary>
        /// Gets the current provisioning state of the pod identity. Possible
        /// values include: 'Assigned', 'Updating', 'Deleting', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "provisioningState")]
        public ManagedClusterPodIdentityProvisioningState ProvisioningState { get; private set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "provisioningInfo")]
        public ManagedClusterPodIdentityProvisioningInfo ProvisioningInfo { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (NamespaceProperty == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "NamespaceProperty");
            }
            if (Identity == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Identity");
            }
        }
    }
}
