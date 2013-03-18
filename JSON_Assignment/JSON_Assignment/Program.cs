using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace JSON_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string myData = RedditData.GetData();
            //string[] words = Regex.Split(myData, ":,");
            //foreach (var s in words)
            //{
            //    Console.WriteLine(words);
            //}
            
            Console.WriteLine(myData);
            Console.ReadLine();
        }

      
    }
}
