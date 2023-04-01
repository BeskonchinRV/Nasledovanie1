using System;
using System.Collections.Generic;
using System.Text;

namespace Farm
{
    public class Eat
    {
        public string Type { get; }
        public int satiety { get; set; }
        public Eat(string type, int satiety)
        {
            this.Type = type;
            this.satiety = satiety;
        }
    }
}
