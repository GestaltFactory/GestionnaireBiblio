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
    public partial class FrmHR : Form
    {
        public FrmHR()
        {
            InitializeComponent();
        }

        const string dir = @"";
        const string filePathClient = dir + "Client.txt";
        const string filePathAuthor = dir + "Author.txt";
        const string filePathEmp = dir + "Employee.txt";
        const string filePathPub = dir + "Publisher.txt";
        const string filePathDis = dir + "Distributor.txt";

        int cliNb, autNb, empNb, pubNb, disNb;

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

        private void FrmClient_Load(object sender, EventArgs e)
        {
            comboBoxClientSex.DataSource = Enum.GetNames(typeof(EnumSexGenre));
            comboBoxClientType.DataSource = Enum.GetNames(typeof(EnumClientType));
            comboBoxAuthorSex.DataSource = Enum.GetNames(typeof(EnumSexGenre));
            comboBoxAuthorGenre.DataSource = Enum.GetNames(typeof(EnumAuthorGenre));
            comboBoxEmpSex.DataSource = Enum.GetNames(typeof(EnumSexGenre));
            comboBoxEmpJobTitle.DataSource = Enum.GetNames(typeof(EnumJobTitle));
            comboBoxPubGenre.DataSource = Enum.GetNames(typeof(EnumAuthorGenre));
            comboBoxDisItemType.DataSource = Enum.GetNames(typeof(EnumTypeItem));

            if(File.Exists(filePathClient)){
                List<ClsClient> listClient = ClientIO.GetListClient();
                textBoxClientId.Text = listClient.Count().ToString();
                if (listClient.Count() < 1){                    
                    cliNb = listClient.Count() + 1;
                }
                else{
                    cliNb = listClient.Count();
                }
            }
            else{
                textBoxClientId.Text = "1";
            }

            if (File.Exists(filePathAuthor)){
                List<ClsAuthor> listAuthor = AuthorIO.GetListAuthor();
                textBoxAuthorId.Text = listAuthor.Count().ToString();
                if (listAuthor.Count() < 1)
                {
                    autNb = listAuthor.Count() +1;
                }
                else
                {
                    autNb = listAuthor.Count();
                }
                
            }
            else {
                textBoxAuthorId.Text = "1";
            }

            if (File.Exists(filePathEmp)){
                List<ClsEmployee> listEmp = EmployeeIO.GetListEmployee();
                textBoxEmpId.Text = listEmp.Count().ToString();
                if (listEmp.Count() < 1)
                {
                    empNb = listEmp.Count() +1;
                }
                else
                {
                    empNb = listEmp.Count();
                }
                
            }
            else{
                textBoxEmpId.Text = "1";
            }

            if (File.Exists(filePathPub)){
                List<ClsPublisher> listPub = PublisherIO.GetListPublisher();
                textBoxPubId.Text = listPub.Count().ToString();
                if (listPub.Count() < 1)
                {
                    pubNb = listPub.Count() +1;
                }
                else
                {
                    pubNb = listPub.Count();
                }
                
            }
            else{
                textBoxPubId.Text = "1";
            }

            if (File.Exists(filePathDis)){
                List<ClsDistributor> listDis = DistributorIO.GetListDistributor();
                textBoxDisId.Text = listDis.Count().ToString();
                if (listDis.Count() < 1)
                {
                    disNb = listDis.Count() +1;
                }
                else
                {
                    disNb = listDis.Count();
                }
                
            }
            else {
                textBoxDisId.Text = "1";
            }
        }

        /// <summary>
        /// Add a client
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            if (Validator.IsValid_1(textBoxClientFirstName, textBoxClientFirstName.Text, textBoxClientLastName, textBoxClientLastName.Text, maskedTextBoxClientAge, comboBoxClientSex, maskedTextBoxClientPhone, maskedTextBoxClientPhone.Text.Length,
                                       textBoxClientEmail, textBoxClientEmail.Text, maskedTextBoxClientStrNb, textBoxClientStrName, textBoxClientStrName.Text, maskedTextBoxClientAppNb, textBoxClientZip, textBoxClientZip.Text, textBoxClientCity,
                                       textBoxClientCity.Text, textBoxClientState, textBoxClientState.Text, comboBoxClientType) && Validator.IsUniqValueClient(maskedTextBoxClientPhone.Text) && Validator.IsUniqValueClient(textBoxClientEmail.Text))
            {
                ClsClient cli = new ClsClient();
                cli.ClientId = Convert.ToUInt16(textBoxClientId.Text);
                cli.Name = new ClsFullName(textBoxClientFirstName.Text, textBoxClientLastName.Text);
                cli.Age = Convert.ToUInt16(maskedTextBoxClientAge.Text);

                switch (comboBoxClientSex.SelectedIndex)
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

                cli.Address = new ClsAddress(Convert.ToUInt16(maskedTextBoxClientStrNb.Text), textBoxClientStrName.Text, Convert.ToUInt16(maskedTextBoxClientAppNb.Text), textBoxClientZip.Text, textBoxClientCity.Text, textBoxClientState.Text);
                cli.Phone = maskedTextBoxClientPhone.Text;
                cli.Email = textBoxClientEmail.Text;                

                switch (comboBoxClientType.SelectedIndex)
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

                //Sauvegarder info
                string msg = "";
                ClientIO.SaveClient(cli, out msg);
                labelInfoCreation.Text = msg;

                cliNb++;
                textBoxClientId.Text = cliNb.ToString();
                ClearClientData();
            }
        }

        private void buttonClearField_Click(object sender, EventArgs e)
        {
            ClearClientData();
        }

        private void ClearClientData(){
            textBoxClientFirstName.Clear();
            textBoxClientLastName.Clear();
            maskedTextBoxClientAge.Clear();
            comboBoxClientSex.SelectedIndex = 0;
            maskedTextBoxClientPhone.Clear();
            textBoxClientEmail.Clear();
            maskedTextBoxClientStrNb.Clear();
            textBoxClientStrName.Clear();
            maskedTextBoxClientAppNb.Clear();
            textBoxClientZip.Clear();
            textBoxClientCity.Clear();
            textBoxClientState.Clear();
            comboBoxClientType.SelectedIndex = 0;
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            ClearClientData();
            this.Hide();
        }

        private void buttonAddAuthor_Click(object sender, EventArgs e)
        {
            if (Validator.IsValid_1(textBoxAuthorFirstName, textBoxAuthorFirstName.Text, textBoxAuthorLastName, textBoxAuthorLastName.Text, maskedTextBoxAuthorAge, comboBoxAuthorSex, maskedTextBoxAuthorPhone, maskedTextBoxAuthorPhone.Text.Length,
                                       textBoxAuthorEmail, textBoxAuthorEmail.Text, maskedTextBoxAuthorStrNb, textBoxAuthorStrName, textBoxAuthorStrName.Text, maskedTextBoxAuthorAppNb, textBoxAuthorZip, textBoxAuthorZip.Text, textBoxAuthorCity,
                                       textBoxAuthorCity.Text, textBoxAuthorState, textBoxAuthorState.Text, comboBoxAuthorGenre) && Validator.IsUniqValueAuthor(maskedTextBoxAuthorPhone.Text) && Validator.IsUniqValueAuthor(textBoxAuthorEmail.Text))
            {
                ClsAuthor aut = new ClsAuthor();
                aut.Name = new ClsFullName(textBoxAuthorFirstName.Text, textBoxAuthorLastName.Text);
                aut.Age = Convert.ToUInt16(maskedTextBoxAuthorAge.Text);

                switch (comboBoxAuthorSex.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a gender for your Author.");
                        break;
                    case 1:
                        aut.SexGenre = EnumSexGenre.male;
                        break;
                    case 2:
                        aut.SexGenre = EnumSexGenre.female;
                        break;
                }

                aut.Address = new ClsAddress(Convert.ToUInt16(maskedTextBoxAuthorStrNb.Text), textBoxAuthorStrName.Text, Convert.ToUInt16(maskedTextBoxAuthorAppNb.Text), textBoxAuthorZip.Text, textBoxAuthorCity.Text, textBoxAuthorState.Text);
                aut.Phone = maskedTextBoxAuthorPhone.Text;
                aut.Email = textBoxAuthorEmail.Text;
                aut.AuthorId = Convert.ToUInt16(textBoxAuthorId.Text);

                switch (comboBoxAuthorGenre.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a genre for your Author.");
                        break;
                    case 1:
                        aut.AuthorGenre = EnumAuthorGenre.Literature;
                        break;
                    case 2:
                        aut.AuthorGenre = EnumAuthorGenre.History;
                        break;
                    case 3:
                        aut.AuthorGenre = EnumAuthorGenre.Romance;
                        break;
                    case 4:
                        aut.AuthorGenre = EnumAuthorGenre.Fiction;
                        break;
                    case 5:
                        aut.AuthorGenre = EnumAuthorGenre.Horror;
                        break;
                    case 6:
                        aut.AuthorGenre = EnumAuthorGenre.Biography;
                        break;
                    case 7:
                        aut.AuthorGenre = EnumAuthorGenre.Genealogy;
                        break;
                    case 8:
                        aut.AuthorGenre = EnumAuthorGenre.Fantasy;
                        break;
                    case 9:
                        aut.AuthorGenre = EnumAuthorGenre.MixedGenre;
                        break;
                }

                //Sauvegarder info
                string msg = "";
                AuthorIO.SaveAuthor(aut, out msg);
                labelInfoCreation.Text = msg;

                autNb++;
                textBoxAuthorId.Text = autNb.ToString();
                ClearAutData();
            }
        }

        private void buttonAuthorClearField_Click(object sender, EventArgs e)
        {
            ClearAutData();
        }

        private void ClearAutData(){
            textBoxAuthorFirstName.Clear();
            textBoxAuthorLastName.Clear();
            maskedTextBoxAuthorAge.Clear();
            comboBoxAuthorSex.SelectedIndex = 0;
            maskedTextBoxAuthorPhone.Clear();
            textBoxAuthorEmail.Clear();
            maskedTextBoxAuthorStrNb.Clear();
            textBoxAuthorStrName.Clear();
            maskedTextBoxAuthorAppNb.Clear();
            textBoxAuthorZip.Clear();
            textBoxAuthorCity.Clear();
            textBoxAuthorState.Clear();
            comboBoxAuthorGenre.SelectedIndex = 0;
        }

        private void buttonAuthorReturn_Click(object sender, EventArgs e)
        {
            ClearAutData();
            this.Hide();
        }

        private void buttonAddEmp_Click(object sender, EventArgs e)
        {
            if (Validator.IsValid_1(textBoxEmpFirstName, textBoxEmpFirstName.Text, textBoxEmpLastName, textBoxEmpLastName.Text, maskedTextBoxEmpAge, comboBoxEmpSex, maskedTextBoxEmpPhone, maskedTextBoxEmpPhone.Text.Length,
                           textBoxEmpEmail, textBoxEmpEmail.Text, maskedTextBoxEmpStrNb, textBoxEmpStrName, textBoxEmpStrName.Text, maskedTextBoxEmpAppNb, textBoxEmpZip, textBoxEmpZip.Text, textBoxEmpCity,
                           textBoxEmpCity.Text, textBoxEmpState, textBoxEmpState.Text, comboBoxEmpJobTitle) && Validator.MinimumWage(numericUpDownEmpSalary) && Validator.IsUniqValueEmp(maskedTextBoxEmpPhone.Text) && Validator.IsUniqValueEmp(textBoxEmpEmail.Text))
            {
                ClsEmployee emp = new ClsEmployee();
                emp.Name = new ClsFullName(textBoxEmpFirstName.Text, textBoxEmpLastName.Text);
                emp.Age = Convert.ToUInt16(maskedTextBoxEmpAge.Text);

                switch (comboBoxEmpSex.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a gender for your employee.");
                        break;
                    case 1:
                        emp.SexGenre = EnumSexGenre.male;
                        break;
                    case 2:
                        emp.SexGenre = EnumSexGenre.female;
                        break;
                }

                emp.Address = new ClsAddress(Convert.ToUInt16(maskedTextBoxEmpStrNb.Text), textBoxEmpStrName.Text, Convert.ToUInt16(maskedTextBoxEmpAppNb.Text), textBoxEmpZip.Text, textBoxEmpCity.Text, textBoxEmpState.Text);
                emp.Phone = maskedTextBoxEmpPhone.Text;
                emp.Email = textBoxEmpEmail.Text;
                emp.EmpId = Convert.ToUInt16(textBoxEmpId.Text);

                switch (comboBoxEmpJobTitle.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a job title for your employee.");
                        break;
                    case 1:
                        emp.JobTitle = EnumJobTitle.Cashier;
                        break;
                    case 2:
                        emp.JobTitle = EnumJobTitle.bookDresser;
                        break;
                    case 3:
                        emp.JobTitle = EnumJobTitle.IT;
                        break;
                }

                emp.Salary = Convert.ToDecimal(numericUpDownEmpSalary.Value);
                emp.HiringDate = dateTimePickerEmp.Value;

                //Sauvegarder info
                string msg = "";
                EmployeeIO.SaveEmp(emp, out msg);
                labelInfoCreation.Text = msg;

                empNb++;
                textBoxEmpId.Text = empNb.ToString();
                ClearEmpData();
            }
        }

        private void buttonClearEmpField_Click(object sender, EventArgs e)
        {
            ClearEmpData();
        }

        private void ClearEmpData(){
            textBoxEmpFirstName.Clear();
            textBoxEmpLastName.Clear();
            maskedTextBoxEmpAge.Clear();
            comboBoxEmpSex.SelectedIndex = 0;
            maskedTextBoxEmpPhone.Clear();
            textBoxEmpEmail.Clear();
            maskedTextBoxEmpStrNb.Clear();
            textBoxEmpStrName.Clear();
            maskedTextBoxEmpAppNb.Clear();
            textBoxEmpZip.Clear();
            textBoxEmpCity.Clear();
            textBoxEmpState.Clear();
            comboBoxEmpJobTitle.SelectedIndex = 0;
            numericUpDownEmpSalary.Value = 0.00m;
            dateTimePickerEmp.Value = DateTime.Now;
        }

        private void buttonEmpReturn_Click(object sender, EventArgs e)
        {
            ClearEmpData();
            this.Hide();
        }

        private void buttonAddPub_Click(object sender, EventArgs e)
        {
            if (Validator.IsValid_2(textBoxPubBusName, textBoxPubBusName.Text, maskedTextBoxPubPhone, maskedTextBoxPubPhone.Text.Length, textBoxPubEmail, textBoxPubEmail.Text, maskedTextBoxPubStrNb, 
                                    textBoxPubStrName, textBoxPubStrName.Text, maskedTextBoxPubSuite, textBoxPubZip, textBoxPubZip.Text, textBoxPubCity, textBoxPubCity.Text, textBoxPubState,
                                    textBoxPubState.Text, comboBoxPubGenre) && Validator.IsPresentMasked(maskedTextBoxPubNbBook) && Validator.IsUniqValuePub(textBoxPubBusName.Text) && Validator.IsUniqValuePub(maskedTextBoxPubPhone.Text) &&
                                    Validator.IsUniqValuePub(textBoxPubEmail.Text))
            {
                ClsPublisher pub = new ClsPublisher();
                pub.BusinessName = textBoxPubBusName.Text;

                pub.Address = new ClsAddress(Convert.ToUInt16(maskedTextBoxPubStrNb.Text), textBoxPubStrName.Text, Convert.ToUInt16(maskedTextBoxPubSuite.Text), textBoxPubZip.Text, textBoxPubCity.Text, textBoxPubState.Text);
                pub.Phone = maskedTextBoxPubPhone.Text;
                pub.Email = textBoxPubEmail.Text;
                pub.PubId = Convert.ToUInt16(textBoxPubId.Text);

                switch (comboBoxPubGenre.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a genre for your Publisher.");
                        break;
                    case 1:
                        pub.AuthorGenre = EnumAuthorGenre.Literature;
                        break;
                    case 2:
                        pub.AuthorGenre = EnumAuthorGenre.History;
                        break;
                    case 3:
                        pub.AuthorGenre = EnumAuthorGenre.Romance;
                        break;
                    case 4:
                        pub.AuthorGenre = EnumAuthorGenre.Fiction;
                        break;
                    case 5:
                        pub.AuthorGenre = EnumAuthorGenre.Horror;
                        break;
                    case 6:
                        pub.AuthorGenre = EnumAuthorGenre.Biography;
                        break;
                    case 7:
                        pub.AuthorGenre = EnumAuthorGenre.Genealogy;
                        break;
                    case 8:
                        pub.AuthorGenre = EnumAuthorGenre.Fantasy;
                        break;
                    case 9:
                        pub.AuthorGenre = EnumAuthorGenre.MixedGenre;
                        break;
                }

                pub.NbOfBooksPublished = Convert.ToUInt16(maskedTextBoxPubNbBook.Text);

                //Sauvegarder info
                string msg = "";
                PublisherIO.SavePub(pub, out msg);
                labelInfoCreation.Text = msg;

                pubNb++;
                textBoxPubId.Text = pubNb.ToString();
                ClearPubData();
            }
        }

        private void buttonClearPubField_Click(object sender, EventArgs e)
        {
            ClearPubData();
        }

        private void ClearPubData(){
            textBoxPubBusName.Clear();
            maskedTextBoxPubPhone.Clear();
            textBoxPubEmail.Clear();
            maskedTextBoxPubStrNb.Clear();
            textBoxPubStrName.Clear();
            maskedTextBoxPubSuite.Clear();
            textBoxPubZip.Clear();
            textBoxPubCity.Clear();
            textBoxPubState.Clear();
            comboBoxPubGenre.SelectedIndex = 0;
            maskedTextBoxPubNbBook.Clear();
        }

        private void buttonPubReturn_Click(object sender, EventArgs e)
        {
            ClearPubData();
            this.Hide();
        }

        private void buttonAddDis_Click(object sender, EventArgs e)
        {
            if (Validator.IsValid_2(textBoxDisBusName, textBoxDisBusName.Text, maskedTextBoxDisPhone, maskedTextBoxDisPhone.Text.Length, textBoxDisEmail, textBoxDisEmail.Text, maskedTextBoxDisStrNb,
                        textBoxDisStrName, textBoxDisStrName.Text, maskedTextBoxDisSuite, textBoxDisZip, textBoxDisZip.Text, textBoxDisCity, textBoxDisCity.Text, textBoxDisState,
                        textBoxDisState.Text, comboBoxDisItemType) && Validator.IsUniqValueDis(textBoxDisBusName.Text) && Validator.IsUniqValueDis(maskedTextBoxDisPhone.Text) &&
                        Validator.IsUniqValueDis(textBoxDisEmail.Text))
            {
                ClsDistributor dis = new ClsDistributor();
                dis.BusinessName = textBoxDisBusName.Text;
                dis.Address = new ClsAddress(Convert.ToUInt16(maskedTextBoxDisStrNb.Text), textBoxDisStrName.Text, Convert.ToUInt16(maskedTextBoxDisSuite.Text), textBoxDisZip.Text, textBoxDisCity.Text, textBoxDisState.Text);
                dis.Phone = maskedTextBoxDisPhone.Text;
                dis.Email = textBoxDisEmail.Text;
                dis.DisId = Convert.ToUInt16(textBoxDisId.Text);

                switch (comboBoxDisItemType.SelectedIndex)
                {
                    case 0:
                        MessageBox.Show("You must select a type of item for your Distributor.");
                        break;
                    case 1:
                        dis.TypeDisItem = EnumTypeItem.book;
                        break;
                    case 2:
                        dis.TypeDisItem = EnumTypeItem.review;
                        break;
                    case 3:
                        dis.TypeDisItem = EnumTypeItem.movie;
                        break;
                    case 4:
                        dis.TypeDisItem = EnumTypeItem.software;
                        break;
                    case 5:
                        dis.TypeDisItem = EnumTypeItem.cd;
                        break;
                }

                //Sauvegarder info
                string msg = "";
                DistributorIO.SaveDis(dis, out msg);
                labelInfoCreation.Text = msg;

                disNb++;
                textBoxDisId.Text = disNb.ToString();
                ClearDisData();
            }
        }

        private void buttonClearDisField_Click(object sender, EventArgs e)
        {
            ClearDisData();
        }

        private void ClearDisData(){
            textBoxDisBusName.Clear();
            maskedTextBoxDisPhone.Clear();
            textBoxDisEmail.Clear();
            maskedTextBoxDisStrNb.Clear();
            textBoxDisStrName.Clear();
            maskedTextBoxDisSuite.Clear();
            textBoxDisZip.Clear();
            textBoxDisCity.Clear();
            textBoxDisState.Clear();
            comboBoxDisItemType.SelectedIndex = 0;
        }

        private void buttonDisReturn_Click(object sender, EventArgs e)
        {
            ClearDisData();
            this.Hide();
        }
    }
}