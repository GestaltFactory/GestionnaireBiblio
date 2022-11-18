namespace GestionnaireBiblio.GUI
{
    partial class FrmAddProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlProduct = new System.Windows.Forms.TabControl();
            this.tabPageBook = new System.Windows.Forms.TabPage();
            this.labelInfoCreation = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.comboBoxBookAuthor = new System.Windows.Forms.ComboBox();
            this.buttonClearBookField = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxBookPublisher = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.comboBoxBookGenre = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.maskedTextBoxIsbn = new System.Windows.Forms.MaskedTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBoxBookCDIncluded = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.numericUpDownBookQuantity = new System.Windows.Forms.NumericUpDown();
            this.label25 = new System.Windows.Forms.Label();
            this.dateTimePickerBookPubDate = new System.Windows.Forms.DateTimePicker();
            this.label26 = new System.Windows.Forms.Label();
            this.numericUpDownBookPrice = new System.Windows.Forms.NumericUpDown();
            this.label28 = new System.Windows.Forms.Label();
            this.textBoxBookProductName = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBoxProductInfo = new System.Windows.Forms.GroupBox();
            this.buttonSoftwareReturn = new System.Windows.Forms.Button();
            this.buttonAddSoftware = new System.Windows.Forms.Button();
            this.buttonClearSoftwareField = new System.Windows.Forms.Button();
            this.comboBoxSoftPublisher = new System.Windows.Forms.ComboBox();
            this.numericUpDownSoftQuantity = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerSoftPubDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownSoftPrice = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSoftName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxSoftType = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSoftId = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabControlProduct.SuspendLayout();
            this.tabPageBook.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookPrice)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBoxProductInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoftQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoftPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlProduct
            // 
            this.tabControlProduct.Controls.Add(this.tabPageBook);
            this.tabControlProduct.Controls.Add(this.tabPage2);
            this.tabControlProduct.Location = new System.Drawing.Point(28, 26);
            this.tabControlProduct.Name = "tabControlProduct";
            this.tabControlProduct.SelectedIndex = 0;
            this.tabControlProduct.Size = new System.Drawing.Size(844, 407);
            this.tabControlProduct.TabIndex = 0;
            // 
            // tabPageBook
            // 
            this.tabPageBook.Controls.Add(this.groupBox1);
            this.tabPageBook.Location = new System.Drawing.Point(4, 22);
            this.tabPageBook.Name = "tabPageBook";
            this.tabPageBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBook.Size = new System.Drawing.Size(836, 381);
            this.tabPageBook.TabIndex = 0;
            this.tabPageBook.Text = "Book page";
            this.tabPageBook.UseVisualStyleBackColor = true;
            // 
            // labelInfoCreation
            // 
            this.labelInfoCreation.AutoSize = true;
            this.labelInfoCreation.Location = new System.Drawing.Point(34, 439);
            this.labelInfoCreation.Name = "labelInfoCreation";
            this.labelInfoCreation.Size = new System.Drawing.Size(0, 13);
            this.labelInfoCreation.TabIndex = 21;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReturnBook);
            this.groupBox1.Controls.Add(this.buttonAddBook);
            this.groupBox1.Controls.Add(this.comboBoxBookAuthor);
            this.groupBox1.Controls.Add(this.buttonClearBookField);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.comboBoxBookPublisher);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.comboBoxBookGenre);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.maskedTextBoxIsbn);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.comboBoxBookCDIncluded);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.numericUpDownBookQuantity);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.dateTimePickerBookPubDate);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.numericUpDownBookPrice);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.textBoxBookProductName);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(130, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 276);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Information";
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReturnBook.Location = new System.Drawing.Point(454, 201);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(81, 59);
            this.buttonReturnBook.TabIndex = 24;
            this.buttonReturnBook.Text = "Return";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddBook.Location = new System.Drawing.Point(454, 27);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(81, 59);
            this.buttonAddBook.TabIndex = 22;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // comboBoxBookAuthor
            // 
            this.comboBoxBookAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookAuthor.FormattingEnabled = true;
            this.comboBoxBookAuthor.Items.AddRange(new object[] {
            "Undefined"});
            this.comboBoxBookAuthor.Location = new System.Drawing.Point(224, 43);
            this.comboBoxBookAuthor.Name = "comboBoxBookAuthor";
            this.comboBoxBookAuthor.Size = new System.Drawing.Size(168, 26);
            this.comboBoxBookAuthor.TabIndex = 162;
            this.comboBoxBookAuthor.Tag = "Author";
            this.comboBoxBookAuthor.Text = "Undefined";
            // 
            // buttonClearBookField
            // 
            this.buttonClearBookField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearBookField.Location = new System.Drawing.Point(453, 113);
            this.buttonClearBookField.Name = "buttonClearBookField";
            this.buttonClearBookField.Size = new System.Drawing.Size(82, 59);
            this.buttonClearBookField.TabIndex = 23;
            this.buttonClearBookField.Text = "Clear";
            this.buttonClearBookField.UseVisualStyleBackColor = true;
            this.buttonClearBookField.Click += new System.EventHandler(this.buttonClearBookField_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(221, 27);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 18);
            this.label12.TabIndex = 163;
            this.label12.Text = "Main Author";
            // 
            // comboBoxBookPublisher
            // 
            this.comboBoxBookPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookPublisher.FormattingEnabled = true;
            this.comboBoxBookPublisher.Items.AddRange(new object[] {
            "Undefined"});
            this.comboBoxBookPublisher.Location = new System.Drawing.Point(224, 93);
            this.comboBoxBookPublisher.Name = "comboBoxBookPublisher";
            this.comboBoxBookPublisher.Size = new System.Drawing.Size(168, 26);
            this.comboBoxBookPublisher.TabIndex = 134;
            this.comboBoxBookPublisher.Tag = "Publisher";
            this.comboBoxBookPublisher.Text = "Undefined";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(221, 77);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(62, 18);
            this.label23.TabIndex = 135;
            this.label23.Text = "Publisher";
            // 
            // comboBoxBookGenre
            // 
            this.comboBoxBookGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookGenre.FormattingEnabled = true;
            this.comboBoxBookGenre.Location = new System.Drawing.Point(35, 142);
            this.comboBoxBookGenre.Name = "comboBoxBookGenre";
            this.comboBoxBookGenre.Size = new System.Drawing.Size(137, 26);
            this.comboBoxBookGenre.TabIndex = 161;
            this.comboBoxBookGenre.Tag = "Book Genre";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(33, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 15);
            this.label11.TabIndex = 160;
            this.label11.Text = "Book Genre";
            // 
            // maskedTextBoxIsbn
            // 
            this.maskedTextBoxIsbn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBoxIsbn.Location = new System.Drawing.Point(34, 41);
            this.maskedTextBoxIsbn.Mask = "000-0-00-000000-0";
            this.maskedTextBoxIsbn.Name = "maskedTextBoxIsbn";
            this.maskedTextBoxIsbn.Size = new System.Drawing.Size(137, 24);
            this.maskedTextBoxIsbn.TabIndex = 121;
            this.maskedTextBoxIsbn.Tag = "ISBN";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(33, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 15);
            this.label15.TabIndex = 159;
            this.label15.Text = "ISBN";
            // 
            // comboBoxBookCDIncluded
            // 
            this.comboBoxBookCDIncluded.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxBookCDIncluded.FormattingEnabled = true;
            this.comboBoxBookCDIncluded.Location = new System.Drawing.Point(224, 194);
            this.comboBoxBookCDIncluded.Name = "comboBoxBookCDIncluded";
            this.comboBoxBookCDIncluded.Size = new System.Drawing.Size(121, 26);
            this.comboBoxBookCDIncluded.TabIndex = 156;
            this.comboBoxBookCDIncluded.Tag = "CD included";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(222, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 15);
            this.label18.TabIndex = 155;
            this.label18.Text = "CD included?";
            // 
            // numericUpDownBookQuantity
            // 
            this.numericUpDownBookQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBookQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBookQuantity.Location = new System.Drawing.Point(37, 240);
            this.numericUpDownBookQuantity.Name = "numericUpDownBookQuantity";
            this.numericUpDownBookQuantity.Size = new System.Drawing.Size(69, 24);
            this.numericUpDownBookQuantity.TabIndex = 31;
            this.numericUpDownBookQuantity.Tag = "Quantity";
            this.numericUpDownBookQuantity.ThousandsSeparator = true;
            this.numericUpDownBookQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(34, 223);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(51, 15);
            this.label25.TabIndex = 30;
            this.label25.Text = "Quantity";
            // 
            // dateTimePickerBookPubDate
            // 
            this.dateTimePickerBookPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBookPubDate.Location = new System.Drawing.Point(225, 144);
            this.dateTimePickerBookPubDate.Name = "dateTimePickerBookPubDate";
            this.dateTimePickerBookPubDate.Size = new System.Drawing.Size(167, 24);
            this.dateTimePickerBookPubDate.TabIndex = 26;
            this.dateTimePickerBookPubDate.Tag = "Publication Date";
            this.dateTimePickerBookPubDate.Value = new System.DateTime(2015, 11, 28, 0, 0, 0, 0);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(224, 128);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(97, 15);
            this.label26.TabIndex = 18;
            this.label26.Text = "Publication Date";
            // 
            // numericUpDownBookPrice
            // 
            this.numericUpDownBookPrice.DecimalPlaces = 2;
            this.numericUpDownBookPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBookPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBookPrice.Location = new System.Drawing.Point(36, 193);
            this.numericUpDownBookPrice.Name = "numericUpDownBookPrice";
            this.numericUpDownBookPrice.Size = new System.Drawing.Size(70, 24);
            this.numericUpDownBookPrice.TabIndex = 27;
            this.numericUpDownBookPrice.Tag = "Price";
            this.numericUpDownBookPrice.ThousandsSeparator = true;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(34, 176);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(35, 15);
            this.label28.TabIndex = 16;
            this.label28.Text = "Price";
            // 
            // textBoxBookProductName
            // 
            this.textBoxBookProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBookProductName.Location = new System.Drawing.Point(36, 93);
            this.textBoxBookProductName.Name = "textBoxBookProductName";
            this.textBoxBookProductName.Size = new System.Drawing.Size(137, 24);
            this.textBoxBookProductName.TabIndex = 11;
            this.textBoxBookProductName.Tag = "Product Name";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(33, 75);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(86, 15);
            this.label29.TabIndex = 1;
            this.label29.Text = "Product Name";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBoxProductInfo);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(836, 381);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Software page";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBoxProductInfo
            // 
            this.groupBoxProductInfo.Controls.Add(this.textBoxSoftId);
            this.groupBoxProductInfo.Controls.Add(this.label27);
            this.groupBoxProductInfo.Controls.Add(this.label1);
            this.groupBoxProductInfo.Controls.Add(this.label6);
            this.groupBoxProductInfo.Controls.Add(this.comboBoxSoftType);
            this.groupBoxProductInfo.Controls.Add(this.comboBoxSoftPublisher);
            this.groupBoxProductInfo.Controls.Add(this.numericUpDownSoftQuantity);
            this.groupBoxProductInfo.Controls.Add(this.label2);
            this.groupBoxProductInfo.Controls.Add(this.dateTimePickerSoftPubDate);
            this.groupBoxProductInfo.Controls.Add(this.label3);
            this.groupBoxProductInfo.Controls.Add(this.numericUpDownSoftPrice);
            this.groupBoxProductInfo.Controls.Add(this.label4);
            this.groupBoxProductInfo.Controls.Add(this.textBoxSoftName);
            this.groupBoxProductInfo.Controls.Add(this.label5);
            this.groupBoxProductInfo.Controls.Add(this.buttonSoftwareReturn);
            this.groupBoxProductInfo.Controls.Add(this.buttonAddSoftware);
            this.groupBoxProductInfo.Controls.Add(this.buttonClearSoftwareField);
            this.groupBoxProductInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxProductInfo.Location = new System.Drawing.Point(50, 6);
            this.groupBoxProductInfo.Name = "groupBoxProductInfo";
            this.groupBoxProductInfo.Size = new System.Drawing.Size(691, 349);
            this.groupBoxProductInfo.TabIndex = 19;
            this.groupBoxProductInfo.TabStop = false;
            this.groupBoxProductInfo.Text = "Software Information";
            // 
            // buttonSoftwareReturn
            // 
            this.buttonSoftwareReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSoftwareReturn.Location = new System.Drawing.Point(568, 224);
            this.buttonSoftwareReturn.Name = "buttonSoftwareReturn";
            this.buttonSoftwareReturn.Size = new System.Drawing.Size(107, 72);
            this.buttonSoftwareReturn.TabIndex = 21;
            this.buttonSoftwareReturn.Text = "Return";
            this.buttonSoftwareReturn.UseVisualStyleBackColor = true;
            this.buttonSoftwareReturn.Click += new System.EventHandler(this.buttonSoftwareReturn_Click);
            // 
            // buttonAddSoftware
            // 
            this.buttonAddSoftware.BackColor = System.Drawing.SystemColors.Control;
            this.buttonAddSoftware.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddSoftware.Location = new System.Drawing.Point(568, 50);
            this.buttonAddSoftware.Name = "buttonAddSoftware";
            this.buttonAddSoftware.Size = new System.Drawing.Size(107, 72);
            this.buttonAddSoftware.TabIndex = 19;
            this.buttonAddSoftware.Text = "Add Software";
            this.buttonAddSoftware.UseVisualStyleBackColor = false;
            this.buttonAddSoftware.Click += new System.EventHandler(this.buttonAddSoftware_Click);
            // 
            // buttonClearSoftwareField
            // 
            this.buttonClearSoftwareField.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearSoftwareField.Location = new System.Drawing.Point(568, 137);
            this.buttonClearSoftwareField.Name = "buttonClearSoftwareField";
            this.buttonClearSoftwareField.Size = new System.Drawing.Size(107, 72);
            this.buttonClearSoftwareField.TabIndex = 20;
            this.buttonClearSoftwareField.Text = "Clear";
            this.buttonClearSoftwareField.UseVisualStyleBackColor = true;
            this.buttonClearSoftwareField.Click += new System.EventHandler(this.buttonClearSoftwareField_Click);
            // 
            // comboBoxSoftPublisher
            // 
            this.comboBoxSoftPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSoftPublisher.FormattingEnabled = true;
            this.comboBoxSoftPublisher.Items.AddRange(new object[] {
            "Undefined"});
            this.comboBoxSoftPublisher.Location = new System.Drawing.Point(218, 46);
            this.comboBoxSoftPublisher.Name = "comboBoxSoftPublisher";
            this.comboBoxSoftPublisher.Size = new System.Drawing.Size(168, 26);
            this.comboBoxSoftPublisher.TabIndex = 144;
            this.comboBoxSoftPublisher.Tag = "Publisher";
            this.comboBoxSoftPublisher.Text = "Undefined";
            // 
            // numericUpDownSoftQuantity
            // 
            this.numericUpDownSoftQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSoftQuantity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSoftQuantity.Location = new System.Drawing.Point(39, 261);
            this.numericUpDownSoftQuantity.Name = "numericUpDownSoftQuantity";
            this.numericUpDownSoftQuantity.Size = new System.Drawing.Size(69, 24);
            this.numericUpDownSoftQuantity.TabIndex = 143;
            this.numericUpDownSoftQuantity.Tag = "Quantity";
            this.numericUpDownSoftQuantity.ThousandsSeparator = true;
            this.numericUpDownSoftQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 142;
            this.label2.Text = "Quantity";
            // 
            // dateTimePickerSoftPubDate
            // 
            this.dateTimePickerSoftPubDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerSoftPubDate.Location = new System.Drawing.Point(219, 97);
            this.dateTimePickerSoftPubDate.Name = "dateTimePickerSoftPubDate";
            this.dateTimePickerSoftPubDate.Size = new System.Drawing.Size(167, 24);
            this.dateTimePickerSoftPubDate.TabIndex = 140;
            this.dateTimePickerSoftPubDate.Tag = "Publication Date";
            this.dateTimePickerSoftPubDate.Value = new System.DateTime(2015, 11, 28, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 139;
            this.label3.Text = "Publication Date";
            // 
            // numericUpDownSoftPrice
            // 
            this.numericUpDownSoftPrice.DecimalPlaces = 2;
            this.numericUpDownSoftPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSoftPrice.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSoftPrice.Location = new System.Drawing.Point(37, 208);
            this.numericUpDownSoftPrice.Name = "numericUpDownSoftPrice";
            this.numericUpDownSoftPrice.Size = new System.Drawing.Size(70, 24);
            this.numericUpDownSoftPrice.TabIndex = 141;
            this.numericUpDownSoftPrice.Tag = "Price";
            this.numericUpDownSoftPrice.ThousandsSeparator = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 15);
            this.label4.TabIndex = 138;
            this.label4.Text = "Price";
            // 
            // textBoxSoftName
            // 
            this.textBoxSoftName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoftName.Location = new System.Drawing.Point(37, 98);
            this.textBoxSoftName.Name = "textBoxSoftName";
            this.textBoxSoftName.Size = new System.Drawing.Size(137, 24);
            this.textBoxSoftName.TabIndex = 137;
            this.textBoxSoftName.Tag = "Product Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 15);
            this.label5.TabIndex = 136;
            this.label5.Text = "Product Name";
            // 
            // comboBoxSoftType
            // 
            this.comboBoxSoftType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxSoftType.FormattingEnabled = true;
            this.comboBoxSoftType.Items.AddRange(new object[] {
            "Undefined"});
            this.comboBoxSoftType.Location = new System.Drawing.Point(37, 151);
            this.comboBoxSoftType.Name = "comboBoxSoftType";
            this.comboBoxSoftType.Size = new System.Drawing.Size(137, 26);
            this.comboBoxSoftType.TabIndex = 146;
            this.comboBoxSoftType.Tag = "Software Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 15);
            this.label6.TabIndex = 147;
            this.label6.Text = "Software Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 148;
            this.label1.Text = "Publisher";
            // 
            // textBoxSoftId
            // 
            this.textBoxSoftId.Enabled = false;
            this.textBoxSoftId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSoftId.Location = new System.Drawing.Point(36, 50);
            this.textBoxSoftId.Name = "textBoxSoftId";
            this.textBoxSoftId.ReadOnly = true;
            this.textBoxSoftId.Size = new System.Drawing.Size(67, 24);
            this.textBoxSoftId.TabIndex = 150;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(34, 34);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(70, 15);
            this.label27.TabIndex = 149;
            this.label27.Text = "Software ID";
            // 
            // FrmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.ControlBox = false;
            this.Controls.Add(this.labelInfoCreation);
            this.Controls.Add(this.tabControlProduct);
            this.Name = "FrmAddProduct";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.FrmAddProduct_Load);
            this.tabControlProduct.ResumeLayout(false);
            this.tabPageBook.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBookPrice)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBoxProductInfo.ResumeLayout(false);
            this.groupBoxProductInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoftQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSoftPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProduct;
        private System.Windows.Forms.TabPage tabPageBook;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Button buttonClearBookField;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxBookGenre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxIsbn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox comboBoxBookCDIncluded;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown numericUpDownBookQuantity;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.DateTimePicker dateTimePickerBookPubDate;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.NumericUpDown numericUpDownBookPrice;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox textBoxBookProductName;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBoxProductInfo;
        private System.Windows.Forms.Button buttonSoftwareReturn;
        private System.Windows.Forms.Button buttonAddSoftware;
        private System.Windows.Forms.Button buttonClearSoftwareField;
        private System.Windows.Forms.ComboBox comboBoxBookAuthor;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxBookPublisher;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label labelInfoCreation;
        private System.Windows.Forms.ComboBox comboBoxSoftPublisher;
        private System.Windows.Forms.NumericUpDown numericUpDownSoftQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerSoftPubDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownSoftPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxSoftName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxSoftType;
        private System.Windows.Forms.TextBox textBoxSoftId;
        private System.Windows.Forms.Label label27;



    }
}