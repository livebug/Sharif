using Antlr4.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Tests
{
    [TestClass()]
    public class HiveParserTests
    {
        [TestMethod()]
        public void HiveParserTest()
        {
            string sql = "SELECT A,B,C FROM A;SELECT count(1) FROM A;";
            var charStream = CharStreams.fromString(sql);
            var lexer = new HiveLexer(charStream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new HiveParser(tokens);
            parser.BuildParseTree = true;
            var tree = parser.statements();
            Console.WriteLine(tree.ToStringTree(parser));
            Assert.IsNotNull(tree);
        }
    }

}