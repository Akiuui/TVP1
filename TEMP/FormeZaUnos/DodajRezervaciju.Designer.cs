namespace TVP_Projekat.FormeZaUnos
{
    partial class DodajRezervaciju
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
            korisnici_dgw = new DataGridView();
            korisnik_lbl = new Label();
            izleti_dgw = new DataGridView();
            rezervacija_lbl = new Label();
            brojMesta_txt = new TextBox();
            brojMesta_lbl = new Label();
            kreirajRezervaciju_btn = new Button();
            filterMesto_txt = new TextBox();
            filterMesto_lbl = new Label();
            ((System.ComponentModel.ISupportInitialize)korisnici_dgw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)izleti_dgw).BeginInit();
            SuspendLayout();
            // 
            // korisnici_dgw
            // 
            korisnici_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            korisnici_dgw.Location = new Point(1, 264);
            korisnici_dgw.Name = "korisnici_dgw";
            korisnici_dgw.ReadOnly = true;
            korisnici_dgw.RowHeadersWidth = 51;
            korisnici_dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            korisnici_dgw.Size = new Size(799, 217);
            korisnici_dgw.TabIndex = 6;
            korisnici_dgw.DataBindingComplete += korisnici_dgw_DataBindingComplete;
            // 
            // korisnik_lbl
            // 
            korisnik_lbl.AutoSize = true;
            korisnik_lbl.Location = new Point(1, 241);
            korisnik_lbl.Name = "korisnik_lbl";
            korisnik_lbl.Size = new Size(287, 20);
            korisnik_lbl.TabIndex = 1;
            korisnik_lbl.Text = "Izaberi korisnika za dodavanje rezervacije:";
            // 
            // izleti_dgw
            // 
            izleti_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            izleti_dgw.Location = new Point(1, 24);
            izleti_dgw.Name = "izleti_dgw";
            izleti_dgw.ReadOnly = true;
            izleti_dgw.RowHeadersWidth = 51;
            izleti_dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            izleti_dgw.Size = new Size(1095, 214);
            izleti_dgw.TabIndex = 2;
            izleti_dgw.DataBindingComplete += izleti_dgw_DataBindingComplete;
            // 
            // rezervacija_lbl
            // 
            rezervacija_lbl.AutoSize = true;
            rezervacija_lbl.Location = new Point(1, 3);
            rezervacija_lbl.Name = "rezervacija_lbl";
            rezervacija_lbl.Size = new Size(257, 20);
            rezervacija_lbl.TabIndex = 3;
            rezervacija_lbl.Text = "Izaberi izlet za dodavanje rezervacije:";
            // 
            // brojMesta_txt
            // 
            brojMesta_txt.Location = new Point(15, 514);
            brojMesta_txt.Name = "brojMesta_txt";
            brojMesta_txt.Size = new Size(221, 27);
            brojMesta_txt.TabIndex = 0;
            brojMesta_txt.Tag = "br";
            // 
            // brojMesta_lbl
            // 
            brojMesta_lbl.AutoSize = true;
            brojMesta_lbl.Location = new Point(15, 484);
            brojMesta_lbl.Name = "brojMesta_lbl";
            brojMesta_lbl.Size = new Size(165, 20);
            brojMesta_lbl.TabIndex = 5;
            brojMesta_lbl.Text = "Broj rezervisanih mesta:";
            // 
            // kreirajRezervaciju_btn
            // 
            kreirajRezervaciju_btn.Location = new Point(560, 512);
            kreirajRezervaciju_btn.Name = "kreirajRezervaciju_btn";
            kreirajRezervaciju_btn.Size = new Size(240, 29);
            kreirajRezervaciju_btn.TabIndex = 8;
            kreirajRezervaciju_btn.Text = "Kreiraj";
            kreirajRezervaciju_btn.UseVisualStyleBackColor = true;
            kreirajRezervaciju_btn.Click += kreirajRezervaciju_btn_Click;
            // 
            // filterMesto_txt
            // 
            filterMesto_txt.Location = new Point(12, 360);
            filterMesto_txt.Name = "filterMesto_txt";
            filterMesto_txt.Size = new Size(221, 27);
            filterMesto_txt.TabIndex = 9;
            filterMesto_txt.Tag = "ignore";
            filterMesto_txt.TextChanged += filterMesto_txt_TextChanged;
            // 
            // filterMesto_lbl
            // 
            filterMesto_lbl.AutoSize = true;
            filterMesto_lbl.Location = new Point(15, 327);
            filterMesto_lbl.Name = "filterMesto_lbl";
            filterMesto_lbl.Size = new Size(109, 20);
            filterMesto_lbl.TabIndex = 10;
            filterMesto_lbl.Text = "Filter za mesto:";
            // 
            // DodajRezervaciju
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1108, 553);
            Controls.Add(filterMesto_lbl);
            Controls.Add(filterMesto_txt);
            Controls.Add(kreirajRezervaciju_btn);
            Controls.Add(brojMesta_lbl);
            Controls.Add(brojMesta_txt);
            Controls.Add(rezervacija_lbl);
            Controls.Add(izleti_dgw);
            Controls.Add(korisnik_lbl);
            Controls.Add(korisnici_dgw);
            Name = "DodajRezervaciju";
            Text = "DodajRezervaciju";
            Load += DodajRezervaciju_Load;
            ((System.ComponentModel.ISupportInitialize)korisnici_dgw).EndInit();
            ((System.ComponentModel.ISupportInitialize)izleti_dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView korisnici_dgw;
        private Label korisnik_lbl;
        private DataGridView izleti_dgw;
        private Label rezervacija_lbl;
        private TextBox brojMesta_txt;
        private Label brojMesta_lbl;
        private Button kreirajRezervaciju_btn;
        private TextBox filterMesto_txt;
        private Label filterMesto_lbl;
    }
}