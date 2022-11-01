
namespace WinUI
{
    partial class Form3
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
            this.btn_MakeAppointment = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_SelectTime = new System.Windows.Forms.Button();
            this.monthCalendar_AppointmentDate = new System.Windows.Forms.MonthCalendar();
            this.comboBox_Doctor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_MedicalUnit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_HospitalName = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_City = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Region = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_MakeAppointment
            // 
            this.btn_MakeAppointment.Location = new System.Drawing.Point(526, 366);
            this.btn_MakeAppointment.Name = "btn_MakeAppointment";
            this.btn_MakeAppointment.Size = new System.Drawing.Size(75, 56);
            this.btn_MakeAppointment.TabIndex = 27;
            this.btn_MakeAppointment.Text = "Randevu Al";
            this.btn_MakeAppointment.UseVisualStyleBackColor = true;
            this.btn_MakeAppointment.Click += new System.EventHandler(this.btn_MakeAppointment_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(19, 220);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(464, 202);
            this.dataGridView1.TabIndex = 26;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btn_SelectTime
            // 
            this.btn_SelectTime.Location = new System.Drawing.Point(526, 220);
            this.btn_SelectTime.Name = "btn_SelectTime";
            this.btn_SelectTime.Size = new System.Drawing.Size(75, 56);
            this.btn_SelectTime.TabIndex = 25;
            this.btn_SelectTime.Text = "Saat Seç";
            this.btn_SelectTime.UseVisualStyleBackColor = true;
            this.btn_SelectTime.Click += new System.EventHandler(this.btn_SelectTime_Click);
            // 
            // monthCalendar_AppointmentDate
            // 
            this.monthCalendar_AppointmentDate.Location = new System.Drawing.Point(249, 8);
            this.monthCalendar_AppointmentDate.Name = "monthCalendar_AppointmentDate";
            this.monthCalendar_AppointmentDate.TabIndex = 24;
            this.monthCalendar_AppointmentDate.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_AppointmentDate_DateChanged);
            // 
            // comboBox_Doctor
            // 
            this.comboBox_Doctor.FormattingEnabled = true;
            this.comboBox_Doctor.Location = new System.Drawing.Point(116, 181);
            this.comboBox_Doctor.Name = "comboBox_Doctor";
            this.comboBox_Doctor.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Doctor.TabIndex = 23;
            this.comboBox_Doctor.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Doctor_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Doktor Seçiniz";
            // 
            // comboBox_MedicalUnit
            // 
            this.comboBox_MedicalUnit.FormattingEnabled = true;
            this.comboBox_MedicalUnit.Location = new System.Drawing.Point(116, 139);
            this.comboBox_MedicalUnit.Name = "comboBox_MedicalUnit";
            this.comboBox_MedicalUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBox_MedicalUnit.TabIndex = 21;
            this.comboBox_MedicalUnit.SelectionChangeCommitted += new System.EventHandler(this.comboBox_MedicalUnit_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tıbbi Birim Seçiniz";
            // 
            // comboBox_HospitalName
            // 
            this.comboBox_HospitalName.FormattingEnabled = true;
            this.comboBox_HospitalName.Location = new System.Drawing.Point(116, 98);
            this.comboBox_HospitalName.Name = "comboBox_HospitalName";
            this.comboBox_HospitalName.Size = new System.Drawing.Size(121, 21);
            this.comboBox_HospitalName.TabIndex = 19;
            this.comboBox_HospitalName.SelectionChangeCommitted += new System.EventHandler(this.comboBox_HospitalName_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Hastane Seçiniz";
            // 
            // comboBox_City
            // 
            this.comboBox_City.FormattingEnabled = true;
            this.comboBox_City.Location = new System.Drawing.Point(116, 51);
            this.comboBox_City.Name = "comboBox_City";
            this.comboBox_City.Size = new System.Drawing.Size(121, 21);
            this.comboBox_City.TabIndex = 17;
            this.comboBox_City.SelectionChangeCommitted += new System.EventHandler(this.comboBox_City_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Şehir Seçiniz";
            // 
            // comboBox_Region
            // 
            this.comboBox_Region.FormattingEnabled = true;
            this.comboBox_Region.Location = new System.Drawing.Point(116, 8);
            this.comboBox_Region.Name = "comboBox_Region";
            this.comboBox_Region.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Region.TabIndex = 15;
            this.comboBox_Region.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Region_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Bölge Seçiniz";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_MakeAppointment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_SelectTime);
            this.Controls.Add(this.monthCalendar_AppointmentDate);
            this.Controls.Add(this.comboBox_Doctor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox_MedicalUnit);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_HospitalName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_City);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox_Region);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_MakeAppointment;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_SelectTime;
        private System.Windows.Forms.MonthCalendar monthCalendar_AppointmentDate;
        private System.Windows.Forms.ComboBox comboBox_Doctor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_MedicalUnit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_HospitalName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_City;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Region;
        private System.Windows.Forms.Label label1;
    }
}