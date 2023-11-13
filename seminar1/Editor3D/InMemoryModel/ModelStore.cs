using Editor3D.ModelElements;
using Editor3D.Types;
using System.Collections.Generic;

namespace Editor3D.InMemoryModel
{
    internal class ModelStore : IModelChanger
    {
        public List<PoligonalModel> Models { get; set; } = new List<PoligonalModel>();

        public List<Scene<Angle3D, Point3D>> Scenes { get; set; } = new List<Scene<Angle3D, Point3D>>();

        public List<Flash> Flashes { get; set; } = new List<Flash>()
        {
            new()
        };

        public List<Camera> Cameras { get; set; } = new List<Camera>()
        {
            new()
        };

        private IModelChangedObserver[] changedObservers;

        public ModelStore(IModelChangedObserver[] changedObservers)
        {
            this.changedObservers = changedObservers;

            Models.Add(new PoligonalModel(new List<Texture>()));

            Scenes.Add(new Scene<Angle3D, Point3D>(1234, Models, Flashes, Cameras));
        }

        public Scene<Angle3D, Point3D> GetScene(int id)
        {
            foreach (var scene in Scenes)
            {
                if (scene.Id == id)
                    return scene;
            }
            return null;
        }

        public void NotifyChange(IModelChanger sender)
        {
            throw new System.NotImplementedException();
        }
    }
}
