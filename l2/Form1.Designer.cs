namespace l2
{
    partial class Form1
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
            this.groupBoxClient = new System.Windows.Forms.GroupBox();
            this.materialButtonAddNewClient = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxAddress = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBoxName = new MaterialSkin.Controls.MaterialTextBox();
            this.groupBoxCreditCard = new System.Windows.Forms.GroupBox();
            this.materialTextBoxInputCreditCard = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.groupBoxAdministrator = new System.Windows.Forms.GroupBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonBlockCard = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBox1 = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.materialButtonUpdateClient = new MaterialSkin.Controls.MaterialButton();
            this.materialLabelClientName = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox3 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBoxClientBankAccountList = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.materialComboBoxClients = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButtonClientBlockCard = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxCount = new MaterialSkin.Controls.MaterialTextBox();
            this.materialButtonMakePayment = new MaterialSkin.Controls.MaterialButton();
            this.materialComboBoxListAllBankAccount = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialTextBox4 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialTextBox5 = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialComboBox2 = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialTextBoxBancAccount = new MaterialSkin.Controls.MaterialTextBox();
            this.materialComboBoxClientListCards = new MaterialSkin.Controls.MaterialComboBox();
            this.groupBoxClient.SuspendLayout();
            this.groupBoxCreditCard.SuspendLayout();
            this.groupBoxAdministrator.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxClient
            // 
            this.groupBoxClient.Controls.Add(this.materialButtonAddNewClient);
            this.groupBoxClient.Controls.Add(this.materialTextBoxAddress);
            this.groupBoxClient.Controls.Add(this.materialTextBoxName);
            this.groupBoxClient.Location = new System.Drawing.Point(23, 74);
            this.groupBoxClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxClient.Name = "groupBoxClient";
            this.groupBoxClient.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBoxClient.Size = new System.Drawing.Size(259, 337);
            this.groupBoxClient.TabIndex = 2;
            this.groupBoxClient.TabStop = false;
            this.groupBoxClient.Text = "Client";
            // 
            // materialButtonAddNewClient
            // 
            this.materialButtonAddNewClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonAddNewClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonAddNewClient.Depth = 0;
            this.materialButtonAddNewClient.HighEmphasis = true;
            this.materialButtonAddNewClient.Icon = null;
            this.materialButtonAddNewClient.Location = new System.Drawing.Point(43, 292);
            this.materialButtonAddNewClient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButtonAddNewClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonAddNewClient.Name = "materialButtonAddNewClient";
            this.materialButtonAddNewClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonAddNewClient.Size = new System.Drawing.Size(211, 36);
            this.materialButtonAddNewClient.TabIndex = 3;
            this.materialButtonAddNewClient.Text = "Додати нового кліента";
            this.materialButtonAddNewClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonAddNewClient.UseAccentColor = false;
            this.materialButtonAddNewClient.UseVisualStyleBackColor = true;
            this.materialButtonAddNewClient.Click += new System.EventHandler(this.materialButtonAddNewClient_Click);
            // 
            // materialTextBoxAddress
            // 
            this.materialTextBoxAddress.AnimateReadOnly = false;
            this.materialTextBoxAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxAddress.Depth = 0;
            this.materialTextBoxAddress.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxAddress.Hint = "Адреса";
            this.materialTextBoxAddress.LeadingIcon = null;
            this.materialTextBoxAddress.Location = new System.Drawing.Point(21, 118);
            this.materialTextBoxAddress.MaxLength = 50;
            this.materialTextBoxAddress.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxAddress.Multiline = false;
            this.materialTextBoxAddress.Name = "materialTextBoxAddress";
            this.materialTextBoxAddress.Size = new System.Drawing.Size(162, 50);
            this.materialTextBoxAddress.TabIndex = 2;
            this.materialTextBoxAddress.Text = "";
            this.materialTextBoxAddress.TrailingIcon = null;
            // 
            // materialTextBoxName
            // 
            this.materialTextBoxName.AnimateReadOnly = false;
            this.materialTextBoxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxName.Depth = 0;
            this.materialTextBoxName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxName.Hint = "ПІБ.";
            this.materialTextBoxName.LeadingIcon = null;
            this.materialTextBoxName.Location = new System.Drawing.Point(21, 62);
            this.materialTextBoxName.MaxLength = 50;
            this.materialTextBoxName.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxName.Multiline = false;
            this.materialTextBoxName.Name = "materialTextBoxName";
            this.materialTextBoxName.Size = new System.Drawing.Size(162, 50);
            this.materialTextBoxName.TabIndex = 0;
            this.materialTextBoxName.Text = "";
            this.materialTextBoxName.TrailingIcon = null;
            // 
            // groupBoxCreditCard
            // 
            this.groupBoxCreditCard.Controls.Add(this.materialButton1);
            this.groupBoxCreditCard.Controls.Add(this.materialTextBoxInputCreditCard);
            this.groupBoxCreditCard.Location = new System.Drawing.Point(287, 74);
            this.groupBoxCreditCard.Name = "groupBoxCreditCard";
            this.groupBoxCreditCard.Size = new System.Drawing.Size(294, 337);
            this.groupBoxCreditCard.TabIndex = 3;
            this.groupBoxCreditCard.TabStop = false;
            this.groupBoxCreditCard.Text = "CreditCard";
            // 
            // materialTextBoxInputCreditCard
            // 
            this.materialTextBoxInputCreditCard.AnimateReadOnly = false;
            this.materialTextBoxInputCreditCard.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxInputCreditCard.Depth = 0;
            this.materialTextBoxInputCreditCard.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxInputCreditCard.Hint = "Номер карти";
            this.materialTextBoxInputCreditCard.LeadingIcon = null;
            this.materialTextBoxInputCreditCard.Location = new System.Drawing.Point(12, 62);
            this.materialTextBoxInputCreditCard.MaxLength = 50;
            this.materialTextBoxInputCreditCard.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxInputCreditCard.Multiline = false;
            this.materialTextBoxInputCreditCard.Name = "materialTextBoxInputCreditCard";
            this.materialTextBoxInputCreditCard.Size = new System.Drawing.Size(261, 50);
            this.materialTextBoxInputCreditCard.TabIndex = 0;
            this.materialTextBoxInputCreditCard.Text = "";
            this.materialTextBoxInputCreditCard.TrailingIcon = null;
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(30, 292);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(258, 36);
            this.materialButton1.TabIndex = 1;
            this.materialButton1.Text = "Додати нову крудитку карту";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // groupBoxAdministrator
            // 
            this.groupBoxAdministrator.Controls.Add(this.materialComboBox1);
            this.groupBoxAdministrator.Controls.Add(this.materialButtonBlockCard);
            this.groupBoxAdministrator.Controls.Add(this.materialLabel1);
            this.groupBoxAdministrator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBoxAdministrator.Location = new System.Drawing.Point(287, 426);
            this.groupBoxAdministrator.Name = "groupBoxAdministrator";
            this.groupBoxAdministrator.Size = new System.Drawing.Size(294, 468);
            this.groupBoxAdministrator.TabIndex = 4;
            this.groupBoxAdministrator.TabStop = false;
            this.groupBoxAdministrator.Text = "Administrator";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(9, 41);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(46, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Карта";
            // 
            // materialButtonBlockCard
            // 
            this.materialButtonBlockCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonBlockCard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonBlockCard.Depth = 0;
            this.materialButtonBlockCard.HighEmphasis = true;
            this.materialButtonBlockCard.Icon = null;
            this.materialButtonBlockCard.Location = new System.Drawing.Point(109, 425);
            this.materialButtonBlockCard.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButtonBlockCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonBlockCard.Name = "materialButtonBlockCard";
            this.materialButtonBlockCard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonBlockCard.Size = new System.Drawing.Size(178, 36);
            this.materialButtonBlockCard.TabIndex = 4;
            this.materialButtonBlockCard.Text = "Заблокувати карту";
            this.materialButtonBlockCard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonBlockCard.UseAccentColor = false;
            this.materialButtonBlockCard.UseVisualStyleBackColor = true;
            // 
            // materialComboBox1
            // 
            this.materialComboBox1.AutoResize = false;
            this.materialComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox1.Depth = 0;
            this.materialComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox1.DropDownHeight = 174;
            this.materialComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox1.DropDownWidth = 121;
            this.materialComboBox1.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox1.FormattingEnabled = true;
            this.materialComboBox1.IntegralHeight = false;
            this.materialComboBox1.ItemHeight = 43;
            this.materialComboBox1.Location = new System.Drawing.Point(6, 63);
            this.materialComboBox1.MaxDropDownItems = 4;
            this.materialComboBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox1.Name = "materialComboBox1";
            this.materialComboBox1.Size = new System.Drawing.Size(282, 49);
            this.materialComboBox1.StartIndex = 0;
            this.materialComboBox1.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.materialComboBox2);
            this.groupBox1.Controls.Add(this.materialLabel3);
            this.groupBox1.Controls.Add(this.materialComboBoxClientBankAccountList);
            this.groupBox1.Controls.Add(this.materialLabel2);
            this.groupBox1.Controls.Add(this.materialComboBoxClientListCards);
            this.groupBox1.Controls.Add(this.materialTextBox3);
            this.groupBox1.Controls.Add(this.materialLabelClientName);
            this.groupBox1.Controls.Add(this.materialButtonUpdateClient);
            this.groupBox1.Location = new System.Drawing.Point(23, 426);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(259, 468);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client";
            // 
            // materialButtonUpdateClient
            // 
            this.materialButtonUpdateClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonUpdateClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonUpdateClient.Depth = 0;
            this.materialButtonUpdateClient.HighEmphasis = true;
            this.materialButtonUpdateClient.Icon = null;
            this.materialButtonUpdateClient.Location = new System.Drawing.Point(123, 425);
            this.materialButtonUpdateClient.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButtonUpdateClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonUpdateClient.Name = "materialButtonUpdateClient";
            this.materialButtonUpdateClient.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonUpdateClient.Size = new System.Drawing.Size(131, 36);
            this.materialButtonUpdateClient.TabIndex = 3;
            this.materialButtonUpdateClient.Text = "Оновити дані";
            this.materialButtonUpdateClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonUpdateClient.UseAccentColor = false;
            this.materialButtonUpdateClient.UseVisualStyleBackColor = true;
            this.materialButtonUpdateClient.Click += new System.EventHandler(this.materialButtonUpdateClient_Click);
            // 
            // materialLabelClientName
            // 
            this.materialLabelClientName.AutoSize = true;
            this.materialLabelClientName.Depth = 0;
            this.materialLabelClientName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabelClientName.Location = new System.Drawing.Point(21, 40);
            this.materialLabelClientName.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabelClientName.Name = "materialLabelClientName";
            this.materialLabelClientName.Size = new System.Drawing.Size(53, 19);
            this.materialLabelClientName.TabIndex = 4;
            this.materialLabelClientName.Text = "Кліент:";
            // 
            // materialTextBox3
            // 
            this.materialTextBox3.AnimateReadOnly = false;
            this.materialTextBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox3.Depth = 0;
            this.materialTextBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox3.Hint = "Адреса";
            this.materialTextBox3.LeadingIcon = null;
            this.materialTextBox3.Location = new System.Drawing.Point(24, 131);
            this.materialTextBox3.MaxLength = 50;
            this.materialTextBox3.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox3.Multiline = false;
            this.materialTextBox3.Name = "materialTextBox3";
            this.materialTextBox3.Size = new System.Drawing.Size(162, 50);
            this.materialTextBox3.TabIndex = 4;
            this.materialTextBox3.Text = "";
            this.materialTextBox3.TrailingIcon = null;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(24, 198);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Карта";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(24, 282);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(63, 19);
            this.materialLabel3.TabIndex = 8;
            this.materialLabel3.Text = "Рахунок";
            // 
            // materialComboBoxClientBankAccountList
            // 
            this.materialComboBoxClientBankAccountList.AutoResize = false;
            this.materialComboBoxClientBankAccountList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxClientBankAccountList.Depth = 0;
            this.materialComboBoxClientBankAccountList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxClientBankAccountList.DropDownHeight = 174;
            this.materialComboBoxClientBankAccountList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxClientBankAccountList.DropDownWidth = 121;
            this.materialComboBoxClientBankAccountList.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxClientBankAccountList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxClientBankAccountList.FormattingEnabled = true;
            this.materialComboBoxClientBankAccountList.IntegralHeight = false;
            this.materialComboBoxClientBankAccountList.ItemHeight = 43;
            this.materialComboBoxClientBankAccountList.Location = new System.Drawing.Point(21, 316);
            this.materialComboBoxClientBankAccountList.MaxDropDownItems = 4;
            this.materialComboBoxClientBankAccountList.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxClientBankAccountList.Name = "materialComboBoxClientBankAccountList";
            this.materialComboBoxClientBankAccountList.Size = new System.Drawing.Size(221, 49);
            this.materialComboBoxClientBankAccountList.StartIndex = 0;
            this.materialComboBoxClientBankAccountList.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.materialButton3);
            this.groupBox2.Controls.Add(this.materialLabel4);
            this.groupBox2.Controls.Add(this.materialComboBoxListAllBankAccount);
            this.groupBox2.Controls.Add(this.materialButtonMakePayment);
            this.groupBox2.Controls.Add(this.materialTextBoxCount);
            this.groupBox2.Controls.Add(this.materialComboBoxClients);
            this.groupBox2.Controls.Add(this.materialLabel6);
            this.groupBox2.Controls.Add(this.materialButtonClientBlockCard);
            this.groupBox2.Location = new System.Drawing.Point(586, 426);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(259, 468);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client";
            // 
            // materialComboBoxClients
            // 
            this.materialComboBoxClients.AutoResize = false;
            this.materialComboBoxClients.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxClients.Depth = 0;
            this.materialComboBoxClients.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxClients.DropDownHeight = 174;
            this.materialComboBoxClients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxClients.DropDownWidth = 121;
            this.materialComboBoxClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxClients.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxClients.FormattingEnabled = true;
            this.materialComboBoxClients.IntegralHeight = false;
            this.materialComboBoxClients.ItemHeight = 43;
            this.materialComboBoxClients.Location = new System.Drawing.Point(19, 73);
            this.materialComboBoxClients.MaxDropDownItems = 4;
            this.materialComboBoxClients.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxClients.Name = "materialComboBoxClients";
            this.materialComboBoxClients.Size = new System.Drawing.Size(221, 49);
            this.materialComboBoxClients.StartIndex = 0;
            this.materialComboBoxClients.TabIndex = 5;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(21, 40);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(53, 19);
            this.materialLabel6.TabIndex = 4;
            this.materialLabel6.Text = "Кліент:";
            // 
            // materialButtonClientBlockCard
            // 
            this.materialButtonClientBlockCard.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonClientBlockCard.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonClientBlockCard.Depth = 0;
            this.materialButtonClientBlockCard.HighEmphasis = true;
            this.materialButtonClientBlockCard.Icon = null;
            this.materialButtonClientBlockCard.Location = new System.Drawing.Point(21, 145);
            this.materialButtonClientBlockCard.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButtonClientBlockCard.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonClientBlockCard.Name = "materialButtonClientBlockCard";
            this.materialButtonClientBlockCard.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonClientBlockCard.Size = new System.Drawing.Size(178, 36);
            this.materialButtonClientBlockCard.TabIndex = 3;
            this.materialButtonClientBlockCard.Text = "Заблокувати карту";
            this.materialButtonClientBlockCard.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonClientBlockCard.UseAccentColor = false;
            this.materialButtonClientBlockCard.UseVisualStyleBackColor = true;
            // 
            // materialTextBoxCount
            // 
            this.materialTextBoxCount.AnimateReadOnly = false;
            this.materialTextBoxCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxCount.Depth = 0;
            this.materialTextBoxCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxCount.Hint = "Сума";
            this.materialTextBoxCount.LeadingIcon = null;
            this.materialTextBoxCount.Location = new System.Drawing.Point(21, 271);
            this.materialTextBoxCount.MaxLength = 50;
            this.materialTextBoxCount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxCount.Multiline = false;
            this.materialTextBoxCount.Name = "materialTextBoxCount";
            this.materialTextBoxCount.Size = new System.Drawing.Size(162, 50);
            this.materialTextBoxCount.TabIndex = 9;
            this.materialTextBoxCount.Text = "";
            this.materialTextBoxCount.TrailingIcon = null;
            // 
            // materialButtonMakePayment
            // 
            this.materialButtonMakePayment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButtonMakePayment.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButtonMakePayment.Depth = 0;
            this.materialButtonMakePayment.HighEmphasis = true;
            this.materialButtonMakePayment.Icon = null;
            this.materialButtonMakePayment.Location = new System.Drawing.Point(19, 329);
            this.materialButtonMakePayment.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButtonMakePayment.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButtonMakePayment.Name = "materialButtonMakePayment";
            this.materialButtonMakePayment.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButtonMakePayment.Size = new System.Drawing.Size(169, 36);
            this.materialButtonMakePayment.TabIndex = 10;
            this.materialButtonMakePayment.Text = "Зробити операцію";
            this.materialButtonMakePayment.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButtonMakePayment.UseAccentColor = false;
            this.materialButtonMakePayment.UseVisualStyleBackColor = true;
            // 
            // materialComboBoxListAllBankAccount
            // 
            this.materialComboBoxListAllBankAccount.AutoResize = false;
            this.materialComboBoxListAllBankAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxListAllBankAccount.Depth = 0;
            this.materialComboBoxListAllBankAccount.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxListAllBankAccount.DropDownHeight = 174;
            this.materialComboBoxListAllBankAccount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxListAllBankAccount.DropDownWidth = 121;
            this.materialComboBoxListAllBankAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxListAllBankAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxListAllBankAccount.FormattingEnabled = true;
            this.materialComboBoxListAllBankAccount.IntegralHeight = false;
            this.materialComboBoxListAllBankAccount.ItemHeight = 43;
            this.materialComboBoxListAllBankAccount.Location = new System.Drawing.Point(21, 216);
            this.materialComboBoxListAllBankAccount.MaxDropDownItems = 4;
            this.materialComboBoxListAllBankAccount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxListAllBankAccount.Name = "materialComboBoxListAllBankAccount";
            this.materialComboBoxListAllBankAccount.Size = new System.Drawing.Size(221, 49);
            this.materialComboBoxListAllBankAccount.StartIndex = 0;
            this.materialComboBoxListAllBankAccount.TabIndex = 11;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(21, 194);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(67, 19);
            this.materialLabel4.TabIndex = 12;
            this.materialLabel4.Text = "Рахунок:";
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(19, 375);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(185, 36);
            this.materialButton3.TabIndex = 14;
            this.materialButton3.Text = "Анулювати рахунок";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(1001, 81);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 6;
            this.materialLabel5.Text = "Кошти";
            // 
            // materialTextBox4
            // 
            this.materialTextBox4.AnimateReadOnly = false;
            this.materialTextBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox4.Depth = 0;
            this.materialTextBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox4.LeadingIcon = null;
            this.materialTextBox4.Location = new System.Drawing.Point(1004, 103);
            this.materialTextBox4.MaxLength = 50;
            this.materialTextBox4.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox4.Multiline = false;
            this.materialTextBox4.Name = "materialTextBox4";
            this.materialTextBox4.ReadOnly = true;
            this.materialTextBox4.Size = new System.Drawing.Size(162, 50);
            this.materialTextBox4.TabIndex = 9;
            this.materialTextBox4.Text = "";
            this.materialTextBox4.TrailingIcon = null;
            // 
            // materialTextBox5
            // 
            this.materialTextBox5.AnimateReadOnly = false;
            this.materialTextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox5.Depth = 0;
            this.materialTextBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox5.LeadingIcon = null;
            this.materialTextBox5.Location = new System.Drawing.Point(1004, 192);
            this.materialTextBox5.MaxLength = 50;
            this.materialTextBox5.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox5.Multiline = false;
            this.materialTextBox5.Name = "materialTextBox5";
            this.materialTextBox5.ReadOnly = true;
            this.materialTextBox5.Size = new System.Drawing.Size(162, 50);
            this.materialTextBox5.TabIndex = 11;
            this.materialTextBox5.Text = "";
            this.materialTextBox5.TrailingIcon = null;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(1001, 167);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(179, 19);
            this.materialLabel7.TabIndex = 10;
            this.materialLabel7.Text = "Сума кредитних коштів";
            // 
            // materialComboBox2
            // 
            this.materialComboBox2.AutoResize = false;
            this.materialComboBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBox2.Depth = 0;
            this.materialComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBox2.DropDownHeight = 174;
            this.materialComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBox2.DropDownWidth = 121;
            this.materialComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBox2.FormattingEnabled = true;
            this.materialComboBox2.IntegralHeight = false;
            this.materialComboBox2.ItemHeight = 43;
            this.materialComboBox2.Location = new System.Drawing.Point(21, 73);
            this.materialComboBox2.MaxDropDownItems = 4;
            this.materialComboBox2.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBox2.Name = "materialComboBox2";
            this.materialComboBox2.Size = new System.Drawing.Size(221, 49);
            this.materialComboBox2.StartIndex = 0;
            this.materialComboBox2.TabIndex = 15;
            this.materialComboBox2.SelectedIndexChanged += new System.EventHandler(this.materialComboBox2_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.materialButton2);
            this.groupBox3.Controls.Add(this.materialTextBoxBancAccount);
            this.groupBox3.Location = new System.Drawing.Point(587, 74);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 337);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BankAccont";
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(78, 292);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(209, 36);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "Додати новий рахунок";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialTextBoxBancAccount
            // 
            this.materialTextBoxBancAccount.AnimateReadOnly = false;
            this.materialTextBoxBancAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBoxBancAccount.Depth = 0;
            this.materialTextBoxBancAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBoxBancAccount.Hint = "Номер рахунку";
            this.materialTextBoxBancAccount.LeadingIcon = null;
            this.materialTextBoxBancAccount.Location = new System.Drawing.Point(18, 62);
            this.materialTextBoxBancAccount.MaxLength = 50;
            this.materialTextBoxBancAccount.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBoxBancAccount.Multiline = false;
            this.materialTextBoxBancAccount.Name = "materialTextBoxBancAccount";
            this.materialTextBoxBancAccount.Size = new System.Drawing.Size(261, 50);
            this.materialTextBoxBancAccount.TabIndex = 0;
            this.materialTextBoxBancAccount.Text = "";
            this.materialTextBoxBancAccount.TrailingIcon = null;
            // 
            // materialComboBoxClientListCards
            // 
            this.materialComboBoxClientListCards.AutoResize = false;
            this.materialComboBoxClientListCards.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialComboBoxClientListCards.Depth = 0;
            this.materialComboBoxClientListCards.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.materialComboBoxClientListCards.DropDownHeight = 174;
            this.materialComboBoxClientListCards.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.materialComboBoxClientListCards.DropDownWidth = 121;
            this.materialComboBoxClientListCards.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialComboBoxClientListCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialComboBoxClientListCards.FormattingEnabled = true;
            this.materialComboBoxClientListCards.IntegralHeight = false;
            this.materialComboBoxClientListCards.ItemHeight = 43;
            this.materialComboBoxClientListCards.Location = new System.Drawing.Point(24, 230);
            this.materialComboBoxClientListCards.MaxDropDownItems = 4;
            this.materialComboBoxClientListCards.MouseState = MaterialSkin.MouseState.OUT;
            this.materialComboBoxClientListCards.Name = "materialComboBoxClientListCards";
            this.materialComboBoxClientListCards.Size = new System.Drawing.Size(221, 49);
            this.materialComboBoxClientListCards.StartIndex = 0;
            this.materialComboBoxClientListCards.TabIndex = 5;
            this.materialComboBoxClientListCards.SelectedIndexChanged += new System.EventHandler(this.materialComboBoxClientListCards_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1203, 915);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.materialTextBox5);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialTextBox4);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxAdministrator);
            this.Controls.Add(this.groupBoxCreditCard);
            this.Controls.Add(this.groupBoxClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(2, 42, 2, 2);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxClient.ResumeLayout(false);
            this.groupBoxClient.PerformLayout();
            this.groupBoxCreditCard.ResumeLayout(false);
            this.groupBoxCreditCard.PerformLayout();
            this.groupBoxAdministrator.ResumeLayout(false);
            this.groupBoxAdministrator.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBoxClient;
        private MaterialSkin.Controls.MaterialButton materialButtonAddNewClient;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxAddress;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxName;
        private System.Windows.Forms.GroupBox groupBoxCreditCard;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxInputCreditCard;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.GroupBox groupBoxAdministrator;
        private MaterialSkin.Controls.MaterialButton materialButtonBlockCard;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private MaterialSkin.Controls.MaterialLabel materialLabelClientName;
        private MaterialSkin.Controls.MaterialButton materialButtonUpdateClient;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxClientBankAccountList;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxClients;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialButton materialButtonClientBlockCard;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxCount;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxListAllBankAccount;
        private MaterialSkin.Controls.MaterialButton materialButtonMakePayment;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox4;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialComboBox materialComboBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialTextBox materialTextBoxBancAccount;
        private MaterialSkin.Controls.MaterialComboBox materialComboBoxClientListCards;
    }
}

