using System.Text.Json.Serialization;

#nullable disable
namespace Models.Hexo
{
    public partial class Meta
    {
        [JsonPropertyName("version")]
        public long Version { get; set; }

        [JsonPropertyName("warehouse")]
        public string Warehouse { get; set; }
    }
}
