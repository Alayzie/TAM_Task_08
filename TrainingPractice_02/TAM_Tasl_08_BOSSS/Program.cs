﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TAM_Task_08_BOSSS
{
    class Program
    {

        static Random rnd = new Random();
        static int fire = 65;
        static int ice = rnd.Next(50, 71);
        static int regen = 20;
        static int iceStun = 0;
        static int swordShot = rnd.Next(15, 21);
        static int inspectum = 2;
        static string buffer = "";
        static int damage = 0;
        static int bonus = 1;
        static int limitStun = 0;
        static int limitRegen = 0;

        static string passWord;
        static int i;
        static int j;

        static int health = 100;
        static int demonHealth = 400;
        static int boss;

        static void Fight(ref int helth, int D)
        {
            string a;
            Console.WriteLine("Введите заклинание");

            a = Console.ReadLine();

            if (bonus >= 2) bonus--;
            if (a == "fire")
            {
                helth -= fire * bonus;
            } // FIRE
            else if (a == "ice")
            {
                helth -= ice * bonus;
            } // ICE
            else if (a == "iceStun")
            {
                if (limitStun == 0)
                {
                    if (buffer == "ice")
                    {
                        damage = 2;
                    }

                    limitStun = 3;
                }
                else
                {
                    Console.WriteLine("Это заклинание сейчас недоступно");
                    Console.ReadKey();
                }

            } // ICE STUN
            else if (a == "inspectum")
            {
                bonus = 3;
            } // INSPECTUM
            else if (a == "swordShot")
            {
                helth -= swordShot * bonus;
            }
            else if (a == "regen")
            {
                if (limitRegen == 0)
                {
                    health += 20;

                    limitRegen = 3;
                }
                else
                {
                    Console.WriteLine("Это заклинание сейчас недоступно");
                    Console.ReadKey();
                }

            }

            if (damage == 0)
            {
                health -= D;
            }

            buffer = a;
            if (damage > 0) damage -= 1;
            if (limitStun > 0) limitStun--;
            if (limitRegen > 0) limitRegen--;

        }

        static void Main(string[] args)
        {

            // ОТКРЫВАЙТЕ КОНСОЛЬНОЕ ОКНО ПРИ ЗАПУСКЕ В ПОЛНОЭКРАННОМ РЕЖИМЕ!!!!!!!!!!! (ДЛЯ ПОЛНОТЫ ИЗОБРАЖЕНИЯ И РАЦИОНАЛЬНОГО РАСПОЛОЖЕНИЯ ТАБУЛЯЦИЙ

            Console.WriteLine(@"Вы рыцарь - маг, который славится своими подвигами в неисследованных местах.Своим выдающимся волшебством
            и великолепными навыками ведения раскопок. Вы путешествуете по местам, которые обнаруживает лига и исследуете их.
            ");

            Console.WriteLine("Первое заклинание: Инспектум - определяет слабое место врага, позволяя наносить двойной урон по нему остальными заклинаниями.");
            Console.WriteLine("\nВторое заклинание: Фарголум - пылающий огненный шар, который вы можете отправить прямиком во врага, нанося ему 65 урона.");
            Console.WriteLine("\n\nТретье заклинание: Лекосмус - обледенелая стрела, яростно летящая во врага, может нанести ему от 50 до 71 урона, в зависимости от вашей удачи, конечно!");
            Console.WriteLine("\nЧетвертое заклинание: Стеколмус - замораживает врага, из-за чего тот будет вынужден пропустить 1 ход. Действует только в том случае, если вы на прошлом ходу применили 'Лекосмус'.");
            Console.WriteLine("\nПятое заклинание: Выстрел из священного меча - атакует врага светом, озарившем меч, нанося ему 15-21 урона.");
            Console.WriteLine("\nШестое заклинание: Реакто - восстанавливает вам 25 очков здоровья.");
            Console.WriteLine("===============================================================================================================================");        
       
            Console.WriteLine("Вы выходите из руин и направляетесь во владения демона...");
            Console.WriteLine("===============================================================================================================================");

            Console.WriteLine($@"

                              ▐█▌                            ██
                              ▐█▌                            ██
                            ┌▄▐▀▌▄▄                          ██
                            ▐█▌▐█▌    ▄▄▄▄▄▄▄▄▄▄▄▄        ▄▄╢▀¼▄⌐
                            ▐█▌▐██▄▄▄▄████▀▀▀▀▀▀▀▀▄▄▄▄    ██▌∩██b
                            ▐█╙▀▀████▓▓▓▓▓▓▓▓▓▓║║▀▀▀▀▓▄  ██▌∩██b
                            ▐█▌▐▀▀██▓▓▓▓▓▓▓▓▓▓║║║║║║▀▀▓▓▀▀Γ∩██b
                             └▐█▌▒████▓▓▓▓▓▓║║║║║║║║██▒▒▓█▌└
                              ▐███▌████▓▓▓▓║║║║║║║║║║████╩`
                              ▐██████████▓▓██████████████████═
                              ▐███████▓▓▓▓▓██████████████¬
                              ▐██████▓▓▓▓▓▓║║║║║╠████║║║║██─
                                ▐██████▓▓▓▓▓▓▓▓║╠████▓▓▓▓██▄
                             ...▐████████▓▓▓▓▓▓║▒████▓▓▓▓██████▄.
                          .,▐██████████████████████████████▒▒║║██▌,
                        ╓▄╣██▀▒║╢▀▓▓███████████████████████▓▓▒▒▒▒██▌                                       === РЫЦАРЬ-МАГ
                        ║██▓▒║║▒▒▒▒▓█████▓▓▓▓║╠▀▀▀▀▀▀║║██████████▀▀=                                       === ЗДОРОВЬЕ - {health}
                        ╙▀██▓▒▓▓▓████████▓▓▓▓▒▒║║║║║║║║████████▀▀"");                                      === МОЛОД И КРАСИВ
                  ╗▄▄▄▄▄▄▄███████████████▓▓▓▓▓▓▓▓║║║║║║████████M
                  ███▀▀▀▀▀▀▀▀▀▀▀▀▀███████▓▓▓▓▓▓▓▓▓▓║║▓▓█████████▄p
                  ██▓▓Ñ╠∩∩∩∩∩∩▐╠╠╠▐████████▓▓▓▓▓▓▓▓▓▓████▓▓██████▓▓▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀
                  ███▓▒▒▒▒M∩∩∩││││▐████████████████████████████▓▓▒▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▓▓
                  ███▓▒▒▒▒▒▒M∩∩∩∩∩▐████████████████████▓▓▒█████▓▓M---------------------------██
                  ████▓▓▒▒▒▒M∩▐║║║▐██▓▓▒█████████████▒▒████████▓▓▒________________________║██
                  ████▓▓▒▒▒▒▒▒▒▓▌╠▐████▓▓║║║║██▓▓║║║║▓▓██¬ ██████▌╠╠╠╠╠╠╠╠╠╠╠╠╠╠╠║██
                    ████▓▓▓▓▒▒▒▓██▌ j████████  ████████    ███████████████████████
                      ╫██▒▒▒▒▒██▌   ▐██▒║║║██  ██▓▓║║║║██  ██████b
                        ╚█████▌   ▐██▓▓▓▓▒▒██  ██▓▓▓▓▒▒██
                                  ╘▀▀██████▀▀  ██████████
                                   ▄▄███▀▀█▄▄  ███████▀▀█▄▄
                                  ▐████▒▒▒▒██  ▀▀████▒▒▒▒██¬
            ");

            do
            {

                Console.WriteLine("===============================================================================================================================");
                Console.WriteLine("Чтобы сразиться с демоном, напишите 'Fight with boss'.");
                Console.WriteLine("===============================================================================================================================");

                passWord = Convert.ToString(Console.ReadLine());

            } while (passWord != "Fight with boss"); // ЦИКЛ ПЕРЕХОДА     

            do
            {

                Console.Clear();

                Console.WriteLine("Войдя в логово демона, вы обнаруживаете, что вас уже ждали. Демон приветствует вас и приказывает встать на колени. \t");

                Console.WriteLine(@"
                   ============================================================================================================ 
                    fire              === наносит 65 ед. урона
                    ice               === наносит 50 - 71 ед. урона
                    regen             === восстанавливает 20 ед. здоровья
                    iceStun           === iceStun полезный только после использования ice, противник пропускает 2 хода
                    swordShot         === наносит 15 - 21 ед. урона
                    inspectum         === увеличивает наносимый урон следующего заклинания в 2 раза      
                   ============================================================================================================ 

                "); // ТАБЛИЦА ЗАКЛИНАНИЙ

                Console.Write("HP игрока: ");
                for (i = 0; i < (health / 10); i++)
                {
                    Console.Write('█');
                }

                if (health < 100)
                {
                    for (i = 0; i < 10 - (health / 10); i++)
                    {
                        Console.Write('_');
                    }
                }

                Console.Write($"\t {health} ");
                Console.WriteLine($@"

                       «.    ▄▄▄▄▄▄▄▄▄▄▄▄█▌   ▄▄▄▄▄▄▄   ▐█▄▄▄▄▄▄▄▄▄▄▄▄    .»              
                          ▓▓█████████████▌  ▄  █████  ▄  ║█████████████▓▓█             
                           ▀█▄█▓█║╝▌╙████▌ ║▌ ▐▄ 0 ▄▌ ╙▌ └████▌▐▌██▌█▓█▀                  
                            ╙█▀▀██#█¢█ ▐█▄▓█║  █▄.▄█ ▌▀▓▄█▌ █▌╫▓██▀██∩                   
                                          █▀█▓▀▀███▀██▀█ ▀▌                       === КРЫЛАТЫЙ ДЕМОН
                                ╓        ▀▓▓█▓▄║█╓▓█▓▓▀▌                          === ЗДОРОВЬЕ - {demonHealth}
                                ╙█▄▄▄▄████▓█▀ ▀████▀ ▀▓█████▄▄▄▄█▌                === ВРАГ
                                  ║ ▐█ ▐▀     ██████     ▀▌▐█ ║                   === У НЕГО НЕТ СЛАБЫХ МЕСТ
                                  ║ ▐█ ▐   ▄▄▄██████▄▄▄   ▌▐█ ║                         
                                  ║ ▐█ ▐    ▐████████     ▌▐█ ║                    
                                  ║ ▐█ ▐     ║███████     ▌▐█ ║                  
                                  ║ ▐█ ▐     ▐██████▌     ▌▐█ ║                         
                                  ║ ▐█ ▐      ██████      ▌▐█ ║                        
                                  ║ ▐█ ▐       ████       ▌▐█ ║                           
                                  ║ ▐█ ▐       ████       ▌▐█ ║                        
                                              ██████                                     
                                              ▐████▌                                     
                                            ▄▓██████▓▄                                   
                                        ██████████████████
                                       ▐ █    ▄▄▄▄▄▄    █ ▌                            
                                       ▐▄▄    █:  :█    ▄▄▌
                                            ▐▀      ▀▌                                  
                                            ▐ ▄▄▄▄▄▄ ▌                                                                                                              

                      "); // КРЫЛАТЫЙ ДЕМОН - ФИНАЛЬНЫЙ БОСС

            Fight(ref demonHealth, 20);

            } while ((demonHealth > 0) && (health > 0)); // ФИНАЛЬНЫЙ БОСС
            if (demonHealth <= 0)
            {

                Console.WriteLine("===============================================================================================================================");
                Console.WriteLine("Вы одержали победу над финальным боссом и теперь сможете продолжить свое путешествие!");
                Console.WriteLine("===============================================================================================================================");
                Console.ReadKey();
                Environment.Exit(0);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("Вы проиграли эту битву! Начните сначала!");
                Console.ReadKey();
                Environment.Exit(0);
            } // ПРОИГРЫШ

        }
    }
}

