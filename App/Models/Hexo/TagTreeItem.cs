using Models.Hexo;
#nullable disable

#nullable disable
namespace Models.Hexo
{
    public class TagTreeItem
    {
        public Category Tag { get; set; }
        public IEnumerable<Post> Posts { get; set; }

    }
}
