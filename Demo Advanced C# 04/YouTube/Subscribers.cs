using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C__04.YouTube
{
    internal class Subscribers
    {
        public string SubName { get; set; }

        public void Notify(Videos video,Channel channel)
        {
            Console.WriteLine(value: $"{channel.ChanelName} is add New Video !!, {SubName}\n {video}\n\n");

        }
        public override string ToString()
        {
            return $"Subscriber Name : {SubName}";
        }


    }
}
