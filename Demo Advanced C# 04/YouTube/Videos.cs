﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Advanced_C__04.YouTube
{
    internal class Videos
    {
        public string Title { get; set; }
        public string Description { get; set; }

        public override string ToString()
        {
            return $"Title: {Title}, Description: {Description}";
        }

    }
}
