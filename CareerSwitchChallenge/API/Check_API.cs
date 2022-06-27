using System;
using Newtonsoft.Json;
using CareerSwitchChallenge.Models;
using CareerSwitchChallenge.Http_req;
using System.Collections.Generic;

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
        static public Boolean Is_success(string url, List<string> ordered_blocks, string token)
        {
            string ordered_blocksstr = string.Join("", ordered_blocks);
            SuccessCheck blocks = new SuccessCheck();
            blocks.encoded = ordered_blocksstr;
            string url_req = url + "?token=" + token;
            string data = Http_request.HttpPost(blocks, url_req);
            Response is_success = JsonConvert.DeserializeObject<Response>(data);
            return is_success.Message;
        }
        static public Boolean Is_success(string url, string ordered_blocks, string token)
        {
            SuccessCheck blocks = new SuccessCheck();
            blocks.encoded = ordered_blocks;
            string url_req = url + "?token=" + token;
            string data = Http_request.HttpPost(blocks, url_req);
            Response is_success = JsonConvert.DeserializeObject<Response>(data);
            return is_success.Message;
        }
    }
}
