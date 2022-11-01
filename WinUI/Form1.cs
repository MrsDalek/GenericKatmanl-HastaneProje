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
    public partial class Form1 : Form
    {
        string password;
        string getpassword;
        Personeller updated;

        HastaneDBEntities hdb = new HastaneDBEntities();
        BaseRepository<Personeller> pr = new BaseRepository<Personeller>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            var title = hdb.Unvans.ToList();
            comboBoxTitle.DataSource = title;
            comboBoxTitle.DisplayMember = "UnvanAdi";
            comboBoxTitle.ValueMember = "UnvanID";

            var hospital = hdb.Hastanelers.ToList();
            comboBoxHospital.DataSource = hospital;
            comboBoxHospital.DisplayMember = "HastaneAdi";
            comboBoxHospital.ValueMember = "HastaneID";
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
            buttonSearch.Enabled = false;
            ClearAll();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            GetAllEmployee();
            buttonSearch.Enabled = true;
        }

        private void GetAllEmployee()
        {
            dataGridView1.DataSource = pr.GetAll().Where(p => p.Durum == true).Select(emp => new
            {
                emp.PersonelAdi,
                emp.PersonelSoyad,
                emp.PersonelTc,
                emp.Hastaneler.HastaneAdi,
                emp.Unvan.UnvanAdi,
                emp.PersonelYas,
                emp.PersonelCinsiyet,
                emp.PersonelTel,
                emp.PersonelMail,
                emp.PersonelAdres,
                emp.Sifre,
                emp.Durum,
                emp.PersonelID
            }).ToList();
            dataGridView1.Columns["Sifre"].Visible = false;
            dataGridView1.Columns["Durum"].Visible = false;
            dataGridView1.Columns["PersonelID"].Visible = false;

        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            getpassword = RandomPassword();
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxAge.Text != "" && textBoxID.Text != "" && textBoxID.Text.Length == 11 && textBoxPhone.Text != "" && textBoxMail.Text != "" && comboBoxHospital.Text != "" && comboBoxTitle.Text != "" && richTextBoxAdress.Text != "")
            {
                pr.Insert(new Personeller
                {
                    PersonelAdi = textBoxName.Text,
                    PersonelSoyad = textBoxSurname.Text,
                    PersonelTc = textBoxID.Text,
                    HastaneID =(int) comboBoxHospital.SelectedValue,
                    UnvanID = (int)comboBoxTitle.SelectedValue,
                    PersonelYas = Convert.ToInt32(textBoxAge.Text),
                    PersonelCinsiyet = textBoxGender.Text,
                    PersonelTel = textBoxPhone.Text,
                    PersonelMail = textBoxMail.Text,
                    PersonelAdres = richTextBoxAdress.Text,
                    Sifre = getpassword,
                    Durum = true
                });

                MessageBox.Show("Çalışan başarıyla eklendi.");
                GetAllEmployee();
                ClearAll();

            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız ve TCKN'yi doğru girdiğinizden emin olunuz.");
            }
        }
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text != "" && textBoxSurname.Text != "" && textBoxAge.Text != "" && textBoxID.Text != "" && textBoxID.Text.Length <= 11 && textBoxPhone.Text != "" && textBoxMail.Text != "" && comboBoxHospital.Text != "" && comboBoxTitle.Text != "" && richTextBoxAdress.Text != "")
            {
                updated.PersonelAdi = textBoxName.Text;
                updated.PersonelSoyad = textBoxSurname.Text;
                updated.PersonelTc = textBoxID.Text;
                updated.Hastaneler.HastaneAdi = comboBoxHospital.Text;
                updated.Unvan.UnvanAdi = comboBoxTitle.Text;
                updated.PersonelYas = Convert.ToInt32(textBoxAge.Text);
                updated.PersonelCinsiyet = textBoxGender.Text;
                updated.PersonelTel = textBoxPhone.Text;
                updated.PersonelMail = textBoxMail.Text;
                updated.PersonelAdres = richTextBoxAdress.Text;

                pr.Update(updated);
                MessageBox.Show("Çalışan başarıyla güncellendi.");
                GetAllEmployee();
                ClearAll();
            }
            else
            {
                MessageBox.Show("Lütfen boş alan bırakmayınız ve TCKN'yi doğru girdiğinizden emin olunuz.");
            }

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[12].Value);
                updated = pr.GetById(id);
                textBoxName.Text = updated.PersonelAdi;
                textBoxSurname.Text = updated.PersonelSoyad;
                textBoxID.Text = updated.PersonelTc;
                comboBoxHospital.Text = updated.Hastaneler.HastaneAdi;
                comboBoxTitle.Text = updated.Unvan.UnvanAdi;
                textBoxAge.Text = updated.PersonelYas.ToString();
                textBoxGender.Text = updated.PersonelCinsiyet;
                textBoxPhone.Text = updated.PersonelTel;
                textBoxMail.Text = updated.PersonelMail;
                richTextBoxAdress.Text = updated.PersonelAdres;
                buttonInsert.Enabled = false;
                buttonDelete.Enabled = true;
                buttonUpdate.Enabled = true;
            }
        
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            updated.Durum = false;
            pr.Delete(updated);
            MessageBox.Show("Çalışan başarıyla silindi.");
            ClearAll();
            GetAllEmployee();

            buttonInsert.Enabled = true;
            buttonUpdate.Enabled = false;
            buttonDelete.Enabled = false;
        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {       
            try
            {

                dataGridView1.DataSource = pr.GetAll().Where(p => p.PersonelTc == textBoxSearch.Text && p.Durum == true).Select(emp => new
                {
                    emp.PersonelAdi,
                    emp.PersonelSoyad,
                    emp.PersonelTc,
                    emp.Hastaneler.HastaneAdi,
                    emp.Unvan.UnvanAdi,
                    emp.PersonelYas,
                    emp.PersonelCinsiyet,
                    emp.PersonelTel,
                    emp.PersonelMail,
                    emp.PersonelAdres,
                    emp.Sifre,
                    emp.Durum,
                    emp.PersonelID
                }).ToList();
                dataGridView1.Columns["Sifre"].Visible = false;
                dataGridView1.Columns["Durum"].Visible = false;
                dataGridView1.Columns["PersonelID"].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı TCKN girdiniz girdiniz");
            }

            ClearAll();
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

        private string RandomPassword()
        {
            password = null;
            Random rndLenght = new Random();
            int passwordlenght = rndLenght.Next(8, 11);

            Random rndbool = new Random();
            Random rndLetter = new Random();
            Random rndNumber = new Random();
            int numberORletter;

            for (int i = 0; i < passwordlenght; i++)
            {
                numberORletter = rndbool.Next(0, 3);

                if (numberORletter == 0)
                {
                    int number = rndNumber.Next(0, 10);
                    password = password + number.ToString();
                }
                else if (numberORletter == 1)
                {
                    int letterBigASCII = rndLetter.Next(65, 91);
                    password = password + Convert.ToChar(letterBigASCII);
                }
                else if (numberORletter == 2)
                {
                    int letterLittleASCII = rndLetter.Next(97, 123);
                    password = password + Convert.ToChar(letterLittleASCII);
                }
            }
            PasswordControl(password);
            return password;
        }

        private void PasswordControl(string password)
        {
            var hasPassword = hdb.Personellers.Select(ps => new
            {
                ps.Sifre
            });
            foreach (var item in hasPassword)
            {
                if (password == item.Sifre)
                {
                    RandomPassword();
                }
            }
        }

        
    }
}
