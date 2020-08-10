using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Gestão
{
    public class modeloPessoa
    {
        int id;
        string nome, morada, senha, Bi, estado_civil, nascimento, naturalidade, nacionalidade, inicio_contrato, privilegio, telefone, outros,sexo,email;
        byte[] foto = null;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
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

        public string Morada
        {
            get
            {
                return morada;
            }

            set
            {
                morada = value;
            }
        }

        public string Senha
        {
            get
            {
                return senha;
            }

            set
            {
                senha = value;
            }
        }

        public string BI
        {
            get
            {
                return Bi;
            }

            set
            {
                Bi = value;
            }
        }

        public string Estado_civil
        {
            get
            {
                return estado_civil;
            }

            set
            {
                estado_civil = value;
            }
        }

        public string Nascimento
        {
            get
            {
                return nascimento;
            }

            set
            {
                nascimento = value;
            }
        }

        public string Naturalidade
        {
            get
            {
                return naturalidade;
            }

            set
            {
                naturalidade = value;
            }
        }

        public string Nacionalidade
        {
            get
            {
                return nacionalidade;
            }

            set
            {
                nacionalidade = value;
            }
        }

        public string Inicio_contrato
        {
            get
            {
                return inicio_contrato;
            }

            set
            {
                inicio_contrato = value;
            }
        }

        public string Privilegio
        {
            get
            {
                return privilegio;
            }

            set
            {
                privilegio = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
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

        public string Sexo
        {
            get
            {
                return sexo;
            }

            set
            {
                sexo = value;
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }
    }
}
