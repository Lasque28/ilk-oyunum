using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace MaceraTutkunuDemirci
{
    //https://github.com/Lasque28
    public partial class koy : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        public koy()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            zindan zindan = new zindan();
            
            zindan.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            balik balik = new balik();
            
            balik.Show();
        }
        //https://github.com/Lasque28
        private void button5_Click(object sender, EventArgs e)
        {
            maden maden = new maden();
            
            maden.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            orman orman = new orman();
           
            orman.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            envanter envanter = new envanter();
           
            envanter.Show();
        }
        //@emreyksln
        string para,klv,kad;

        private void koy_MouseEnter(object sender, EventArgs e)
        {

            baglan.Open();
            OleDbDataReader sorgu;
            string ara = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir2 = new OleDbCommand(ara, baglan);
            emir2.ExecuteNonQuery();

            sorgu = emir2.ExecuteReader();
            if (sorgu.Read())
            {
                // AÇILDIĞINDAKİ AYARLAR
                klv = sorgu[3].ToString();
                kad = sorgu[1].ToString();
                para = sorgu[4].ToString();
                label1.Text = kad;
                label2.Text = klv + " LV";
                label3.Text = para + " COİN";



            }
            else { MessageBox.Show("nah sana kod"); }
            baglan.Close();

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void koy_MouseClick(object sender, MouseEventArgs e)
        {

        }
        //https://github.com/Lasque28
        private void koy_Load(object sender, EventArgs e)
        {
            baglan.Open();
            OleDbDataReader sorgu;
            string ara = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir2 = new OleDbCommand(ara, baglan);
            emir2.ExecuteNonQuery();

            sorgu = emir2.ExecuteReader();
            if (sorgu.Read())
            {
                // AÇILDIĞINDAKİ AYARLAR
               klv = sorgu[3].ToString();
                kad= sorgu[1].ToString();
                para = sorgu[4].ToString();
                label1.Text = kad;
                label2.Text = klv+ " LV";
                label3.Text = para + " COİN";



            }
            else { MessageBox.Show("nah sana kod"); }
            baglan.Close();
        }
    }
}
