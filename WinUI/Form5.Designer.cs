
namespace WinUI
{
    partial class Form5
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
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_PatientHistoryViewing = new System.Windows.Forms.Button();
            this.btn_PersonelTransactions = new System.Windows.Forms.Button();
            this.btn_PatientTransactions = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(445, 76);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(114, 75);
            this.btn_Exit.TabIndex = 7;
            this.btn_Exit.Text = "Çıkış";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_PatientHistoryViewing
            // 
            this.btn_PatientHistoryViewing.Location = new System.Drawing.Point(298, 76);
            this.btn_PatientHistoryViewing.Name = "btn_PatientHistoryViewing";
            this.btn_PatientHistoryViewing.Size = new System.Drawing.Size(114, 75);
            this.btn_PatientHistoryViewing.TabIndex = 6;
            this.btn_PatientHistoryViewing.Text = "Hasta Geçmiş Görüntüleme";
            this.btn_PatientHistoryViewing.UseVisualStyleBackColor = true;
            this.btn_PatientHistoryViewing.Click += new System.EventHandler(this.btn_PatientHistoryViewing_Click);
            // 
            // btn_PersonelTransactions
            // 
            this.btn_PersonelTransactions.Location = new System.Drawing.Point(148, 76);
            this.btn_PersonelTransactions.Name = "btn_PersonelTransactions";
            this.btn_PersonelTransactions.Size = new System.Drawing.Size(114, 75);
            this.btn_PersonelTransactions.TabIndex = 5;
            this.btn_PersonelTransactions.Text = "Personel İşlemler";
            this.btn_PersonelTransactions.UseVisualStyleBackColor = true;
            this.btn_PersonelTransactions.Click += new System.EventHandler(this.btn_PersonelTransactions_Click);
            // 
            // btn_PatientTransactions
            // 
            this.btn_PatientTransactions.Location = new System.Drawing.Point(1, 76);
            this.btn_PatientTransactions.Name = "btn_PatientTransactions";
            this.btn_PatientTransactions.Size = new System.Drawing.Size(114, 75);
            this.btn_PatientTransactions.TabIndex = 4;
            this.btn_PatientTransactions.Text = "Hasta İşlemler";
            this.btn_PatientTransactions.UseVisualStyleBackColor = true;
            this.btn_PatientTransactions.Click += new System.EventHandler(this.btn_PatientTransactions_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_PatientHistoryViewing);
            this.Controls.Add(this.btn_PersonelTransactions);
            this.Controls.Add(this.btn_PatientTransactions);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_PatientHistoryViewing;
        private System.Windows.Forms.Button btn_PersonelTransactions;
        private System.Windows.Forms.Button btn_PatientTransactions;
    }
}