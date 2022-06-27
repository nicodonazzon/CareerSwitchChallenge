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
            Block block = Block_API.Get_Blocks(token.Token, block_endpoint);

            Console.WriteLine("Unordered Blocks: ");
            foreach (var item in block.data)
            {
                Console.WriteLine("BLOCK: " + item);
            }

            List<string> orderer_blocks = Checker.Check(block.data, token.Token);
            Console.WriteLine("Ordered Blocks: ");
            foreach (string orderer_block in orderer_blocks)
            {
                Console.WriteLine("BLOCK: " + orderer_block);
            }

            bool issuccess = Check_API.Is_success(check_endpoint, orderer_blocks, token.Token);
            Console.WriteLine("Result of the Check API: " + issuccess);
            Console.ReadKey();
        }
    }
}
