using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class StudentForm : Form
    {
        StudentEntitiesOne context = new StudentEntitiesOne();
        TbStudent tbstudent = new TbStudent();
        public static int studentID = 0;
        public StudentForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Anda yakin ingin tutup aplikasi","Student App", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==
                                DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void addStudent ()
        {
            tbstudent.nins = tb_nisn.Text;
            tbstudent.nama = tb_nama.Text;
            tbstudent.jk = tb_jk.Text;
            tbstudent.tempat_lahir = tb_tl.Text;
            tbstudent.tanggal_lahir = dt_tl.Value;
            tbstudent.kelas = cb_kelas.Text;
            tbstudent.jurusan = cb_jurusan.Text;

            if (studentID > 0)
            {
                /*Kondisi saat update data student lama*/
                context.Entry(tbstudent).State = System.Data.Entity.EntityState.Modified;
                MessageBox.Show("Success update data ..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                /*Kondisi saat Simpan data student baru*/
                context.TbStudent.Add(tbstudent);
                MessageBox.Show("Success save data..", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            context.SaveChanges();
            this.showData();
            this.clearForm();
        }

        private void clearForm()
        {
            tb_nisn.Clear(); tb_nama.Clear(); tb_jk.Text = ""; tb_tl.Clear();
            cb_jurusan.Text = "";
            cb_kelas.Text = "";
            dt_tl.Value = DateTime.Now;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            /* chekForm*/
            if ((tb_nisn.Text == "") || (tb_nama.Text == "") || (tb_jk.Text == "") ||
               (tb_tl.Text == "") || (dt_tl.Text == Convert.ToString(DateTime.Now)) ||
               (cb_jurusan.Text == "") || (cb_kelas.Text == ""))
            {
                MessageBox.Show("Ada data yang kosong! Silahkan Cek kembali", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.addStudent();

        }

        private void showData()
        {
            dt_student.DataSource = context.TbStudent.ToList();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.showData();

        }

        private void dt_student_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dt_student.CurrentCell.RowIndex != -1)
            {
                studentID = Convert.ToInt16(dt_student.CurrentRow.Cells["id"].Value);
                tbstudent = context.TbStudent.Where(x => x.id == studentID).FirstOrDefault();
                tb_nisn.Text = tbstudent.nins;
                tb_nama.Text = tbstudent.nama;
                tb_jk.Text = tbstudent.jk;
                tb_tl.Text = tbstudent.tempat_lahir;
                dt_tl.Value = Convert.ToDateTime(tbstudent.tanggal_lahir);
                cb_kelas.Text = tbstudent.kelas;
                cb_jurusan.Text = tbstudent.jurusan;
            }
           
            if (dt_student.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            {
                /* Button Show Aksi */
                if (dt_student.CurrentCell != null && dt_student.CurrentCell.Value != null)
                //MessageBox.Show(dt_student.CurrentCell.Value.ToString());
                { ProfileForm pf = new ProfileForm();
                    pf.Show();
                    this.Hide();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            studentID = 0;
            this.clearForm();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentID = 0;
            clearForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /* chekForm*/
            if ((tb_nisn.Text == "") || (tb_nama.Text == "") || (tb_jk.Text == "") ||
               (tb_tl.Text == "") || (dt_tl.Text == Convert.ToString(DateTime.Now)) ||
               (cb_jurusan.Text == "") || (cb_kelas.Text == ""))
            {
                MessageBox.Show("Ada data yang kosong! Silahkan Cek kembali", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }      

            if (MessageBox.Show("Anda yakin untuk hapus data ini?","Delete Data",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
            {
                context.TbStudent.Remove(tbstudent);
                context.SaveChanges();
                clearForm();
                showData();
                MessageBox.Show("Success delete data", "Delete Success", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchData (string textName)
        {
            var query = context.TbStudent.Where(x => x.nama.StartsWith(textName)).ToList();
            dt_student.DataSource = query;

            studentID = Convert.ToInt16(dt_student.CurrentRow.Cells["id"].Value);
            tbstudent = context.TbStudent.Where(x => x.id == studentID).FirstOrDefault();
            tb_nisn.Text = tbstudent.nins;
            tb_nama.Text = tbstudent.nama;
            tb_jk.Text = tbstudent.jk;
            tb_tl.Text = tbstudent.tempat_lahir;
            dt_tl.Value = Convert.ToDateTime(tbstudent.tanggal_lahir);
            cb_kelas.Text = tbstudent.kelas;
            cb_jurusan.Text = tbstudent.jurusan;
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            this.searchData(textSearch.Text);
        }

        private void checkForm ()
        {
           
        }
    }
}
