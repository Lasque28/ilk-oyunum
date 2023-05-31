using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace MaceraTutkunuDemirci
{
    public partial class giris : Form
    {
       
        OleDbConnection baglan = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source = 'kullanici_veri.mdb'");
        public giris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (bilgi.Enabled == true)
            { 
            baglan.Open();
            OleDbDataReader sorgu;
            string ara = ("Select*From kullanici_kayit WHERE  kullanici_adi='"+ textBox1.Text+"' AND kullanici_sifre='"+textBox2.Text +"'");
            OleDbCommand emir2 = new OleDbCommand(ara, baglan);
            emir2.ExecuteNonQuery();
            //@emreyksln
            sorgu = emir2.ExecuteReader(); 
            if(sorgu.Read())
            {
                MessageBox.Show("Tebrikler "+textBox1.Text+" başarıyla giriş yapabilidiniz");
                koy koy = new koy();
                this.Hide();
                koy.Show();

            }
            else { MessageBox.Show("nah sana kod"); }
            baglan.Close();
            }
            bilgi.Enabled = true;
            button1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            baglan.Open();
            string ekle = "INSERT INTO kullanici_kayit(kullanici_adi,kullanici_sifre,kullanici_lv,kullanici_para,gamer_can,gamer_mana,gamer_hsr,gamer_xp) VALUES (@ad,@sifre,@lv,@para,@can,@mana,@hsr,xp)";
            OleDbCommand emir = new OleDbCommand(ekle,baglan);
            emir.Parameters.AddWithValue("@ad",OleDbType.VarChar).Value= textBox3.Text;
            emir.Parameters.AddWithValue("@sifre", OleDbType.VarChar).Value = textBox4.Text;
            emir.Parameters.AddWithValue("@lv", OleDbType.Integer).Value=1;
            emir.Parameters.AddWithValue("@para", OleDbType.Integer).Value=0;
            emir.Parameters.AddWithValue("@can", OleDbType.VarChar).Value = 10;
            emir.Parameters.AddWithValue("@mana", OleDbType.Integer).Value = 5;
            emir.Parameters.AddWithValue("@hsr", OleDbType.Integer).Value = 2;
            emir.Parameters.AddWithValue("@xp", OleDbType.Integer).Value = 0;
            emir.ExecuteNonQuery();
            baglan.Close();
            label4.Visible = false;
            label5.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            button3.Visible = false;
            MessageBox.Show("Tebrikler "+textBox3.Text+" başarıyla kayıt oldun artık giriş yapabilirsin ");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            button3.Visible = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            zindan zindan = new zindan();
            this.Hide();
            zindan.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;

        }

        private void giris_Load(object sender, EventArgs e)
        {
            button2.Enabled = false;
            bilgi.Enabled = false;

        }

        private void bilgi_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BackgroundImage = Properties.Resources.update;
            button1.Enabled = true;
            
        }
    }
    }

