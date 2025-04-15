namespace WinFormsApp25
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            tmrSaat = new System.Windows.Forms.Timer(components);
            lblSaat = new Label();
            btnKapat = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.saat;
            pictureBox1.Image = Properties.Resources.saat;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(-2, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tmrSaat
            // 
            tmrSaat.Enabled = true;
            tmrSaat.Interval = 1000;
            tmrSaat.Tick += tmrSaat_Tick;
            // 
            // lblSaat
            // 
            lblSaat.AutoSize = true;
            lblSaat.BackColor = SystemColors.ActiveCaptionText;
            lblSaat.ForeColor = SystemColors.ButtonFace;
            lblSaat.Location = new Point(114, 219);
            lblSaat.Name = "lblSaat";
            lblSaat.Size = new Size(50, 20);
            lblSaat.TabIndex = 1;
            lblSaat.Text = "label1";
            // 
            // btnKapat
            // 
            btnKapat.BackColor = SystemColors.ButtonShadow;
            btnKapat.Location = new Point(244, 27);
            btnKapat.Name = "btnKapat";
            btnKapat.Size = new Size(49, 29);
            btnKapat.TabIndex = 2;
            btnKapat.Text = "x";
            btnKapat.UseVisualStyleBackColor = false;
            btnKapat.Click += btnKapat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 450);
            Controls.Add(btnKapat);
            Controls.Add(lblSaat);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrSaat;
        private Label lblSaat;
        private Button btnKapat;
    }
}
