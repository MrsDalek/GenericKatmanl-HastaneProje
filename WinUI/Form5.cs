using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinUI
{
    public partial class Form5 : Form
    {
        public static Form5 instance;
        public string title;

        public Form5()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            if (title == "Doktor" || title == "Blm.bsk.Doktor")
            {
                btn_PatientTransactions.Enabled = false;
                btn_PersonelTransactions.Enabled = false;
                btn_PatientHistoryViewing.Enabled = true;

            }
            else if (title == "Yonetici")
            {
                btn_PatientTransactions.Enabled = true;
                btn_PersonelTransactions.Enabled = true;
                btn_PatientHistoryViewing.Enabled = true;
            }
            else if (title == "Sekreter")
            {
                btn_PatientTransactions.Enabled = true;
                btn_PersonelTransactions.Enabled = false;
                btn_PatientHistoryViewing.Enabled = false;
            }

        }

        private void btn_PatientTransactions_Click(object sender, EventArgs e)
        {
                Form2 frm2 = new Form2();
                frm2.Show();
        }

        private void btn_PersonelTransactions_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            frm1.Show();
        }

        private void btn_PatientHistoryViewing_Click(object sender, EventArgs e)
        {
            Form4 frm4 = new Form4();
            frm4.Show();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Form5.instance.Close();
            Form6.instance.variable = false;

        }
    }
}
