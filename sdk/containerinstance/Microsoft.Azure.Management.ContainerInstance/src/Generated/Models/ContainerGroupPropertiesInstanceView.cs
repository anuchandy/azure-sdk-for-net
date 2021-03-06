// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ContainerInstance.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The instance view of the container group. Only valid in response.
    /// </summary>
    public partial class ContainerGroupPropertiesInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ContainerGroupPropertiesInstanceView class.
        /// </summary>
        public ContainerGroupPropertiesInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ContainerGroupPropertiesInstanceView class.
        /// </summary>
        /// <param name="events">The events of this container group.</param>
        /// <param name="state">The state of the container group. Only valid in
        /// response.</param>
        public ContainerGroupPropertiesInstanceView(IList<EventModel> events = default(IList<EventModel>), string state = default(string))
        {
            Events = events;
            State = state;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the events of this container group.
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<EventModel> Events { get; private set; }

        /// <summary>
        /// Gets the state of the container group. Only valid in response.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; private set; }

    }
}
