using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayıtSistemi
{
    public partial class frmGiderGuncelle : Form
    {
        public frmGiderGuncelle()
        {
            InitializeComponent();
        }
        
        SqlBaglantim bgl=new SqlBaglantim();    
        public string id, elektrik, su, dogalgaz, internet, gida, personel, diger;

       
        private void frmGiderGuncelle_Load(object sender, EventArgs e)
        {
            txtGiderId.Text = id;
            txtElektrikGuncelle.Text = elektrik;
            txtSuGuncelle.Text=su;
            txtDogalgazGuncelle.Text=dogalgaz;
            txtInternetGuncelle.Text=internet;
            txtGidaGuncelle.Text=gida;
            txtPersonelGuncelle.Text = personel;
            txtDigerGuncelle.Text=diger;
        }

        private void btnGiderGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Giderler set elektrik=@p2,su=@p3,doğalgaz=@p4,internet=@p5,gıda=@p6,personel=@p7,diğer=@p8 where odemeId=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtGiderId.Text);
                komut.Parameters.AddWithValue("@p2", txtElektrikGuncelle.Text);
                komut.Parameters.AddWithValue("@p3", txtSuGuncelle.Text);
                komut.Parameters.AddWithValue("@p4", txtDogalgazGuncelle.Text);
                komut.Parameters.AddWithValue("@p5", txtInternetGuncelle.Text);
                komut.Parameters.AddWithValue("@p6", txtGidaGuncelle.Text);
                komut.Parameters.AddWithValue("@p7", txtPersonelGuncelle.Text);
                komut.Parameters.AddWithValue("@p8", txtDigerGuncelle.Text);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Kayıt Güncellendi");
        
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Tekrar Deneyin");
            }

        }
    }
}
