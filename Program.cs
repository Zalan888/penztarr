using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace penztarr
{
    internal class Program
    {
        public static int[] notes = new int[6] { 500, 1000, 2000, 5000, 10000, 20000 };
        public static int[] money = new int[6];

        public static void input()
        {
            for (int i = 0; i < notes.Length; i++)
            {
                Console.WriteLine($"Kérem adja meg a {notes[i]}-asok számát!");
                money[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void Main(string[] args)
        {
            input();
        }
    }
}
