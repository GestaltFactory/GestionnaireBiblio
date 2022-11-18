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
    public partial class FrmInventory : Form
    {
        public FrmInventory()
        {
            InitializeComponent();
        }

        const string dir = @"";
        const string filePathClient = dir + "Client.txt";
        const string filePathBook = dir + "Book.txt";
        const string filePathSoftware = dir + "Software.txt";

        private void FrmInventory_Load(object sender, EventArgs e)
        {
            comboBoxClientSexResult.DataSource = Enum.GetNames(typeof(EnumSexGenre));
            comboBoxClientTypeResult.DataSource = Enum.GetNames(typeof(EnumClientType));
            comboBoxBookCDIncludedResult.DataSource = Enum.GetNames(typeof(EnumCDIncluded));

            string[] lineofContentsAuthor = File.ReadAllLines("Author.txt");
            foreach(var line in lineofContentsAuthor){
                string[] tokens = line.Split('|');
                comboBoxBookAuthorResult.Items.Add(tokens[1].Substring(0, 1).ToUpper() + tokens[1].Trim().Remove(0, 1).ToLower() + " " + tokens[0].Substring(0, 1).ToUpper() + tokens[0].Trim().Remove(0, 1).ToLower());
            }

            string[] lineofCOntentsPublisher = File.ReadAllLines("Publisher.txt");
            foreach (var line in lineofCOntentsPublisher){
                string[] tokens = line.Split('|');
                comboBoxBookPublisherResult.Items.Add(tokens[0].Substring(0, 1).ToUpper() + tokens[0].Trim().Remove(0, 1).ToLower());
                comboBoxBookPublisherResult.Items.Add(tokens[0].Substring(0, 1).ToUpper() + tokens[0].Trim().Remove(0, 1).ToLower());
            }

            if (File.Exists(filePathClient))
            {
                GenerateClientList();
            }

            if (File.Exists(filePathBook))
            {
                GenerateBookList();
            }
        }

        private void GenerateClientList(){
            listViewClientResult.Items.Clear();
            List<ClsClient> listCli = ClientIO.GetListClient();
            foreach (ClsClient cli in listCli)
            {
                ListViewItem item = new ListViewItem(cli.ClientId.ToString());
                item.SubItems.Add(cli.Name.FirstName);
                item.SubItems.Add(cli.Name.LastName);
                item.SubItems.Add(cli.Age.ToString());
                item.SubItems.Add(cli.SexGenre.ToString());
                item.SubItems.Add(cli.Phone);
                item.SubItems.Add(cli.Email);
                item.SubItems.Add(cli.Address.StreetNumber.ToString());
                item.SubItems.Add(cli.Address.StreetName);
                item.SubItems.Add(cli.Address.AppNumber.ToString());
                item.SubItems.Add(cli.Address.PostalCode);
                item.SubItems.Add(cli.Address.City);
                item.SubItems.Add(cli.Address.State);
                item.SubItems.Add(cli.ClientType.ToString());
                listViewClientResult.Items.Add(item);
            }
        }

        private void GenerateBookList(){
            listViewBookResult.Items.Clear();
            List<ClsBook> listBook = BookIO.GetListBook();
            foreach (ClsBook book in listBook)
            {
                ListViewItem item = new ListViewItem(book.Isbn);
                item.SubItems.Add(book.ProductName);
                item.SubItems.Add(book.BookGenre.ToString());
                item.SubItems.Add(book.Price.ToString());
                item.SubItems.Add(book.Quantity.ToString());
                item.SubItems.Add(book.Authors.Name.FirstName + " " + book.Authors.Name.LastName);
                item.SubItems.Add(book.Publisher.BusinessName);
                item.SubItems.Add(book.PubDate.ToString());
                item.SubItems.Add(book.CdIncluded.ToString());
                listViewBookResult.Items.Add(item);
            }
        }

        private void buttonPrintClientResult_Click(object sender, EventArgs e)
        {
            ClsClient cli = new ClsClient();
            ushort SearchID = 0;
            string searchEmail = "";

            if (textBoxInfoClientSearch.Text != "")
            {
                switch (comboBoxClientSearchOption.SelectedIndex)
                {
                    case 0:
                        SearchID = Convert.ToUInt16(textBoxInfoClientSearch.Text);
                        cli = ClientIO.SearchById(SearchID);
                        if (cli != null) {
                            textBoxClientIdResult.Text = SearchID.ToString();
                            textBoxClientFirstNameResult.Text = cli.Name.FirstName;
                            textBoxClientLastNameResult.Text = cli.Name.LastName;
                            maskedTextBoxClientAgeResult.Text = cli.Age.ToString();
                            comboBoxClientSexResult.SelectedItem = cli.SexGenre.ToString();
                            maskedTextBoxClientPhoneResult.Text = cli.Phone;
                            textBoxClientEmailResult.Text = cli.Email;
                            maskedTextBoxClientStrNbResult.Text = cli.Address.StreetNumber.ToString();
                            textBoxClientStrNameResult.Text = cli.Address.StreetName;
                            maskedTextBoxClientAppNbResult.Text = cli.Address.AppNumber.ToString();
                            textBoxClientZipResult.Text = cli.Address.PostalCode;
                            textBoxClientCityResult.Text = cli.Address.City;
                            textBoxClientStateResult.Text = cli.Address.State;
                            comboBoxClientTypeResult.SelectedItem = cli.ClientType.ToString();
                        }
                        break;
                    case 1:
                        searchEmail = textBoxInfoClientSearch.Text;
                        cli = ClientIO.SearchByEmail(searchEmail);
                        if (cli != null){
                            textBoxClientIdResult.Text = SearchID.ToString();
                            textBoxClientFirstNameResult.Text = cli.Name.FirstName;
                            textBoxClientLastNameResult.Text = cli.Name.LastName;
                            maskedTextBoxClientAgeResult.Text = cli.Age.ToString();
                            comboBoxClientSexResult.SelectedItem = cli.SexGenre.ToString();
                            maskedTextBoxClientPhoneResult.Text = cli.Phone;
                            textBoxClientEmailResult.Text = cli.Email;
                            maskedTextBoxClientStrNbResult.Text = cli.Address.StreetNumber.ToString();
                            textBoxClientStrNameResult.Text = cli.Address.StreetName;
                            maskedTextBoxClientAppNbResult.Text = cli.Address.AppNumber.ToString();
                            textBoxClientZipResult.Text = cli.Address.PostalCode;
                            textBoxClientCityResult.Text = cli.Address.City;
                            textBoxClientStateResult.Text = cli.Address.State;
                            comboBoxClientTypeResult.SelectedItem = cli.ClientType.ToString();
                        }
                        else{
                            MessageBox.Show("This email doesn't exist");
                        }
                        break;
                }
            }
        }

        private void buttonModifierAuteur_Click(object sender, EventArgs e)
        {
            if (Validator.IsValid_1(textBoxClientFirstNameResult, textBoxClientFirstNameResult.Text, textBoxClientLastNameResult, textBoxClientLastNameResult.Text, maskedTextBoxClientAgeResult, comboBoxClientSexResult, maskedTextBoxClientPhoneResult, maskedTextBoxClientPhoneResult.Text.Length,
                                       textBoxClientEmailResult, textBoxClientEmailResult.Text, maskedTextBoxClientStrNbResult, textBoxClientStrNameResult, textBoxClientStrNameResult.Text, maskedTextBoxClientAppNbResult, textBoxClientZipResult, textBoxClientZipResult.Text, textBoxClientCityResult,
                                       textBoxClientCityResult.Text, textBoxClientStateResult, textBoxClientStateResult.Text, comboBoxClientTypeResult))
            {
                ClsClient cli = new ClsClient();
                cli.Name = new ClsFullName(textBoxClientFirstNameResult.Text, textBoxClientLastNameResult.Text);
                cli.Age = Convert.ToUInt16(maskedTextBoxClientAgeResult.Text);

                switch (comboBoxClientSexResult.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a gender for your client.");
                        break;
                    case 1:
                        cli.SexGenre = EnumSexGenre.male;
                        break;
                    case 2:
                        cli.SexGenre = EnumSexGenre.female;
                        break;
                }

                cli.Address = new ClsAddress(Convert.ToUInt16(maskedTextBoxClientStrNbResult.Text), textBoxClientStrNameResult.Text, Convert.ToUInt16(maskedTextBoxClientAppNbResult.Text), textBoxClientZipResult.Text, textBoxClientCityResult.Text, textBoxClientStateResult.Text);
                cli.Phone = maskedTextBoxClientPhoneResult.Text;
                cli.Email = textBoxClientEmailResult.Text;
                cli.ClientId = Convert.ToUInt16(textBoxClientIdResult.Text);

                switch (comboBoxClientTypeResult.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a type for your client.");
                        break;
                    case 1:
                        cli.ClientType = EnumClientType.normal;
                        break;
                    case 2:
                        cli.ClientType = EnumClientType.employee;
                        break;
                    case 3:
                        cli.ClientType = EnumClientType.vip;
                        break;
                }

                bool success = ClientIO.ModClient(cli);
                ClearClientSearchField();
                if (File.Exists(filePathClient))
                {
                    GenerateClientList();
                }
            }
        }

        private void buttonHRReturn_Click(object sender, EventArgs e)
        {
            ClearClientSearchField();
            if (File.Exists(filePathClient))
            {
                GenerateClientList();
            }
            this.Hide();
        }

        private void buttonSupprimerAuteur_Click(object sender, EventArgs e)
        {
            if(textBoxClientIdResult.Text != ""){
                ushort searchId = Convert.ToUInt16(textBoxClientIdResult.Text);
                bool success = ClientIO.DelClient(searchId);
                ClearClientSearchField();
                if (File.Exists(filePathClient))
                {
                    GenerateClientList();
                }
            }
        }

        private void buttonClientSearchClear_Click(object sender, EventArgs e)
        {
            ClearClientSearchField();
        }

        private void ClearClientSearchField(){
            comboBoxClientSearchOption.SelectedIndex = 0;
            textBoxInfoClientSearch.Clear();
            textBoxClientIdResult.Clear();
            textBoxClientFirstNameResult.Clear();
            textBoxClientLastNameResult.Clear();
            maskedTextBoxClientAgeResult.Clear();
            comboBoxClientSexResult.SelectedItem = 0;
            maskedTextBoxClientPhoneResult.Clear();
            textBoxClientEmailResult.Clear();
            maskedTextBoxClientStrNbResult.Clear();
            textBoxClientStrNameResult.Clear();
            maskedTextBoxClientAppNbResult.Clear();
            textBoxClientZipResult.Clear();
            textBoxClientCityResult.Clear();
            textBoxClientStateResult.Clear();
            comboBoxClientTypeResult.SelectedIndex = 0;
        }

        private void buttonProductPrintToList_Click(object sender, EventArgs e)
        {
            ClsBook book = new ClsBook();
            string isbn = "";
            string pub = "";

            if (textBoxInfoBookSearch.Text != "")
            {
                switch (comboBoxClientSearchOption.SelectedIndex)
                {
                    case 0:
                        isbn = textBoxInfoClientSearch.Text;
                        book = BookIO.SearchByISBN(isbn);
                        if (book != null)
                        {
                            maskedTextBoxIsbnResult.Text = isbn.ToString();
                            textBoxProductNameResult.Text = book.ProductName;
                            comboBoxBookGenreResult.SelectedItem = book.BookGenre.ToString();
                            numericUpDownBookPriceResult.Value = book.Price;
                            numericUpDownBookQuantityResult.Value = book.Quantity;
                            comboBoxBookAuthorResult.SelectedItem = book.Authors.Name.LastName + " " + book.Authors.Name.FirstName;
                            comboBoxBookPublisherResult.SelectedItem = book.Publisher.BusinessName;
                            dateTimePickerBookPubDateResult.Value = book.PubDate;
                            comboBoxBookCDIncludedResult.SelectedItem = book.CdIncluded.ToString();
                        }
                        else
                        {
                            MessageBox.Show("This isbn doesn't exist");
                        }
                        break;
                    case 1:
                        pub = comboBoxBookPublisherResult.SelectedItem.ToString();
                        book = BookIO.SearchByPublisher(pub);
                        if (book != null)
                        {
                            maskedTextBoxIsbnResult.Text = isbn.ToString();
                            textBoxProductNameResult.Text = book.ProductName;
                            comboBoxBookGenreResult.SelectedItem = book.BookGenre.ToString();
                            numericUpDownBookPriceResult.Value = book.Price;
                            numericUpDownBookQuantityResult.Value = book.Quantity;
                            comboBoxBookAuthorResult.SelectedItem = book.Authors.Name.LastName + " " + book.Authors.Name.FirstName;
                            comboBoxBookPublisherResult.SelectedItem = book.Publisher.BusinessName;
                            dateTimePickerBookPubDateResult.Value = book.PubDate;
                            comboBoxBookCDIncludedResult.SelectedItem = book.CdIncluded.ToString();
                        }
                        else
                        {
                            MessageBox.Show("This publisher doesn't exist");
                        }
                        break;
                }
            }
        }

        private void buttonModifierBook_Click(object sender, EventArgs e)
        {
            if (Validator.IsValidBook(maskedTextBoxIsbnResult, maskedTextBoxIsbnResult.Text.Length, textBoxProductNameResult, textBoxProductNameResult.Text, comboBoxBookGenreResult,
                                       numericUpDownBookPriceResult, numericUpDownBookQuantityResult, comboBoxBookAuthorResult, comboBoxBookPublisherResult, comboBoxBookCDIncludedResult))
            {
                ClsBook book = new ClsBook();
                book.Isbn = maskedTextBoxIsbnResult.Text;
                book.ProductName = textBoxProductNameResult.Text;

                switch(comboBoxBookGenreResult.SelectedIndex){
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

                book.Price = numericUpDownBookPriceResult.Value;
                book.Quantity = Convert.ToUInt16(numericUpDownBookQuantityResult.Value);

                book.Authors.Name.FirstName = comboBoxBookAuthorResult.SelectedItem.ToString();
                book.Publisher.BusinessName = comboBoxBookPublisherResult.SelectedItem.ToString();

                book.PubDate = dateTimePickerBookPubDateResult.Value;

                switch(comboBoxBookCDIncludedResult.SelectedIndex){
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

                bool success = BookIO.ModBook(book);
                ClearBookSearchField();
                if (File.Exists(filePathBook))
                {
                    GenerateBookList();
                }
            }
        }

        private void buttonDelBook_Click(object sender, EventArgs e){
            if (maskedTextBoxIsbnResult.Text != "")
            {
                string isbn = maskedTextBoxIsbnResult.Text;
                bool success = BookIO.DelBook(isbn);
                ClearBookSearchField();
                if (File.Exists(filePathBook))
                {
                    GenerateBookList();
                }
            }  
        }

        private void buttonClearBookField_Click(object sender, EventArgs e)
        {
            ClearBookSearchField();           
        }

        private void buttonBookReturn_Click(object sender, EventArgs e)
        {
            ClearBookSearchField();
            if (File.Exists(filePathBook))
            {
                GenerateBookList();
            }
            this.Hide();
        }

        private void ClearBookSearchField(){
            comboBoxBookSearchOption.SelectedIndex = 0;
            textBoxInfoBookSearch.Clear();
            maskedTextBoxIsbnResult.Clear();
            textBoxProductNameResult.Clear();
            comboBoxBookGenreResult.SelectedItem = 0;
            numericUpDownBookPriceResult.Value = 0.0m;
            numericUpDownBookQuantityResult.Value = 0;
            comboBoxBookAuthorResult.SelectedIndex = 0;
            comboBoxBookPublisherResult.SelectedIndex = 0;
            dateTimePickerBookPubDateResult.Value = DateTime.Now;
            comboBoxBookCDIncludedResult.SelectedIndex = 0;
        }
    }
}