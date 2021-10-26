using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Blog.Repo
{
    public class MDTools
    {
        public static IEnumerable<string> GetArticleMenu(StreamReader reader)
        {
            IDictionary<string, string> menu = new Dictionary<string, string>();
            try
            {
                string? line;
                // Read and display lines from the file until the end of
                // the file is reached.
                string pattern = @"^(#+) ";
                int[] level = new int[6];
                while ((line = reader.ReadLine()) != null)
                {
                    if (Regex.IsMatch(line, pattern))
                    {
                        var match = Regex.Match(line, pattern);
                        var len = match.Groups[1].Value.Length;
                        line = Regex.Replace(line, pattern, "".PadLeft(len));
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
            return Enumerable.Empty<string>();
        }
    }
}

/*
 * 文件管理
 * 1. 文件模板
 * 2. 根据文件模板解析文件
 * 
 * MD文件
 * 1. 分析MD文件
 * 
 */