using System.Text.Json.Serialization;
#nullable disable

namespace Models.Hexo
{
    public class Site
    {
        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}
