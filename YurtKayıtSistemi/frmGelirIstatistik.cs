using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayıtSistemi
{
    public partial class frmGelirIstatistik : Form
    {
        public frmGelirIstatistik()
        {
            InitializeComponent();
        }
         SqlBaglantim bgl=new SqlBaglantim();
        private void frmGelirIstatistik_Load(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("select Sum(OdemeMiktar)  from Kasa",bgl.Baglanti());
            SqlDataReader oku=komut.ExecuteReader();
            while (oku.Read())
            {
                lblKasa.Text = oku[0].ToString() + " TL";
            }
            bgl.Baglanti().Close();

            //tekrarsız olarak ayları listeleme

            SqlCommand komut2 = new SqlCommand("Select distinct(OdemeAy) from Kasa", bgl.Baglanti());
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                cmbAy.Items.Add(oku2[0].ToString().ToUpper()); 
            }
            bgl.Baglanti().Close();

            //Grafiklere veri tabanından veri çekme

            SqlCommand komut3 = new SqlCommand("Select OdemeAy, sum(OdemeMiktar) from Kasa group by OdemeAy", bgl.Baglanti());
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                this.chart1.Series["Aylık"].Points.AddY(oku3[1]);
            }
            bgl.Baglanti().Close();




        }

        private void cmbAy_SelectedIndexChanged(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select sum(OdemeMiktar) from Kasa where OdemeAy=@p1", bgl.Baglanti());
            komut.Parameters.AddWithValue("@p1", cmbAy.Text);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblAyKazanc.Text = oku[0].ToString() + " TL";
            }
            bgl.Baglanti().Close();

        }
    }
}
