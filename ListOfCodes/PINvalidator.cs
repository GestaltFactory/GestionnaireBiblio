using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListOfCodes
{
    class PINvalidator
    {
        private int pin;
        public int Pin
        {
            get { return pin; }
            set { pin = value; }
        }


        bool IsNumeric(TextBox tb)
        {
            int validPin;
            bool valid = Int32.TryParse(tb.Text, out validPin);
            if (valid)
            {
                Pin = validPin;
                return true;
            }
            else
            {
                return false;
            }
        }

        bool IsValidSize(TextBox tb, int size)
        {
            if (tb.Text.Length == size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public PINvalidator()
        {
            InitializeComponent();
        }

        private void PINvalidator_Load(object sender, EventArgs e)
        {
            textBoxPin.Focus();
        }

        private void buttonPin_Click(object sender, EventArgs e)
        {
            if ((IsNumeric(textBoxPin)) && (IsValidSize(textBoxPin, 4)))
            {
                MessageBox.Show("The PIN " + Pin + " is valid.");
            }
            else
            {
                MessageBox.Show("The PIN is invalid...try again");
                textBoxPin.Clear();
                textBoxPin.Focus();
            }
        }

        private void buttonGetPin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The pin " + piNvalidator1.Pin + " is valid");
            pinGet = piNvalidator1.Pin;
        }
    }
}
