﻿namespace otel_rezervasyon_uygulaması
{
    partial class GirisForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            girisButton = new Button();
            textBox1 = new TextBox();
            panel1 = new Panel();
            textBox2 = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__1_;
            pictureBox1.Location = new Point(10, 348);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(44, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com;
            pictureBox2.Location = new Point(10, 425);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(44, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // girisButton
            // 
            girisButton.FlatStyle = FlatStyle.Flat;
            girisButton.Location = new Point(207, 484);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(109, 31);
            girisButton.TabIndex = 2;
            girisButton.Text = "Giriş Yap";
            girisButton.UseVisualStyleBackColor = true;
            girisButton.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.LightGray;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(60, 360);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(256, 25);
            textBox1.TabIndex = 3;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(60, 387);
            panel1.Name = "panel1";
            panel1.Size = new Size(256, 4);
            panel1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(60, 437);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(256, 25);
            textBox2.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(60, 464);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 4);
            panel2.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.GrayText;
            label1.Location = new Point(10, 500);
            label1.Name = "label1";
            label1.Size = new Size(98, 15);
            label1.TabIndex = 7;
            label1.Text = "Şifremi Unuttum?";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(97, 9);
            label2.Name = "label2";
            label2.Size = new Size(119, 22);
            label2.TabIndex = 9;
            label2.Text = "Giriş Ekranı";
            // 
            // button1
            // 
            button1.BackColor = Color.LightGray;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(207, 521);
            button1.Name = "button1";
            button1.Size = new Size(109, 31);
            button1.TabIndex = 10;
            button1.Text = "Giriş Yap";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.Octavia_otel_logo1;
            pictureBox3.Location = new Point(12, 34);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(295, 295);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 65;
            pictureBox3.TabStop = false;
            // 
            // GirisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(332, 585);
            Controls.Add(label2);
            Controls.Add(pictureBox3);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(panel1);
            Controls.Add(textBox1);
            Controls.Add(girisButton);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "GirisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button girisButton;
        private TextBox textBox1;
        private Panel panel1;
        private TextBox textBox2;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button button1;
        private PictureBox pictureBox3;
    }
}
