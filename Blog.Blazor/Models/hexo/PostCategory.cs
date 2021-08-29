using System.Text.Json.Serialization;

namespace Blog.Blazor.Models.hexo
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
