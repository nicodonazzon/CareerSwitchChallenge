using System;
using Newtonsoft.Json;
using CareerSwitchChallenge.Models;
using System.Net;
using System.IO;
using CareerSwitchChallenge.Http_req;

namespace CareerSwitchChallenge.API
{
    static class Check_API
    {
        static public Boolean Is_secuential(BlockCheck block,string url, string token)
        {
            string url_req = url + "?token=" + token;
            string data = Http_request.HttpPost(block, url_req);
            Response is_secuential = JsonConvert.DeserializeObject<Response>(data);
            return is_secuential.Message;
        }
    }
}
