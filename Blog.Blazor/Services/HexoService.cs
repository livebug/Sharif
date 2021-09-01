using Blog.Blazor.Models.hexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static Blog.Blazor.Pages.FetchData;
using static System.Net.WebRequestMethods;

namespace Blog.Blazor.Services
{
    public class HexoService
    {
        private HttpClient _http;
        protected HexoContent _hexoContent;
        public HexoService(HttpClient http)
        {
            _http = http;
        }

        public async Task FlashHexoContent()
        {
            try
            {
                var hexo = await _http.GetFromJsonAsync<Hexo>("sample-data/hexodb.json");
                _hexoContent = hexo.HexoContent;
            }
            catch (Exception)
            {
                throw new Exception("Flash HexoContent Failed!");
            }
        }

        public async Task InitHexoContentAsync()
        {
            try
            {
                var hexo = await _http.GetFromJsonAsync<Hexo>("sample-data/hexodb.json");
                _hexoContent = hexo.HexoContent;
            }
            catch (Exception)
            {
                //throw new Exception("Init HexoContent Failed!");
                throw;
            }

        }

        public IEnumerable<Post> GetAllPosts()
        {
            return _hexoContent.Post.ToArray();
        }

        public IEnumerable<TagTreeItem> GetTagTree()
        {
            var tagTree = new List<TagTreeItem>();
            foreach (var tag in _hexoContent.Tag)
            {
                var posts = _hexoContent.PostTag.Where(e => e.TagId == tag.Id).Select(e => e.PostId);
                tagTree.Add(new TagTreeItem
                {
                    Tag = tag,
                    Posts = _hexoContent.Post.Where(e => posts.Contains(e.Id))
                });
            }
            return tagTree;
        }
    }

    public class TagTreeItem
        {
        public Category Tag { get; set; }
        public IEnumerable<Post> Posts { get; set; }

    }

    public partial class Hexo
    {
        [JsonPropertyName("meta")]
        public Meta Meta { get; set; }

        [JsonPropertyName("models")]
        public HexoContent HexoContent { get; set; }
    }

    public partial class Meta
    {
        [JsonPropertyName("version")]
        public long Version { get; set; }

        [JsonPropertyName("warehouse")]
        public string Warehouse { get; set; }
    }

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
}
