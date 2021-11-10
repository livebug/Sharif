using System.Text.Json.Serialization;
#nullable disable

namespace Models.Hexo
{
    public class PostCategory
    {
        [JsonPropertyName("post_id")]
        public string PostId { get; set; }

        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        [JsonPropertyName("_id")]
        public string Id { get; set; }
    }
}
