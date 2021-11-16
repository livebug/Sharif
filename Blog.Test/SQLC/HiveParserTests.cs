using Antlr4.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class HiveParserTests
    {
        [TestMethod()]
        public void HiveParserTest()
        {
            string sql = "WITH A AS (SELECT * FROM TB) SELECT A,B,C FROM A";
            var charStream = CharStreams.fromString(sql);
            var lexer = new HiveLexer(charStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new HiveParser(tokens);
            parser.BuildParseTree = true;
            var tree = parser.statements();
            Console.WriteLine(tree.ToStringTree());
            Assert.IsNotNull(tree);
        }
    }
}