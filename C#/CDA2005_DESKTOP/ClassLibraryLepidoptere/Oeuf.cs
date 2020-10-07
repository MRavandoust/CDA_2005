using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Oeuf : StadeDevolution
    {
        public override StadeDevolution DonTonProchainEtat()
        {
            return new Chenille();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je ne bouge pas");
            return false;
        }
    }
}