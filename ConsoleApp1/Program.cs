using System.Diagnostics;
namespace ConsoleLepexa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Piano = new int[] { };
            ConsoleKeyInfo pkey = Console.ReadKey();
            Console.WriteLine("3 Октава");
            while (pkey.Key != ConsoleKey.Escape)
            {
                pkey = Console.ReadKey();
                if (pkey.Key == ConsoleKey.F1)
                {
                    Piano = new int[12] { 131, 139, 147, 156, 165, 175, 185, 196, 208, 220, 233, 247 };
                    Console.WriteLine("3 Октава");
                }
                else if (pkey.Key == ConsoleKey.F2)
                {
                    Piano = new int[12] { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494 };
                    Console.WriteLine("4 Октава");
                }
                else if (pkey.Key == ConsoleKey.F3)
                {
                    Piano = new int[12] { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988 };
                    Console.WriteLine("5 Октава");
                }
                else if (pkey.Key == ConsoleKey.Q)
                    Console.Beep(Piano[0], 100);
                else if (pkey.Key == ConsoleKey.W)
                    Console.Beep(Piano[1], 100);
                else if (pkey.Key == ConsoleKey.E)
                    Console.Beep(Piano[2], 100);
                else if (pkey.Key == ConsoleKey.R)
                    Console.Beep(Piano[3], 100);
                else if (pkey.Key == ConsoleKey.T)
                    Console.Beep(Piano[4], 100);
                else if (pkey.Key == ConsoleKey.Y)
                    Console.Beep(Piano[5], 100);
                else if (pkey.Key == ConsoleKey.U)
                    Console.Beep(Piano[6], 100);
                else if (pkey.Key == ConsoleKey.I)
                    Console.Beep(Piano[7], 100);
                else if (pkey.Key == ConsoleKey.O)
                    Console.Beep(Piano[8], 100);
                else if (pkey.Key == ConsoleKey.P)
                    Console.Beep(Piano[9], 100);
                else if (pkey.Key == ConsoleKey.Oem4)
                    Console.Beep(Piano[10], 100);
                else if (pkey.Key == ConsoleKey.Oem6)
                    Console.Beep(Piano[11], 100);
            }
        }
    }
}