namespace TVP_Projekat
{
    partial class Registracija
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
            ime_lbl = new Label();
            prezime_lbl = new Label();
            korIme_lbl = new Label();
            lozinka_lbl = new Label();
            ime_txt = new TextBox();
            prezime_txt = new TextBox();
            korIme_txt = new TextBox();
            lozinka_txt = new TextBox();
            registracija_btn = new Button();
            klijent_rdbtn = new RadioButton();
            administrator_rdbtn = new RadioButton();
            tipNaloga_lbl = new Label();
            klijent_lbl = new Label();
            administrator_lbl = new Label();
            kli_amd_lbl = new Label();
            SuspendLayout();
            // 
            // ime_lbl
            // 
            ime_lbl.AutoSize = true;
            ime_lbl.Location = new Point(339, 61);
            ime_lbl.Name = "ime_lbl";
            ime_lbl.Size = new Size(37, 20);
            ime_lbl.TabIndex = 0;
            ime_lbl.Text = "Ime:";
            // 
            // prezime_lbl
            // 
            prezime_lbl.AutoSize = true;
            prezime_lbl.Location = new Point(328, 139);
            prezime_lbl.Name = "prezime_lbl";
            prezime_lbl.Size = new Size(65, 20);
            prezime_lbl.TabIndex = 1;
            prezime_lbl.Text = "Prezime:";
            // 
            // korIme_lbl
            // 
            korIme_lbl.AutoSize = true;
            korIme_lbl.Location = new Point(315, 216);
            korIme_lbl.Name = "korIme_lbl";
            korIme_lbl.Size = new Size(109, 20);
            korIme_lbl.TabIndex = 2;
            korIme_lbl.Text = "Korisnicko ime:";
            // 
            // lozinka_lbl
            // 
            lozinka_lbl.AutoSize = true;
            lozinka_lbl.Location = new Point(331, 298);
            lozinka_lbl.Name = "lozinka_lbl";
            lozinka_lbl.Size = new Size(62, 20);
            lozinka_lbl.TabIndex = 3;
            lozinka_lbl.Text = "Lozinka:";
            // 
            // ime_txt
            // 
            ime_txt.Location = new Point(255, 96);
            ime_txt.Name = "ime_txt";
            ime_txt.Size = new Size(217, 27);
            ime_txt.TabIndex = 4;
            // 
            // prezime_txt
            // 
            prezime_txt.Location = new Point(255, 177);
            prezime_txt.Name = "prezime_txt";
            prezime_txt.Size = new Size(217, 27);
            prezime_txt.TabIndex = 5;
            // 
            // korIme_txt
            // 
            korIme_txt.Location = new Point(255, 259);
            korIme_txt.Name = "korIme_txt";
            korIme_txt.Size = new Size(217, 27);
            korIme_txt.TabIndex = 6;
            // 
            // lozinka_txt
            // 
            lozinka_txt.Location = new Point(255, 339);
            lozinka_txt.Name = "lozinka_txt";
            lozinka_txt.PasswordChar = '*';
            lozinka_txt.Size = new Size(217, 27);
            lozinka_txt.TabIndex = 7;
            // 
            // registracija_btn
            // 
            registracija_btn.Location = new Point(315, 412);
            registracija_btn.Name = "registracija_btn";
            registracija_btn.Size = new Size(94, 29);
            registracija_btn.TabIndex = 8;
            registracija_btn.Text = "Registracija";
            registracija_btn.UseVisualStyleBackColor = true;
            registracija_btn.Click += registracija_btn_Click;
            // 
            // klijent_rdbtn
            // 
            klijent_rdbtn.AutoSize = true;
            klijent_rdbtn.Checked = true;
            klijent_rdbtn.Location = new Point(526, 342);
            klijent_rdbtn.Name = "klijent_rdbtn";
            klijent_rdbtn.Size = new Size(70, 24);
            klijent_rdbtn.TabIndex = 9;
            klijent_rdbtn.TabStop = true;
            klijent_rdbtn.Text = "klijent";
            klijent_rdbtn.UseVisualStyleBackColor = true;
            // 
            // administrator_rdbtn
            // 
            administrator_rdbtn.AutoSize = true;
            administrator_rdbtn.Location = new Point(526, 379);
            administrator_rdbtn.Name = "administrator_rdbtn";
            administrator_rdbtn.Size = new Size(119, 24);
            administrator_rdbtn.TabIndex = 10;
            administrator_rdbtn.Text = "administrator";
            administrator_rdbtn.UseVisualStyleBackColor = true;
            // 
            // tipNaloga_lbl
            // 
            tipNaloga_lbl.AutoSize = true;
            tipNaloga_lbl.Location = new Point(526, 301);
            tipNaloga_lbl.Name = "tipNaloga_lbl";
            tipNaloga_lbl.Size = new Size(83, 20);
            tipNaloga_lbl.TabIndex = 11;
            tipNaloga_lbl.Text = "Tip naloga:";
            tipNaloga_lbl.Visible = false;
            // 
            // klijent_lbl
            // 
            klijent_lbl.AutoSize = true;
            klijent_lbl.Location = new Point(331, 22);
            klijent_lbl.Name = "klijent_lbl";
            klijent_lbl.Size = new Size(61, 20);
            klijent_lbl.TabIndex = 12;
            klijent_lbl.Text = "KLIJENT";
            klijent_lbl.Visible = false;
            // 
            // administrator_lbl
            // 
            administrator_lbl.AutoSize = true;
            administrator_lbl.Location = new Point(301, 22);
            administrator_lbl.Name = "administrator_lbl";
            administrator_lbl.Size = new Size(123, 20);
            administrator_lbl.TabIndex = 13;
            administrator_lbl.Text = "ADMINISTRATOR";
            administrator_lbl.Visible = false;
            // 
            // kli_amd_lbl
            // 
            kli_amd_lbl.AutoSize = true;
            kli_amd_lbl.Location = new Point(272, 22);
            kli_amd_lbl.Name = "kli_amd_lbl";
            kli_amd_lbl.Size = new Size(187, 20);
            kli_amd_lbl.TabIndex = 14;
            kli_amd_lbl.Text = "KLIJENT I ADMINISTRATOR";
            kli_amd_lbl.Visible = false;
            // 
            // Registracija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(kli_amd_lbl);
            Controls.Add(administrator_lbl);
            Controls.Add(klijent_lbl);
            Controls.Add(tipNaloga_lbl);
            Controls.Add(administrator_rdbtn);
            Controls.Add(klijent_rdbtn);
            Controls.Add(registracija_btn);
            Controls.Add(lozinka_txt);
            Controls.Add(korIme_txt);
            Controls.Add(prezime_txt);
            Controls.Add(ime_txt);
            Controls.Add(lozinka_lbl);
            Controls.Add(korIme_lbl);
            Controls.Add(prezime_lbl);
            Controls.Add(ime_lbl);
            Name = "Registracija";
            Text = "Registracija";
            Load += Registracija_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ime_lbl;
        private Label prezime_lbl;
        private Label korIme_lbl;
        private Label lozinka_lbl;
        private TextBox ime_txt;
        private TextBox prezime_txt;
        private TextBox korIme_txt;
        private TextBox lozinka_txt;
        private Button registracija_btn;
        private RadioButton klijent_rdbtn;
        private RadioButton administrator_rdbtn;
        private Label tipNaloga_lbl;
        private Label klijent_lbl;
        private Label administrator_lbl;
        private Label kli_amd_lbl;
    }
}