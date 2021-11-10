using System.Text.Json.Serialization;
#nullable disable

namespace Models.Hexo
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
