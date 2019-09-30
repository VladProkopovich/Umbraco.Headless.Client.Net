﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Umbraco.Headless.Client.Net.Delivery.Models
{
    public class ContentCollection<T> where T : IContentBase
    {
        [JsonProperty("content")]
        public IEnumerable<T> Items { get; set; }
    }

    public class ContentCollection
    {
        [JsonProperty("content")]
        public IEnumerable<Content> Items { get; set; }
    }
}