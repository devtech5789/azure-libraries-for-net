// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.BatchAI.Fluent.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// File Server mounting configuration.
    /// </summary>
    public partial class FileServerReference
    {
        /// <summary>
        /// Initializes a new instance of the FileServerReference class.
        /// </summary>
        public FileServerReference()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FileServerReference class.
        /// </summary>
        /// <param name="fileServer">File server.</param>
        /// <param name="relativeMountPath">Relative mount path.</param>
        /// <param name="sourceDirectory">Source directory.</param>
        /// <param name="mountOptions">Mount options.</param>
        public FileServerReference(ResourceId fileServer, string relativeMountPath, string sourceDirectory = default(string), string mountOptions = default(string))
        {
            FileServer = fileServer;
            SourceDirectory = sourceDirectory;
            RelativeMountPath = relativeMountPath;
            MountOptions = mountOptions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets file server.
        /// </summary>
        /// <remarks>
        /// Resource ID of the existing File Server to be mounted.
        /// </remarks>
        [JsonProperty(PropertyName = "fileServer")]
        public ResourceId FileServer { get; set; }

        /// <summary>
        /// Gets or sets source directory.
        /// </summary>
        /// <remarks>
        /// File Server directory that needs to be mounted. If this property is
        /// not specified, the entire File Server will be mounted.
        /// </remarks>
        [JsonProperty(PropertyName = "sourceDirectory")]
        public string SourceDirectory { get; set; }

        /// <summary>
        /// Gets or sets relative mount path.
        /// </summary>
        /// <remarks>
        /// The relative path on the compute node where the File Server will be
        /// mounted. Note that all cluster level file servers will be mounted
        /// under $AZ_BATCHAI_MOUNT_ROOT location and all job level file
        /// servers will be mounted under $AZ_BATCHAI_JOB_MOUNT_ROOT.
        /// </remarks>
        [JsonProperty(PropertyName = "relativeMountPath")]
        public string RelativeMountPath { get; set; }

        /// <summary>
        /// Gets or sets mount options.
        /// </summary>
        /// <remarks>
        /// Mount options to be passed to mount command.
        /// </remarks>
        [JsonProperty(PropertyName = "mountOptions")]
        public string MountOptions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (FileServer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FileServer");
            }
            if (RelativeMountPath == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "RelativeMountPath");
            }
            if (FileServer != null)
            {
                FileServer.Validate();
            }
        }
    }
}