using System;
using System.Collections.Generic;
using System.Text;
using CareerSwitchChallenge.Models;
using CareerSwitchChallenge.Http_req;
using Newtonsoft.Json;

namespace CareerSwitchChallenge.API
{
    static class Success_API
    {
        static public Boolean Is_success(string url, List<string> ordered_blocks,string token)
        {
            string ordered_blocksstr = string.Join("", ordered_blocks);
            SuccessCheck blocks = new SuccessCheck();
            blocks.Encoded = ordered_blocksstr;
            string url_req = url + "?token=" + token;
            string data = Http_request.HttpPost(blocks, url_req);
            Response is_success = JsonConvert.DeserializeObject<Response>(data);
            return is_success.Message;
        }
        static public Boolean Is_success(string url, string ordered_blocks, string token)
        {
            SuccessCheck blocks = new SuccessCheck();
            blocks.Encoded = ordered_blocks;
            string url_req = url + "?token=" + token;
            string data = Http_request.HttpPost(blocks, url_req);
            Response is_success = JsonConvert.DeserializeObject<Response>(data);
            return is_success.Message;
        }
    }
}
