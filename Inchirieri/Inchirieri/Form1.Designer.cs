namespace Inchirieri
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.nudAn = new System.Windows.Forms.NumericUpDown();
            this.nudPret = new System.Windows.Forms.NumericUpDown();
            this.chkInchiriata = new System.Windows.Forms.CheckBox();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblAn = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.btnAdaugaMasina = new System.Windows.Forms.Button();
            this.txtCauta = new System.Windows.Forms.TextBox();
            this.btnCauta = new System.Windows.Forms.Button();
            this.txtRezultatCautare = new System.Windows.Forms.TextBox();
            this.rbAutomata = new System.Windows.Forms.RadioButton();
            this.cmbMasiniDisponibile = new System.Windows.Forms.ComboBox();
            this.btnInchiriaza1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(474, 327);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(622, 225);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Coral;
            this.textBox1.Location = new System.Drawing.Point(402, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(153, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Lista masini pentru inchiriat";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(214, 51);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 2;
            // 
            // nudAn
            // 
            this.nudAn.Location = new System.Drawing.Point(214, 99);
            this.nudAn.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.nudAn.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAn.Name = "nudAn";
            this.nudAn.Size = new System.Drawing.Size(100, 20);
            this.nudAn.TabIndex = 3;
            this.nudAn.Value = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAn.ValueChanged += new System.EventHandler(this.nudAn_ValueChanged);
            // 
            // nudPret
            // 
            this.nudPret.Location = new System.Drawing.Point(214, 149);
            this.nudPret.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nudPret.Name = "nudPret";
            this.nudPret.Size = new System.Drawing.Size(100, 20);
            this.nudPret.TabIndex = 4;
            // 
            // chkInchiriata
            // 
            this.chkInchiriata.AutoSize = true;
            this.chkInchiriata.Location = new System.Drawing.Point(214, 194);
            this.chkInchiriata.Name = "chkInchiriata";
            this.chkInchiriata.Size = new System.Drawing.Size(69, 17);
            this.chkInchiriata.TabIndex = 5;
            this.chkInchiriata.Text = "Inchiriata";
            this.chkInchiriata.UseVisualStyleBackColor = true;
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(49, 51);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 6;
            this.lblNume.Text = "Nume";
            this.lblNume.Click += new System.EventHandler(this.lblNume_Click);
            // 
            // lblAn
            // 
            this.lblAn.AutoSize = true;
            this.lblAn.Location = new System.Drawing.Point(49, 99);
            this.lblAn.Name = "lblAn";
            this.lblAn.Size = new System.Drawing.Size(20, 13);
            this.lblAn.TabIndex = 7;
            this.lblAn.Text = "An";
            this.lblAn.Click += new System.EventHandler(this.lblAn_Click);
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(49, 151);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 8;
            this.lblPret.Text = "Pret";
            // 
            // btnAdaugaMasina
            // 
            this.btnAdaugaMasina.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnAdaugaMasina.Location = new System.Drawing.Point(121, 265);
            this.btnAdaugaMasina.Name = "btnAdaugaMasina";
            this.btnAdaugaMasina.Size = new System.Drawing.Size(69, 23);
            this.btnAdaugaMasina.TabIndex = 9;
            this.btnAdaugaMasina.Text = "Adauga";
            this.btnAdaugaMasina.UseVisualStyleBackColor = false;
            this.btnAdaugaMasina.Click += new System.EventHandler(this.BtnAdaugaMasina_Click);
            // 
            // txtCauta
            // 
            this.txtCauta.Location = new System.Drawing.Point(152, 375);
            this.txtCauta.Name = "txtCauta";
            this.txtCauta.Size = new System.Drawing.Size(120, 20);
            this.txtCauta.TabIndex = 10;
            this.txtCauta.Text = "Cauta masini automate";
            this.txtCauta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCauta
            // 
            this.btnCauta.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btnCauta.Location = new System.Drawing.Point(177, 411);
            this.btnCauta.Name = "btnCauta";
            this.btnCauta.Size = new System.Drawing.Size(75, 23);
            this.btnCauta.TabIndex = 11;
            this.btnCauta.Text = "Cauta";
            this.btnCauta.UseVisualStyleBackColor = false;
            this.btnCauta.Click += new System.EventHandler(this.btnCauta_Click_1);
            // 
            // txtRezultatCautare
            // 
            this.txtRezultatCautare.Location = new System.Drawing.Point(52, 452);
            this.txtRezultatCautare.Multiline = true;
            this.txtRezultatCautare.Name = "txtRezultatCautare";
            this.txtRezultatCautare.ReadOnly = true;
            this.txtRezultatCautare.Size = new System.Drawing.Size(352, 100);
            this.txtRezultatCautare.TabIndex = 12;
            // 
            // rbAutomata
            // 
            this.rbAutomata.AutoSize = true;
            this.rbAutomata.Location = new System.Drawing.Point(52, 194);
            this.rbAutomata.Name = "rbAutomata";
            this.rbAutomata.Size = new System.Drawing.Size(70, 17);
            this.rbAutomata.TabIndex = 13;
            this.rbAutomata.TabStop = true;
            this.rbAutomata.Text = "Automata";
            this.rbAutomata.UseVisualStyleBackColor = true;
            // 
            // cmbMasiniDisponibile
            // 
            this.cmbMasiniDisponibile.FormattingEnabled = true;
            this.cmbMasiniDisponibile.Location = new System.Drawing.Point(500, 115);
            this.cmbMasiniDisponibile.Name = "cmbMasiniDisponibile";
            this.cmbMasiniDisponibile.Size = new System.Drawing.Size(120, 21);
            this.cmbMasiniDisponibile.TabIndex = 14;
            // 
            // btnInchiriaza1
            // 
            this.btnInchiriaza1.Location = new System.Drawing.Point(700, 113);
            this.btnInchiriaza1.Name = "btnInchiriaza1";
            this.btnInchiriaza1.Size = new System.Drawing.Size(75, 23);
            this.btnInchiriaza1.TabIndex = 15;
            this.btnInchiriaza1.Text = "Inchiriaza";
            this.btnInchiriaza1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1231, 629);
            this.Controls.Add(this.btnInchiriaza1);
            this.Controls.Add(this.cmbMasiniDisponibile);
            this.Controls.Add(this.rbAutomata);
            this.Controls.Add(this.txtRezultatCautare);
            this.Controls.Add(this.btnCauta);
            this.Controls.Add(this.txtCauta);
            this.Controls.Add(this.btnAdaugaMasina);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.lblAn);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.chkInchiriata);
            this.Controls.Add(this.nudPret);
            this.Controls.Add(this.nudAn);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Inchirieri masini";
            ((System.ComponentModel.ISupportInitialize)(this.nudAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPret)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.NumericUpDown nudAn;
        private System.Windows.Forms.NumericUpDown nudPret;
        private System.Windows.Forms.CheckBox chkInchiriata;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblAn;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.Button btnAdaugaMasina;
        private System.Windows.Forms.TextBox txtCauta;
        private System.Windows.Forms.Button btnCauta;
        private System.Windows.Forms.TextBox txtRezultatCautare;
        private System.Windows.Forms.RadioButton rbAutomata;
        private System.Windows.Forms.ComboBox cmbMasiniDisponibile;
        private System.Windows.Forms.Button btnInchiriaza1;
    }
}

