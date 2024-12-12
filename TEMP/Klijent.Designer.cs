namespace TVP_Projekat
{
    partial class Klijent
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
            rezervacijeKlijenta_dgw = new DataGridView();
            izmeniRezervacije_btn = new Button();
            obrisiRezervacije_btn = new Button();
            dodajRezervacije_btn = new Button();
            detalji_btn = new Button();
            label1 = new Label();
            sveRezervacije_btn = new Button();
            ((System.ComponentModel.ISupportInitialize)rezervacijeKlijenta_dgw).BeginInit();
            SuspendLayout();
            // 
            // rezervacijeKlijenta_dgw
            // 
            rezervacijeKlijenta_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            rezervacijeKlijenta_dgw.Location = new Point(3, 51);
            rezervacijeKlijenta_dgw.Name = "rezervacijeKlijenta_dgw";
            rezervacijeKlijenta_dgw.ReadOnly = true;
            rezervacijeKlijenta_dgw.RowHeadersWidth = 51;
            rezervacijeKlijenta_dgw.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            rezervacijeKlijenta_dgw.Size = new Size(1263, 325);
            rezervacijeKlijenta_dgw.TabIndex = 20;
            rezervacijeKlijenta_dgw.DataBindingComplete += rezervacijeKlijenta_dgw_DataBindingComplete;
            // 
            // izmeniRezervacije_btn
            // 
            izmeniRezervacije_btn.Location = new Point(413, 393);
            izmeniRezervacije_btn.Name = "izmeniRezervacije_btn";
            izmeniRezervacije_btn.Size = new Size(180, 50);
            izmeniRezervacije_btn.TabIndex = 19;
            izmeniRezervacije_btn.Text = "Izmeni";
            izmeniRezervacije_btn.UseVisualStyleBackColor = true;
            izmeniRezervacije_btn.Click += izmeniRezervacije_btn_Click;
            // 
            // obrisiRezervacije_btn
            // 
            obrisiRezervacije_btn.Location = new Point(217, 393);
            obrisiRezervacije_btn.Name = "obrisiRezervacije_btn";
            obrisiRezervacije_btn.Size = new Size(180, 50);
            obrisiRezervacije_btn.TabIndex = 18;
            obrisiRezervacije_btn.Text = "Obrisi";
            obrisiRezervacije_btn.UseVisualStyleBackColor = true;
            obrisiRezervacije_btn.Click += obrisiRezervacije_btn_Click;
            // 
            // dodajRezervacije_btn
            // 
            dodajRezervacije_btn.Location = new Point(12, 393);
            dodajRezervacije_btn.Name = "dodajRezervacije_btn";
            dodajRezervacije_btn.Size = new Size(180, 50);
            dodajRezervacije_btn.TabIndex = 17;
            dodajRezervacije_btn.Text = "Dodaj";
            dodajRezervacije_btn.UseVisualStyleBackColor = true;
            dodajRezervacije_btn.Click += dodajRezervacije_btn_Click;
            // 
            // detalji_btn
            // 
            detalji_btn.Location = new Point(614, 393);
            detalji_btn.Name = "detalji_btn";
            detalji_btn.Size = new Size(174, 50);
            detalji_btn.TabIndex = 21;
            detalji_btn.Text = "Detalji Rezervacije";
            detalji_btn.UseVisualStyleBackColor = true;
            detalji_btn.Click += detalji_btn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(304, 9);
            label1.Name = "label1";
            label1.Size = new Size(158, 20);
            label1.TabIndex = 22;
            label1.Text = "Rezervacije koje slede:";
            // 
            // sveRezervacije_btn
            // 
            sveRezervacije_btn.Location = new Point(12, 12);
            sveRezervacije_btn.Name = "sveRezervacije_btn";
            sveRezervacije_btn.Size = new Size(156, 29);
            sveRezervacije_btn.TabIndex = 23;
            sveRezervacije_btn.Text = "Istorija Rezevacija";
            sveRezervacije_btn.UseVisualStyleBackColor = true;
            sveRezervacije_btn.Click += sveRezervacije_btn_Click;
            // 
            // Klijent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1316, 450);
            Controls.Add(sveRezervacije_btn);
            Controls.Add(label1);
            Controls.Add(detalji_btn);
            Controls.Add(rezervacijeKlijenta_dgw);
            Controls.Add(izmeniRezervacije_btn);
            Controls.Add(obrisiRezervacije_btn);
            Controls.Add(dodajRezervacije_btn);
            Name = "Klijent";
            Text = "Klijent";
            Load += Klijent_Load;
            ((System.ComponentModel.ISupportInitialize)rezervacijeKlijenta_dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView rezervacijeKlijenta_dgw;
        private Button izmeniRezervacije_btn;
        private Button obrisiRezervacije_btn;
        private Button dodajRezervacije_btn;
        private Button detalji_btn;
        private Label label1;
        private Button sveRezervacije_btn;
    }
}