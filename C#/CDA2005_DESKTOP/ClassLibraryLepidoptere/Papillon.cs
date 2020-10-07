using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Papillon : StadeDevolution
    {
        public override StadeDevolution DonTonProchainEtat()
        {
            return this;
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je vole");
            return true;
        }
    }
}