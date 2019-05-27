namespace EgitimKayitUI
{
    partial class frm_Subeler
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
            this.dgv_Subeler = new System.Windows.Forms.DataGridView();
            this.ctxDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSubeEkle = new System.Windows.Forms.Button();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subeler)).BeginInit();
            this.ctxDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_Subeler
            // 
            this.dgv_Subeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Subeler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Adi});
            this.dgv_Subeler.ContextMenuStrip = this.ctxDuzenle;
            this.dgv_Subeler.Location = new System.Drawing.Point(12, 46);
            this.dgv_Subeler.Name = "dgv_Subeler";
            this.dgv_Subeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Subeler.Size = new System.Drawing.Size(460, 278);
            this.dgv_Subeler.TabIndex = 0;
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
            // btnSubeEkle
            // 
            this.btnSubeEkle.Location = new System.Drawing.Point(12, 12);
            this.btnSubeEkle.Name = "btnSubeEkle";
            this.btnSubeEkle.Size = new System.Drawing.Size(84, 28);
            this.btnSubeEkle.TabIndex = 1;
            this.btnSubeEkle.Text = "Şube Ekle";
            this.btnSubeEkle.UseVisualStyleBackColor = true;
            this.btnSubeEkle.Click += new System.EventHandler(this.btnSubeEkle_Click);
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
            this.Col_Adi.DataPropertyName = "SubeAdi";
            this.Col_Adi.HeaderText = "Şube Adı";
            this.Col_Adi.Name = "Col_Adi";
            // 
            // frm_Subeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 357);
            this.Controls.Add(this.btnSubeEkle);
            this.Controls.Add(this.dgv_Subeler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Subeler";
            this.Text = "frm_Subeler";
            this.Load += new System.EventHandler(this.frm_Subeler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Subeler)).EndInit();
            this.ctxDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Subeler;
        private System.Windows.Forms.ContextMenuStrip ctxDuzenle;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.Button btnSubeEkle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Adi;
    }
}