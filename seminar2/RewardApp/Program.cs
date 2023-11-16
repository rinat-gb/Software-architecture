using System;
using RewardApp.Fabrics;

namespace RewardApp
{
    internal class Program
    {
#pragma warning disable IDE0060 // Remove unused parameter
        static void Main(string[] args)
#pragma warning restore IDE0060 // Remove unused parameter
        {
            Console.WriteLine("Задание к семинару №2 модуля \"Архитектура ПО\"\n");

            ItemGenerator[] items = {
                new GemGenerator(),
                new GoldGenerator(),
                new DustGenerator(),
                new PeelingsGenerator(),
                new SandGenerator(),
                new StoneGenerator(),
                new WormsGenerator()
            };

            Random rnd = new Random();

            for (int i = 0; i < items.Length * 5; i++)
            {
                Console.Write("Итерация {0:d2}: ", i + 1);
                items[rnd.Next(items.Length)].OpenReward();
            }
        }
    }
}
