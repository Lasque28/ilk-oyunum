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

namespace MaceraTutkunuDemirci  //https://github.com/Lasque28 @emreyksln
{
    public partial class balik : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        string hamsiler, inciler ;
        int hamsi, inci;
        private void yakalabalık()
        {
            baglan.Open();
            OleDbDataReader sorgu;
            string ara2 = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan);
            emir2.ExecuteNonQuery();
            
            sorgu = emir2.ExecuteReader();
            if (sorgu.Read())
            {

               hamsiler = sorgu[9].ToString();
                inciler = sorgu[10].ToString();                                        // KAZANILANLARI KAYDETME
            
            }
            else { MessageBox.Show("nah sana kod"); }
            baglan.Close();
            hamsiler = (Convert.ToInt32(hamsiler) + hamsi).ToString();
            inciler = (Convert.ToInt32(inciler) + inci).ToString();
            baglan.Open();
            string ara = ("UPDATE kullanici_kayit  set gamer_balik=@balik, gamer_inci=@inci WHERE kullanici_no=@no");

            OleDbCommand emir3 = new OleDbCommand(ara, baglan);
            
            emir3.Parameters.AddWithValue("@balik", OleDbType.Integer).Value =hamsiler;
            emir3.Parameters.AddWithValue("@inci", OleDbType.Integer).Value = inciler;
            emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;

            
            emir3.ExecuteNonQuery();
            baglan.Close();


        }
       
        public balik()
        {
            InitializeComponent();  //https://github.com/Lasque28 @emreyksln

        }
        int sayac = 100;
        int sayi1, sayi2, sayi3, sayi4, sayi5, sayi6;

        private void timer1_Tick(object sender, EventArgs e)
        {
            sayac--;
            label1.Text=(sayac.ToString());
            
            
            if (sayac == sayi1) { balik1.Visible = true; l1.Text = sayi1.ToString();  }
            if (sayac == (sayi1 - 5)) { balik1.Visible = false; }
            if (sayac == sayi2) { balik2.Visible = true; l2.Text = sayi2.ToString(); }
            if (sayac == (sayi2 - 5)) { balik2.Visible = false; }
            if (sayac == sayi3) { balik3.Visible = true; l3.Text = sayi3.ToString(); }       // RASGELE BALIK ÇIKARMA
            if (sayac == (sayi3 - 5)) { balik3.Visible = false; }
            if (sayac == sayi4) { balik4.Visible = true; l4.Text = sayi4.ToString(); }
            if (sayac == (sayi4 - 5)) { balik4.Visible = false; }
            if (sayac == sayi5) { balik5.Visible = true; l5.Text = sayi5.ToString(); }
            if (sayac == (sayi5 - 5)) { balik5.Visible = false; }
            if (sayac == sayi6) { balik6.Visible = true; l6.Text = sayi6.ToString(); }
            if (sayac == (sayi6 - 5)) { balik6.Visible = false; }





            if (sayac < 1) { timer1.Stop(); button2.Enabled =true;
                sunum.Text=("Süreniz bitti"); label4.Text = hamsi.ToString(); label5.Text = inci.ToString(); yakalabalık(); } // SÜRE BİTTİ
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32( para) >= 20&& sayac==100) {

                baglan.Open();
                string ara3 = ("UPDATE kullanici_kayit  set kullanici_para=@para WHERE kullanici_no=@no");

                OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                para = (Convert.ToInt32(para) - 20).ToString();
                emir3.Parameters.AddWithValue("@para", OleDbType.Integer).Value = para;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                
                label3.Text = para.ToString() + "COİN";                                                    //BAŞLAT
                emir3.ExecuteNonQuery();
                baglan.Close();                                                                         //BAŞLAT


                timer1.Start();
            sunum.Text = ("100 saniyeniz başladı");
            Random rsg = new Random();
             sayi1 = rsg.Next(5, 100);
             sayi2 = rsg.Next(5, 100);
             sayi3 = rsg.Next(5, 100);
            sayi4 = rsg.Next(5, 100);
            sayi5 = rsg.Next(5, 100);
            sayi6 = rsg.Next(5, 100);
            }
            else { sunum.Text = ("Başlamadan önce reset atmalısın yada paran bitmiş"); }

        }  //https://github.com/Lasque28 @emreyksln

        private void balik4_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.fishing); player3.Play(); 
            Random rsg = new Random();
            int rastgele = rsg.Next(1, 3); 
            if (rastgele == 1) { sunum.Text = ("harika bir balık tutunuz"); hamsi++; }   //BALIK YAKALADIN
            else { sunum.Text = ("balığı kaçırdın ama şansa inci tutun"); inci++; }
           
            checkBox4.Checked = true;
        }

        private void balik5_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.fishing); player3.Play();  Random rsg = new Random();
            int rastgele = rsg.Next(1, 3);
            if (rastgele == 1) { sunum.Text = ("harika bir balık tutunuz"); hamsi++; }   //BALIK YAKALADIN
            else { sunum.Text = ("balığı kaçırdın ama şansa inci tutun"); inci++; }
            checkBox5.Checked=true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("BALIK TUTMA MASRAFI 20 COİNDİR TUTUĞUN BALIK ELİNDEN KAÇARSA İNCİ KAZANIRSIN");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            koy koy = new koy();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            panel1.Visible = false;

        }
        //@emreyksln
        private void button2_Click(object sender, EventArgs e)
        {
            sayac = 100;
            checkBox1.Checked = false; l1.Text = "0"; label4.Text = "0";
            checkBox2.Checked = false; l2.Text = "0"; label5.Text = "0";  //RESET TUŞU
            checkBox3.Checked = false; l3.Text = "0";
            checkBox4.Checked = false; l4.Text = "0";
            checkBox5.Checked = false; l5.Text = "0";
            checkBox6.Checked = false; l6.Text = "0";

        }

        private void balik1_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.fishing); player3.Play();  Random rsg = new Random();
            int rastgele = rsg.Next(1, 3);
            if (rastgele == 1) { sunum.Text = ("harika bir balık tutunuz"); hamsi++; }  //BALIK YAKALADIN
            else { sunum.Text = ("balığı kaçırdın ama şansa inci tutun"); inci++; }
            checkBox1.Checked = true;
        }

        private void balik3_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.fishing); player3.Play();  Random rsg = new Random();
            int rastgele = rsg.Next(1, 3);
            if (rastgele == 1) { sunum.Text = ("harika bir balık tutunuz"); hamsi++; }   //BALIK YAKALADIN
            else { sunum.Text = ("balığı kaçırdın ama şansa inci tutun"); inci++; }
            checkBox3.Checked = true;
        }

        private void balik6_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.fishing); player3.Play(); Random rsg = new Random();
            int rastgele = rsg.Next(1, 3);
            if (rastgele == 1) { sunum.Text = ("harika bir balık tutunuz"); hamsi++; }   //BALIK YAKALADIN
            else { sunum.Text = ("balığı kaçırdın ama şansa inci tutun"); inci++; }
            checkBox6.Checked = true;
        }

        private void balik2_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.fishing); player3.Play(); Random rsg = new Random();
            int rastgele = rsg.Next(1, 3);
            if (rastgele == 1) { sunum.Text = ("harika bir balık tutunuz"); hamsi++; }    //BALIK YAKALADIN
            else { sunum.Text = ("balığı kaçırdın ama şansa inci tutun"); inci++; }
            checkBox2.Checked = true;
        }
        string para;
        private void balik_Load(object sender, EventArgs e)
        {  //https://github.com/Lasque28 @emreyksln
            button2.Enabled = false;
            baglan.Open();
            OleDbDataReader sorgu;
            string ara = ("Select*From kullanici_kayit WHERE  kullanici_no= "+1);
            OleDbCommand emir2 = new OleDbCommand(ara, baglan);
            emir2.ExecuteNonQuery();

            sorgu = emir2.ExecuteReader();
            if (sorgu.Read())
            {
                                                              // AÇILDIĞINDAKİ AYARLAR
                para = sorgu[4].ToString();
                label3.Text = para + " COİN";
               
                

            }
            else { MessageBox.Show("nah sana kod"); }
            baglan.Close();
        }
    }
}
