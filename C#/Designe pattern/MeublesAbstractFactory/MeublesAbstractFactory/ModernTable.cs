using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeublesAbstractFactory
{
    class ModernTable : TabbleBasse
    {
        public override string Produit()
        {
            return "Produit : Table basse Modern";
        }
    }
}
