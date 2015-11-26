using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private string CalcularCodBarras()
        {
            string fecha;
            fecha = DateTime.Today.Year.ToString() + DateTime.Today.Month.ToString();
                
                if(Convert.ToInt32(DateTime.Today.Day.ToString())<10)
                      fecha = fecha + "0" + DateTime.Today.Day.ToString();
                else
                    fecha = fecha + DateTime.Today.Day.ToString();

            MessageBox.Show(fecha);
            return null;

        }
        private void carToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string CodBarras = CalcularCodBarras();
        }
    }
}
