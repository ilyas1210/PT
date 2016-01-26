using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo()
            int cnt = Search(d);
            Console.WriteLine(cnt);
            Console.ReadKey();
        }
    static int Search(DirectoryInfo d);
    {
        fileinfo[] Files = d.GetFiles();
        int cnt_files = files.Length; 
        return cnt_files;
    }
    }

}
