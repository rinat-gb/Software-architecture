using RewardApp.Interfaces;

namespace RewardApp.Fabrics
{
    internal abstract class ItemGenerator: IGameItem
    {
        public abstract IGameItem CreateItem();

        public void OpenReward()
        {
            CreateItem().OpenReward();
        }
    }
}
