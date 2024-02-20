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
    public partial class frmGider : Form
    {
        public frmGider()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void btnGiderKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand komut = new SqlCommand("Insert into Giderler(elektrik,su,doğalgaz,internet,gıda,personel,diğer) values(@p1,@p2,@p3,@p4,@p5,@p6,@p7)", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", txtElektrik.Text);
                komut.Parameters.AddWithValue("@p2", txtSu.Text);
                komut.Parameters.AddWithValue("@p3", txtDogalgaz.Text);
                komut.Parameters.AddWithValue("@p4", txtInternet.Text);
                komut.Parameters.AddWithValue("@p5", txtGida.Text);
                komut.Parameters.AddWithValue("@p6", txtPersonel.Text);
                komut.Parameters.AddWithValue("@p7", txtDiger.Text);

                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();
                MessageBox.Show("Kayıt eklendi.");
            }
            catch (Exception)
            {

                MessageBox.Show("Hata oluştu yeniden deneyin.");
            }

        }
    }
}
