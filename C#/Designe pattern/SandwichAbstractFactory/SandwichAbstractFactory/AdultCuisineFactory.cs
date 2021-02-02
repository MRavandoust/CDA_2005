using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichAbstractFactory
{
    public class AdultCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new CremeBrulee() ;
        }

        public override Sandwich CreateSandwich()
        {
            return new BLT();
        }
    }
}
