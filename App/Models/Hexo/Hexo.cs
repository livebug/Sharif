using System.Text.Json.Serialization;

#nullable disable
namespace Models.Hexo
{
    public partial class HexoJsonObj
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("models")]
        public HexoContent HexoContent { get; set; }
    }
}
