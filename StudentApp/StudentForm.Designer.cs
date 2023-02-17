namespace StudentApp
{
    partial class StudentForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.textSearch = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cb_jurusan = new System.Windows.Forms.ComboBox();
            this.cb_kelas = new System.Windows.Forms.ComboBox();
            this.tb_tl = new System.Windows.Forms.TextBox();
            this.tb_nama = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_tl = new System.Windows.Forms.DateTimePicker();
            this.tb_nisn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_student = new System.Windows.Forms.DataGridView();
            this.tb_jk = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.tbStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ninsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatlahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tanggallahirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kelasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jurusanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aksi = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.AksiDua = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_student)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(706, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(315, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "STUDENT APP";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textSearch);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cb_jurusan);
            this.panel1.Controls.Add(this.cb_kelas);
            this.panel1.Controls.Add(this.tb_tl);
            this.panel1.Controls.Add(this.tb_nama);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dt_tl);
            this.panel1.Controls.Add(this.tb_nisn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dt_student);
            this.panel1.Controls.Add(this.tb_jk);
            this.panel1.Location = new System.Drawing.Point(12, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 419);
            this.panel1.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(449, 209);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Cari Data";
            // 
            // textSearch
            // 
            this.textSearch.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textSearch.Location = new System.Drawing.Point(528, 206);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(208, 24);
            this.textSearch.TabIndex = 24;
            this.textSearch.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.IndianRed;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(652, 124);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 39);
            this.button4.TabIndex = 23;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Goldenrod;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(570, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 39);
            this.button3.TabIndex = 22;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(406, 124);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 39);
            this.button2.TabIndex = 8;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cb_jurusan
            // 
            this.cb_jurusan.FormattingEnabled = true;
            this.cb_jurusan.Items.AddRange(new object[] {
            "ATPH",
            "ATR",
            "APAT",
            "RPL"});
            this.cb_jurusan.Location = new System.Drawing.Point(528, 80);
            this.cb_jurusan.Name = "cb_jurusan";
            this.cb_jurusan.Size = new System.Drawing.Size(200, 25);
            this.cb_jurusan.TabIndex = 21;
            // 
            // cb_kelas
            // 
            this.cb_kelas.FormattingEnabled = true;
            this.cb_kelas.Items.AddRange(new object[] {
            "X",
            "XI",
            "XII"});
            this.cb_kelas.Location = new System.Drawing.Point(528, 48);
            this.cb_kelas.Name = "cb_kelas";
            this.cb_kelas.Size = new System.Drawing.Size(200, 25);
            this.cb_kelas.TabIndex = 20;
            // 
            // tb_tl
            // 
            this.tb_tl.Location = new System.Drawing.Point(124, 106);
            this.tb_tl.Name = "tb_tl";
            this.tb_tl.Size = new System.Drawing.Size(202, 24);
            this.tb_tl.TabIndex = 19;
            // 
            // tb_nama
            // 
            this.tb_nama.Location = new System.Drawing.Point(124, 42);
            this.tb_nama.Name = "tb_nama";
            this.tb_nama.Size = new System.Drawing.Size(202, 24);
            this.tb_nama.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(406, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "Jurusan";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Kelas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tanggal Lahir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 14;
            this.label5.Text = "Tempat Lahir";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "Jenis Kelamin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nama";
            // 
            // dt_tl
            // 
            this.dt_tl.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dt_tl.Location = new System.Drawing.Point(528, 15);
            this.dt_tl.Name = "dt_tl";
            this.dt_tl.Size = new System.Drawing.Size(200, 24);
            this.dt_tl.TabIndex = 9;
            // 
            // tb_nisn
            // 
            this.tb_nisn.Location = new System.Drawing.Point(124, 10);
            this.tb_nisn.Name = "tb_nisn";
            this.tb_nisn.Size = new System.Drawing.Size(202, 24);
            this.tb_nisn.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "NISN";
            // 
            // dt_student
            // 
            this.dt_student.AutoGenerateColumns = false;
            this.dt_student.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt_student.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ninsDataGridViewTextBoxColumn,
            this.namaDataGridViewTextBoxColumn,
            this.jkDataGridViewTextBoxColumn,
            this.tempatlahirDataGridViewTextBoxColumn,
            this.tanggallahirDataGridViewTextBoxColumn,
            this.kelasDataGridViewTextBoxColumn,
            this.jurusanDataGridViewTextBoxColumn,
            this.aksi,
            this.AksiDua});
            this.dt_student.DataSource = this.tbStudentBindingSource;
            this.dt_student.Location = new System.Drawing.Point(14, 236);
            this.dt_student.Name = "dt_student";
            this.dt_student.RowTemplate.Height = 40;
            this.dt_student.Size = new System.Drawing.Size(722, 171);
            this.dt_student.TabIndex = 10;
            this.dt_student.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dt_student_CellClick);
            // 
            // tb_jk
            // 
            this.tb_jk.FormattingEnabled = true;
            this.tb_jk.Items.AddRange(new object[] {
            "Laki-Laki",
            "Perempuan"});
            this.tb_jk.Location = new System.Drawing.Point(124, 73);
            this.tb_jk.Name = "tb_jk";
            this.tb_jk.Size = new System.Drawing.Size(202, 25);
            this.tb_jk.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(488, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(76, 39);
            this.button5.TabIndex = 26;
            this.button5.Text = "Add";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // tbStudentBindingSource
            // 
            this.tbStudentBindingSource.DataSource = typeof(StudentApp.TbStudent);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // ninsDataGridViewTextBoxColumn
            // 
            this.ninsDataGridViewTextBoxColumn.DataPropertyName = "nins";
            this.ninsDataGridViewTextBoxColumn.HeaderText = "NISN";
            this.ninsDataGridViewTextBoxColumn.Name = "ninsDataGridViewTextBoxColumn";
            // 
            // namaDataGridViewTextBoxColumn
            // 
            this.namaDataGridViewTextBoxColumn.DataPropertyName = "nama";
            this.namaDataGridViewTextBoxColumn.HeaderText = "NAMA";
            this.namaDataGridViewTextBoxColumn.Name = "namaDataGridViewTextBoxColumn";
            // 
            // jkDataGridViewTextBoxColumn
            // 
            this.jkDataGridViewTextBoxColumn.DataPropertyName = "jk";
            this.jkDataGridViewTextBoxColumn.HeaderText = "JENIS KELAMIN";
            this.jkDataGridViewTextBoxColumn.Name = "jkDataGridViewTextBoxColumn";
            // 
            // tempatlahirDataGridViewTextBoxColumn
            // 
            this.tempatlahirDataGridViewTextBoxColumn.DataPropertyName = "tempat_lahir";
            this.tempatlahirDataGridViewTextBoxColumn.HeaderText = "TEMPAT LAHIR";
            this.tempatlahirDataGridViewTextBoxColumn.Name = "tempatlahirDataGridViewTextBoxColumn";
            // 
            // tanggallahirDataGridViewTextBoxColumn
            // 
            this.tanggallahirDataGridViewTextBoxColumn.DataPropertyName = "tanggal_lahir";
            this.tanggallahirDataGridViewTextBoxColumn.HeaderText = "TANGGAL LAHIR";
            this.tanggallahirDataGridViewTextBoxColumn.Name = "tanggallahirDataGridViewTextBoxColumn";
            // 
            // kelasDataGridViewTextBoxColumn
            // 
            this.kelasDataGridViewTextBoxColumn.DataPropertyName = "kelas";
            this.kelasDataGridViewTextBoxColumn.HeaderText = "KELAS";
            this.kelasDataGridViewTextBoxColumn.Name = "kelasDataGridViewTextBoxColumn";
            // 
            // jurusanDataGridViewTextBoxColumn
            // 
            this.jurusanDataGridViewTextBoxColumn.DataPropertyName = "jurusan";
            this.jurusanDataGridViewTextBoxColumn.HeaderText = "JUURSAN";
            this.jurusanDataGridViewTextBoxColumn.Name = "jurusanDataGridViewTextBoxColumn";
            // 
            // aksi
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle1.NullValue = false;
            this.aksi.DefaultCellStyle = dataGridViewCellStyle1;
            this.aksi.HeaderText = "AKSI";
            this.aksi.Name = "aksi";
            this.aksi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.aksi.Width = 60;
            // 
            // AksiDua
            // 
            this.AksiDua.HeaderText = "Aksi Dua";
            this.AksiDua.Name = "AksiDua";
            this.AksiDua.Text = "Show";
            this.AksiDua.ToolTipText = "Show";
            this.AksiDua.UseColumnTextForButtonValue = true;
            this.AksiDua.Width = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 537);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt_student)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStudentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cb_jurusan;
        private System.Windows.Forms.ComboBox cb_kelas;
        private System.Windows.Forms.TextBox tb_tl;
        private System.Windows.Forms.TextBox tb_nama;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dt_tl;
        private System.Windows.Forms.TextBox tb_nisn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox tb_jk;
        private System.Windows.Forms.BindingSource tbStudentBindingSource;
        private System.Windows.Forms.DataGridView dt_student;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ninsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatlahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tanggallahirDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kelasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jurusanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aksi;
        private System.Windows.Forms.DataGridViewButtonColumn AksiDua;
    }
}

