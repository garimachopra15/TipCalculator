using System;
using System.Windows.Forms;

namespace Tip_Calculator
{
    class bill // class in which per person amount is calculated
    {
        private float total, tip, totalperperson, tipperperson, tipvalue;
        private int people;
        public float Total // total Property
        {

            set { total = value; }
        }
        public float Tip // tip Property
        {

            set { tip = value; }
        }

        public int People // people Property
        {

            set
            {
                if (value > 0) // Number of Person Cant be 0 or less 
                {
                    people = value;
                }
                else
                {
                    MessageBox.Show("Number Of Person Cannot be 0");
                    
                }
            }
        }

        public float Totalperperson // Totalperperson Property
        {
            
            get
            {   // Exception Handling
                try 
                {
                    tipvalue = total * tip / 100;
                    totalperperson = (total + tipvalue) / people; // Calculation for Total Bill Per Person
                }
                catch (Exception e)
                {
                    Console.WriteLine(e); 
                }
                return totalperperson;
            }
        }

        public float Tipperperson // Tipperperson Property
        {

            get
            {
                try
                {
                    tipvalue = total * tip / 100;
                    tipperperson = tipvalue / people; // Calculation for Tip per person
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
                return tipperperson;
            }
        }



    }
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
