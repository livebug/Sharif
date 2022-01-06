using System.Text.Json.Serialization;

namespace Blog.Repo.SQLC.Print.OrgChart
{
    public class OrgChartTreeNode
    {
        public OrgChartTreeNode()
        {
        }
        public OrgChartTreeNode(string name, string? title = null)
        {
            Name = name;
            Title = title;
        }
        public void AddChildrens(params OrgChartTreeNode[] nodes)
        {
            if (Children is null)
                Children = new List<OrgChartTreeNode>();
            foreach (var node in nodes)
            {
                Children.Add(node);
            }
        }
        public void AdoptChildrensTo(OrgChartTreeNode node)
        {
            if (Children is not null && node.Children is not null)
            {
                ((List<OrgChartTreeNode>)Children).ForEach(node.Children.Add);
                Children = null;
            }
        }
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("title")]
        public string? Title { get; set; }
        [JsonPropertyName("children")]
        public IList<OrgChartTreeNode>? Children { get; set; }
    }
}
