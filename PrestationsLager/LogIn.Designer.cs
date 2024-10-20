namespace PrestationsLager
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            EfterLogIN = new Button();
            label2 = new Label();
            label3 = new Label();
            textNamn = new TextBox();
            textLösenord = new TextBox();
            RänsaFält = new Label();
            label5 = new Label();
            label6 = new Label();
            textVisaLösenord = new CheckBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Lucida Fax", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(115, 156);
            label1.Name = "label1";
            label1.Size = new Size(129, 37);
            label1.TabIndex = 5;
            label1.Text = "LOG IN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(66, 259);
            panel1.Name = "panel1";
            panel1.Size = new Size(222, 1);
            panel1.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaptionText;
            panel2.Location = new Point(66, 319);
            panel2.Name = "panel2";
            panel2.Size = new Size(222, 1);
            panel2.TabIndex = 7;
            // 
            // EfterLogIN
            // 
            EfterLogIN.BackColor = Color.SeaGreen;
            EfterLogIN.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            EfterLogIN.ForeColor = Color.White;
            EfterLogIN.Location = new Point(115, 339);
            EfterLogIN.Name = "EfterLogIN";
            EfterLogIN.Size = new Size(129, 45);
            EfterLogIN.TabIndex = 8;
            EfterLogIN.Text = "LOG IN";
            EfterLogIN.UseVisualStyleBackColor = false;
            EfterLogIN.Click += LogIn_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(132, 387);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 9;
            label2.Text = "Skapa Konto";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(161, 475);
            label3.Name = "label3";
            label3.Size = new Size(33, 20);
            label3.TabIndex = 10;
            label3.Text = "Exit";
            label3.Click += label3_Click;
            // 
            // textNamn
            // 
            textNamn.BackColor = Color.FromArgb(230, 231, 233);
            textNamn.BorderStyle = BorderStyle.None;
            textNamn.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textNamn.ForeColor = SystemColors.WindowText;
            textNamn.Location = new Point(97, 234);
            textNamn.Multiline = true;
            textNamn.Name = "textNamn";
            textNamn.Size = new Size(188, 25);
            textNamn.TabIndex = 11;
            // 
            // textLösenord
            // 
            textLösenord.BackColor = Color.FromArgb(230, 231, 233);
            textLösenord.BorderStyle = BorderStyle.None;
            textLösenord.Font = new Font("Sylfaen", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textLösenord.ForeColor = SystemColors.WindowText;
            textLösenord.Location = new Point(97, 292);
            textLösenord.Multiline = true;
            textLösenord.Name = "textLösenord";
            textLösenord.PasswordChar = '*';
            textLösenord.Size = new Size(188, 25);
            textLösenord.TabIndex = 12;
            // 
            // RänsaFält
            // 
            RänsaFält.AutoSize = true;
            RänsaFält.BackColor = Color.White;
            RänsaFält.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RänsaFält.ForeColor = Color.Green;
            RänsaFält.Location = new Point(141, 423);
            RänsaFält.Name = "RänsaFält";
            RänsaFält.Size = new Size(75, 20);
            RänsaFält.TabIndex = 13;
            RänsaFält.Text = "Rensa Fält";
            RänsaFält.Click += RänsaFält_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(62, 210);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 14;
            label5.Text = "Full Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(66, 274);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 15;
            label6.Text = "Password";
            // 
            // textVisaLösenord
            // 
            textVisaLösenord.AutoSize = true;
            textVisaLösenord.Cursor = Cursors.Hand;
            textVisaLösenord.FlatStyle = FlatStyle.Flat;
            textVisaLösenord.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textVisaLösenord.Location = new Point(250, 323);
            textVisaLösenord.Name = "textVisaLösenord";
            textVisaLösenord.Size = new Size(104, 19);
            textVisaLösenord.TabIndex = 16;
            textVisaLösenord.Text = "Vissa Lösenord";
            textVisaLösenord.UseVisualStyleBackColor = true;
            textVisaLösenord.CheckedChanged += VisaLösenord_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(66, 232);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(66, 292);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(115, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(129, 129);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 19;
            pictureBox3.TabStop = false;
            //pictureBox3.Click += pictureBox3_Click;
            // 
            // LogIn
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(382, 504);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(textVisaLösenord);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(RänsaFält);
            Controls.Add(textLösenord);
            Controls.Add(textNamn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(EfterLogIN);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LogIn";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Label label6;
        private Label label5;
        private TextBox textNamn;
        private Panel panel1;
        private PictureBox pictureBox2;
        private CheckBox textVisaLösenord;
        private Label RänsaFält;
        private TextBox textLösenord;
        private Label label3;
        private Label label2;
        private Button EfterLogIN;
        private Panel panel2;
    }
}
