using System;
using System.Collections.Generic;
using System.Text;

namespace Test_Property
{
    class Rectangle
    {
        private int lenght;
        private int height;

        public Rectangle()
        {
            lenght = 25;
            height = 16;
        }

        public int Lenght 
        {
            get { return lenght; }
            set { lenght = value; }
        }

        public int Height
        {
            get { return height; }
            set { height = value; }
        }

        public bool IsSquer
        {
            get
            {
                if (Lenght == Height)
                    return true;
                else
                    return false;
            }
        }

        public int Aeria()
        {
            return Lenght * Height;
        }
    
    }
}
