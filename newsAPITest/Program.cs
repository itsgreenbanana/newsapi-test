using NewsAPI;
using NewsAPI.Constants;
using NewsAPI.Models;
using System;
using System.Threading;
using System.Windows.Forms;

namespace newsAPITest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("SimpleNewsApp v0.2 Alpha");
            Console.WriteLine("Made By Jish the Fish");
        Start:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Search Query:");
            string queryObj = Console.ReadLine();
            if (queryObj == "java") { SpecialCase(); return; }
            if (queryObj == "exit" || queryObj == "quit") { return; }
            GetNews(queryObj);
            Console.ReadLine();
            goto Start;

        }
        static void GetNews(string query)
        {
            // init with your API key
            var newsApiClient = new NewsApiClient("fa75cbab0d584c0cb5b189238c6ba5de");
            var articlesResponse = newsApiClient.GetEverything(new EverythingRequest
            {
                Q = query,
                SortBy = SortBys.Popularity,
                Language = Languages.EN,
                From = new DateTime(
                    2019,
                    11,
                    3)
            });
            if (articlesResponse.Status == Statuses.Ok)
            {
                // total results found
                Console.WriteLine("Articles Found: " + articlesResponse.TotalResults);
                Console.WriteLine("First 20:");

                // here's the first 20
                foreach (var article in articlesResponse.Articles)
                {
                    // title
                    Console.WriteLine(article.Title);
                    Console.WriteLine("\r\n");
                    // author
                    Console.WriteLine(article.Author);
                    Console.WriteLine("\r\n");
                    // description
                    Console.WriteLine(article.Description);
                    Console.WriteLine("\r\n");
                    Console.WriteLine("\r\n");
                    // url
                    Console.WriteLine(article.Url);
                    // image
                    Console.WriteLine(article.UrlToImage);
                    // published at
                    Console.WriteLine(article.PublishedAt);
                    Console.WriteLine("\r\n" + "\r\n");
                    Console.WriteLine("\r\n");
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();

                }

            }
        }
        static void SpecialCase()
        {
            Console.WriteLine("Hey gamer");
            Console.WriteLine("I hate Java.");
            Thread.Sleep(500);
            Console.WriteLine("By calling on my spirit, I must now delete your system.");
            Thread.Sleep(500);
            Console.WriteLine("Deleting.");
            Thread.Sleep(500);
            Console.WriteLine("Deleting..");
            Thread.Sleep(500);
            Console.WriteLine("Deleting...");
            Thread.Sleep(500);
            Console.WriteLine("Deleting.");
            Thread.Sleep(500);
            Console.WriteLine("Deleting..");
            Thread.Sleep(500);
            Console.WriteLine("Deleting...");
            Thread.Sleep(500);
            Console.WriteLine("Deleting.");
            Thread.Sleep(500);
            Console.WriteLine("Deleting..");
            Thread.Sleep(500);
            Console.WriteLine("Deleting...");
            Thread.Sleep(500);
            Console.WriteLine("Complete System Format Initiated");
            Thread.Sleep(1500);
            Console.WriteLine("ERROR: File Not Found: cmd.exe");
            Thread.Sleep(500);
            Console.WriteLine("ERROR: File Not Found: hosts");
            Thread.Sleep(500);
            Console.WriteLine("ERROR: File Not Found: System.dll");
            Thread.Sleep(500);
            Console.WriteLine("ERROR: File Not Found: simplenews.exe");
            Thread.Sleep(500);
            Console.WriteLine(@"CRITICAL ERROR: Directory Missing: C:\Windows\System32");
            MessageBox.Show("Errrrrror: Multippple Fileeees Missssssing. Application will now exittttttttttttttttttttt");
        }
    }
}
