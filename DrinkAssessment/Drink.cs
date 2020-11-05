using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAssessment
{
    /// <summary>
    /// The main Drink class that has a method to display the drink description.
    /// </summary>
    /// <remarks>
    /// <para>This class can determine and display weather or not the drink is carbinated.</para>
    /// </remarks>
    class Drink
    {


        private string name;
        /// <value>Gets the value of Name.</value>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private bool carbinated;
        /// <value>Gets the value of Carbinated.</value>
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

        /// <summary>
        /// Determine if the generic drink is carbonated.
        /// </summary>
        /// <returns>
        /// String explaining whether the generic drink is carbonated or not.
        /// </returns>
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
