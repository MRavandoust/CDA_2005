using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandwichAbstractFactory
{
    public class KidCuisineFactory : RecipeFactory
    {
        public override Dessert CreateDessert()
        {
            return new IceCreamSundae();
        }

        public override Sandwich CreateSandwich()
        {
            return new GrilledCheese();
        }
    }
}
