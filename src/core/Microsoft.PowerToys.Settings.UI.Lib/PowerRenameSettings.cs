// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Microsoft.PowerToys.Settings.UI.Lib
{
    public class PowerRenameSettings : BasePTModuleSettings
    {
        public PowerRenameProperties Properties { get; set; }

        public PowerRenameSettings()
        {
            Properties = new PowerRenameProperties();
            Version = "1";
            Name = "PowerRename";
        }

        public PowerRenameSettings(PowerRenameLocalProperties localProperties)
        {
            Properties = new PowerRenameProperties();
            Properties.PersistState.Value = localProperties.PersistState;
            Properties.MRUEnabled.Value = localProperties.MRUEnabled;
            Properties.MaxMRUSize.Value = localProperties.MaxMRUSize;
            Properties.ShowIcon.Value = localProperties.ShowIcon;
            Properties.ExtendedContextMenuOnly.Value = localProperties.ExtendedContextMenuOnly;

            Version = "1";
            Name = "PowerRename";
        }

        public PowerRenameSettings(string ptName)
        {
            Properties = new PowerRenameProperties();
            Version = "1";
            Name = ptName;
        }

        public override string ToJsonString()
        {
            return JsonSerializer.Serialize(this);
        }
    }
}
