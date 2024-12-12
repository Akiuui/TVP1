namespace TVP_Projekat
{
    partial class DodajIzlet
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
            mesto_txt = new TextBox();
            drzava_txt = new TextBox();
            mesto_lbl = new Label();
            drzava_lbl = new Label();
            popust_lbl = new Label();
            cena_lbl = new Label();
            popust_txt = new TextBox();
            cena_txt = new TextBox();
            ukupnoMesta_lbl = new Label();
            brojDana_lbl = new Label();
            ukupnoMesta_txt = new TextBox();
            brojDana_txt = new TextBox();
            datum_lbl = new Label();
            datum_date = new DateTimePicker();
            izleti_btn = new Button();
            SuspendLayout();
            // 
            // mesto_txt
            // 
            mesto_txt.Location = new Point(53, 87);
            mesto_txt.Name = "mesto_txt";
            mesto_txt.Size = new Size(196, 27);
            mesto_txt.TabIndex = 0;
            // 
            // drzava_txt
            // 
            drzava_txt.Location = new Point(53, 160);
            drzava_txt.Name = "drzava_txt";
            drzava_txt.Size = new Size(196, 27);
            drzava_txt.TabIndex = 1;
            // 
            // mesto_lbl
            // 
            mesto_lbl.AutoSize = true;
            mesto_lbl.Location = new Point(124, 50);
            mesto_lbl.Name = "mesto_lbl";
            mesto_lbl.Size = new Size(53, 20);
            mesto_lbl.TabIndex = 7;
            mesto_lbl.Text = "Mesto:";
            // 
            // drzava_lbl
            // 
            drzava_lbl.AutoSize = true;
            drzava_lbl.Location = new Point(124, 128);
            drzava_lbl.Name = "drzava_lbl";
            drzava_lbl.Size = new Size(58, 20);
            drzava_lbl.TabIndex = 8;
            drzava_lbl.Text = "Drzava:";
            // 
            // popust_lbl
            // 
            popust_lbl.AutoSize = true;
            popust_lbl.Location = new Point(358, 128);
            popust_lbl.Name = "popust_lbl";
            popust_lbl.Size = new Size(56, 20);
            popust_lbl.TabIndex = 12;
            popust_lbl.Text = "Popust:";
            // 
            // cena_lbl
            // 
            cena_lbl.AutoSize = true;
            cena_lbl.Location = new Point(358, 50);
            cena_lbl.Name = "cena_lbl";
            cena_lbl.Size = new Size(45, 20);
            cena_lbl.TabIndex = 11;
            cena_lbl.Text = "Cena:";
            // 
            // popust_txt
            // 
            popust_txt.Location = new Point(287, 160);
            popust_txt.Name = "popust_txt";
            popust_txt.Size = new Size(196, 27);
            popust_txt.TabIndex = 10;
            popust_txt.Tag = "br 0";
            // 
            // cena_txt
            // 
            cena_txt.Location = new Point(287, 87);
            cena_txt.Name = "cena_txt";
            cena_txt.Size = new Size(196, 27);
            cena_txt.TabIndex = 9;
            cena_txt.Tag = "br";
            // 
            // ukupnoMesta_lbl
            // 
            ukupnoMesta_lbl.AutoSize = true;
            ukupnoMesta_lbl.Location = new Point(586, 128);
            ukupnoMesta_lbl.Name = "ukupnoMesta_lbl";
            ukupnoMesta_lbl.Size = new Size(107, 20);
            ukupnoMesta_lbl.TabIndex = 16;
            ukupnoMesta_lbl.Text = "Ukupno mesta:";
            // 
            // brojDana_lbl
            // 
            brojDana_lbl.AutoSize = true;
            brojDana_lbl.Location = new Point(598, 50);
            brojDana_lbl.Name = "brojDana_lbl";
            brojDana_lbl.Size = new Size(76, 20);
            brojDana_lbl.TabIndex = 15;
            brojDana_lbl.Text = "Broj dana:";
            // 
            // ukupnoMesta_txt
            // 
            ukupnoMesta_txt.Location = new Point(542, 160);
            ukupnoMesta_txt.Name = "ukupnoMesta_txt";
            ukupnoMesta_txt.Size = new Size(196, 27);
            ukupnoMesta_txt.TabIndex = 14;
            ukupnoMesta_txt.Tag = "br";
            // 
            // brojDana_txt
            // 
            brojDana_txt.Location = new Point(542, 87);
            brojDana_txt.Name = "brojDana_txt";
            brojDana_txt.Size = new Size(196, 27);
            brojDana_txt.TabIndex = 13;
            brojDana_txt.Tag = "br";
            // 
            // datum_lbl
            // 
            datum_lbl.AutoSize = true;
            datum_lbl.Location = new Point(358, 214);
            datum_lbl.Name = "datum_lbl";
            datum_lbl.Size = new Size(57, 20);
            datum_lbl.TabIndex = 18;
            datum_lbl.Text = "Datum:";
            // 
            // datum_date
            // 
            datum_date.Location = new Point(274, 254);
            datum_date.Name = "datum_date";
            datum_date.Size = new Size(250, 27);
            datum_date.TabIndex = 19;
            // 
            // izleti_btn
            // 
            izleti_btn.Location = new Point(293, 327);
            izleti_btn.Name = "izleti_btn";
            izleti_btn.Size = new Size(202, 66);
            izleti_btn.TabIndex = 20;
            izleti_btn.Text = "Kreiraj Izlet";
            izleti_btn.UseVisualStyleBackColor = true;
            izleti_btn.Click += izleti_btn_Click;
            // 
            // DodajIzlet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(izleti_btn);
            Controls.Add(datum_date);
            Controls.Add(datum_lbl);
            Controls.Add(ukupnoMesta_lbl);
            Controls.Add(brojDana_lbl);
            Controls.Add(ukupnoMesta_txt);
            Controls.Add(brojDana_txt);
            Controls.Add(popust_lbl);
            Controls.Add(cena_lbl);
            Controls.Add(popust_txt);
            Controls.Add(cena_txt);
            Controls.Add(drzava_lbl);
            Controls.Add(mesto_lbl);
            Controls.Add(drzava_txt);
            Controls.Add(mesto_txt);
            Name = "DodajIzlet";
            Text = "Izleti";
            Load += DodajIzlet_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox mesto_txt;
        private TextBox drzava_txt;
        private Label mesto_lbl;
        private Label drzava_lbl;
        private Label popust_lbl;
        private Label cena_lbl;
        private TextBox popust_txt;
        private TextBox cena_txt;
        private Label ukupnoMesta_lbl;
        private Label brojDana_lbl;
        private TextBox ukupnoMesta_txt;
        private TextBox brojDana_txt;
        private Label datum_lbl;
        private DateTimePicker datum_date;
        private Button izleti_btn;
    }
}