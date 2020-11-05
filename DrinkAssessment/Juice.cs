using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAssessment
{
    /// <summary>
    /// The Juice class inherited from the Drink class that has a method
    /// to display the drink description.
    /// </summary>
    /// <remarks>
    /// <para>This class can determine and display weather or not the
    /// drink is carbinated.</para>
    /// </remarks>
    class Juice : Drink
    {

        private string madeFrom;
        public Juice(string name, bool carbinated, string m) : base(name, carbinated)
        {
            madeFrom = m;
        }

        /// <value>Gets the value of MadeFrom.</value>
        public string MadeFrom
        {
            get { return madeFrom; }
            set { madeFrom = value; }
        }

        /// <summary>
        /// Determine if the Juice drink is carbonated.
        /// </summary>
        /// <returns>
        /// String explaining whether the Juice drink is carbonated or not.
        /// </returns>
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
