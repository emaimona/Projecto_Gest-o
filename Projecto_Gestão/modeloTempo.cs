using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projecto_Gestão
{
    public class modeloTempo
    {
        string dia, mes, ano, hora, minuto, segundos, date, time;

        public string Time
        {
            get { return time; }
            set { time = value; }
        }

        public string Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Segundos
        {
            get { return segundos; }
            set { segundos = value; }
        }

        public string Minuto
        {
            get { return minuto; }
            set { minuto = value; }
        }

        public string Hora
        {
            get { return hora; }
            set { hora = value; }
        }

        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }

        public string Mes
        {
            get { return mes; }
            set { mes = value; }
        }

        public string Dia
        {
            get { return dia; }
            set { dia = value; }
        }
    }
}
