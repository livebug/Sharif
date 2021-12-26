using System.Text.Json.Serialization;

namespace Blog.BlazorApp.Components.OrgChat
{
    public class OrgChatTreeNode
    {
        public OrgChatTreeNode()
        { 
        }
        public OrgChatTreeNode(string name, string content = null)
        {
            Name = name;
            Title = content;
            Children = new List<OrgChatTreeNode>();
        }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonIgnore]
        public int Depth { get; set; }
        [JsonIgnore]
        public int Sn { get; set; }
        [JsonPropertyName("children")]
        public IList<OrgChatTreeNode> Children { get; set; }
    }
}
