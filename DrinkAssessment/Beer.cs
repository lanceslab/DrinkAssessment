using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAssessment
{
    /// <summary>
    /// The Beer class inherited from the Drink class that has a method
    /// to display the drink description.
    /// </summary>
    /// <remarks>
    /// <para>This class can determine and display weather or not the
    /// drink is carbinated and the Alcohol Content.</para>
    /// </remarks>
    class Beer : Drink
    {

        private double alcoholContent;
        public Beer (string name, bool carbinated, double a) : base(name, carbinated)
        {
            alcoholContent = a;
        }

        /// <value>Gets the value of AlcoholContent.</value>
        public double AlcoholContent
        {
            get { return alcoholContent; }
            set { alcoholContent = value; }
        }

        /// <summary>
        /// Determine if the Beer is carbonated.
        /// </summary>
        /// <returns>
        /// String explaining whether the Beer is carbonated or not.
        /// </returns>
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
