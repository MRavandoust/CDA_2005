using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeublesAbstractFactory
{
    class Client
    {
        private Chaise chaise;
        private Sofa sofa;
        private TabbleBasse table;

        public Client(MeublesFactory factory, string model)
        {
            chaise = factory.CreerChaise(model);
            sofa = factory.CreerSofa(model);
            table = factory.CreerTable(model);
        }

        public string GetChaise()
        {
            return chaise.Produit();
        }

        public string GetSofa()
        {
            return sofa.Produit();
        }

        public string GetTable()
        {
            return table.Produit();
        }
    }
}
