using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Gestão
{
   public class modelo_Saida_Entrada
    {
        int id, idUsuario;
        string data, hora, outros, valor;

        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Outros
        {
            get { return outros; }
            set { outros = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string Data
        {
            get { return data; }
            set { data = value; }
        }

      
        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
