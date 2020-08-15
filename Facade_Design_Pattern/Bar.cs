using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Design_Pattern
{
    /// <summary>
    /// A division of the kitchen.
    /// </summary>
    class Bar : KitchenSection
    {
        public FoodItem PrepDish(int dishID)
        {
            //Go mix the drink
            return new FoodItem()
            {
                DishID = dishID
            };
        }
    }
}
