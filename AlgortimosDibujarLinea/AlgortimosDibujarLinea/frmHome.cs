using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgortimosDibujarLinea
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void dDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoLineaDda frm= new frmMetodoLineaDda();
            frm. MdiParent = this;
            frm.Show();
        }

        private void circuloToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // Punto medio (original)
            frmMetodoCirculo frm = new frmMetodoCirculo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void bresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMetodoCirculoBresenham();
            frm.MdiParent = this;
            frm.Show();
        }

        private void polarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmMetodoCirculoPolar();
            frm.MdiParent = this;
            frm.Show();
        }

        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metodoBresenhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoLineaBresenham frm = new frmMetodoLineaBresenham();   
            frm.MdiParent = this;
            frm.Show();
        }

        private void metodoPuntoMedioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoLineaPuntoMedio frm = new frmMetodoLineaPuntoMedio();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
