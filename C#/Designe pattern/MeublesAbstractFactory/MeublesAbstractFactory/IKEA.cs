using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeublesAbstractFactory
{
    class IKEA : MeublesFactory
    {
        public override Chaise CreerChaise(string type)
        {
            switch (type)
            {
                case "Modern":
                    return new ModernChaise();
                case "Classique":
                    return new ClassiqueChaise();
                default:
                    throw new ApplicationException(string.Format("On ne fabrique pas {0}", type));
            }
        }

        public override Sofa CreerSofa(string type)
        {
            switch (type)
            {
                case "Modern":
                    return new ModernSofa();
                case "Classique":
                    return new ClassiqueSofa();
                default:
                    throw new NotImplementedException();

            }
        }

        public override TabbleBasse CreerTable(string type)
        {
            switch (type)
            {
                case "Modern":
                    return new ModernTable();
                case "Classique":
                    return new ClassiqueTable();
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
