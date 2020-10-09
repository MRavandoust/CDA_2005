using ClassLibraryLepidoptere;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestLepidoptere
{
    class Program
    {
        static void Main(string[] args)
        {
            Lepidoptere georges = new Lepidoptere();
            georges.SeDeplacer();
            georges.SeMetamorphoser();
            georges.SeDeplacer();


        }

    }
}
