using Editor3D.Types;
using System.Collections.Generic;

namespace Editor3D.ModelElements
{
    internal class PoligonalModel
    {
        public List<Poligon> Poligons { get; set; }
        public List<Texture> Textures { get; set; }

        public PoligonalModel(List<Texture> textures) {
            Poligons = new List<Poligon>
            {
                new Poligon(new Point3D())
            };

            Textures = textures;
        }
    }
}
