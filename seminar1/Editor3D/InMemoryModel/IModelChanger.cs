namespace Editor3D.InMemoryModel
{
    internal interface IModelChanger
    {
        public void NotifyChange(IModelChanger sender);
    }
}
