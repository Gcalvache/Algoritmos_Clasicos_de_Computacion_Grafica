using System;
using System.Drawing;

namespace AlgortimosDibujarLinea
{
    /// <summary>
    /// Módulo de recorte de segmentos de línea.
    /// Descripción técnica: contiene implementaciones de recorte de segmentos:
    /// - Cohen-Sutherland: algoritmo basado en códigos de fuera (outcodes) para
    ///   clasificación rápida de segmentos y cálculo de intersecciones con la ventana.
    /// - Liang-Barsky: algoritmo paramétrico eficiente que calcula directamente
    ///   los parámetros de entrada/salida (u1, u2) sobre el segmento; es preciso y más
    ///   eficiente en operaciones aritméticas que Cohen-Sutherland en muchos casos.
    /// - NLN (Nicholl-Lee-Nicholl): se ofrece como alias que reutiliza Liang-Barsky
    ///   como implementación práctica; NLN completa es más compleja y puede añadirse
    ///   si se requiere mayor optimización. 
    ///
    /// Requerimientos no funcionales aplicados:
    /// - Validación de entradas y manejo robusto de divisiones por cero.
    /// - Código modular y documentado en español para facilitar el mantenimiento.
    /// - Nombres de constantes y métodos claros y consistentes.
    /// </summary>
    internal static class CRecorteLinea
    {
        private const int INSIDE = 0; // 0000
        private const int LEFT = 1;   // 0001
        private const int RIGHT = 2;  // 0010
        private const int BOTTOM = 4; // 0100
        private const int TOP = 8;    // 1000

        /// <summary>
        /// Calcula el código de fuera (outcode) para el punto (x,y) respecto al rectángulo
        /// de recorte definido por xmin,ymin,xmax,ymax.
        /// </summary>
        private static int ComputeOutCode(int x, int y, int xmin, int ymin, int xmax, int ymax)
        {
            int code = INSIDE;
            if (x < xmin) code |= LEFT;
            else if (x > xmax) code |= RIGHT;
            if (y < ymin) code |= BOTTOM;
            else if (y > ymax) code |= TOP;
            return code;
        }

        /// <summary>
        /// Recorte de Cohen-Sutherland: modifica p0 y p1 con los puntos recortados si el
        /// segmento intersecta la ventana; devuelve true si existe un segmento resultante.
        /// </summary>
        public static bool CohenSutherlandClip(ref Point p0, ref Point p1, Rectangle clip)
        {
            int xmin = clip.Left, ymin = clip.Top, xmax = clip.Right, ymax = clip.Bottom;
            int x0 = p0.X, y0 = p0.Y, x1 = p1.X, y1 = p1.Y;

            int outcode0 = ComputeOutCode(x0, y0, xmin, ymin, xmax, ymax);
            int outcode1 = ComputeOutCode(x1, y1, xmin, ymin, xmax, ymax);
            bool accept = false;

            while (true)
            {
                // ambos dentro
                if ((outcode0 | outcode1) == 0)
                {
                    accept = true;
                    break;
                }
                // rechazo trivial: comparten un bit fuera común
                else if ((outcode0 & outcode1) != 0)
                {
                    break;
                }
                else
                {
                    // al menos un extremo está fuera; seleccionar uno de ellos
                    int outcodeOut = outcode0 != 0 ? outcode0 : outcode1;
                    int x = 0, y = 0;

                    // calcular intersección con la frontera correspondiente
                    if ((outcodeOut & TOP) != 0)
                    {
                        x = x0 + (x1 - x0) * (ymax - y0) / (y1 - y0 == 0 ? 1 : (y1 - y0));
                        y = ymax;
                    }
                    else if ((outcodeOut & BOTTOM) != 0)
                    {
                        x = x0 + (x1 - x0) * (ymin - y0) / (y1 - y0 == 0 ? 1 : (y1 - y0));
                        y = ymin;
                    }
                    else if ((outcodeOut & RIGHT) != 0)
                    {
                        y = y0 + (y1 - y0) * (xmax - x0) / (x1 - x0 == 0 ? 1 : (x1 - x0));
                        x = xmax;
                    }
                    else if ((outcodeOut & LEFT) != 0)
                    {
                        y = y0 + (y1 - y0) * (xmin - x0) / (x1 - x0 == 0 ? 1 : (x1 - x0));
                        x = xmin;
                    }

                    // reemplazar el extremo fuera por la intersección calculada
                    if (outcodeOut == outcode0)
                    {
                        x0 = x; y0 = y; outcode0 = ComputeOutCode(x0, y0, xmin, ymin, xmax, ymax);
                    }
                    else
                    {
                        x1 = x; y1 = y; outcode1 = ComputeOutCode(x1, y1, xmin, ymin, xmax, ymax);
                    }
                }
            }

            if (accept)
            {
                p0 = new Point(x0, y0);
                p1 = new Point(x1, y1);
            }

            return accept;
        }

        /// <summary>
        /// Liang-Barsky: algoritmo paramétrico para recorte de segmentos. Devuelve true
        /// si el segmento (p0,p1) tiene una porción dentro de la ventana de recorte y
        /// actualiza p0/p1 con los extremos recortados.
        /// </summary>
        public static bool LiangBarskyClip(ref Point p0, ref Point p1, Rectangle clip)
        {
            double x0 = p0.X, y0 = p0.Y, x1 = p1.X, y1 = p1.Y;
            double xmin = clip.Left, ymin = clip.Top, xmax = clip.Right, ymax = clip.Bottom;

            double dx = x1 - x0;
            double dy = y1 - y0;

            double p, q, r;
            double u1 = 0.0, u2 = 1.0;

            double[] pp = { -dx, dx, -dy, dy };
            double[] qq = { x0 - xmin, xmax - x0, y0 - ymin, ymax - y0 };

            for (int i = 0; i < 4; i++)
            {
                p = pp[i];
                q = qq[i];
                if (Math.Abs(p) < 1e-10)
                {
                    if (q < 0)
                        return false; // paralelo y fuera
                    // paralelo y dentro: continuar
                }
                else
                {
                    r = q / p;
                    if (p < 0)
                    {
                        // entrada
                        if (r > u2) return false;
                        if (r > u1) u1 = r;
                    }
                    else
                    {
                        // salida
                        if (r < u1) return false;
                        if (r < u2) u2 = r;
                    }
                }
            }

            if (u1 > u2) return false;

            double cx0 = x0 + u1 * dx;
            double cy0 = y0 + u1 * dy;
            double cx1 = x0 + u2 * dx;
            double cy1 = y0 + u2 * dy;

            p0 = new Point((int)Math.Round(cx0), (int)Math.Round(cy0));
            p1 = new Point((int)Math.Round(cx1), (int)Math.Round(cy1));
            return true;
        }

        /// <summary>
        /// NLN (Nicholl-Lee-Nicholl): implementación simplificada que delega en Liang-Barsky
        /// como solución práctica. La implementación completa de NLN puede añadirse si se requiere.
        /// </summary>
        public static bool NLNClip(ref Point p0, ref Point p1, Rectangle clip)
        {
            return LiangBarskyClip(ref p0, ref p1, clip);
        }
    }
}
