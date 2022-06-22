using System;
using System.Collections.Generic;
using System.Text;

namespace CareerSwitchChallenge.Models
{
    public class Block
    {
        public Int32 Id { get; set; }
        public Int32 length { get; set; }
        public List<string> data { get; set; }
    }
}
