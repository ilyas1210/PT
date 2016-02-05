using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s; //числа вводим
            s = Console.ReadLine(); //chitaet chisla
            string[] stringNumbers = s.Split();// delim ih na raznie
            foreach (string ss in stringNumbers) // probegaemsya po stringu
            {
                int a= Int32.Parse(ss); //perevodim iz stringa v integer form
                bool ok = true; 
                for (int i = 2; i<a; i++) //uslovie prostogo chisla
                {
                    if (a % i == 0) ok = false; //esli delitsya na drugie chisla to false
                }
                if (ok == true) // dlya vseh ostalnih znachenie istionoe 
                    Console.WriteLine(a);
            }
            Console.ReadKey();
        }
        


    }
}
