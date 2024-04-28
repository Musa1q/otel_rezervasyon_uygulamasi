namespace otel_rezervasyon_uygulaması.Forms
{
    partial class AnasayfaForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            label4 = new Label();
            button1 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(29, 64);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 1;
            label1.Text = "Tek Kişilik Odalar";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(305, 66);
            label2.Name = "label2";
            label2.Size = new Size(139, 18);
            label2.TabIndex = 2;
            label2.Text = "Çift Kişilik Odalar";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(603, 64);
            label3.Name = "label3";
            label3.Size = new Size(134, 18);
            label3.TabIndex = 3;
            label3.Text = "Üç Kişilik Odalar";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = null;
            pictureBox1.Location = new Point(29, 166);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 169);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(295, 166);
            label7.Name = "label7";
            label7.Size = new Size(106, 21);
            label7.TabIndex = 7;
            label7.Text = "Otel içeriği : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(424, 166);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 8;
            label4.Text = "şitişiti";
            label4.Visible = false;
            // 
            // button1
            // 
            button1.Location = new Point(713, 425);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 49);
            label8.Name = "label8";
            label8.Size = new Size(149, 15);
            label8.TabIndex = 10;
            label8.Text = "Odaları görmek için seçiniz";
            // 
            // AnasayfaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(800, 450);
            Controls.Add(label8);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AnasayfaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnasayfaForm";
            Load += AnasayfaForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label7;
        private Button button1;
        private Label label8;
    }
}