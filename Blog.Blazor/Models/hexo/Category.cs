using System.Text.Json.Serialization;

namespace Blog.Blazor.Models.hexo
{
    public class Category
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("_id")]
        public string Id { get; set; }
    }
}
