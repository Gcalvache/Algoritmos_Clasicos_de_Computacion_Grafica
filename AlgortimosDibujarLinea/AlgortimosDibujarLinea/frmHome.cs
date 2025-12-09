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

        private void boundaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoRellenoBoundary frm = new frmMetodoRellenoBoundary();
            frm.MdiParent = this;
            frm.Show();
        }

        private void floodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoRellenoFlood frm = new frmMetodoRellenoFlood();
            frm.MdiParent = this;
            frm.Show();
        }

        private void scanlineSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoRellenoScanlineSeed frm = new frmMetodoRellenoScanlineSeed();
            frm.MdiParent = this;
            frm.Show();
        }

        private void cohenSutherlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoCorteLineaCohen frm = new frmMetodoCorteLineaCohen();
            frm.MdiParent = this;
            frm.Show();
        }

        private void liangBarskyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoCorteLineaBarsky frm= new frmMetodoCorteLineaBarsky();
            frm.MdiParent = this;
            frm.Show();
        }

        private void nichollLeeNichollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoCorteLineaNLN frm = new frmMetodoCorteLineaNLN();
            frm.MdiParent = this;
            frm.Show();
        }

        private void greinerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoRecortePoligonoGreiner frm = new frmMetodoRecortePoligonoGreiner();
            frm.MdiParent = this;
            frm.Show();
        }

        private void sutherlandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoRecortePoligonoSutherland frm = new frmMetodoRecortePoligonoSutherland();
            frm.MdiParent = this;
            frm.Show();
        }

        private void weilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMetodoRecortePoligonoWeiler frm= new frmMetodoRecortePoligonoWeiler();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
