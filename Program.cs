using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using HtmlAgilityPack;
using MariGold.HtmlParser;
using WebCrawler;

namespace webCrawler_PROG_ZAAW
{
    class Program 
    {

        
        

        


        static void Main(string[] args)
        {
            WebCrawlerClass WebCrawler = new WebCrawlerClass();

           
            var httpClient = new HttpClient();
            var t = httpClient.GetAsync("http://wp.pl").Result;

            WebCrawler.GetLinksFromHTMLContent()

            /*I gęstość
           
           var content = t.Content.ReadAsStringAsync().Result;

           var urlList = WebCrawler.GetLinksFromHTMLContent(content);

           //II gęstość

           foreach (var element in urlList)
           {
               var t2 = httpClient.GetAsync(element).Result;
               var content2 = t2.Content.ReadAsStringAsync().Result;
               var urlList2 = WebCrawler.GetLinksFromHTMLContent(content);
           }
           */



            Console.WriteLine(content);
        }
    }
}
