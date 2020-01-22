namespace Programming_Challenges
{
    partial class frnHighLow
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
            if (disposing && (components != null)) {
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
            this.btnIsompi = new System.Windows.Forms.Button();
            this.btnPienempi = new System.Windows.Forms.Button();
            this.lblOtsikko = new System.Windows.Forms.Label();
            this.lblArpa1 = new System.Windows.Forms.Label();
            this.lblArpa2 = new System.Windows.Forms.Label();
            this.lblTulos = new System.Windows.Forms.Label();
            this.btnSeuraavaPeli = new System.Windows.Forms.Button();
            this.lblVoittoPutki = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIsompi
            // 
            this.btnIsompi.BackColor = System.Drawing.Color.FloralWhite;
            this.btnIsompi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIsompi.Location = new System.Drawing.Point(29, 65);
            this.btnIsompi.Name = "btnIsompi";
            this.btnIsompi.Size = new System.Drawing.Size(181, 65);
            this.btnIsompi.TabIndex = 0;
            this.btnIsompi.Text = "ISOMPI";
            this.btnIsompi.UseVisualStyleBackColor = false;
            this.btnIsompi.Click += new System.EventHandler(this.btnIsompi_Click);
            // 
            // btnPienempi
            // 
            this.btnPienempi.BackColor = System.Drawing.Color.Azure;
            this.btnPienempi.ForeColor = System.Drawing.Color.DarkRed;
            this.btnPienempi.Location = new System.Drawing.Point(463, 65);
            this.btnPienempi.Name = "btnPienempi";
            this.btnPienempi.Size = new System.Drawing.Size(181, 65);
            this.btnPienempi.TabIndex = 1;
            this.btnPienempi.Text = "PIENEMPI";
            this.btnPienempi.UseVisualStyleBackColor = false;
            this.btnPienempi.Click += new System.EventHandler(this.btnPienempi_Click);
            // 
            // lblOtsikko
            // 
            this.lblOtsikko.AutoSize = true;
            this.lblOtsikko.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtsikko.Location = new System.Drawing.Point(159, 26);
            this.lblOtsikko.Name = "lblOtsikko";
            this.lblOtsikko.Size = new System.Drawing.Size(357, 16);
            this.lblOtsikko.TabIndex = 2;
            this.lblOtsikko.Text = "Luuletko seuraavan numeron olevan isompi, vai pienempi?";
            // 
            // lblArpa1
            // 
            this.lblArpa1.AutoSize = true;
            this.lblArpa1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArpa1.Location = new System.Drawing.Point(27, 156);
            this.lblArpa1.Name = "lblArpa1";
            this.lblArpa1.Size = new System.Drawing.Size(88, 25);
            this.lblArpa1.TabIndex = 3;
            this.lblArpa1.Text = "1. luku: ";
            // 
            // lblArpa2
            // 
            this.lblArpa2.AutoSize = true;
            this.lblArpa2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArpa2.Location = new System.Drawing.Point(27, 202);
            this.lblArpa2.Name = "lblArpa2";
            this.lblArpa2.Size = new System.Drawing.Size(88, 25);
            this.lblArpa2.TabIndex = 4;
            this.lblArpa2.Text = "2. luku: ";
            // 
            // lblTulos
            // 
            this.lblTulos.AutoSize = true;
            this.lblTulos.Font = new System.Drawing.Font("NI7SEG", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTulos.Location = new System.Drawing.Point(427, 164);
            this.lblTulos.Name = "lblTulos";
            this.lblTulos.Size = new System.Drawing.Size(62, 12);
            this.lblTulos.TabIndex = 5;
            this.lblTulos.Text = "Tulos: ";
            // 
            // btnSeuraavaPeli
            // 
            this.btnSeuraavaPeli.Location = new System.Drawing.Point(242, 65);
            this.btnSeuraavaPeli.Name = "btnSeuraavaPeli";
            this.btnSeuraavaPeli.Size = new System.Drawing.Size(181, 33);
            this.btnSeuraavaPeli.TabIndex = 6;
            this.btnSeuraavaPeli.Text = "Seuraava";
            this.btnSeuraavaPeli.UseVisualStyleBackColor = true;
            this.btnSeuraavaPeli.Click += new System.EventHandler(this.btnSeuraavaPeli_Click);
            // 
            // lblVoittoPutki
            // 
            this.lblVoittoPutki.AutoSize = true;
            this.lblVoittoPutki.Font = new System.Drawing.Font("NI7SEG", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVoittoPutki.Location = new System.Drawing.Point(427, 217);
            this.lblVoittoPutki.Name = "lblVoittoPutki";
            this.lblVoittoPutki.Size = new System.Drawing.Size(110, 12);
            this.lblVoittoPutki.TabIndex = 7;
            this.lblVoittoPutki.Text = "Voittoputki: ";
            // 
            // frnHighLow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 358);
            this.Controls.Add(this.lblVoittoPutki);
            this.Controls.Add(this.btnSeuraavaPeli);
            this.Controls.Add(this.lblTulos);
            this.Controls.Add(this.lblArpa2);
            this.Controls.Add(this.lblArpa1);
            this.Controls.Add(this.lblOtsikko);
            this.Controls.Add(this.btnPienempi);
            this.Controls.Add(this.btnIsompi);
            this.Name = "frnHighLow";
            this.Text = "High/Low";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIsompi;
        private System.Windows.Forms.Button btnPienempi;
        private System.Windows.Forms.Label lblOtsikko;
        private System.Windows.Forms.Label lblArpa1;
        private System.Windows.Forms.Label lblArpa2;
        private System.Windows.Forms.Label lblTulos;
        private System.Windows.Forms.Button btnSeuraavaPeli;
        private System.Windows.Forms.Label lblVoittoPutki;
    }
}