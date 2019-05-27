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
    public partial class frm_SubeDuzenle : Form
    {
        private string subeId;
        public event EventHandler EditItemCompleted;
        public frm_SubeDuzenle(string subeId)
        {
            InitializeComponent();
            this.subeId = subeId;
        }

        private void frm_SubeDuzenle_Load(object sender, EventArgs e)
        {
            var duzenlenecekSube = Program.isBirimi.Subeler.SingleOrDefault(x => x.Id == subeId);
            txtSubeAdi.Text = duzenlenecekSube.SubeAdi;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Program.isBirimi.SubeDuzenle(subeId, txtSubeAdi.Text);
            if (EditItemCompleted != null)
            {
                EditItemCompleted(this, null);
            }
            this.Close();
        }
    }
}
