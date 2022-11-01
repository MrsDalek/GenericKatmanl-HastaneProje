
namespace WinUI
{
    partial class Form4
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_PatientSearch = new System.Windows.Forms.Button();
            this.textBox_Identity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(46, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(634, 313);
            this.dataGridView1.TabIndex = 7;
            // 
            // btn_PatientSearch
            // 
            this.btn_PatientSearch.Location = new System.Drawing.Point(583, 25);
            this.btn_PatientSearch.Name = "btn_PatientSearch";
            this.btn_PatientSearch.Size = new System.Drawing.Size(97, 26);
            this.btn_PatientSearch.TabIndex = 6;
            this.btn_PatientSearch.Text = "Hasta Sorgula";
            this.btn_PatientSearch.UseVisualStyleBackColor = true;
            this.btn_PatientSearch.Click += new System.EventHandler(this.btn_PatientSearch_Click);
            // 
            // textBox_Identity
            // 
            this.textBox_Identity.Location = new System.Drawing.Point(118, 25);
            this.textBox_Identity.Name = "textBox_Identity";
            this.textBox_Identity.Size = new System.Drawing.Size(185, 20);
            this.textBox_Identity.TabIndex = 5;
            this.textBox_Identity.TextChanged += new System.EventHandler(this.textBox_Identity_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "TCKN Giriniz";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_PatientSearch);
            this.Controls.Add(this.textBox_Identity);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_PatientSearch;
        private System.Windows.Forms.TextBox textBox_Identity;
        private System.Windows.Forms.Label label1;
    }
}