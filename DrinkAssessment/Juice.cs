using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAssessment
{
    class Juice : Drink
    {

        private string madeFrom;
        public Juice(string name, bool carbinated, string m) : base(name, carbinated)
        {
            madeFrom = m;
        }


        public string MadeFrom
        {
            get { return madeFrom; }
            set { madeFrom = value; }
        }


        public override string DrinkDesc()
        {
            if (this.Carbinated == true)
            {
                return this.Name + ", is carbinated made from " +
                    this.madeFrom + ".";
            }
            else
            {
                return this.Name + ", is not carbinated made from " +
                    this.madeFrom + ".";
            } 

        }




    }
}
