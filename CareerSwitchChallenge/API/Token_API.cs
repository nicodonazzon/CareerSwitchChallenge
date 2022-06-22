﻿using System;
using System.Collections.Generic;
using System.Text;
using CareerSwitchChallenge.Http_req;
using Newtonsoft.Json;
using CareerSwitchChallenge.Models;
namespace CareerSwitchChallenge.Connections
{
    static class Token_API
    {
        static public Token_request Get_Token(string endpoint_token, string token_parameters)
        {
            string str_request = Http_request.HttpGet(endpoint_token + $"?email={token_parameters}");
            Token_request token = JsonConvert.DeserializeObject<Token_request>(str_request);
            return token;
        }
    }
}