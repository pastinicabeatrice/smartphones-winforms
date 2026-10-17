using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Smartphones
{
    public partial class Aplicatie : Form
    {
        private const string FisierProducatori = "producatori.txt";
        private readonly List<Smartphone> smartphones = new List<Smartphone>();
        private readonly List<Producator> producatori = new List<Producator>();
        private int urmatorulId = 1;

        public Aplicatie()
        {
            InitializeComponent();
            dgvSmartphones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSmartphones.MultiSelect = false;
            dgvSmartphones.ReadOnly = true;
            dgvSmartphones.AllowUserToAddRows = false;

            IncarcaProducatori(FisierProducatori);
            AdaugaSmartphone(new Smartphone { Model = "Galaxy S24", UnitatiPeStoc = 15, Pret = 4299m, DataAparitiei = new DateTime(2024, 1, 31), IdProducator = 1 });
            AdaugaSmartphone(new Smartphone { Model = "iPhone 15", UnitatiPeStoc = 8, Pret = 4899m, DataAparitiei = new DateTime(2023, 9, 22), IdProducator = 2 });
            ActualizeazaGrid();
        }

        private void IncarcaProducatori(string cale)
        {
            if (File.Exists(cale))
            {
                foreach (var linie in File.ReadAllLines(cale))
                {
                    var parti = linie.Split(',');
                    int id;
                    if (parti.Length == 2 && int.TryParse(parti[0].Trim(), out id))
                    {
                        producatori.Add(new Producator { Id = id, Name = parti[1].Trim() });
                    }
                }
            }
            if (producatori.Count == 0)
            {
                producatori.Add(new Producator { Id = 1, Name = "Samsung" });
                producatori.Add(new Producator { Id = 2, Name = "Apple" });
                producatori.Add(new Producator { Id = 3, Name = "Xiaomi" });
            }
        }

        private void AdaugaSmartphone(Smartphone s)
        {
            s.Id = urmatorulId++;
            smartphones.Add(s);
        }

        private string NumeProducator(int id)
        {
            var p = producatori.FirstOrDefault(x => x.Id == id);
            return p == null ? "?" : p.Name;
        }

        private void ActualizeazaGrid()
        {
            dgvSmartphones.DataSource = null;
            dgvSmartphones.DataSource = smartphones
                .Select(s => new
                {
                    s.Id,
                    s.Model,
                    Producator = NumeProducator(s.IdProducator),
                    s.UnitatiPeStoc,
                    s.Pret,
                    DataAparitiei = s.DataAparitiei.ToString("yyyy-MM-dd"),
                    ValoareStoc = s.Pret * s.UnitatiPeStoc
                })
                .ToList();
            Text = "Smartphones - " + smartphones.Count + " modele, valoare stoc " +
                   smartphones.Sum(s => s.Pret * s.UnitatiPeStoc).ToString("N2") + " lei";
        }

        private Smartphone SmartphoneSelectat()
        {
            if (dgvSmartphones.CurrentRow == null)
            {
                return null;
            }
            int id = (int)dgvSmartphones.CurrentRow.Cells[0].Value;
            return smartphones.FirstOrDefault(s => s.Id == id);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            using (var addForm = new SmartphonesAdd(producatori))
            {
                if (addForm.ShowDialog(this) == DialogResult.OK)
                {
                    AdaugaSmartphone(addForm.NewSmartphone);
                    ActualizeazaGrid();
                }
            }
        }

        private void Editeaza()
        {
            var smartphone = SmartphoneSelectat();
            if (smartphone == null)
            {
                return;
            }
            using (var editForm = new Modificare(smartphone, producatori))
            {
                if (editForm.ShowDialog(this) == DialogResult.OK)
                {
                    ActualizeazaGrid();
                }
            }
        }

        private void Sterge()
        {
            var smartphone = SmartphoneSelectat();
            if (smartphone == null)
            {
                return;
            }
            if (MessageBox.Show("Stergeti modelul " + smartphone.Model + "?", "Confirmare",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                smartphones.Remove(smartphone);
                ActualizeazaGrid();
            }
        }

        private void btnActualizeaza_Click(object sender, EventArgs e)
        {
            Editeaza();
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            Sterge();
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editeaza();
        }

        private void stergeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sterge();
        }

        private void Aplicatie_Load(object sender, EventArgs e)
        {
            dgvSmartphones.AutoResizeColumns();
        }
    }
}
