using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DimensionCalculator1
{
    /// <summary>
    /// Interaction logic for Cinterest.xaml
    /// </summary>
    public partial class Cinterest : Window
    {
        public Cinterest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            float interest, Amount;
            if (textBox1.Text != "" & textBox2.Text != "" & textBox3.Text != "")
            {
                interest = Convert.ToSingle(textBox1.Text) * Convert.ToSingle(textBox2.Text) / 100 * Convert.ToSingle(textBox3.Text);
                Amount = interest + Convert.ToSingle(textBox1.Text);
                MessageBox.Show(" simple interest =" + " " + interest + " " + "Amount =" + Amount);
            }
            else
            {
                MessageBox.Show("please enter the value");
            }
        }
             private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            CExchange ex = new CExchange();
            ex.Show();

        }
    }
  }
