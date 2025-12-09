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
    public partial class frmMetodoRecortePoligonoSutherland : Form
    {
        private List<PointF> poligonoSujeto = new List<PointF>();
        private List<PointF> poligonoRecorte = null; // polígono de recorte (opcional)
        private bool estaCerrado = false;

        public frmMetodoRecortePoligonoSutherland()
        {
            InitializeComponent();

            btnCalcular.Click += BtnCalcular_Click;
            btnLimpiar.Click += BtnLimpiar_Click;
            btnSalir.Click += BtnSalir_Click;

            pcbGrafico.Image = new Bitmap(pcbGrafico.Width, pcbGrafico.Height);
            pcbGrafico.MouseClick += PcbGrafico_MouseClick;

            trkZoom.Minimum = 1; trkZoom.Maximum = 200; trkZoom.Value = 20;
            trkZoom.Scroll += (s, e) => { lblZoom.Text = $"Zoom: {trkZoom.Value} px"; Redraw(); };

            Redraw();
        }

        private void BtnSalir_Click(object sender, EventArgs e) => Close();

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            poligonoSujeto.Clear(); poligonoRecorte = null; estaCerrado = false;
            txtXc.Clear(); txtYc.Clear(); txtR.Clear();
            Redraw();
        }

        private void PcbGrafico_MouseClick(object sender, MouseEventArgs e)
        {
            // Agregar punto en coordenadas lógicas centradas
            int w = pcbGrafico.Width, h = pcbGrafico.Height;
            float scale = trkZoom.Value;
            float cx = w/2f, cy = h/2f;
            int lx = (int)Math.Round((e.X - cx)/scale);
            int ly = (int)Math.Round((cy - e.Y)/scale);
            poligonoSujeto.Add(new PointF(lx, ly));
            Redraw();
        }

        private void DrawPolygon(Graphics g, List<PointF> poly, Pen pen, float scale)
        {
            if (poly == null || poly.Count == 0) return;
            float w = pcbGrafico.Width, h = pcbGrafico.Height;
            float cx = w/2f, cy = h/2f;
            PointF[] pts = poly.Select(p => new PointF(cx + p.X*scale, cy - p.Y*scale)).ToArray();
            if (pts.Length == 1) g.FillEllipse(Brushes.Red, pts[0].X-3, pts[0].Y-3,6,6);
            else g.DrawPolygon(pen, pts);
        }

        private void Redraw()
        {
            if (pcbGrafico.Image == null) pcbGrafico.Image = new Bitmap(pcbGrafico.Width, pcbGrafico.Height);
            using (Graphics g = Graphics.FromImage(pcbGrafico.Image))
            {
                g.Clear(pcbGrafico.BackColor);
                float scale = trkZoom.Value;
                // Dibujar polígono sujeto en gris oscuro
                DrawPolygon(g, poligonoSujeto, Pens.DarkGray, scale);

                // Dibujar ventana de recorte (rectángulo del PictureBox) en azul
                var rect = new Rectangle(0,0,pcbGrafico.Width-1, pcbGrafico.Height-1);
                g.DrawRectangle(Pens.Blue, rect);

                // Calcular el polígono de recorte en coordenadas lógicas: rectángulo
                float w = pcbGrafico.Width, h = pcbGrafico.Height;
                float cx = w/2f, cy = h/2f;
                float halfW = (w/2f)/scale; float halfH = (h/2f)/scale;
                poligonoRecorte = new List<PointF> {
                    new PointF(-halfW, -halfH),
                    new PointF(halfW, -halfH),
                    new PointF(halfW, halfH),
                    new PointF(-halfW, halfH)
                };

                // Dibujar puntos del polígono sujeto
                if (poligonoSujeto.Count>0) DrawPolygon(g, poligonoSujeto, Pens.DarkGray, scale);

                // Si el polígono sujeto está cerrado -> realizar recorte
                if (poligonoSujeto.Count >= 3)
                {
                    // Mostrar sujeto relleno ligeramente
                    var subjectPts = poligonoSujeto.Select(p => new PointF(cx + p.X*scale, cy - p.Y*scale)).ToArray();
                    using (var sb = new SolidBrush(Color.FromArgb(40, 80, 80, 80))) g.FillPolygon(sb, subjectPts);

                    var clipped = CRecortePoligono.SutherlandHodgmanClip(poligonoSujeto, poligonoRecorte);
                    DrawPolygon(g, clipped, Pens.Red, scale);

                    if (clipped.Count>0)
                    {
                        var pts = clipped.Select(p => new PointF(cx + p.X*scale, cy - p.Y*scale)).ToArray();
                        using (var sb = new SolidBrush(Color.FromArgb(100, 200, 100, 100))) g.FillPolygon(sb, pts);
                    }
                }
            }
            pcbGrafico.Invalidate();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            // Cerrar polígono sujeto y redibujar
            if (poligonoSujeto.Count >= 3) estaCerrado = true;
            Redraw();
        }
    }
}
