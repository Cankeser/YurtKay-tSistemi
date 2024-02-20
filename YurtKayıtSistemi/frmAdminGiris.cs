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
    public partial class frmAdminGiris : Form
    {
        public frmAdminGiris()
        {
            InitializeComponent();
        }
         SqlBaglantim bgl=new SqlBaglantim();
        private void btnGirisYap_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("Select * from Admin where YoneticiAd=@p1 and YoneticiSifre=@p2  ", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", txtKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@p2", txtSifre.Text);
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
               FrmAnaForm frmAnaForm = new FrmAnaForm();
                frmAnaForm.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            bgl.Baglanti().Close();
        }
    }
}
