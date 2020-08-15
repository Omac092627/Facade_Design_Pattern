using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Design_Pattern
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class ColdPrep : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go prep the cold item
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
