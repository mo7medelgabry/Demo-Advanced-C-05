using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C__04.FIFA
{
    internal class Refree
    {
        public string RefreeName { get; set; }

        public void Look()
        {
            Console.WriteLine($"Refree {RefreeName} is looking at ball");

        }
    }
}
