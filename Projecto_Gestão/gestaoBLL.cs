using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
namespace Projecto_Gestão
{
    public class gestaoBLL
    {
       
        gestaoDAL bancoDal = new gestaoDAL();

        public modeloTipoServico registoTipoServico(string servico, string extensao)
        {
            return bancoDal.registoTipoServicoDAL(servico, extensao);
        }
        public void listarServico(ComboBox cbo, string servico)
        {
            bancoDal.listarServicoDAL(cbo, servico);
        }
        public void listarServicos(ToolStripMenuItem Tmenu, EventHandler evento)
        {
            bancoDal.listarServicoDAL(Tmenu, evento);
        }
        public void listarProdutos(ToolStripMenuItem Tmenu, EventHandler evento)
        {
            bancoDal.listarProdutoDAL(Tmenu,evento);
        }
        public void resumoDia(ListBox vendedor, ListBox produto, ListBox servico, ListBox saida, string data, Label lblEntrada, Label lblSaida, Label lblTotal)
        {
            bancoDal.resumoDiaDAl(vendedor,produto,servico,saida,data,lblEntrada,lblSaida,lblTotal);
        }
        public void resumoMes(ListBox vendedor, ListBox produto, ListBox servico, ListBox saida, Label lblEntrada, Label lblSaida, Label lblTotal, modeloTempo tempo)
        {
            bancoDal.resumoMesDAl(vendedor, produto, servico, saida,lblEntrada, lblSaida, lblTotal,tempo);
        }
        public void resumoAno(ListBox vendedor, ListBox produto, ListBox servico, ListBox saida, Label lblEntrada, Label lblSaida, Label lblTotal, modeloTempo tempo)
        {
            bancoDal.resumoAnoDAl(vendedor, produto, servico, saida, lblEntrada, lblSaida, lblTotal,tempo);
        }

        public void registarSaida(modelo_Saida_Entrada registo)
        {
            bancoDal.registarSaidaDAL(registo);
        }

        public void registarEntrada(modelo_Saida_Entrada registo)
        {
            bancoDal.registarEntradaDAL(registo);
        }

        public void actualizarUsuario(modeloPessoa usuario)
        {
            bancoDal.actualizarUsuarioDAL(usuario);
        }

        public void cadastrarUsuario(modeloPessoa usuario)
        {
            bancoDal.cadastrarUsuarioDAL(usuario);
        }
        public DataTable mostararTabela(string sql)
        {
            return bancoDal.mostararTabelaDAL(sql);
        }

        public void actualizarProduto(modeloProduto produto)
        {
            bancoDal.actualizarProdutoDAL(produto);
        }

        public void prestarServico(int idServico, int idUsuario, string quantidade, string data, string hora, string total)
        {
            bancoDal.prestarServicoDAL(idServico, idUsuario, quantidade, data, hora, total);
        }

        public void venderProduto(int idProduto, int idUsuario, string quantidade, string data, string hora, string total)
        {
            bancoDal.venderProdutoDAL(idProduto, idUsuario, quantidade, data, hora, total);
        }

        public void listarProdutos(ComboBox cbo)
        {
            bancoDal.listarProdutoDAL(cbo);
        }
        public void listarUsuarios(ComboBox cbo)
        {
            bancoDal.listarUsuarioDAL(cbo);
        }

        public string stockProduto(string nome)
        {
            return bancoDal.stockProdutoDAL(nome);
        }

        public void venderProduto(string nome, string valorStock)
        {
            bancoDal.venderProdutoDAL(nome, valorStock);
        }

        public void cadastrarProduto(modeloProduto produto)
        {
            bancoDal.cadastrarProdutoDAL(produto);
        }

        public modeloProduto registoProduto(string nomeProduto)
        {
            return bancoDal.registoProdutoDAL(nomeProduto);
        }

        public modeloServico[] menuServico()
        {
            return bancoDal.menuServicoDAL();
        }

        public modeloPessoa registoAdmin()
        {
            return bancoDal.registoAdminDal();
        }
        public modeloPessoa registoUser(string nome)
        {
            return bancoDal.registoDal(nome);
        }
        public char verificarSenha(string senha)
        {
            return bancoDal.verificarSenhaDal(senha);
        }
        public char validarSenha(string senha)
        {
            return bancoDal.validarSenhaDal(senha);
        }
        public char validarSenha(string nome, string senha)
        {
             return bancoDal.validarSenhaDal(nome, senha);
        }
        public void userList(ComboBox cbo)
        {
             bancoDal.userListDal(cbo);
        }

    }
}
