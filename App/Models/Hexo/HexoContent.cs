using System.Text.Json.Serialization;

#nullable disable
namespace Models.Hexo;

public partial class HexoContent
{
    [JsonPropertyName("Asset")]
    public List<Asset> Asset { get; set; }

    [JsonPropertyName("Cache")]
    public List<Cache> Cache { get; set; }

    [JsonPropertyName("Category")]
    public List<Category> Category { get; set; }

    [JsonPropertyName("Data")]
    public List<object> Data { get; set; }

    [JsonPropertyName("Page")]
    public List<object> Page { get; set; }

    [JsonPropertyName("Post")]
    public List<Post> Post { get; set; }

    [JsonPropertyName("PostAsset")]
    public List<PostAsset> PostAsset { get; set; }

    [JsonPropertyName("PostCategory")]
    public List<PostCategory> PostCategory { get; set; }

    [JsonPropertyName("PostTag")]
    public List<PostTag> PostTag { get; set; }

    [JsonPropertyName("Tag")]
    public List<Category> Tag { get; set; }
}
