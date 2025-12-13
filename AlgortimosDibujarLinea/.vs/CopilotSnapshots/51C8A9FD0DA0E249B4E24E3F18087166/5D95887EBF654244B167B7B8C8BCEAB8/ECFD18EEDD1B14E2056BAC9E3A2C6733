using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgortimosDibujarLinea
{
    /// <summary>
    /// Formulario para la variante Nicholl-Lee-Nicholl (NLN) de recorte de líneas.
    /// Se proporciona una interfaz para seleccionar dos puntos y visualizar recorte.
    /// NLN usa Liang–Barsky como implementación práctica en este proyecto.
    /// </summary>
    public partial class frmMetodoCorteLineaNLN : Form
    {
        private Point? puntoA = null;
        private Point? puntoB = null;

        public frmMetodoCorteLineaNLN()
        {
            InitializeComponent();
            btnCalcular.Click += BtnCalcular_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            btnSalir.Click += BtnSalir_Click;

            if (trkZoom != null)
            {
                trkZoom.Minimum = 1; trkZoom.Maximum = 2000; trkZoom.Value = 100;
                trkZoom.Scroll += (s,e) => { lblZoom.Text = $"Zoom: {trkZoom.Value/10f:0.##} px/unidad"; DrawBase(); DrawPointsAndLines(); };
            }

            if (pcbGrafico.Image == null) pcbGrafico.Image = new Bitmap(pcbGrafico.Width, pcbGrafico.Height);
            pcbGrafico.MouseClick += PcbGrafico_MouseClick;
            DrawBase();
        }

        private void BtnSalir_Click(object sender, EventArgs e) => Close();
        private void BtnLimpiar_Click(object sender, EventArgs e) { puntoA=null; puntoB=null; DrawBase(); }

        private void PcbGrafico_MouseClick(object sender, MouseEventArgs e)
        {
            int width = pcbGrafico.Width, height = pcbGrafico.Height; float scale = trkZoom.Value/10f; float cx = width/2f, cy = height/2f;
            int lx = (int)Math.Round((e.X - cx)/scale); int ly = (int)Math.Round((cy - e.Y)/scale);
            if (puntoA==null) puntoA = new Point(lx, ly);
            else if (puntoB==null) puntoB = new Point(lx, ly);
            else { puntoA = new Point(lx, ly); puntoB = null; }
            DrawBase(); DrawPointsAndLines();
        }

        private void DrawBase()
        {
            if (pcbGrafico.Image==null) pcbGrafico.Image = new Bitmap(pcbGrafico.Width, pcbGrafico.Height);
            int width = pcbGrafico.Width, height = pcbGrafico.Height; float scale = trkZoom.Value/10f;
            using (Graphics g = Graphics.FromImage(pcbGrafico.Image))
            {
                g.Clear(pcbGrafico.BackColor);
                float spacing = scale < 6f ? scale * (int)Math.Ceiling(6f / Math.Max(0.0001f, scale)) : scale;
                float cx = width/2f, cy = height/2f;
                using (var penGrid = new Pen(Color.FromArgb(200,230,230,230),1))
                {
                    for (float x = cx; x <= width; x += spacing) g.DrawLine(penGrid, x, 0, x, height);
                    for (float x = cx - spacing; x >= 0; x -= spacing) g.DrawLine(penGrid, x, 0, x, height);
                    for (float y = cy; y <= height; y += spacing) g.DrawLine(penGrid, 0, y, width, y);
                    for (float y = cy - spacing; y >= 0; y -= spacing) g.DrawLine(penGrid, 0, y, width, y);
                }
                using (var penAxis = new Pen(Color.Gray,2)) { g.DrawLine(penAxis,0,cy,width,cy); g.DrawLine(penAxis,cx,0,cx,height); }
                using (var penClip = new Pen(Color.Blue,2)) { g.DrawRectangle(penClip,0,0,width-1,height-1); }
            }
            pcbGrafico.Invalidate();
        }

        private void DrawPointsAndLines()
        {
            if (pcbGrafico.Image==null) return;
            int width = pcbGrafico.Width, height = pcbGrafico.Height; float scale = trkZoom.Value/10f; float cx = width/2f, cy = height/2f;
            Func<int,int,PointF> map = (x,y) => new PointF(cx + x*scale, cy - y*scale);

            using (Graphics g = Graphics.FromImage(pcbGrafico.Image))
            {
                if (puntoA!=null) { var p=map(puntoA.Value.X,puntoA.Value.Y); g.FillEllipse(Brushes.Red,p.X-3,p.Y-3,6,6); }
                if (puntoB!=null) { var p=map(puntoB.Value.X,puntoB.Value.Y); g.FillEllipse(Brushes.Red,p.X-3,p.Y-3,6,6); }

                if (puntoA!=null && puntoB!=null)
                {
                    var pA = map(puntoA.Value.X,puntoA.Value.Y); var pB = map(puntoB.Value.X,puntoB.Value.Y);
                    using (var pen = new Pen(Color.DarkGray,2)) g.DrawLine(pen,pA,pB);

                    int xmin = (int)Math.Ceiling(-(width/2f)/scale); int xmax = (int)Math.Floor((width/2f)/scale);
                    int ymin = (int)Math.Ceiling(-(height/2f)/scale); int ymax = (int)Math.Floor((height/2f)/scale);

                    Point cp0 = puntoA.Value; Point cp1 = puntoB.Value;
                    bool ok = CRecorteLinea.NLNClip(ref cp0, ref cp1, new Rectangle(xmin, ymin, xmax - xmin, ymax - ymin));
                    if (ok)
                    {
                        var q0 = map(cp0.X, cp0.Y); var q1 = map(cp1.X, cp1.Y);
                        using (var penC = new Pen(Color.Red,2)) g.DrawLine(penC, q0, q1);
                    }
                    else
                    {
                        g.DrawString("Segmento fuera del área de recorte", new Font("Segoe UI",9), Brushes.Red, 6,6);
                    }
                }
            }
            pcbGrafico.Invalidate();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (puntoA==null || puntoB==null) { MessageBox.Show("Seleccione dos puntos con el mouse.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            DrawBase(); DrawPointsAndLines();
        }

        private void frmMetodoCorteLineaNLN_Load(object sender, EventArgs e)
        {
            // no-op
        }
    }
}
