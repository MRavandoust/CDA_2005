﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryFigures
{
    public class Figure
    {
        private int x;
        private int y;

        public int X 
        { get { return x; } 
            set { x = value; } 
        }

        public int Y 
        {
            get { return y; }
            set { y = value; } 
        }

    }
}
