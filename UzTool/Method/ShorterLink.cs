using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using xNet;

namespace UzTool.Method
{
    class ShorterLink
    {
        public string TinyURL(string strURL)
        {
            string URL;
            URL = "http://tinyurl.com/api-create.php?url=" + strURL.ToLower();

            HttpWebRequest objWebRequest;
            HttpWebResponse objWebResponse;
            string strHTML;

            objWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            objWebRequest.Method = "GET";

            objWebResponse = (HttpWebResponse)objWebRequest
               .GetResponse();
            StreamReader srReader = new StreamReader(objWebResponse.GetResponseStream());

            strHTML = srReader.ReadToEnd();

            srReader.Close();
            objWebResponse.Close();
            objWebRequest.Abort();

            return strHTML;
        }

        public string BomURL(string url, string custom)
        {
            var request = (HttpWebRequest)WebRequest.Create("https://bom.to/shorten");
            var postData = "url=" + Uri.EscapeDataString(url) + "&custom=" 
                + Uri.EscapeDataString(custom) + "&multiple=" 
                + Uri.EscapeDataString("0"); 
            var data = Encoding.ASCII.GetBytes(postData);

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = data.Length;

            using (var stream = request.GetRequestStream())
            {
                stream.Write(data, 0, data.Length);
            }

            var response = (HttpWebResponse)request.GetResponse();

            string responseString = new StreamReader(response.GetResponseStream()).ReadToEnd();

            return responseString;
        }
    }
}
