using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON_Assignment
{
    public class RedditData
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public int Score { get; set; }
        public string Permalink { get; set; }
        public string Author { get; set; }

        public static string GetData()
        {
            var stream = File.OpenText("redditfront.txt");
            string text = stream.ReadToEnd();

            //StreamReader myReader = new StreamReader("redditfront.json");
            //string line = "";
            //string result = "";

            //while (line != null)
            //{
            //    line = myReader.ReadLine();
            //    if (line != null)
            //    {
            //        result += line;
            //    }
            //}
            //myReader.Close();

            return text;

        }
    }

   
}
