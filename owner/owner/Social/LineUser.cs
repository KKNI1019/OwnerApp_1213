﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace owner.Social
{
    [JsonObject]
    public class LineUser
    {
        [JsonProperty("userId")]
        public string Id { get; set; }

        [JsonProperty("displayName")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("pictureUrl")]
        public string ProfileImage { get; set; }

        [JsonProperty("statusMessage")]
        public string StatusMessage { get; set; }
    }

    public class Payload
    {
        public string Iss { get; set; }
        public string Sub { get; set; }
        public string Aud { get; set; }
        public string Exp { get; set; }
        public string Iat { get; set; }
        public string Nonce { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; }
        public string Email { get; set; }
    }
}
