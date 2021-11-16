using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repo.SQLC
{
    public class TestVisitor : HiveParserBaseVisitor<string>
    {
        Dictionary<string, string> mem = new Dictionary<string, string>();
       

        public override string VisitFromClause([NotNull] HiveParser.FromClauseContext context)
        {
            Console.WriteLine(string.Join(",", context.GetText(), context.Start.ToString(),context.Stop.ToString()));

            return base.VisitFromClause(context);
        }
        public override string VisitFromSource([NotNull] HiveParser.FromSourceContext context)
        {
            Console.WriteLine(string.Join(",", context.GetText(), context.Start.ToString(), context.Stop.ToString()));

            return context.GetText();
        }
        public override string VisitSingleFromStatement([NotNull] HiveParser.SingleFromStatementContext context)
        {
            Console.WriteLine(string.Join(",", context.GetText(), context.Start.ToString(), context.Stop.ToString()));


            return base.VisitSingleFromStatement(context);
        }

        public override string VisitIdentifier([NotNull] HiveParser.IdentifierContext context)
        {
            Console.WriteLine(string.Join(",", context.GetText(), context.Start.ToString(), context.Stop.ToString()));

            return context.GetText();
        }
        public override string VisitTableName([NotNull] HiveParser.TableNameContext context)
        {
            Console.WriteLine(string.Join(",", context.GetText(), context.Start.ToString(), context.Stop.ToString()));

            return context.GetText();
        }
    }
}
