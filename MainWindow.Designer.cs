namespace Programming_Challenges
{
    partial class MainWindow
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
            this.btn3 = new System.Windows.Forms.Button();
            this.btnNameGenerator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(12, 123);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(109, 23);
            this.btn3.TabIndex = 0;
            this.btn3.Text = "High/Low (1)";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnNameGenerator
            // 
            this.btnNameGenerator.Location = new System.Drawing.Point(12, 94);
            this.btnNameGenerator.Name = "btnNameGenerator";
            this.btnNameGenerator.Size = new System.Drawing.Size(109, 23);
            this.btnNameGenerator.TabIndex = 1;
            this.btnNameGenerator.Text = "Name Generator (0)";
            this.btnNameGenerator.UseVisualStyleBackColor = true;
            this.btnNameGenerator.Click += new System.EventHandler(this.btnNameGenerator_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNameGenerator);
            this.Controls.Add(this.btn3);
            this.Name = "MainWindow";
            this.Text = "App";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnNameGenerator;
    }
}

