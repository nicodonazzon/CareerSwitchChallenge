using System;
using System.Collections.Generic;
using CareerSwitchChallenge.API;
using CareerSwitchChallenge.Models;

namespace CareerSwitchChallenge.Methods
{
    static class Checker
    {
        static public List<String> Check(List<string> ordered_blocks,string token)
        {
            string isSecuential_endpoint = "https://rooftop-career-switch.herokuapp.com/check";
            BlockCheck blockchk = new BlockCheck();
            for (int i = 0; i < ordered_blocks.Count; i++)
            {
                for(int j = i+1; j < ordered_blocks.Count; j++)
                {
                    blockchk.blocks = new List<string>();
                    blockchk.blocks.Add(ordered_blocks[i]);
                    blockchk.blocks.Add(ordered_blocks[j]);
                    bool isSecuential = Check_API.Is_secuential(blockchk, isSecuential_endpoint, token);
                    if (isSecuential)
                    {
                        var switchplace = ordered_blocks[i + 1];
                        ordered_blocks[i + 1] = ordered_blocks[j];
                        ordered_blocks[j] = switchplace;
                        break;
                    }
                }
            }            
            return ordered_blocks;
        }
    }
}
