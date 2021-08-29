using System.Text.Json.Serialization;

namespace Blog.Blazor.Models.hexo
{
    public class Cache
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("hash")]
        public string Hash { get; set; }

        [JsonPropertyName("modified")]
        public long Modified { get; set; }
    }
}
