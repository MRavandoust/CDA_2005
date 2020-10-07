using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Chrysalide : StadeDevolution
    {
        public override StadeDevolution DonTonProchainEtat()
        {
            return new Papillon();
        }

        public override bool SeDeplacer()
        {
            Console.WriteLine("Je bouge pas");
            return false;
        }
    }
}