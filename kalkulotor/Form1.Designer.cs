namespace kalkulotor
{
    partial class KALKOLOTUR
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.wartosc1 = new System.Windows.Forms.TextBox();
            this.wartosc2 = new System.Windows.Forms.TextBox();
            this.wartosc3 = new System.Windows.Forms.TextBox();
            this.mno = new System.Windows.Forms.RadioButton();
            this.dziel = new System.Windows.Forms.RadioButton();
            this.dod = new System.Windows.Forms.RadioButton();
            this.min = new System.Windows.Forms.RadioButton();
            this.EXECUTE = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Float = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // wartosc1
            // 
            this.wartosc1.Location = new System.Drawing.Point(47, 57);
            this.wartosc1.Name = "wartosc1";
            this.wartosc1.Size = new System.Drawing.Size(100, 20);
            this.wartosc1.TabIndex = 0;
            this.wartosc1.TextChanged += new System.EventHandler(this.x_TextChanged);
            // 
            // wartosc2
            // 
            this.wartosc2.Location = new System.Drawing.Point(219, 57);
            this.wartosc2.Name = "wartosc2";
            this.wartosc2.Size = new System.Drawing.Size(100, 20);
            this.wartosc2.TabIndex = 1;
            this.wartosc2.TextChanged += new System.EventHandler(this.wartosc2_TextChanged);
            // 
            // wartosc3
            // 
            this.wartosc3.Location = new System.Drawing.Point(344, 57);
            this.wartosc3.Name = "wartosc3";
            this.wartosc3.ReadOnly = true;
            this.wartosc3.Size = new System.Drawing.Size(167, 20);
            this.wartosc3.TabIndex = 2;
            this.wartosc3.TextChanged += new System.EventHandler(this.wartosc3_TextChanged);
            // 
            // mno
            // 
            this.mno.AutoSize = true;
            this.mno.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.mno.Location = new System.Drawing.Point(153, 0);
            this.mno.Name = "mno";
            this.mno.Size = new System.Drawing.Size(38, 29);
            this.mno.TabIndex = 7;
            this.mno.TabStop = true;
            this.mno.Text = "*";
            this.mno.UseVisualStyleBackColor = true;
            this.mno.CheckedChanged += new System.EventHandler(this.mno_CheckedChanged);
            // 
            // dziel
            // 
            this.dziel.AutoSize = true;
            this.dziel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dziel.Location = new System.Drawing.Point(153, 35);
            this.dziel.Name = "dziel";
            this.dziel.Size = new System.Drawing.Size(36, 29);
            this.dziel.TabIndex = 8;
            this.dziel.TabStop = true;
            this.dziel.Text = "/";
            this.dziel.UseVisualStyleBackColor = true;
            this.dziel.CheckedChanged += new System.EventHandler(this.dziel_CheckedChanged);
            // 
            // dod
            // 
            this.dod.AutoSize = true;
            this.dod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.dod.Location = new System.Drawing.Point(153, 70);
            this.dod.Name = "dod";
            this.dod.Size = new System.Drawing.Size(42, 29);
            this.dod.TabIndex = 9;
            this.dod.TabStop = true;
            this.dod.Text = "+";
            this.dod.UseVisualStyleBackColor = true;
            this.dod.CheckedChanged += new System.EventHandler(this.dod_CheckedChanged);
            // 
            // min
            // 
            this.min.AutoSize = true;
            this.min.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.min.Location = new System.Drawing.Point(153, 105);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(37, 29);
            this.min.TabIndex = 10;
            this.min.TabStop = true;
            this.min.Text = "-";
            this.min.UseVisualStyleBackColor = true;
            this.min.CheckedChanged += new System.EventHandler(this.min_CheckedChanged);
            // 
            // EXECUTE
            // 
            this.EXECUTE.Location = new System.Drawing.Point(436, 99);
            this.EXECUTE.Name = "EXECUTE";
            this.EXECUTE.Size = new System.Drawing.Size(75, 23);
            this.EXECUTE.TabIndex = 11;
            this.EXECUTE.Text = "EXECUTE";
            this.EXECUTE.UseVisualStyleBackColor = true;
            this.EXECUTE.Click += new System.EventHandler(this.EXECUTE_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(325, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(17, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "X:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(195, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Y:";
            // 
            // Float
            // 
            this.Float.AutoSize = true;
            this.Float.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Float.Location = new System.Drawing.Point(12, 105);
            this.Float.Name = "Float";
            this.Float.Size = new System.Drawing.Size(72, 21);
            this.Float.TabIndex = 16;
            this.Float.Text = "FLOAT";
            this.Float.UseVisualStyleBackColor = true;
            this.Float.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // KALKOLOTUR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 136);
            this.Controls.Add(this.Float);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EXECUTE);
            this.Controls.Add(this.min);
            this.Controls.Add(this.dod);
            this.Controls.Add(this.dziel);
            this.Controls.Add(this.mno);
            this.Controls.Add(this.wartosc3);
            this.Controls.Add(this.wartosc2);
            this.Controls.Add(this.wartosc1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "KALKOLOTUR";
            this.Text = "KALKOLOTUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wartosc1;
        private System.Windows.Forms.TextBox wartosc2;
        private System.Windows.Forms.TextBox wartosc3;
        private System.Windows.Forms.RadioButton mno;
        private System.Windows.Forms.RadioButton dziel;
        private System.Windows.Forms.RadioButton dod;
        private System.Windows.Forms.RadioButton min;
        private System.Windows.Forms.Button EXECUTE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Float;
    }
}

