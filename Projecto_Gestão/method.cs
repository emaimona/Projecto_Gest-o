using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Projecto_Gestão
{
    public class method
    {
        public void desconectado(Exception ex)
        {
            MessageBox.Show("" + ex.Message);
        }
       
    }
}
