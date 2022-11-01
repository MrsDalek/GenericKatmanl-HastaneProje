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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
          
        }
        public static Form6 instance;
        public string title;
        int identity_id = 0;
        int password_id = 0;
        Form5 frm5;
        public bool variable;
        HastaneDBEntities hdb = new HastaneDBEntities();

        private void Form6_Load(object sender, EventArgs e)
        {
           
            btn_LogIn.Enabled = false;
            instance = this;

        }

        private void btn_LogIn_Click(object sender, EventArgs e)
        {
            if (variable == false)
            {
                variable = true;
                IdentityControl();
                PasswordControl();
                if (identity_id == password_id && identity_id != 0 && password_id != 0)
                {
                    title = hdb.Personellers.FirstOrDefault(pe => pe.PersonelTc == textBox_Identity.Text).Unvan.UnvanAdi;
                    if (title == "Doktor" || title == "Yonetici" || title == "Sekreter" || title == "Blm.bsk.Doktor")
                    {
                        frm5 = new Form5();
                        frm5.MdiParent = this;
                        Form5.instance.title = title;
                        frm5.Show();
                    }
                    else
                    {
                        MessageBox.Show("Giriş yetkiniz yoktur.");
                        variable = false;
                        btn_LogIn.Enabled = false;
                    }
                }
                else
                {
                    MessageBox.Show("TCKN veya şifre yanlış girildi.");
                    variable = false;
                    btn_LogIn.Enabled = false;
                }
                textBox_Identity.Clear();
                textBox_Password.Clear();
            }
            else
            {
                MessageBox.Show("Giriş için önce çıkış yapmalısınız");
            }
        }

        private void PasswordControl()
        {
            var tc_VarMi = hdb.Personellers.Select(p => new
            {
                p.PersonelTc

            }).ToList();
            foreach (var item in tc_VarMi)
            {
                if (textBox_Identity.Text == item.PersonelTc)
                {
                    identity_id = hdb.Personellers.FirstOrDefault(pe => pe.PersonelTc == textBox_Identity.Text).PersonelID;
                    break;
                }
            }
        }

        private void IdentityControl()
        {
            var sifre_VarMi = hdb.Personellers.Select(ps => new
            {
                ps.Sifre
            }).ToList();
            foreach (var item in sifre_VarMi)
            {
                if (textBox_Password.Text == item.Sifre)
                {
                    password_id = hdb.Personellers.FirstOrDefault(ps => ps.Sifre == textBox_Password.Text).PersonelID;
                    break;
                }
            }
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {
            btn_LogIn.Enabled = true;
        }
    }
}
