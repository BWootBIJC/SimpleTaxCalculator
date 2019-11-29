using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class TaxCalc : Form
    {
        public TaxCalc()
        {
            InitializeComponent();
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Decimal input = Convert.ToDecimal(textBox1.Text); //user input in 1st text box
            Double taxRate = 0.15;
            Decimal taxes = Math.Round(input * Convert.ToDecimal(taxRate), 2); //user input * 0.15
            textBox2.Text = Convert.ToString("$" + taxes); //shows how much in tax will be subtracted from input
            Decimal total = Math.Round(input - taxes, 2); //computes amount remaining from input after tax is taken out
            textBox3.Text = Convert.ToString("$" + total); //displays the computed total in textbox 3
        }
    }
}
