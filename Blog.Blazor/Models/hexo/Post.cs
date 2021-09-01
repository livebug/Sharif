using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Blog.Blazor.Models.hexo
{
    public class Post
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("date")]
        public DateTimeOffset Date { get; set; }

        [JsonPropertyName("_content")]
        public string Content { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("raw")]
        public string Raw { get; set; }

        [JsonPropertyName("slug")]
        public string Slug { get; set; }

        [JsonPropertyName("published")]
        public long Published { get; set; }

        [JsonPropertyName("updated")]
        public DateTimeOffset Updated { get; set; }

        [JsonPropertyName("comments")]
        public long Comments { get; set; }

        [JsonPropertyName("layout")]
        [JsonIgnore]
        public Layout Layout { get; set; }

        [JsonPropertyName("photos")]
        public List<object> Photos { get; set; }

        [JsonPropertyName("link")]
        public string Link { get; set; }

        [JsonPropertyName("_id")]
        public string Id { get; set; }

        [JsonPropertyName("content")]
        public string PostContent { get; set; }

        [JsonPropertyName("site")]
        public Site Site { get; set; }

        [JsonPropertyName("excerpt")]
        public string Excerpt { get; set; }

        [JsonPropertyName("more")]
        public string More { get; set; }
    }
    public enum Layout { Post };
}
