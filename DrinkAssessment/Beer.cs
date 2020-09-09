using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAssessment
{
    class Beer : Drink
    {

        private double alcoholContent;
        public Beer (string name, bool carbinated, double a) : base(name, carbinated)
        {
            alcoholContent = a;
        }


        public double AlcoholContent
        {
            get { return alcoholContent; }
            set { alcoholContent = value; }
        }


        public override string DrinkDesc()
        {
            if (this.Carbinated == true)
            {
                return this.Name + ", is carbinated with " +
                    this.alcoholContent.ToString() + "% alcohol.";
            }
            else
            {
                return this.Name + ", is not carbinated" +
                    this.alcoholContent.ToString() + " percent alcohol.";
            }

        }



    }
}
