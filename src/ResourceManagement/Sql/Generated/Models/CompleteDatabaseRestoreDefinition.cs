// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Contains the information necessary to perform a complete database
    /// restore operation.
    /// </summary>
    public partial class CompleteDatabaseRestoreDefinition
    {
        /// <summary>
        /// Initializes a new instance of the CompleteDatabaseRestoreDefinition
        /// class.
        /// </summary>
        public CompleteDatabaseRestoreDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CompleteDatabaseRestoreDefinition
        /// class.
        /// </summary>
        /// <param name="lastBackupName">The last backup name to apply</param>
        public CompleteDatabaseRestoreDefinition(string lastBackupName)
        {
            LastBackupName = lastBackupName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the last backup name to apply
        /// </summary>
        [JsonProperty(PropertyName = "lastBackupName")]
        public string LastBackupName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (LastBackupName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "LastBackupName");
            }
        }
    }
}
