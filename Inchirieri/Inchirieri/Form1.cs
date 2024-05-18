using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Inchirieri
{
    public partial class Form1 : Form
    {
        private const int MinAn = 1900;
        private readonly int MaxAn = DateTime.Now.Year;
        private const decimal MinPret = 0;
        private List<Masina> masini;
        private ComboBox cmbMasiniInchiriate;
        private Button btnReturneaza;

        public Form1()
        {
            InitializeComponent();
            masini = new List<Masina>();
            InitializeMasini();
            AfiseazaMasini();
            PopuleazaComboBoxMasiniDisponibile();
            InitializeUIComponents();
            InitializeReturnUI();
            PopuleazaComboBoxMasiniInchiriate();
            this.btnInchiriaza1.Click += new EventHandler(this.btnInchiriaza1_Click);
        }

        private void InitializeMasini()
        {
            string filePath = @"C:\Users\tomam\OneDrive\Desktop\Inchirieri\Inchirieri\masini.txt";
            try
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var parts = line.Split(',');
                    if (parts.Length == 5) // Acum avem cinci componente pentru că am adăugat informația despre automatizare
                    {
                        Masina masina = new Masina
                        {
                            Nume = parts[0],
                            An = int.Parse(parts[1]),
                            Pret = decimal.Parse(parts[2]),
                            Inchiriata = bool.Parse(parts[3]),
                            EsteAutomata = bool.Parse(parts[4]) // Noua informație despre automatizare
                        };
                        masini.Add(masina);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la citirea fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AfiseazaMasini()
        {
            flowLayoutPanel1.Controls.Clear(); // Curăță panoul înainte de a afișa mașinile
            foreach (Masina masina in masini)
            {
                AdaugaMasinaLaFormular(masina);
            }
        }

        private void AdaugaMasinaLaFormular(Masina masina)
        {
            TextBox textBoxNume = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Nume: {masina.Nume}"
            };

            TextBox textBoxAn = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"An: {masina.An}"
            };

            TextBox textBoxPret = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Preț: {masina.Pret} lei/zi"
            };

            TextBox textBoxInchiriata = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Stare: {(masina.Inchiriata ? "Închiriată" : "Disponibilă")}"
            };

            TextBox textBoxAutomata = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = $"Automată: {(masina.EsteAutomata ? "Da" : "Nu")}" // Afișează "Da" dacă mașina este automată, altfel "Nu"
            };

            flowLayoutPanel1.Controls.Add(textBoxNume);
            flowLayoutPanel1.Controls.Add(textBoxAn);
            flowLayoutPanel1.Controls.Add(textBoxPret);
            flowLayoutPanel1.Controls.Add(textBoxInchiriata);
            flowLayoutPanel1.Controls.Add(textBoxAutomata); // Adaugă TextBox-ul pentru informația despre automatizare la formular
        }

        private void InitializeUIComponents()
        {
            TextBox textBoxInchiriaza = new TextBox
            {
                Multiline = true,
                ReadOnly = true,
                Text = "Închiriază mașini",
                Location = new Point(500, 50),
                Size = new Size(100, 40),
                Font = new Font("Arial", 12, FontStyle.Bold),
                ForeColor = Color.Blue,
                BackColor = Color.LightGray,
                TextAlign = HorizontalAlignment.Center
            };

            this.Controls.Add(textBoxInchiriaza); // Adaugă textbox-ul la colecția de controale a formularului principal
        }

        private void ResetFields()
        {
            txtNume.Text = "";
            nudAn.Value = DateTime.Now.Year;
            nudPret.Value = 0;
            chkInchiriata.Checked = false;
            rbAutomata.Checked = false;

            lblNume.ForeColor = Color.Black;
            lblNume.Text = "Nume:";
            lblAn.ForeColor = Color.Black;
            lblAn.Text = "An:";
            lblPret.ForeColor = Color.Black;
            lblPret.Text = "Preț:";
        }

        private void BtnAdaugaMasina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                lblNume.ForeColor = Color.Red;
                lblNume.Text = "Nume: Introduceți un nume!";
                return;
            }

            if (nudAn.Value < MinAn || nudAn.Value > MaxAn)
            {
                lblAn.ForeColor = Color.Red;
                lblAn.Text = $"An: Introduceți un an între {MinAn} și {MaxAn}!";
                return;
            }

            if (nudPret.Value <= MinPret)
            {
                lblPret.ForeColor = Color.Red;
                lblPret.Text = $"Preț: Introduceți un preț pozitiv!";
                return;
            }

            Masina masina = new Masina
            {
                Nume = txtNume.Text,
                An = (int)nudAn.Value,
                Pret = nudPret.Value,
                Inchiriata = chkInchiriata.Checked,
                EsteAutomata = rbAutomata.Checked
            };

            masini.Add(masina);

            // Salvare masini in fisier
            SalveazaMasiniInFisier();

            // Afisare masina adaugata in formular
            AdaugaMasinaLaFormular(masina);

            ResetFields();
            PopuleazaComboBoxMasiniDisponibile();
        }

        private void SalveazaMasiniInFisier()
        {
            string filePath = @"C:\Users\tomam\OneDrive\Desktop\Inchirieri\Inchirieri\masini.txt";
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Masina masina in masini)
                    {
                        writer.WriteLine($"{masina.Nume},{masina.An},{masina.Pret},{masina.Inchiriata},{masina.EsteAutomata}");
                    }
                }
                MessageBox.Show("Datele au fost salvate cu succes în fișier!", "Salvare reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la salvarea datelor în fișier: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopuleazaComboBoxMasiniDisponibile()
        {
            cmbMasiniDisponibile.Items.Clear();
            foreach (var masina in masini)
            {
                if (!masina.Inchiriata)
                {
                    cmbMasiniDisponibile.Items.Add(masina.Nume);
                }
            }
        }

        private void btnInchiriaza1_Click(object sender, EventArgs e)
        {
            if (cmbMasiniDisponibile.SelectedItem == null)
            {
                MessageBox.Show("Selectați o mașină pentru închiriere.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string numeMasinaSelectata = cmbMasiniDisponibile.SelectedItem.ToString();
            var masinaDeInchiriat = masini.Find(m => m.Nume == numeMasinaSelectata);

            if (masinaDeInchiriat != null)
            {
                masinaDeInchiriat.Inchiriata = true;
                SalveazaMasiniInFisier();
                MessageBox.Show($"Mașina {masinaDeInchiriat.Nume} a fost închiriată cu succes!", "Închiriere reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopuleazaComboBoxMasiniDisponibile();
                flowLayoutPanel1.Controls.Clear();
                AfiseazaMasini();
                PopuleazaComboBoxMasiniInchiriate(); // Actualizează și lista de mașini închiriate
            }
        }

        public class Masina
        {
            public string Nume { get; set; }
            public int An { get; set; }
            public decimal Pret { get; set; }
            public bool Inchiriata { get; set; }
            public bool EsteAutomata { get; set; }
        }

        private void lblAn_Click(object sender, EventArgs e)
        {
            // Evenimentul pentru click pe eticheta an
        }

        private void lblNume_Click(object sender, EventArgs e)
        {
            // Evenimentul pentru click pe eticheta nume
        }

        private void nudAn_ValueChanged(object sender, EventArgs e)
        {
            // Evenimentul pentru schimbarea valorii anului
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            // Evenimentul pentru desenarea panoului de layout
        }

        private void btnCauta_Click_1(object sender, EventArgs e)
        {
            // Resetare TextBox-ul de rezultate
            txtRezultatCautare.Text = "";

            // Calea către fișierul text
            string caleFisier = @"C:\Users\tomam\OneDrive\Desktop\Inchirieri\Inchirieri\masini.txt";

            // Verificare dacă fișierul există
            if (!File.Exists(caleFisier))
            {
                MessageBox.Show("Fișierul masini.txt nu a fost găsit.");
                return;
            }

            // Citirea datelor din fișier și căutarea mașinilor automate
            try
            {
                string[] linii = File.ReadAllLines(caleFisier);

                bool found = false;
                foreach (string linie in linii)
                {
                    string[] split = linie.Split(',');

                    if (split.Length == 5 && bool.Parse(split[4])) // Verificăm dacă mașina este automată
                    {
                        txtRezultatCautare.Text += $"\nNume: {split[0]}\n An: {split[1]}\n Preț: {split[2]} lei/zi\n Stare: {(bool.Parse(split[3]) ? "Închiriată" : "Disponibilă")}\n Automată: Da\n\n\n";
                        found = true;
                    }
                }

                if (!found)
                {
                    txtRezultatCautare.Text = "Nu s-au găsit mașini automate.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"A apărut o eroare la citirea fișierului: {ex.Message}", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeReturnUI()
        {
            cmbMasiniInchiriate = new ComboBox
            {
                Location = new Point(500, 150), // Coordonatele pot varia în funcție de designul tău
                Width = 120,
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            this.Controls.Add(cmbMasiniInchiriate);

            btnReturneaza = new Button
            {
                Text = "Returnează Mașina",
                Location = new Point(700, 150), // Poziționat sub ComboBox
                Width = 120 // Ajustează dimensiunea butonului pentru a se potrivi mai bine
            };
            btnReturneaza.Click += btnReturneaza_Click;
            this.Controls.Add(btnReturneaza);
        }

        private void PopuleazaComboBoxMasiniInchiriate()
        {
            cmbMasiniInchiriate.Items.Clear();
            foreach (var masina in masini.Where(m => m.Inchiriata))
            {
                cmbMasiniInchiriate.Items.Add(masina.Nume);
            }
            if (cmbMasiniInchiriate.Items.Count > 0)
                cmbMasiniInchiriate.SelectedIndex = 0;
        }

        private void btnReturneaza_Click(object sender, EventArgs e)
        {
            if (cmbMasiniInchiriate.SelectedItem == null)
            {
                MessageBox.Show("Selectați o mașină pentru a o returna.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string numeMasinaSelectata = cmbMasiniInchiriate.SelectedItem.ToString();
            var masinaDeReturnat = masini.Find(m => m.Nume == numeMasinaSelectata);

            if (masinaDeReturnat != null)
            {
                masinaDeReturnat.Inchiriata = false;
                SalveazaMasiniInFisier();
                MessageBox.Show($"Mașina {masinaDeReturnat.Nume} a fost returnată cu succes!", "Returnare reușită", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Reîmprospătează listele sau controalele afectate
                PopuleazaComboBoxMasiniDisponibile();
                PopuleazaComboBoxMasiniInchiriate();
                flowLayoutPanel1.Controls.Clear();
                AfiseazaMasini();
            }
        }
    }
}
