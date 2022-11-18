using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryBusinessRules;
using ClassLibraryIOdata;

namespace GestionnaireBiblio.GUI
{
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        const string dir = @"";
        const string filePathBook = dir + "Book.txt";
        const string filePathSoftware = dir + "Software.txt";

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void FrmAddProduct_Load(object sender, EventArgs e)
        {
            comboBoxBookGenre.DataSource = Enum.GetNames(typeof(EnumAuthorGenre));
            comboBoxBookCDIncluded.DataSource = Enum.GetNames(typeof(EnumCDIncluded));
            comboBoxSoftType.DataSource = Enum.GetNames(typeof(EnumSoftType));

            string[] lineOfContentsAuthor = File.ReadAllLines("Author.txt");
            foreach(var line in lineOfContentsAuthor){
                string[] tokens = line.Split('|');
                comboBoxBookAuthor.Items.Add(tokens[1].Substring(0, 1).ToUpper() + tokens[1].Trim().Remove(0, 1).ToLower() + " " + tokens[0].Substring(0, 1).ToUpper() + tokens[0].Trim().Remove(0, 1).ToLower());
            }

            string[] lineofCOntentsPublisher = File.ReadAllLines("Publisher.txt");
            foreach(var line in lineofCOntentsPublisher){
                string[] tokens = line.Split('|');
                comboBoxBookPublisher.Items.Add(tokens[0].Substring(0, 1).ToUpper() + tokens[0].Trim().Remove(0, 1).ToLower());
                comboBoxSoftPublisher.Items.Add(tokens[0].Substring(0, 1).ToUpper() + tokens[0].Trim().Remove(0, 1).ToLower());
            }

            if (File.Exists(filePathSoftware))
            {
                List<ClsSoftware> listSoft = SoftwareIO.GetListSoftware();
                textBoxSoftId.Text = listSoft.Count().ToString();
            }
            else
            {
                textBoxSoftId.Text = "1";
            }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidBook(maskedTextBoxIsbn, maskedTextBoxIsbn.Text.Length, textBoxBookProductName, textBoxBookProductName.Text, comboBoxBookGenre,
                                       numericUpDownBookPrice, numericUpDownBookQuantity, comboBoxBookAuthor, comboBoxBookPublisher, comboBoxBookCDIncluded))
            {
                ClsBook book = new ClsBook();
                book.Isbn = maskedTextBoxIsbn.Text;
                book.ProductName = textBoxBookProductName.Text;

                switch(comboBoxBookGenre.SelectedIndex){
                    case 0:
                        MessageBox.Show("You must select a genre for your book.");
                        break;
                    case 1:
                        book.BookGenre = EnumAuthorGenre.Literature;
                        break;
                    case 2:
                        book.BookGenre = EnumAuthorGenre.History;
                        break;
                    case 3:
                        book.BookGenre = EnumAuthorGenre.Romance;
                        break;
                    case 4:
                        book.BookGenre = EnumAuthorGenre.Fiction;
                        break;
                    case 5:
                        book.BookGenre = EnumAuthorGenre.Horror;
                        break;
                    case 6:
                        book.BookGenre = EnumAuthorGenre.Biography;
                        break;
                    case 7:
                        book.BookGenre = EnumAuthorGenre.Genealogy;
                        break;
                    case 8:
                        book.BookGenre = EnumAuthorGenre.Fantasy;
                        break;
                    case 9:
                        book.BookGenre = EnumAuthorGenre.MixedGenre;
                        break;
                }

                book.Price = numericUpDownBookPrice.Value;
                book.Quantity = Convert.ToUInt16(numericUpDownBookQuantity.Value);

                book.Authors.Name.FirstName = comboBoxBookAuthor.SelectedItem.ToString();
                book.Publisher.BusinessName = comboBoxBookPublisher.SelectedItem.ToString();

                book.PubDate = dateTimePickerBookPubDate.Value;

                switch(comboBoxBookCDIncluded.SelectedIndex){
                    case 0:
                        MessageBox.Show("You must specify if a cd is included with this book.");
                        break;
                    case 1:
                        book.CdIncluded = EnumCDIncluded.yes;
                        break;
                    case 2:
                        book.CdIncluded = EnumCDIncluded.no;
                        break;
                }

                //Sauvegarder info
                string msg = "";
                BookIO.SaveBook(book, out msg);
                labelInfoCreation.Text = msg;
            }
        }

        private void buttonClearBookField_Click(object sender, EventArgs e)
        {
            maskedTextBoxIsbn.Clear();
            textBoxBookProductName.Clear();
            comboBoxBookGenre.SelectedIndex = 0;
            numericUpDownBookPrice.Value = 0.00m;
            numericUpDownBookQuantity.Value = 0;
            comboBoxBookAuthor.SelectedItem = null;
            comboBoxBookPublisher.SelectedItem = null;
            dateTimePickerBookPubDate.Value = DateTime.Now;
            comboBoxBookCDIncluded.SelectedIndex = 0;
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void buttonAddSoftware_Click(object sender, EventArgs e)
        {
            if(Validator.IsValidSoft(textBoxSoftName, textBoxSoftName.Text, comboBoxSoftType, numericUpDownSoftPrice, numericUpDownSoftQuantity, comboBoxSoftPublisher)){
                ClsSoftware soft = new ClsSoftware();
                soft.SoftId = Convert.ToUInt16(textBoxSoftId.Text);
                soft.ProductName = textBoxBookProductName.Text;

                switch (comboBoxSoftType.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a genre for your software.");
                        break;
                    case 1:
                        soft.SoftType = EnumSoftType.game;
                        break;
                    case 2:
                        soft.SoftType = EnumSoftType.learning;
                        break;
                    case 3:
                        soft.SoftType = EnumSoftType.apps;
                        break;
                }

                soft.Price = numericUpDownSoftPrice.Value;
                soft.Quantity = Convert.ToUInt16(numericUpDownSoftQuantity.Value);
                
                soft.Publisher.BusinessName = comboBoxSoftPublisher.SelectedItem.ToString();
                
                soft.PubDate = dateTimePickerSoftPubDate.Value;



                //Sauvegarder info
                string msg = "";
                SoftwareIO.SaveSoftware(soft, out msg);
                labelInfoCreation.Text = msg;
            }
        }

        private void buttonClearSoftwareField_Click(object sender, EventArgs e)
        {
            textBoxBookProductName.Clear();
            comboBoxSoftType.SelectedIndex = 0;
            numericUpDownBookPrice.Value = 0.00m;
            numericUpDownBookQuantity.Value = 0;
            comboBoxBookPublisher.SelectedItem = null;
            dateTimePickerBookPubDate.Value = DateTime.Now;
        }

        private void buttonSoftwareReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}