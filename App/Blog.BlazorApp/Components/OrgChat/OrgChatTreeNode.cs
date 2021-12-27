using System.Text.Json.Serialization;

namespace Blog.BlazorApp.Components.OrgChat
{
    public class OrgChatTreeNode
    {
        public OrgChatTreeNode()
        { 
        }
        public OrgChatTreeNode(string name, string  title = null)
        {
            Name = name;
            Title = title;
        }
        public void AddChildrens(params OrgChatTreeNode[] nodes)
        {
            if(this.Children is null)
                this.Children = new List<OrgChatTreeNode>();
            foreach(var node in nodes)
            {
                this.Children.Add(node);
            }
        }
        public void AdoptChildrensTo(OrgChatTreeNode node)
        {
            (this.Children as List<OrgChatTreeNode>).ForEach(node.Children.Add);
            this.Children = null;
        }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("children")]
        public IList<OrgChatTreeNode> Children { get; set; }
    }
}
