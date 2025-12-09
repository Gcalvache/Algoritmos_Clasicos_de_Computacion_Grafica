using System;
using System.Collections.Generic;
using System.Drawing;

namespace AlgortimosDibujarLinea
{
    /// <summary>
    /// Módulo de discretización de líneas y generación de puntos de círculo.
    /// Contiene implementaciones de algoritmos clásicos:
    /// - DDA (Digital Differential Analyzer): muestreo uniforme por pasos.
    /// - Bresenham (líneas y círculos): algoritmo eficiente con aritmética entera.
    /// - Midpoint: variante del algoritmo de Bresenham para líneas y círculos.
    /// - Polar (círculo): método basado en coordenadas polares para comparar resultados.
    ///
    /// Requerimientos no funcionales: comentarios en español, validación mínima de entradas
    /// y diseño modular para permitir reemplazo de algoritmos.
    /// </summary>
    public class Clinea
    {
        public int Xi { get; }
        public int Yi { get; }
        public int Xf { get; }
        public int Yf { get; }
        public double Pendiente { get; private set; }

        public Clinea(int xi, int yi, int xf, int yf)
        {
            Xi = xi;
            Yi = yi;
            Xf = xf;
            Yf = yf;
        }

        public enum LineAlgorithm { DDA, Bresenham, Midpoint }

        public List<Point> Discretize()
        {
            return Discretize(LineAlgorithm.DDA);
        }

        public List<Point> Discretize(LineAlgorithm alg)
        {
            switch (alg)
            {
                case LineAlgorithm.Bresenham:
                    return DiscretizeBresenham();
                case LineAlgorithm.Midpoint:
                    return DiscretizeMidpoint();
                case LineAlgorithm.DDA:
                default:
                    return DiscretizeDDA();
            }
        }

        private List<Point> DiscretizeDDA()
        {
            var points = new List<Point>();

            int dx = Xf - Xi;
            int dy = Yf - Yi;
            int steps = Math.Max(Math.Abs(dx), Math.Abs(dy));

            if (steps == 0)
            {
                points.Add(new Point(Xi, Yi));
                Pendiente = double.NaN;
                return points;
            }

            double xInc = dx / (double)steps;
            double yInc = dy / (double)steps;

            double x = Xi;
            double y = Yi;

            for (int i = 0; i <= steps; i++)
            {
                points.Add(new Point((int)Math.Round(x), (int)Math.Round(y)));
                x += xInc;
                y += yInc;
            }

            Pendiente = dx == 0 ? double.PositiveInfinity : dy / (double)dx;
            return points;
        }

        private List<Point> DiscretizeBresenham()
        {
            var points = new List<Point>();

            int x0 = Xi;
            int y0 = Yi;
            int x1 = Xf;
            int y1 = Yf;

            int dx = Math.Abs(x1 - x0);
            int dy = Math.Abs(y1 - y0);
            int sx = x0 < x1 ? 1 : -1;
            int sy = y0 < y1 ? 1 : -1;
            int err = dx - dy;

            while (true)
            {
                points.Add(new Point(x0, y0));
                if (x0 == x1 && y0 == y1) break;
                int e2 = err << 1; 
                if (e2 > -dy)
                {
                    err -= dy;
                    x0 += sx;
                }
                if (e2 < dx)
                {
                    err += dx;
                    y0 += sy;
                }
            }

            Pendiente = (Xf - Xi) == 0 ? double.PositiveInfinity : (Yf - Yi) / (double)(Xf - Xi);
            return points;
        }

        private List<Point> DiscretizeMidpoint()
        {
            var points = new List<Point>();

            int x0 = Xi;
            int y0 = Yi;
            int x1 = Xf;
            int y1 = Yf;

            int dx = x1 - x0;
            int dy = y1 - y0;

            int dx1 = Math.Abs(dx);
            int dy1 = Math.Abs(dy);

            int sx = dx >= 0 ? 1 : -1;
            int sy = dy >= 0 ? 1 : -1;

            if (dy1 <= dx1)
            {
                int p = 2 * dy1 - dx1;
                int twoDy = 2 * dy1;
                int twoDyMinusDx = 2 * (dy1 - dx1);

                int x = x0;
                int y = y0;
                int xEnd = x1;

                while (true)
                {
                    points.Add(new Point(x, y));
                    if (x == xEnd) break;
                    x += sx;
                    if (p < 0)
                    {
                        p += twoDy;
                    }
                    else
                    {
                        y += sy;
                        p += twoDyMinusDx;
                    }
                }
            }
            else
            {
                int p = 2 * dx1 - dy1;
                int twoDx = 2 * dx1;
                int twoDxMinusDy = 2 * (dx1 - dy1);

                int x = x0;
                int y = y0;
                int yEnd = y1;

                while (true)
                {
                    points.Add(new Point(x, y));
                    if (y == yEnd) break;
                    y += sy;
                    if (p < 0)
                    {
                        p += twoDx;
                    }
                    else
                    {
                        x += sx;
                        p += twoDxMinusDy;
                    }
                }
            }

            Pendiente = (Xf - Xi) == 0 ? double.PositiveInfinity : (Yf - Yi) / (double)(Xf - Xi);
            return points;
        }

        /// <summary>
        /// Algoritmo de punto medio para círculos.
        /// Produce puntos enteros que aproximan un círculo centrado en (xc,yc) con radio r.
        /// </summary>
        public static List<Point> CircleMidpoint(int xc, int yc, int r)
        {
            var points = new List<Point>();
            if (r < 0) return points;

            int x = 0;
            int y = r;
            int p = 1 - r;

            PlotCircleOctants(points, xc, yc, x, y);

            while (x < y)
            {
                x++;
                if (p < 0)
                {
                    p += 2 * x + 1;
                }
                else
                {
                    y--;
                    p += 2 * (x - y) + 5;
                }
                PlotCircleOctants(points, xc, yc, x, y);
            }

            return points;
        }

        /// <summary>
        /// Algoritmo de Bresenham para círculos (aritmética entera).
        /// </summary>
        public static List<Point> CircleBresenham(int xc, int yc, int r)
        {
            var points = new List<Point>();
            if (r < 0) return points;

            int x = 0;
            int y = r;
            int d = 3 - 2 * r; // parámetro de decisión

            PlotCircleOctants(points, xc, yc, x, y);

            while (x <= y)
            {
                if (d <= 0)
                {
                    d = d + 4 * x + 6;
                }
                else
                {
                    d = d + 4 * (x - y) + 10;
                    y--;
                }
                x++;
                PlotCircleOctants(points, xc, yc, x, y);
            }

            return points;
        }

        /// <summary>
        /// Algoritmo polar para círculos (usa trigonometría flotante) para comparación.
        /// </summary>
        public static List<Point> CirclePolar(int xc, int yc, int r)
        {
            var points = new List<Point>();
            if (r < 0) return points;

            if (r == 0)
            {
                points.Add(new Point(xc, yc));
                return points;
            }

            double dtheta = 1.0 / r;
            double theta = 0.0;
            double limit = Math.PI / 4.0;

            for (theta = 0.0; theta <= limit + 1e-9; theta += dtheta)
            {
                int x = (int)Math.Round(r * Math.Cos(theta));
                int y = (int)Math.Round(r * Math.Sin(theta));
                PlotCircleOctants(points, xc, yc, x, y);
            }

            int xf = (int)Math.Round(r * Math.Cos(limit));
            int yf = (int)Math.Round(r * Math.Sin(limit));
            PlotCircleOctants(points, xc, yc, xf, yf);

            return points;
        }

        /// <summary>
        /// Añade los 8 puntos simétricos alrededor del centro para (x,y).
        /// </summary>
        private static void PlotCircleOctants(List<Point> list, int xc, int yc, int x, int y)
        {
            void AddUnique(int px, int py)
            {
                var pt = new Point(px, py);
                if (!list.Contains(pt))
                    list.Add(pt);
            }

            AddUnique(xc + x, yc + y);
            AddUnique(xc - x, yc + y);
            AddUnique(xc + x, yc - y);
            AddUnique(xc - x, yc - y);
            AddUnique(xc + y, yc + x);
            AddUnique(xc - y, yc + x);
            AddUnique(xc + y, yc - x);
            AddUnique(xc - y, yc - x);
        }
    }
}
