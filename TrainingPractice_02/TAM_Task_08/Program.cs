using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TAM_Task_08
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
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
    }
}