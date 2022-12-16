using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Shape
    {
        protected int Width;
        protected int height;

        public Shape(int width, int height)
        {
            Width = width;
            this.height = height;
        }

        public virtual int Area()
        {
            return 0;
        }
        public virtual int Omkrets()
        {
            return 0;
        }

    }




}

