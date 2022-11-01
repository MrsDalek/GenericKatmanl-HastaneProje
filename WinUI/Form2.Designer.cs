
namespace WinUI
{
    partial class Form2
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
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_GetAll = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.richTextBox_Address = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox_Bloodgroup = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Weight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Height = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_Identity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Lastname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(595, 378);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(143, 20);
            this.textBox8.TabIndex = 73;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(623, 404);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 72;
            this.btn_search.Text = "Hasta Ara";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_GetAll
            // 
            this.btn_GetAll.Location = new System.Drawing.Point(595, 349);
            this.btn_GetAll.Name = "btn_GetAll";
            this.btn_GetAll.Size = new System.Drawing.Size(143, 23);
            this.btn_GetAll.TabIndex = 71;
            this.btn_GetAll.Text = "Hasta Listele";
            this.btn_GetAll.UseVisualStyleBackColor = true;
            this.btn_GetAll.Click += new System.EventHandler(this.btn_GetAll_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(595, 320);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(143, 23);
            this.btn_Delete.TabIndex = 70;
            this.btn_Delete.Text = "Hasta Sil";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(595, 287);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(143, 23);
            this.btn_Update.TabIndex = 69;
            this.btn_Update.Text = "Hasta Bilgisi Guncelle";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(595, 258);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(143, 23);
            this.btn_Insert.TabIndex = 68;
            this.btn_Insert.Text = "Hasta Ekle";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // richTextBox_Address
            // 
            this.richTextBox_Address.Location = new System.Drawing.Point(571, 42);
            this.richTextBox_Address.Name = "richTextBox_Address";
            this.richTextBox_Address.Size = new System.Drawing.Size(209, 181);
            this.richTextBox_Address.TabIndex = 67;
            this.richTextBox_Address.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(715, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 66;
            this.label9.Text = "Hasta Adres";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(73, 254);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 150);
            this.dataGridView1.TabIndex = 65;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboBox_Bloodgroup
            // 
            this.comboBox_Bloodgroup.FormattingEnabled = true;
            this.comboBox_Bloodgroup.Items.AddRange(new object[] {
            "0 RH+",
            "0 RH-",
            "A RH+",
            "A RH-",
            "B RH+",
            "B RH-",
            "AB RH+",
            "AB RH-"});
            this.comboBox_Bloodgroup.Location = new System.Drawing.Point(113, 202);
            this.comboBox_Bloodgroup.Name = "comboBox_Bloodgroup";
            this.comboBox_Bloodgroup.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Bloodgroup.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 202);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Kan Grubu";
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(412, 205);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 20);
            this.textBox_Phone.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "Hasta Telefon No";
            // 
            // textBox_Weight
            // 
            this.textBox_Weight.Location = new System.Drawing.Point(412, 145);
            this.textBox_Weight.Name = "textBox_Weight";
            this.textBox_Weight.Size = new System.Drawing.Size(100, 20);
            this.textBox_Weight.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(310, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Hasta Kilo";
            // 
            // textBox_Age
            // 
            this.textBox_Age.Location = new System.Drawing.Point(412, 90);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(100, 20);
            this.textBox_Age.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 57;
            this.label5.Text = "Hasta Yaş";
            // 
            // textBox_Height
            // 
            this.textBox_Height.ImeMode = System.Windows.Forms.ImeMode.On;
            this.textBox_Height.Location = new System.Drawing.Point(412, 47);
            this.textBox_Height.Name = "textBox_Height";
            this.textBox_Height.Size = new System.Drawing.Size(100, 20);
            this.textBox_Height.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 55;
            this.label4.Text = "Hasta Boy";
            // 
            // textBox_Identity
            // 
            this.textBox_Identity.Location = new System.Drawing.Point(113, 145);
            this.textBox_Identity.Name = "textBox_Identity";
            this.textBox_Identity.Size = new System.Drawing.Size(121, 20);
            this.textBox_Identity.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 53;
            this.label3.Text = "Hasta TCKN";
            // 
            // textBox_Lastname
            // 
            this.textBox_Lastname.Location = new System.Drawing.Point(113, 90);
            this.textBox_Lastname.Name = "textBox_Lastname";
            this.textBox_Lastname.Size = new System.Drawing.Size(121, 20);
            this.textBox_Lastname.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Hasta Soyadı";
            // 
            // textBox_Firstname
            // 
            this.textBox_Firstname.Location = new System.Drawing.Point(113, 44);
            this.textBox_Firstname.Name = "textBox_Firstname";
            this.textBox_Firstname.Size = new System.Drawing.Size(121, 20);
            this.textBox_Firstname.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hasta Adı";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_GetAll);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.richTextBox_Address);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Bloodgroup);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Weight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_Age);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Height);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Identity);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Lastname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Firstname);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_GetAll;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.RichTextBox richTextBox_Address;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBox_Bloodgroup;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Weight;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Height;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_Identity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Lastname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Firstname;
        private System.Windows.Forms.Label label1;
    }
}