using System;
using  GameNumber;
namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                var gameNumber = new GameNumber.GameNumber(i);
                Console.WriteLine(gameNumber.Say());
            }   
            Console.ReadKey();
        }
    }
}
