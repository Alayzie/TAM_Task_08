using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TAM_Task_08_labirint4
{
    class Program
    {
        static char[,] ReadMap(string mapName, out int performerX, out int performerY)
        {
            performerX = 0;
            performerY = 0;

            string[] newFile = File.ReadAllLines($"map/{mapName}.txt");
            char[,] map = new char[newFile.Length, newFile[0].Length];

            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    map[i, j] = newFile[i][j];

                    if (map[i, j] == 'Q')
                    {
                        performerX = i;
                        performerY = j;
                    }
                }
            }
            return map;
        }


        static void DrawMap(char[,] map, int sum)
        {
            Console.SetCursorPosition(90, 0);
            Console.Write("Количество собранных монет: ");
            Console.Write(sum);
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < map.GetLength(0); i++)
            {
                for (int j = 0; j < map.GetLength(1); j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        } // ФУНКЦИЯ СЧЕТЧИКА МОНЕТ

        static void Main(string[] args)
        {
            int sum = 0;
            int HP = 100;
            Console.CursorVisible = false;
            int performerX, performerY;
            char[,] map = ReadMap("maplevel04", out performerX, out performerY);


            Console.SetCursorPosition(0, 40);
            Console.WriteLine("=================================================================================");
            Console.WriteLine(@"

              Движение персонажа осуществляется на стрелочки.
              Ваша задача - собрать все монеты (0).
              Старайтесь не задевать врагов (E), они отнимают 20 ед. здоровья и исчезают.
              Вы можете зайти в таверну (T), где сможете полностью восстановить здоровье.

            ");
            Console.WriteLine("=================================================================================");
            Console.SetCursorPosition(0, 0);
            int userX = 3, userY = 3;

            do
            {
                DrawMap(map, sum);

                Console.SetCursorPosition(userX, userY);
                Console.Write('Q');

                ConsoleKeyInfo charKey = Console.ReadKey();

                switch (charKey.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (map[userY, userX - 1] != '█')
                            userX--;
                        break;
                    case ConsoleKey.RightArrow:
                        if (map[userY, userX + 1] != '█')
                            userX++;
                        break;
                    case ConsoleKey.UpArrow:
                        if (map[userY - 1, userX] != '█')
                            userY--;
                        break;
                    case ConsoleKey.DownArrow:
                        if (map[userY + 1, userX] != '█')
                            userY++;
                        break;
                }  // УПРАВЛЕНИЕ
                if (map[userY, userX] == 'T')
                {
                    Console.SetCursorPosition(90, 9);
                    Console.Write("HP игрока:");
                    Console.SetCursorPosition(90, 10);
                    int notFullHp = HP / 10;
                    Console.Write("█");

                    for (int i = 1; i <= notFullHp; i++)
                    {
                        Console.Write("█");
                    }
                    for (int i = notFullHp; i < 10; i++)
                    {
                        Console.Write("_");
                    }
                    Console.WriteLine("]");
                } // БАР С ПРОВЕРКОЙ ХП
                if (map[userY, userX] == 'E')
                {
                    map[userY, userX] = ' ';
                    HP -= 20;
                } // ВРАГ

                if (map[userY, userX] == '0')
                {
                    map[userY, userX] = ' ';

                    sum += 1;

                    if (sum == 10)
                    {
                        Console.SetCursorPosition(90, 1);
                        Console.WriteLine("Поздравляю! Все монеты собраны.");
                        Console.ReadKey();
                        break;
                    }
                } // МОНЕТКИ
                else if (HP <= 0)
                {
                    Console.SetCursorPosition(90, 3);
                    Console.WriteLine("К сожалению вы проиграли, попробуйте в следующий раз!!!");
                    Console.ReadKey();
                    break;
                } // ПОРАЖЕНИЕ
            } while (true);

        }
    }
}