using System.Text.Json.Serialization;

namespace Blog.Blazor.Models.hexo
{
    public class Site
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}
