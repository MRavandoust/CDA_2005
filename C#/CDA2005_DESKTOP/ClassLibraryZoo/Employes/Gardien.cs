using ClassLibraryZoo.Contrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryZoo.Employes
{
    public class Gardien : IDeplacable, IParler
    {
        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool PeutParler()
        {
            Console.WriteLine("Je parle");
            return true;
        }

        public bool SeDeplacer()
        {
            Console.WriteLine("Je marche");
            return true;
        }
    }
}
