// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Extensions;

    /// <summary>Public key information for client authentication</summary>
    public partial class KeyProperties
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json serialization has finished, allowing customization of the <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <paramref name= "returnNow" />
        /// output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <paramref name="returnNow" /> output
        /// parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode"/> into an instance of Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IKeyProperties.
        /// </summary>
        /// <param name="node">a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>
        /// an instance of Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IKeyProperties.
        /// </returns>
        public static Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.IKeyProperties FromJson(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode node)
        {
            return node is Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject json ? new KeyProperties(json) : null;
        }

        /// <summary>
        /// Deserializes a Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject into a new instance of <see cref="KeyProperties" />.
        /// </summary>
        /// <param name="json">A Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal KeyProperties(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_clientPublicKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject>("clientPublicKey"), out var __jsonClientPublicKey) ? Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.KeyDetails.FromJson(__jsonClientPublicKey) : _clientPublicKey;}
            {_candidatePublicKey = If( json?.PropertyT<Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject>("candidatePublicKey"), out var __jsonCandidatePublicKey) ? Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Models.KeyDetails.FromJson(__jsonCandidatePublicKey) : _candidatePublicKey;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="KeyProperties" /> into a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="KeyProperties" /> as a <see cref="Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode" />.
        /// </returns>
        public Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode ToJson(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject container, Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._clientPublicKey ? (Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode) this._clientPublicKey.ToJson(null,serializationMode) : null, "clientPublicKey" ,container.Add );
            }
            if (serializationMode.HasFlag(Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.SerializationMode.IncludeRead))
            {
                AddIf( null != this._candidatePublicKey ? (Microsoft.Azure.PowerShell.Cmdlets.ArcGateway.Runtime.Json.JsonNode) this._candidatePublicKey.ToJson(null,serializationMode) : null, "candidatePublicKey" ,container.Add );
            }
            AfterToJson(ref container);
            return container;
        }
    }
}