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
    public partial class frm_Subeler : Form
    {
        BindingSource bs = new BindingSource();
        public frm_Subeler()
        {
            InitializeComponent();
        }

        private void frm_Subeler_Load(object sender, EventArgs e)
        {
            bs.DataSource = Program.isBirimi.SubeGetir();
            dgv_Subeler.DataSource = bs;
        }

        private void btnSubeEkle_Click(object sender, EventArgs e)
        {
            frm_SubeEkle frm_SubeEkle = new frm_SubeEkle();
            if (frm_SubeEkle.ShowDialog()==DialogResult.OK)
            {
                bs.ResetBindings(false);
            }
            
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_SubeDuzenle frm_SubeDuzenle = new frm_SubeDuzenle(dgv_Subeler.SelectedRows[0].Cells["Col_Id"].Value.ToString());
            frm_SubeDuzenle.EditItemCompleted += Frm_SubeDuzenle_EditItemCompleted;
            frm_SubeDuzenle.Show();
        }

        private void Frm_SubeDuzenle_EditItemCompleted(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }
    }
}
