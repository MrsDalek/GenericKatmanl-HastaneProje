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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        HastaneDBEntities hdb = new HastaneDBEntities();
        private void Form4_Load(object sender, EventArgs e)
        {
            btn_PatientSearch.Enabled = false;
        }

        private void btn_PatientSearch_Click(object sender, EventArgs e)
        {
            var leftouterjoin = (from ht in hdb.HastaTahlils
                                 join t in hdb.Tahlillers on ht.TahlilID equals t.TahlilID
                                 into te
                                 from Tahliller in te.DefaultIfEmpty()
                                 join h in hdb.Hastas on ht.HastaID equals h.HastaID
                                 into he
                                 from Hasta in he.DefaultIfEmpty()
                                 join m in hdb.Muayenes on Hasta.HastaID equals m.HastaID
                                 into me
                                 from Muayene in me.DefaultIfEmpty()
                                 join mt in hdb.MuayeneTedavis on Muayene.MID equals mt.MID
                                 into mte
                                 from MuayeneTedavi in mte.DefaultIfEmpty()
                                 join ted in hdb.Tedavis on MuayeneTedavi.TedaviID equals ted.TedaviID
                                 into tede
                                 from Tedavi in tede.DefaultIfEmpty()

                                 where Hasta.Tc_Passaport == textBox_Identity.Text
                                 select new
                                 {
                                     Ad = Hasta.HastaAdi,
                                     soyad = Hasta.HastaSoyAdi,
                                     Giris = Muayene.MGiris,
                                     Cikis = Muayene.MCikis,
                                     Tahlil = Tahliller.TahlilTur,
                                     Sonuc = ht.TahlilSonuc,
                                     TedaviTanisi = Tedavi.TedaviTanim,
                                     Recete = MuayeneTedavi.ReceteAdi
                                 });

            var rightouterjoin = (from ted in hdb.Tedavis
                                  join mt in hdb.MuayeneTedavis on ted.TedaviID equals mt.TedaviID
                                  into mte
                                  from MuayeneTedavi in mte.DefaultIfEmpty()
                                  join m in hdb.Muayenes on MuayeneTedavi.MID equals m.MID
                                  into me
                                  from Muayene in me.DefaultIfEmpty()
                                  join h in hdb.Hastas on Muayene.HastaID equals h.HastaID
                                  into he
                                  from Hasta in he.DefaultIfEmpty()
                                  join ht in hdb.HastaTahlils on Hasta.HastaID equals ht.HastaID
                                  into hte
                                  from HastaTahlil in hte.DefaultIfEmpty()
                                  join t in hdb.Tahlillers on HastaTahlil.TahlilID equals t.TahlilID
                                  into te
                                  from Tahliller in te.DefaultIfEmpty()
                                  where Hasta.Tc_Passaport == textBox_Identity.Text
                                  select new
                                  {
                                      Ad = Hasta.HastaAdi,
                                      soyad = Hasta.HastaSoyAdi,
                                      Giris = Muayene.MGiris,
                                      Cikis = Muayene.MCikis,
                                      Tahlil = Tahliller.TahlilTur,
                                      Sonuc = HastaTahlil.TahlilSonuc,
                                      TedaviTanisi = ted.TedaviTanim,
                                      Recete = MuayeneTedavi.ReceteAdi,
                                  });
            leftouterjoin = rightouterjoin.Union(leftouterjoin);
            dataGridView1.DataSource = leftouterjoin.ToList();
            textBox_Identity.Clear();

        }

        private void textBox_Identity_TextChanged(object sender, EventArgs e)
        {
            btn_PatientSearch.Enabled = true;
        }
    }
}
