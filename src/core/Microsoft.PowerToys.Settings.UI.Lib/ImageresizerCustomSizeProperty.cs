// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Lib
{
    public class ImageresizerCustomSizeProperty
    {
        [JsonPropertyName("value")]
        public ImageSize Value { get; set; }

        public ImageresizerCustomSizeProperty()
        {
            this.Value = new ImageSize();
        }

        public ImageresizerCustomSizeProperty(ImageSize value)
        {
            Value = value;
        }
    }
}
