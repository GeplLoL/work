using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class2
    {
        public static void Tere(string name) 
        {
            Console.WriteLine("Tere {0}", name);
        }
        public static float Korruta(float arv1, float arv2, int n)
        {
            return (arv1 + arv2)/n;
        }
        public static float Calc(float arv1, float arv2, char znak)
        {
            float vastus = 0;
            if (znak=='+')
            {
                vastus = arv1 + arv2;
            }
            else if (znak=='-')
            {
                vastus = arv1 - arv2;
            }
            else if (znak=='*')
            {
                vastus = arv1 * arv2;
            }
            else if (znak=='/')
            {
                vastus=arv1 / arv2;
                if (vastus==0)
                {
                    Console.WriteLine("error");
                }
            }
            for (int i = 0; i < Math.Abs(vastus); i++)
            {
                Console.Write("nurr ");
            }
            Console.WriteLine();
            return vastus;
        }
        public static void Zvezd()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                int n = int.Parse(Console.ReadLine());
                for (int j = 0; j < n; j++)
                    {
                        Console.Write('*');
                    }
            }
        }
    }
}
