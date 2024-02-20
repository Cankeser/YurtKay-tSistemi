using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YurtKayıtSistemi
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

      

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbYurtOtomasyonDataSet1.Ogrenci' table. You can move, or remove it, as needed.
            this.ogrenciTableAdapter.Fill(this.dbYurtOtomasyonDataSet1.Ogrenci);
           timer1.Start();
           

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text=DateTime.Now.ToLongDateString();
            label2.Text=DateTime.Now.ToLongTimeString();
        }

        private void hesapMakinesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");
        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.exe");
        }

        private void radyo1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://n10101m.mediatriple.net/slow";
        }

        private void radyo2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://live.radyofenomen.com/fenomenturkrap/128/icecast.audio";
          
        }

        private void radyo3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "https://onlineradiobox.com/tr/turkceraphiphop";
        }

        private void öğrenciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOgrKayit frmOgrKayit=new frmOgrKayit();
            frmOgrKayit.Show();
        }

        private void öğrenciListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrListe frmOgrListe=new FrmOgrListe();
            frmOgrListe.Show();
        }

        private void çğrenciDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOgrDuzenle frmOgrDuzenle=new FrmOgrDuzenle();    
            frmOgrDuzenle.Show();
        }

        private void bölümlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBolumler frmBolumler=new frmBolumler();
            frmBolumler.Show();
        }

        private void ödemeAlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmOdemeler frmOdemeler=new FrmOdemeler();
            frmOdemeler.Show();
        }

        private void giderEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGider frmGider=new frmGider();
            frmGider.Show();
        }

        private void giderListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiderListesi frmGiderListesi=new frmGiderListesi();
                frmGiderListesi.Show();
        }

        private void gelirİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGelirIstatistik frmGelirIstatistik=new frmGelirIstatistik();
            frmGelirIstatistik.Show();
        }

        private void giderİstatistikleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGiderListesi frmGiderListesi =new frmGiderListesi();
            frmGiderListesi.Show();
        }

        private void şifreİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmYoneticiDuzenle frmYoneticiDuzenle=new frmYoneticiDuzenle();
            frmYoneticiDuzenle.Show();
        }

        private void personelDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPersonelDuzenle frmPersonelDuzenle =new frmPersonelDuzenle();
            frmPersonelDuzenle.Show();  
        }
    }
}
