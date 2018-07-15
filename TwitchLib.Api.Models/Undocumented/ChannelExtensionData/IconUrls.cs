﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TwitchLib.Api.Core.Models.Undocumented.ChannelExtensionData
{
    public class IconUrls
    {
        [JsonProperty(PropertyName = "100x100")]
        public string Url100x100 { get; protected set; }
    }
}
