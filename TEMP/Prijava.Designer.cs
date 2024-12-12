namespace TVP_Projekat
{
    partial class Prijava
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
            korIme_lbl = new Label();
            label2 = new Label();
            ime_txt = new TextBox();
            prijava_btn = new Button();
            label3 = new Label();
            lozinka_lbl = new Label();
            registrujteSe_btn = new Button();
            lozinka_txt = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // korIme_lbl
            // 
            korIme_lbl.AutoSize = true;
            korIme_lbl.Location = new Point(312, 94);
            korIme_lbl.Name = "korIme_lbl";
            korIme_lbl.Size = new Size(109, 20);
            korIme_lbl.TabIndex = 0;
            korIme_lbl.Text = "Korisnicko ime:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(345, 194);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 1;
            label2.Text = "Sifra:";
            // 
            // ime_txt
            // 
            ime_txt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ime_txt.Location = new Point(256, 133);
            ime_txt.Name = "ime_txt";
            ime_txt.Size = new Size(240, 27);
            ime_txt.TabIndex = 4;
            // 
            // prijava_btn
            // 
            prijava_btn.Location = new Point(284, 299);
            prijava_btn.Name = "prijava_btn";
            prijava_btn.Size = new Size(189, 48);
            prijava_btn.TabIndex = 6;
            prijava_btn.Text = "prijavi se";
            prijava_btn.UseVisualStyleBackColor = true;
            prijava_btn.Click += prijava_btn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 376);
            label3.Name = "label3";
            label3.Size = new Size(111, 20);
            label3.TabIndex = 7;
            label3.Text = "Nemate nalog?";
            // 
            // lozinka_lbl
            // 
            lozinka_lbl.AutoSize = true;
            lozinka_lbl.Location = new Point(345, 192);
            lozinka_lbl.Name = "lozinka_lbl";
            lozinka_lbl.Size = new Size(62, 20);
            lozinka_lbl.TabIndex = 8;
            lozinka_lbl.Text = "Lozinka:";
            // 
            // registrujteSe_btn
            // 
            registrujteSe_btn.FlatStyle = FlatStyle.Flat;
            registrujteSe_btn.Location = new Point(301, 409);
            registrujteSe_btn.Name = "registrujteSe_btn";
            registrujteSe_btn.Size = new Size(146, 29);
            registrujteSe_btn.TabIndex = 11;
            registrujteSe_btn.Text = "Registrujte se!";
            registrujteSe_btn.UseVisualStyleBackColor = false;
            registrujteSe_btn.Click += registrujteSe_txt_Click;
            registrujteSe_btn.MouseEnter += registrujteSe_txt_MouseEnter;
            registrujteSe_btn.MouseLeave += registrujteSe_txt_MouseLeave;
            // 
            // lozinka_txt
            // 
            lozinka_txt.Location = new Point(256, 232);
            lozinka_txt.Name = "lozinka_txt";
            lozinka_txt.PasswordChar = '*';
            lozinka_txt.Size = new Size(240, 27);
            lozinka_txt.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(345, 33);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 13;
            label1.Text = "Prijava:";
            // 
            // Prijava
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lozinka_txt);
            Controls.Add(registrujteSe_btn);
            Controls.Add(lozinka_lbl);
            Controls.Add(label3);
            Controls.Add(prijava_btn);
            Controls.Add(ime_txt);
            Controls.Add(label2);
            Controls.Add(korIme_lbl);
            Name = "Prijava";
            Text = "Prijava";
            Load += Prijava_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label korIme_lbl;
        private Label label2;
        private TextBox ime_txt;
        private Button prijava_btn;
        private Label label3;
        private Label lozinka_lbl;
        private Button registrujteSe_btn;
        private TextBox lozinka_txt;
        private Label label1;
    }
}