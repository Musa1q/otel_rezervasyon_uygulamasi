namespace otel_rezervasyon_uygulaması.Forms
{
    partial class KarsilamaEkrani
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
            girisButton = new Button();
            label1 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // girisButton
            // 
            girisButton.FlatStyle = FlatStyle.Flat;
            girisButton.Location = new Point(164, 283);
            girisButton.Name = "girisButton";
            girisButton.Size = new Size(109, 31);
            girisButton.TabIndex = 3;
            girisButton.Text = "Giriş Yap";
            girisButton.UseVisualStyleBackColor = true;
            girisButton.Click += girisButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 145);
            label1.Name = "label1";
            label1.Size = new Size(200, 30);
            label1.TabIndex = 5;
            label1.Text = "Logolu yazı gelecek";
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(34, 283);
            button2.Name = "button2";
            button2.Size = new Size(109, 31);
            button2.TabIndex = 6;
            button2.Text = "Kayıt Ol";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // KarsilamaEkrani
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(309, 415);
            Controls.Add(button2);
            Controls.Add(label1);
            Controls.Add(girisButton);
            Name = "KarsilamaEkrani";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KarsilamaEkrani";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button girisButton;
        private Label label1;
        private Button button2;
    }
}