using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeublesAbstractFactory
{
    class ClassiqueChaise : Chaise
    {
        public override string Produit()
        {
            return "Produit : Chaise classique";
        }
    }
}
