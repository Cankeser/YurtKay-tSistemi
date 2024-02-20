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
    public partial class frmBolumler : Form
    {
        public frmBolumler()
        {
            InitializeComponent();
        }
        SqlBaglantim bgl=new SqlBaglantim();
        private void frmBolumler_Load(object sender, EventArgs e)
        {
           
            this.bolumlerTableAdapter.Fill(this.dbYurtOtomasyonDataSet.Bolumler);

        }

        private void pcbBolumEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBolumAd.Text))
                {
                   MessageBox.Show("Lütfen Bolüm Adı Giriniz");
                }
                else
                {
                    
                    SqlCommand komut = new SqlCommand("insert into Bolumler (bolumAd) values(@p1)", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                    komut.ExecuteNonQuery();
                    bgl.Baglanti().Close();
                    MessageBox.Show("Bölüm Başarıyla Eklendi.");
                    this.bolumlerTableAdapter.Fill(this.dbYurtOtomasyonDataSet.Bolumler);
                    txtBolumAd.Clear();
                   
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Tekrar Deneyin.");
            }
        }

        private void pcbBolumSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtBolumId.Text))
                {
                    MessageBox.Show("Lütfen Silmek İstediğiniz Bölümü Seçin ");
                }
                else
                {
                
                    SqlCommand komut = new SqlCommand("delete  Bolumler where bolumId=@p1", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", txtBolumId.Text);
                    komut.ExecuteNonQuery();
                    bgl.Baglanti().Close();
                    MessageBox.Show("Bölüm Başarıyla Silindi.");
                    this.bolumlerTableAdapter.Fill(this.dbYurtOtomasyonDataSet.Bolumler);
                    txtBolumAd.Clear();
                    txtBolumId.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Tekrar Deneyin.");
            }
        }

        private void pcbBolumDuzenle_Click(object sender, EventArgs e)
        {
            try
            {
              if(string.IsNullOrWhiteSpace(txtBolumId.Text)||string.IsNullOrWhiteSpace(txtBolumAd.Text))
                {
                  MessageBox.Show("Lütfen Tüm Alanları Doldurun");
                }
                else
                {
                   
                    SqlCommand komut = new SqlCommand("update  Bolumler set bolumAd=@p1 where bolumId=@p2", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", txtBolumAd.Text);
                    komut.Parameters.AddWithValue("@p2", txtBolumId.Text);
                    komut.ExecuteNonQuery();
                    bgl.Baglanti().Close();
                    MessageBox.Show("Bölüm Başarıyla Güncellendi.");
                    this.bolumlerTableAdapter.Fill(this.dbYurtOtomasyonDataSet.Bolumler);
                    txtBolumAd.Clear();
                    txtBolumId.Clear();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu Tekrar Deneyin.");
            }
        }
         
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, bolumAd;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
           bolumAd = dataGridView1.Rows[secilen].Cells[1].Value.ToString();

            txtBolumAd.Text = bolumAd;
            txtBolumId.Text = id;
        }
    }
}
