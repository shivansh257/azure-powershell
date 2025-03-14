// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Attestation.Models
{
    using System.Linq;

    /// <summary>
    /// Definition object with the name and properties of an operation.
    /// </summary>
    public partial class OperationsDefinition
    {
        /// <summary>
        /// Initializes a new instance of the OperationsDefinition class.
        /// </summary>
        public OperationsDefinition()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationsDefinition class.
        /// </summary>

        /// <param name="name">Name of the operation.
        /// </param>

        /// <param name="display">Display object with properties of the operation.
        /// </param>
        public OperationsDefinition(string name = default(string), OperationsDisplayDefinition display = default(OperationsDisplayDefinition))

        {
            this.Name = name;
            this.Display = display;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets name of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "name")]
        public string Name {get; set; }

        /// <summary>
        /// Gets or sets display object with properties of the operation.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "display")]
        public OperationsDisplayDefinition Display {get; set; }
    }
}