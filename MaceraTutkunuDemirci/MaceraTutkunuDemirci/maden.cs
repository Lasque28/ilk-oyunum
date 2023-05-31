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
   

    public partial class maden : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        int sayac3 = 0;
        int[] sayilar = new int[19];
        Random rsg = new Random();  //https://github.com/Lasque28 @emreyksln
        public void kayitgir()
        {
           

            if (sayac == 0&& sayac3==0)
            {
                sayac3 = 1;
                MessageBox.Show("KAYİTLAR GİRİLİYOR");
                baglan.Open();
                OleDbDataReader sorgu;
                string ara2 = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
                OleDbCommand emir2 = new OleDbCommand(ara2, baglan);
                emir2.ExecuteNonQuery();

                sorgu = emir2.ExecuteReader();
                if (sorgu.Read())
                {

                    demirler = sorgu[11].ToString();
                    silverlar = sorgu[12].ToString();
                    yakutlar = sorgu[13].ToString();


                }
                else { MessageBox.Show("nah sana kod"); }
                baglan.Close();
                demirler = (Convert.ToInt32(demirler) + demir).ToString();
                yakutlar = (Convert.ToInt32(yakutlar) + yakut).ToString();
                silverlar = (Convert.ToInt32(silverlar) + silver).ToString();
               
                baglan.Open();
                string ara = ("UPDATE kullanici_kayit  set gamer_demir=@demir, gamer_silver=@silver, gamer_yakut=@yakut WHERE kullanici_no=@no");  // KAZANILANLARI KAYDETME

                OleDbCommand emir3 = new OleDbCommand(ara, baglan);

                emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demirler;
                emir3.Parameters.AddWithValue("@silver", OleDbType.Integer).Value = silverlar;
                emir3.Parameters.AddWithValue("@yakut", OleDbType.Integer).Value = yakutlar;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;


                emir3.ExecuteNonQuery();
                baglan.Close();
                

            }

                   

            if (tas0.Enabled = false) { if (tas1.Enabled = false) { if (tas3.Enabled = false) { if (tas4.Enabled = false) { if (tas5.Enabled = false) { if (tas6.Enabled = false) { if (tas8.Enabled = false) {if (tas9.Enabled = false) {
             if (tas10.Enabled = false) { if (tas11.Enabled = false) { if (tas12.Enabled = false) { if (tas13.Enabled = false) { if (tas14.Enabled = false) { if (tas15.Enabled = false) { if (tas16.Enabled = false) {if (tas18.Enabled = false)
                                                                        {
                                                                            if (tas19.Enabled = false)
                                                                            {
                                                                                if (tas20.Enabled = false)
                                                                                {
                                                                                    if (tas21.Enabled = false)
                                                                                    {




                                                                                        baglan.Open();
                                                                                        OleDbDataReader sorgu;
                                                                                        string ara2 = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
                                                                                        OleDbCommand emir2 = new OleDbCommand(ara2, baglan);
                                                                                        emir2.ExecuteNonQuery();

                                                                                        sorgu = emir2.ExecuteReader();
                                                                                        if (sorgu.Read())
                                                                                        {

                                                                                            demirler = sorgu[11].ToString();
                                                                                            silverlar = sorgu[12].ToString();
                                                                                            yakutlar = sorgu[13].ToString();


                                                                                        }
                                                                                        else { MessageBox.Show("nah sana kod"); }
                                                                                        baglan.Close();
                                                                                        demirler = (Convert.ToInt32(demirler) + demir).ToString();
                                                                                        yakutlar = (Convert.ToInt32(yakutlar) + yakut).ToString();
                                                                                        silverlar = (Convert.ToInt32(silverlar) + silver).ToString();
                                                                                        MessageBox.Show(demirler + "--" + silverlar + "--" + yakutlar);
                                                                                        baglan.Open();
                                                                                        string ara = ("UPDATE kullanici_kayit  set gamer_demir=@demir, gamer_silver=@silver, gamer_yakut=@yakut WHERE kullanici_no=@no");  // KAZANILANLARI KAYDETME

                                                                                        OleDbCommand emir3 = new OleDbCommand(ara, baglan);

                                                                                        emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demirler;
                                                                                        emir3.Parameters.AddWithValue("@silver", OleDbType.Integer).Value = silverlar;
                                                                                        emir3.Parameters.AddWithValue("@yakut", OleDbType.Integer).Value = yakutlar;
                                                                                        emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;


                                                                                        emir3.ExecuteNonQuery();
                                                                                        baglan.Close();


                                                                                    }}}}}}}}}}}}}}}}}}}
                                                                             



        }
            public maden()
        {
            
           
            for (i = 0; i < sayilar.Length; i++)
            {

               
                sayilar[i] = rsg.Next(1, 21);

            }
            InitializeComponent();
            

        }
        
        int demir=0, silver=0, yakut=0,sayac=0;
       

    private void tas0_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);
            player3.Play();
            if (sayac >0)
            {
                no.Text = sayilar[0].ToString();
                if (sayilar[0] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas0.Image = Properties.Resources.stone22; }
                else if (sayilar[0] > 13 && sayilar[0] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas0.Enabled = false;tas0.Enabled = false; tas0.Image = Properties.Resources.ironbar; demir++; sayac--; sy.Text = sayac.ToString(); ; }
                else if (sayilar[0] > 17 && sayilar[0] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas0.Enabled = false; tas0.Image = Properties.Resources.silverbar; silver++; sayac--; sy.Text = sayac.ToString(); ; }
                else if (sayilar[0] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas0.Enabled = false; tas0.Image = Properties.Resources.yakut; yakut++; sayac--; sy.Text = sayac.ToString(); ; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }


        }  //https://github.com/Lasque28 @emreyksln

        private void tas1_Click(object sender, EventArgs e)
        {
           
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);
            player3.Play();
            if (sayac >0)
            {
                no.Text = sayilar[1].ToString();
                if (sayilar[1] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas1.Image = Properties.Resources.stone22; }
                else if (sayilar[1] > 13 && sayilar[1] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas1.Enabled = false; tas1.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[1] > 17 && sayilar[1] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas1.Enabled = false; tas1.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[1] > 19 ){ sunum.Text = "Taşın içinden Yakut çıktı  ";tas1.Enabled = false; tas1.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas2_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);
            player3.Play();
            if (sayac >0)
            {
                no.Text = sayilar[2].ToString();
                if (sayilar[2] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas2.Image = Properties.Resources.stone22; }
                else if (sayilar[2] > 13 && sayilar[2] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas2.Enabled = false; tas2.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[2] > 17 && sayilar[2] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas2.Enabled = false; tas2.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[2] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas2.Enabled = false; tas2.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas3_Click(object sender, EventArgs e)
        {
            System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);
            player3.Play();
            if (sayac >0)
            {
                no.Text = sayilar[3].ToString();
                if (sayilar[3] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas3.Image = Properties.Resources.stone22; }
                else if (sayilar[3] > 13 && sayilar[3] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas3.Enabled = false; tas3.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[3] > 17 && sayilar[3] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas3.Enabled = false; tas3.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[3] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas3.Enabled = false; tas3.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas4_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play();
            if (sayac >0)
            {
                no.Text = sayilar[4].ToString();
                if (sayilar[4] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas4.Image = Properties.Resources.stone22; }
                else if (sayilar[4] > 13 && sayilar[4] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas4.Enabled = false; tas4.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[4] > 17 && sayilar[4] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas4.Enabled = false; tas4.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[4] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas4.Enabled = false; tas4.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas5_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play();
            if (sayac >0)
            {
                no.Text = sayilar[5].ToString();
                if (sayilar[5] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas5.Image = Properties.Resources.stone22; }
                else if (sayilar[5] > 13 && sayilar[5] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas5.Enabled = false; tas5.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[5] > 17 && sayilar[5] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas5.Enabled = false; tas5.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[5] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas5.Enabled = false; tas5.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
                
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas6_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play();
            if (sayac >0)
            {
                no.Text = sayilar[6].ToString();
                if (sayilar[6] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas6.Image = Properties.Resources.stone22; }
                else if (sayilar[6] > 13 && sayilar[6] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas6.Enabled = false; tas6.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[6] > 17 && sayilar[6] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas6.Enabled = false; tas6.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[6] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas6.Enabled = false; tas6.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas8_Click(object sender, EventArgs e)
        {
            
                 System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
            {
                no.Text = sayilar[7].ToString();
                if (sayilar[7] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas8.Image = Properties.Resources.stone22; }
                    else if (sayilar[7] > 13 && sayilar[7] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas8.Enabled = false; tas8.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[7] > 17 && sayilar[7] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas8.Enabled = false; tas8.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[7] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas8.Enabled = false; tas8.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
                }
                else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
            
        }

        private void tas9_Click(object sender, EventArgs e)
        {
           
                 System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
                {
                no.Text = sayilar[8].ToString();
                if (sayilar[8] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas9.Image = Properties.Resources.stone22; }
                    else if (sayilar[8] > 13 && sayilar[8] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas9.Enabled = false; tas9.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[8] > 17 && sayilar[8] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas9.Enabled = false; tas9.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[8] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas9.Enabled = false; tas9.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
                }
                else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
            
        }

        private void tas10_Click(object sender, EventArgs e)
        {
            
                 System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play();
            if (sayac >0)
                {
                no.Text = sayilar[9].ToString();
                if (sayilar[9] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas10.Image = Properties.Resources.stone22; }
                    else if (sayilar[9] > 13 && sayilar[9] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas10.Enabled = false; tas10.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[9] > 17 && sayilar[9] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas10.Enabled = false; tas10.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[9] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas10.Enabled = false; tas10.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
                }
                else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
            
        }

        private void tas11_Click(object sender, EventArgs e)
        {
            
                 System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
                {
                no.Text = sayilar[10].ToString();
                if (sayilar[10] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas11.Image = Properties.Resources.stone22; }
                    else if (sayilar[10] > 13 && sayilar[10] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas11.Enabled = false; tas11.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[10] > 17 && sayilar[10] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas11.Enabled = false; tas11.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[10] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas11.Enabled = false; tas11.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
                else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
            
        }

        private void tas12_Click(object sender, EventArgs e)
        {
           
                 System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
                {
                no.Text = sayilar[11].ToString();
                if (sayilar[11] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas12.Image = Properties.Resources.stone22; }
                    else if (sayilar[11] > 13 && sayilar[11] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas12.Enabled = false; tas12.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[11] > 17 && sayilar[11] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas12.Enabled = false; tas12.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[11] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas12.Enabled = false; tas12.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
                }
                else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }

        }  //https://github.com/Lasque28 @emreyksln

        private void tas13_Click(object sender, EventArgs e)
        {
            
                 System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
                {
                no.Text = sayilar[12].ToString();
                if (sayilar[12] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas13.Image = Properties.Resources.stone22; }
                    else if (sayilar[12] > 13 && sayilar[12] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas13.Enabled = false; tas13.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[12] > 17 && sayilar[12] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas13.Enabled = false; tas13.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[12] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas13.Enabled = false; tas13.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
                else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
            
        }

        private void tas14_Click(object sender, EventArgs e)
        {
            
                 System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
                {
                no.Text = sayilar[13].ToString();
                if (sayilar[13] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas14.Image = Properties.Resources.stone22; }
                    else if (sayilar[13] > 13 && sayilar[13] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas14.Enabled = false; tas14.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[13] > 17 && sayilar[13] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas14.Enabled = false; tas14.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                    else if (sayilar[13] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas14.Enabled = false; tas14.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
                }
                else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
            
        }

        private void tas15_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
            {
                no.Text = sayilar[14].ToString();
                if (sayilar[14] <= 13) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas15.Image = Properties.Resources.stone22; }
                else if (sayilar[14] > 13 && sayilar[14] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas15.Enabled = false; tas15.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[14] > 17 && sayilar[14] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas15.Enabled = false; tas15.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[14] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas15.Enabled = false; tas15.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas16_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
            {
                no.Text = sayilar[15].ToString();
                if (sayilar[15] <= 10) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas16.Image = Properties.Resources.stone22; }
                else if (sayilar[15] > 10 && sayilar[15] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas16.Enabled = false; tas16.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[15] > 17 && sayilar[15] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas16.Enabled = false; tas16.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[15] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas16.Enabled = false; tas16.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas18_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
            {
                no.Text = sayilar[16].ToString();
                if (sayilar[16] <= 5) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas18.Image = Properties.Resources.stone22; }
                else if (sayilar[16] > 5 && sayilar[16] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas18.Enabled = false; tas18.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[16] > 17 && sayilar[16] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas18.Enabled = false; tas18.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[16] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas18.Enabled = false; tas18.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas19_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
            {
                no.Text = sayilar[17].ToString();
                if (sayilar[17] <= 5) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas19.Image = Properties.Resources.stone22; }
                else if (sayilar[17] > 5 && sayilar[17] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas19.Enabled = false; tas19.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[17] > 17 && sayilar[17] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas19.Enabled = false; tas19.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[17] > 19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas19.Enabled = false; tas19.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas20_Click(object sender, EventArgs e)
        {
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
            {
                no.Text = sayilar[18].ToString();
                if (sayilar[18] <= 5) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas20.Image = Properties.Resources.stone22; }
                else if (sayilar[18] > 5 && sayilar[18] <= 17) { sunum.Text = "Taşın içinden Demir çıktı  ";tas20.Enabled = false; tas20.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[18] > 17 && sayilar[18] <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı  ";tas20.Enabled = false; tas20.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar[18] >19) { sunum.Text = "Taşın içinden Yakut çıktı  ";tas20.Enabled = false; tas20.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        private void tas21_Click(object sender, EventArgs e)
        {
            int sayilar19 = rsg.Next(1, 20);
           
             System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.dig);   player3.Play(); if (sayac >0)
            {
                no.Text = sayilar19.ToString();
                if (sayilar19 <= 5) { sunum.Text = "Hay aksi Taşın içi boş çıktı";   tas21.Image = Properties.Resources.stone22; }
                else if (sayilar19 > 5 && sayilar19 <= 17) { sunum.Text = "Taşın içinden Demir çıktı "; tas21.Image = Properties.Resources.ironbar; demir++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar19 > 17 && sayilar19 <= 19) { sunum.Text = "Taşın içinden Gümüş çıktı "; tas21.Image = Properties.Resources.silverbar; silver++; sayac--;sy.Text=sayac.ToString();; }
                else if (sayilar19 > 19) { sunum.Text = "Taşın içinden Yakut çıktı "; tas21.Image = Properties.Resources.yakut; yakut++; sayac--;sy.Text=sayac.ToString();; }
            }
            else { sunum.Text = "Çok yoruldun daha maden çıkaramasın"; }
        }

        int i ;
        string para;
       private void maden_Load(object sender, EventArgs e)
        {  //https://github.com/Lasque28 @emreyksln



            baglan.Open();
            OleDbDataReader sorgu;
            string ara = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
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

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void sunum_TextChanged(object sender, EventArgs e)
        {
            demirsay.Text = demir.ToString();
            gümüssay.Text = silver.ToString();
            yakutsat.Text = yakut.ToString();
        }
        string demirler="0", silverlar = "0", yakutlar = "0";
        //@emreyksln
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (sayac == 0 && sayac2 >= 1) { kayitgir(); sayac3++; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            koy koy = new koy();
            this.Hide();
           
        }

        private void hizlikaz_Click(object sender, EventArgs e)
        {
            demirsay.Text= "0"; gümüssay.Text = "0"; yakutsat.Text = "0";
            baglan.Open();
            string ara3 = ("UPDATE kullanici_kayit  set kullanici_para=@para WHERE kullanici_no=@no");

            OleDbCommand emir4 = new OleDbCommand(ara3, baglan);
            para = (Convert.ToInt32(para) - 200).ToString();
            emir4.Parameters.AddWithValue("@para", OleDbType.Integer).Value = para;
            emir4.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;

            label3.Text = para.ToString() + "COİN";                                                    //BAŞLAT
            emir4.ExecuteNonQuery();
            baglan.Close();
            int demirsayar=0, silversayar=0, yakutsayar=0;
            Random rast = new Random();
            int Random=0;
            for (int x = 0; x <= 20; x++)
            {
                Random = rast.Next(1, 21);
                int toplam = demirsayar + silversayar + yakutsayar;
                if (toplam<=7) { 
                if (Random <= 12) { }
               else if (Random > 14&& Random <= 18) { demirsayar++; demirsay.Text = demirsayar + ""; }
               else if (Random > 18 && Random <= 19) { silversayar++; gümüssay.Text = silversayar + ""; }
               else if(Random >19) { yakutsayar++; yakutsat.Text = yakutsayar + ""; }
                }
            }
            sayac3 = 1;
            MessageBox.Show("KAYİTLAR GİRİLİYOR");
            baglan.Open();
            OleDbDataReader sorgu;
            string ara2 = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan);
            emir2.ExecuteNonQuery();

            sorgu = emir2.ExecuteReader();
            if (sorgu.Read())
            {

                demirler = sorgu[11].ToString();
                silverlar = sorgu[12].ToString();
                yakutlar = sorgu[13].ToString();


            }
            else { MessageBox.Show("nah sana kod"); }
            baglan.Close();
            demirler = (Convert.ToInt32(demirler) + demirsayar).ToString();
            yakutlar = (Convert.ToInt32(yakutlar) + yakutsayar).ToString();
            silverlar = (Convert.ToInt32(silverlar) + silversayar).ToString();

            baglan.Open();
            string ara = ("UPDATE kullanici_kayit  set gamer_demir=@demir, gamer_silver=@silver, gamer_yakut=@yakut WHERE kullanici_no=@no");  // KAZANILANLARI KAYDETME

            OleDbCommand emir3 = new OleDbCommand(ara, baglan);

            emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demirler;
            emir3.Parameters.AddWithValue("@silver", OleDbType.Integer).Value = silverlar;
            emir3.Parameters.AddWithValue("@yakut", OleDbType.Integer).Value = yakutlar;
            emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;


            emir3.ExecuteNonQuery();
            baglan.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            panel1.Visible = false;
        }

        private void sy_TextChanged(object sender, EventArgs e)
        {


            
        
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            sayac3 = 0;
            sayac = 0;
            sy.Text = sayac.ToString();
            tas0.Image = Properties.Resources.stone;
            //https://github.com/Lasque28 @emreyksln
            tas1.Image = Properties.Resources.stone;
            tas2.Image = Properties.Resources.stone;
            tas3.Image = Properties.Resources.stone;
            tas4.Image = Properties.Resources.stone;
            tas5.Image = Properties.Resources.stone;
            tas6.Image = Properties.Resources.stone;
            tas8.Image = Properties.Resources.stone;
            tas9.Image = Properties.Resources.stone;
            tas10.Image = Properties.Resources.stone;
            tas11.Image = Properties.Resources.stone;
            tas12.Image = Properties.Resources.stone;
            tas13.Image = Properties.Resources.stone;
            tas14.Image = Properties.Resources.stone;
            tas15.Image = Properties.Resources.stone;
            tas16.Image = Properties.Resources.stone;
            tas18.Image = Properties.Resources.stone;
            tas19.Image = Properties.Resources.stone;
            tas20.Image = Properties.Resources.stone;
            tas21.Image = Properties.Resources.stone;
            yakutsat.Text = "0";
            demirsay.Text = "0";
            gümüssay.Text = "0";
            demir = 0;
            silver = 0;
            yakut = 0;
            for (i = 0; i < sayilar.Length; i++)
            {


                sayilar[i] = rsg.Next(1, 21);

            }

            tas0.Enabled = true;
            tas1.Enabled =true;
            tas2.Enabled =true;
            tas3.Enabled =true;
            tas4.Enabled =true;
            tas5.Enabled =true;
            tas6.Enabled =true;
            tas8.Enabled =true;
            tas9.Enabled =true;
            tas19.Enabled =true;
            tas11.Enabled =true;
            tas12.Enabled =true;
            tas13.Enabled =true;
            tas14.Enabled =true;
            tas15.Enabled =true;
            tas16.Enabled =true;
            tas18.Enabled =true;
            tas19.Enabled =true;
            tas20.Enabled =true;
            tas21.Enabled =true;

        }

    
        int sayac2 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            


            if (Convert.ToInt32(para) >= 20&& sayac==0 )
            {
                timer1.Start();

                sayac2++;
                sayac = 6;
                sy.Text = sayac.ToString();

                baglan.Open();
                string ara3 = ("UPDATE kullanici_kayit  set kullanici_para=@para WHERE kullanici_no=@no");

                OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                para = (Convert.ToInt32(para) - 20).ToString();
                emir3.Parameters.AddWithValue("@para", OleDbType.Integer).Value = para;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;

                label3.Text = para.ToString() + "COİN";                                                    //BAŞLAT
                emir3.ExecuteNonQuery();
                baglan.Close();
            }

            }

       
    }
}
