using Lucene.Net.Analysis.Standard;
using Lucene.Net.QueryParsers;
using System;
using Version = Lucene.Net.Util.Version;

namespace Version3.x
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchPhrase = "Variant1 - Variant2";
            var searchPhrase1 = "Variant1 + Variant2";

            var parser = new QueryParser(Version.LUCENE_30, "content", new StandardAnalyzer(Version.LUCENE_30))
            {
                DefaultOperator = QueryParser.Operator.AND
            };

            Console.WriteLine(parser.Parse(searchPhrase).ToString());
            Console.WriteLine(parser.Parse(searchPhrase1).ToString());

            Console.Read();
        }
    }
}
