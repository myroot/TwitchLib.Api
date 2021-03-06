﻿using Newtonsoft.Json;

namespace TwitchLib.Api.ThirdParty.Models.AuthorizationFlow
{
    public class RefreshTokenResponse
    {
        [JsonProperty(PropertyName = "token")]
        public string Token { get; protected set; }
        [JsonProperty(PropertyName = "refresh")]
        public string Refresh { get; protected set; }
    }
}
