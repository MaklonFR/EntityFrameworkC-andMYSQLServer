namespace StudentApp
{
    partial class ProfileForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_jurusan = new System.Windows.Forms.Label();
            this.lb_kelas = new System.Windows.Forms.Label();
            this.lb_tglahir = new System.Windows.Forms.Label();
            this.lb_tlahir = new System.Windows.Forms.Label();
            this.lb_jk = new System.Windows.Forms.Label();
            this.lb_nisn = new System.Windows.Forms.Label();
            this.lb_nama = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Profile";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(327, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.lb_jurusan);
            this.groupBox1.Controls.Add(this.lb_kelas);
            this.groupBox1.Controls.Add(this.lb_tglahir);
            this.groupBox1.Controls.Add(this.lb_tlahir);
            this.groupBox1.Controls.Add(this.lb_jk);
            this.groupBox1.Controls.Add(this.lb_nisn);
            this.groupBox1.Controls.Add(this.lb_nama);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 310);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Student";
            // 
            // lb_jurusan
            // 
            this.lb_jurusan.AutoSize = true;
            this.lb_jurusan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jurusan.Location = new System.Drawing.Point(118, 269);
            this.lb_jurusan.Name = "lb_jurusan";
            this.lb_jurusan.Size = new System.Drawing.Size(55, 17);
            this.lb_jurusan.TabIndex = 16;
            this.lb_jurusan.Text = "jurusan";
            // 
            // lb_kelas
            // 
            this.lb_kelas.AutoSize = true;
            this.lb_kelas.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_kelas.Location = new System.Drawing.Point(118, 239);
            this.lb_kelas.Name = "lb_kelas";
            this.lb_kelas.Size = new System.Drawing.Size(44, 17);
            this.lb_kelas.TabIndex = 15;
            this.lb_kelas.Text = "kelas";
            // 
            // lb_tglahir
            // 
            this.lb_tglahir.AutoSize = true;
            this.lb_tglahir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tglahir.Location = new System.Drawing.Point(118, 201);
            this.lb_tglahir.Name = "lb_tglahir";
            this.lb_tglahir.Size = new System.Drawing.Size(50, 17);
            this.lb_tglahir.TabIndex = 14;
            this.lb_tglahir.Text = "tglahir";
            // 
            // lb_tlahir
            // 
            this.lb_tlahir.AutoSize = true;
            this.lb_tlahir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tlahir.Location = new System.Drawing.Point(118, 163);
            this.lb_tlahir.Name = "lb_tlahir";
            this.lb_tlahir.Size = new System.Drawing.Size(41, 17);
            this.lb_tlahir.TabIndex = 13;
            this.lb_tlahir.Text = "tlahir";
            // 
            // lb_jk
            // 
            this.lb_jk.AutoSize = true;
            this.lb_jk.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_jk.Location = new System.Drawing.Point(118, 124);
            this.lb_jk.Name = "lb_jk";
            this.lb_jk.Size = new System.Drawing.Size(20, 17);
            this.lb_jk.TabIndex = 12;
            this.lb_jk.Text = "jk";
            // 
            // lb_nisn
            // 
            this.lb_nisn.AutoSize = true;
            this.lb_nisn.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nisn.Location = new System.Drawing.Point(118, 83);
            this.lb_nisn.Name = "lb_nisn";
            this.lb_nisn.Size = new System.Drawing.Size(34, 17);
            this.lb_nisn.TabIndex = 11;
            this.lb_nisn.Text = "nisn";
            // 
            // lb_nama
            // 
            this.lb_nama.AutoSize = true;
            this.lb_nama.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nama.Location = new System.Drawing.Point(118, 44);
            this.lb_nama.Name = "lb_nama";
            this.lb_nama.Size = new System.Drawing.Size(48, 17);
            this.lb_nama.TabIndex = 10;
            this.lb_nama.Text = "nama";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(6, 269);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 9;
            this.label8.Text = "Jurusan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(6, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(6, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tempat Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(6, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(6, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "NISN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nama";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(96, 373);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(203, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Cread by RPL SMKN 1 Kuwus";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 398);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "ProfileForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProfileForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_jurusan;
        private System.Windows.Forms.Label lb_kelas;
        private System.Windows.Forms.Label lb_tglahir;
        private System.Windows.Forms.Label lb_tlahir;
        private System.Windows.Forms.Label lb_jk;
        private System.Windows.Forms.Label lb_nisn;
        private System.Windows.Forms.Label lb_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
    }
}