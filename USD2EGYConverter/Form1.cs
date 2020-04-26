using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace USD2EGYConverter
{
    public partial class USD2EGY_Converter : Form
    {
        public USD2EGY_Converter()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            Regex rg = new Regex("^[0-9]+$");

            if (txtBoxCurrency1.Text == "")
            {
                MessageBox.Show("Please Enter a number in USD to Convert to Egyptian Pounds!");
            }
            else
            {
                if (rg.Match(txtBoxCurrency1.Text).Success)
                {
                    double usdCurrency1 = Convert.ToDouble(txtBoxCurrency1.Text);
                    double multiplier = 15.75;
                    double egyCurrency2 = Convert.ToDouble(usdCurrency1 * multiplier);
                    txtBoxCurrency2.Text = egyCurrency2.ToString();


                }
                else
                {
                    MessageBox.Show("Only numbers allowed");
                }
            }    
        }

        private void txtBoxCurrency1_TextChanged(object sender, EventArgs e)
        {
            Regex rg = new Regex("^[0-9]+$");

            if (rg.Match(txtBoxCurrency1.Text).Success && txtBoxCurrency1.Text != "")
            {
              
            }
            else
            {
                MessageBox.Show("Can't be blank & use only numerics please");
            }

        }
    }
}
