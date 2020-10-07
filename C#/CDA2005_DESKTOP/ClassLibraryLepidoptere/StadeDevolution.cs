using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    abstract public class StadeDevolution
    {
        abstract public bool SeDeplacer();

        public bool PrendreDuPoids()
        {
            return true;
        }
       
    }
}