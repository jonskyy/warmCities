using System;
using System.IO;
using System.Net;

namespace ConsoleApp3
{
    /// <summary>
    /// Getting data from the API
    /// </summary>
    public class HttpProvider
    {
        public string LoadData()
        {
            string addressUrl = "https://danepubliczne.imgw.pl/api/data/synop";
            string webAddress = String.Format(addressUrl);
            WebRequest requestObjGet = WebRequest.Create(webAddress);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            string content = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                content = sr.ReadToEnd();
                sr.Close();
            }

            return content;
        }
    }
}
