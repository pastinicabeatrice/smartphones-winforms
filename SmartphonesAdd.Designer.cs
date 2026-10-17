namespace Smartphones
{
    partial class SmartphonesAdd
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
            this.btnAdauga = new System.Windows.Forms.Button();
            this.lblProducator = new System.Windows.Forms.Label();
            this.lblDataAparitie = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.lblUnitatiPeStoc = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.txtIdProducator = new System.Windows.Forms.TextBox();
            this.txtDataAparitie = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.txtUnitatiPeStoc = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            this.btnAdauga.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAdauga.Location = new System.Drawing.Point(373, 17);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(172, 67);
            this.btnAdauga.TabIndex = 24;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            this.lblProducator.AutoSize = true;
            this.lblProducator.Location = new System.Drawing.Point(26, 172);
            this.lblProducator.Name = "lblProducator";
            this.lblProducator.Size = new System.Drawing.Size(117, 25);
            this.lblProducator.TabIndex = 23;
            this.lblProducator.Text = "Producator";
            this.lblDataAparitie.AutoSize = true;
            this.lblDataAparitie.Location = new System.Drawing.Point(23, 136);
            this.lblDataAparitie.Name = "lblDataAparitie";
            this.lblDataAparitie.Size = new System.Drawing.Size(136, 25);
            this.lblDataAparitie.TabIndex = 22;
            this.lblDataAparitie.Text = "Data Aparitie";
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(23, 99);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(51, 25);
            this.lblPret.TabIndex = 21;
            this.lblPret.Text = "Pret";
            this.lblUnitatiPeStoc.AutoSize = true;
            this.lblUnitatiPeStoc.Location = new System.Drawing.Point(23, 59);
            this.lblUnitatiPeStoc.Name = "lblUnitatiPeStoc";
            this.lblUnitatiPeStoc.Size = new System.Drawing.Size(149, 25);
            this.lblUnitatiPeStoc.TabIndex = 20;
            this.lblUnitatiPeStoc.Text = "Unitati pe stoc";
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(23, 23);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(71, 25);
            this.lblModel.TabIndex = 19;
            this.lblModel.Text = "Model";
            this.txtIdProducator.Location = new System.Drawing.Point(178, 170);
            this.txtIdProducator.Name = "txtIdProducator";
            this.txtIdProducator.Size = new System.Drawing.Size(142, 31);
            this.txtIdProducator.TabIndex = 18;
            this.txtDataAparitie.Location = new System.Drawing.Point(178, 130);
            this.txtDataAparitie.Name = "txtDataAparitie";
            this.txtDataAparitie.Size = new System.Drawing.Size(142, 31);
            this.txtDataAparitie.TabIndex = 17;
            this.txtPret.Location = new System.Drawing.Point(178, 93);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(142, 31);
            this.txtPret.TabIndex = 16;
            this.txtUnitatiPeStoc.Location = new System.Drawing.Point(178, 56);
            this.txtUnitatiPeStoc.Name = "txtUnitatiPeStoc";
            this.txtUnitatiPeStoc.Size = new System.Drawing.Size(142, 31);
            this.txtUnitatiPeStoc.TabIndex = 15;
            this.txtModel.Location = new System.Drawing.Point(178, 17);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(142, 31);
            this.txtModel.TabIndex = 14;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 469);
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
            this.Name = "SmartphonesAdd";
            this.Text = "SmartphonesAdd";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Label lblProducator;
        private System.Windows.Forms.Label lblDataAparitie;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Label lblUnitatiPeStoc;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtIdProducator;
        private System.Windows.Forms.TextBox txtDataAparitie;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.TextBox txtUnitatiPeStoc;
        private System.Windows.Forms.TextBox txtModel;
    }
}