using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishForm
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"/home/lime/form.html";
            //string path = @"C:\Users\User\source\repos\CgiExamples\HtmlForm\form.html";
            string html;

            Console.WriteLine("Content-Type: text/html \n\n");
            try
            {
                using (StreamReader s = new StreamReader(path))
                {
                    html = s.ReadToEnd();
                    Console.WriteLine(html);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
