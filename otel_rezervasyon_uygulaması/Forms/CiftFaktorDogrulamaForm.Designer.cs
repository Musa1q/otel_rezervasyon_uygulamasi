namespace otel_rezervasyon_uygulaması.Forms
{
    partial class CiftFaktorDogrulamaForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button1 = new Button();
            label2 = new Label();
            timerCountdown = new System.Windows.Forms.Timer(components);
            labelCountdown = new Label();
            label3 = new Label();
            sureDolduLabel = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(76, 111);
            label1.Name = "label1";
            label1.Size = new Size(602, 30);
            label1.TabIndex = 0;
            label1.Text = "Lütfen Mail Adresinize Gelen 6 Haneli Doğrulama Kodu Giriniz";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(241, 196);
            panel2.Name = "panel2";
            panel2.Size = new Size(256, 4);
            panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.LightGray;
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Cursor = Cursors.IBeam;
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(241, 169);
            textBox2.MaxLength = 6;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(256, 25);
            textBox2.TabIndex = 8;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(422, 215);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 9;
            button1.Text = "Doğrula";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.GrayText;
            label2.Location = new Point(241, 219);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 10;
            label2.Text = "Tekrar Gönder";
            label2.Click += label2_Click;
            // 
            // timerCountdown
            // 
            timerCountdown.Interval = 1000;
            timerCountdown.Tick += timerCountdown_Tick_1;
            // 
            // labelCountdown
            // 
            labelCountdown.AutoSize = true;
            labelCountdown.Font = new Font("Segoe UI", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            labelCountdown.Location = new Point(396, 259);
            labelCountdown.Name = "labelCountdown";
            labelCountdown.Size = new Size(48, 20);
            labelCountdown.TabIndex = 11;
            labelCountdown.Text = "label3";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(299, 259);
            label3.Name = "label3";
            label3.Size = new Size(102, 20);
            label3.TabIndex = 12;
            label3.Text = "Kalan Zaman:";
            // 
            // sureDolduLabel
            // 
            sureDolduLabel.AutoSize = true;
            sureDolduLabel.Font = new Font("Segoe UI Variable Small Semibol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            sureDolduLabel.ForeColor = Color.Brown;
            sureDolduLabel.Location = new Point(181, 298);
            sureDolduLabel.Name = "sureDolduLabel";
            sureDolduLabel.Size = new Size(403, 17);
            sureDolduLabel.TabIndex = 13;
            sureDolduLabel.Text = "Verilen Süre İçerisinde Kodu Girmediniz. Lütfen Tekrar Gönderin.";
            sureDolduLabel.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Variable Small Semibol", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Brown;
            label4.Location = new Point(220, 326);
            label4.Name = "label4";
            label4.Size = new Size(277, 17);
            label4.TabIndex = 14;
            label4.Text = "Kodu Yanlış Girdiniz. Lütfen Tekrar Deneyin.";
            label4.Visible = false;
            label4.Click += label4_Click;
            // 
            // CiftFaktorDogrulamaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(757, 447);
            Controls.Add(label4);
            Controls.Add(sureDolduLabel);
            Controls.Add(label3);
            Controls.Add(labelCountdown);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Name = "CiftFaktorDogrulamaForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CiftFaktorDogrulama";
            Load += CiftFaktorDogrulamaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel2;
        private TextBox textBox2;
        private Button button1;
        private Label label2;
        private System.Windows.Forms.Timer timerCountdown;
        private Label labelCountdown;
        private Label label3;
        private Label sureDolduLabel;
        private Label label4;
    }
}