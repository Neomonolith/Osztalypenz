namespace osztalypenztranzakcio
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
            this.lbLista = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdKifizet = new System.Windows.Forms.RadioButton();
            this.rdBefizet = new System.Windows.Forms.RadioButton();
            this.nev = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.penz = new System.Windows.Forms.TextBox();
            this.btnTranzakcio = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.dtpIdo = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbLista
            // 
            this.lbLista.FormattingEnabled = true;
            this.lbLista.Location = new System.Drawing.Point(12, 25);
            this.lbLista.Name = "lbLista";
            this.lbLista.Size = new System.Drawing.Size(518, 251);
            this.lbLista.TabIndex = 1;
            this.lbLista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdKifizet);
            this.groupBox1.Controls.Add(this.rdBefizet);
            this.groupBox1.Location = new System.Drawing.Point(557, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 74);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Új tranzakció";
            // 
            // rdKifizet
            // 
            this.rdKifizet.AutoSize = true;
            this.rdKifizet.Location = new System.Drawing.Point(16, 42);
            this.rdKifizet.Name = "rdKifizet";
            this.rdKifizet.Size = new System.Drawing.Size(64, 17);
            this.rdKifizet.TabIndex = 1;
            this.rdKifizet.Text = "Kifizetés";
            this.rdKifizet.UseVisualStyleBackColor = true;
            // 
            // rdBefizet
            // 
            this.rdBefizet.AutoSize = true;
            this.rdBefizet.Checked = true;
            this.rdBefizet.Location = new System.Drawing.Point(16, 19);
            this.rdBefizet.Name = "rdBefizet";
            this.rdBefizet.Size = new System.Drawing.Size(68, 17);
            this.rdBefizet.TabIndex = 0;
            this.rdBefizet.TabStop = true;
            this.rdBefizet.Text = "Befizetés";
            this.rdBefizet.UseVisualStyleBackColor = true;
            // 
            // nev
            // 
            this.nev.Location = new System.Drawing.Point(547, 121);
            this.nev.Name = "nev";
            this.nev.Size = new System.Drawing.Size(146, 20);
            this.nev.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Név";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Összeg";
            // 
            // penz
            // 
            this.penz.Location = new System.Drawing.Point(547, 160);
            this.penz.Name = "penz";
            this.penz.Size = new System.Drawing.Size(146, 20);
            this.penz.TabIndex = 5;
            // 
            // btnTranzakcio
            // 
            this.btnTranzakcio.Location = new System.Drawing.Point(560, 261);
            this.btnTranzakcio.Name = "btnTranzakcio";
            this.btnTranzakcio.Size = new System.Drawing.Size(122, 23);
            this.btnTranzakcio.TabIndex = 7;
            this.btnTranzakcio.Text = "Tranzakció Start";
            this.btnTranzakcio.UseVisualStyleBackColor = true;
            this.btnTranzakcio.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(558, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Egyenleg:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(557, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "0 Ft";
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(123, 282);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(341, 33);
            this.btnMentes.TabIndex = 10;
            this.btnMentes.Text = "Állapot mentése";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnBetolt
            // 
            this.btnBetolt.Location = new System.Drawing.Point(123, 344);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(341, 35);
            this.btnBetolt.TabIndex = 11;
            this.btnBetolt.Text = "Állapot betöltése";
            this.btnBetolt.UseVisualStyleBackColor = true;
            this.btnBetolt.Click += new System.EventHandler(this.button3_Click);
            // 
            // dtpIdo
            // 
            this.dtpIdo.Location = new System.Drawing.Point(535, 218);
            this.dtpIdo.Margin = new System.Windows.Forms.Padding(2);
            this.dtpIdo.Name = "dtpIdo";
            this.dtpIdo.Size = new System.Drawing.Size(193, 20);
            this.dtpIdo.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(561, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dátum:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 438);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpIdo);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTranzakcio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.penz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nev);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbLista);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Osztálypénz";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lbLista;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdKifizet;
        private System.Windows.Forms.RadioButton rdBefizet;
        private System.Windows.Forms.TextBox nev;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox penz;
        private System.Windows.Forms.Button btnTranzakcio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.DateTimePicker dtpIdo;
        private System.Windows.Forms.Label label6;
    }
}

