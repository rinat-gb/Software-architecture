using Editor3D.Types;
using System.Collections.Generic;

namespace Editor3D.ModelElements
{
    internal class Poligon
    {
        public List<Point3D> Points { get; set; } = new List<Point3D>();

        public Poligon(Point3D point) {
            Points.Add(point);
        }
    }
}
