using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace YurtKayıtSistemi
{
    public partial class frmYoneticiDuzenle : Form
    {
        public frmYoneticiDuzenle()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl = new SqlBaglantim();
        private void frmYoneticiDuzenle_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbYurtOtomasyonDataSet5.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.dbYurtOtomasyonDataSet5.Admin);

        }



        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen;
            secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtYoneticiId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtYoneticiAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtYoneticiSifre.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            try
            {
                 SqlCommand komut = new SqlCommand("insert into Admin (YoneticiAd,YoneticiSifre) values(@p1,@p2)", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", txtYoneticiAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtYoneticiSifre.Text);
                    komut.ExecuteNonQuery();

                    bgl.Baglanti().Close();

                    MessageBox.Show("Yönetici Eklendi");
                    this.adminTableAdapter.Fill(this.dbYurtOtomasyonDataSet5.Admin);
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
                SqlCommand komut = new SqlCommand("update  Admin set YoneticiAd=@p2, YoneticiSifre=@p3 where YoneticiId=@p1 ", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtYoneticiId.Text);
                komut.Parameters.AddWithValue("@p2", txtYoneticiAd.Text);
                komut.Parameters.AddWithValue("@p3", txtYoneticiSifre.Text);
                komut.ExecuteNonQuery();

                bgl.Baglanti().Close();

                MessageBox.Show("Yönetici Güncellendi");
                this.adminTableAdapter.Fill(this.dbYurtOtomasyonDataSet5.Admin);
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
                SqlCommand komut = new SqlCommand("delete from Admin where YoneticiId=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtYoneticiId.Text);

                komut.ExecuteNonQuery();

                bgl.Baglanti().Close();

                MessageBox.Show("Yönetici Silindi");
                this.adminTableAdapter.Fill(this.dbYurtOtomasyonDataSet5.Admin);
                Temizle();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu tekrar deneyin");
            }
        }
        private void Temizle()
        {
            txtYoneticiId.Clear();
            txtYoneticiSifre.Clear();
            txtYoneticiAd.Clear();
        }
    }
}
