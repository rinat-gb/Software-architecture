using RewardApp.Interfaces;
using RewardApp.Products;

namespace RewardApp.Fabrics
{
    internal class WormsGenerator: ItemGenerator
    {
        override public IGameItem CreateItem() => new Worms();
    }
}
