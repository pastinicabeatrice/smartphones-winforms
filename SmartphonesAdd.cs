using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Smartphones
{
    public partial class SmartphonesAdd : Form
    {
        public Smartphone NewSmartphone { get; private set; }
        private List<Producator> producatori;

        public SmartphonesAdd(List<Producator> producatori)
        {
            InitializeComponent();
            this.producatori = producatori;
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            ErrorProvider errorProvider = new ErrorProvider();

            try
            {
                int IdProducator = int.Parse(txtIdProducator.Text);
                if (!producatori.Exists(p => p.Id == IdProducator))
                {
                    throw new Exception("Producator invalid.");
                }

                NewSmartphone = new Smartphone
                {
                    Model = txtModel.Text,
                    UnitatiPeStoc = int.Parse(txtUnitatiPeStoc.Text),
                    Pret = decimal.Parse(txtPret.Text),
                    DataAparitiei = DateTime.Parse(txtDataAparitie.Text),
                    IdProducator = IdProducator
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                errorProvider.SetError(btnAdauga, ex.Message);
            }
        }
    }
}
