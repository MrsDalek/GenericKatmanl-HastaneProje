using DAL;
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
    public partial class Form3 : Form
    {
        HastaneDBEntities hdb = new HastaneDBEntities();
        DataTable dt;
        DataTable dt2 = new DataTable();
        string date;
        string time;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            var region = hdb.Bolges.ToList();
            combo(comboBox_Region, region, "BolgeAdi", "BolgeID");

            monthCalendar_AppointmentDate.Enabled = false;
            btn_SelectTime.Enabled = false;
            btn_MakeAppointment.Enabled = false;

        }

    

        private void comboBox_Region_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var city = hdb.AltBolges.Where(ab => ab.BolgeID == (int)comboBox_Region.SelectedValue).Select(al => new
            {

                al.AltBolgeAdi,
                al.AltBolgeID

            }).ToList();
            combo(comboBox_City, city, "AltBolgeAdi", "AltBolgeID");


        }

        private void comboBox_City_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var hospital = hdb.Hastanelers.Where(h => h.AltBolgeID == (int)comboBox_City.SelectedValue).Select(h => new
            {
                h.HastaneAdi,
                h.HastaneID
            }).ToList();
            combo(comboBox_HospitalName, hospital, "HastaneAdi", "HastaneID");


        }

        private void comboBox_HospitalName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var medicalUnit = hdb.TibbiBirimlers.ToList();
            combo(comboBox_MedicalUnit, medicalUnit, "TibbiAdi", "TBID");

        }

        private void comboBox_MedicalUnit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var doctor = hdb.vw_Doktor.Where(vd => vd.TBID == (int)comboBox_MedicalUnit.SelectedValue).Select(d => new
            {
                d.Doktor,
                d.DoktorID
            }).ToList();

            combo(comboBox_Doctor, doctor, "Doktor", "DoktorID");
        }

        private void comboBox_Doctor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            monthCalendar_AppointmentDate.Enabled = true;
        }

        private void btn_SelectTime_Click(object sender, EventArgs e)
        {
            dt = TimeGet();
            dataGridView1.DataSource = dt;
            dataGridView1.Enabled = true;
            btn_SelectTime.Enabled = false;

        }


        private void monthCalendar_AppointmentDate_DateChanged(object sender, DateRangeEventArgs e)
        {

            if (monthCalendar_AppointmentDate.SelectionRange.Start > DateTime.Now)
            {

                btn_SelectTime.Enabled = true;
                date = monthCalendar_AppointmentDate.SelectionRange.Start.ToShortDateString();

            }
            else
            {
                MessageBox.Show("Bugün tarihinden ileri bir tarih seçiniz.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_MakeAppointment.Enabled = true;
            time = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }

        private void btn_MakeAppointment_Click(object sender, EventArgs e)
        {
            MessageBox.Show(date + " " + time + " tarihinde " + comboBox_MedicalUnit.Text + " bölümünden " + comboBox_HospitalName.Text + " ile randevunuz oluşturulmuştur.");
            btn_SelectTime.Enabled = true;
            ClearAll();
        }

        

        private void combo(ComboBox cbox, object lst, string dmember , string vmember)
        {
            cbox.DataSource = lst;
            cbox.DisplayMember = dmember;
            cbox.ValueMember = vmember;
            cbox.Text = null;
        }
        private DataTable TimeGet()
        {
            dt2.Columns.Add(" ", typeof(string));
            dt2.Columns.Add("  ", typeof(string));
            dt2.Columns.Add("   ", typeof(string));
            dt2.Columns.Add("    ", typeof(string));


            dt2.Rows.Add("09:00", "09:15", "09:30", "09:45");
            dt2.Rows.Add("10:00", "10:15", "10:30", "10:45");
            dt2.Rows.Add("11:00", "11:15", "11:30", "11:45");
            dt2.Rows.Add("12:00", "12:15", "12:30", "12:45");
            dt2.Rows.Add("13:00", "13:15", "13:30", "13:45");
            dt2.Rows.Add("14:00", "14:15", "14:30", "14:45");
            dt2.Rows.Add("15:00", "15:15", "15:30", "15:45");
            dt2.Rows.Add("16:00", "16:15", "16:30", "16:45");

            return dt2;
        }
        private void ClearAll()
        {
            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    ComboBox cbox = (ComboBox)item;
                    cbox.Text = null;
                }
                if (item is MonthCalendar)
                {
                    MonthCalendar mc = (MonthCalendar)item;
                    mc.SelectionRange.Start = DateTime.Now;
                    monthCalendar_AppointmentDate.Enabled = false;
                }
                if (item is DataGridView)
                {
                    DataGridView dgv = (DataGridView)item;
                    dgv.Enabled = false;
                    dgv.DataSource = null;
                    dt2.Columns.Clear();
                    dt2.Rows.Clear();

                }
                if (item is Button)
                {
                    Button btn = (Button)item;
                    btn.Enabled = false;
                }
            }
        }
    }
}
