namespace EgitimKayitUI
{
    partial class frm_Ogretmenler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgv_Ogretmenler = new System.Windows.Forms.DataGridView();
            this.btn_OgretmenEkle = new System.Windows.Forms.Button();
            this.ctxDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ogretmenler)).BeginInit();
            this.ctxDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Ogretmenler
            // 
            this.dgv_Ogretmenler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Ogretmenler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Adi});
            this.dgv_Ogretmenler.ContextMenuStrip = this.ctxDuzenle;
            this.dgv_Ogretmenler.Location = new System.Drawing.Point(12, 49);
            this.dgv_Ogretmenler.Name = "dgv_Ogretmenler";
            this.dgv_Ogretmenler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Ogretmenler.Size = new System.Drawing.Size(524, 372);
            this.dgv_Ogretmenler.TabIndex = 0;
            // 
            // btn_OgretmenEkle
            // 
            this.btn_OgretmenEkle.Location = new System.Drawing.Point(12, 12);
            this.btn_OgretmenEkle.Name = "btn_OgretmenEkle";
            this.btn_OgretmenEkle.Size = new System.Drawing.Size(102, 31);
            this.btn_OgretmenEkle.TabIndex = 1;
            this.btn_OgretmenEkle.Text = "Öğretmen Ekle";
            this.btn_OgretmenEkle.UseVisualStyleBackColor = true;
            this.btn_OgretmenEkle.Click += new System.EventHandler(this.btn_OgretmenEkle_Click);
            // 
            // ctxDuzenle
            // 
            this.ctxDuzenle.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.düzenleToolStripMenuItem});
            this.ctxDuzenle.Name = "ctxDuzenle";
            this.ctxDuzenle.Size = new System.Drawing.Size(181, 48);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // Col_Id
            // 
            this.Col_Id.DataPropertyName = "Id";
            this.Col_Id.HeaderText = "Id";
            this.Col_Id.Name = "Col_Id";
            this.Col_Id.Visible = false;
            // 
            // Col_Adi
            // 
            this.Col_Adi.DataPropertyName = "OgretmenAdi";
            this.Col_Adi.HeaderText = "Öğretmen Adı";
            this.Col_Adi.Name = "Col_Adi";
            // 
            // frm_Ogretmenler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.btn_OgretmenEkle);
            this.Controls.Add(this.dgv_Ogretmenler);
            this.Name = "frm_Ogretmenler";
            this.Text = "Ogretmenler";
            this.Load += new System.EventHandler(this.frm_Ogretmenler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Ogretmenler)).EndInit();
            this.ctxDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Ogretmenler;
        private System.Windows.Forms.Button btn_OgretmenEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Adi;
        private System.Windows.Forms.ContextMenuStrip ctxDuzenle;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}