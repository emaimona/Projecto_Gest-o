using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Gestão
{
    public class modeloTipoServico
    {
        int idTipoServico, idServico;
        string nome, valor;

        public int IdServico
        {
            get
            {
                return idServico;
            }

            set
            {
                idServico = value;
            }
        }

        public int IdTipoServico
        {
            get
            {
                return idTipoServico;
            }

            set
            {
                idTipoServico = value;
            }
        }

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string Valor
        {
            get
            {
                return valor;
            }

            set
            {
                valor = value;
            }
        }
    }
}
