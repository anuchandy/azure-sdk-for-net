// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Subscription.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// status of the subscription POST operation.
    /// </summary>
    public partial class SubscriptionOperation
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionOperation class.
        /// </summary>
        public SubscriptionOperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionOperation class.
        /// </summary>
        /// <param name="id">The operation Id.</param>
        /// <param name="status">Status of the pending subscription</param>
        /// <param name="statusDetail">Status Detail of the pending
        /// subscription</param>
        public SubscriptionOperation(string id = default(string), string status = default(string), string statusDetail = default(string))
        {
            Id = id;
            Status = status;
            StatusDetail = statusDetail;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the operation Id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets status of the pending subscription
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets status Detail of the pending subscription
        /// </summary>
        [JsonProperty(PropertyName = "statusDetail")]
        public string StatusDetail { get; set; }

    }
}