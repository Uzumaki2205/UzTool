using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzTool.Method
{
    class News
    {
        public List<List<string>> getVNNew(string html)
        {
            HtmlWeb htmlWeb = new HtmlWeb()
            {
                AutoDetectEncoding = false,
                OverrideEncoding = Encoding.UTF8  //Set UTF8 để hiển thị tiếng Việt
            };

            HtmlDocument document = htmlWeb.Load(html);

            var threadItems = document.DocumentNode.SelectNodes("//article[@class='item-news item-news-common']/p").ToList();
            List<List<string>> listNews = new List<List<string>>();

            foreach (var item in threadItems)
            {
                var node = item.ChildNodes["a"];
                string title = node.Attributes["title"].Value;
                string descriptions = node.InnerText;
                string link = node.Attributes["href"].Value;
                listNews.Add(new List<string>() { title, descriptions, link });
            }

            return listNews;
        }
    }
}
