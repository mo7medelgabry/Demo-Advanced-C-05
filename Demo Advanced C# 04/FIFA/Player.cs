using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C__04.FIFA
{
    internal class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        public void Run()
        {
            Console.WriteLine($"Player: {Name} is Running...");
        }



    }   

}
