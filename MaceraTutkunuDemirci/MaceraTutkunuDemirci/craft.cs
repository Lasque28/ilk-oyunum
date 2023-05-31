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
    public partial class craft : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider =  Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        public craft()
        {
            InitializeComponent();
        }
        int no = 0;
        int adetint = 0;
        private void yenile()
        {
            envanter envanter = new envanter();
           


        }
        private void adetata(){
            string adet = "";
            
            
            baglan.Open();
            OleDbDataReader sorgu2;
            string ara = ("Select*From crafts WHERE  craft_no= " + no);
            OleDbCommand emir6 = new OleDbCommand(ara, baglan);
            emir6.ExecuteNonQuery();
            sorgu2 = emir6.ExecuteReader();
            if (sorgu2.Read())
            {
                adet = sorgu2[2].ToString();
                adetint = Convert.ToInt32(adet);
            }
            baglan.Close();
           
            adetint++;

            baglan.Open();
            string ara5 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
            OleDbCommand emir5 = new OleDbCommand(ara5, baglan);
          
            emir5.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adetint;
            emir5.Parameters.AddWithValue("@no", OleDbType.Integer).Value = no;
            emir5.ExecuteNonQuery();
            baglan.Close();



        } //https://github.com/Lasque28

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            itemana.Image = Properties.Resources.bos;
            item1.Image = Properties.Resources.bos;
            item2.Image = Properties.Resources.bos;
            item3.Image = Properties.Resources.bos;
            item4.Image = Properties.Resources.bos;
            if (comboBox1.SelectedIndex == 0) { item1.Image = Properties.Resources.ironbar;item1s1.Text = "5"; item2.Image = Properties.Resources.coin;item2s2.Text = "100"; itemana.Image = Properties.Resources.helmet;item3s3.Text = "0";item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 1) { item1.Image = Properties.Resources.ironbar; item1s1.Text = "10"; itemana.Image = Properties.Resources.armorr; item2.Image = Properties.Resources.coin; item2s2.Text = "100"; item3s3.Text = "0"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 2) { item1.Image = Properties.Resources.ironbar; item1s1.Text = "10"; item2.Image = Properties.Resources.inci; item2s2.Text = "1"; itemana.Image = Properties.Resources.sword; item3.Image = Properties.Resources.coin; item3s3.Text = "100"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 3) { item1.Image = Properties.Resources.ironbar; item1s1.Text = "3"; item2.Image = Properties.Resources.inci; item2s2.Text = "3"; itemana.Image = Properties.Resources.neckle; item3.Image = Properties.Resources.coin; item3s3.Text = "100"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 4) { item1.Image = Properties.Resources.ironbar; item1s1.Text = "3"; item2.Image = Properties.Resources.yakut;item2s2.Text = "2"; item3.Image = Properties.Resources.mantar;item3s3.Text = "2"; itemana.Image = Properties.Resources.bilezik; item4.Image = Properties.Resources.coin; item4s4.Text = "100"; }
            if (comboBox1.SelectedIndex == 5) { item1.Image = Properties.Resources.ironbar; item1s1.Text = "5"; itemana.Image = Properties.Resources.armor2; item2.Image = Properties.Resources.coin; item2s2.Text = "100"; item3s3.Text = "0"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 6) { item1.Image = Properties.Resources.cicek2; item1s1.Text = "5"; itemana.Image = Properties.Resources.healpotion; item2.Image = Properties.Resources.coin; item2s2.Text = "100"; item3s3.Text = "0"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 7) { item1.Image = Properties.Resources.cicek3; item1s1.Text = "5"; itemana.Image = Properties.Resources.manapotion; item2.Image = Properties.Resources.coin; item2s2.Text = "100"; item3s3.Text = "0"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 8) { item1.Image = Properties.Resources.fish; item1s1.Text = "2"; itemana.Image = Properties.Resources.pismisbalik; item2.Image = Properties.Resources.coin; item2s2.Text = "100"; item3s3.Text = "0"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 9) { item1.Image = Properties.Resources.ironbar; item1s1.Text = "30"; itemana.Image = Properties.Resources.shild; item2.Image = Properties.Resources.coin; item2s2.Text = "300"; item3s3.Text = "0"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 10) { item1.Image = Properties.Resources.ironbar; item1s1.Text = "3"; item2.Image = Properties.Resources.inci; item2s2.Text = "10"; item3.Image = Properties.Resources.coin; item3s3.Text = "300"; item4s4.Text = "0"; itemana.Image = Properties.Resources.küpe; }
            if (comboBox1.SelectedIndex == 11) { item1.Image = Properties.Resources.helmet; item1s1.Text = "1"; itemana.Image = Properties.Resources.ghelmet; item2.Image = Properties.Resources.ironbar; item2s2.Text = "50"; item3.Image=Properties.Resources.coin; item3s3.Text = "1000"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 12)  {item1.Image = Properties.Resources.armorr; item1s1.Text = "1"; itemana.Image = Properties.Resources.garmor; item2.Image = Properties.Resources.ironbar; item2s2.Text = "100"; item3.Image = Properties.Resources.coin; item3s3.Text = "1000"; item4s4.Text = "30"; item4.Image = Properties.Resources.mantar; }
            if (comboBox1.SelectedIndex == 13) { item1.Image = Properties.Resources.sword; item1s1.Text = "1"; itemana.Image = Properties.Resources.gsword; item2.Image = Properties.Resources.ironbar; item2s2.Text = "100"; item3.Image = Properties.Resources.coin; item3s3.Text = "1000"; item4.Image = Properties.Resources.yakut; item4s4.Text = "20"; }
            if (comboBox1.SelectedIndex == 14) { item1.Image = Properties.Resources.neckle; item1s1.Text = "1"; itemana.Image = Properties.Resources.gkolye; item2.Image = Properties.Resources.ironbar; item2s2.Text = "20"; item3.Image = Properties.Resources.coin; item3s3.Text = "1000"; item4.Image = Properties.Resources.inci; item4s4.Text = "20"; }
            if (comboBox1.SelectedIndex == 15) { item1.Image = Properties.Resources.bilezik; item1s1.Text = "1"; itemana.Image = Properties.Resources.gbilezik; item2.Image = Properties.Resources.ironbar; item2s2.Text = "20"; item3.Image = Properties.Resources.coin; item3s3.Text = "1000"; item4.Image = Properties.Resources.inci; item4s4.Text = "20"; }
            if (comboBox1.SelectedIndex == 16) {  item1.Image = Properties.Resources.armor2; item1s1.Text = "1"; itemana.Image = Properties.Resources.gayak; item2.Image = Properties.Resources.ironbar; item2s2.Text = "50"; item3.Image = Properties.Resources.coin; item3s3.Text = "1000"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 17) { item1.Image = Properties.Resources.shild; item1s1.Text = "1"; itemana.Image = Properties.Resources.gkalkan; item2.Image = Properties.Resources.ironbar; item2s2.Text = "200"; item3.Image = Properties.Resources.coin; item3s3.Text = "2000"; item4s4.Text = "0"; }
            if (comboBox1.SelectedIndex == 18) { item1.Image = Properties.Resources.küpe; item1s1.Text = "1"; itemana.Image = Properties.Resources.gküpe; item2.Image = Properties.Resources.ironbar; item2s2.Text = "50"; item3.Image = Properties.Resources.coin; item3s3.Text = "2000"; item4.Image = Properties.Resources.yakut; item4s4.Text = "20"; }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        //https://github.com/Lasque28
        private void craft_Load(object sender, EventArgs e)
        {
           
            itemana.Image = Properties.Resources.bos;
            item1.Image = Properties.Resources.bos;
            item2.Image = Properties.Resources.bos;
            item3.Image = Properties.Resources.bos;
            item4.Image = Properties.Resources.bos;

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
                label_para.Text = para + " COİN";



            }
            else { MessageBox.Show("nah sana kod"); }
            baglan.Close();
           

        }
        string para;
        string demir, silver, yakut, kcicek, mcicek, mantar, balik, inci;//@emreyksln
        private void paradüs() {

            baglan.Open();
            string ara4 = ("UPDATE kullanici_kayit  set kullanici_para=@para WHERE kullanici_no=@no");

            OleDbCommand emir4 = new OleDbCommand(ara4, baglan);
            para = (Convert.ToInt32(para) - 100).ToString();
            if (comboBox1.SelectedIndex == 9 && Convert.ToInt32(para) >= 200) { para = (Convert.ToInt32(para) - 200).ToString(); }
            else if (comboBox1.SelectedIndex == 10 && Convert.ToInt32(para) >= 200) { para = (Convert.ToInt32(para) - 200).ToString(); }

           
            label_para.Text = para.ToString() + "COİN";
            emir4.Parameters.AddWithValue("@para", OleDbType.Integer).Value = para;
            emir4.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;

            //BAŞLAT
            emir4.ExecuteNonQuery();
            baglan.Close();




        }
        private void button1_Click(object sender, EventArgs e)
        {
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
           
            else { MessageBox.Show("DEMİRLER YOLDA KAYBOLDU" ); }
            baglan.Close();

            if (Convert.ToInt32(para) >= 100&&comboBox1.SelectedIndex==0|| comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2 || comboBox1.SelectedIndex == 3 || comboBox1.SelectedIndex == 4
                || comboBox1.SelectedIndex == 5 || comboBox1.SelectedIndex == 6 || comboBox1.SelectedIndex == 7 || comboBox1.SelectedIndex == 8 || comboBox1.SelectedIndex == 9 || comboBox1.SelectedIndex == 10)
            {
                




                envanter envanter = new envanter();
                if (comboBox1.SelectedIndex == 0 && Convert.ToInt32(demir) >= 5)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //KASK                  
                    demir = (Convert.ToInt32(demir) - 5).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR KASK ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    envanter.envanterres12.Visible = true;
                    baglan.Close();
                    no = 2;
                    adetata();
                    yenile();
                }
                else if (comboBox1.SelectedIndex == 1 && Convert.ToInt32(demir) >= 10)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                    //ZIRH                
                  
                    demir = (Convert.ToInt32(demir) - 10).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR ZIRH ÜRETİNİZ ");
                    baglan.Close();
                    no = 3;
                    adetata();
                    yenile();
                    envanter.envanterres13.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 2 && Convert.ToInt32(demir) >= 10 && Convert.ToInt32(inci) >= 1)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_inci=@inci WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                    
                    //KILIC 
                    demir = (Convert.ToInt32(demir) - 10).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    inci = (Convert.ToInt32(inci) - 1).ToString();
                    emir3.Parameters.AddWithValue("@inci", OleDbType.Integer).Value = inci;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR KILICI ÜRETİNİZ ");
                    baglan.Close();
                    no = 4;
                    adetata();
                    yenile();
                    envanter.envanterres14.Visible = true;
                }
                else if (comboBox1.SelectedIndex == 3 && Convert.ToInt32(demir) >= 3 && Convert.ToInt32(yakut) >= 2)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_yakut=@yakut WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                    
                    //KOLYE
                    demir = (Convert.ToInt32(demir) - 3).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    yakut = (Convert.ToInt32(yakut) >= 2).ToString();
                    emir3.Parameters.AddWithValue("@yakut", OleDbType.Integer).Value = yakut;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR KOLYE ÜRETİNİZ ");
                    baglan.Close();
                    no = 5;
                    adetata();
                    yenile();
                    envanter.envanterres15.Visible = true;



                }
                else if (comboBox1.SelectedIndex == 4 && Convert.ToInt32(demir) >= 3 && Convert.ToInt32(yakut) >= 2 && Convert.ToInt32(inci) >= 3)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_yakut=@yakut,gamer_inci=@inci WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                    
                    //BİLEZİK
                    demir = (Convert.ToInt32(demir) - 3).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    yakut = (Convert.ToInt32(yakut) >= 2).ToString();
                    emir3.Parameters.AddWithValue("@yakut", OleDbType.Integer).Value = yakut;
                    inci = (Convert.ToInt32(inci) >= 3).ToString();
                    emir3.Parameters.AddWithValue("@inci", OleDbType.Integer).Value = inci;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR BİLEZİK ÜRETİNİZ ");
                    baglan.Close();
                    no = 6;
                    adetata();
                    yenile();


                }
                else if (comboBox1.SelectedIndex == 5 && Convert.ToInt32(demir) >= 5)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                    //AYAK
                    
                    demir = (Convert.ToInt32(demir) - 5).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR AYAKKABI ÜRETİNİZ ");
                    baglan.Close();
                    no = 7;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 6 && Convert.ToInt32(kcicek) >= 5)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_kcicek=@cicek WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                    //KPOT 
                   
                    kcicek = (Convert.ToInt32(kcicek) - 5).ToString();
                    emir3.Parameters.AddWithValue("@cicek", OleDbType.Integer).Value = kcicek;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA CAN İKSİRİ ÜRETİNİZ ");
                    baglan.Close();
                    no = 8;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 7 && Convert.ToInt32(mcicek) >= 5)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_mcicek=@cicek WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                    //MPOT
                    
                    kcicek = (Convert.ToInt32(mcicek) - 5).ToString();
                    emir3.Parameters.AddWithValue("@cicek", OleDbType.Integer).Value = mcicek;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA MANA İKSİRİ ÜRETİNİZ ");
                    baglan.Close();
                    no = 9;
                    adetata();
                    yenile();

                }
                //https://github.com/Lasque28 @emreyksln
                else if (comboBox1.SelectedIndex == 8 && Convert.ToInt32(balik) >= 2)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_balik=@balik WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                   
                    //BALIK 
                    balik = (Convert.ToInt32(balik) - 2).ToString();
                    emir3.Parameters.AddWithValue("@balik", OleDbType.Integer).Value = balik;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA CAN İKSİRİ ÜRETİNİZ ");
                    baglan.Close();
                    no = 8;
                    adetata();
                    yenile();

                }

                else if (comboBox1.SelectedIndex == 9 && Convert.ToInt32(demir) >= 30 && Convert.ToInt32(para) >= 300)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                   
                    //KALKAN 
                    demir = (Convert.ToInt32(demir) - 30).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR KALKAN ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    no = 11;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 10 && Convert.ToInt32(demir) >= 3 && Convert.ToInt32(para) >= 300 && Convert.ToInt32(inci) >= 10)

                {
                    paradüs();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_inci=@inci WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                   
                    //KÜPE 
                    demir = (Convert.ToInt32(demir) - 3).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    inci = (Convert.ToInt32(inci) -10).ToString();
                    emir3.Parameters.AddWithValue("@inci", OleDbType.Integer).Value = inci;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA DEMİR KÜPE ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    no = 12;
                    adetata();
                    yenile();

                }

                else if (Convert.ToInt32(para) < 300) { MessageBox.Show("BAŞARIYLA BAŞINI ALDINIZ PARANIZ VEYA İTEMİNİZ YOK"); }
                else { MessageBox.Show("ÇAKAL OLMAYAN İTEMLE ÜRETMEYE ÇALIŞIYORSUN "); }









                baglan.Close();

            }
            
            else if(Convert.ToInt32(para) >= 1000 && comboBox1.SelectedIndex == 11 || comboBox1.SelectedIndex == 12 || comboBox1.SelectedIndex == 13 || comboBox1.SelectedIndex == 14
                || comboBox1.SelectedIndex == 15 || comboBox1.SelectedIndex == 16 || comboBox1.SelectedIndex == 17 || comboBox1.SelectedIndex == 18)
            {
                


                string[] zırhadet = new string[15];
                for (int i = 0; i < 14; i++)
                {
                    int art = 0;
                    art = i + 2;
                    baglan.Open();
                    OleDbDataReader sorgu9;
                    string ara = ("Select*From crafts WHERE  craft_no= " + art);
                    OleDbCommand emir6 = new OleDbCommand(ara, baglan);
                    emir6.ExecuteNonQuery();
                    sorgu9 = emir6.ExecuteReader();
                    if (sorgu9.Read())
                    {

                        zırhadet[i] = sorgu9[2].ToString();
                        

                    }
                    baglan.Close();
                }
              
                if (comboBox1.SelectedIndex == 11 && Convert.ToInt32(zırhadet[0]) > 0 && Convert.ToInt32(para) >= 1000 && Convert.ToInt32(demir) >= 50)

                {
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ KASK
                    demir = (Convert.ToInt32(demir) - 50).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR KASK ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[0]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 2;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 13;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 12 && Convert.ToInt32(zırhadet[1]) > 0 && Convert.ToInt32(para) >= 1000 && Convert.ToInt32(demir) >= 100 && Convert.ToInt32(mantar) >= 30)
                //https://github.com/Lasque28
                {
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_mantar=@mantar WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ ZIRH
                    demir = (Convert.ToInt32(demir) - 100).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    mantar = (Convert.ToInt32(mantar) - 30).ToString();
                    emir3.Parameters.AddWithValue("@mantar", OleDbType.Integer).Value = mantar;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR ZIRH ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[1]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 3;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 14;
                    adetata();
                    yenile();
                    //https://github.com/Lasque28 @emreyksln

                }
                else if (comboBox1.SelectedIndex == 13&& Convert.ToInt32(zırhadet[2]) > 0 && Convert.ToInt32(para) >= 1000 && Convert.ToInt32(demir) >= 100 && Convert.ToInt32(yakut) >= 20)

                {
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_yakut=@yakut WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ KILIÇ
                    demir = (Convert.ToInt32(demir) - 100).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    yakut = (Convert.ToInt32(yakut) - 30).ToString();
                    emir3.Parameters.AddWithValue("@yakut", OleDbType.Integer).Value =yakut;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR KILIÇ ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[2]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 4;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 15;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 14 && Convert.ToInt32(zırhadet[3]) > 0 && Convert.ToInt32(para) >= 1000 && Convert.ToInt32(demir) >= 100 && Convert.ToInt32(inci) >= 20)

                {
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_inci=@inci WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ KOLYE
                    demir = (Convert.ToInt32(demir) - 20).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    inci = (Convert.ToInt32(inci) - 20).ToString();
                    emir3.Parameters.AddWithValue("@inci", OleDbType.Integer).Value = inci;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR KOLYE ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[3]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 5;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 16;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 15 && Convert.ToInt32(zırhadet[4]) > 0 && Convert.ToInt32(para) >= 1000 && Convert.ToInt32(demir) >= 100 && Convert.ToInt32(inci) >= 20)

                { //https://github.com/Lasque28
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_inci=@inci WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ BİLEZİK
                    demir = (Convert.ToInt32(demir) - 20).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    inci = (Convert.ToInt32(inci) - 20).ToString();
                    emir3.Parameters.AddWithValue("@inci", OleDbType.Integer).Value = inci;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR BİLEZİK ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[3]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 6;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 17;
                    adetata();
                    yenile();

                }
               else if(comboBox1.SelectedIndex == 16 && Convert.ToInt32(zırhadet[5]) > 0 && Convert.ToInt32(para) >= 1000 && Convert.ToInt32(demir) >= 50)

                {
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ ayak
                    demir = (Convert.ToInt32(demir) - 50).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR AYAKKABI ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[5]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 7;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 18;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 17 && Convert.ToInt32(zırhadet[9]) > 0 && Convert.ToInt32(para) >= 2000 && Convert.ToInt32(demir) >= 50)

                {
                    paradus1000();
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ ayak
                    demir = (Convert.ToInt32(demir) - 200).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                   
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR KALKAN ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[9]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 11;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 19;
                    adetata();
                    yenile();

                }
                else if (comboBox1.SelectedIndex == 18 && Convert.ToInt32(zırhadet[10]) > 0 && Convert.ToInt32(para) >= 2000 && Convert.ToInt32(demir) >= 50)

                { //https://github.com/Lasque28
                    paradus1000();
                    paradus1000();
                    baglan.Open();
                    string ara3 = ("UPDATE kullanici_kayit set gamer_demir=@demir,gamer_yakut=@yakut WHERE kullanici_no=@no");
                    OleDbCommand emir3 = new OleDbCommand(ara3, baglan);

                    //GÜÇLÜ ayak
                    demir = (Convert.ToInt32(demir) - 50).ToString();
                    emir3.Parameters.AddWithValue("@demir", OleDbType.Integer).Value = demir;
                    yakut = (Convert.ToInt32(yakut) - 20).ToString();
                    emir3.Parameters.AddWithValue("@yakut", OleDbType.Integer).Value = yakut;
                    emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;
                    MessageBox.Show("BAŞARIYLA GÜÇLÜ DEMİR KÜPE ÜRETİNİZ ");
                    emir3.ExecuteNonQuery();
                    baglan.Close();
                    baglan.Open();
                    string ara6 = ("UPDATE crafts set craft_adet=@adet WHERE craft_no=@no");
                    OleDbCommand emir6 = new OleDbCommand(ara6, baglan);

                    int adet = Convert.ToInt32(zırhadet[10]);
                    adet = adet - 1;
                    emir6.Parameters.AddWithValue("@adet", OleDbType.Integer).Value = adet;
                    emir6.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 12;

                    emir6.ExecuteNonQuery();
                    baglan.Close();
                    no = 20;
                    adetata();
                    yenile();

                }





            }
            else { MessageBox.Show("BAŞARIYLA BAŞINI ALDINIZ 2.5"); }
        }
        private void paradus1000()
        {

            baglan.Open();
            string ara4 = ("UPDATE kullanici_kayit  set kullanici_para=@para WHERE kullanici_no=@no");

            OleDbCommand emir4 = new OleDbCommand(ara4, baglan);
            para = (Convert.ToInt32(para) - 1000).ToString();



            label_para.Text = para.ToString() + "COİN";
            emir4.Parameters.AddWithValue("@para", OleDbType.Integer).Value = para;
            emir4.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;

            //BAŞLAT
            emir4.ExecuteNonQuery();
            baglan.Close();
            //https://github.com/Lasque28 @emreyksln
        }
    }
}
