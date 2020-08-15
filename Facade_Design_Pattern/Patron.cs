using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Design_Pattern
{
    class Patron
    {
        private string _name;

        public Patron(string name)
        {
            this._name = name;
        }

        public string Name
        {
            get { return _name; }
        }
    }
}
