﻿namespace Microsoft.CommonDataModel.ObjectModel.Persistence.ModelJson.types
{
    using Newtonsoft.Json;

    /// <summary>
    /// Represents a base class for file format settings.
    /// </summary>
    public class FileFormatSettings
    {
        [JsonProperty("$type", NullValueHandling = NullValueHandling.Ignore, Order = -2)]
        public string Type { get; set; }
    }
}
