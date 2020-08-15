using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Design_Pattern
{
    class Order
    {
        public FoodItem Appetizer { get; set; }
        public FoodItem Entree { get; set; }
        public FoodItem Drink { get; set; }
    }
}
