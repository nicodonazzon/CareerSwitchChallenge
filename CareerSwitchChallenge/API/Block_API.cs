using CareerSwitchChallenge.Http_req;
using Newtonsoft.Json;
using CareerSwitchChallenge.Models;

namespace CareerSwitchChallenge.API
{
    static class Block_API
    {
        static public Block Get_Blocks(string token, string endpoint_blocks) {
            string str_request = Http_request.HttpGet(endpoint_blocks +$"?token={token}");
            Block block = JsonConvert.DeserializeObject<Block>(str_request);
            return block;
        }
    }
}
