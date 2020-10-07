using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClassLibraryLepidoptere
{
    public class Lepidoptere
    {
        private StadeDevolution monStadeCourant;
        private System.DateTime dateDeNaissance;

        public Lepidoptere()
        {
            monStadeCourant = new Oeuf();
            dateDeNaissance = DateTime.Now;
        }

        public bool SeDeplacer()
        {
            return monStadeCourant.SeDeplacer();
        }

        public void SeMetamorphoser()
        {
            monStadeCourant = monStadeCourant.DonTonProchainEtat();
        }
    }
}