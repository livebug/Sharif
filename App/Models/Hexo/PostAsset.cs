using System.Text.Json.Serialization;
#nullable disable

namespace Models.Hexo
{
    public class PostAsset
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("post")]
        public string Post { get; set; }

        [JsonPropertyName("modified")]
        public long Modified { get; set; }

        [JsonPropertyName("renderable")]
        public long Renderable { get; set; }
    }
}
