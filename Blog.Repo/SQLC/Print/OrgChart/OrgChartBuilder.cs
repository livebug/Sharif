using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repo.SQLC.Print.OrgChart
{
    public static class OrgChartBuilder
    {
        public static OrgChartTreeNode Build(string SqlStatement,out string error)
        {
            return Build(SqlStatement, out string str, out error);
        }
        public static OrgChartTreeNode Build(string SqlStatement,out string outstr, out string error)
        {
            var charStream = CharStreams.fromString(SqlStatement);
            var lexer = new HiveLexer(charStream);
            var tokens = new CommonTokenStream(lexer);
            StringWriter output = new StringWriter();
            StringWriter errorOutput = new StringWriter();
            var parser = new HiveParser(tokens, output, errorOutput);
            parser.BuildParseTree = true;
            var tree = parser.statements();
            error = errorOutput.ToString();
            outstr = tree.ToStringTree(parser);
            return OrgChartBuilder.InitLispTree(outstr);
        }

        public static OrgChartTreeNode InitLispTree(string lispTree)
        {
            var root = new OrgChartTreeNode("root");
            var stack = new Stack<OrgChartTreeNode>();
            stack.Push(root);
            string content;
            for (int i = 0; i < lispTree.Length; i++)
            {
                var v_char = lispTree[i];
                //Console.WriteLine(v_char);
                // 读到 '('
                if (v_char == '(')
                {
                    OrgChartTreeNode node = new OrgChartTreeNode();
                    // 读取至下一个 ‘（’或者‘）’
                    (content, i) = ReadUnitl(lispTree, "()", i);
                    // 如果内容去首尾空格之后 内容不为空，正常元素
                    if (content.Trim().Length > 0)
                    {
                        var tmp_n = content;
                        var n = tmp_n.IndexOf(' ');
                        node.Name = n <= 0 ? tmp_n : tmp_n.Substring(0, n);
                        node.Title = n <= 0 ? "" : tmp_n.Substring(n);
                    }
                    // 只读到一个 ‘（’，是语句括号，此时按照正常结点处理，在发现语句反括号时，在对括号元素进行正确位置修复【to A】
                    else if (content.Trim().Length == 0)
                    {
                        node.Title = "(";
                        node.Name = "";
                    }
                    // 为了保证 叶结点 children 为空，子结点链表惰性加载
                    stack.Peek().AddChildrens(node);
                    stack.Push(node);
                }
                //  读到 ')'
                // 如果当前栈顶元素为 ‘（’
                else if (v_char == ')')
                {
                    // 说明 该对括号为语句括号，非LISP树括号 【接 A】
                    // 处理方法为，将括号‘（’的子结点【C】，转给父节点【P】
                    if (stack.Peek().Title == "(")
                    {
                        // 将括号‘（’的子结点【C】，转给父节点【P】，并清除子节点
                        stack.Pop().AdoptChildrensTo(stack.Peek());
                        // 将 ‘）’新增为叶节点 添加到父节点【P】上
                        stack.Peek().AddChildrens(new OrgChartTreeNode(title: ")", name: ""));
                    }
                    // 其他则退出栈顶元素，总是保持栈顶为最新根
                    else
                        stack.Pop();
                }
                // 读到不是 ‘（’和‘）’的元素，都是叶节点
                else
                {
                    //读取直至下一个 ‘（’或者‘）’
                    (content, i) = ReadUnitl(lispTree, "()", i);
                    // 内容不为空 添加子节点
                    if (content.ToString().Trim().Length > 0)
                        stack.Peek().AddChildrens(new OrgChartTreeNode(name: "", title: content));
                }
                content = null;
            }
            return root;
        }

        private static (string, int) ReadUnitl(string src, string until = " ", int start = 0)
        {
            var content = new StringBuilder();
            while (!until.Contains(src[start + 1]))
            {
                start++;
                content.Append(src[start]);
            }
            return (content.ToString(), start);
        }
    }
}
