using System.Text.Json.Serialization;
#nullable disable

namespace Models.Hexo
{
    public class Category
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("_id")]
        public string Id { get; set; }
    }
}
