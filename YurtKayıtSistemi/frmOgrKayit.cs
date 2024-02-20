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
    public partial class frmOgrKayit : Form
    {
        public frmOgrKayit()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl=new SqlBaglantim();

        private void frmOgrKayit_Load(object sender, EventArgs e)
        {
            //Bölümleri listelem komutları
           
            SqlCommand komut = new SqlCommand("select bolumAd from Bolumler", bgl.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.Baglanti().Close();
            //Boş odaları listeleme komutları

            Yenile();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {


                SqlCommand komutKaydet = new SqlCommand("insert into Ogrenci (ogrAd,ogrSoyad,ogrTC,ogrTelefon,ogrDogum,ogrBolum,ogrMail,ogrOdaNo,ogrVeliAdSoyad,ogrVeliTelefon,ogrVeliAdres) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.Baglanti());
                komutKaydet.Parameters.AddWithValue("@p1", txtAd.Text);
                komutKaydet.Parameters.AddWithValue("@p2", txtSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p3", mskTC.Text);
                komutKaydet.Parameters.AddWithValue("@p4", mskTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p5", mskDogum.Text);
                komutKaydet.Parameters.AddWithValue("@p6", cmbBolum.Text);
                komutKaydet.Parameters.AddWithValue("@p7", txtMail.Text);
                komutKaydet.Parameters.AddWithValue("@p8", cmbOdaNo.Text);
                komutKaydet.Parameters.AddWithValue("@p9", txtVeliAdSoyad.Text);
                komutKaydet.Parameters.AddWithValue("@p10", mskVeliTelefon.Text);
                komutKaydet.Parameters.AddWithValue("@p11", rchAdres.Text);
                komutKaydet.ExecuteNonQuery();
                bgl.Baglanti().Close();
              
                MessageBox.Show("Kayıt başarıyla eklendi....");
               

                //Öğrenci id labela çekme komutu
                SqlCommand komut = new SqlCommand("select ogrId from Ogrenci", bgl.Baglanti());
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    label12.Text = oku[0].ToString();
                }
                bgl.Baglanti().Close();


                //Öğrenci borç alanı oluşturma

                SqlCommand komutkaydet2 = new SqlCommand("insert into borclar (ogrId,ogrAd,ogrSoyad) values(@b1,@b2,@b3)", bgl.Baglanti());
                komutkaydet2.Parameters.AddWithValue("@b1", label12.Text);
                komutkaydet2.Parameters.AddWithValue("@b2", txtAd.Text);
                komutkaydet2.Parameters.AddWithValue("@b3", txtSoyad.Text);
                komutkaydet2.ExecuteNonQuery();
                bgl.Baglanti().Close();

                //Öğrenci oda konteanjanı arttırma 

                SqlCommand komutoda = new SqlCommand("update Odalar set odaAktif = odaAktif+1 where odaNo=@oda1", bgl.Baglanti());
                komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
                komutoda.ExecuteNonQuery();
                bgl.Baglanti().Close();

                Temizle(); 
                Yenile();
              

            }
            catch (Exception)
            {
                MessageBox.Show("HATA!!!  Lütfen yeniden deneyin");
            }           

        }
        private void Yenile()
        {
            cmbOdaNo.Items.Clear();
            SqlCommand komut = new SqlCommand("select odaNo from Odalar where odaKapasite!=odaAktif ", bgl.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbOdaNo.Items.Add(oku[0].ToString());
            }
            bgl.Baglanti().Close();
        }
        private void Temizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtMail.Clear();
            txtVeliAdSoyad.Clear();
            cmbBolum.SelectedItem=null;
            cmbOdaNo.SelectedItem=null; 
            rchAdres.Clear();
            mskDogum.Clear();
            mskTC.Clear();
            mskTelefon.Clear();
            mskVeliTelefon.Clear();

        }
    }
}
