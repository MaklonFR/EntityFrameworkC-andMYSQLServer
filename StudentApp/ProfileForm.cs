using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class ProfileForm : Form
    {
        StudentEntitiesOne context = new StudentEntitiesOne();
        TbStudent tbstudent = new TbStudent();
        public ProfileForm()
        {
            InitializeComponent();
        }

        private void showProfile ()
        {
            int id = StudentForm.studentID;
            tbstudent = context.TbStudent.Where(x => x.id == id).FirstOrDefault();
            lb_nisn.Text = tbstudent.nins;
            lb_nama.Text = tbstudent.nama;
            lb_jk.Text = tbstudent.jk;
            lb_tlahir.Text = tbstudent.tempat_lahir;
            lb_tglahir.Text = Convert.ToString(tbstudent.tanggal_lahir); 
            lb_kelas.Text = tbstudent.kelas;
            lb_jurusan.Text = tbstudent.jurusan;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            StudentForm sf = new StudentForm();
            sf.Show();
            this.Close();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            this.showProfile();
        }
    }
}
