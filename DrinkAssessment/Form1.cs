using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrinkAssessment
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDisplay_Click(object sender, EventArgs e)
        {

            var drinkList = new[]
            {
                new Drink("Tea", false),
                new Beer("Budwiser", true, 5.6),
                new Juice("Orange juice", false, "Oranges"),
                new Soda("Pepsi", true)
            };

            foreach(Drink drnk in drinkList.OfType<Drink>())
            {
                listBoxDesc.Items.Add(drnk.DrinkDesc());
            }

            //listBoxDesc.Items.Add(regularDrink.DrinkDesc());
            //listBoxDesc.Items.Add(bud.DrinkDesc());
            //listBoxDesc.Items.Add(ornage.DrinkDesc());
            //listBoxDesc.Items.Add(pepsi.DrinkDesc());
        }
    }
}
