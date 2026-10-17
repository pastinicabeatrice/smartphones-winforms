using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Smartphones
{
    public partial class Modificare : Form
    {
        public Smartphone EditedSmartphone { get; private set; }
        private List<Producator> producatori;

        public Modificare(Smartphone smartphone, List<Producator> producatori)
        {
            InitializeComponent();
            this.producatori = producatori;

            txtModel.Text = smartphone.Model;
            txtUnitatiPeStoc.Text = smartphone.UnitatiPeStoc.ToString();
            txtPret.Text = smartphone.Pret.ToString();
            txtDataAparitie.Text = smartphone.DataAparitiei.ToString("yyyy-MM-dd");
            txtIdProducator.Text = smartphone.IdProducator.ToString();

            EditedSmartphone = smartphone;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            try
            {
                int IdProducator = int.Parse(txtIdProducator.Text);
                if (!producatori.Exists(p => p.Id == IdProducator))
                {
                    throw new Exception("Producator invalid.");
                }

                EditedSmartphone.Model = txtModel.Text;
                EditedSmartphone.UnitatiPeStoc = int.Parse(txtUnitatiPeStoc.Text);
                EditedSmartphone.Pret = decimal.Parse(txtPret.Text);
                EditedSmartphone.DataAparitiei = DateTime.Parse(txtDataAparitie.Text);
                EditedSmartphone.IdProducator = IdProducator;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                errorProvider.SetError(btnSalveaza, ex.Message);
            }
        }
    }
}
