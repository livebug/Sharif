using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blog.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Blog.Repo.Tests
{
    [TestClass()]
    public class MDToolsTests
    {
        [TestMethod()]
        public void GetArticleMenuTest()
        {
            using (StreamReader stream = new StreamReader(@"D:\Sharif\Blog.Test\TestFiles\test01.md"))
            {
                MDTools.GetArticleMenu(stream);
            }
            Assert.Fail();
        }
    }
}