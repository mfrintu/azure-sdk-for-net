// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    internal partial class FilterGroup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Filter))
            {
                writer.WritePropertyName("filter"u8);
                writer.WriteStartArray();
                foreach (var item in Filter)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static FilterGroup DeserializeFilterGroup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<SelfHelpFilter>> filter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SelfHelpFilter> array = new List<SelfHelpFilter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SelfHelpFilter.DeserializeSelfHelpFilter(item));
                    }
                    filter = array;
                    continue;
                }
            }
            return new FilterGroup(Optional.ToList(filter));
        }
    }
}
