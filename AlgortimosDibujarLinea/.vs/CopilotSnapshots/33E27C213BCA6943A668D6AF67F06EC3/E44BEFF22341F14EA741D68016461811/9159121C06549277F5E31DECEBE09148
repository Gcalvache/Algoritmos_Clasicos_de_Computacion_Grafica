using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace AlgortimosDibujarLinea
{
    internal class CRelleno
    {
        // Flood fill (seed-based). Returns the list of points in the order they were filled.
        // boundary: set of boundary points (pixels) that should not be filled.
        // seed: world coordinate seed point.
        // eightConnected: if true uses 8-connected neighbors, otherwise 4-connected.
        public static List<Point> FloodFillSeed(Point seed, HashSet<Point> boundary, bool eightConnected = false)
        {
            var result = new List<Point>();
            if (boundary == null || boundary.Count == 0) return result;

            // bounding box to limit flood
            GetBounds(boundary, out int minX, out int maxX, out int minY, out int maxY);

            // If seed is outside bounds extend bounds by 1 so fill can start
            if (seed.X < minX) minX = seed.X - 1;
            if (seed.X > maxX) maxX = seed.X + 1;
            if (seed.Y < minY) minY = seed.Y - 1;
            if (seed.Y > maxY) maxY = seed.Y + 1;

            var visited = new HashSet<Point>();
            var stack = new Stack<Point>();

            if (boundary.Contains(seed)) return result;

            stack.Push(seed);

            Point[] dirs4 = new[] { new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1) };
            Point[] dirs8 = new[] {
                new Point(1,0), new Point(-1,0), new Point(0,1), new Point(0,-1),
                new Point(1,1), new Point(1,-1), new Point(-1,1), new Point(-1,-1)
            };

            var dirs = eightConnected ? dirs8 : dirs4;

            while (stack.Count > 0)
            {
                var p = stack.Pop();
                if (visited.Contains(p)) continue;
                if (p.X < minX || p.X > maxX || p.Y < minY || p.Y > maxY) continue;
                if (boundary.Contains(p)) continue;

                visited.Add(p);
                result.Add(p);

                foreach (var d in dirs)
                {
                    var np = new Point(p.X + d.X, p.Y + d.Y);
                    if (!visited.Contains(np) && !boundary.Contains(np)) stack.Push(np);
                }
            }

            return result;
        }

        // Boundary fill implemented with stack (seed fill until boundary set is encountered).
        // Equivalent to flood fill with boundary check; kept separate name for clarity.
        public static List<Point> BoundaryFillSeed(Point seed, HashSet<Point> boundary, bool eightConnected = false)
        {
            // Reuse FloodFillSeed since behavior is identical given boundary set
            return FloodFillSeed(seed, boundary, eightConnected);
        }

        // Scanline seed fill implementation
        public static List<Point> ScanlineSeedFill(Point seed, HashSet<Point> boundary)
        {
            var result = new List<Point>();
            if (boundary == null || boundary.Count == 0) return result;

            GetBounds(boundary, out int minX, out int maxX, out int minY, out int maxY);

            var visited = new HashSet<Point>();
            var stack = new Stack<Point>();

            if (boundary.Contains(seed)) return result;

            stack.Push(seed);

            while (stack.Count > 0)
            {
                var p = stack.Pop();
                int x = p.X;
                int y = p.Y;

                if (y < minY || y > maxY || x < minX || x > maxX) continue;
                if (boundary.Contains(p) || visited.Contains(p)) continue;

                // move to leftmost point on this scanline
                int xLeft = x;
                while (xLeft - 1 >= minX && !boundary.Contains(new Point(xLeft - 1, y)) && !visited.Contains(new Point(xLeft - 1, y))) xLeft--;

                int xRight = x;
                while (xRight + 1 <= maxX && !boundary.Contains(new Point(xRight + 1, y)) && !visited.Contains(new Point(xRight + 1, y))) xRight++;

                // fill from xLeft to xRight
                for (int xi = xLeft; xi <= xRight; xi++)
                {
                    var pt = new Point(xi, y);
                    if (visited.Add(pt)) result.Add(pt);
                }

                // check spans above and below for seeds
                for (int xi = xLeft; xi <= xRight; xi++)
                {
                    var above = new Point(xi, y + 1);
                    if (y + 1 <= maxY && !boundary.Contains(above) && !visited.Contains(above))
                    {
                        // push seed at first point of the span
                        stack.Push(above);
                    }

                    var below = new Point(xi, y - 1);
                    if (y - 1 >= minY && !boundary.Contains(below) && !visited.Contains(below))
                    {
                        stack.Push(below);
                    }
                }
            }

            return result;
        }

        private static void GetBounds(IEnumerable<Point> pts, out int minX, out int maxX, out int minY, out int maxY)
        {
            minX = int.MaxValue; maxX = int.MinValue; minY = int.MaxValue; maxY = int.MinValue;
            bool any = false;
            foreach (var p in pts)
            {
                any = true;
                if (p.X < minX) minX = p.X;
                if (p.X > maxX) maxX = p.X;
                if (p.Y < minY) minY = p.Y;
                if (p.Y > maxY) maxY = p.Y;
            }
            if (!any)
            {
                minX = maxX = minY = maxY = 0;
            }
        }
    }
}
