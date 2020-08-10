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
    public partial class frmUsuario : Form
    {
        gestaoBLL banco = new gestaoBLL();
        method metodo = new method();
        modeloPessoa registoPessoa = new modeloPessoa();
        modeloServico registoServico = new modeloServico();
        modeloTipoServico registoTipoServico = new modeloTipoServico();
        modeloProduto registoProduto = new modeloProduto();
        modelo_Saida_Entrada registoSaida = new modelo_Saida_Entrada();
        modelo_Saida_Entrada registoEntrada = new modelo_Saida_Entrada();
        modeloTempo Tempo = new modeloTempo();
        string moeda = " Kz",nome;

        void resize(Panel painel, Control conteineir)
        {
            painel.Location = new Point(((conteineir.Size.Width - painel.Size.Width) / 2), ((conteineir.Size.Height - painel.Size.Height) / 2));
        }

        void centerPanel()
        {
            resize(pnlProduto, panel1);
           // resize(pnlUser, panel1);
            resize(pnlSaidas, panel1);
            resize(pnlServico, panel1);
            resize(pnlEntradas, panel1);
        }

        public frmUsuario(string name)
        {
            nome = name;
            InitializeComponent();
           
        }

        private void closePanel()
        {
            pnlProduto.Visible = false;
            pnlUser.Visible = false;
            pnlSaidas.Visible = false;
            pnlEntradas.Visible = false;
            pnlServico.Visible = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            closePanel();
            centerPanel();

            

            try
            {
                banco.listarProdutos(produtoToolStripMenuItem, eventoProduto_Click);
                banco.listarServicos(servicoToolStripMenuItem, eventoServico_Click);

              registoPessoa= banco.registoUser(nome);
              lblnome.Text = registoPessoa.Nome;
                if (registoPessoa.Foto == null)
                {
                    fotoUser.BackgroundImage = Properties.Resources.photo;
                }
                else
                {
                    MemoryStream mstream = new MemoryStream(registoPessoa.Foto);
                    fotoUser.BackgroundImage = Image.FromStream(mstream);
                }
               
            }
            catch (Exception ex)
            {
                metodo.desconectado(ex);                
            }
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

            pnlProduto.Visible = false;
            cleanPainelProduto();
        }

        private void cleanPainelProduto()
        {
            txtQuantidade.Value=1;
            txtValor.Text="";
            lblTroco.Visible = false;
            btnContinuarPainelP.Visible = false;
            btnFecharPainelP.Visible = false;
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            actualizarProduto(registoProduto.Nome);
            int quantidade = (int)txtQuantidade.Value;
            int total = quantidade * int.Parse(registoProduto.Valor);
            int stock = Convert.ToInt32(banco.stockProduto(registoProduto.Nome));
            if (Convert.ToInt32(txtValor.Text) < total)
            {
                actualizarProduto(registoProduto.Nome);
                MessageBox.Show("O valor introduzido é inválido!\nO valor deve ser maior ou igual a "+total+moeda);
            }
            else
            {
                if (quantidade > stock)
                {
                    actualizarProduto(registoProduto.Nome);
                    MessageBox.Show("Lamentamos mais o stock é insuficiente!\nStock= "+stock+" unidades.");
                }
                else
                {
                    int actStock = stock - quantidade;
                    try
                    {
                        banco.venderProduto(registoProduto.Nome, actStock.ToString());
                        banco.venderProduto(registoProduto.IdProduto,registoPessoa.Id,quantidade.ToString(),Tempo.Date,Tempo.Hora,total.ToString());

                        lblTroco.Text = "Troco:   " + (Convert.ToInt32(txtValor.Text) - total) + moeda;

                        lblTroco.Visible = true;
                        btnContinuarPainelP.Visible = true;
                        btnFecharPainelP.Visible = true;

                        txtQuantidade.Enabled = false;
                        txtValor.Enabled = false;
                        btnValidarP.Visible = false;
                        btnCancelarP.Visible = false;
                    }
                    catch (Exception)
                    {

                    }
                    
                }
                
            }
           
        }

        private void btnCancelarP_Click(object sender, EventArgs e)
        {
            pnlProduto.Visible = false;
            cleanPainelProduto();
        }

        private void abrirPainelProduto(string nomeProduto)
        {
            closePanel();

            cleanPainelProduto();
            actualizarProduto(nomeProduto);

            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;

            btnValidarP.Visible = true;
            btnCancelarP.Visible = true;
            pnlProduto.Visible = true;

            lblTroco.Visible = false;
            btnContinuarPainelP.Visible = false;
            btnFecharPainelP.Visible = false;
        }

        private void actualizarProduto(string nomeProduto)
        {
            registoProduto = banco.registoProduto(nomeProduto);
            lblProduto.Text = "Nome: " + registoProduto.Nome;
            lblPreco.Text = "Preço: " + registoProduto.Valor + moeda;

            if (Convert.ToInt32(registoProduto.Stock) <=10) {
                lblStock.ForeColor = Color.Red;
            }
            else
            {
                lblStock.ForeColor = Color.Green;
            }
            lblStock.Text = "Stock: " + registoProduto.Stock+" unid.";

            if (registoProduto.Foto == null)
            {
                fotoProduto.BackgroundImage = null;
            }
            else
            {
                MemoryStream mstream = new MemoryStream(registoProduto.Foto);
                fotoProduto.BackgroundImage = Image.FromStream(mstream);
            }
        }

        private void btnContinuarPainelP_Click(object sender, EventArgs e)
        {
            actualizarProduto(registoProduto.Nome);

            txtQuantidade.Enabled = true;
            txtValor.Enabled = true;

            btnValidarP.Visible = true;
            btnCancelarP.Visible = true;
            cleanPainelProduto();
        }
               
         void eventoProduto_Click(object sender, EventArgs e)
        {
            abrirPainelProduto((sender as ToolStripMenuItem).Text);
        }
         void eventoServico_Click(object sender, EventArgs e)
         {
             abrirPainelServico((sender as ToolStripMenuItem).Text);
         }

         private void abrirPainelServico(string servico)
         {
             closePanel();

             cleanPainelServico();
             registoServico.Nome = servico;

             banco.listarServico(cboServico, registoServico.Nome);
                       
             pnlServico.Visible = true;

         }

         private void cleanPainelServico()
         {
             cboServico.Items.Clear();

             txtQuantidadeServico.Value = 1;
             txtValorServico.Text = "";
             lblPrecoServico.Text = "Preço: ";

             btnValidarS.Visible = true;
             btnCancelarS.Visible = true;

             lblTrocoServico.Visible = false;
             btnFecharS.Visible = false;
             btnContinuarS.Visible = false;

             btnValidarS.Visible = true;
             btnCancelarS.Visible = true;
             txtQuantidadeServico.Enabled = true;
             txtValorServico.Enabled = true;
             cboServico.Enabled = true;
             
         }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmLoginUser frm = new frmLoginUser();
            frm.Show();
        }

        private void fotoUser_Click(object sender, EventArgs e)
        {
            if (pnlUser.Visible == true)
            {
                pnlUser.Visible =false;
            }
            else
            {
                pnlUser.Visible = true;
                fotoUserA.Image = fotoUser.BackgroundImage;
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
            pnlUser.Visible = false;
        }

        private void frmUsuario_Resize(object sender, EventArgs e)
        {
            centerPanel();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Tempo.Date = DateTime.Now.Year + "/" + DateTime.Now.Month + "/" + DateTime.Now.Day;
            Tempo.Dia = DateTime.Now.Day.ToString();
            Tempo.Mes = DateTime.Now.Month.ToString();
            Tempo.Ano = DateTime.Now.Year.ToString();
            Tempo.Hora = DateTime.Now.Hour.ToString();
            Tempo.Minuto = DateTime.Now.Minute.ToString();
            Tempo.Segundos = DateTime.Now.Second.ToString();
            Tempo.Time = DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
        }

        private void saidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closePanel();

            cleanPainelSaida();
            pnlSaidas.Visible = true;
        }

        private void cleanPainelSaida()
        {
            txtOutrosSaida.Text="";
            txtValorSaida.Text="";
        }

        private void bunifuThinButton23_Click_1(object sender, EventArgs e)
        {
            try
            {
                registoSaida.Data = Tempo.Date;
                registoSaida.Hora = Tempo.Time;
                registoSaida.IdUsuario = registoPessoa.Id;
                registoSaida.Outros = txtOutrosSaida.Text;
                registoSaida.Valor = txtValorSaida.Text;
                banco.registarSaida(registoSaida);

                cleanPainelSaida();
            }
            catch (Exception)
            {
                                
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            cleanPainelSaida();
            closePanel();
        }

        private void cboServico_SelectedIndexChanged(object sender, EventArgs e)
        {
            registoTipoServico = banco.registoTipoServico(registoServico.Nome,cboServico.Text);
            lblPrecoServico.Text = "Preço: " + registoTipoServico.Valor + moeda;

        }

        private void btnCancelarS_Click(object sender, EventArgs e)
        {
            closePanel();
            cleanPainelServico();
        }

        private void btnValidarS_Click(object sender, EventArgs e)
        {
                       
            int quantidade = (int)txtQuantidadeServico.Value;
            int total = quantidade * int.Parse(registoTipoServico.Valor);
            
            if (Convert.ToInt32(txtValorServico.Text) < total)
            {
               
                MessageBox.Show("O valor introduzido é inválido!\nO valor deve ser maior ou igual a " + total + moeda);
            }
            else
            {
                    
                    try
                    {

                        banco.prestarServico(registoTipoServico.IdServico, registoPessoa.Id, quantidade.ToString(), Tempo.Date, Tempo.Time, total.ToString());

                        lblTrocoServico.Text = "Troco:   " + (Convert.ToInt32(txtValorServico.Text) - total) + moeda;

                        lblTrocoServico.Visible = true;
                        btnContinuarS.Visible = true;
                        btnFecharS.Visible = true;

                        txtQuantidadeServico.Enabled = false;
                        txtValorServico.Enabled = false;
                        btnValidarS.Visible = false;
                        btnCancelarS.Visible = false;
                        cboServico.Enabled = false;
                    }
                    catch (Exception)
                    {

                    }
                
            }
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                registoEntrada.Data =  Tempo.Date;
                registoEntrada.Hora = Tempo.Time;
                registoEntrada.IdUsuario = registoPessoa.Id;
                registoEntrada.Outros = txtOutrosE.Text;
                registoEntrada.Valor = txtValorE.Text;
                banco.registarEntrada(registoEntrada);

                cleanPainelEntrada();
            }
            catch (Exception)
            {
                                
            }
        }

        private void cleanPainelEntrada()
        {
 	        txtOutrosE.Text="";
            txtValorE.Text="";
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            cleanPainelSaida();
            closePanel();
        }

        private void entradasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            closePanel();

            cleanPainelEntrada();
            pnlEntradas.Visible = true;
        }

        private void btnContinuarS_Click(object sender, EventArgs e)
        {
            cleanPainelServico();
            banco.listarServico(cboServico, registoServico.Nome);

        }

        private void btnFecharS_Click(object sender, EventArgs e)
        {
            cleanPainelServico();
            closePanel();
        }
        }
    }

