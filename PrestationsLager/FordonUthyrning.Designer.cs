namespace PrestationsLager
{
    partial class FordonUthyrning
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
            label3 = new Label();
            label2 = new Label();
            listStationer = new ListView();
            listFordon = new ListView();
            btnHyra = new Button();
            btnAvslutaHyra = new Button();
            lblFullNamn = new Label();
            lblEpost = new Label();
            listHyreshistorik = new ListView();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(314, 560);
            label1.Name = "label1";
            label1.Size = new Size(33, 20);
            label1.TabIndex = 16;
            label1.Text = "Exit";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.SeaGreen;
            label3.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(12, 358);
            label3.Name = "label3";
            label3.Size = new Size(53, 14);
            label3.TabIndex = 15;
            label3.Text = "Station";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.SeaGreen;
            label2.Font = new Font("Mongolian Baiti", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(331, 358);
            label2.Name = "label2";
            label2.Size = new Size(52, 14);
            label2.TabIndex = 14;
            label2.Text = "Fordon";
            // 
            // listStationer
            // 
            listStationer.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listStationer.GridLines = true;
            listStationer.Location = new Point(12, 375);
            listStationer.Name = "listStationer";
            listStationer.Size = new Size(303, 182);
            listStationer.TabIndex = 13;
            listStationer.UseCompatibleStateImageBehavior = false;
            listStationer.View = View.Details;
            listStationer.SelectedIndexChanged += listStationer_SelectedIndexChanged;
            // 
            // listFordon
            // 
            listFordon.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listFordon.GridLines = true;
            listFordon.Location = new Point(331, 375);
            listFordon.Name = "listFordon";
            listFordon.Size = new Size(408, 182);
            listFordon.TabIndex = 12;
            listFordon.UseCompatibleStateImageBehavior = false;
            listFordon.View = View.Details;
            // 
            // btnHyra
            // 
            btnHyra.BackColor = Color.SeaGreen;
            btnHyra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHyra.ForeColor = Color.White;
            btnHyra.Location = new Point(20, 293);
            btnHyra.Name = "btnHyra";
            btnHyra.Size = new Size(104, 33);
            btnHyra.TabIndex = 24;
            btnHyra.Text = "Hyra";
            btnHyra.UseVisualStyleBackColor = false;
            btnHyra.Click += btnHyra_Click_1;
            // 
            // btnAvslutaHyra
            // 
            btnAvslutaHyra.BackColor = Color.SeaGreen;
            btnAvslutaHyra.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAvslutaHyra.ForeColor = Color.White;
            btnAvslutaHyra.Location = new Point(302, 293);
            btnAvslutaHyra.Name = "btnAvslutaHyra";
            btnAvslutaHyra.Size = new Size(104, 33);
            btnAvslutaHyra.TabIndex = 25;
            btnAvslutaHyra.Text = "Avsluta Hyra";
            btnAvslutaHyra.UseVisualStyleBackColor = false;
            btnAvslutaHyra.Click += btnAvslutaHyra_Click_1;
            // 
            // lblFullNamn
            // 
            lblFullNamn.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFullNamn.Location = new Point(20, 9);
            lblFullNamn.Name = "lblFullNamn";
            lblFullNamn.Size = new Size(100, 23);
            lblFullNamn.TabIndex = 0;
            // 
            // lblEpost
            // 
            lblEpost.AutoSize = true;
            lblEpost.Font = new Font("Bell MT", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEpost.Location = new Point(20, 50);
            lblEpost.Name = "lblEpost";
            lblEpost.Size = new Size(0, 19);
            lblEpost.TabIndex = 27;
            // 
            // listHyreshistorik
            // 
            listHyreshistorik.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listHyreshistorik.GridLines = true;
            listHyreshistorik.Location = new Point(12, 72);
            listHyreshistorik.Name = "listHyreshistorik";
            listHyreshistorik.Size = new Size(424, 184);
            listHyreshistorik.TabIndex = 28;
            listHyreshistorik.UseCompatibleStateImageBehavior = false;
            listHyreshistorik.View = View.Details;
            // 
            // UthyrningForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(780, 586);
            Controls.Add(listHyreshistorik);
            Controls.Add(lblEpost);
            Controls.Add(lblFullNamn);
            Controls.Add(btnAvslutaHyra);
            Controls.Add(btnHyra);
            Controls.Add(label1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listStationer);
            Controls.Add(listFordon);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UthyrningForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UthyrningForm";
            Load += UthyrningForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private ListView listHyreshistorik;
        private Label lblEpost;
        private Label lblFullNamn;
        private Button btnAvslutaHyra;
        private Button btnHyra;
        private Label label3;
        private Label label1;
        private ListView listStationer;
        private ListView listFordon;
        private PictureBox pictureBox3;
    }
}