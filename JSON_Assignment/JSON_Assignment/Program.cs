using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JSON_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myReader = new StreamReader("redditfront2.json");
            string getJson = myReader.ReadToEnd();
            myReader.Close();

            //JObject parseJson = JObject.Parse(getJson);

            //IList<JToken> results = parseJson["data"]["children"][0]["data"].Children().ToList();

            //IList<RedditData> dataLists = results.Select(data => JsonConvert.DeserializeObject<RedditData>(data.ToString())).ToList();

            Console.WriteLine(getJson);
            Console.ReadLine();
        }

      
    }
}
