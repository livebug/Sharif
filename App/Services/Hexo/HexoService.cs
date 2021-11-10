using Microsoft.Extensions.Logging;
using Models.Hexo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

#nullable disable
namespace Services.Hexo
{
    public class HexoService
    {
        private HttpClient _http;
        protected HexoContent _hexoContent;
        private ILogger<HexoService> _logger;
        public HexoService(HttpClient http, ILogger<HexoService> logger)
        {
            _http = http; 
            _logger = logger;
        }

        public async Task InitHexoContentAsync(string hexodbPath)
        {
            _logger.LogInformation("InitHexoContentAsync");
            var res = await _http.GetFromJsonAsync<HexoJsonObj>(hexodbPath);
            if (res is not null)
            {
                _hexoContent = res.HexoContent;
                for (int i = 0; i < _hexoContent.Post.Count; i++)
                {
                    var post_id = _hexoContent.Post[i].Id;
                    var tag_ids = _hexoContent.PostTag.Where(e => e.PostId == post_id).Select(e => e.TagId);
                    var tags = _hexoContent.Tag.Join(tag_ids, e => e.Id, id => id, (tag, id) => tag);
                    _hexoContent.Post[i].Tags = tags;
                }
            }
            else
                throw new NullReferenceException("InitHexoContentAsync Error : res IS NULL");
        } 

        public IEnumerable<Post> GetAllPosts()
        {
            return _hexoContent.Post?.ToArray();
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

        public IReadOnlyDictionary<Category, IEnumerable<Post>> GetTagPostsDict()
        {
            var res = new Dictionary<Category, IEnumerable<Post>>();
            foreach (var tag in _hexoContent.Tag)
            {
                var post_ids = _hexoContent.PostTag.Where(e => e.TagId == tag.Id).Select(e => e.PostId);
                var posts = _hexoContent.Post.Where(e => post_ids.Contains(e.Id));
                res.Add(tag, posts);
            }
            return res;
        }

        public IEnumerable<Category> GetAllTags()
        {
            return _hexoContent.Tag;
        }
    }
}
