namespace PrestationsLager
{
    partial class SkapaKonto
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
            textNewUserName = new TextBox();
            textEpost = new TextBox();
            label3 = new Label();
            textBetalningsMetod = new TextBox();
            label4 = new Label();
            textAnvändareID = new TextBox();
            label5 = new Label();
            textNyttLösenord = new TextBox();
            label6 = new Label();
            textRättLösenord = new TextBox();
            label7 = new Label();
            VissaNyLösenord = new CheckBox();
            REGISTERA = new Button();
            label8 = new Label();
            RensaFält = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Guttman-CourMir", 27.7499962F, FontStyle.Bold, GraphicsUnit.Point, 177);
            label1.ForeColor = Color.SeaGreen;
            label1.Location = new Point(28, 68);
            label1.Name = "label1";
            label1.Size = new Size(236, 48);
            label1.TabIndex = 0;
            label1.Text = "Get Started";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 121);
            label2.Name = "label2";
            label2.Size = new Size(72, 17);
            label2.TabIndex = 1;
            label2.Text = "Full Namn";
            //label2.Click += label2_Click;
            // 
            // textNewUserName
            // 
            textNewUserName.BackColor = Color.FromArgb(230, 231, 233);
            textNewUserName.Location = new Point(35, 141);
            textNewUserName.Multiline = true;
            textNewUserName.Name = "textNewUserName";
            textNewUserName.Size = new Size(229, 23);
            textNewUserName.TabIndex = 2;
            // 
            // textEpost
            // 
            textEpost.BackColor = Color.FromArgb(230, 231, 233);
            textEpost.Location = new Point(35, 199);
            textEpost.Multiline = true;
            textEpost.Name = "textEpost";
            textEpost.Size = new Size(229, 23);
            textEpost.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 179);
            label3.Name = "label3";
            label3.Size = new Size(47, 17);
            label3.TabIndex = 3;
            label3.Text = "E-post";
            // 
            // textBetalningsMetod
            // 
            textBetalningsMetod.BackColor = Color.FromArgb(230, 231, 233);
            textBetalningsMetod.Location = new Point(35, 256);
            textBetalningsMetod.Multiline = true;
            textBetalningsMetod.Name = "textBetalningsMetod";
            textBetalningsMetod.Size = new Size(229, 23);
            textBetalningsMetod.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 236);
            label4.Name = "label4";
            label4.Size = new Size(117, 17);
            label4.TabIndex = 5;
            label4.Text = "Betalnings Metod";
            // 
            // textAnvändareID
            // 
            textAnvändareID.BackColor = Color.FromArgb(230, 231, 233);
            textAnvändareID.Location = new Point(35, 308);
            textAnvändareID.Multiline = true;
            textAnvändareID.Name = "textAnvändareID";
            textAnvändareID.Size = new Size(229, 23);
            textAnvändareID.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 288);
            label5.Name = "label5";
            label5.Size = new Size(154, 17);
            label5.TabIndex = 7;
            label5.Text = "Din unika användare ID";
            // 
            // textNyttLösenord
            // 
            textNyttLösenord.BackColor = Color.FromArgb(230, 231, 233);
            textNyttLösenord.Location = new Point(35, 360);
            textNyttLösenord.Multiline = true;
            textNyttLösenord.Name = "textNyttLösenord";
            textNyttLösenord.PasswordChar = '*';
            textNyttLösenord.Size = new Size(229, 23);
            textNyttLösenord.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 340);
            label6.Name = "label6";
            label6.Size = new Size(65, 17);
            label6.TabIndex = 9;
            label6.Text = "Lösenord";
            // 
            // textRättLösenord
            // 
            textRättLösenord.BackColor = Color.FromArgb(230, 231, 233);
            textRättLösenord.Location = new Point(35, 409);
            textRättLösenord.Multiline = true;
            textRättLösenord.Name = "textRättLösenord";
            textRättLösenord.PasswordChar = '*';
            textRättLösenord.Size = new Size(229, 23);
            textRättLösenord.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 389);
            label7.Name = "label7";
            label7.Size = new Size(117, 17);
            label7.TabIndex = 11;
            label7.Text = "Bekräfta lösenord";
            // 
            // VissaNyLösenord
            // 
            VissaNyLösenord.AutoSize = true;
            VissaNyLösenord.Cursor = Cursors.Hand;
            VissaNyLösenord.FlatStyle = FlatStyle.Flat;
            VissaNyLösenord.Location = new Point(224, 438);
            VissaNyLösenord.Name = "VissaNyLösenord";
            VissaNyLösenord.Size = new Size(117, 21);
            VissaNyLösenord.TabIndex = 13;
            VissaNyLösenord.Text = "Vissa Lösenord";
            VissaNyLösenord.UseVisualStyleBackColor = true;
            VissaNyLösenord.CheckedChanged += VissaNyLösenord_CheckedChanged;
            // 
            // REGISTERA
            // 
            REGISTERA.BackColor = Color.SeaGreen;
            REGISTERA.Cursor = Cursors.Hand;
            REGISTERA.FlatAppearance.BorderSize = 0;
            REGISTERA.FlatStyle = FlatStyle.Flat;
            REGISTERA.ForeColor = Color.White;
            REGISTERA.Location = new Point(35, 448);
            REGISTERA.Name = "REGISTERA";
            REGISTERA.Size = new Size(174, 33);
            REGISTERA.TabIndex = 14;
            REGISTERA.Text = "Registrera ";
            REGISTERA.UseVisualStyleBackColor = false;
            REGISTERA.Click += REGISTERA_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(66, 532);
            label8.Name = "label8";
            label8.Size = new Size(106, 21);
            label8.TabIndex = 16;
            label8.Text = "Gå till Log in";
            label8.Click += label8_Click;
            // 
            // RensaFält
            // 
            RensaFält.BackColor = Color.White;
            RensaFält.Cursor = Cursors.Hand;
            RensaFält.FlatStyle = FlatStyle.Flat;
            RensaFält.ForeColor = Color.SeaGreen;
            RensaFält.Location = new Point(35, 487);
            RensaFält.Name = "RensaFält";
            RensaFält.Size = new Size(174, 33);
            RensaFält.TabIndex = 17;
            RensaFält.Text = "Rensa Fält";
            RensaFält.UseVisualStyleBackColor = false;
            // 
            // SkapaKonto
            // 
            AutoScaleDimensions = new SizeF(8F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(418, 580);
            Controls.Add(RensaFält);
            Controls.Add(label8);
            Controls.Add(REGISTERA);
            Controls.Add(VissaNyLösenord);
            Controls.Add(textRättLösenord);
            Controls.Add(label7);
            Controls.Add(textNyttLösenord);
            Controls.Add(label6);
            Controls.Add(textAnvändareID);
            Controls.Add(label5);
            Controls.Add(textBetalningsMetod);
            Controls.Add(label4);
            Controls.Add(textEpost);
            Controls.Add(label3);
            Controls.Add(textNewUserName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Nirmala UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ForeColor = Color.FromArgb(164, 165, 169);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SkapaKonto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Button button2;
        private Button REGISTERA;
        private CheckBox VissaNyLösenord;
        private TextBox textRättLösenord;
        private Label label7;
        private TextBox textNyttLösenord;
        private Label label6;
        private TextBox textAnvändareID;
        private Label label5;
        private TextBox textBetalningsMetod;
        private Label label4;
        private TextBox textEpost;
        private Label label3;
        private TextBox textNewUserName;
        private Label label2;
        private Label label1;
        private Button RensaFält;
    }
}