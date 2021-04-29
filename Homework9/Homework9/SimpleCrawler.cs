using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace Homework9
{
    class SimpleCrawler
    {
        public Hashtable urls = new Hashtable();
        public int count = 0;
        public string websitetocrawl = null;
        public string host = null;
        public int numofpages = 0;
        public bool isOnSamesite = true;
        public bool isOnHtml = true;
        public bool isOnRelative = true;

        public void Crawl()
        {
            Console.WriteLine("开始爬行了.... ");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }

                if (current == null || count > this.numofpages) break;
                
                Console.WriteLine("爬行" + current + "页面!");
                this.host = current;
                string html = DownLoad(current); // 下载
                urls[current] = true;
                count++;
                Parse(html);//解析,并加入新的链接
                Console.WriteLine("爬行结束");
            }
        }

        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string fileName = count.ToString();
                File.WriteAllText(fileName, html, Encoding.UTF8);
                Console.WriteLine("Downloading finished.\n");
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }

        public void Parse(string html)
        {
            string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {

                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                          .Trim('"', '\"', '#', '>');
                if (strRef.Length == 0) continue;
                if (IsRelative(strRef))
                {
                    strRef = host + strRef;
                }
                if (urls[strRef] == null && FurtherCrawl(strRef, this.websitetocrawl))
                {
                    urls[strRef] = false;
                    Console.WriteLine("the webpage " + strRef + " is going to be crawled.\n");
                }
            }
        }

        public bool IsHTML(string html)
        {
            if (!this.isOnHtml) {
                return true;
            }
            string strRef = @"[^""'#>]+.(html|HTML|aspx|ASPX|jsp|JSP)";
            return new Regex(strRef).IsMatch(html);
        }

        public bool FurtherCrawl(string html, string website)
        {
            return IsHTML(html) && IsTheSameWebsite(html, website);
        }

        public bool IsRelative(string html)
        {
            if (html.StartsWith("./") || html.StartsWith("../")||!this.isOnRelative)
            {
                return true;
            }
            return false;
        }

        public bool IsTheSameWebsite(string html, string website)
        {
            if (!this.isOnSamesite) {
                return true;
            }
            string thiswebsite = GetWebsite(html);
            return thiswebsite.Equals(website);

        }

        public static string GetWebsite(string html)
        {
            string strRef = @".[^""'.#>]+.(com|cn)";
            Match match = new Regex(strRef).Match(html);
            if (match.Value.Length <= 5)
            {
                return "";
            }
            string website = match.Value.Substring(match.Value.IndexOf('.') + 1, match.Value.Length - 5);
            return website;
        }
    }
}
