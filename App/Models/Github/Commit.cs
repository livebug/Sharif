using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

#nullable disable
namespace Models.Github
{
    public class Author
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string date { get; set; }
    }

    public class Committer
    {
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string date { get; set; }
    }

    public class Tree
    {
        /// <summary>
        /// 
        /// </summary>
        public string sha { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
    }

    public class Verification
    {
        /// <summary>
        /// 
        /// </summary>
        public string verified { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string reason { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string signature { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string payload { get; set; }
    }

    public class Commit
    {
        /// <summary>
        /// 
        /// </summary>
        public Author author { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Committer committer { get; set; }
        /// <summary>
        /// 20211116 增加TestVistor,测试观察者
        /// </summary>
        public string message { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Tree tree { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string url { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int comment_count { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonIgnore]
        public Verification verification { get; set; }
    }


}
