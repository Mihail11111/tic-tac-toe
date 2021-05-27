using System;

namespace Крестики_нолики_оригинал
{
    class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int choise;
        static int player = 1;
        static int flag = 0;
        static void Field()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
        private static int Winner()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        public static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                if (player % 2 == 1)
                {
                    Console.WriteLine("Ходят X");
                }
                else
                {
                    Console.WriteLine("Ходят O");
                }
                Console.WriteLine("\n");
                Field();
                choise = int.Parse(Console.ReadLine());
                if (arr[choise] != 'X' && arr[choise] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        arr[choise] = 'O';
                        player++;
                    }
                    else
                    {
                        arr[choise] = 'X';
                        player++;
                    }
                }
                flag = Winner();
            }
            while (flag != 1 && flag != -1) ;
            Console.Clear();
            Field();
            if (flag == 1)
            {
                Console.WriteLine("Победил игрок:{0}", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Ничья");
            }
            Console.ReadLine();
        }
    }
}
