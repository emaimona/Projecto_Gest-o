using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projecto_Gestão
{
    public partial class frmSelectPrivilege : Form
    {
        public frmSelectPrivilege()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            frmLoginAdmin frm = new frmLoginAdmin();
            frm.Show();
            
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            frmLoginUser frm = new frmLoginUser();
            frm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            b1.BorderColor = btnAdmin.BackColor;
            b2.BorderColor = btnUser.BackColor;
        }
    }
}
