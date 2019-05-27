using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EgitimKayitUI
{
    public partial class frm_OgrenciDuzenle : Form
    {
        public event EventHandler EditItemCompleted;
        private string ogrenciId;
        public frm_OgrenciDuzenle(string ogrenciId)
        {
            InitializeComponent();
            this.ogrenciId = ogrenciId;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Program.isBirimi.OgrenciDuzenle(ogrenciId, txtAd.Text, txtSoyad.Text, txtTelefon.Text, txtEmail.Text);
            if (EditItemCompleted!=null)
            {
                EditItemCompleted(this, null);
            }
            this.Close();
        }

        private void frm_OgrenciDuzenle_Load(object sender, EventArgs e)
        {
            var duzenlenecekOgrenci = Program.isBirimi.Ogrenciler.SingleOrDefault(x => x.Id == ogrenciId);
            txtAd.Text = duzenlenecekOgrenci.OgrenciAdi;
            txtSoyad.Text = duzenlenecekOgrenci.OgrenciSoyadi;
            txtTelefon.Text = duzenlenecekOgrenci.Telefon;
            txtEmail.Text = duzenlenecekOgrenci.Email;
        }

    }
}
