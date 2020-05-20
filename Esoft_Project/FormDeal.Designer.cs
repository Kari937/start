namespace Esoft_Project
{
    partial class FormDeal
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDel = new System.Windows.Forms.Button();
            this.comboBoxSupply = new System.Windows.Forms.ComboBox();
            this.comboBoxDemand = new System.Windows.Forms.ComboBox();
            this.textBoxSellerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentSellerDeductions = new System.Windows.Forms.TextBox();
            this.textCustomerCompanyDeductions = new System.Windows.Forms.TextBox();
            this.textBoxAgentCustomerDeductions = new System.Windows.Forms.TextBox();
            this.labelSupply = new System.Windows.Forms.Label();
            this.labelDemand = new System.Windows.Forms.Label();
            this.labelSellerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentSellerDeductions = new System.Windows.Forms.Label();
            this.labelCustomerCompanyDeductions = new System.Windows.Forms.Label();
            this.labelAgentCustomerDeductions = new System.Windows.Forms.Label();
            this.listViewDealSet = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonAdd.Location = new System.Drawing.Point(377, 258);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(100, 45);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Создать";
            this.ButtonAdd.UseVisualStyleBackColor = false;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonEdit.Location = new System.Drawing.Point(483, 258);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(100, 45);
            this.ButtonEdit.TabIndex = 1;
            this.ButtonEdit.Text = "Изменить";
            this.ButtonEdit.UseVisualStyleBackColor = false;
            this.ButtonEdit.Click += new System.EventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDel
            // 
            this.ButtonDel.BackColor = System.Drawing.Color.DodgerBlue;
            this.ButtonDel.Location = new System.Drawing.Point(589, 258);
            this.ButtonDel.Name = "ButtonDel";
            this.ButtonDel.Size = new System.Drawing.Size(100, 45);
            this.ButtonDel.TabIndex = 2;
            this.ButtonDel.Text = "Удалить";
            this.ButtonDel.UseVisualStyleBackColor = false;
            this.ButtonDel.Click += new System.EventHandler(this.ButtonDel_Click);
            // 
            // comboBoxSupply
            // 
            this.comboBoxSupply.FormattingEnabled = true;
            this.comboBoxSupply.Location = new System.Drawing.Point(4, 38);
            this.comboBoxSupply.Name = "comboBoxSupply";
            this.comboBoxSupply.Size = new System.Drawing.Size(211, 21);
            this.comboBoxSupply.TabIndex = 3;
            this.comboBoxSupply.SelectedIndexChanged += new System.EventHandler(this.comboBoxSupply_SelectedIndexChanged);
            // 
            // comboBoxDemand
            // 
            this.comboBoxDemand.FormattingEnabled = true;
            this.comboBoxDemand.Location = new System.Drawing.Point(4, 78);
            this.comboBoxDemand.Name = "comboBoxDemand";
            this.comboBoxDemand.Size = new System.Drawing.Size(211, 21);
            this.comboBoxDemand.TabIndex = 4;
            this.comboBoxDemand.SelectedIndexChanged += new System.EventHandler(this.comboBoxDemand_SelectedIndexChanged);
            // 
            // textBoxSellerCompanyDeductions
            // 
            this.textBoxSellerCompanyDeductions.Location = new System.Drawing.Point(4, 118);
            this.textBoxSellerCompanyDeductions.Name = "textBoxSellerCompanyDeductions";
            this.textBoxSellerCompanyDeductions.Size = new System.Drawing.Size(211, 20);
            this.textBoxSellerCompanyDeductions.TabIndex = 5;
            // 
            // textBoxAgentSellerDeductions
            // 
            this.textBoxAgentSellerDeductions.Location = new System.Drawing.Point(4, 157);
            this.textBoxAgentSellerDeductions.Name = "textBoxAgentSellerDeductions";
            this.textBoxAgentSellerDeductions.Size = new System.Drawing.Size(211, 20);
            this.textBoxAgentSellerDeductions.TabIndex = 6;
            // 
            // textCustomerCompanyDeductions
            // 
            this.textCustomerCompanyDeductions.Location = new System.Drawing.Point(4, 196);
            this.textCustomerCompanyDeductions.Name = "textCustomerCompanyDeductions";
            this.textCustomerCompanyDeductions.Size = new System.Drawing.Size(211, 20);
            this.textCustomerCompanyDeductions.TabIndex = 7;
            // 
            // textBoxAgentCustomerDeductions
            // 
            this.textBoxAgentCustomerDeductions.Location = new System.Drawing.Point(4, 235);
            this.textBoxAgentCustomerDeductions.Name = "textBoxAgentCustomerDeductions";
            this.textBoxAgentCustomerDeductions.Size = new System.Drawing.Size(211, 20);
            this.textBoxAgentCustomerDeductions.TabIndex = 8;
            // 
            // labelSupply
            // 
            this.labelSupply.AutoSize = true;
            this.labelSupply.Location = new System.Drawing.Point(1, 22);
            this.labelSupply.Name = "labelSupply";
            this.labelSupply.Size = new System.Drawing.Size(77, 13);
            this.labelSupply.TabIndex = 9;
            this.labelSupply.Text = "Предложение";
            // 
            // labelDemand
            // 
            this.labelDemand.AutoSize = true;
            this.labelDemand.Location = new System.Drawing.Point(1, 62);
            this.labelDemand.Name = "labelDemand";
            this.labelDemand.Size = new System.Drawing.Size(73, 13);
            this.labelDemand.TabIndex = 10;
            this.labelDemand.Text = "Потребность";
            // 
            // labelSellerCompanyDeductions
            // 
            this.labelSellerCompanyDeductions.AutoSize = true;
            this.labelSellerCompanyDeductions.Location = new System.Drawing.Point(1, 102);
            this.labelSellerCompanyDeductions.Name = "labelSellerCompanyDeductions";
            this.labelSellerCompanyDeductions.Size = new System.Drawing.Size(214, 13);
            this.labelSellerCompanyDeductions.TabIndex = 11;
            this.labelSellerCompanyDeductions.Text = "Стоимость услуги для клиента-продавца";
            // 
            // labelAgentSellerDeductions
            // 
            this.labelAgentSellerDeductions.AutoSize = true;
            this.labelAgentSellerDeductions.Location = new System.Drawing.Point(1, 141);
            this.labelAgentSellerDeductions.Name = "labelAgentSellerDeductions";
            this.labelAgentSellerDeductions.Size = new System.Drawing.Size(211, 13);
            this.labelAgentSellerDeductions.TabIndex = 12;
            this.labelAgentSellerDeductions.Text = "Отчисления риелтору клиента-продавца";
            // 
            // labelCustomerCompanyDeductions
            // 
            this.labelCustomerCompanyDeductions.AutoSize = true;
            this.labelCustomerCompanyDeductions.Location = new System.Drawing.Point(1, 180);
            this.labelCustomerCompanyDeductions.Name = "labelCustomerCompanyDeductions";
            this.labelCustomerCompanyDeductions.Size = new System.Drawing.Size(225, 13);
            this.labelCustomerCompanyDeductions.TabIndex = 13;
            this.labelCustomerCompanyDeductions.Text = "Стоимость услиги для клиента-покупателя";
            // 
            // labelAgentCustomerDeductions
            // 
            this.labelAgentCustomerDeductions.AutoSize = true;
            this.labelAgentCustomerDeductions.Location = new System.Drawing.Point(1, 219);
            this.labelAgentCustomerDeductions.Name = "labelAgentCustomerDeductions";
            this.labelAgentCustomerDeductions.Size = new System.Drawing.Size(220, 13);
            this.labelAgentCustomerDeductions.TabIndex = 14;
            this.labelAgentCustomerDeductions.Text = "Отчесления риелтору клиенту-покупателя";
            // 
            // listViewDealSet
            // 
            this.listViewDealSet.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewDealSet.FullRowSelect = true;
            this.listViewDealSet.GridLines = true;
            this.listViewDealSet.HideSelection = false;
            this.listViewDealSet.Location = new System.Drawing.Point(221, 38);
            this.listViewDealSet.MultiSelect = false;
            this.listViewDealSet.Name = "listViewDealSet";
            this.listViewDealSet.Size = new System.Drawing.Size(648, 214);
            this.listViewDealSet.TabIndex = 15;
            this.listViewDealSet.UseCompatibleStateImageBehavior = false;
            this.listViewDealSet.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Клиент-продавец";
            this.columnHeader1.Width = 99;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Риелтор-клиента продавца";
            this.columnHeader2.Width = 135;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Клиент-покупатель";
            this.columnHeader3.Width = 117;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Риелтор клиента-покупателя";
            this.columnHeader4.Width = 85;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Адрес объекта недвижимости";
            this.columnHeader5.Width = 143;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Стоимость";
            this.columnHeader6.Width = 67;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Esoft_Project.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(764, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(105, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // FormDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(876, 335);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.listViewDealSet);
            this.Controls.Add(this.labelAgentCustomerDeductions);
            this.Controls.Add(this.labelCustomerCompanyDeductions);
            this.Controls.Add(this.labelAgentSellerDeductions);
            this.Controls.Add(this.labelSellerCompanyDeductions);
            this.Controls.Add(this.labelDemand);
            this.Controls.Add(this.labelSupply);
            this.Controls.Add(this.textBoxAgentCustomerDeductions);
            this.Controls.Add(this.textCustomerCompanyDeductions);
            this.Controls.Add(this.textBoxAgentSellerDeductions);
            this.Controls.Add(this.textBoxSellerCompanyDeductions);
            this.Controls.Add(this.comboBoxDemand);
            this.Controls.Add(this.comboBoxSupply);
            this.Controls.Add(this.ButtonDel);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ButtonAdd);
            this.Name = "FormDeal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сделки";
            this.Load += new System.EventHandler(this.FormDeal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonEdit;
        private System.Windows.Forms.Button ButtonDel;
        private System.Windows.Forms.ComboBox comboBoxSupply;
        private System.Windows.Forms.ComboBox comboBoxDemand;
        private System.Windows.Forms.TextBox textBoxSellerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxAgentSellerDeductions;
        private System.Windows.Forms.TextBox textCustomerCompanyDeductions;
        private System.Windows.Forms.TextBox textBoxAgentCustomerDeductions;
        private System.Windows.Forms.Label labelSupply;
        private System.Windows.Forms.Label labelDemand;
        private System.Windows.Forms.Label labelSellerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentSellerDeductions;
        private System.Windows.Forms.Label labelCustomerCompanyDeductions;
        private System.Windows.Forms.Label labelAgentCustomerDeductions;
        private System.Windows.Forms.ListView listViewDealSet;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}