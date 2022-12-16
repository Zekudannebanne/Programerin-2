using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Rektangel:Shape
    {
        public Rektangel(int Width, int height) : base(Width, height)
        {  
        
        }

        public override int Area()
        {
            return Width * height;
        }

        public override int Omkrets() 
        {
            return Width + Width + height + height;
        }

    }

}
