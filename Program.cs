using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gold;
            do
            {
                Console.Write("Введите начальное количество золота: ");
            } while (!int.TryParse(Console.ReadLine(), out gold) || gold < 0);
            Console.WriteLine($"У вас {gold} золота.");

            int crystalPrice = 10;
            Console.WriteLine("Цена одного кристалла =  "+ crystalPrice+" золотых");

            int crystalsToBuy;
            do
            {
                Console.Write("Сколько кристаллов вы хотите купить? ");
            } while (!int.TryParse(Console.ReadLine(), out crystalsToBuy) || crystalsToBuy < 0);

            int totalPrice = crystalsToBuy * crystalPrice;

            if (totalPrice <= gold)
            {
                gold -= totalPrice;
                Console.WriteLine($"Вы купили {crystalsToBuy} кристаллов за {totalPrice} золота.\n У вас осталось {gold} золота и {crystalsToBuy} кристаллов.");
            }
            else
            {
                Console.WriteLine($"У вас недостаточно золота для покупки {crystalsToBuy} кристаллов.\n У вас есть {gold} золота и 0 кристаллов.");
            }
            Console.ReadLine();
        }
    }
}
