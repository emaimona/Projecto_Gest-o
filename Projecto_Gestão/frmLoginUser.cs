using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Projecto_Gestão
{
    public partial class frmLoginUser : Form
    {
        gestaoBLL banco = new gestaoBLL();
        method metodo = new method();
        modeloPessoa registoPessoa = new modeloPessoa();

        public frmLoginUser()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            frmSelectPrivilege frm = new frmSelectPrivilege();
            frm.Show();
        }

        private void frmLoginUser_Load(object sender, EventArgs e)
        {
            try
            {
                fotoUser.BackgroundImage = Properties.Resources.photo;
                banco.userList(txtnome);
            }
            catch (Exception ex)
            {
                metodo.desconectado(ex);
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtnome.Text==string.Empty || txtSenha.Text == string.Empty)
                {
                    MessageBox.Show("Campos Vazios.");
                }
                else
                {
                    char retorno = banco.validarSenha(txtnome.Text, txtSenha.Text);
                    if (retorno == 'F')
                    {
                        MessageBox.Show("Errado");

                    }
                    else if (retorno == 'T')
                    {
                        MessageBox.Show("Correcto");
                        ActiveForm.Hide();
                        frmUsuario frm = new frmUsuario(txtnome.Text);
                        frm.Show();
                    }
                }
               
            }
            catch (Exception ex)
            {
                metodo.desconectado(ex);
            }
        }

        private void txtnome_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtnome.Text != "")
            {
               registoPessoa= banco.registoUser(txtnome.Text);

                byte[] img = registoPessoa.Foto;
                if (img == null)
                {
                    fotoUser.BackgroundImage = Properties.Resources.photo;

                }
                else
                {
                    MemoryStream stream = new MemoryStream(img);
                    fotoUser.BackgroundImage = Image.FromStream(stream);
                }

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            timer1.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (txtSenha.Text == "")
            {
                label1.Visible = true;
            }
        }
    }
}
