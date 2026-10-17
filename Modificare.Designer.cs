namespace Smartphones
{
    partial class Modificare
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtUnitatiPeStoc;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtDataAparitie;
        private System.Windows.Forms.TextBox txtIdProducator;
        private System.Windows.Forms.Button btnSalveaza;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtUnitatiPeStoc = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtDataAparitie = new System.Windows.Forms.TextBox();
            this.txtIdProducator = new System.Windows.Forms.TextBox();
            this.btnSalveaza = new System.Windows.Forms.Button();
            this.SuspendLayout();
            this.txtModel.Location = new System.Drawing.Point(12, 12);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 31);
            this.txtModel.TabIndex = 1;
            this.txtUnitatiPeStoc.Location = new System.Drawing.Point(12, 38);
            this.txtUnitatiPeStoc.Name = "txtUnitatiPeStoc";
            this.txtUnitatiPeStoc.Size = new System.Drawing.Size(100, 31);
            this.txtUnitatiPeStoc.TabIndex = 2;
            this.txtPret.Location = new System.Drawing.Point(12, 64);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(100, 31);
            this.txtPret.TabIndex = 3;
            this.txtDataAparitie.Location = new System.Drawing.Point(12, 90);
            this.txtDataAparitie.Name = "txtDataAparitie";
            this.txtDataAparitie.Size = new System.Drawing.Size(100, 31);
            this.txtDataAparitie.TabIndex = 4;
            this.txtIdProducator.Location = new System.Drawing.Point(12, 116);
            this.txtIdProducator.Name = "txtIdProducator";
            this.txtIdProducator.Size = new System.Drawing.Size(100, 31);
            this.txtIdProducator.TabIndex = 5;
            this.btnSalveaza.Location = new System.Drawing.Point(12, 153);
            this.btnSalveaza.Name = "btnSalveaza";
            this.btnSalveaza.Size = new System.Drawing.Size(161, 88);
            this.btnSalveaza.TabIndex = 6;
            this.btnSalveaza.Text = "Salveaza";
            this.btnSalveaza.UseVisualStyleBackColor = true;
            this.btnSalveaza.Click += new System.EventHandler(this.btnSalveaza_Click);
            this.ClientSize = new System.Drawing.Size(838, 567);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtUnitatiPeStoc);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.txtDataAparitie);
            this.Controls.Add(this.txtIdProducator);
            this.Controls.Add(this.btnSalveaza);
            this.Name = "Modificare";
            this.Text = "Modificare Smartphone";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
