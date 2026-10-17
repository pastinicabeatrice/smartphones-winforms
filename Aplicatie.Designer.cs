namespace Smartphones
{
    partial class Aplicatie
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.dgvSmartphones = new System.Windows.Forms.DataGridView();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtUnitatiPeStoc = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtDataAparitie = new System.Windows.Forms.TextBox();
            this.txtIdProducator = new System.Windows.Forms.TextBox();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblUnitatiPeStoc = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblDataAparitie = new System.Windows.Forms.Label();
            this.lblProducator = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnActualizeaza = new System.Windows.Forms.Button();
            this.btnSterge = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stergeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmartphones)).BeginInit();
            this.SuspendLayout();
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.dgvSmartphones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSmartphones.Location = new System.Drawing.Point(12, 266);
            this.dgvSmartphones.Name = "dgvSmartphones";
            this.dgvSmartphones.RowHeadersWidth = 82;
            this.dgvSmartphones.RowTemplate.Height = 33;
            this.dgvSmartphones.Size = new System.Drawing.Size(758, 172);
            this.dgvSmartphones.TabIndex = 0;
            this.txtModel.Location = new System.Drawing.Point(167, 12);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(142, 31);
            this.txtModel.TabIndex = 1;
            this.txtUnitatiPeStoc.Location = new System.Drawing.Point(167, 51);
            this.txtUnitatiPeStoc.Name = "txtUnitatiPeStoc";
            this.txtUnitatiPeStoc.Size = new System.Drawing.Size(142, 31);
            this.txtUnitatiPeStoc.TabIndex = 2;
            this.txtPret.Location = new System.Drawing.Point(167, 88);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(142, 31);
            this.txtPret.TabIndex = 3;
            this.txtDataAparitie.Location = new System.Drawing.Point(167, 125);
            this.txtDataAparitie.Name = "txtDataAparitie";
            this.txtDataAparitie.Size = new System.Drawing.Size(142, 31);
            this.txtDataAparitie.TabIndex = 4;
            this.txtIdProducator.Location = new System.Drawing.Point(167, 165);
            this.txtIdProducator.Name = "txtIdProducator";
            this.txtIdProducator.Size = new System.Drawing.Size(142, 31);
            this.txtIdProducator.TabIndex = 5;
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(12, 18);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(71, 25);
            this.lblModel.TabIndex = 6;
            this.lblModel.Text = "Model";
            this.lblUnitatiPeStoc.AutoSize = true;
            this.lblUnitatiPeStoc.Location = new System.Drawing.Point(12, 54);
            this.lblUnitatiPeStoc.Name = "lblUnitatiPeStoc";
            this.lblUnitatiPeStoc.Size = new System.Drawing.Size(149, 25);
            this.lblUnitatiPeStoc.TabIndex = 7;
            this.lblUnitatiPeStoc.Text = "Unitati pe stoc";
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(12, 94);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(51, 25);
            this.lblPret.TabIndex = 8;
            this.lblPret.Text = "Pret";
            this.lblDataAparitie.AutoSize = true;
            this.lblDataAparitie.Location = new System.Drawing.Point(12, 131);
            this.lblDataAparitie.Name = "lblDataAparitie";
            this.lblDataAparitie.Size = new System.Drawing.Size(136, 25);
            this.lblDataAparitie.TabIndex = 9;
            this.lblDataAparitie.Text = "Data Aparitie";
            this.lblProducator.AutoSize = true;
            this.lblProducator.Location = new System.Drawing.Point(15, 167);
            this.lblProducator.Name = "lblProducator";
            this.lblProducator.Size = new System.Drawing.Size(117, 25);
            this.lblProducator.TabIndex = 10;
            this.lblProducator.Text = "Producator";
            this.btnAdauga.Location = new System.Drawing.Point(362, 12);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(172, 67);
            this.btnAdauga.TabIndex = 11;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            this.btnActualizeaza.Location = new System.Drawing.Point(362, 85);
            this.btnActualizeaza.Name = "btnActualizeaza";
            this.btnActualizeaza.Size = new System.Drawing.Size(172, 67);
            this.btnActualizeaza.TabIndex = 12;
            this.btnActualizeaza.Text = "Actualizeaza";
            this.btnActualizeaza.UseVisualStyleBackColor = true;
            this.btnActualizeaza.Click += new System.EventHandler(this.btnActualizeaza_Click);
            this.btnSterge.Location = new System.Drawing.Point(362, 158);
            this.btnSterge.Name = "btnSterge";
            this.btnSterge.Size = new System.Drawing.Size(172, 67);
            this.btnSterge.TabIndex = 13;
            this.btnSterge.Text = "Sterge";
            this.btnSterge.UseVisualStyleBackColor = true;
            this.btnSterge.Click += new System.EventHandler(this.btnSterge_Click);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editareToolStripMenuItem,
            this.stergeToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 96);
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            this.stergeToolStripMenuItem.Name = "stergeToolStripMenuItem";
            this.stergeToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.stergeToolStripMenuItem.Text = "Sterge";
            this.stergeToolStripMenuItem.Click += new System.EventHandler(this.stergeToolStripMenuItem_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSterge);
            this.Controls.Add(this.btnActualizeaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.lblProducator);
            this.Controls.Add(this.lblDataAparitie);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblUnitatiPeStoc);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtIdProducator);
            this.Controls.Add(this.txtDataAparitie);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtUnitatiPeStoc);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.dgvSmartphones);
            this.Name = "Aplicatie";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Aplicatie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmartphones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.DataGridView dgvSmartphones;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtUnitatiPeStoc;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtDataAparitie;
        private System.Windows.Forms.TextBox txtIdProducator;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblUnitatiPeStoc;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblDataAparitie;
        private System.Windows.Forms.Label lblProducator;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnActualizeaza;
        private System.Windows.Forms.Button btnSterge;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stergeToolStripMenuItem;
    }
}
