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
    public partial class FrmOgrDuzenle : Form
    {
        public FrmOgrDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl=new SqlBaglantim();
        public string id , ad,soyad,TC,telefon,dogum,bolum;

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("delete from Ogrenci where ogrId=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrId.Text);

                komut.ExecuteNonQuery();

                bgl.Baglanti().Close();

                MessageBox.Show("Öğrenci Silindi");


                SqlCommand komutoda = new SqlCommand("update Odalar set odaAktif = odaAktif-1 where odaNo=@oda1", bgl.Baglanti());
                komutoda.Parameters.AddWithValue("@oda1", cmbOdaNo.Text);
                komutoda.ExecuteNonQuery();
                bgl.Baglanti().Close();

                Yenile();
                

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu tekrar deneyin");
            }
        }

        public string mail,odano,veliad,velitel,adres;

        private void FrmOgrDuzenle_Load(object sender, EventArgs e)
        {
            txtOgrId.Text = id;
            txtAd.Text = ad;
            txtSoyad.Text = soyad;
            mskTC.Text = TC;
            mskTelefon.Text = telefon;
            mskDogum.Text = dogum;
            cmbBolum.Text = bolum;
            txtMail.Text = mail;
            cmbOdaNo.Text = odano;
            txtVeliAdSoyad.Text=veliad;
            mskVeliTelefon.Text = velitel;
            rchAdres.Text = adres;

            //Bölümleri listelem komutları

            SqlCommand komut = new SqlCommand("select bolumAd from Bolumler", bgl.Baglanti());
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                cmbBolum.Items.Add(oku[0].ToString());
            }
            bgl.Baglanti().Close();
            //Boş odaları listeleme komutları

            SqlCommand komut2 = new SqlCommand("select odaNo from Odalar where odaKapasite!=odaAktif ", bgl.Baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbOdaNo.Items.Add(oku2[0].ToString());
            }
            bgl.Baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("update Ogrenci set ogrAd=@p2,ogrSoyad=@p3,ogrTC=@p4,ogrTelefon=@p5,ogrDogum=@p6,ogrBolum=@p7,ogrMail=@p8,ogrOdaNo=@p9,ogrVeliAdSoyad=@p10,ogrVeliTelefon=@p11,ogrVeliAdres=@p12 where ogrId=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtOgrId.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", txtSoyad.Text);
                komut.Parameters.AddWithValue("@p4", mskTC.Text);
                komut.Parameters.AddWithValue("@p5", mskTelefon.Text);
                komut.Parameters.AddWithValue("@p6", mskDogum.Text);
                komut.Parameters.AddWithValue("@p7", cmbBolum.Text);
                komut.Parameters.AddWithValue("@p8", txtMail.Text);
                komut.Parameters.AddWithValue("@p9", cmbOdaNo.Text);
                komut.Parameters.AddWithValue("@p10", txtVeliAdSoyad.Text);
                komut.Parameters.AddWithValue("@p11", mskVeliTelefon.Text);
                komut.Parameters.AddWithValue("@p12", rchAdres.Text);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Öğrenci Güncellendi");
                Yenile();
            }
            catch (Exception)
            {

                MessageBox.Show("Bir Hata Oluştu Tekrar Deneyin");
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
    }
}
