using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeublesAbstractFactory
{
    class ModernSofa : Sofa
    {
        public override string Produit()
        {
            return "Produit : Sofa Modern";
        }
    }
}
