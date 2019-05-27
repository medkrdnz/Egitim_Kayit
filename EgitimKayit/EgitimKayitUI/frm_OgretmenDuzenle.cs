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
    public partial class frm_OgretmenDuzenle : Form
    {
        public event EventHandler EditItemCompleted;
        private string ogretmenId;
        public frm_OgretmenDuzenle(string ogretmenId)
        {
            InitializeComponent();
            this.ogretmenId = ogretmenId;
        }

        private void frm_OgretmenDuzenle_Load(object sender, EventArgs e)
        {
            var duzenlenecekOgretmen = Program.isBirimi.Ogretmenler.SingleOrDefault(x => x.Id == ogretmenId);
            txtOgretmenAdi.Text = duzenlenecekOgretmen.OgretmenAdi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Program.isBirimi.OgretmenDuzenle(ogretmenId,txtOgretmenAdi.Text);
            if (EditItemCompleted != null)
            {
                EditItemCompleted(this, null);
            }
            this.Close();
        }
    }
}
