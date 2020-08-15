using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Design_Pattern
{

    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class HotPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the hot entree
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
