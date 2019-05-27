namespace EgitimKayitUI
{
    partial class frm_Ogrenciler
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
            this.dgvOgrenciler = new System.Windows.Forms.DataGridView();
            this.Col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Adi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Soyadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Telefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctxDuzenle = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).BeginInit();
            this.ctxDuzenle.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvOgrenciler
            // 
            this.dgvOgrenciler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenciler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_Id,
            this.Col_Adi,
            this.Col_Soyadi,
            this.Col_Telefon,
            this.Col_Email});
            this.dgvOgrenciler.ContextMenuStrip = this.ctxDuzenle;
            this.dgvOgrenciler.Location = new System.Drawing.Point(12, 51);
            this.dgvOgrenciler.Name = "dgvOgrenciler";
            this.dgvOgrenciler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOgrenciler.Size = new System.Drawing.Size(698, 292);
            this.dgvOgrenciler.TabIndex = 0;
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
            this.Col_Adi.DataPropertyName = "OgrenciAdi";
            this.Col_Adi.HeaderText = "Öğrenci Adı";
            this.Col_Adi.Name = "Col_Adi";
            // 
            // Col_Soyadi
            // 
            this.Col_Soyadi.DataPropertyName = "OgrenciSoyadi";
            this.Col_Soyadi.HeaderText = "Öğrenci Soyadı";
            this.Col_Soyadi.Name = "Col_Soyadi";
            // 
            // Col_Telefon
            // 
            this.Col_Telefon.DataPropertyName = "Telefon";
            this.Col_Telefon.HeaderText = "Telefon";
            this.Col_Telefon.Name = "Col_Telefon";
            // 
            // Col_Email
            // 
            this.Col_Email.DataPropertyName = "Email";
            this.Col_Email.HeaderText = "Email";
            this.Col_Email.Name = "Col_Email";
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
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(12, 12);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(133, 33);
            this.btnOgrenciEkle.TabIndex = 1;
            this.btnOgrenciEkle.Text = "Öğrenci Ekle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // frm_Ogrenciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOgrenciEkle);
            this.Controls.Add(this.dgvOgrenciler);
            this.Name = "frm_Ogrenciler";
            this.Text = "Ogrenciler";
            this.Load += new System.EventHandler(this.frm_Ogrenciler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenciler)).EndInit();
            this.ctxDuzenle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenciler;
        private System.Windows.Forms.Button btnOgrenciEkle;
        private System.Windows.Forms.ContextMenuStrip ctxDuzenle;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Adi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Soyadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Telefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Email;
    }
}