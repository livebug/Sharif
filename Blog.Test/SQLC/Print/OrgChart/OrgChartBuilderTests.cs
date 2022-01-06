using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blog.Repo.SQLC.Print.OrgChart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Repo.SQLC.Print.OrgChart.Tests
{
    [TestClass()]
    public class OrgChartBuilderTests
    {
        [TestMethod()]
        public void BuildTest()
        {
            string SqlStatement = @"insert into C (C01,C02,C03,C04)
SELECT t1.a01 as c01,t1.b01 as c02,t2.bo2 ,t1.a05 ,t03.sumbal
FROM sha.A t1
left join qaw.B t2 on t1.b01=t2.b01 and t2.day_id= case when org='ABC' then '20211231' else '20211230' end
left join (select tt.q as ttq,tt.w as ttw,sum(bal) as sumbal from seesion.tmp tt where tt.day_id='20211231' group by tt.q,tt.w
    ) t03 on t03.tta||t03.ttw = t1.a05  ";
            OrgChartTreeNode Root = OrgChartBuilder.Build(SqlStatement,out string error);
            Console.WriteLine(error);
        }
    }
}