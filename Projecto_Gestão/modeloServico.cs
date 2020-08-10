using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Gestão
{
    public class modeloServico
    {
        int idServico;
        string nome;

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
    }
}
