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
    public partial class frmAdmin : Form
    {
        gestaoBLL banco = new gestaoBLL();
        method metodo = new method();
        modeloPessoa registoPessoa = new modeloPessoa();
        modeloServico[] registoServico = new modeloServico[5];
        modeloTipoServico registoTipoServico = new modeloTipoServico();
        modeloProduto registoProduto = new modeloProduto();
        modeloTempo Tempo = new modeloTempo();
        string moeda = " Kzs";
        string pathFoto, nome;

        //Histórico
        int H = 1;

        void resize(Panel painel, Control conteineir)
        {
            painel.Location = new Point(((conteineir.Size.Width - painel.Size.Width) / 2), ((conteineir.Size.Height - painel.Size.Height) / 2));
        }

        void centerPanel()
        {
            resize(pnlCadastrarProduto, panel1);
            resize(pnlActualizarProduto, panel1);
            resize(pnlConsulta, panel1);
            resize(pnlCadastrarUsuario, panel1);
            resize(pnlActualizarCadastro, panel1);
            resize(pnlResumo, panel1);

        }

        public frmAdmin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Hide();
            frmLoginAdmin frm = new frmLoginAdmin();
            frm.Show();
        }

        private void fotoProduto_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                fotoProduto.BackgroundImage =Image.FromFile(file.FileName);
                pathFoto = file.FileName;
            }
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closePanel();
            cleanPainelProduto();
            pnlCadastrarProduto.Visible = true;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelarPainelP_Click(object sender, EventArgs e)
        {
            closePanel();
        }

        private void cleanPainelProduto()
        {
            pathFoto = "";
            fotoProduto.BackgroundImage = null;

            txtNomeP.Text = "";
            txtPrecoP.Text = "";
            txtStockP.Text = "";
            txtOutroP.Text = "";
        }

        private void btnCadastrarPainelP_Click(object sender, EventArgs e)
        {
            if (txtNomeP.Text==""|txtPrecoP.Text==""|txtStockP.Text=="") {
                MessageBox.Show("Campos não podem estar vazios");
            }
            else
            {
                modeloProduto produto = new modeloProduto();
                if (pathFoto == "")
                {
                    produto.Foto = null;
                }
                else
                {
                    FileStream fstream = new FileStream(pathFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader breader = new BinaryReader(fstream);
                    produto.Foto = breader.ReadBytes((int)fstream.Length);
                }

                produto.Nome = txtNomeP.Text;
                produto.Outros = txtOutroP.Text;
                produto.Stock = txtStockP.Text;
                produto.Valor = txtPrecoP.Text;
                produto.Outros = txtOutroP.Text;
                produto.Total = (Convert.ToInt32(txtStockP.Text) * Convert.ToInt32(txtPrecoP.Text)).ToString();
                banco.cadastrarProduto(produto);
                cleanPainelProduto();
            }
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            closePanel();
            centerPanel();

        }

        private void closePanel()
        {
            pathFoto = "";

            fotoPA.BackgroundImage = null;
            fotoProduto.BackgroundImage = null;
            fotoUser.BackgroundImage = null;
            fotoUserA.BackgroundImage = null;

            pnlResumo.Visible = false;
            pnlCadastrarProduto.Visible = false;
            pnlActualizarProduto.Visible = false;
            pnlConsulta.Visible = false;
            pnlCadastrarUsuario.Visible = false;
            pnlActualizarCadastro.Visible = false;
        }

        private void frmAdmin_Resize(object sender, EventArgs e)
        {
            centerPanel();
        }

        private void produtoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            closePanel();
            cleanPainelProdutoA();
            banco.listarProdutos(cboProdutos);
            pnlActualizarProduto.Visible = true;
        }

        private void cleanPainelProdutoA()
        {
            pathFoto = "";
            fotoPA.BackgroundImage = null;


            cboProdutos.Items.Clear();
            txtStockPA.Text = "";
            txtValorPA.Text="";
            txtOutrosPA.Text = "";
        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            closePanel();
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathFoto = "";
            registoProduto= banco.registoProduto(cboProdutos.Text);
            txtStockPA.Text = registoProduto.Stock;
            txtValorPA.Text = registoProduto.Valor;
            txtOutrosPA.Text = registoProduto.Outros;
            if (registoProduto.Foto == null)
            {
                fotoPA.BackgroundImage = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(registoProduto.Foto);
                fotoPA.BackgroundImage = Image.FromStream(mstream);
            }

        }

        private void btnActualizarP_Click(object sender, EventArgs e)
        {
            modeloProduto produto = new modeloProduto();
            if (cboProdutos.Text == "")
            {
                MessageBox.Show("Selecione um produto");
            }
            else
            {
                if (txtStockPA.Text == "" || txtValorPA.Text == "")
                {
                    MessageBox.Show("Campos não podem estar Vazios");
                }
                else
                {
                   
                    if (pathFoto == "")
                    {
                        produto.Foto = registoProduto.Foto;
                    }
                    else
                    {
                        FileStream fstream = new FileStream(pathFoto, FileMode.Open, FileAccess.Read);
                        BinaryReader breader = new BinaryReader(fstream);
                        produto.Foto = breader.ReadBytes((int)fstream.Length);
                    }
                    produto.Nome = cboProdutos.Text;
                    produto.Outros = txtOutrosPA.Text;
                    produto.Stock = txtStockPA.Text;
                    produto.Valor = txtValorPA.Text;
                    produto.Total= (Convert.ToInt32(txtStockPA.Text) * Convert.ToInt32(txtValorPA.Text)).ToString();

                    banco.actualizarProduto(produto);
                    cleanPainelProdutoA();
                    banco.listarProdutos(cboProdutos);
                }
                
            }
               
        }

        private void fotoPA_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                fotoPA.BackgroundImage = Image.FromFile(file.FileName);
                pathFoto = file.FileName;
            }
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closePanel();
            prencherTabela();
            pnlConsulta.Visible = true;
        }

        private void prencherTabela()
        {
            dgvProduto.DataSource = banco.mostararTabela("select nome as 'Nome do produto',valor as 'Preco Unitario em "+ moeda + "',stock as 'Stock em Unidades',outros 'Obs' from produto order by nome;");
            dgvUsuario.DataSource = banco.mostararTabela("select nome as'Nome completo', senha as 'Senha', sexo as 'Sexo',estadoCivil as'Estado civil',nascimento as'Data de nascimento',numeroBI as 'Numero do BI', morada as 'Morada',email as'E-mail',telefone as'Contacto', nacionalidade as'Pais',naturalidade as'Provincia',dataIngresso as 'Inicio do contrato',outros as 'Informacao adicional' from usuario order by nome;");
            dgvVP.DataSource = banco.mostararTabela("select u.nome Vendedor,p.nome 'Nome do produto',p.valor 'Preco em " + moeda + "',v.quantidade 'Quantidade',v.hora_venda 'Hora',v.data_venda 'Data' ,v.Total 'Total em " + moeda + "' from usuario u join venderproduto v on v.idUsuario=u.idUsuario join produto p on p.idProduto=v.idProduto;");
            dgvSaida.DataSource = banco.mostararTabela("select u.nome 'Usuario', s.valor 'Valor em "+moeda+"', s.data_saida 'Data', s.hora_saida 'Hora', obs 'Obs.' from saida s join usuario u on s.idUsuario=u.idUsuario;");
            dgvServico.DataSource = banco.mostararTabela("select s.nome 'Designacao', t.nome 'Extensao do servico', t.valor 'Valor em " + moeda + "' from servico s join tiposervico t on s.idServico=t.idServico;");
            dgvSP.DataSource = banco.mostararTabela("select s.nome 'Designacao', t.nome 'Extensao do servico', t.valor 'Valor em " + moeda + "' from servico s join tiposervico t on s.idServico=t.idServico;");
            
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closePanel();
            cleanPainelCadUsuario();
            pnlCadastrarUsuario.Visible = true;
        }

        private void cleanPainelCadUsuario()
        {
            pathFoto = "";
            fotoUser.BackgroundImage = null;
            
            txtContactoU.Text = "";
            txtEmailU.Text = "";
            txtMoradaU.Text = "";
            txtNumBIU.Text = "";
            txtNomeU.Text = "";
            txtOutrosU.Text = "";
            txtPaisU.Text = "";
            txtProvinciaU.Text = "";
            txtSenhaU.Text = "";
            
        }

        private void btnFecharPU_Click(object sender, EventArgs e)
        {
            closePanel();
            cleanPainelCadUsuario();
            pnlCadastrarUsuario.Visible = false;
        }

        private void btnCadastrarPU_Click(object sender, EventArgs e)
        {
            
            if (txtSenhaU.Text=="")
            {
                MessageBox.Show("Senha não pode estar vazio!");
            }
            else
            {
               string ret= banco.verificarSenha(txtSenhaU.Text).ToString();
                if (ret == "T")
                {
                    MessageBox.Show("Ja existe um Usuário com esta senha\nPor razões de segurança informe outra senha!");
                }
                else if (ret == "F")
                {
                    modeloPessoa usuario = new modeloPessoa();

                    usuario.BI = txtNumBIU.Text;
                    usuario.Email = txtEmailU.Text;

                    if (rdbCasadoU.Checked)
                    {
                        usuario.Estado_civil = "Casado";
                    }
                    else
                    {
                        usuario.Estado_civil = "Solteiro";
                    }

                    if (rdbMascU.Checked)
                    {
                        usuario.Sexo = "M";
                    }
                    else
                    {
                        usuario.Sexo = "F";
                    }

                    byte[] img = null;
                    if (pathFoto == "")
                    {
                        usuario.Foto = null;
                    }
                    else
                    {
                        FileStream fstream = new FileStream(pathFoto, FileMode.Open, FileAccess.Read);
                        BinaryReader breader = new BinaryReader(fstream);
                        img = breader.ReadBytes((int)fstream.Length);
                        usuario.Foto = img;
                    }

                    usuario.Inicio_contrato = dataInicioU.Value.Year + "/" + dataInicioU.Value.Month + "/" + dataInicioU.Value.Day;
                    usuario.Nascimento = dataNascimentoU.Value.Year + "/" + dataNascimentoU.Value.Month + "/" + dataNascimentoU.Value.Day;

                    usuario.Morada = txtMoradaU.Text;
                    usuario.Nacionalidade = txtPaisU.Text;
                    usuario.Naturalidade = txtProvinciaU.Text;
                    usuario.Nome = txtNomeU.Text;
                    usuario.Outros = txtOutrosU.Text;
                    usuario.Senha = txtSenhaU.Text;
                    usuario.Telefone = txtContactoU.Text;
                    
                    banco.cadastrarUsuario(usuario);
                    cleanPainelCadUsuario();
                }

            }

        }

        private void fotoUser_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                fotoUser.BackgroundImage = Image.FromFile(file.FileName);
                pathFoto = file.FileName;
            }
        }

        private void usuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cleanPainelCadUsuarioA();
            closePanel();

            banco.listarUsuarios(cboNomeUserA);

            pnlActualizarCadastro.Visible = true;
        }

        private void cleanPainelCadUsuarioA()
        {
            pathFoto = "";
            fotoUserA.BackgroundImage = null;

            txtSenhaUA.Text = "";
            txtProvinciaUA.Text = "";
            txtPaisUA.Text = "";
            txtOutrosUA.Text = "";
            txtNumeroBiUA.Text = "";
            txtMoradaUA.Text = "";
            txtEmailUA.Text = "";
            txtContactoUA.Text = "";
            cboNomeUserA.Items.Clear();
        }

        private void fotoUserA_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                fotoUserA.BackgroundImage = Image.FromFile(file.FileName);
                pathFoto = file.FileName;
            }
        }

        private void cboNomeUserA_SelectedIndexChanged(object sender, EventArgs e)
        {
            pathFoto = "";
            registoPessoa = banco.registoUser(cboNomeUserA.Text);

            txtSenhaUA.Text = registoPessoa.Senha;
            txtProvinciaUA.Text = registoPessoa.Naturalidade;
            txtPaisUA.Text = registoPessoa.Nacionalidade;
            txtOutrosUA.Text = registoPessoa.Outros;
            txtNumeroBiUA.Text = registoPessoa.BI;
            txtMoradaUA.Text = registoPessoa.Morada;
            txtEmailUA.Text = registoPessoa.Email;
            txtContactoUA.Text = registoPessoa.Telefone;

            if (registoPessoa.Estado_civil == "Casado")
            {
                rdbCasadoA.Checked=true;
            }
            else
            {
                rdbSolteiroA.Checked = true;
            }

            if (registoPessoa.Sexo == "M")
            {
                rdbMascUA.Checked = true;
            }
            else
            {
                rdbFemUA.Checked = true;
            }


            dataContratoUA.Value =DateTime.Parse(registoPessoa.Inicio_contrato);
            dataNascimentoUA.Value =DateTime.Parse(registoPessoa.Nascimento);

            if (registoPessoa.Foto == null)
            {
                fotoUserA.BackgroundImage = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(registoPessoa.Foto);
                fotoUserA.BackgroundImage = Image.FromStream(mstream);
            }
        }

        private void btnFecharCadastro_Click(object sender, EventArgs e)
        {
            closePanel();
            cleanPainelCadUsuario();
            pnlActualizarCadastro.Visible = false;
        }

        private void btnActualizarCasdatro_Click(object sender, EventArgs e)
        {
            if (cboNomeUserA.Text == "")
            {
                MessageBox.Show("Selecione um usuário");
            }
            else
            {
                modeloPessoa usuario = new modeloPessoa();

                usuario.BI = txtNumeroBiUA.Text;
                usuario.Email = txtEmailUA.Text;

                if (rdbCasadoA.Checked)
                {
                    usuario.Estado_civil = "Casado";
                }
                else
                {
                    usuario.Estado_civil = "Solteiro";
                }

                if (rdbMascUA.Checked)
                {
                    usuario.Sexo = "M";
                }
                else
                {
                    usuario.Sexo = "F";
                }

                byte[] img = null;
                if (pathFoto == "")
                {
                    usuario.Foto = registoPessoa.Foto;
                }
                else
                {
                    FileStream fstream = new FileStream(pathFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader breader = new BinaryReader(fstream);
                    img = breader.ReadBytes((int)fstream.Length);
                    usuario.Foto = img;
                }

                usuario.Inicio_contrato = dataContratoUA.Value.Year + "/" + dataContratoUA.Value.Month + "/" + dataContratoUA.Value.Day;
                usuario.Nascimento = dataNascimentoUA.Value.Year + "/" + dataNascimentoUA.Value.Month + "/" + dataNascimentoUA.Value.Day;

                usuario.Morada = txtMoradaUA.Text;
                usuario.Nacionalidade = txtPaisUA.Text;
                usuario.Naturalidade = txtProvinciaUA.Text;
                usuario.Nome = cboNomeUserA.Text;
                usuario.Outros = txtOutrosUA.Text;
                usuario.Senha = txtSenhaUA.Text;
                usuario.Telefone = txtContactoUA.Text;

                banco.actualizarUsuario(usuario);
                cleanPainelCadUsuarioA();
                banco.listarUsuarios(cboNomeUserA);
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tempo.Date = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            Tempo.Dia = DateTime.Now.Day.ToString();
            Tempo.Mes = DateTime.Now.Month.ToString();
            Tempo.Ano = DateTime.Now.Year.ToString();
            Tempo.Hora = DateTime.Now.Hour.ToString();
            Tempo.Minuto= DateTime.Now.Minute.ToString();
            Tempo.Segundos = DateTime.Now.Second.ToString();
            Tempo.Time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            cleanPainelResumo();
            closePanel();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

        }

        private void diaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H = 1;

            closePanel();
            cleanPainelResumo();
            pnlResumo.Visible = true;
        }

        private void cleanPainelResumo()
        {
            lstProdutos.Items.Clear();
            lstSaidas.Items.Clear();
            lstVendas.Items.Clear();
            lstServiços.Items.Clear();

            lblEntradas.Text = "Entradas: 0 Kzs";
            lblSaidas.Text = "Saidas: 0 Kzs";
            lblTotal.Text = "Total: 0 Kzs";
        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {
            cleanPainelResumo();
            modeloTempo timer = new modeloTempo();
            timer.Ano = dataResumo.Value.Year.ToString();
            timer.Mes = dataResumo.Value.Month.ToString();
            timer.Dia = dataResumo.Value.Day.ToString();
            timer.Date = dataResumo.Value.Year + "/" + dataResumo.Value.Month + "/" + dataResumo.Value.Day;

            try
            {
                if (H == 1)
                {
                    string data = dataResumo.Value.Year + "/" + dataResumo.Value.Month + "/" + dataResumo.Value.Day;

                    banco.resumoDia(lstVendas, lstProdutos, lstServiços, lstSaidas, data, lblEntradas, lblSaidas, lblTotal);
                }
                else if (H == 2)
                {
                    banco.resumoMes(lstVendas, lstProdutos, lstServiços, lstSaidas, lblEntradas, lblSaidas, lblTotal,timer);
                }
                else if (H == 3)
                {
                    string data = dataResumo.Value.Year + "/" + dataResumo.Value.Month + "/" + dataResumo.Value.Day;

                    banco.resumoAno(lstVendas, lstProdutos, lstServiços, lstSaidas,lblEntradas, lblSaidas, lblTotal,timer);
                }
                
            }

            catch (Exception)
            {

            }
        }

        private void mêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H = 2;

            closePanel();
            cleanPainelResumo();
            pnlResumo.Visible = true;
        }

        private void anoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            H = 3;

            closePanel();
            cleanPainelResumo();
            pnlResumo.Visible = true;
        }
        
    }
}
