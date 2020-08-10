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
    public partial class frmLoginAdmin : Form
    {
        gestaoBLL banco = new gestaoBLL();
        method metodo = new method();
        modeloPessoa registoPessoa = new modeloPessoa();
        public frmLoginAdmin()
        {
            InitializeComponent();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            ActiveForm.Hide();
            frmSelectPrivilege frm = new frmSelectPrivilege();
            frm.Show();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSenha.Text == string.Empty)
                {
                    MessageBox.Show("Campo Vazio.");
                }
                else
                {
                    char retorno = banco.validarSenha(txtSenha.Text);
                    if (retorno == 'F')
                    {
                        MessageBox.Show("Errado");

                    }
                    else if (retorno == 'T')
                    {
                        MessageBox.Show("Correcto");
                        ActiveForm.Hide();
                        frmAdmin frm = new frmAdmin();
                        frm.Show();
                    }
                }
            }
            catch (Exception ex)
            {
                metodo.desconectado(ex);
            }
        }

        private void frmLoginAdmin_Load(object sender, EventArgs e)
        {
            
            try
            {
                registoPessoa= banco.registoAdmin();
                lblnome.Text = registoPessoa.Nome;
                byte[] img = registoPessoa.Foto;

                if (img == null)
                {
                    fotoAdmin.BackgroundImage = Properties.Resources.photo;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(img);
                    
                   // BinaryReader breader = new BinaryReader(mstream);

                    fotoAdmin.BackgroundImage = Image.FromStream(mstream);
                }

            }
            catch (Exception ex)
            {
                metodo.desconectado(ex);

            }
        }

        private void lblnome_Click(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {

        }
    }
}
