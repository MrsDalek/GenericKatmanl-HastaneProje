using BLL.Repositories;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        Hasta updated;
        BaseRepository<Hasta> hr = new BaseRepository<Hasta>();

        private void Form2_Load(object sender, EventArgs e)
        {
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
            btn_search.Enabled = false;
        }

        private void btn_GetAll_Click(object sender, EventArgs e)
        {
            GetAllPatient();
            btn_search.Enabled = true;
        }

        private void GetAllPatient()
        {
            dataGridView1.DataSource = hr.GetAll().Where(h => h.durum == true).ToList();
            dataGridView1.Columns["Durum"].Visible = false;
            dataGridView1.Columns["HastaID"].Visible = false;
            dataGridView1.Columns["Muayenes"].Visible = false;
            dataGridView1.Columns["HastaTahlils"].Visible = false;
        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            if (textBox_Firstname.Text != "" && textBox_Lastname.Text != "" && textBox_Identity.Text != "" && textBox_Identity.Text.Length < 11 && textBox_Age.Text != "" && textBox_Phone.Text != "" && textBox_Weight.Text != "" && textBox_Height.Text != "" && comboBox_Bloodgroup.Text != "" && richTextBox_Address.Text != "")
            {
                hr.Insert(new Hasta
                {
                    HastaAdi = textBox_Firstname.Text,
                    HastaSoyAdi = textBox_Lastname.Text,
                    Tc_Passaport = textBox_Identity.Text,
                    HastaKanGrubu = comboBox_Bloodgroup.Text,
                    HastaBoy = textBox_Height.Text,
                    HastaYas = Convert.ToInt32(textBox_Age.Text),
                    HastaKilo = textBox_Weight.Text,
                    HastaAdres = richTextBox_Address.Text,
                    HastaTel = textBox_Phone.Text,
                    durum = true
                });
                MessageBox.Show("Hasta kaydı başarıyla eklendi.");
                GetAllPatient();
                ClearAll();

            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız ve TCKN'yi doğru girdiğinizden emin olunuz.");
            }


        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            if (textBox_Firstname.Text != "" && textBox_Lastname.Text != "" && textBox_Identity.Text != "" && textBox_Identity.Text.Length == 10 && textBox_Age.Text != "" && textBox_Phone.Text != "" && textBox_Weight.Text != "" && textBox_Height.Text != "" && comboBox_Bloodgroup.Text != "" && richTextBox_Address.Text != "")
            {
                updated.HastaAdi = textBox_Firstname.Text;
                updated.HastaSoyAdi = textBox_Lastname.Text;
                updated.Tc_Passaport = textBox_Identity.Text;
                updated.HastaKanGrubu = comboBox_Bloodgroup.Text;
                updated.HastaBoy = textBox_Height.Text;
                updated.HastaYas = Convert.ToInt32(textBox_Age.Text);
                updated.HastaKilo = textBox_Weight.Text;
                updated.HastaAdres = richTextBox_Address.Text;
                updated.HastaTel = textBox_Phone.Text;
                hr.Update(updated);
                MessageBox.Show("Hasta Kaydı başarıyla güncellendi.");
                GetAllPatient();
                ClearAll();

                btn_Insert.Enabled = true;
                btn_Update.Enabled = false;
                btn_Delete.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız ve TCKN'yi doğru girdiğinizden emin olunuz.");
            }

        }
        private void btn_Delete_Click(object sender, EventArgs e)
        {
            updated.durum = false;
            hr.Delete(updated);
            MessageBox.Show("Hasta kaydı başarıyla silindi.");
            GetAllPatient();
            ClearAll();

            btn_Insert.Enabled = true;
            btn_Update.Enabled = false;
            btn_Delete.Enabled = false;
        }
        private void btn_search_Click(object sender, EventArgs e)
        {
         
            try
            {
                dataGridView1.DataSource = hr.GetAll().Where(h => h.durum == true && h.Tc_Passaport == textBox8.Text).ToList();
                dataGridView1.Columns["Durum"].Visible = false;
                dataGridView1.Columns["HastaID"].Visible = false;
                dataGridView1.Columns["Muayenes"].Visible = false;
                dataGridView1.Columns["HastaTahlils"].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı TCKN girdiniz");
            }
            ClearAll();
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                updated = hr.GetById(id);
                textBox_Firstname.Text = updated.HastaAdi;
                textBox_Lastname.Text = updated.HastaSoyAdi;
                textBox_Identity.Text = updated.Tc_Passaport;
                comboBox_Bloodgroup.Text = updated.HastaKanGrubu;
                textBox_Height.Text = updated.HastaBoy;
                textBox_Age.Text = updated.HastaYas.ToString();
                textBox_Weight.Text = updated.HastaKilo;
                richTextBox_Address.Text = updated.HastaAdres;
                textBox_Phone.Text = updated.HastaTel;

                btn_Insert.Enabled = false;
                btn_Delete.Enabled = true;
                btn_Update.Enabled = true;
            }
        }

        private void ClearAll()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    txt.Clear();
                }
                if (item is ComboBox)
                {
                    ComboBox cb = (ComboBox)item;
                    cb.Text = "";
                }
                if (item is RichTextBox)
                {
                    RichTextBox rtxt = (RichTextBox)item;
                    rtxt.Clear();
                }
            }
        }

  
    }
}
