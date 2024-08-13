using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C__04.FIFA
{
    internal class Ball
    {
        public int Id { get; set; }

        private Location location;

        public Location Location
        {
            get { return location; }
            set { if(value.Equals(location))
                {
                    location = value;
                    BallLocationChange?.Invoke();
                }
               
            }
            
        }
        public event Action? BallLocationChange;
         

        public override string ToString()
        {
            return $"Id:{Id}, Location: {Location}"; 
        }

    }
}
