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
    public partial class FrmOdemeler : Form
    {
        public FrmOdemeler()
        {
            InitializeComponent();
        }
         SqlBaglantim bgl=new SqlBaglantim();
        private void FrmOdemeler_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbYurtOtomasyonDataSet2.Borclar' table. You can move, or remove it, as needed.
            this.borclarTableAdapter.Fill(this.dbYurtOtomasyonDataSet2.Borclar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id, ad, soyad, kalan;
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            id = dataGridView1.Rows[secilen].Cells[0].Value.ToString(); 
            ad = dataGridView1.Rows[secilen].Cells[1].Value.ToString(); 
            soyad = dataGridView1.Rows[secilen].Cells[2].Value.ToString(); 
            kalan = dataGridView1.Rows[secilen].Cells[3].Value.ToString(); 

            txtOgrId.Text = id;
            txtOgrAd.Text = ad;
            txtOgrSoyad.Text = soyad;
            txtKalanBorc.Text = kalan;



        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            //Ödene tutarı kalan tutardan düşme
            int odenen, kalan, yeniborc;
            odenen = Convert.ToInt32(txtOdenen.Text);
            kalan = Convert.ToInt32(txtKalanBorc.Text);
            yeniborc = kalan - odenen;
txtKalanBorc.Text = yeniborc.ToString();

            //Yeni tutarı veri tabanına kaydetme

            SqlCommand komut=new SqlCommand("update borclar set ogrKalanBorc=@p1 where ogrId=@p2",bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtKalanBorc.Text);
            komut.Parameters.AddWithValue("@p2", txtOgrId.Text);
            komut.ExecuteNonQuery();
            MessageBox.Show("Borç Ödemesi alındı");
            bgl.Baglanti().Close();
            this.borclarTableAdapter.Fill(this.dbYurtOtomasyonDataSet2.Borclar);


            //kasa tablosuna ekleme yapma

            SqlCommand komut2 = new SqlCommand("Insert into Kasa (OdemeAy , OdemeMiktar) values(@k1,@k2)", bgl.Baglanti());
            komut2.Parameters.AddWithValue("@k1", txtOdemeAy.Text);
            komut2.Parameters.AddWithValue("@k2", txtOdenen.Text);
            komut2.ExecuteNonQuery();
            bgl.Baglanti().Close();

        }
    }
}
