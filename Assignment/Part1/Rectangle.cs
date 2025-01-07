using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Part1
{
    internal class Rectangle
    {
        int width { get; set; }
        int height { get; set; }
        public Rectangle()
        {
            width = 0; height = 0;
        }
        public Rectangle(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
        public Rectangle(int x)
        {
            width = x;
            height = x;
        }

    }
}
