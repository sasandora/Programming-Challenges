namespace Programming_Challenges
{
    partial class frnNameGenerator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.chklbNationalities = new System.Windows.Forms.CheckedListBox();
            this.txtEnimi = new System.Windows.Forms.TextBox();
            this.txtSnimi = new System.Windows.Forms.TextBox();
            this.btnLuoNimi = new System.Windows.Forms.Button();
            this.rdMies = new System.Windows.Forms.RadioButton();
            this.rdNainen = new System.Windows.Forms.RadioButton();
            this.rdMuu = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // chklbNationalities
            // 
            this.chklbNationalities.CheckOnClick = true;
            this.chklbNationalities.FormattingEnabled = true;
            this.chklbNationalities.Location = new System.Drawing.Point(180, 82);
            this.chklbNationalities.Name = "chklbNationalities";
            this.chklbNationalities.Size = new System.Drawing.Size(120, 289);
            this.chklbNationalities.Sorted = true;
            this.chklbNationalities.TabIndex = 0;
            // 
            // txtEnimi
            // 
            this.txtEnimi.Location = new System.Drawing.Point(29, 34);
            this.txtEnimi.Name = "txtEnimi";
            this.txtEnimi.ReadOnly = true;
            this.txtEnimi.Size = new System.Drawing.Size(128, 20);
            this.txtEnimi.TabIndex = 1;
            this.txtEnimi.Click += new System.EventHandler(this.txtEnimi_Click);
            // 
            // txtSnimi
            // 
            this.txtSnimi.Location = new System.Drawing.Point(180, 34);
            this.txtSnimi.Name = "txtSnimi";
            this.txtSnimi.ReadOnly = true;
            this.txtSnimi.Size = new System.Drawing.Size(135, 20);
            this.txtSnimi.TabIndex = 2;
            this.txtSnimi.Click += new System.EventHandler(this.txtSnimi_Click);
            // 
            // btnLuoNimi
            // 
            this.btnLuoNimi.Location = new System.Drawing.Point(29, 186);
            this.btnLuoNimi.Name = "btnLuoNimi";
            this.btnLuoNimi.Size = new System.Drawing.Size(75, 23);
            this.btnLuoNimi.TabIndex = 3;
            this.btnLuoNimi.Text = "Luo nimi";
            this.btnLuoNimi.UseVisualStyleBackColor = true;
            this.btnLuoNimi.Click += new System.EventHandler(this.btnLuoNimi_Click);
            // 
            // rdMies
            // 
            this.rdMies.AutoSize = true;
            this.rdMies.Location = new System.Drawing.Point(29, 91);
            this.rdMies.Name = "rdMies";
            this.rdMies.Size = new System.Drawing.Size(47, 17);
            this.rdMies.TabIndex = 4;
            this.rdMies.TabStop = true;
            this.rdMies.Text = "Mies";
            this.rdMies.UseVisualStyleBackColor = true;
            // 
            // rdNainen
            // 
            this.rdNainen.AutoSize = true;
            this.rdNainen.Location = new System.Drawing.Point(29, 114);
            this.rdNainen.Name = "rdNainen";
            this.rdNainen.Size = new System.Drawing.Size(59, 17);
            this.rdNainen.TabIndex = 5;
            this.rdNainen.TabStop = true;
            this.rdNainen.Text = "Nainen";
            this.rdNainen.UseVisualStyleBackColor = true;
            // 
            // rdMuu
            // 
            this.rdMuu.AutoSize = true;
            this.rdMuu.Location = new System.Drawing.Point(29, 137);
            this.rdMuu.Name = "rdMuu";
            this.rdMuu.Size = new System.Drawing.Size(59, 17);
            this.rdMuu.TabIndex = 6;
            this.rdMuu.TabStop = true;
            this.rdMuu.Text = "Ei väliä";
            this.rdMuu.UseVisualStyleBackColor = true;
            // 
            // frnNameGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.rdMuu);
            this.Controls.Add(this.rdNainen);
            this.Controls.Add(this.rdMies);
            this.Controls.Add(this.btnLuoNimi);
            this.Controls.Add(this.txtSnimi);
            this.Controls.Add(this.txtEnimi);
            this.Controls.Add(this.chklbNationalities);
            this.Name = "frnNameGenerator";
            this.Text = "Name Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chklbNationalities;
        private System.Windows.Forms.TextBox txtEnimi;
        private System.Windows.Forms.TextBox txtSnimi;
        private System.Windows.Forms.Button btnLuoNimi;
        private System.Windows.Forms.RadioButton rdMies;
        private System.Windows.Forms.RadioButton rdNainen;
        private System.Windows.Forms.RadioButton rdMuu;
    }
}