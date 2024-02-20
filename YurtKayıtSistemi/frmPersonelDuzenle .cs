using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayıtSistemi
{
    public partial class frmPersonelDuzenle : Form
    {
        public frmPersonelDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void frmPersonelDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbYurtOtomasyonDataSet7.Personel' table. You can move, or remove it, as needed.
            this.personelTableAdapter1.Fill(this.dbYurtOtomasyonDataSet7.Personel);


        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
              
                    SqlCommand komut = new SqlCommand("insert into Personel (personelAdSoyad,personelDepartman) values(@p1,@p2)", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", txtPersonelAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtPersonelGorev.Text);
                    komut.ExecuteNonQuery();

                    bgl.Baglanti().Close();

                    MessageBox.Show("Personel Eklendi");
                    this.personelTableAdapter1.Fill(this.dbYurtOtomasyonDataSet7.Personel);
                    Temizle();
                

            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu tekrar deneyin");
            }

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand("update  Personel set personelAdSoyad=@p2, personelDepartman=@p3 where PersonelId=@p1 ", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersonelId.Text);
                komut.Parameters.AddWithValue("@p2", txtPersonelAd.Text);
                komut.Parameters.AddWithValue("@p3", txtPersonelGorev.Text);
                komut.ExecuteNonQuery();

                bgl.Baglanti().Close();

                MessageBox.Show("Personel Güncellendi");
                this.personelTableAdapter1.Fill(this.dbYurtOtomasyonDataSet7.Personel);
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu tekrar deneyin");
            }

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand komut = new SqlCommand("delete from Personel where PersonelId=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtPersonelId.Text);

                komut.ExecuteNonQuery();

                bgl.Baglanti().Close();

                MessageBox.Show("Personel Silindi");
                this.personelTableAdapter1.Fill(this.dbYurtOtomasyonDataSet7.Personel);
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu tekrar deneyin");
            }
        }
        private void Temizle()
        {
            txtPersonelId.Clear();
            txtPersonelGorev.Clear();
            txtPersonelAd.Clear();
        }

        private void dgwPersonel_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int secilen = dgwPersonel.SelectedCells[0].RowIndex;
            txtPersonelId.Text = dgwPersonel.Rows[secilen].Cells[0].Value.ToString();
            txtPersonelAd.Text = dgwPersonel.Rows[secilen].Cells[1].Value.ToString();
            txtPersonelGorev.Text = dgwPersonel.Rows[secilen].Cells[2].Value.ToString();
        }
    }
}
