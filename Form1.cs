using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Navegador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            // NAVEGAMOS HACIA LA URL 
            webBrowser1.Navigate(txtSearch.Text);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            // NOS LLEVA A LA PAGINA ANTERIOR
            webBrowser1.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            // VAMOS A LA SIGUIENTE
            webBrowser1.GoForward();
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            // RECARGAMOS LA PAGINA
            webBrowser1.Refresh();
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            // PARAMOS LA BUSQUEDA
            webBrowser1.Stop();
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            // VOLVEMOS AL INICIO
            webBrowser1.GoHome();
        }
    }
}
