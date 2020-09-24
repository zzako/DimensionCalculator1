using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DimensionCalculator1
{
    public partial class CExchange : Form
    {
        private double exchangeRate;
        public CExchange()
        {
            InitializeComponent();
            exchangeRate = 0;
        }
        private double ConvertCurrency(double american, double rate)
        {
            return american * rate;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            double result;
            if(double.TryParse(textBox1.Text, out result))
            {
                lblConvertedCurrency.Text = ConvertCurrency(result, exchangeRate).ToString();
            }
        }

        private void rbRand_CheckedChanged(object sender, EventArgs e)
        {
            exchangeRate = 17.13;
            lblCurrencyType.Text = "Rands";
        }

    private void rbPound_CheckedChanged(object sender, EventArgs e)
    {
        exchangeRate = 0.78;
        lblCurrencyType.Text = "Pound";
    }

    private void rbCanadian_CheckedChanged(object sender, EventArgs e)
    {
        exchangeRate = 1.34;
        lblCurrencyType.Text = "Canadian";
    }

    private void rbEuro_CheckedChanged(object sender, EventArgs e)
    {
        exchangeRate = 0.86;
        lblCurrencyType.Text = "Euro";
    }

    private void Exchange_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
