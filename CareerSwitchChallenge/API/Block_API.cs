using System;
using System.Collections.Generic;
using System.Text;
using CareerSwitchChallenge.Http_req;
using Newtonsoft.Json;
using CareerSwitchChallenge.Models;

namespace CareerSwitchChallenge.API
{
    static class Block_API
    {
        static public Block Get_Blocks(string endpoint_token, string token_parameters, string endpoint_blocks) {
            Token_request token = Token_API.Get_Token(endpoint_token, token_parameters);
            string str_request = Http_request.HttpGet(endpoint_blocks +$"?token={token.Token}");
            Block block = JsonConvert.DeserializeObject<Block>(str_request);
            return block;
        }
    }
}
