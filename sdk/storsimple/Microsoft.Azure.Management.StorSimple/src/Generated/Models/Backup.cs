// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple1200Series.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The backup.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class Backup : BaseModel
    {
        /// <summary>
        /// Initializes a new instance of the Backup class.
        /// </summary>
        public Backup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Backup class.
        /// </summary>
        /// <param name="sizeInBytes">The backup size in bytes.</param>
        /// <param name="initiatedBy">Indicates how the backup was initiated
        /// "Manual | Scheduled". Possible values include: 'Manual',
        /// 'Scheduled'</param>
        /// <param name="deviceId">The Device Identifier.</param>
        /// <param name="elements">The backup elements.</param>
        /// <param name="id">The identifier.</param>
        /// <param name="name">The name.</param>
        /// <param name="type">The type.</param>
        /// <param name="targetId">The path id of the target FileServer or
        /// IscsiServer for which the backup was taken.</param>
        /// <param name="targetType">Type of target, FileServer or
        /// IscsiServer</param>
        /// <param name="createdTime">The time when the backup was
        /// created.</param>
        /// <param name="expirationTime">The time when the backup will
        /// expire.</param>
        public Backup(long sizeInBytes, InitiatedBy initiatedBy, string deviceId, IList<BackupElement> elements, string id = default(string), string name = default(string), string type = default(string), string targetId = default(string), string targetType = default(string), System.DateTime? createdTime = default(System.DateTime?), System.DateTime? expirationTime = default(System.DateTime?))
            : base(id, name, type)
        {
            TargetId = targetId;
            TargetType = targetType;
            SizeInBytes = sizeInBytes;
            CreatedTime = createdTime;
            ExpirationTime = expirationTime;
            InitiatedBy = initiatedBy;
            DeviceId = deviceId;
            Elements = elements;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the path id of the target FileServer or IscsiServer
        /// for which the backup was taken.
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetId")]
        public string TargetId { get; set; }

        /// <summary>
        /// Gets or sets type of target, FileServer or IscsiServer
        /// </summary>
        [JsonProperty(PropertyName = "properties.targetType")]
        public string TargetType { get; set; }

        /// <summary>
        /// Gets or sets the backup size in bytes.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sizeInBytes")]
        public long SizeInBytes { get; set; }

        /// <summary>
        /// Gets or sets the time when the backup was created.
        /// </summary>
        [JsonProperty(PropertyName = "properties.createdTime")]
        public System.DateTime? CreatedTime { get; set; }

        /// <summary>
        /// Gets or sets the time when the backup will expire.
        /// </summary>
        [JsonProperty(PropertyName = "properties.expirationTime")]
        public System.DateTime? ExpirationTime { get; set; }

        /// <summary>
        /// Gets or sets indicates how the backup was initiated "Manual |
        /// Scheduled". Possible values include: 'Manual', 'Scheduled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.initiatedBy")]
        public InitiatedBy InitiatedBy { get; set; }

        /// <summary>
        /// Gets or sets the Device Identifier.
        /// </summary>
        [JsonProperty(PropertyName = "properties.deviceId")]
        public string DeviceId { get; set; }

        /// <summary>
        /// Gets or sets the backup elements.
        /// </summary>
        [JsonProperty(PropertyName = "properties.elements")]
        public IList<BackupElement> Elements { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (DeviceId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeviceId");
            }
            if (Elements == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Elements");
            }
            if (Elements != null)
            {
                foreach (var element in Elements)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
        }
    }
}
