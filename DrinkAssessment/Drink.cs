using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAssessment
{
    class Drink
    {


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool carbinated;

        public bool Carbinated
        {
            get { return carbinated; }
            set { carbinated = value; }
        }

        public Drink(string name, bool carbinated)
        {
            this.name = name;
            this.carbinated = carbinated;
        }

        public virtual string DrinkDesc()
        {
            if (carbinated == true)
            {
                return name + ", is carbinated.";
            }
            else
            {
                return name + ", is not carbinated.";
            }
        }

    }
}
