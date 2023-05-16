using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        public static Teacher LoggedTeacher
        {
            get; set;
        }

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoggedTeacher = TeacherRepository.GetTeacher(txtUsername.Text);
            if(LoggedTeacher != null && LoggedTeacher.CheckPassword(txtPassword.Text))
            {
                FrmStudents frmStudents = new FrmStudents();
                Hide();
                frmStudents.ShowDialog();
                Close();
            }
            else
            {

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
