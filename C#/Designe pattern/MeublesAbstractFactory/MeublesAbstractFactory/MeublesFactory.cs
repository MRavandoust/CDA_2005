using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeublesAbstractFactory
{
    abstract class MeublesFactory
    {
        public abstract Chaise CreerChaise(string type);
        public abstract Sofa CreerSofa(string type);
        public abstract TabbleBasse CreerTable(string type);
    }
}
