using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace GestionnaireBiblio.GUI
{
    public static class Validator
    {

        const string dir = @"";
        const string filePathClient = dir + "Client.txt";
        const string filePathAuthor = dir + "Author.txt";
        const string filePathEmp = dir + "Employee.txt";
        const string filePathPub = dir + "Publisher.txt";
        const string filePathDis = dir + "Distributor.txt";
        
        /// <summary>
        /// Valid client, employee and Author form composed of a group of other validation methods
        /// </summary>
        /// <param name="textBoxFirstName"></param>
        /// <param name="firstName"></param>
        /// <param name="textBoxLastName"></param>
        /// <param name="lastName"></param>
        /// <param name="maskedTextBoxAge"></param>
        /// <param name="comboBoxSex"></param>
        /// <param name="maskedTextBoxPhone"></param>
        /// <param name="textBoxEmail"></param>
        /// <param name="email"></param>
        /// <param name="maskedTextBoxStrNb"></param>
        /// <param name="textBoxStrName"></param>
        /// <param name="streetName"></param>
        /// <param name="maskedTextBoxAppNb"></param>
        /// <param name="textBoxZip"></param>
        /// <param name="zip"></param>
        /// <param name="textBoxCity"></param>
        /// <param name="city"></param>
        /// <param name="textBoxState"></param>
        /// <param name="state"></param>
        /// <param name="comboBoxType"></param>
        /// <returns></returns>
        public static bool IsValid_1(TextBox textBoxFirstName, string firstName, TextBox textBoxLastName, string lastName, MaskedTextBox maskedTextBoxAge, ComboBox comboBoxSex, MaskedTextBox maskedTextBoxPhone,
                                          int valueSize, TextBox textBoxEmail, string email, MaskedTextBox maskedTextBoxStrNb, TextBox textBoxStrName, string streetName, MaskedTextBox maskedTextBoxAppNb, 
                                          TextBox textBoxZip, string zip, TextBox textBoxCity, string city, TextBox textBoxState, string state, ComboBox comboBoxType)
        {
            bool valid = IsPresent(textBoxFirstName) && IsValidString(firstName, "first name") && IsPresent(textBoxLastName) && IsValidString(lastName, "last name") && IsPresentMasked(maskedTextBoxAge) &&
                         EnumValid(comboBoxSex) && IsPresentMasked(maskedTextBoxAge) && TelNumberSize(valueSize) && IsPresent(textBoxEmail) && EmailExpressionValid(textBoxEmail.Text) && IsPresentMasked(maskedTextBoxStrNb) &&
                         IsPresent(textBoxStrName) && IsValidString(streetName, "street name") && IsPresentMasked(maskedTextBoxAppNb) && IsPresent(textBoxZip) && PostalCodeExpressionValid(textBoxZip.Text) &&
                         IsPresent(textBoxCity) && IsValidString(city, "city") && IsPresent(textBoxState) && IsValidString(state, "state") && EnumValid(comboBoxType);

            return valid;
        }

        /// <summary>
        /// Valid client, employee and Author form composed of a group of other validation methods
        /// </summary>
        /// <param name="textBoxBusName"></param>
        /// <param name="busName"></param>
        /// <param name="maskedTextBoxPhone"></param>
        /// <param name="textBoxEmail"></param>
        /// <param name="email"></param>
        /// <param name="maskedTextBoxStrNb"></param>
        /// <param name="textBoxStrName"></param>
        /// <param name="streetName"></param>
        /// <param name="maskedTextBoxAppNb"></param>
        /// <param name="textBoxZip"></param>
        /// <param name="zip"></param>
        /// <param name="textBoxCity"></param>
        /// <param name="city"></param>
        /// <param name="textBoxState"></param>
        /// <param name="state"></param>
        /// <param name="comboBoxType"></param>
        /// <returns></returns>
        public static bool IsValid_2(TextBox textBoxBusName, string busName, MaskedTextBox maskedTextBoxPhone, int valueSize, TextBox textBoxEmail, string email, MaskedTextBox maskedTextBoxStrNb, 
                                     TextBox textBoxStrName, string streetName, MaskedTextBox maskedTextBoxAppNb, TextBox textBoxZip, string zip, TextBox textBoxCity, string city, TextBox textBoxState, 
                                     string state, ComboBox comboBoxType)
        {
            bool valid = IsPresent(textBoxBusName) && IsValidString(busName, "business name") && TelNumberSize(valueSize) && IsPresent(textBoxEmail) && EmailExpressionValid(textBoxEmail.Text) && IsPresentMasked(maskedTextBoxStrNb) &&
                         IsPresent(textBoxStrName) && IsValidString(streetName, "street name") && IsPresentMasked(maskedTextBoxAppNb) && IsPresent(textBoxZip) && PostalCodeExpressionValid(textBoxZip.Text) &&
                         IsPresent(textBoxCity) && IsValidString(city, "city") && IsPresent(textBoxState) && IsValidString(state, "state") && EnumValid(comboBoxType);

            return valid;
        }

        public static bool IsValidBook(MaskedTextBox textBoxIsbn, int isbnSize, TextBox textBoxProductName, string productName, ComboBox comboBoxBookGenre,
                                       NumericUpDown minPrice, NumericUpDown minQuantity, ComboBox author, ComboBox publisher, ComboBox cdIncluded)
        {
            bool valid = IsPresentMasked(textBoxIsbn) && IsbnNumberSize(isbnSize) && IsPresent(textBoxProductName) && IsValidString(productName, "product name") && EnumValid(comboBoxBookGenre) &&
                         MinimumPrice(minPrice) && MinimumQT(minQuantity) && EnumValid(author) && EnumValid(publisher) && EnumValid(cdIncluded);

            return valid;
        }

        public static bool IsValidSoft(TextBox textBoxProductName, string productName, ComboBox comboBoxSoftType, NumericUpDown minPrice, NumericUpDown minQuantity, ComboBox publisher)
        {
            bool valid = IsPresent(textBoxProductName) && IsValidString(productName, "product name") && EnumValid(comboBoxSoftType) && MinimumPrice(minPrice) && 
                         MinimumQT(minQuantity) && EnumValid(publisher);

            return valid;
        }
        
        /// <summary>
        /// empty textbox
        /// </summary>
        const string err = "Invalid entry";
        public static bool IsPresent(TextBox textBox){
            if (textBox.Text == ""){
                MessageBox.Show(textBox.Tag.ToString() + " is a mandatory field", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool IsUniqValueClient(string str){           
            if(File.Exists(filePathClient)){
                StreamReader sReader = new StreamReader(filePathClient);
                string line = sReader.ReadLine();
                while (line != null){
                    string[] field = line.Split('|');
                    if (field[11] == str){
                        MessageBox.Show("The phone number must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    else if (field[12] == str)
                    {
                        MessageBox.Show("The email must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return true;
        }

        public static bool IsUniqValueAuthor(string str)
        {
            if (File.Exists(filePathAuthor))
            {
                StreamReader sReader = new StreamReader(filePathAuthor);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[10] == str)
                    {
                        MessageBox.Show("The phone number must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    else if (field[11] == str)
                    {
                        MessageBox.Show("The email must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return true;
        }

        public static bool IsUniqValueEmp(string str)
        {
            if (File.Exists(filePathEmp))
            {
                StreamReader sReader = new StreamReader(filePathEmp);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[10] == str)
                    {
                        MessageBox.Show("The phone number must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    else if (field[11] == str)
                    {
                        MessageBox.Show("The email must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return true;
        }

        public static bool IsUniqValuePub(string str)
        {
            if(File.Exists(filePathPub))
            {
                StreamReader sReader = new StreamReader(filePathPub);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[0] == str)
                    {
                        MessageBox.Show("The business name must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    else if (field[7] == str)
                    {
                        MessageBox.Show("The phone must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    else if (field[8] == str)
                    {
                        MessageBox.Show("The email must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return true;
        }

        public static bool IsUniqValueDis(string str)
        {
            if (File.Exists(filePathDis))
            {
                StreamReader sReader = new StreamReader(filePathDis);
                string line = sReader.ReadLine();
                while (line != null)
                {
                    string[] field = line.Split('|');
                    if (field[0] == str)
                    {
                        MessageBox.Show("The business name must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    else if (field[7] == str)
                    {
                        MessageBox.Show("The phone must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    else if (field[8] == str)
                    {
                        MessageBox.Show("The email must be a unique value.");
                        sReader.Close();
                        return false;
                    }
                    line = sReader.ReadLine();
                }
                sReader.Close();
            }
            return true;
        }

        /// <summary>
        /// minimum wage
        /// </summary>
        /// <param name="minSalary"></param>
        /// <returns></returns>
        public static bool MinimumWage(NumericUpDown minSalary){
            if(minSalary.Value < 10.50m){
                MessageBox.Show(minSalary.Tag.ToString() + " must be above or equal 10.50 per hour", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// minimum QT
        /// </summary>
        /// <param name="minSalary"></param>
        /// <returns></returns>
        public static bool MinimumPrice(NumericUpDown minPrice){
            if (minPrice.Value == 0.00m){
                MessageBox.Show(minPrice.Tag.ToString() + " must be above 0.00", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// minimum QT
        /// </summary>
        /// <param name="minSalary"></param>
        /// <returns></returns>
        public static bool MinimumQT(NumericUpDown minQuantity)
        {
            if (minQuantity.Value < 1)
            {
                MessageBox.Show(minQuantity.Tag.ToString() + " must be above or equal to 1", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// empty textbox
        /// </summary>
        public static bool IsPresentMasked(MaskedTextBox maskTextBox)
        {
            if (maskTextBox.Text == "")
            {
                MessageBox.Show(maskTextBox.Tag.ToString() + " is a mandatory field", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// is a char
        /// </summary>
        /// <param name="str"></param>
        /// <param name="info"></param>
        /// <returns></returns>
        public static bool IsValidString(string str, string info){
            bool isValid = true;
            for (int i = 0; i < str.Length; i++){
                if(!Char.IsLetter(str, i)){
                    MessageBox.Show("The " + info + " is invalid.", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            return isValid;
        }

        /// <summary>
        /// Valid enums
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        static public bool EnumValid(ComboBox value)
        {
            if (value.SelectedItem == null || value.SelectedIndex == 0)
            {
                MessageBox.Show("A value must be selected for " + value.Tag.ToString(), err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //valid email
        public static bool EmailExpressionValid(string str)
        {
            if (!Regex.IsMatch(str, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("The email address you have entered is invalid.", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        //valid postal code
        public static bool PostalCodeExpressionValid(string str)
        {
            if (!Regex.IsMatch(str, @"^[ABCEGHJKLMNPRSTVXY]{1}\d{1}[A-Z]{1} *\d{1}[A-Z]{1}\d{1}$", RegexOptions.IgnoreCase))
            {
                MessageBox.Show("The postal code you have entered is invalid.", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// valid ISBN
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool IsbnNumberSize(int value)
        {
            if (value != 17)
            {
                MessageBox.Show("The ISBN must contain 13 numbers.", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// valid phone size
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static bool TelNumberSize(int value)
        {
            if (value != 14)
            {
                MessageBox.Show("The phone number must be composed of 10 digits.", err, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

    }
}
