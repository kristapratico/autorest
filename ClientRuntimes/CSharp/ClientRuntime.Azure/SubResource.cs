// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

using Newtonsoft.Json;
using System.Diagnostics.CodeAnalysis;

namespace Microsoft.Azure
{
    /// <summary>
    /// Defines Azure sub-resource.
    /// </summary>
    public class SubResource : IResource
    {
        /// <summary>
        /// Gets the ID of the sub-resource.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets the provisioning state of the resource.
        /// </summary>
        [JsonProperty("properties.provisioningState")]
        public string ProvisioningState { get; private set; }
    }
}