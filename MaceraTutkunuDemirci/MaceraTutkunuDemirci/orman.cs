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
{//@emreyksln
    public partial class orman : Form
    {
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        string cicekler1, cicekler2, mantar3;
        int kcicek=0, mcicek=0, mantar=0,bos=0;
        private void isle()
        {

            //https://github.com/Lasque28 @emreyksln
            if (bos==0)
            {

                int rsg = rastgele.Next(1, 4);
                if (rsg == 1) { kcicek=kcicek+1; }
                if (rsg == 2) { mcicek=mcicek+1; }
                if (rsg == 3) { mantar=mantar+1; }

                if (rsg == 1) { sunum.Text =  "kırmızı çicek toplandı"; }
                if (rsg == 2) { sunum.Text = "mavi  çicek toplandı"; }
                if (rsg == 3) { sunum.Text = "mantar toplandı"; }



                
                baglan.Open();
                OleDbDataReader sorgu;
                string ara2 = ("Select*From kullanici_kayit WHERE  kullanici_no= " + 1);
                OleDbCommand emir2 = new OleDbCommand(ara2, baglan);
                emir2.ExecuteNonQuery();

                sorgu = emir2.ExecuteReader();
                if (sorgu.Read())
                {

                    cicekler1 = sorgu[14].ToString();
                    cicekler2 = sorgu[15].ToString();
                    mantar3 = sorgu[16].ToString();


                }
                else { MessageBox.Show("nah sana kod"); }
                baglan.Close();
                cicekler1= (Convert.ToInt32(cicekler1) + kcicek).ToString();
                cicekler2 = (Convert.ToInt32(cicekler2) + mcicek).ToString();
                mantar3 = (Convert.ToInt32(mantar3) + mantar).ToString();

                baglan.Open();
                string ara = ("UPDATE kullanici_kayit  set gamer_kcicek=@kcicek, gamer_mcicek=@mcicek, gamer_mantar=@mantar WHERE kullanici_no=@no");  // KAZANILANLARI KAYDETME

                OleDbCommand emir3 = new OleDbCommand(ara, baglan);

                emir3.Parameters.AddWithValue("@kcicek", OleDbType.Integer).Value = cicekler1;
                emir3.Parameters.AddWithValue("@mcicek", OleDbType.Integer).Value = cicekler2;
                emir3.Parameters.AddWithValue("@mantar", OleDbType.Integer).Value = mantar3;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;


                emir3.ExecuteNonQuery();
                baglan.Close();






            }
        }
        string para;
            public orman()
        {
            InitializeComponent();
        }
        Random rastgele = new Random();
        private void button1_Click(object sender, EventArgs e)
        {  //https://github.com/Lasque28 @emreyksln


            if (Convert.ToInt32(para) >= 20) {


                baglan.Open();
                string ara3 = ("UPDATE kullanici_kayit  set kullanici_para=@para WHERE kullanici_no=@no");

                OleDbCommand emir3 = new OleDbCommand(ara3, baglan);
                para = (Convert.ToInt32(para) - 20).ToString();
                emir3.Parameters.AddWithValue("@para", OleDbType.Integer).Value = para;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;

                label3.Text = para.ToString() + "COİN";                                                    //BAŞLAT
                emir3.ExecuteNonQuery();
                baglan.Close();

                int rsg = rastgele.Next(1, 4);
            int rsg1 = rastgele.Next(1, 4);
            int rsg2 = rastgele.Next(1, 4);
            int rsg3 = rastgele.Next(1, 4);
            int rsg4 = rastgele.Next(1, 4);
            int rsg5 = rastgele.Next(1, 4);
            if (rsg == 1) { this.BackgroundImage = Properties.Resources.jungle1; }
            if (rsg == 2) { this.BackgroundImage = Properties.Resources.jungle3; }
            if (rsg == 3) { this.BackgroundImage = Properties.Resources.jungle4; }
            if (rsg == 1) { cicek2.Image = Properties.Resources.cicek2; cicek2.Visible = true; }
            if (rsg2 == 1) { cicek3.Image = Properties.Resources.cicek3; cicek3.Visible = true; }
            if (rsg3 == 1) { cicek4.Image = Properties.Resources.mantar; cicek4.Visible = true; }

            if (rsg == 1) { cicek13.Image = Properties.Resources.cicek2; cicek13.Visible = true; }
            if (rsg == 2) { cicek3.Image = Properties.Resources.cicek3; cicek3.Visible = true; }
            if (rsg == 3) { cicek4.Image = Properties.Resources.mantar; cicek4.Visible = true; }
            if (rsg2 == 1) { cicek3.Image = Properties.Resources.cicek3; cicek3.Visible = true; }
            if (rsg2 == 2) { cicek4.Image = Properties.Resources.mantar; cicek4.Visible = true; }
            if (rsg2 == 3) { cicek9.Image = Properties.Resources.cicek3; cicek9.Visible = true; }
            if (rsg3 == 1) { cicek6.Image = Properties.Resources.cicek2; cicek6.Visible = true; }
            if (rsg3 == 2) { cicek14.Image = Properties.Resources.mantar; cicek14.Visible = true; }
            if (rsg3 == 3) { cicek7.Image = Properties.Resources.cicek3; cicek7.Visible = true; }
            if (rsg4 == 1) { cicek13.Image = Properties.Resources.cicek2; cicek13.Visible = true; }
            if (rsg4 == 2) { cicek12.Image = Properties.Resources.mantar; cicek12.Visible = true; }
            if (rsg4 == 3) { cicek15.Image = Properties.Resources.cicek3; cicek15.Visible = true; }
            if (rsg5 == 1) { cicek6.Image = Properties.Resources.cicek2; cicek6.Visible = true; }
            if (rsg5 == 2) { cicek17.Image = Properties.Resources.mantar; cicek17.Visible = true; }
            if (rsg5 == 3) { cicek13.Image = Properties.Resources.cicek3; cicek13.Visible = true; }
            if (rsg == 1) { cicek1.Image = Properties.Resources.cicek2; cicek1.Visible = true; }
            if (rsg == 2) { cicek13.Image = Properties.Resources.mantar; cicek13.Visible = true; }
            if (rsg == 3) { cicek12.Image = Properties.Resources.cicek3; cicek12.Visible = true; }
        }
            else { sunum.Text = "paran yok fakir"; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(para) >= 20)
            {


                baglan.Open();
                string ara4 = ("UPDATE kullanici_kayit  set kullanici_para=@para WHERE kullanici_no=@no");

                OleDbCommand emir3 = new OleDbCommand(ara4, baglan);
                para = (Convert.ToInt32(para) - 20).ToString();
                emir3.Parameters.AddWithValue("@para", OleDbType.Integer).Value = para;
                emir3.Parameters.AddWithValue("@no", OleDbType.Integer).Value = 1;

                label3.Text = para.ToString() + "COİN";                                                    //BAŞLAT
                emir3.ExecuteNonQuery();
                baglan.Close();
                
            

            int rsg = rastgele.Next(1, 4);
            int rsg1 = rastgele.Next(1, 4);
            int rsg2= rastgele.Next(1, 4);
            int rsg3 = rastgele.Next(1, 4);
            int rsg4 = rastgele.Next(1, 4);
            int rsg5 = rastgele.Next(1, 4);
            if (rsg == 1) { this.BackgroundImage = Properties.Resources.jungle1; }
            if (rsg == 2) { this.BackgroundImage = Properties.Resources.jungle3; }
            if (rsg == 3) { this.BackgroundImage = Properties.Resources.jungle4; }

            if(rsg==1) { cicek2.Image = Properties.Resources.cicek2; cicek2.Visible = true; }
            if (rsg == 2) { cicek3.Image = Properties.Resources.cicek3; cicek3.Visible = true; }
            if (rsg == 3) { cicek4.Image = Properties.Resources.mantar; cicek4.Visible = true; }
            if (rsg2 == 1) { cicek3.Image = Properties.Resources.cicek3; cicek3.Visible = true; }
            if (rsg2 == 2) { cicek4.Image = Properties.Resources.mantar; cicek4.Visible = true; }
            if (rsg2 == 3) { cicek9.Image = Properties.Resources.cicek3; cicek9.Visible = true; }
            if (rsg3 == 1) { cicek6.Image = Properties.Resources.cicek2; cicek6.Visible = true; }
            if (rsg3 == 2) { cicek7.Image = Properties.Resources.mantar; cicek7.Visible = true; }
            if (rsg3 == 3) { cicek16.Image = Properties.Resources.cicek3; cicek16.Visible = true; }
            if (rsg4 == 1) { cicek13.Image = Properties.Resources.cicek2; cicek13.Visible = true; }
            if (rsg4== 2) { cicek12.Image = Properties.Resources.mantar; cicek12.Visible = true; }
            if (rsg4 == 3) { cicek15.Image = Properties.Resources.cicek3; cicek15.Visible = true; }
            if (rsg5 == 1) { cicek6.Image = Properties.Resources.cicek2; cicek6.Visible = true; }
            if (rsg5== 2) { cicek17.Image = Properties.Resources.mantar; cicek17.Visible = true; }
            if (rsg5 == 3) { cicek13.Image = Properties.Resources.cicek3; cicek13.Visible = true; }
            if (rsg == 1) { cicek1.Image = Properties.Resources.cicek2; cicek1.Visible = true; }
            if (rsg == 2) { cicek13.Image = Properties.Resources.mantar; cicek13.Visible = true; }
            if (rsg == 3) { cicek12.Image = Properties.Resources.cicek3; cicek12.Visible = true; }
        }
            else { sunum.Text = "paran yok fakir"; }
        }

        private void orman_Load(object sender, EventArgs e)
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
            this.BackgroundImage = Properties.Resources.jungelstart;
        }

        private void cicek2_Click(object sender, EventArgs e)
        {
            cicek2.Visible =false; isle();
        }

        private void cicek1_Click(object sender, EventArgs e)
        {
            cicek1.Visible =false; isle();
        }

        private void cicek3_Click(object sender, EventArgs e)
        {
            cicek3.Visible =false; isle();
        }

        private void cicek4_Click(object sender, EventArgs e)
        {
            cicek4.Visible =false; isle();
        }

        private void cicek6_Click(object sender, EventArgs e)
        {
            cicek6.Visible =false; isle();
        }

        private void cicek5_Click(object sender, EventArgs e)
        {
            cicek5.Visible =false; isle();
        }

        private void cicek10_Click(object sender, EventArgs e)
        {
            cicek10.Visible =false; isle();
        }

        private void cicek13_Click(object sender, EventArgs e)
        {
            cicek13.Visible =false; isle();
        }

        private void cicek12_Click(object sender, EventArgs e)
        {
            cicek12.Visible = false; isle();
        }

        private void cicek16_Click(object sender, EventArgs e)
        {
            cicek16.Visible = false; isle();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            koy koy = new koy();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            button3.Visible = false;
        }

        private void cicek8_Click(object sender, EventArgs e)
        {

        }

        private void cicek15_Click(object sender, EventArgs e)
        {
            cicek15.Visible = false; isle();
        }

        private void cicek17_Click(object sender, EventArgs e)
        {
            cicek17.Visible = false; isle();
        }

        private void cicek7_Click(object sender, EventArgs e)
        {
            cicek7.Visible = false; isle();
        }
        //https://github.com/Lasque28 @emreyksln
        private void cicek9_Click(object sender, EventArgs e)
        {
            cicek9.Visible = false; isle();
        }

        private void cicek14_Click(object sender, EventArgs e)
        {
            cicek14.Visible = false; isle();
        }
    }
}
