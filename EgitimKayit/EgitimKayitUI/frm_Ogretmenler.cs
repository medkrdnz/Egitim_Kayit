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
    public partial class frm_Ogretmenler : Form
    {
        BindingSource bs = new BindingSource();
        public frm_Ogretmenler()
        {
            InitializeComponent();
        }

        private void btn_OgretmenEkle_Click(object sender, EventArgs e)
        {
            frm_OgretmenEkle frm_OgretmenEkle = new frm_OgretmenEkle();
            if (frm_OgretmenEkle.ShowDialog()==DialogResult.OK)
            {
                bs.ResetBindings(false);
            }
        }

        private void frm_Ogretmenler_Load(object sender, EventArgs e)
        {
            bs.DataSource = Program.isBirimi.OgretmenGetir();
            dgv_Ogretmenler.DataSource = bs;
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_OgretmenDuzenle frm_OgretmenDuzenle = new frm_OgretmenDuzenle(dgv_Ogretmenler.SelectedRows[0].Cells["Col_Id"].Value.ToString());
            frm_OgretmenDuzenle.EditItemCompleted += Frm_OgretmenDuzenle_EditItemCompleted;
            frm_OgretmenDuzenle.Show();
        }

        private void Frm_OgretmenDuzenle_EditItemCompleted(object sender, EventArgs e)
        {
            bs.ResetBindings(false);
        }
    }
}
