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

    public partial class zindan : Form
    {
        OleDbConnection baglan2 = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        int cnvcan2,cnvcan3, cnvxp2, cnvhsr2, cnvlv2,cnvpr2;
        int heal=0;
        string gmrlvtani2;
        private void cnvcagir()

        {
            Random random = new Random();
            int cnvno = 0;
            OleDbDataReader sorgu5;
            baglan2.Open();
            string ara5 = ("Select*From kullanici_kayit WHERE kullanici_no=" + 1);//dnm2
            OleDbCommand emir5 = new OleDbCommand(ara5,baglan2);
            sorgu5 = emir5.ExecuteReader();                                //LV GÖRE CANAVAR GETİREN KOD

            if (sorgu5.Read())
            {
                 gmrlvtani2 = sorgu5[3].ToString();
                int gmrlvtani =Convert.ToInt32( gmrlvtani2);
                if (55>= gmrlvtani && gmrlvtani>=1) { cnvno = random.Next(2, 4); }
               

            }
            baglan2.Close();
            baglan2.Open();
            
           
          
            OleDbDataReader sorgu;
            int dnm = 2;

            string ara = ("Select*From cnv_kayit WHERE cnv_no=" + cnvno);
            OleDbCommand emir = new OleDbCommand(ara, baglan2);

            emir.ExecuteNonQuery();

            sorgu = emir.ExecuteReader();
            if (sorgu.Read())
            {
                
                string cnvad, cnvcan, cnvxp, cnvlv, cnvhsr,cnvpr;
                cnvad = sorgu[1].ToString();
                cnvcan = sorgu[2].ToString();
                cnvlv = sorgu[3].ToString();
                cnvxp = sorgu[4].ToString();              // METOTLA CANAVAR YENİLEME
                cnvhsr = sorgu[5].ToString();
                cnvpr = sorgu[6].ToString();

               if(Convert.ToInt32(gmrlvtani2)<=5)
                {
                cnvcan3 = Convert.ToInt32(cnvcan);
                cnvhsr2 = Convert.ToInt32(cnvhsr);
                cnvlv2 = Convert.ToInt32(cnvlv);        //GEREKSİZ İNT ÇEVİRME İŞLEMİ
                cnvxp2 = Convert.ToInt32(cnvxp);
                cnvpr2 = Convert.ToInt32(cnvpr);
                label11.Text = cnvcan3+"";
                label12.Text = cnvad + " " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
                }
              else  if (Convert.ToInt32(gmrlvtani2) > 5&& Convert.ToInt32(gmrlvtani2)<= 9)
                {
                    cnvcan3 = Convert.ToInt32(cnvcan)*2;
                    cnvhsr2 = Convert.ToInt32(cnvhsr)*2;
                    cnvlv2 = Convert.ToInt32(cnvlv)*2;        //GEREKSİZ İNT ÇEVİRME İŞLEMİ
                    cnvxp2 = Convert.ToInt32(cnvxp)*2;
                    cnvpr2 = Convert.ToInt32(cnvpr)*2;
                    label11.Text = cnvcan3 + "";
                    label12.Text = cnvad + " " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
                }
                else if (Convert.ToInt32(gmrlvtani2) > 9 && Convert.ToInt32(gmrlvtani2) <= 19)
                {
                    if(Convert.ToInt32(gmrlvtani2) == 10)
                    {
                        cnvcan3 = Convert.ToInt32(cnvcan) * 8;
                        cnvhsr2 = Convert.ToInt32(cnvhsr) * 3;
                        cnvlv2 = Convert.ToInt32(cnvlv) * 4;        //BOSS 10LV
                        cnvxp2 = Convert.ToInt32(cnvxp) * 3;
                        cnvpr2 = Convert.ToInt32(cnvpr) * 8;
                        label11.Text = cnvcan3 + "";
                        label12.Text = cnvad + " BOSS " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;

                    }
                    else
                    {
                        cnvcan3 = Convert.ToInt32(cnvcan) * 3;
                    cnvhsr2 = Convert.ToInt32(cnvhsr) * 3;
                    cnvlv2 = Convert.ToInt32(cnvlv) * 2;        //11LV-19LV YARATIK
                    cnvxp2 = Convert.ToInt32(cnvxp) * 2;
                    cnvpr2 = Convert.ToInt32(cnvpr) * 3;
                    label11.Text = cnvcan3 + "";
                    label12.Text = cnvad + " " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
                    }
                }
                else if (Convert.ToInt32(gmrlvtani2) > 19 && Convert.ToInt32(gmrlvtani2) <=29)
                {
                    if (Convert.ToInt32(gmrlvtani2) == 20)
                    {
                        cnvcan3 = Convert.ToInt32(cnvcan) * 15;
                        cnvhsr2 = Convert.ToInt32(cnvhsr) * 6;
                        cnvlv2 = Convert.ToInt32(cnvlv) * 8;        //BOSS 20LV
                        cnvxp2 = Convert.ToInt32(cnvxp) * 10;
                        cnvpr2 = Convert.ToInt32(cnvpr) * 15;
                        label11.Text = cnvcan3 + "";
                        label12.Text = cnvad + " BOSS " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
                    }
                    else
                    {
                            cnvcan3 = Convert.ToInt32(cnvcan) * 6;
                            cnvhsr2 = Convert.ToInt32(cnvhsr) * 4;
                            cnvlv2 = Convert.ToInt32(cnvlv) * 2;        //21-29LV YARATIK
                            cnvxp2 = Convert.ToInt32(cnvxp) * 4;
                            cnvpr2 = Convert.ToInt32(cnvpr) * 6;
                            label11.Text = cnvcan3 + "";
                            label12.Text = cnvad + " " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
                        }
                    }

                
                   
            
                else if (Convert.ToInt32(gmrlvtani2) > 29 && Convert.ToInt32(gmrlvtani2) <= 39)
                {
                if (Convert.ToInt32(gmrlvtani2) == 30)
                {
                    cnvcan3 = Convert.ToInt32(cnvcan) * 25;
                    cnvhsr2 = Convert.ToInt32(cnvhsr) * 8;
                    cnvlv2 = Convert.ToInt32(cnvlv) * 4;        //BOSS 30LV
                    cnvxp2 = Convert.ToInt32(cnvxp) * 10;
                    cnvpr2 = Convert.ToInt32(cnvpr) * 15;
                    label11.Text = cnvcan3 + "";
                    label12.Text = cnvad + " BOSS " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;

                }
           
            else
            {
                cnvcan3 = Convert.ToInt32(cnvcan) * 8;
                cnvhsr2 = Convert.ToInt32(cnvhsr) * 8;
                cnvlv2 = Convert.ToInt32(cnvlv) * 3;        //31-39LV YARATIK
                cnvxp2 = Convert.ToInt32(cnvxp) * 3;
                cnvpr2 = Convert.ToInt32(cnvpr) * 8;
                label11.Text = cnvcan3 + "";
                label12.Text = cnvad + " " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
            }
            }



            else if (Convert.ToInt32(gmrlvtani2) > 39 && Convert.ToInt32(gmrlvtani2) <= 49)
                {
                    if (Convert.ToInt32(gmrlvtani2) == 40)
                    {
                        cnvcan3 = Convert.ToInt32(cnvcan) * 30;
                        cnvhsr2 = Convert.ToInt32(cnvhsr) * 8;
                        cnvlv2 = Convert.ToInt32(cnvlv) * 7;        //BOSS 40LV
                        cnvxp2 = Convert.ToInt32(cnvxp) * 10;
                        cnvpr2 = Convert.ToInt32(cnvpr) * 16;
                        label11.Text = cnvcan3 + "";
                        label12.Text = cnvad + " BOSS " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;

                    }
                    else { 
                    cnvcan3 = Convert.ToInt32(cnvcan) * 10;
                    cnvhsr2 = Convert.ToInt32(cnvhsr) * 10;
                    cnvlv2 = Convert.ToInt32(cnvlv) * 8;        //41-49LV YATARIK
                    cnvxp2 = Convert.ToInt32(cnvxp) * 2;
                    cnvpr2 = Convert.ToInt32(cnvpr) * 10;
                    label11.Text = cnvcan3 + "";
                    label12.Text = cnvad + " " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
                    }
                }
                

            
            else if (Convert.ToInt32(gmrlvtani2) > 49 && Convert.ToInt32(gmrlvtani2) <= 100)
            {
                if (Convert.ToInt32(gmrlvtani2) == 40|| Convert.ToInt32(gmrlvtani2) == 50 || Convert.ToInt32(gmrlvtani2) == 60 || Convert.ToInt32(gmrlvtani2) == 70
                        || Convert.ToInt32(gmrlvtani2) == 80 || Convert.ToInt32(gmrlvtani2) == 90 || Convert.ToInt32(gmrlvtani2) == 100)
                {
                    cnvcan3 = Convert.ToInt32(cnvcan) * 40;
                    cnvhsr2 = Convert.ToInt32(cnvhsr) * 10;
                    cnvlv2 = Convert.ToInt32(cnvlv) * 6;        //BOSS 40-100LV
                    cnvxp2 = Convert.ToInt32(cnvxp) * 6;
                    cnvpr2 = Convert.ToInt32(cnvpr) * 25;
                    label11.Text = cnvcan3 + "";
                    label12.Text = cnvad + " BOSS " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;

                }
                else
                {
                    cnvcan3 = Convert.ToInt32(cnvcan) * 5;
                    cnvhsr2 = Convert.ToInt32(cnvhsr) * 5;
                    cnvlv2 = Convert.ToInt32(cnvlv) * 2;        //41-49LV YATARIK
                    cnvxp2 = Convert.ToInt32(cnvxp) * 2;
                    cnvpr2 = Convert.ToInt32(cnvpr) * 5;
                    label11.Text = cnvcan3 + "";
                    label12.Text = cnvad + " " + cnvlv2 + "lv  " + cnvhsr2 + "hsr" + " " + cnvxp2;
                }
            }
                
                if (cnvno == 2) { pictureBox2.Image = Properties.Resources.slime2; }
            else if (cnvno == 3) { pictureBox2.Image = Properties.Resources.orkresim; }

        }
            else { MessageBox.Show("bozuk canavar"); }
            baglan2.Close();

        }
        public zindan()
        {
            
                InitializeComponent();
            
        }
        bool sesac;
        private void button2_Click(object sender, EventArgs e)
        {
            if (sesac == true)
            {
                System.Media.SoundPlayer player3 = new System.Media.SoundPlayer(Properties.Resources.attack3);
                player3.Play();
            }
            label14.Visible = false;
            baglan2.Open();
            OleDbDataReader sorgu4;

            int dnm2 = 1;
            string ara2 = ("Select*From kullanici_kayit WHERE kullanici_no=" + dnm2);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan2);
            emir2.ExecuteNonQuery();

            sorgu4 = emir2.ExecuteReader();


            if (sorgu4.Read() && sayac == 1)
            {

                gmrcan = Convert.ToInt32(sorgu4[5]);                                  // KRİTİK VUR TUŞUNUN ETKİLERİ
                gmrlv = Convert.ToInt32(sorgu4[3]);
                gmrxp = Convert.ToInt32(sorgu4[8]);
                gmrhsr = Convert.ToInt32(sorgu4[7]);
            }
            sayac++;
            baglan2.Close();
            Random random = new Random();
            int vurussans = random.Next(1, 11);
            if (vurussans > 5)
            {
                if (cnvcan2 > 0)
                {

                    cnvcan2 -= (gmrhsr*3)/2;

                    label11.Text = cnvcan2.ToString();
                    if (gmrcan == 10)
                    {
                        gmrcan -= cnvhsr2;

                        label8.Text = gmrcan.ToString();
                    }
                    else
                    {


                        label8.Text = (Convert.ToInt32(label8.Text) - cnvhsr2).ToString();

                    }




                }
                if (cnvcan2 <= 0)
                {
                    sunum2.Visible = true;
                    sunum2.Text = ("Tebrikler yaratık öldü");

                    label14.Text = ("Mağranın derinlerinlikten yeni bir yaratık geliyor");
                    label14.Visible = true;
                    cnvcan2 = Convert.ToInt32(cnvcan3);
                 
                    gmrxp += cnvxp2+5;
                    gmrpr2 += cnvpr2+5;
                    label8.Text = (Convert.ToInt32(label8.Text) + 4).ToString();

                    for (int i = 0; i < 3; i++)
                    {

                        if (gmrxp >= gmrxplv * gmrlv * 2 && Convert.ToInt32(gmrlvtani2) <= 9) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text = (gmrxplv * gmrlv * 2).ToString(); }
                        else if (gmrxp >= gmrxplv * gmrlv * 3 && Convert.ToInt32(gmrlvtani2) >= 10 && Convert.ToInt32(gmrlvtani2) <= 18) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text = (gmrxplv * gmrlv * 3).ToString(); }
                        else if (gmrxp >= gmrxplv * gmrlv * 6 && Convert.ToInt32(gmrlvtani2) >= 19 && Convert.ToInt32(gmrlvtani2) <= 28) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text = (gmrxplv * gmrlv * 8).ToString(); }
                        else if (gmrxp >= gmrxplv * gmrlv * 8 && Convert.ToInt32(gmrlvtani2) >= 29 && Convert.ToInt32(gmrlvtani2) <= 38) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text = (gmrxplv * gmrlv * 8).ToString(); }
                        else if (gmrxp >= gmrxplv * gmrlv * 11 && Convert.ToInt32(gmrlvtani2) >= 39 && Convert.ToInt32(gmrlvtani2) <= 48) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text = (gmrxplv * gmrlv * 12).ToString(); }
                        else if (gmrxp >= gmrxplv * gmrlv * 14 && Convert.ToInt32(gmrlvtani2) >= 49 && Convert.ToInt32(gmrlvtani2) <= 58) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text = (gmrxplv * gmrlv * 14).ToString(); }

                    }
                    //VUR TUŞUNUN ETKİLERİ CANAVAR ÖLÜMÜ

                    baglan2.Open();
                    string ara3 = ("UPDATE kullanici_kayit  set gamer_xp=@xp , kullanici_lv=@lv,kullanici_para=@para WHERE kullanici_no=@no");

                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                    emir3.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = gmrxp;
                    emir3.Parameters.AddWithValue("@lv", OleDbType.Integer).Value = gmrlv;
                    emir3.Parameters.AddWithValue("@para", OleDbType.Integer).Value = gmrpr2;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = dnm2;
                    label13.Text = gmrxp.ToString() + "XP";
                    label3.Text = gmrpr2.ToString() + "COİN";
                    emir3.ExecuteNonQuery();
                    baglan2.Close();



                }
                if (Convert.ToInt32(label8.Text) <= 0)
                {
                    OleDbDataReader sorgu3;
                    gmrxp -= cnvlv2 * 80;
                    MessageBox.Show("YARATIKTAN AĞIR BİR DARBE ALARAK ÖLDÜN YENİDEN CANLANMAK İÇİN XP FEDA ETMEN GEREKTİ");
                    baglan2.Open();
                    string ara3 = ("UPDATE kullanici_kayit  set gamer_xp=@xp  WHERE kullanici_no=@no");
                    string ara4 = ("Select*From kullanici_kayit WHERE kullanici_no=" + dnm2);
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                    OleDbCommand emir4 = new OleDbCommand(ara4, baglan2);                                               //VUR TUŞUNUN ETKİLERİ KARAKTER ÖLÜMÜ
                    sorgu3 = emir2.ExecuteReader();
                    if (sorgu3.Read())
                    { string gmrcan = sorgu3[5].ToString(); label8.Text = gmrcan;  
    }


                    emir3.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = gmrxp;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = dnm2;
                    label13.Text = gmrxp.ToString() + "XP";
                    emir3.ExecuteNonQuery();
                    baglan2.Close();
                    cnvcagir();
                }
            }
            else {
                label14.Text = "Hay aksi vuruşunu kaçırdın";
                label14.Visible = true;
                gmrcan -= cnvhsr2;

                label8.Text = gmrcan.ToString();




            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sesac == true)
            { 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.heal);
            player.Play();
            }
            Random random1 = new Random();
            int canavaryenileme = random1.Next(1, 11);
            if (canavaryenileme > 7)
            {
                label8.Text = (heal + 3).ToString();
                label14.Text = "KORUNMA BAŞARILI CANIN BİR MİKTAR DOLDU"; label14.Visible = true; // KORUMA TUŞU 
            }
            else { label14.Text = "KORUNMA BAŞARISIZ"; label14.Visible = true;

                if (gmrcan == 10)
                {
                    gmrcan -= cnvhsr2*2;

                    label8.Text = gmrcan.ToString();
                }
                else
                {


                    label8.Text = (Convert.ToInt32(label8.Text) - cnvhsr2*2).ToString();

                }
                if (Convert.ToInt32(label8.Text) <= 0)
                { 
                    OleDbDataReader sorgu3;
                    gmrxp -= cnvlv2 * 80;
                    MessageBox.Show("KORUNMAYA ÇALIŞIRKEN YARATIKTAN AĞIR BİR DARBE ALARAK ÖLDÜN YENİDEN CANLANMAK İÇİN XP FEDA ETMEN GEREKTİ");
                    baglan2.Open();
                    string ara3 = ("UPDATE kullanici_kayit  set gamer_xp=@xp  WHERE kullanici_no=@no");
                    string ara4 = ("Select*From kullanici_kayit WHERE kullanici_no=" + 1);
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                    OleDbCommand emir4 = new OleDbCommand(ara4, baglan2);                                               //KORUN TUŞUNUN ETKİLERİ KARAKTER ÖLÜMÜ
                    sorgu3 = emir4.ExecuteReader();
                    if (sorgu3.Read())
                    { string gmrcan = sorgu3[5].ToString(); label8.Text = gmrcan; }


                    emir3.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = gmrxp;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value =1;
                    label13.Text = gmrxp.ToString() + "XP";
                    emir3.ExecuteNonQuery();
                    baglan2.Close();
                    cnvcagir();
                }
            }
        }

        private void label8_TabIndexChanged(object sender, EventArgs e)
        {
        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
           
                heal = Convert.ToInt32(label8.Text);
           
            
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            koy koy = new koy();
            this.Hide();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel4.Visible = false;
            button4.Visible = false;//@emreyksln
        }

        private void hpot_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("İçmek İstermisin", "iksir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes&& Convert.ToInt32( iksr1.Text)>0)
            {
                label8.Text = (Convert.ToInt32(label8.Text) + 15).ToString();
                gmrcan = (Convert.ToInt32(label8.Text) + 15);
                baglan2.Open();
                OleDbDataReader sorgu6;
                string ara3 = ("Select*From crafts WHERE craft_no=" + 8);
                OleDbCommand emir4 = new OleDbCommand(ara3, baglan2);
                emir4.ExecuteNonQuery();
                sorgu6 = emir4.ExecuteReader();

                string kpot;
                int kpotint=0;
                if (sorgu6.Read())
                {
                    kpot = sorgu6[2].ToString();
                    kpotint = Convert.ToInt32(kpot);
                }
                baglan2.Close();
                baglan2.Open();
                string ara7 = ("UPDATE crafts  set craft_adet=@adet  WHERE craft_no=@no");
                kpotint--;
                OleDbCommand emir3 = new OleDbCommand(ara7, baglan2);
                emir3.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = kpotint;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 8;
                iksr1.Text = kpotint + "";
               
                emir3.ExecuteNonQuery();
                baglan2.Close();
            }
        }
        
        private void fishh_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Yemek İstermisin", "iksir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && Convert.ToInt32(iksr3.Text) > 0)
            {
                label8.Text = (Convert.ToInt32(label8.Text) + 10).ToString();
                gmrcan = (Convert.ToInt32(label8.Text) + 15);
                baglan2.Open();
                OleDbDataReader sorgu6;
                string ara3 = ("Select*From crafts WHERE craft_no=" + 10);
                OleDbCommand emir4 = new OleDbCommand(ara3, baglan2);
                emir4.ExecuteNonQuery();
                sorgu6 = emir4.ExecuteReader();
                int tavabalik = 0;
                string tvbalik;

                if (sorgu6.Read())
                {
                    tvbalik = sorgu6[2].ToString();
                    tavabalik = Convert.ToInt32(tvbalik);
                }
                baglan2.Close();
                baglan2.Open();
                string ara7 = ("UPDATE crafts  set craft_adet=@adet  WHERE craft_no=@no");
                tavabalik--;
                OleDbCommand emir3 = new OleDbCommand(ara7, baglan2);
                emir3.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = tavabalik;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 10;
                iksr3.Text = tavabalik + "";

                emir3.ExecuteNonQuery();
                baglan2.Close();
            }
        }

        int sayac = 1; //KARAKTERİN YETENEKLERİNİ SADECE 1 KEZ YENİLEMEK İÇİN
        int gmrcan = 0, gmrxp = 0, gmrhsr = 0, gmrlv = 0,gmrxplv=50, gmrpr2=0;

        private void yetenek1_Click(object sender, EventArgs e)
        {
            sunum2.Visible = false;
            label14.Visible = false;
            baglan2.Open();
            OleDbDataReader sorgu4;
            pictureBox2.Location = new Point(610, 116);
            pictureBox2.Location = new Point(588, 130);
            pictureBox2.Location = new Point(588, 116);


            string bos = (sesac.ToString());

            if (sesac == true)
            {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.attack);
                player.Play();
            }

            int dnm2 = 1;
            string ara2 = ("Select*From kullanici_kayit WHERE kullanici_no=" + dnm2);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan2);
            emir2.ExecuteNonQuery();

            sorgu4 = emir2.ExecuteReader();


            if (sorgu4.Read() && sayac == 1)
            {

                gmrcan = Convert.ToInt32(sorgu4[5]);                                  //VUR TUŞUNUN ETKİLERİ
                gmrlv = Convert.ToInt32(sorgu4[3]);
                gmrxp = Convert.ToInt32(sorgu4[8]);
                gmrhsr = Convert.ToInt32(sorgu4[7]);
            }
            sayac++;
            baglan2.Close();
            int gmrxpcopy = gmrxp;
            gmrxpcopy += cnvxp2 * (cnvlv2);
            if (cnvcan2 > 0)
            {

                cnvcan2 -= gmrhsr;

                label11.Text = cnvcan2.ToString();
                if (gmrcan == 10)
                {
                    gmrcan -= cnvhsr2;

                    label8.Text = gmrcan.ToString();
                }
                else
                {
                    label8.Text = (Convert.ToInt32(label8.Text) - cnvhsr2).ToString();} }
            if (cnvcan2 <= 0)
            {
                sunum2.Visible = true;
                sunum2.Text = ("Tebrikler yaratık öldü");
                if (sesac == true)
                {
                    System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Properties.Resources.monsterattack);
                    player2.Play();
                }

                label14.Text = ("Mağranın derinlerinlikten yeni bir yaratık geliyor");
                label14.Visible = true;
                cnvcan2 = Convert.ToInt32(cnvcan3);

                gmrxp += cnvxp2 * (cnvlv2);

                gmrpr2 += cnvpr2;
                label8.Text = (Convert.ToInt32(label8.Text) + 2).ToString();


                for (int i = lvartir; i <= 50;)
                {

                    if (gmrxp >= lvxp[i - 1]) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text = lvxp[i].ToString(); i = lvartir; lvartir++; }

                    break;
                }
                //VUR TUŞUNUN ETKİLERİ CANAVAR ÖLÜMÜ



                baglan2.Open();
                string ara3 = ("UPDATE kullanici_kayit  set gamer_xp=@xp , kullanici_lv=@lv,kullanici_para=@para WHERE kullanici_no=@no");

                OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                emir3.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = gmrxp;
                emir3.Parameters.AddWithValue("@lv", OleDbType.Integer).Value = gmrlv;
                emir3.Parameters.AddWithValue("@para", OleDbType.Integer).Value = gmrpr2;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = dnm2;
                label13.Text = gmrxp.ToString() + "XP";
                label3.Text = gmrpr2.ToString() + "COİN";
                emir3.ExecuteNonQuery();
                baglan2.Close();



            }
            if (Convert.ToInt32(label8.Text) <= 0)
            {
                OleDbDataReader sorgu3;
                gmrxp -= cnvlv2 * 80;
                MessageBox.Show("YARATIKTAN AĞIR BİR DARBE ALARAK ÖLDÜN YENİDEN CANLANMAK İÇİN XP FEDA ETMEN GEREKTİ");
                baglan2.Open();
                string ara3 = ("UPDATE kullanici_kayit  set gamer_xp=@xp  WHERE kullanici_no=@no");
                string ara4 = ("Select*From kullanici_kayit WHERE kullanici_no=" + dnm2);
                OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                OleDbCommand emir4 = new OleDbCommand(ara4, baglan2);                                               //VUR TUŞUNUN ETKİLERİ KARAKTER ÖLÜMÜ
                sorgu3 = emir2.ExecuteReader();
                if (sorgu3.Read())
                { string gmrcan = sorgu3[5].ToString(); label8.Text = gmrcan; }


                emir3.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = gmrxp;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = dnm2;
                label13.Text = gmrxp.ToString() + "XP";
                emir3.ExecuteNonQuery();
                baglan2.Close();
                cnvcagir();
            }

        }

        private void sesacbtn_Click(object sender, EventArgs e)
        {
            sesac = true;
            sesacbtn.Enabled = false;
            seskapbtn.Enabled = true;
        }

        private void seskapbtn_Click(object sender, EventArgs e)
        {
            sesac = false;
            seskapbtn.Enabled = false;
            sesacbtn.Enabled = true;
        }

        private void label11_TextChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(label11.Text) <= 0) { cnvcagir(); label13.Text = gmrxp.ToString();  }  //CANI DÜŞEN YARATIK XP KONTROL EDİP YENİLİYOR
        }
        
          
        private void button1_Click(object sender, EventArgs e)
        {
            

            sunum2.Visible = false;
            label14.Visible = false;
            baglan2.Open();
            OleDbDataReader sorgu4;
            pictureBox2.Location = new Point(610, 116);
            pictureBox2.Location = new Point(588, 130);
            pictureBox2.Location = new Point(588, 116);


           string bos=(sesac.ToString());

            if (sesac == true)
            { 
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.attack);
            player.Play();
            }

            int dnm2 = 1;
            string ara2 = ("Select*From kullanici_kayit WHERE kullanici_no=" + dnm2);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan2);
            emir2.ExecuteNonQuery();
            
            sorgu4 = emir2.ExecuteReader();
           
            
            if (sorgu4.Read()&&sayac==1)
            {
                 
                gmrcan = Convert.ToInt32(sorgu4[5]);                                  //VUR TUŞUNUN ETKİLERİ
                gmrlv = Convert.ToInt32(sorgu4[3]);
                gmrxp = Convert.ToInt32(sorgu4[8]);
                gmrhsr = Convert.ToInt32(sorgu4[7]);
            }
            sayac++;
            baglan2.Close();
            int gmrxpcopy=gmrxp;
            gmrxpcopy += cnvxp2 * (cnvlv2);

        

            if (cnvcan2 > 0)
            {
               
                cnvcan2 -= gmrhsr;
                
                label11.Text = cnvcan2.ToString();
                if (gmrcan == 10)
                {
                    gmrcan -= cnvhsr2;

                    label8.Text = gmrcan.ToString();
                }
                else {
                    

                    label8.Text = (Convert.ToInt32(label8.Text) - cnvhsr2).ToString();

                }

                



            }
           
                
          
               
            if (cnvcan2 <= 0) {
                sunum2.Visible = true;
                sunum2.Text=("Tebrikler yaratık öldü");
                if (sesac == true)
                { 
                System.Media.SoundPlayer player2 = new System.Media.SoundPlayer(Properties.Resources.monsterattack);
                player2.Play();
                }

                label14.Text=("Mağranın derinlerinlikten yeni bir yaratık geliyor");
                label14.Visible = true;
                cnvcan2 = Convert.ToInt32(cnvcan3);
                
                gmrxp += cnvxp2*(cnvlv2);
               
                gmrpr2 += cnvpr2;
                label8.Text = (Convert.ToInt32(label8.Text)+2).ToString();
                

                for (int i = lvartir; i <= 50; )
                    {
                  
                        if (gmrxp >= lvxp[i-1]) { gmrlv++; sunum2.Text = ("LV ATLADINIZ ARTIK ** " + gmrlv + "LV SİN"); label2.Text = gmrlv.ToString(); gerekenxp.Text =lvxp[i].ToString(); i=lvartir; lvartir++; }
                 
                    break;
                }  
                    //VUR TUŞUNUN ETKİLERİ CANAVAR ÖLÜMÜ



                    baglan2.Open();
                string ara3 = ("UPDATE kullanici_kayit  set gamer_xp=@xp , kullanici_lv=@lv,kullanici_para=@para WHERE kullanici_no=@no");
                
               OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                emir3.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = gmrxp;
                emir3.Parameters.AddWithValue("@lv", OleDbType.Integer).Value = gmrlv;
                emir3.Parameters.AddWithValue("@para", OleDbType.Integer).Value = gmrpr2;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = dnm2;
                label13.Text = gmrxp.ToString()+"XP";
                label3.Text = gmrpr2.ToString()+"COİN";
                emir3.ExecuteNonQuery();
                baglan2.Close();



            }
            if (Convert.ToInt32(label8.Text) <= 0)
            {
                OleDbDataReader sorgu3;
                gmrxp -= cnvlv2 * 80;
                MessageBox.Show("YARATIKTAN AĞIR BİR DARBE ALARAK ÖLDÜN YENİDEN CANLANMAK İÇİN XP FEDA ETMEN GEREKTİ");
                baglan2.Open();
                string ara3 = ("UPDATE kullanici_kayit  set gamer_xp=@xp  WHERE kullanici_no=@no");
                string ara4 = ("Select*From kullanici_kayit WHERE kullanici_no=" + dnm2);
                OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                OleDbCommand emir4= new OleDbCommand(ara4, baglan2);                                               //VUR TUŞUNUN ETKİLERİ KARAKTER ÖLÜMÜ
                sorgu3 = emir2.ExecuteReader();
                if (sorgu3.Read())
                { string gmrcan = sorgu3[5].ToString(); label8.Text = gmrcan; }
                    
               
                emir3.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = gmrxp;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = dnm2;
                label13.Text = gmrxp.ToString() + "XP";
                emir3.ExecuteNonQuery();
                baglan2.Close();
                cnvcagir();
            }


        }



        int[] lvxp = new int[59];
        private void zindan_Load(object sender, EventArgs e)
        {
            sesacbtn.Enabled = false;
            sesac = true;
            lvxp[0] = 100;
           
            for (int x = 1; x <= 8; x++)
            {
                lvxp[x] = lvxp[0] * (x + 1);
              
            }
            lvxp[9] = 2500;
            for (int x = 10; x <= 18; x++)
            {
                lvxp[x] = lvxp[9] + (500*(x-9));

            }
            lvxp[19] = 9000;
            for (int x = 20; x <= 28; x++)
            {
                lvxp[x] = lvxp[19] + (1000 * (x - 19));

            }
            lvxp[29] = 20000;
            for (int x = 30; x <= 38; x++)
            {
                lvxp[x] = lvxp[29] + (2000 * (x - 29));

            }
            lvxp[39] = 42000;
            for (int x = 40; x <= 48; x++)
            {
                lvxp[x] = lvxp[39] + (4000 * (x - 39));

            }
            lvxp[49] = 80000;
            for (int x = 50; x <= 58; x++)
            {
                lvxp[x] = lvxp[39] + (6000 * (x - 39));

            }


            cnvcagir();
           
            string[] iksirler = new string[3];
           for(int i=8;i<=10;i++)
            { 
            baglan2.Open();
            OleDbDataReader sorgu3;
            string ara3 = ("Select*From crafts WHERE  craft_no= " +i);
            OleDbCommand emir3 = new OleDbCommand(ara3, baglan2);
                emir3.ExecuteNonQuery();
                sorgu3 = emir3.ExecuteReader();
                if (sorgu3.Read())
                {
                    iksirler[i-8] = sorgu3[2].ToString();
                   
                }
                baglan2.Close();
            }
            
            iksr1.Text = iksirler[0];
            iksr2.Text = iksirler[1];
            iksr3.Text = iksirler[2];

            baglan2.Open();
           


            OleDbDataReader sorgu2;
            int dnm2 = 1;
            cnvcan2 = Convert.ToInt32(label11.Text);
            string ara2 = ("Select*From kullanici_kayit WHERE kullanici_no=" + dnm2);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan2);
            emir2.ExecuteNonQuery();

            sorgu2 = emir2.ExecuteReader();
            
            if (sorgu2.Read())
            {
                string gmrad, gmrcan, gmrxp, gmrlv, gmrhsr,gmrpr,gmrmana;
                gmrad = sorgu2[1].ToString();
                gmrcan = sorgu2[5].ToString();
                gmrpr = sorgu2[4].ToString();
                gmrlv = sorgu2[3].ToString();
                gmrxp = sorgu2[8].ToString();
                gmrhsr = sorgu2[7].ToString();
                gmrmana = sorgu2[6].ToString();                                               // ZİNDANA GİRİLDİĞİNDE KARAKTER ÖZELİKLERİNİ GETİREN KOD
                label1.Text = gmrad;
                label2.Text = gmrlv+"LV";
                label3.Text = gmrpr+"COİN";
                gmrpr2 =Convert.ToInt32( gmrpr);
                lvartir =Convert.ToInt32( gmrlv);
                label13.Text = gmrxp+"XP";
                label8.Text = gmrcan;
                label9.Text = gmrmana;
                
                gerekenxp.Text = lvxp[lvartir - 1].ToString();
               

            }
            else { MessageBox.Show("bozuk canavar"); }
            baglan2.Close();
           

        }
        int lvartir;
    }
}
