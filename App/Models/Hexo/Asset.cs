using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
#nullable disable
namespace Models.Hexo
{
    public class Asset
    {
        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("path")]
        public string Path { get; set; }

        [JsonPropertyName("modified")]
        public long Modified { get; set; }

        [JsonPropertyName("renderable")]
        public long Renderable { get; set; }
    }
}
