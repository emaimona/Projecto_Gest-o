using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Gestão
{
    public class modeloProduto
    {
        int idProduto;
        string nome, total,stock,outros,valor;
        byte[] foto;

        public int IdProduto
        {
            get
            {
                return idProduto;
            }

            set
            {
                idProduto = value;
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


        public string Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public byte[] Foto
        {
            get
            {
                return foto;
            }

            set
            {
                foto = value;
            }
        }

        public string Stock
        {
            get
            {
                return stock;
            }

            set
            {
                stock = value;
            }
        }

        public string Outros
        {
            get
            {
                return outros;
            }

            set
            {
                outros = value;
            }
        }
    }
}
