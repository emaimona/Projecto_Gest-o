using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
namespace Projecto_Gestão
{
    public class gestaoDAL : method
    {

        public string strcon = "server=localhost; uid=root; pwd=; database=gr_cyber";
        MySqlConnection con = null;
        MySqlCommand cmd = null;
        MySqlDataReader leitor = null;
        MySqlDataAdapter prencher = null;

        public int entradas, saidas, total;

        char ret;
        string retorno,texto;

        public void actualizarUsuarioDAL(modeloPessoa usuario)
        {

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("Update `gr_cyber`.`usuario` set nome=@nome,senha=@senha,sexo=@sexo,estadoCivil=@estadoCivil,nascimento=@nascimento,numeroBI=@numeroBI,morada=@morada,telefone=@telefone,outros=@outros,dataIngresso=@dataIngresso,nacionalidade=@nacionalidade,naturalidade= @naturalidade,email= @email,foto=@foto where nome=@nome;", con);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
            cmd.Parameters.AddWithValue("@estadoCivil", usuario.Estado_civil);
            cmd.Parameters.AddWithValue("@nascimento", usuario.Nascimento);
            cmd.Parameters.AddWithValue("@numeroBI", usuario.BI);
            cmd.Parameters.AddWithValue("@morada", usuario.Morada);
            cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@outros", usuario.Outros);
            cmd.Parameters.AddWithValue("@dataIngresso", usuario.Inicio_contrato);
            cmd.Parameters.AddWithValue("@nacionalidade", usuario.Nacionalidade);
            cmd.Parameters.AddWithValue("@naturalidade", usuario.Naturalidade);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@foto", usuario.Foto);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void resumoDiaDAl(ListBox vendedor, ListBox produto, ListBox servico, ListBox saida,string data, Label lblEntrada,Label lblSaida,Label lblTotal)
        {
            entradas = 0;
            saidas = 0;
            total = 0;

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select u.nome as 'nomeUser',p.nome as'pnome',p.valor pvalor,v.quantidade as'vquantidade',v.hora_venda,v.data_venda,v.Total from usuario u join venderproduto v on v.idUsuario=u.idUsuario and v.data_venda=@data join produto p on p.idProduto=v.idProduto;", con);
            cmd.Parameters.AddWithValue("@data", data);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    vendedor.Items.Add(leitor["nomeUser"].ToString());
                    produto.Items.Add(leitor["pnome"].ToString() + " (" + leitor["vquantidade"] + ")");
                    //vendedor.Items.Add(leitor["nome"].ToString());

                    entradas += Convert.ToInt32(leitor["pvalor"]) * Convert.ToInt32(leitor["vquantidade"]);
                }


                con.Close();
                cmd = new MySqlCommand("select * from saida where data_saida=@data;", con);
                cmd.Parameters.AddWithValue("@data", data);
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    saida.Items.Add(leitor["obs"].ToString() + " (" + leitor["valor"] + ")");
                    saidas += Convert.ToInt32(leitor["valor"]);
                }

                total = entradas - saidas;

                lblEntrada.Text = "Entradas: " + entradas + " Kzs";
                lblSaida.Text ="Saidas: " +saidas+" Kzs.";
                lblTotal.Text = "Total: " + total + " Kzs.";
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }

        }

        public void resumoMesDAl(ListBox vendedor, ListBox produto, ListBox servico, ListBox saida, Label lblEntrada, Label lblSaida, Label lblTotal, modeloTempo tempo)
        {
            entradas = 0;
            saidas = 0;
            total = 0;
            texto= "between '"+tempo.Ano + "-" + tempo.Mes + "-1' and '" + tempo.Ano + "-" + tempo.Mes + "- 31'";
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select u.nome as 'nomeUser',p.nome as'pnome',p.valor pvalor,v.quantidade as'vquantidade',v.hora_venda,v.data_venda,v.Total from usuario u join venderproduto v on v.idUsuario=u.idUsuario and v.data_venda join produto p on p.idProduto=v.idProduto;", con);
            cmd.Parameters.AddWithValue("@data",texto);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    vendedor.Items.Add(leitor["nomeUser"].ToString());
                    produto.Items.Add(leitor["pnome"].ToString() + " (" + leitor["vquantidade"] + ")");
                    //vendedor.Items.Add(leitor["nome"].ToString());

                    entradas += Convert.ToInt32(leitor["pvalor"]) * Convert.ToInt32(leitor["vquantidade"]);
                }

                con.Close();
                leitor = null;
                con.Open();
                cmd = new MySqlCommand("select * from saida where data_saida between '" + tempo.Ano + "-" + tempo.Mes + "-1' and '" + tempo.Ano + "-" + tempo.Mes + "- 31';", con);
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    saida.Items.Add(leitor["obs"].ToString() + " (" + leitor["valor"] + ")");
                    saidas += Convert.ToInt32(leitor["valor"]);
                }

                total = entradas - saidas;

                lblEntrada.Text = "Entradas: " + entradas + " Kzs";
                lblSaida.Text = "Saidas: " + saidas + " Kzs.";
                lblTotal.Text = "Total: " + total + " Kzs.";
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }

        }
        public void resumoAnoDAl(ListBox vendedor, ListBox produto, ListBox servico, ListBox saida, Label lblEntrada, Label lblSaida, Label lblTotal, modeloTempo tempo)
        {
            entradas = 0;
            saidas = 0;
            total = 0;

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select u.nome as 'nomeUser',p.nome as'pnome',p.valor pvalor,v.quantidade as'vquantidade',v.hora_venda,v.data_venda,v.Total from usuario u join venderproduto v on v.idUsuario=u.idUsuario and v.data_venda=@data join produto p on p.idProduto=v.idProduto;", con);
            cmd.Parameters.AddWithValue("@data", texto);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    vendedor.Items.Add(leitor["nomeUser"].ToString());
                    produto.Items.Add(leitor["pnome"].ToString() + " (" + leitor["vquantidade"] + ")");
                    //vendedor.Items.Add(leitor["nome"].ToString());

                    entradas += Convert.ToInt32(leitor["pvalor"]) * Convert.ToInt32(leitor["vquantidade"]);
                }


                con.Close();
                cmd = new MySqlCommand("select * from saida where data_saida=@data;", con);
                cmd.Parameters.AddWithValue("@data", texto);
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    saida.Items.Add(leitor["obs"].ToString() + " (" + leitor["valor"] + ")");
                    saidas += Convert.ToInt32(leitor["valor"]);
                }

                total = entradas - saidas;

                lblEntrada.Text = "Entradas: " + entradas + " Kzs";
                lblSaida.Text = "Saidas: " + saidas + " Kzs.";
                lblTotal.Text = "Total: " + total + " Kzs.";
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }

        }

        public void listarServicoDAL(ComboBox cbo, string servico)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select t.nome nome from tiposervico t join servico s on s.idServico=t.idServico and s.nome=@servico;", con);
            cmd.Parameters.AddWithValue("@servico", servico);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    cbo.Items.Add(leitor["nome"].ToString());
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void listarUsuarioDAL(ComboBox cbo)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select nome from usuario order by nome;", con);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    cbo.Items.Add(leitor["nome"].ToString());
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }

        }
        public void registarEntradaDAL(modelo_Saida_Entrada registo)
        {

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("INSERT INTO `gr_cyber`.`entrada` (`idUsuario`, `data_entrada`, `hora_entrada`, `valor`, `obs`) VALUES (@idUsuario, @data, @hora, @valor, @obs);", con);
            cmd.Parameters.AddWithValue("@idUsuario", registo.IdUsuario);
            cmd.Parameters.AddWithValue("@data", registo.Data);
            cmd.Parameters.AddWithValue("@hora", registo.Hora);
            cmd.Parameters.AddWithValue("@valor", registo.Valor);
            cmd.Parameters.AddWithValue("@obs", registo.Outros);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Registado com Sucesso");

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void registarSaidaDAL(modelo_Saida_Entrada registo)
        {

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("INSERT INTO `gr_cyber`.`saida` (`idUsuario`, `data_saida`, `hora_saida`, `valor`, `obs`) VALUES (@idUsuario, @data, @hora, @valor, @obs);", con);
            cmd.Parameters.AddWithValue("@idUsuario", registo.IdUsuario);
            cmd.Parameters.AddWithValue("@data", registo.Data);
            cmd.Parameters.AddWithValue("@hora", registo.Hora);
            cmd.Parameters.AddWithValue("@valor", registo.Valor);
            cmd.Parameters.AddWithValue("@obs", registo.Outros);
         
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Registado com Sucesso");

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void prestarServicoDAL(int idServico, int idUsuario, string quantidade, string data, string hora, string total)
        {

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("INSERT INTO `gr_cyber`.`prestarServico` (`idUsuario`, `idTipoServico`, `quantidade`, `data_venda`, `hora_venda`, `total`) VALUES (@idUsuario,@idTipoServico,@quantidade,@data,@hora,@total);", con);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@idTipoServico", idServico);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@total", total);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Registado com Sucesso");

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void venderProdutoDAL(int idProduto,int idUsuario, string quantidade, string data,string hora, string total)
        {

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("INSERT INTO `gr_cyber`.`venderproduto` (`idUsuario`, `idProduto`, `quantidade`, `data_venda`, `hora_venda`, `total`) VALUES (@idUsuario,@idProduto,@quantidade,@data,@hora,@total);", con);
            cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
            cmd.Parameters.AddWithValue("@idProduto", idProduto);
            cmd.Parameters.AddWithValue("@quantidade", quantidade);
            cmd.Parameters.AddWithValue("@data", data);
            cmd.Parameters.AddWithValue("@hora", hora);
            cmd.Parameters.AddWithValue("@total",total);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Registado com Sucesso");

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void cadastrarUsuarioDAL(modeloPessoa usuario)
        {

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("INSERT INTO `gr_cyber`.`usuario` (`nome`, `senha`, `sexo`, `estadoCivil`, `nascimento`,`numeroBI`, `morada`, `telefone`, `outros`, `dataIngresso`, `nacionalidade`, `naturalidade`, `email`,`foto`) VALUES (@nome,@senha,@sexo,@estadoCivil,@nascimento,@numeroBI,@morada,@telefone,@outros,@dataIngresso,@nacionalidade, @naturalidade, @email,@foto);", con);
            cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            cmd.Parameters.AddWithValue("@sexo", usuario.Sexo);
            cmd.Parameters.AddWithValue("@estadoCivil", usuario.Estado_civil);
            cmd.Parameters.AddWithValue("@nascimento", usuario.Nascimento);
            cmd.Parameters.AddWithValue("@numeroBI", usuario.BI);
            cmd.Parameters.AddWithValue("@morada", usuario.Morada);
            cmd.Parameters.AddWithValue("@telefone", usuario.Telefone);
            cmd.Parameters.AddWithValue("@outros", usuario.Outros);
            cmd.Parameters.AddWithValue("@dataIngresso", usuario.Inicio_contrato);
            cmd.Parameters.AddWithValue("@nacionalidade", usuario.Nacionalidade);
            cmd.Parameters.AddWithValue("@naturalidade", usuario.Naturalidade);
            cmd.Parameters.AddWithValue("@email", usuario.Email);
            cmd.Parameters.AddWithValue("@foto", usuario.Foto);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable mostararTabelaDAL(string sql)
        {
            DataTable tabela = new DataTable();

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand(sql, con);
            try
            {
                con.Open();
                MySqlDataAdapter data = new MySqlDataAdapter(cmd);
                data.Fill(tabela);
               
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return tabela;
        }

        public string stockProdutoDAL(string nome)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from produto where nome=@nome", con);
            cmd.Parameters.AddWithValue("@nome", nome);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    retorno = leitor["stock"].ToString();
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return retorno;
        }

        public void listarServicoDAL(ToolStripMenuItem Tmenu, EventHandler evento)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select nome from servico order by nome;", con);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                   Tmenu.DropDownItems.Add(leitor["nome"].ToString(), null, evento);
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }

        }

        public void listarProdutoDAL(ToolStripMenuItem Tmenu, EventHandler evento)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select nome,foto from produto order by nome;", con);

            try
            {
                byte[] img = null;
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    try
                    {
                        img = (byte[])leitor["foto"];
                        MemoryStream mstream = new MemoryStream(img);
                        Tmenu.DropDownItems.Add(leitor["nome"].ToString(), Image.FromStream(mstream), evento);
                    }
                    catch (Exception)
                    {
                        Tmenu.DropDownItems.Add(leitor["nome"].ToString(), Properties.Resources.photo, evento);

                    } 
                        
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }

        }

        public void listarProdutoDAL(ComboBox cbo)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select nome from produto order by nome;", con);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    cbo.Items.Add(leitor["nome"].ToString());
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }

        }
        public void actualizarProdutoDAL(modeloProduto produto)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("Update produto set stock=@stock,valor=@valor,foto=@foto where nome=@nome;", con);
            cmd.Parameters.AddWithValue("@nome", produto.Nome);
            cmd.Parameters.AddWithValue("@valor", produto.Valor);
            cmd.Parameters.AddWithValue("@stock", produto.Stock);
            cmd.Parameters.AddWithValue("@foto", produto.Foto);
            cmd.Parameters.AddWithValue("@outros", produto.Outros);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Actualizado com Sucesso");
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void venderProdutoDAL(string nome, string valorStock)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("Update produto set stock=@valor where nome=@nome;", con);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@valor", valorStock);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Vendido com Sucesso");
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public void cadastrarProdutoDAL(modeloProduto produto)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("insert into produto (`nome`, `valor`, `total`, `foto`,`stock`,`outros`) values(@nome,@valor,@total,@foto,@stock,@outros);", con);
            cmd.Parameters.AddWithValue("@nome", produto.Nome);
            cmd.Parameters.AddWithValue("@stock", produto.Stock);
            cmd.Parameters.AddWithValue("@foto", produto.Foto);
            cmd.Parameters.AddWithValue("@valor", produto.Valor);
            cmd.Parameters.AddWithValue("@total", produto.Total);
            cmd.Parameters.AddWithValue("@outros", produto.Outros);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                MessageBox.Show("Sucesso");
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
        }

        public modeloTipoServico registoTipoServicoDAL(string servico, string extensao)
        {
            modeloTipoServico model = new modeloTipoServico();
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select t.nome nome,t.valor valor,t.idTipoServico idTipoServico,s.idServico idServico,s.nome from tiposervico t join servico s on s.idServico=t.idServico and t.nome=@extensao where s.nome=@servico;", con);
            cmd.Parameters.AddWithValue("@extensao", extensao);
            cmd.Parameters.AddWithValue("@servico", servico);

            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    model.IdServico = Convert.ToInt32(leitor["idServico"]);
                    model.IdTipoServico = Convert.ToInt32(leitor["idTipoServico"]);
                    model.Valor = (leitor["valor"]).ToString();
                    model.Nome = leitor["nome"].ToString();
                                        
                }

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return model;
        }

        public modeloProduto registoProdutoDAL(string nomeProduto)
        {
            modeloProduto model = new modeloProduto();
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from produto where nome=@nome;", con);
            cmd.Parameters.AddWithValue("@nome", nomeProduto);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    model.IdProduto = Convert.ToInt32(leitor["idProduto"]);
                    model.Nome = leitor["nome"].ToString();
                    model.Valor = (leitor["valor"]).ToString();
                    model.Total = leitor["total"].ToString();
                    model.Stock= leitor["stock"].ToString();
                    model.Outros = leitor["outros"].ToString();
                    try
                    {
                        model.Foto = (byte[])leitor["foto"];

                    }
                    catch (Exception)
                    {

                    }
                }

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return model;
        }

        public modeloServico[] menuServicoDAL()
        {
            modeloServico[] model = new modeloServico [5];
            int n = 1;
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from servico", con);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    model[n].IdServico = (int)leitor["idservico"];
                    model[n].Nome = leitor["nome"].ToString();
                    n++;
                }

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return model;
        }

        public modeloPessoa registoAdminDal()
        {
            modeloPessoa model = new modeloPessoa();
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from admin;", con);
            
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    model.Nome = (string)leitor["nome"];
                    model.Id =Convert.ToInt32(leitor["idAdmin"]);
                    model.Sexo = leitor["sexo"].ToString();
                    model.BI = leitor["numeroBI"].ToString();
                    model.Morada = leitor["morada"].ToString();
                    model.Nacionalidade = leitor["nacionalidade"].ToString();
                    model.Naturalidade = leitor["naturalidade"].ToString();
                    model.Nascimento = leitor["nascimento"].ToString();
                    model.Outros = leitor["outros"].ToString();
                    model.Senha = leitor["senha"].ToString();
                    model.Telefone = leitor["telefone"].ToString();
                    model.Privilegio = "admin";
                    try
                    {
                        model.Foto = (byte[])leitor["foto"];

                    }
                    catch (Exception)
                    {
                        
                    }

                }

            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return model;
        }

        public modeloPessoa registoDal(string nome)
        {
            modeloPessoa model = new modeloPessoa();
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from usuario where nome=@nome;", con);
            cmd.Parameters.AddWithValue("@nome", nome);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    model.Nome =leitor["nome"].ToString();
                    model.Id = (int)leitor["idusuario"];
                    model.Sexo = leitor["sexo"].ToString();
                    model.BI = leitor["numeroBI"].ToString();
                    model.Inicio_contrato = leitor["dataingresso"].ToString();
                    model.Morada = leitor["morada"].ToString();
                    model.Nacionalidade = leitor["nacionalidade"].ToString();
                    model.Naturalidade = leitor["naturalidade"].ToString();
                    model.Nascimento = leitor["nascimento"].ToString();
                    model.Outros = leitor["outros"].ToString();
                    model.Senha = leitor["senha"].ToString();
                    model.Telefone = leitor["telefone"].ToString();
                    model.Email = leitor["email"].ToString();
                    model.Estado_civil = leitor["estadocivil"].ToString();
                    model.Privilegio = "User";
                    try
                    {
                        model.Foto = (byte[])leitor["foto"];

                    }
                    catch (Exception)
                    {

                    }

                }

            }
            catch (Exception ex)
            {
                desconectado(ex);             
            }
            finally
            {
                con.Close();
            }
            return model;
        }

        public char verificarSenhaDal(string senha)
        {
            
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from usuario where senha=@senha;", con);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                if (leitor.Read())
                {
                    ret = 'T';
                }
                else
                {
                    ret = 'F';
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return ret;
        }

        public char validarSenhaDal(string senha)
        {

            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from admin where senha=@senha;", con);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                if (leitor.Read())
                {
                    ret = 'T';
                }
                else
                {
                    ret = 'F';
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return ret;
        }
        public char validarSenhaDal(string nome,string senha)
        {
            
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from usuario where nome=@nome and senha=@senha;", con);
            cmd.Parameters.AddWithValue("@nome", nome);
            cmd.Parameters.AddWithValue("@senha", senha);
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                if (leitor.Read())
                {
                    ret= 'T';
                }
                else
                {
                    ret= 'F';
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();
            }
            return ret;
        }

        public void userListDal(ComboBox cbo)
        {
            con = new MySqlConnection(strcon);
            cmd = new MySqlCommand("select * from usuario;",con);
            
            try
            {
                con.Open();
                leitor = cmd.ExecuteReader();
                while (leitor.Read())
                {
                    cbo.Items.Add(leitor["nome"]);
                }
            }
            catch (Exception ex)
            {
                desconectado(ex);
            }
            finally
            {
                con.Close();

            }
        }
        
    }
}
