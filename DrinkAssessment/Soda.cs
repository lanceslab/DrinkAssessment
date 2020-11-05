using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAssessment
{
    /// <summary>
    /// The Soda class inherited from the Drink class that has a method
    /// to display the drink description.
    /// </summary>
    /// <remarks>
    /// <para>This class can determine and display weather or not the
    /// drink is carbinated.</para>
    /// </remarks>
    class Soda : Drink
    {


        public Soda(string name, bool carbinated) : base(name, carbinated)
        {

        }


    }
}
