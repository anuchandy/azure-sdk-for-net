// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An entity extractor create object.
    /// </summary>
    public partial class EntityModelCreateObject
    {
        /// <summary>
        /// Initializes a new instance of the EntityModelCreateObject class.
        /// </summary>
        public EntityModelCreateObject()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the EntityModelCreateObject class.
        /// </summary>
        /// <param name="children">Child entities.</param>
        /// <param name="name">Entity name.</param>
        public EntityModelCreateObject(IList<ChildEntityModelCreateObject> children = default(IList<ChildEntityModelCreateObject>), string name = default(string))
        {
            Children = children;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets child entities.
        /// </summary>
        [JsonProperty(PropertyName = "children")]
        public IList<ChildEntityModelCreateObject> Children { get; set; }

        /// <summary>
        /// Gets or sets entity name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
