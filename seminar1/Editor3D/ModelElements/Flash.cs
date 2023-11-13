using Editor3D.Types;
using System.Drawing;

namespace Editor3D.ModelElements
{
    internal class Flash
    {
        public Point3D Location { get; set; }
        public Angle3D Angle { get; set; }
        public Color Color { get; set; }
        public float Power { get; set; }

        public void Rotate(Angle3D angle)
        {
            Angle = angle;
        }

        public void Move(Point3D location)
        {
            Location = location;
        }
    }
}
