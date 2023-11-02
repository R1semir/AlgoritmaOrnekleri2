namespace Algoritma2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTekSayilar = new System.Windows.Forms.Label();
            this.lblCiftSayilar = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(204, 197);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "   Tek Sayılar:\r\n-------------------------\r\n\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "   Çift Sayılar:\r\n-------------------------";
            // 
            // lblTekSayilar
            // 
            this.lblTekSayilar.AutoSize = true;
            this.lblTekSayilar.Location = new System.Drawing.Point(133, 135);
            this.lblTekSayilar.Name = "lblTekSayilar";
            this.lblTekSayilar.Size = new System.Drawing.Size(16, 20);
            this.lblTekSayilar.TabIndex = 3;
            this.lblTekSayilar.Text = "0";
            // 
            // lblCiftSayilar
            // 
            this.lblCiftSayilar.AutoSize = true;
            this.lblCiftSayilar.Location = new System.Drawing.Point(356, 135);
            this.lblCiftSayilar.Name = "lblCiftSayilar";
            this.lblCiftSayilar.Size = new System.Drawing.Size(16, 20);
            this.lblCiftSayilar.TabIndex = 4;
            this.lblCiftSayilar.Text = "0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(204, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 25);
            this.textBox1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(539, 312);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblCiftSayilar);
            this.Controls.Add(this.lblTekSayilar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTekSayilar;
        private System.Windows.Forms.Label lblCiftSayilar;
        private System.Windows.Forms.TextBox textBox1;
    }
}

