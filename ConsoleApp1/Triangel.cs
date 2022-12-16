using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Triangel:Shape
    {
       
        
        public Triangel(int Width, int height) : base(Width, height) 
        {
            
        }

         public override int Area()
        {
            return Width * height /2;
        }
         
        public override int Omkrets()
        {
            int H = (int)Math.Sqrt(Width * Width + height* height);
            return  Width + height + H;
        }
    }

}
