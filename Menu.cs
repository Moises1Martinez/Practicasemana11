using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practicasemana11
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //instaciamos al formulario 

            Fmtest frm = new Fmtest();
            frm.MdiParent = this; // definir formulario padre
            frm.Show(); //mostrar formulario 
        }

        private void edificioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Edificio edificio = new Edificio();
               edificio.MdiParent = this;
            edificio.Show();
        }
    }
}
