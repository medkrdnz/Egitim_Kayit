﻿using System;
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
    public partial class frm_SubeEkle : Form
    {
        public frm_SubeEkle()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Program.isBirimi.SubeEkle(txtSubeAdi.Text);
            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
