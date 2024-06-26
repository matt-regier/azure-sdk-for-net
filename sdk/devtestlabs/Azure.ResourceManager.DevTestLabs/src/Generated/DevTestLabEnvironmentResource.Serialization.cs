// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.DevTestLabs
{
    public partial class DevTestLabEnvironmentResource : IJsonModel<DevTestLabEnvironmentData>
    {
        void IJsonModel<DevTestLabEnvironmentData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabEnvironmentData>)Data).Write(writer, options);

        DevTestLabEnvironmentData IJsonModel<DevTestLabEnvironmentData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<DevTestLabEnvironmentData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<DevTestLabEnvironmentData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write(Data, options);

        DevTestLabEnvironmentData IPersistableModel<DevTestLabEnvironmentData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<DevTestLabEnvironmentData>(data, options);

        string IPersistableModel<DevTestLabEnvironmentData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<DevTestLabEnvironmentData>)Data).GetFormatFromOptions(options);
    }
}
