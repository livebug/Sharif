using System.Text.Json.Serialization;

namespace Blog.Blazor.Models.hexo
{
    public class PostTag
    {
        [JsonPropertyName("post_id")]
        public string PostId { get; set; }

        [JsonPropertyName("tag_id")]
        public string TagId { get; set; }

        [JsonPropertyName("_id")]
        public string Id { get; set; }
    }
}
