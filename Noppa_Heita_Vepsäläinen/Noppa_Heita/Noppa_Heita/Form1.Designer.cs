namespace Noppa_Heita
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_noppa1_luvut = new System.Windows.Forms.TextBox();
            this.txt_noppa2_luvut = new System.Windows.Forms.TextBox();
            this.txt_yhteensa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(87, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_noppa1_luvut
            // 
            this.txt_noppa1_luvut.Location = new System.Drawing.Point(233, 228);
            this.txt_noppa1_luvut.Name = "txt_noppa1_luvut";
            this.txt_noppa1_luvut.Size = new System.Drawing.Size(100, 26);
            this.txt_noppa1_luvut.TabIndex = 1;
            // 
            // txt_noppa2_luvut
            // 
            this.txt_noppa2_luvut.Location = new System.Drawing.Point(231, 285);
            this.txt_noppa2_luvut.Name = "txt_noppa2_luvut";
            this.txt_noppa2_luvut.Size = new System.Drawing.Size(102, 26);
            this.txt_noppa2_luvut.TabIndex = 2;
            // 
            // txt_yhteensa
            // 
            this.txt_yhteensa.Location = new System.Drawing.Point(454, 269);
            this.txt_yhteensa.Name = "txt_yhteensa";
            this.txt_yhteensa.Size = new System.Drawing.Size(98, 26);
            this.txt_yhteensa.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_yhteensa);
            this.Controls.Add(this.txt_noppa2_luvut);
            this.Controls.Add(this.txt_noppa1_luvut);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_noppa1_luvut;
        private System.Windows.Forms.TextBox txt_noppa2_luvut;
        private System.Windows.Forms.TextBox txt_yhteensa;
    }
}

