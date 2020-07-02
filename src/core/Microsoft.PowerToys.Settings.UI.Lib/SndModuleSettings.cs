// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json;
using System.Text.Json.Serialization;

#pragma warning disable SA1649 // File name should match first type name

namespace Microsoft.PowerToys.Settings.UI.Lib
{
    // Represents a powertoys module settings setnt to the runner.
    public class SndModuleSettings<T>
    {
        [JsonPropertyName("powertoys")]
        public T Powertoys { get; set; }

        public SndModuleSettings()
        {
        }

        public SndModuleSettings(T settings)
        {
            this.Powertoys = settings;
        }

        public string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
