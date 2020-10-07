using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Chenille : StadeDevolution
    {
        public override bool SeDeplacer()
        {
            Console.WriteLine("Je rampe");
            return true;
        }
    }
}