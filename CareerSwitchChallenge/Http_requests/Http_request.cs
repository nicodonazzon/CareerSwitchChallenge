using System;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace CareerSwitchChallenge.Http_req
{
    static class Http_request
    {
        static public string HttpGet(string url)
        {
            WebClient client = new WebClient();

            client.Headers.Add("user-agent", "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");

            Stream data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            string str = reader.ReadToEnd();
            data.Close();
            reader.Close();

            return str;
        }
        static public string HttpPost(Object obj, string url)
        {
            string data;
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            StreamWriter requestWriter = new StreamWriter(request.GetRequestStream());
            string jsondata = JsonConvert.SerializeObject(obj);
            requestWriter.Write(jsondata);
            requestWriter.Close();
            WebResponse response = request.GetResponse();
            using var reqstream = response.GetResponseStream();
            {
                StreamReader reader = new StreamReader(response.GetResponseStream());
                data = reader.ReadToEnd();
            }
            return data;
        }
    }
}
