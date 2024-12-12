namespace TVP_Projekat.OsnovneKlase
{
    partial class IstorijaRezervacija
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
            izlRez_dgw = new DataGridView();
            pocetniDatum_dt = new DateTimePicker();
            krajnjiDatum_dt = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)izlRez_dgw).BeginInit();
            SuspendLayout();
            // 
            // izlRez_dgw
            // 
            izlRez_dgw.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            izlRez_dgw.Location = new Point(12, 37);
            izlRez_dgw.Name = "izlRez_dgw";
            izlRez_dgw.ReadOnly = true;
            izlRez_dgw.RowHeadersWidth = 51;
            izlRez_dgw.Size = new Size(776, 258);
            izlRez_dgw.TabIndex = 0;
            // 
            // pocetniDatum_dt
            // 
            pocetniDatum_dt.Location = new Point(88, 384);
            pocetniDatum_dt.Name = "pocetniDatum_dt";
            pocetniDatum_dt.Size = new Size(250, 27);
            pocetniDatum_dt.TabIndex = 1;
            // 
            // krajnjiDatum_dt
            // 
            krajnjiDatum_dt.Location = new Point(418, 384);
            krajnjiDatum_dt.Name = "krajnjiDatum_dt";
            krajnjiDatum_dt.Size = new Size(250, 27);
            krajnjiDatum_dt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(151, 347);
            label1.Name = "label1";
            label1.Size = new Size(107, 20);
            label1.TabIndex = 3;
            label1.Text = "Pocetni datum:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(494, 347);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 4;
            label2.Text = "Krajnji datum:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(323, 312);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 5;
            label3.Text = "FIlteri po datumu:";
            // 
            // button1
            // 
            button1.Location = new Point(323, 417);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "Detalji";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // IstorijaRezervacija
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(krajnjiDatum_dt);
            Controls.Add(pocetniDatum_dt);
            Controls.Add(izlRez_dgw);
            Name = "IstorijaRezervacija";
            Text = "IstorijaRezervacija";
            Load += IstorijaRezervacija_Load;
            ((System.ComponentModel.ISupportInitialize)izlRez_dgw).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView izlRez_dgw;
        private DateTimePicker pocetniDatum_dt;
        private DateTimePicker krajnjiDatum_dt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
    }
}