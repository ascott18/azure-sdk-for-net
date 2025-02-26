// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.AppService.Models;

namespace Azure.ResourceManager.AppService
{
    public partial class WebSiteInstanceStatusData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind");
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state");
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StatusUrl))
            {
                writer.WritePropertyName("statusUrl");
                writer.WriteStringValue(StatusUrl);
            }
            if (Optional.IsDefined(DetectorUrl))
            {
                writer.WritePropertyName("detectorUrl");
                writer.WriteStringValue(DetectorUrl);
            }
            if (Optional.IsDefined(ConsoleUrl))
            {
                writer.WritePropertyName("consoleUrl");
                writer.WriteStringValue(ConsoleUrl);
            }
            if (Optional.IsDefined(HealthCheckUrl))
            {
                writer.WritePropertyName("healthCheckUrl");
                writer.WriteStringValue(HealthCheckUrl);
            }
            if (Optional.IsCollectionDefined(Containers))
            {
                writer.WritePropertyName("containers");
                writer.WriteStartObject();
                foreach (var item in Containers)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static WebSiteInstanceStatusData DeserializeWebSiteInstanceStatusData(JsonElement element)
        {
            Optional<string> kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SiteRuntimeState> state = default;
            Optional<string> statusUrl = default;
            Optional<string> detectorUrl = default;
            Optional<string> consoleUrl = default;
            Optional<string> healthCheckUrl = default;
            Optional<IDictionary<string, ContainerInfo>> containers = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("state"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            state = property0.Value.GetString().ToSiteRuntimeState();
                            continue;
                        }
                        if (property0.NameEquals("statusUrl"))
                        {
                            statusUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("detectorUrl"))
                        {
                            detectorUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("consoleUrl"))
                        {
                            consoleUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("healthCheckUrl"))
                        {
                            healthCheckUrl = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("containers"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, ContainerInfo> dictionary = new Dictionary<string, ContainerInfo>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, ContainerInfo.DeserializeContainerInfo(property1.Value));
                            }
                            containers = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new WebSiteInstanceStatusData(id, name, type, kind.Value, Optional.ToNullable(state), statusUrl.Value, detectorUrl.Value, consoleUrl.Value, healthCheckUrl.Value, Optional.ToDictionary(containers));
        }
    }
}
