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
    public partial class envanter : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider =  Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        public envanter()
        {
            InitializeComponent();
        }
        int hangizırh = 0;
        string zırhsay ="?";
        private void setkontrol()
        {
           
            
            baglan.Open();
            OleDbDataReader sorgu3;
            string ara8 = ("Select*From crafts WHERE  craft_no= " + hangizırh);
            OleDbCommand emir7 = new OleDbCommand(ara8, baglan);
            emir7.ExecuteNonQuery();
            sorgu3 = emir7.ExecuteReader();
            if (sorgu3.Read())
            {

                zırhsay = sorgu3[2].ToString();
                                                            //ZIRHLARI SAYMMAK İÇİN


            }

            baglan.Close();
            

        }
        int craftno = 0;
        bool giycikart;
        private void giycikar()
        {
           

           

            baglan.Open();
            string ara5 = ("UPDATE crafts set craft_aktif=@aktif WHERE craft_no=@no");
            OleDbCommand emir5 = new OleDbCommand(ara5, baglan);

            emir5.Parameters.AddWithValue("@aktif", OleDbType.Boolean).Value = giycikart;
            emir5.Parameters.AddWithValue("@no", OleDbType.Integer).Value = craftno;
            emir5.ExecuteNonQuery();
            baglan.Close();


        }



        string can;
        int cancık = 0;

        private void candegis()
        {
            baglan.Open();
            OleDbDataReader sorgu2;
            string ara = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir6 = new OleDbCommand(ara, baglan);
            emir6.ExecuteNonQuery();
            sorgu2 = emir6.ExecuteReader();
            if (sorgu2.Read())
            {
                can = sorgu2[5].ToString();
                
            }
            baglan.Close();

            can = (Convert.ToInt32(can) + cancık).ToString();

            baglan.Open();
            string ara5 = ("UPDATE kullanici_kayit set gamer_can=@can WHERE kullanici_no=@no");
            OleDbCommand emir5 = new OleDbCommand(ara5, baglan);

            emir5.Parameters.AddWithValue("@can", OleDbType.Integer).Value = can;
            emir5.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
            emir5.ExecuteNonQuery();
            baglan.Close();



        }
        string hasar;
        int hasarcık = 0;
        private void hasardegis()
        {
            baglan.Open();
            OleDbDataReader sorgu2;
            string ara = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir6 = new OleDbCommand(ara, baglan);
            emir6.ExecuteNonQuery();
            sorgu2 = emir6.ExecuteReader();
            if (sorgu2.Read())
            {
                hasar = sorgu2[7].ToString();

            }
            baglan.Close();

            hasar = (Convert.ToInt32(hasar) + hasarcık).ToString();

            baglan.Open();
            string ara5 = ("UPDATE kullanici_kayit set gamer_hasar=@hasar WHERE kullanici_no=@no");
            OleDbCommand emir5 = new OleDbCommand(ara5, baglan);

            emir5.Parameters.AddWithValue("@hasar", OleDbType.Integer).Value = hasar;
            emir5.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
            emir5.ExecuteNonQuery();
            baglan.Close();



        }

        private void button6_Click(object sender, EventArgs e)
        {
            craft craft = new craft();

            craft.Show();
        }
        string demir, silver, yakut, kcicek, mcicek, mantar, balik, inci;

        private void envanterres15_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 13;
            setkontrol();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ", "KOLYE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && kolyeres.Visible == false && Convert.ToInt32(zırhsay) <= 0)
            {
                kolyeres.Visible = true;
                cancık = 7;
                candegis();
                hasarcık = 1;
                hasardegis();
                giycikart = true;
                craftno = 5;
                giycikar();




            }
            else if (secim == DialogResult.Yes && kolyeres.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                kolyeres.Image = Properties.Resources.gkolye;
                kolyeres.Visible = true;
                cancık = 15;
                candegis();
                hasarcık = 2;
                hasardegis();
                giycikart = true;
                craftno = 16;
                giycikar();


            }
        }

        private void kolyeres_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 13;
            setkontrol();
            secim = MessageBox.Show("ÇIKARMAK İSTERMİSİNİZ", "KOLYE", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && kolyeres.Visible == true)
            {
                kolyeres.Visible = false;
                cancık = -7;
                candegis();
                hasarcık = -1;
                hasardegis();
                giycikart = false;
                craftno = 5;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kolyeres.Visible == true && Convert.ToInt32(zırhsay) > 0)
            {
                kolyeres.Image = Properties.Resources.gkolye;
                kolyeres.Visible = false;
                cancık = -15;
                candegis();
                hasarcık = -2;
                hasardegis();
                giycikart = false;
                craftno = 16;
                giycikar();


            }
        }

        private void envanterres16_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 13;
            setkontrol();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ", "BİLEZİK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && bilezikres.Visible == false && Convert.ToInt32(zırhsay) <= 0)
            {
                bilezikres.Visible = true;
                cancık = 2;
                candegis();
                hasarcık = 2;
                hasardegis();
                giycikart = true;
                craftno = 6;
                giycikar();


            }
            else if (secim == DialogResult.Yes && bilezikres.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                bilezikres.Image = Properties.Resources.gbilezik;
                bilezikres.Visible = true;
                cancık = 12;
                candegis();
                hasarcık = 3;
                hasardegis();
                giycikart = true;
                craftno = 17;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void bilezikres_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 13;
            setkontrol();
            secim = MessageBox.Show("ÇIKARMAK İSTERMİSİNİZ", "BİLEZİK", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && bilezikres.Visible == true)
            {
                bilezikres.Visible = false;
                cancık = -2;
                candegis();
                hasarcık = -2;
                hasardegis();
                giycikart = false;
                craftno = 6;
                giycikar();


            }
            else if (secim == DialogResult.Yes && bilezikres.Visible == true && Convert.ToInt32(zırhsay) > 0)
            {
                bilezikres.Image = Properties.Resources.gbilezik;
                bilezikres.Visible = false;
                cancık = -12;
                candegis();
                hasarcık = 3;
                hasardegis();
                giycikart = false;
                craftno = 17;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }
        //https://github.com/Lasque28

        private void ayakres_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 18;
            setkontrol();
            secim = MessageBox.Show("ÇIKARMAK İSTERMİSİNİZ", "AYAKKABI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && ayakres.Visible == true)
            {
                ayakres.Visible = false;
                cancık = -5;
                candegis();
                giycikart = false;
                craftno = 7;
                giycikar();


            }
               else if (secim == DialogResult.Yes && ayakres.Visible == true && Convert.ToInt32(zırhsay) > 0)
            {
                ayakres.Image = Properties.Resources.gayak;
                ayakres.Visible = false;
                cancık = -15;
                candegis();
                giycikart = false;
                craftno = 18;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void envanterres17_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 18;
            setkontrol();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ", "AYAKKABI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && ayakres.Visible == false && Convert.ToInt32(zırhsay) <=0)
            {
                ayakres.Visible = true;
                cancık = 5;
                candegis();
                giycikart = true;
                craftno = 7;
                giycikar();


            }
            else if (secim == DialogResult.Yes && ayakres.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                ayakres.Image = Properties.Resources.gayak;
                ayakres.Visible = true;
                cancık = 15;
                candegis();
                giycikart = true;
                craftno = 18;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            


        }

        private void envanter_Click(object sender, EventArgs e)
        {
            string sorgula;
            int topla = 0;


            Boolean[] sorgulama = new bool[25];
            for (int i = 0; i <= 25; i++)
            {
                topla = i + 2;
                baglan.Open();
                OleDbDataReader sorgu3;
                string ara8 = ("Select*From crafts WHERE  craft_no= " + topla);
                OleDbCommand emir7 = new OleDbCommand(ara8, baglan);
                emir7.ExecuteNonQuery();
                sorgu3 = emir7.ExecuteReader();
                if (sorgu3.Read())
                {

                    sorgula = sorgu3[16].ToString();
                    sorgulama[i] = Convert.ToBoolean(sorgula);                                             //ZIRHLAR GİYİLMİŞMİ DİYE KONTROL ET


                }

                baglan.Close();
            }


            if (sorgulama[0] == true) { kaskres.Visible = true; }
            if (sorgulama[1] == true) { zırhres.Visible = true; }
            if (sorgulama[2] == true) { kılıcres.Visible = true; }
            if (sorgulama[3] == true) { kolyeres.Visible = true; }
            if (sorgulama[4] == true) { bilezikres.Visible = true; }
            if (sorgulama[5] == true) { ayakres.Visible = true; }
            if (sorgulama[9] == true) { kalkanres.Visible = true; }
            if (sorgulama[10] == true) { kuperes.Visible = true; }
            if (sorgulama[11] == true) { kaskres.Visible = true; kaskres.Image = Properties.Resources.ghelmet; }
            if (sorgulama[12] == true) { zırhres.Visible = true; zırhres.Image = Properties.Resources.garmor; }
            if (sorgulama[13] == true) { kılıcres.Visible = true; kılıcres.Image = Properties.Resources.gsword; }
            if (sorgulama[14] == true) { kolyeres.Visible = true; kolyeres.Image = Properties.Resources.gkolye; }
            if (sorgulama[15] == true) { bilezikres.Visible = true; bilezikres.Image = Properties.Resources.gbilezik; }
            if (sorgulama[16] == true) { ayakres.Visible = true; ayakres.Image = Properties.Resources.gayak; }
            if (sorgulama[17] == true) { kalkanres.Visible = true; kalkanres.Image = Properties.Resources.gkalkan; }
            if (sorgulama[18] == true) { kuperes.Visible = true; kuperes.Image = Properties.Resources.gküpe; }
            can = (Convert.ToInt32(can) + cancık).ToString();








            baglan.Open();
            OleDbDataReader sorgu;
            string ara2 = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan);
            emir2.ExecuteNonQuery();
            sorgu = emir2.ExecuteReader();
            if (sorgu.Read())
            {

                demir = sorgu[11].ToString();

                silver = sorgu[12].ToString();
                yakut = sorgu[13].ToString();
                kcicek = sorgu[14].ToString();
                mcicek = sorgu[15].ToString();
                mantar = sorgu[16].ToString();
                balik = sorgu[9].ToString();
                inci = sorgu[10].ToString(); // KAZANILANLARI KAYDETME

            }
            else { MessageBox.Show("DEMİRLER YOLDA KAYBOLDU"); }
            baglan.Close();
            if (Convert.ToInt32(demir) > 0) { envanterres1.Image = Properties.Resources.ironbar; res1.Text = demir; envanterres1.Visible = true; res1.Visible = true; }
            if (Convert.ToInt32(silver) > 0) { envanterres2.Image = Properties.Resources.silverbar; res2.Text = silver; envanterres2.Visible = true; res2.Visible = true; }
            if (Convert.ToInt32(yakut) > 0) { envanterres3.Image = Properties.Resources.yakut; res3.Text = yakut; envanterres3.Visible = true; res3.Visible = true; }
            if (Convert.ToInt32(kcicek) > 0) { envanterres4.Image = Properties.Resources.cicek2; res4.Text = kcicek; envanterres4.Visible = true; res4.Visible = true; }
            if (Convert.ToInt32(mcicek) > 0) { envanterres5.Image = Properties.Resources.cicek3; res5.Text = mcicek; envanterres5.Visible = true; res5.Visible = true; }
            if (Convert.ToInt32(mantar) > 0) { envanterres6.Image = Properties.Resources.mantar; res6.Text = mantar; envanterres6.Visible = true; res6.Visible = true; }
            if (Convert.ToInt32(balik) > 0) { envanterres7.Image = Properties.Resources.fish; res7.Text = balik; envanterres7.Visible = true; res7.Visible = true; }
            if (Convert.ToInt32(inci) > 0) { envanterres8.Image = Properties.Resources.inci; res8.Text = inci; envanterres8.Visible = true; res8.Visible = true; }

            string kask, zırh, kilic, kolye, bzik, kpot, mpot;
            string[] say = new string[9];
            int syc = 0;
            for (int i = 2; i <= 9; i++)
            {
                baglan.Open();
                OleDbDataReader sorgu2;
                string ara = ("Select*From crafts WHERE  craft_no= " + i);
                OleDbCommand emir6 = new OleDbCommand(ara, baglan);
                emir6.ExecuteNonQuery();
                sorgu2 = emir6.ExecuteReader();
                if (sorgu2.Read())
                {
                    say[i - 2] = sorgu2[2].ToString();


                }
                baglan.Close();
            }

            if (Convert.ToInt32(say[0]) > 0) { envanterres12.Image = Properties.Resources.helmet; envanterres12.Visible = true; }
            if (Convert.ToInt32(say[1]) > 0) { envanterres13.Image = Properties.Resources.armorr; envanterres13.Visible = true; }
            if (Convert.ToInt32(say[2]) > 0) { envanterres14.Image = Properties.Resources.sword; envanterres14.Visible = true; }
            if (Convert.ToInt32(say[3]) > 0) { envanterres15.Image = Properties.Resources.neckle; envanterres15.Visible = true; }
            if (Convert.ToInt32(say[4]) > 0) { envanterres16.Image = Properties.Resources.bilezik; envanterres16.Visible = true; }
            if (Convert.ToInt32(say[5]) > 0) { envanterres17.Image = Properties.Resources.armor2; envanterres17.Visible = true; }
            if (Convert.ToInt32(say[6]) > 0) { envanterres23.Image = Properties.Resources.healpotion; envanterres23.Visible = true; res23.Text = say[6]; res23.Visible = true; }
            if (Convert.ToInt32(say[7]) > 0) { envanterres24.Image = Properties.Resources.manapotion; envanterres24.Visible = true; res24.Text = say[7]; res24.Visible = true; }
            if (Convert.ToInt32(say[8]) > 0) { envanterres25.Image = Properties.Resources.pismisbalik; envanterres25.Visible = true; res25.Text = say[8]; res25.Visible = true; }

        }

        private void envanterres12_Click(object sender, EventArgs e)
        {

        }

        private void envanterres18_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ", "Kalkan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            hangizırh = 19;
            setkontrol();
            if (secim == DialogResult.Yes && kalkanres.Visible == false && Convert.ToInt32(zırhsay) <= 0)
            {
                kalkanres.Visible = true;
                cancık = 20;
                candegis();
                giycikart = true;
                craftno = 11;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kalkanres.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                kalkanres.Image = Properties.Resources.gkalkan;
                kalkanres.Visible = true;
                cancık = 40;
                candegis();
                giycikart = true;
                craftno = 19;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void kalkanres_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("ÇIKARMAK İSTERMİSİNİZ", "Kalkan", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            hangizırh = 19;
            setkontrol();
            if (secim == DialogResult.Yes && kalkanres.Visible == true )
            {
                kalkanres.Visible = false;
                cancık = -20;
                candegis();
                giycikart = false;
                craftno = 11;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kalkanres.Visible == true && Convert.ToInt32(zırhsay) > 0 )
            {
                
                kalkanres.Visible = false;
                cancık = -40;
                candegis();
                giycikart = false;
                craftno = 19;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void kuperes_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("ÇIKARMAK İSTERMİSİNİZ", "Küpe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            hangizırh = 20;
            setkontrol();
            if (secim == DialogResult.Yes && kuperes.Visible == true && Convert.ToInt32(zırhsay) <= 0)
            {
                kuperes.Visible = false;
                cancık = -15;
                candegis();
                hasarcık = -2;
                hasardegis();
                giycikart = false;
                craftno = 12;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kuperes.Visible == true && Convert.ToInt32(zırhsay) > 0)
            {
                
                kuperes.Visible = false;
                cancık = -30;
                candegis();
                hasarcık = -4;
                hasardegis();
                giycikart = false;
                craftno = 20;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void envanterres19_Click(object sender, EventArgs e)
        {

            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ", "Küpe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            hangizırh = 20;
            setkontrol();
            if (secim == DialogResult.Yes && kuperes.Visible == false&& Convert.ToInt32(zırhsay) <= 0)
            {
                kuperes.Visible = true;
                cancık = 15;
                candegis();
                hasarcık = 2;
                hasardegis();
                giycikart = true;
                craftno = 12;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kuperes.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                kuperes.Image = Properties.Resources.gküpe;
                kuperes.Visible = true;
                cancık = 30;
                candegis();
                hasarcık = 4;
                hasardegis();
                giycikart = true;
                craftno = 20;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void envanter_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("BUG DÜZELTMEK İSTERMİSİN", "KILIÇ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && kılıcres.Visible == true)
            {
               
                kılıcres.Visible = false;
                zırhres.Visible = false;
            kaskres.Visible = false;
                kuperes.Visible = false;
                kalkanres.Visible = false;
                ayakres.Visible = false;
                kolyeres.Visible = false;


            }
          

        }
        //https://github.com/Lasque28
        private void kılıcres_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("ÇIKARMA İSTERMİSİNİZ", "KILIÇ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && kılıcres.Visible == true )
            {
                kılıcres.Visible = false;
                hasarcık = -3;
                hasardegis();
                giycikart = false;
                craftno = 4;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kılıcres.Visible == true && Convert.ToInt32(zırhsay) > 0)
            {

                kılıcres.Visible = false;
                hasarcık = -9;
                hasardegis();
                giycikart = false;
                craftno = 4;
                giycikar();
                giycikart = false;
                craftno = 15;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void envanterres14_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 15;
            setkontrol();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ", "KILIÇ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && kılıcres.Visible ==false && Convert.ToInt32(zırhsay) <= 0)
            {
                kılıcres.Visible = true;
                hasarcık=3;
                hasardegis();
                giycikart = true;
                craftno = 4;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kılıcres.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                kılıcres.Image = Properties.Resources.gsword;
                kılıcres.Visible = true;
                hasarcık = 9;
                hasardegis();
                giycikart = true;
                craftno = 15;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }

        }

        private void zırhres_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 14;
            setkontrol();
            secim = MessageBox.Show("ÇIKARMAK İSTERMİSİNİZ", "Zırh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && zırhres.Visible == true && Convert.ToInt32(zırhsay) <= 0)
            {
                zırhres.Visible = false;
                cancık = -10;
                candegis();
                giycikart = false;
                craftno = 3;
                giycikar();
            }
            else if (secim == DialogResult.Yes && zırhres.Visible == true && Convert.ToInt32(zırhsay) > 0)
            {
               
                zırhres.Visible = false;
                cancık = -25;
                candegis();
                giycikart = false;
                craftno = 3;
                giycikar();
                giycikart = false;
                craftno = 14;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }
        //https://github.com/Lasque28
        private void envanterres13_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            hangizırh = 14;
            setkontrol();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ", "Zırh", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (secim == DialogResult.Yes && zırhres.Visible == false && Convert.ToInt32(zırhsay) <= 0)
            {
                zırhres.Visible = true;
                cancık = 10;
                candegis();
                giycikart = true;
                craftno = 3;
                giycikar();


            }
            else if (secim == DialogResult.Yes && zırhres.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                zırhres.Image = Properties.Resources.garmor;
                zırhres.Visible = true;
                cancık = 25;
                candegis();
                giycikart = true;
                craftno = 14;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        private void kaskres_Click(object sender, EventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("ÇIKARMAK İSTERMİSİNİZ", "Kask", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            hangizırh = 13;
            setkontrol();
            if (secim == DialogResult.Yes && kaskres.Visible == true && Convert.ToInt32(zırhsay) <= 0)
            {
                kaskres.Visible = false;
                cancık = -5;
                candegis();
                giycikart = false;
                craftno = 2;
                giycikar();


            }
            else if (secim == DialogResult.Yes && kaskres.Visible == true && Convert.ToInt32(zırhsay) > 0)
            {
                kaskres.Visible = false;
                cancık = -15;
                candegis();
                giycikart = false;
                craftno = 2;
                giycikar();
                giycikart = false;
                craftno = 13;
                giycikar();


            }
            else { MessageBox.Show("NASIL BURAYA GELDİN BURDA OLMAMAN GEREK"); }

        }

        private void envanterres12_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("GİYMEK İSTERMİSİNİZ","Kask", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            hangizırh = 13;
            setkontrol();
            if(secim==DialogResult.Yes&&kaskres.Visible==false&&Convert.ToInt32( zırhsay)<=0)
            {
                kaskres.Visible = true;
                cancık = 5;
                candegis();
                giycikart = true;
                craftno = 2;
                giycikar();
               

            }
            else if(secim == DialogResult.Yes && kaskres.Visible == false && Convert.ToInt32(zırhsay) > 0)
            {
                kaskres.Image = Properties.Resources.ghelmet;
                kaskres.Visible = true;
                cancık = 15;
                candegis();
                giycikart = true;
                craftno = 13;
                giycikar();


            }
            else { MessageBox.Show("ZATEN GİYİLİ"); }
        }

        public void envanter_Load(object sender, EventArgs e)
        {
            string sorgula;
            int topla=0;

           
            Boolean[] sorgulama = new bool[30];
            for (int i = 0; i <= 30; i++)
            {
                topla = i + 2;
                baglan.Open();
            OleDbDataReader sorgu3;
            string ara8 = ("Select*From crafts WHERE  craft_no= " + topla);
            OleDbCommand emir7 = new OleDbCommand(ara8, baglan);
            emir7.ExecuteNonQuery();
            sorgu3 = emir7.ExecuteReader();
                if (sorgu3.Read())
                {

                    sorgula = sorgu3[16].ToString();
                    sorgulama[i] =Convert.ToBoolean( sorgula);                                             //ZIRHLAR GİYİLMİŞMİ DİYE KONTROL ET
                    

                }
                 //https://github.com/Lasque28
                
            baglan.Close();
            }
          
            if (sorgulama[0] == true) { kaskres.Visible = true; }
            if (sorgulama[1] == true) { zırhres.Visible = true; } 
            if (sorgulama[2] == true) { kılıcres.Visible = true; } 
            if (sorgulama[3] == true) { kolyeres.Visible = true; } 
            if (sorgulama[4] == true) { bilezikres.Visible = true; } 
            if (sorgulama[5] == true) { ayakres.Visible = true; }
            if (sorgulama[9] == true) { kalkanres.Visible = true;  }
            if (sorgulama[10] == true) { kuperes.Visible = true; }
            if (sorgulama[11] == true) { kaskres.Visible = true; kaskres.Image = Properties.Resources.ghelmet; }
            if (sorgulama[12] == true) { zırhres.Visible = true; zırhres.Image = Properties.Resources.garmor; }
            if (sorgulama[13] == true) { kılıcres.Visible = true; kılıcres.Image = Properties.Resources.gsword; }
            if (sorgulama[14] == true) { kolyeres.Visible = true; kolyeres.Image = Properties.Resources.gkolye; }
            if (sorgulama[15] == true) { bilezikres.Visible = true; bilezikres.Image = Properties.Resources.gbilezik; }
            if (sorgulama[16] == true) { ayakres.Visible = true; ayakres.Image = Properties.Resources.gayak; }
            if (sorgulama[17] == true) { kalkanres.Visible = true; kalkanres.Image = Properties.Resources.gkalkan; }
            if (sorgulama[18] == true) { kuperes.Visible = true; kuperes.Image = Properties.Resources.gküpe; }


            can = (Convert.ToInt32(can) + cancık).ToString();

           






            baglan.Open();
            OleDbDataReader sorgu;
            string ara2 = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
            OleDbCommand emir2 = new OleDbCommand(ara2, baglan);
            emir2.ExecuteNonQuery();
            sorgu = emir2.ExecuteReader();
            if (sorgu.Read())
            {

                demir = sorgu[11].ToString();

                silver = sorgu[12].ToString();
                yakut = sorgu[13].ToString();
                kcicek = sorgu[14].ToString();
                mcicek = sorgu[15].ToString();
                mantar = sorgu[16].ToString();
                balik = sorgu[9].ToString();
                inci = sorgu[10].ToString(); // KAZANILANLARI KAYDETME

            }
            else { MessageBox.Show("DEMİRLER YOLDA KAYBOLDU"); }
            baglan.Close();
            if (Convert.ToInt32(demir) > 0) { envanterres1.Image = Properties.Resources.ironbar; res1.Text = demir; envanterres1.Visible = true; res1.Visible = true; }
            if (Convert.ToInt32(silver) > 0) { envanterres2.Image = Properties.Resources.silverbar; res2.Text = silver; envanterres2.Visible = true; res2.Visible = true; }
            if (Convert.ToInt32(yakut) > 0) { envanterres3.Image = Properties.Resources.yakut; res3.Text = yakut; envanterres3.Visible = true; res3.Visible = true; }
            if (Convert.ToInt32(kcicek) > 0) { envanterres4.Image = Properties.Resources.cicek2; res4.Text = kcicek; envanterres4.Visible = true; res4.Visible = true; }
            if (Convert.ToInt32(mcicek) > 0) { envanterres5.Image = Properties.Resources.cicek3; res5.Text = mcicek; envanterres5.Visible = true; res5.Visible = true; }
            if (Convert.ToInt32(mantar) > 0) { envanterres6.Image = Properties.Resources.mantar; res6.Text = mantar; envanterres6.Visible = true; res6.Visible = true; }
            if (Convert.ToInt32(balik) > 0) { envanterres7.Image = Properties.Resources.fish; res7.Text = balik; envanterres7.Visible = true; res7.Visible = true; }
            if (Convert.ToInt32(inci) > 0) { envanterres8.Image = Properties.Resources.inci; res8.Text = inci; envanterres8.Visible = true; res8.Visible = true; }

            string kask, zırh, kilic, kolye, bzik, kpot, mpot;
            string[] say = new string[22];
            int syc = 0;
            for (int i = 2; i <= 25; i++)
            {
                baglan.Open();
                OleDbDataReader sorgu2;
                string ara = ("Select*From crafts WHERE  craft_no= " + i);
                OleDbCommand emir6 = new OleDbCommand(ara, baglan);
                emir6.ExecuteNonQuery();
                sorgu2 = emir6.ExecuteReader();
                if (sorgu2.Read())
                {
                    say[i-2] = sorgu2[2].ToString();
                   
                    
                }
                baglan.Close();
            }//@emreyksln

            if (Convert.ToInt32(say[0]) > 0) { envanterres12.Image = Properties.Resources.helmet; envanterres12.Visible = true; }
            if (Convert.ToInt32(say[1]) > 0) { envanterres13.Image = Properties.Resources.armorr; envanterres13.Visible = true; }
            if (Convert.ToInt32(say[2]) > 0){ envanterres14.Image = Properties.Resources.sword; envanterres14.Visible = true; }
            if (Convert.ToInt32(say[3]) > 0){ envanterres15.Image = Properties.Resources.neckle; envanterres15.Visible = true; }
            if (Convert.ToInt32(say[4]) > 0){ envanterres16.Image = Properties.Resources.bilezik; envanterres16.Visible = true; }
            if (Convert.ToInt32(say[5]) > 0){ envanterres17.Image = Properties.Resources.armor2; envanterres17.Visible = true; }
            if (Convert.ToInt32(say[6]) > 0) { envanterres23.Image = Properties.Resources.healpotion; envanterres23.Visible = true;res23.Text = say[6]; res23.Visible = true; }
            if (Convert.ToInt32(say[7]) > 0) { envanterres24.Image = Properties.Resources.manapotion; envanterres24.Visible = true; res24.Text = say[7]; res24.Visible = true; }
            if (Convert.ToInt32(say[8]) > 0) { envanterres25.Image = Properties.Resources.pismisbalik; envanterres25.Visible = true; res25.Text = say[8]; res25.Visible = true; }
            res23.Visible = true;
            if (Convert.ToInt32(say[9]) > 0) { envanterres18.Image = Properties.Resources.shild; envanterres18.Visible = true; }
            if (Convert.ToInt32(say[10]) > 0) { envanterres19.Image = Properties.Resources.küpe; envanterres19.Visible = true; }
            if (Convert.ToInt32(say[11]) > 0) { envanterres12.Image = Properties.Resources.ghelmet; envanterres12.Visible = true; }
            if (Convert.ToInt32(say[12]) > 0) { envanterres13.Image = Properties.Resources.garmor; envanterres13.Visible = true; }
            if (Convert.ToInt32(say[13]) > 0) { envanterres14.Image = Properties.Resources.gsword; envanterres14.Visible = true; }
            if (Convert.ToInt32(say[14]) > 0) { envanterres15.Image = Properties.Resources.gkolye; envanterres15.Visible = true; }
            if (Convert.ToInt32(say[15]) > 0) { envanterres16.Image = Properties.Resources.gbilezik; envanterres16.Visible = true; }
            if (Convert.ToInt32(say[16]) > 0) { envanterres17.Image = Properties.Resources.gayak; envanterres17.Visible = true; }
            if (Convert.ToInt32(say[17]) > 0) { envanterres18.Image = Properties.Resources.gkalkan; envanterres17.Visible = true; }
            if (Convert.ToInt32(say[18]) > 0) { envanterres19.Image = Properties.Resources.gküpe; envanterres17.Visible = true; }

            //https://github.com/Lasque28
        }
    }
}
