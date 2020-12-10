using System;
using System.Windows.Forms;

namespace Tip_Calculator
{
    public partial class Form1 : Form
    {
        bill bill = new bill();// object of bill class (program.cs) named bill
        public Form1()
        {
            InitializeComponent();
        }
        // Initializing Default Values
        private void Form1_Load(object sender, EventArgs e)
        {   
            // Passing values to bill class variables for calculation
            bill.Total = int.Parse(textBox1.Text);
            bill.Tip = (float)numericUpDown1.Value;
            bill.People = (int)numericUpDown2.Value;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            // parsing the string value to float
            try
            {
                bill.Total = float.Parse(textBox1.Text);
            }
            catch (OverflowException ef)
            {
               
                Console.WriteLine(ef);
           
            }
            catch (FormatException ef)
            {

                Console.WriteLine(ef);
     
            }
            catch (Exception ef)
            {
                Console.WriteLine(ef);
            
            }
            // parsing the float value to string
            label8.Text = bill.Tipperperson.ToString();
            label9.Text = bill.Totalperperson.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            bill.Tip = (float)numericUpDown1.Value;
            label8.Text = bill.Tipperperson.ToString();
            label9.Text = bill.Totalperperson.ToString();
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {           
            bill.People = (int)numericUpDown2.Value;
            label8.Text = bill.Tipperperson.ToString();
            label9.Text = bill.Totalperperson.ToString();
        }
        // Bill input should accept integer and backspace
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}

