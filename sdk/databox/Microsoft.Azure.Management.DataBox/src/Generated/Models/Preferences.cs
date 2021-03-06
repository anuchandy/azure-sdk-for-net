// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataBox.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Preferences related to the order
    /// </summary>
    public partial class Preferences
    {
        /// <summary>
        /// Initializes a new instance of the Preferences class.
        /// </summary>
        public Preferences()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Preferences class.
        /// </summary>
        /// <param name="preferredDataCenterRegion">Preferred Data Center
        /// Region.</param>
        /// <param name="transportPreferences">Preferences related to the
        /// shipment logistics of the sku.</param>
        public Preferences(IList<string> preferredDataCenterRegion = default(IList<string>), TransportPreferences transportPreferences = default(TransportPreferences))
        {
            PreferredDataCenterRegion = preferredDataCenterRegion;
            TransportPreferences = transportPreferences;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets preferred Data Center Region.
        /// </summary>
        [JsonProperty(PropertyName = "preferredDataCenterRegion")]
        public IList<string> PreferredDataCenterRegion { get; set; }

        /// <summary>
        /// Gets or sets preferences related to the shipment logistics of the
        /// sku.
        /// </summary>
        [JsonProperty(PropertyName = "transportPreferences")]
        public TransportPreferences TransportPreferences { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TransportPreferences != null)
            {
                TransportPreferences.Validate();
            }
        }
    }
}
