using System;
using CareerSwitchChallenge.API;
using CareerSwitchChallenge.Http_req;
using CareerSwitchChallenge.Models;

namespace CareerSwitchChallenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var blocks = new BlockCheck();
            blocks.blocks.Add("TB8tkNtcDL0QxszDNEDPNg0LwM1qlA1QYaIKlfV0awHdCq6fd6288lEWK9fKMIg8YEesdhtyDcg8g0oaYqNX7KhnMJ8LUX1qMNHp");
            blocks.blocks.Add("O52GmtTec5Y78gTkb4DOEO8vNXkCDF9UVlvgr4fLtBjduTVSVQpgEICJnN3PC2Ttgk8aVkZ8OBCpcKw6MxdcN3a2Y7png1VxjhrZ");
            var challenger = Http_request.HttpPost(blocks, "https://rooftop-career-switch.herokuapp.com/check?token=f950bc64-f0c3-4c37-9ba0-6b77bc120f2e");
            //string url_token = "https://rooftop-career-switch.herokuapp.com/token";
            //string parameters = "nicolasdonazzon@gmail.com";
            //string url_blocks = "https://rooftop-career-switch.herokuapp.com/blocks";
            //Block block_Connection = Block_API.Get_Blocks(url_token,parameters,url_blocks);
            //foreach(var item in block_Connection.data)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
