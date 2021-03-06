// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Client.Http.Serialization
{
    using System;
    using System.Collections.Generic;
    using Microsoft.ServiceFabric.Common;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;

    /// <summary>
    /// Converter for <see cref="FailedPropertyBatchInfo" />.
    /// </summary>
    internal class FailedPropertyBatchInfoConverter
    {
        /// <summary>
        /// Deserializes the JSON representation of the object.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from.</param>
        /// <returns>The object Value.</returns>
        internal static FailedPropertyBatchInfo Deserialize(JsonReader reader)
        {
            return reader.Deserialize(GetFromJsonProperties);
        }

        /// <summary>
        /// Gets the object from Json properties.
        /// </summary>
        /// <param name="reader">The <see cref="T: Newtonsoft.Json.JsonReader" /> to read from, reader must be placed at first property.</param>
        /// <returns>The object Value.</returns>
        internal static FailedPropertyBatchInfo GetFromJsonProperties(JsonReader reader)
        {
            var errorMessage = default(string);
            var operationIndex = default(int?);

            do
            {
                var propName = reader.ReadPropertyName();
                if (string.Compare("ErrorMessage", propName, StringComparison.Ordinal) == 0)
                {
                    errorMessage = reader.ReadValueAsString();
                }
                else if (string.Compare("OperationIndex", propName, StringComparison.Ordinal) == 0)
                {
                    operationIndex = reader.ReadValueAsInt();
                }
                else
                {
                    reader.SkipPropertyValue();
                }
            }
            while (reader.TokenType != JsonToken.EndObject);

            return new FailedPropertyBatchInfo(
                errorMessage: errorMessage,
                operationIndex: operationIndex);
        }

        /// <summary>
        /// Serializes the object to JSON.
        /// </summary>
        /// <param name="writer">The <see cref="T: Newtonsoft.Json.JsonWriter" /> to write to.</param>
        /// <param name="obj">The object to serialize to JSON.</param>
        internal static void Serialize(JsonWriter writer, FailedPropertyBatchInfo obj)
        {
            // Required properties are always serialized, optional properties are serialized when not null.
            writer.WriteStartObject();
            writer.WriteProperty(obj.Kind, "Kind", PropertyBatchInfoKindConverter.Serialize);
            if (obj.ErrorMessage != null)
            {
                writer.WriteProperty(obj.ErrorMessage, "ErrorMessage", JsonWriterExtensions.WriteStringValue);
            }

            if (obj.OperationIndex != null)
            {
                writer.WriteProperty(obj.OperationIndex, "OperationIndex", JsonWriterExtensions.WriteIntValue);
            }

            writer.WriteEndObject();
        }
    }
}
