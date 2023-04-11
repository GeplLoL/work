using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            string nimi = "Python";
            Class2.Tere(nimi);
            float a = 10;
            float b = 20;
            int n = 3;
            char z = '/';
            float vastus = Class2.Korruta(a, b, n);
            float vastuCalc = Class2.Calc(a, b, z);
            Console.WriteLine(vastuCalc);
            Console.WriteLine(vastus);
            Class2.Zvezd();
            /*
            Random rnd = new Random();
            int n = rnd.Next(-100, 100);
            int m = rnd.Next(-100, 100);
            Console.WriteLine(n + "," + m);
            int[] arr = new int[0];
            if (n > m)
            {
                while (n != m)
                {
                    m++;
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = m;
                    Console.WriteLine(m * m);
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            else if (m > n)
            {
                while (m != n)
                {
                    n++;
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = n;
                    Console.WriteLine(n*n);
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i] + " ");
                }
            }
            int sumAR = 0;
            int[] arrNum = new int[0];
            for (int i = 1; i < 5; i++)
            {
                int num = int.Parse(Console.ReadLine());
                Array.Resize(ref arrNum, arrNum.Length + 1);
                arrNum[arrNum.Length - 1] = num;
            for (int j = 2; j < 5; j++)
            {
                sumAR = arrNum[i] + arrNum[j];
            }
            Console.WriteLine(sumAR);
            }*/
        }
    }
}
