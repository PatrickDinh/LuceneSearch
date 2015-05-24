using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuceneSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var searcher = new Searcher();

            searcher.ClearLuceneIndex();
            searcher.AddUpdateLuceneIndex(SampleDataRepository.GetAll());

            var data = searcher.Search("City\\ in");

            foreach (var row in data)
            {
                Console.WriteLine(row.ToString());
            }

            Console.WriteLine("Done");
            Console.ReadLine();
        }
    }
}
