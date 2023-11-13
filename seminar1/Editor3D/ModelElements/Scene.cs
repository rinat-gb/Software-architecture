using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Editor3D.ModelElements
{
    internal class Scene<T, U>
    {
        public int Id { get; set; }
        public List<PoligonalModel> Models { get; set; }
        public List<Flash> Flashes { get; set; }
        public List<Camera> Cameras { get; set; }

        public Scene(int id, List<PoligonalModel> models, List<Flash> flashes, List<Camera> cameras)
        {
            Id = id;

            if (models.Count > 0)
                Models = models;
            else
                throw new ArgumentException("Как минимум одна модель должна быть задана!");

            Flashes = flashes;

            if (cameras.Count > 0)
                Cameras = cameras;
            else
                throw new ArgumentException("Как минимум одна камера должна быть задана!");
        }

        public T method1(T t)
        {
            return t;
        }

#pragma warning disable IDE0060 // Remove unused parameter
        public T method2(T t1, T t2)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            return t1;
        }
    }
}
