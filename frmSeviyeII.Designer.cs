namespace TusBas
{
    partial class frmSeviyeII
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
            lblSure = new Label();
            btnBasla = new Button();
            txtBx = new TextBox();
            lblHarf = new Label();
            Timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            btnOnayla = new Button();
            label3 = new Label();
            label2 = new Label();
            cmbBxSkor = new ComboBox();
            cmbBxSure = new ComboBox();
            lblAyarlar = new Label();
            lblOnceki = new Label();
            btnSonrakiSeviye = new Button();
            lblSkor = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lblSure
            // 
            lblSure.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSure.Location = new Point(134, 146);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(110, 45);
            lblSure.TabIndex = 17;
            lblSure.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnBasla
            // 
            btnBasla.BackColor = Color.LawnGreen;
            btnBasla.FlatAppearance.BorderSize = 0;
            btnBasla.FlatStyle = FlatStyle.Flat;
            btnBasla.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBasla.Location = new Point(11, 101);
            btnBasla.Name = "btnBasla";
            btnBasla.Size = new Size(102, 34);
            btnBasla.TabIndex = 16;
            btnBasla.Text = "Başla";
            btnBasla.UseVisualStyleBackColor = false;
            btnBasla.Click += btnBasla_Click;
            // 
            // txtBx
            // 
            txtBx.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtBx.Location = new Point(134, 101);
            txtBx.Multiline = true;
            txtBx.Name = "txtBx";
            txtBx.Size = new Size(110, 34);
            txtBx.TabIndex = 15;
            txtBx.KeyPress += txtBx_KeyPress;
            // 
            // lblHarf
            // 
            lblHarf.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblHarf.Location = new Point(134, 47);
            lblHarf.Name = "lblHarf";
            lblHarf.Size = new Size(110, 45);
            lblHarf.TabIndex = 14;
            lblHarf.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Timer1
            // 
            Timer1.Interval = 1000;
            Timer1.Tick += Timer1_Tick;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(45, 146);
            label1.Name = "label1";
            label1.Size = new Size(110, 45);
            label1.TabIndex = 27;
            label1.Text = "Süre:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOnayla
            // 
            btnOnayla.BackColor = Color.LawnGreen;
            btnOnayla.FlatAppearance.BorderSize = 0;
            btnOnayla.FlatStyle = FlatStyle.Flat;
            btnOnayla.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnOnayla.Location = new Point(298, 235);
            btnOnayla.Name = "btnOnayla";
            btnOnayla.Size = new Size(102, 29);
            btnOnayla.TabIndex = 26;
            btnOnayla.Text = "Onayla";
            btnOnayla.UseVisualStyleBackColor = false;
            btnOnayla.Click += btnOnayla_Click;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(170, 204);
            label3.Name = "label3";
            label3.Size = new Size(59, 30);
            label3.TabIndex = 25;
            label3.Text = "Skor:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(25, 204);
            label2.Name = "label2";
            label2.Size = new Size(59, 30);
            label2.TabIndex = 24;
            label2.Text = "Süre:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cmbBxSkor
            // 
            cmbBxSkor.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxSkor.FormattingEnabled = true;
            cmbBxSkor.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "35", "40", "45", "50" });
            cmbBxSkor.Location = new Point(171, 235);
            cmbBxSkor.Name = "cmbBxSkor";
            cmbBxSkor.Size = new Size(121, 29);
            cmbBxSkor.TabIndex = 23;
            // 
            // cmbBxSure
            // 
            cmbBxSure.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cmbBxSure.FormattingEnabled = true;
            cmbBxSure.Items.AddRange(new object[] { "10", "15", "25", "30", "40", "50", "60" });
            cmbBxSure.Location = new Point(26, 235);
            cmbBxSure.Name = "cmbBxSure";
            cmbBxSure.Size = new Size(121, 29);
            cmbBxSure.TabIndex = 22;
            // 
            // lblAyarlar
            // 
            lblAyarlar.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblAyarlar.Location = new Point(3, 2);
            lblAyarlar.Name = "lblAyarlar";
            lblAyarlar.Size = new Size(291, 30);
            lblAyarlar.TabIndex = 21;
            lblAyarlar.Text = "---- | ----";
            lblAyarlar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOnceki
            // 
            lblOnceki.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblOnceki.Location = new Point(263, 121);
            lblOnceki.Name = "lblOnceki";
            lblOnceki.Size = new Size(155, 45);
            lblOnceki.TabIndex = 20;
            lblOnceki.Text = "Önceki Skor:";
            lblOnceki.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSonrakiSeviye
            // 
            btnSonrakiSeviye.BackColor = Color.Yellow;
            btnSonrakiSeviye.FlatAppearance.BorderSize = 0;
            btnSonrakiSeviye.FlatStyle = FlatStyle.Flat;
            btnSonrakiSeviye.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSonrakiSeviye.Location = new Point(303, 4);
            btnSonrakiSeviye.Name = "btnSonrakiSeviye";
            btnSonrakiSeviye.Size = new Size(120, 30);
            btnSonrakiSeviye.TabIndex = 19;
            btnSonrakiSeviye.Text = "Sonraki Seviye";
            btnSonrakiSeviye.UseVisualStyleBackColor = false;
            btnSonrakiSeviye.Click += btnSonrakiSeviye_Click;
            // 
            // lblSkor
            // 
            lblSkor.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblSkor.Location = new Point(262, 76);
            lblSkor.Name = "lblSkor";
            lblSkor.Size = new Size(136, 45);
            lblSkor.TabIndex = 18;
            lblSkor.Text = "Skor: 0";
            lblSkor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 51);
            label4.Name = "label4";
            label4.Size = new Size(96, 31);
            label4.TabIndex = 43;
            label4.Text = "2. Seviye";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // frmSeviyeII
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 279);
            Controls.Add(label4);
            Controls.Add(lblSure);
            Controls.Add(btnBasla);
            Controls.Add(txtBx);
            Controls.Add(lblHarf);
            Controls.Add(label1);
            Controls.Add(btnOnayla);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cmbBxSkor);
            Controls.Add(cmbBxSure);
            Controls.Add(lblAyarlar);
            Controls.Add(lblOnceki);
            Controls.Add(btnSonrakiSeviye);
            Controls.Add(lblSkor);
            Name = "frmSeviyeII";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "2. Level";
            Load += frmSeviyeII_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSure;
        private Button btnBasla;
        private TextBox txtBx;
        private Label lblHarf;
        private System.Windows.Forms.Timer Timer1;
        private Label label1;
        private Button btnOnayla;
        private Label label3;
        private Label label2;
        private ComboBox cmbBxSkor;
        private ComboBox cmbBxSure;
        private Label lblAyarlar;
        private Label lblOnceki;
        private Button btnSonrakiSeviye;
        private Label lblSkor;
        private Label label4;
    }
}