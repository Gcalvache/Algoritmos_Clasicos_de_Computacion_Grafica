using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AlgortimosDibujarLinea
{
    /// <summary>
    /// Módulo de recorte de polígonos.
    /// Descripción técnica: contiene implementaciones de algoritmos de recorte de polígonos.
    /// - Sutherland–Hodgman: algoritmo por pasos que recorta el polígono sujeto frente a cada arista
    ///   del polígono de recorte iterativamente; se eligió por su sencillez y estabilidad para
    ///   recortar contra polígonos convexos (o rectángulos), además es fácil de comprender y de
    ///   integrar en la interfaz gráfica.
    /// - Weiler–Atherton: prevista como variante que maneja casos más complejos (polígonos concavos
    ///   y múltiples intersecciones). Por simplicidad inicial se ofrece una versión fallback que
    ///   usa Sutherland–Hodgman; puede extenderse con la implementación completa si se requiere.
    /// - Greiner–Hormann: diseñada para operaciones booleanas entre polígonos; aquí se proporciona
    ///   un fallback a Sutherland–Hodgman documentado y preparado para extensión.
    ///
    /// Justificación de variantes: se implementa Sutherland–Hodgman completo por ser robusto para
    /// recorte contra rectángulos y polígonos convexos; Weiler y Greiner requieren estructuras de
    /// datos más complejas y gestión de nodos/intersecciones, por eso se añadieron como puntos de
    /// extensión y se usan como fallback para garantizar resultados coherentes mientras se
    /// implementan versiones completas.
    ///
    /// Requerimientos no funcionales (resumido):
    /// - Interfaz clara y modular.
    /// - Manejo de entradas inválidas y validaciones.
    /// - Comentarios en español que describen el propósito y funcionamiento de cada módulo.
    /// - Estilo consistente en nombres (camelCase) y sin guiones bajos prefijos.
    /// </summary>
    internal static class CRecortePoligono
    {
        /// <summary>
        /// Realiza el recorte de un polígono sujeto frente a un polígono de recorte usando
        /// el algoritmo Sutherland–Hodgman. Devuelve la lista de vértices del polígono resultante.
        /// </summary>
        public static List<PointF> SutherlandHodgmanClip(List<PointF> poligonoSujeto, List<PointF> poligonoRecorte)
        {
            if (poligonoSujeto == null || poligonoRecorte == null) return new List<PointF>();
            if (poligonoSujeto.Count == 0) return new List<PointF>();

            List<PointF> listaSalida = new List<PointF>(poligonoSujeto);

            // Para cada arista del polígono de recorte se procesa la lista de entrada
            for (int i = 0; i < poligonoRecorte.Count; i++)
            {
                PointF A = poligonoRecorte[i];
                PointF B = poligonoRecorte[(i + 1) % poligonoRecorte.Count];

                List<PointF> listaEntrada = listaSalida.ToList();
                listaSalida.Clear();

                if (listaEntrada.Count == 0) break;

                PointF S = listaEntrada[listaEntrada.Count - 1];

                for (int j = 0; j < listaEntrada.Count; j++)
                {
                    PointF E = listaEntrada[j];

                    bool E_dentro = PuntoDentro(A, B, E);
                    bool S_dentro = PuntoDentro(A, B, S);

                    if (S_dentro && E_dentro)
                    {
                        listaSalida.Add(E);
                    }
                    else if (S_dentro && !E_dentro)
                    {
                        var inter = CalcularInterseccion(S, E, A, B);
                        if (inter.HasValue) listaSalida.Add(inter.Value);
                    }
                    else if (!S_dentro && E_dentro)
                    {
                        var inter = CalcularInterseccion(S, E, A, B);
                        if (inter.HasValue) listaSalida.Add(inter.Value);
                        listaSalida.Add(E);
                    }

                    S = E;
                }
            }

            return listaSalida;
        }

        /// <summary>
        /// Determina si un punto P está dentro de la semiplana definida por la arista A->B.
        /// Se considera "dentro" si el punto queda a la izquierda de la arista (suponiendo
        /// que el polígono de recorte está definido en sentido antihorario).
        /// </summary>
        private static bool PuntoDentro(PointF A, PointF B, PointF P)
        {
            float cross = (B.X - A.X) * (P.Y - A.Y) - (B.Y - A.Y) * (P.X - A.X);
            return cross >= 0f;
        }

        /// <summary>
        /// Calcula la intersección entre el segmento S->E y la recta A->B. Devuelve null si son
        /// paralelos.
        /// </summary>
        private static PointF? CalcularInterseccion(PointF S, PointF E, PointF A, PointF B)
        {
            float dxSE = E.X - S.X;
            float dySE = E.Y - S.Y;

            float dxAB = B.X - A.X;
            float dyAB = B.Y - A.Y;

            float denom = dxSE * dyAB - dySE * dxAB;
            if (Math.Abs(denom) < 1e-9f) return null;

            float s = ((A.X - S.X) * dyAB - (A.Y - S.Y) * dxAB) / denom;
            return new PointF(S.X + s * dxSE, S.Y + s * dySE);
        }

        /// <summary>
        /// Weiler–Atherton: placeholder que actúa como fallback y actualmente emplea
        /// Sutherland–Hodgman. Está documentado para futura extensión.
        /// </summary>
        public static List<PointF> WeilerAthertonClip(List<PointF> poligonoSujeto, List<PointF> poligonoRecorte)
        {
            return SutherlandHodgmanClip(poligonoSujeto, poligonoRecorte);
        }

        /// <summary>
        /// Greiner–Hormann: placeholder que actúa como fallback y actualmente emplea
        /// Sutherland–Hodgman. Está documentado para futura extensión.
        /// </summary>
        public static List<PointF> GreinerHormannClip(List<PointF> poligonoSujeto, List<PointF> poligonoRecorte)
        {
            return SutherlandHodgmanClip(poligonoSujeto, poligonoRecorte);
        }
    }
}
