using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishFormHandle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Content-Type: text/html \n\n");
            var queryStr = Environment.GetEnvironmentVariable("QUERY_STRING");
            Console.WriteLine(queryStr);
        }
    }
}
