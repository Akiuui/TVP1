namespace TVP_Projekat
{
    partial class Administrator
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
            label1 = new Label();
            tabovi = new TabControl();
            izleti_tab = new TabPage();
            panel2 = new Panel();
            panel3 = new Panel();
            panel1 = new Panel();
            dodajIzlet_btn = new Button();
            izmeniIzlet_btn = new Button();
            obrisiIzlet_btn = new Button();
            izleti_dgw = new DataGridView();
            korisnici_tab = new TabPage();
            panel5 = new Panel();
            dodajKorisnika_btn = new Button();
            obrisiKorisnika_btn = new Button();
            izmeniKorisnika_btn = new Button();
            panel4 = new Panel();
            korisnici_dgw = new DataGridView();
            Rezervacije = new TabPage();
            button1 = new Button();
            rezervacije_dgw = new DataGridView();
            izmeniRezervacije_btn = new Button();
            obrisiRezervacije_btn = new Button();
            dodajRezervacije_btn = new Button();
            tabovi.SuspendLayout();
            izleti_tab.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)izleti_dgw).BeginInit();
            korisnici_tab.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)korisnici_dgw).BeginInit();
            Rezervacije.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)rezervacije_dgw).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 22);
            label1.Name = "label1";
            label1.Size = new Size(151, 20);
            label1.TabIndex = 0;
            label1.Text = "Administratska strana";
            // 
            // tabovi
            // 
            tabovi.Controls.Add(izleti_tab);
            tabovi.Controls.Add(korisnici_tab);
            tabovi.Controls.Add(Rezervacije);
            tabovi.Dock = DockStyle.Fill;
            tabovi.Location = new Point(0, 0);
            tabovi.Name = "tabovi";
            tabovi.SelectedIndex = 0;
            tabovi.Size = new Size(1014, 450);
            tabovi.TabIndex = 1;
            // 
            // izleti_tab
            // 
            izleti_tab.Controls.Add(panel2);
            izleti_tab.Controls.Add(izleti_dgw);
            izleti_tab.Location = new Point(4, 29);
            izleti_tab.Name = "izleti_tab";
            izleti_tab.Padding = new Padding(3);
            izleti_tab.Size = new Size(1006, 417);
            izleti_tab.TabIndex = 0;
            izleti_tab.Text = "Izleti";
            izleti_tab.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 272);
            panel2.Name = "panel2";
            panel2.Size = new Size(1000, 142);
            panel2.TabIndex = 14;
            panel2.Paint += panel2_Paint;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel1);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 17);
            panel3.Name = "panel3";
            panel3.Size = new Size(1000, 125);
            panel3.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(dodajIzlet_btn);
            panel1.Controls.Add(izmeniIzlet_btn);
            panel1.Controls.Add(obrisiIzlet_btn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 125);
            panel1.TabIndex = 13;
            // 
            // dodajIzlet_btn
            // 
            dodajIzlet_btn.Dock = DockStyle.Left;
            dodajIzlet_btn.Location = new Point(0, 0);
            dodajIzlet_btn.Name = "dodajIzlet_btn";
            dodajIzlet_btn.Size = new Size(271, 125);
            dodajIzlet_btn.TabIndex = 9;
            dodajIzlet_btn.Text = "Dodaj";
            dodajIzlet_btn.UseVisualStyleBackColor = true;
            dodajIzlet_btn.Click += dodajIzlet_btn_Click;
            // 
            // izmeniIzlet_btn
            // 
            izmeniIzlet_btn.Dock = DockStyle.Right;
            izmeniIzlet_btn.Location = new Point(733, 0);
            izmeniIzlet_btn.Name = "izmeniIzlet_btn";
            izmeniIzlet_btn.Size = new Size(267, 125);
            izmeniIzlet_btn.TabIndex = 11;
            izmeniIzlet_btn.Text = "Izmeni";
            izmeniIzlet_btn.UseVisualStyleBackColor = true;
            izmeniIzlet_btn.Click += izmeniIzlet_btn_Click;
            // 
            // obrisiIzlet_btn
            // 
            obrisiIzlet_btn.Dock = DockStyle.Fill;
            obrisiIzlet_btn.Location = new Point(0, 0);
            obrisiIzlet_btn.Name = "obrisiIzlet_btn";
            obrisiIzlet_btn.Size = new Size(1000, 125);
            obrisiIzlet_btn.TabIndex = 10;
            obrisiIzlet_btn.Text = "Obrisi";
            obrisiIzlet_btn.UseVisualStyleBackColor = true;
            obrisiIzlet_btn.Click += obrisiIzlet_btn_Click;
            // 
            // izleti_dgw
            // 
            izleti_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            izleti_dgw.Dock = DockStyle.Top;
            izleti_dgw.Location = new Point(3, 3);
            izleti_dgw.Name = "izleti_dgw";
            izleti_dgw.ReadOnly = true;
            izleti_dgw.RowHeadersWidth = 51;
            izleti_dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            izleti_dgw.Size = new Size(1000, 269);
            izleti_dgw.TabIndex = 12;
            izleti_dgw.DataBindingComplete += izleti_dgw_DataBindingComplete;
            // 
            // korisnici_tab
            // 
            korisnici_tab.Controls.Add(panel5);
            korisnici_tab.Controls.Add(panel4);
            korisnici_tab.Controls.Add(korisnici_dgw);
            korisnici_tab.Location = new Point(4, 29);
            korisnici_tab.Name = "korisnici_tab";
            korisnici_tab.Padding = new Padding(3);
            korisnici_tab.Size = new Size(1006, 417);
            korisnici_tab.TabIndex = 1;
            korisnici_tab.Text = "Korisnici";
            korisnici_tab.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(dodajKorisnika_btn);
            panel5.Controls.Add(obrisiKorisnika_btn);
            panel5.Controls.Add(izmeniKorisnika_btn);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(3, 289);
            panel5.Name = "panel5";
            panel5.Size = new Size(1000, 125);
            panel5.TabIndex = 10;
            // 
            // dodajKorisnika_btn
            // 
            dodajKorisnika_btn.Location = new Point(24, 33);
            dodajKorisnika_btn.Name = "dodajKorisnika_btn";
            dodajKorisnika_btn.Size = new Size(184, 64);
            dodajKorisnika_btn.TabIndex = 5;
            dodajKorisnika_btn.Text = "Dodaj";
            dodajKorisnika_btn.UseVisualStyleBackColor = true;
            dodajKorisnika_btn.Click += dodajKorisnika_btn_Click;
            // 
            // obrisiKorisnika_btn
            // 
            obrisiKorisnika_btn.Location = new Point(253, 33);
            obrisiKorisnika_btn.Name = "obrisiKorisnika_btn";
            obrisiKorisnika_btn.Size = new Size(236, 64);
            obrisiKorisnika_btn.TabIndex = 6;
            obrisiKorisnika_btn.Text = "Obrisi";
            obrisiKorisnika_btn.UseVisualStyleBackColor = true;
            obrisiKorisnika_btn.Click += obrisiKorisnika_btn_Click;
            // 
            // izmeniKorisnika_btn
            // 
            izmeniKorisnika_btn.Location = new Point(529, 28);
            izmeniKorisnika_btn.Name = "izmeniKorisnika_btn";
            izmeniKorisnika_btn.Size = new Size(232, 64);
            izmeniKorisnika_btn.TabIndex = 7;
            izmeniKorisnika_btn.Text = "Izmeni";
            izmeniKorisnika_btn.UseVisualStyleBackColor = true;
            izmeniKorisnika_btn.Click += izmeniKorisnika_btn_Click;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 311);
            panel4.Name = "panel4";
            panel4.Size = new Size(1000, 103);
            panel4.TabIndex = 9;
            // 
            // korisnici_dgw
            // 
            korisnici_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            korisnici_dgw.Dock = DockStyle.Top;
            korisnici_dgw.Location = new Point(3, 3);
            korisnici_dgw.Name = "korisnici_dgw";
            korisnici_dgw.ReadOnly = true;
            korisnici_dgw.RowHeadersWidth = 51;
            korisnici_dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            korisnici_dgw.Size = new Size(1000, 308);
            korisnici_dgw.TabIndex = 8;
            korisnici_dgw.DataBindingComplete += korisnici_dgw_DataBindingComplete;
            // 
            // Rezervacije
            // 
            Rezervacije.Controls.Add(button1);
            Rezervacije.Controls.Add(rezervacije_dgw);
            Rezervacije.Controls.Add(izmeniRezervacije_btn);
            Rezervacije.Controls.Add(obrisiRezervacije_btn);
            Rezervacije.Controls.Add(dodajRezervacije_btn);
            Rezervacije.Location = new Point(4, 29);
            Rezervacije.Name = "Rezervacije";
            Rezervacije.Size = new Size(1006, 417);
            Rezervacije.TabIndex = 2;
            Rezervacije.Text = "Rezervacije";
            Rezervacije.UseVisualStyleBackColor = true;
            Rezervacije.Click += Rezervacije_Click;
            // 
            // button1
            // 
            button1.Location = new Point(754, 329);
            button1.Name = "button1";
            button1.Size = new Size(200, 59);
            button1.TabIndex = 17;
            button1.Text = "Detalji Rezervacije";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // rezervacije_dgw
            // 
            rezervacije_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezervacije_dgw.Dock = DockStyle.Top;
            rezervacije_dgw.Location = new Point(0, 0);
            rezervacije_dgw.Name = "rezervacije_dgw";
            rezervacije_dgw.ReadOnly = true;
            rezervacije_dgw.RowHeadersWidth = 51;
            rezervacije_dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rezervacije_dgw.Size = new Size(1006, 284);
            rezervacije_dgw.TabIndex = 16;
            rezervacije_dgw.DataBindingComplete += rezervacije_dgw_DataBindingComplete;
            // 
            // izmeniRezervacije_btn
            // 
            izmeniRezervacije_btn.Location = new Point(547, 329);
            izmeniRezervacije_btn.Name = "izmeniRezervacije_btn";
            izmeniRezervacije_btn.Size = new Size(180, 59);
            izmeniRezervacije_btn.TabIndex = 15;
            izmeniRezervacije_btn.Text = "Izmeni";
            izmeniRezervacije_btn.UseVisualStyleBackColor = true;
            izmeniRezervacije_btn.Click += izmeniRezervacije_btn_Click;
            // 
            // obrisiRezervacije_btn
            // 
            obrisiRezervacije_btn.Location = new Point(307, 329);
            obrisiRezervacije_btn.Name = "obrisiRezervacije_btn";
            obrisiRezervacije_btn.Size = new Size(180, 59);
            obrisiRezervacije_btn.TabIndex = 14;
            obrisiRezervacije_btn.Text = "Obrisi";
            obrisiRezervacije_btn.UseVisualStyleBackColor = true;
            obrisiRezervacije_btn.Click += obrisiRezervacije_btn_Click;
            // 
            // dodajRezervacije_btn
            // 
            dodajRezervacije_btn.Location = new Point(64, 329);
            dodajRezervacije_btn.Name = "dodajRezervacije_btn";
            dodajRezervacije_btn.Size = new Size(180, 59);
            dodajRezervacije_btn.TabIndex = 13;
            dodajRezervacije_btn.Text = "Dodaj";
            dodajRezervacije_btn.UseVisualStyleBackColor = true;
            dodajRezervacije_btn.Click += dodajRezervacije_btn_Click;
            // 
            // Administrator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1014, 450);
            Controls.Add(tabovi);
            Controls.Add(label1);
            Name = "Administrator";
            Text = "Administrator";
            Load += Administrator_Load;
            tabovi.ResumeLayout(false);
            izleti_tab.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)izleti_dgw).EndInit();
            korisnici_tab.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)korisnici_dgw).EndInit();
            Rezervacije.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)rezervacije_dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl tabovi;
        private TabPage izleti_tab;
        private TabPage korisnici_tab;
        private TabPage Rezervacije;
        private Button izmeniKorisnika_btn;
        private Button obrisiKorisnika_btn;
        private Button dodajKorisnika_btn;
        private DataGridView korisnici_dgw;
        private DataGridView izleti_dgw;
        private DataGridView rezervacije_dgw;
        private Button izmeniRezervacije_btn;
        private Button obrisiRezervacije_btn;
        private Button dodajRezervacije_btn;
        private Panel panel2;
        private Panel panel3;
        private Panel panel1;
        private Button dodajIzlet_btn;
        private Button izmeniIzlet_btn;
        private Button obrisiIzlet_btn;
        private Panel panel5;
        private Panel panel4;
        private Button button1;
    }
}