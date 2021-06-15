using Lucene.Net.Analysis.Standard;
using Lucene.Net.QueryParsers.Classic;
using Version = Lucene.Net.Util.LuceneVersion;
using System;

namespace Version4._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchPhrase1 = "Variant1 - Variant2";
            var searchPhrase2 = "Variant1 + Variant2";

            var parser = new QueryParser(Version.LUCENE_48, "_content", new StandardAnalyzer(Version.LUCENE_48))
            {
                DefaultOperator = QueryParserBase.AND_OPERATOR
            };

            Console.WriteLine(parser.Parse(searchPhrase1).ToString());
            Console.WriteLine(parser.Parse(searchPhrase2).ToString());

            Console.Read();
        }
    }
}
