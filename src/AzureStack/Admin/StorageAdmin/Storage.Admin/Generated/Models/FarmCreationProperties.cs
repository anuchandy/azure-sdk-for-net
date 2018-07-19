// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.AzureStack.Management.Storage.Admin.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Storage farm properties.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class FarmCreationProperties : Resource
    {
        /// <summary>
        /// Initializes a new instance of the FarmCreationProperties class.
        /// </summary>
        public FarmCreationProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FarmCreationProperties class.
        /// </summary>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource Name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="location">Resource location.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="settingAccessStringProperty">Setting access
        /// string.</param>
        public FarmCreationProperties(string id = default(string), string name = default(string), string type = default(string), string location = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string settingAccessStringProperty = default(string))
            : base(id, name, type, location, tags)
        {
            SettingAccessStringProperty = settingAccessStringProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets setting access string.
        /// </summary>
        [JsonProperty(PropertyName = "properties.settingAccessString")]
        public string SettingAccessStringProperty { get; set; }

    }
}