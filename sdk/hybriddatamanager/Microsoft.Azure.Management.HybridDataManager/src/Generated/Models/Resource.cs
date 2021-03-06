// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.HybridData.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Model of the Resource.
    /// </summary>
    public partial class Resource : IResource
    {
        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        public Resource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Resource class.
        /// </summary>
        /// <param name="location">The location of the resource. This will be
        /// one of the supported and registered Azure Geo Regions (e.g. West
        /// US, East
        /// US, Southeast Asia, etc.). The geo region of a resource cannot be
        /// changed once it is created, but if an identical geo
        /// region is specified on update the request will succeed.</param>
        /// <param name="id">The Resource Id.</param>
        /// <param name="name">The Resource Name.</param>
        /// <param name="type">The Resource type.</param>
        /// <param name="tags">The list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource
        /// (across resource groups).</param>
        /// <param name="sku">The sku type.</param>
        public Resource(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), Sku sku = default(Sku))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            Tags = tags;
            Sku = sku;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the Resource Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets the Resource Name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets the Resource type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets or sets the location of the resource. This will be one of the
        /// supported and registered Azure Geo Regions (e.g. West US, East
        /// US, Southeast Asia, etc.). The geo region of a resource cannot be
        /// changed once it is created, but if an identical geo
        /// region is specified on update the request will succeed.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the list of key value pairs that describe the
        /// resource. These tags can be used in viewing and grouping this
        /// resource
        /// (across resource groups).
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Gets or sets the sku type.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Location == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Location");
            }
        }
    }
}
