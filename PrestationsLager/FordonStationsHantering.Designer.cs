namespace PrestationsLager
{
    partial class FordonStationsHantering
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
            listFordon = new ListView();
            listStationer = new ListView();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtFordonID = new TextBox();
            label4 = new Label();
            txtTyp = new TextBox();
            label5 = new Label();
            txtBatteriNivå = new TextBox();
            label6 = new Label();
            txtStatus = new TextBox();
            label7 = new Label();
            Uppdatera = new Button();
            LäggTillFordn = new Button();
            TabortFordon = new Button();
            pictureBox1 = new PictureBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listFordon
            // 
            listFordon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listFordon.GridLines = true;
            listFordon.Location = new Point(331, 385);
            listFordon.Name = "listFordon";
            listFordon.Size = new Size(408, 182);
            listFordon.TabIndex = 0;
            listFordon.UseCompatibleStateImageBehavior = false;
            listFordon.View = View.Details;
            // 
            // listStationer
            // 
            listStationer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listStationer.GridLines = true;
            listStationer.Location = new Point(12, 385);
            listStationer.Name = "listStationer";
            listStationer.Size = new Size(303, 182);
            listStationer.TabIndex = 1;
            listStationer.UseCompatibleStateImageBehavior = false;
            listStationer.View = View.Details;
            listStationer.SelectedIndexChanged += listStationer_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(331, 368);
            label2.Name = "label2";
            label2.Size = new Size(52, 14);
            label2.TabIndex = 3;
            label2.Text = "Fordon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaGreen;
            label3.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 368);
            label3.Name = "label3";
            label3.Size = new Size(53, 14);
            label3.TabIndex = 4;
            label3.Text = "Station";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 570);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 11;
            label1.Text = "Exit";
            label1.Click += label1_Click;
            // 
            // txtFordonID
            // 
            txtFordonID.BackColor = Color.FromArgb(230, 231, 233);
            txtFordonID.Location = new Point(12, 145);
            txtFordonID.Multiline = true;
            txtFordonID.Name = "txtFordonID";
            txtFordonID.Size = new Size(229, 23);
            txtFordonID.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 125);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 12;
            label4.Text = "FordonID";
            // 
            // txtTyp
            // 
            txtTyp.BackColor = Color.FromArgb(230, 231, 233);
            txtTyp.Location = new Point(12, 196);
            txtTyp.Multiline = true;
            txtTyp.Name = "txtTyp";
            txtTyp.Size = new Size(229, 23);
            txtTyp.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 176);
            label5.Name = "label5";
            label5.Size = new Size(25, 15);
            label5.TabIndex = 14;
            label5.Text = "Typ";
            // 
            // txtBatteriNivå
            // 
            txtBatteriNivå.BackColor = Color.FromArgb(230, 231, 233);
            txtBatteriNivå.Location = new Point(12, 252);
            txtBatteriNivå.Multiline = true;
            txtBatteriNivå.Name = "txtBatteriNivå";
            txtBatteriNivå.Size = new Size(229, 23);
            txtBatteriNivå.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 232);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 16;
            label6.Text = "Batteri nivå";
            // 
            // txtStatus
            // 
            txtStatus.BackColor = Color.FromArgb(230, 231, 233);
            txtStatus.Location = new Point(12, 309);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(229, 23);
            txtStatus.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 289);
            label7.Name = "label7";
            label7.Size = new Size(39, 15);
            label7.TabIndex = 18;
            label7.Text = "Status";
            // 
            // Uppdatera
            // 
            Uppdatera.BackColor = Color.SeaGreen;
            Uppdatera.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Uppdatera.ForeColor = Color.White;
            Uppdatera.Location = new Point(279, 158);
            Uppdatera.Name = "Uppdatera";
            Uppdatera.Size = new Size(104, 33);
            Uppdatera.TabIndex = 23;
            Uppdatera.Text = "Uppdatera";
            Uppdatera.UseVisualStyleBackColor = false;
            Uppdatera.Click += Uppdatera_Click;
            // 
            // LäggTillFordn
            // 
            LäggTillFordn.BackColor = Color.SeaGreen;
            LäggTillFordn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LäggTillFordn.ForeColor = Color.White;
            LäggTillFordn.Location = new Point(279, 214);
            LäggTillFordn.Name = "LäggTillFordn";
            LäggTillFordn.Size = new Size(104, 33);
            LäggTillFordn.TabIndex = 26;
            LäggTillFordn.Text = "Lägg Till";
            LäggTillFordn.UseVisualStyleBackColor = false;
            LäggTillFordn.Click += LäggTillFordn_Click;
            // 
            // TabortFordon
            // 
            TabortFordon.BackColor = Color.SeaGreen;
            TabortFordon.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TabortFordon.ForeColor = Color.White;
            TabortFordon.Location = new Point(279, 271);
            TabortFordon.Name = "TabortFordon";
            TabortFordon.Size = new Size(104, 33);
            TabortFordon.TabIndex = 27;
            TabortFordon.Text = "Ta Bort";
            TabortFordon.UseVisualStyleBackColor = false;
            TabortFordon.Click += TabortFordon_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_10_11_000153;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 28;
            pictureBox1.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Guttman-CourMir", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 177);
            label8.ForeColor = Color.SeaGreen;
            label8.Location = new Point(147, 30);
            label8.Name = "label8";
            label8.Size = new Size(426, 38);
            label8.TabIndex = 29;
            label8.Text = "LET'S GET WORK DONE";
            // 
            // FordonStationsHantering
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 599);
            Controls.Add(label8);
            Controls.Add(pictureBox1);
            Controls.Add(TabortFordon);
            Controls.Add(LäggTillFordn);
            Controls.Add(Uppdatera);
            Controls.Add(txtStatus);
            Controls.Add(label7);
            Controls.Add(txtBatteriNivå);
            Controls.Add(label6);
            Controls.Add(txtTyp);
            Controls.Add(label5);
            Controls.Add(txtFordonID);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listStationer);
            Controls.Add(listFordon);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FordonStationsHantering";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += LäggTillFordon_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label3;
        private Label label4;
        private ListView listStationer;
        private ListView listFordon;
        private Label label8;
        private PictureBox pictureBox1;
        private Button TabortFordon;
        private Button LäggTillFordn;
        private Button Uppdatera;
        private TextBox txtStatus;
        private Label label7;
        private TextBox txtBatteriNivå;
        private Label label6;
        private TextBox txtTyp;
        private Label label5;
        private TextBox txtFordonID;
        private Label label1;
    }
}