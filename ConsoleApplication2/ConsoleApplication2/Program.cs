using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace lab2
{

    class Program
    {

        public bool isPrime(int a)
        {

            for (int i = 2; i * i <= a; i++)

                if (a % i == 0) return false;

            return true;

        }

        static void Main(string[] args)
        {

            string text = System.IO.File.ReadAllText(@"C:\Users\Ilyas K\Desktop\a.txt.txt");

            string[] ss = text.Split();

            Console.WriteLine(text);

            Console.ReadKey();

            int[] numbers = new int[ss.Length];

            for (int i = 0; i < ss.Length; i++)
            {

                numbers[i] = int.Parse(ss[i]);

            }

            int maxi = numbers.Max(), mini = numbers.Min();

            int minPrime = numbers[0];

            Program p = new Program();

            for (int i = 0; i < numbers.Length; i++)
            {

                if (p.isPrime(numbers[i]))
                {

                    if (minPrime > numbers[i])
                    {

                        minPrime = numbers[i];

                    }

                }

            }

            string text2 = text + "nextline " + maxi.ToString() + " " + mini.ToString() + " " + minPrime.ToString();

            System.IO.File.WriteAllText(@"C:\Users\Ilyas K\Desktop\a.txt.txt", text2);

        }
        
    }

}