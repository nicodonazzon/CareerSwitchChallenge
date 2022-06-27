using System;
using System.Collections.Generic;
using CareerSwitchChallenge.API;
using CareerSwitchChallenge.Models;
using CareerSwitchChallenge.Methods;

namespace CareerSwitchChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string token_endpoint = "https://rooftop-career-switch.herokuapp.com/token";
            string token_parameters = "?email=nicolasdonazzon@gmail.com";
            string block_endpoint = "https://rooftop-career-switch.herokuapp.com/blocks";
            string check_endpoint = "https://rooftop-career-switch.herokuapp.com/check";
            Token_request token = Token_API.Get_Token(token_endpoint, token_parameters);


            Block block = Block_API.Get_Blocks(token.Token,block_endpoint);

            List<string> orderer_blocks = Checker.Check(block.data,token.Token);

            bool issuccess = Success_API.Is_success(check_endpoint, orderer_blocks, token.Token);
        }
    }
}
