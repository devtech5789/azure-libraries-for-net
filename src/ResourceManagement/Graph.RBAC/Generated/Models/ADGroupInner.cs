// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Graph.RBAC.Fluent.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Active Directory group information.
    /// </summary>
    [Newtonsoft.Json.JsonObject("Group")]
    public partial class ADGroupInner : DirectoryObject
    {
        /// <summary>
        /// Initializes a new instance of the ADGroupInner class.
        /// </summary>
        public ADGroupInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ADGroupInner class.
        /// </summary>
        /// <param name="additionalProperties">Unmatched properties from the
        /// message are deserialized this collection</param>
        /// <param name="objectId">The object ID.</param>
        /// <param name="deletionTimestamp">The time at which the directory
        /// object was deleted.</param>
        /// <param name="displayName">The display name of the group.</param>
        /// <param name="mailEnabled">Whether the group is mail-enabled. Must
        /// be false. This is because only pure security groups can be created
        /// using the Graph API.</param>
        /// <param name="mailNickname">The mail alias for the group. </param>
        /// <param name="securityEnabled">Whether the group is
        /// security-enable.</param>
        /// <param name="mail">The primary email address of the group.</param>
        public ADGroupInner(IDictionary<string, object> additionalProperties = default(IDictionary<string, object>), string objectId = default(string), System.DateTime? deletionTimestamp = default(System.DateTime?), string displayName = default(string), bool? mailEnabled = default(bool?), string mailNickname = default(string), bool? securityEnabled = default(bool?), string mail = default(string))
            : base(additionalProperties, objectId, deletionTimestamp)
        {
            DisplayName = displayName;
            MailEnabled = mailEnabled;
            MailNickname = mailNickname;
            SecurityEnabled = securityEnabled;
            Mail = mail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the display name of the group.
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets whether the group is mail-enabled. Must be false. This
        /// is because only pure security groups can be created using the Graph
        /// API.
        /// </summary>
        [JsonProperty(PropertyName = "mailEnabled")]
        public bool? MailEnabled { get; set; }

        /// <summary>
        /// Gets or sets the mail alias for the group.
        /// </summary>
        [JsonProperty(PropertyName = "mailNickname")]
        public string MailNickname { get; set; }

        /// <summary>
        /// Gets or sets whether the group is security-enable.
        /// </summary>
        [JsonProperty(PropertyName = "securityEnabled")]
        public bool? SecurityEnabled { get; set; }

        /// <summary>
        /// Gets or sets the primary email address of the group.
        /// </summary>
        [JsonProperty(PropertyName = "mail")]
        public string Mail { get; set; }

    }
}
