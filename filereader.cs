using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {

             Console.Clear();
             StreamReader reader = new StreamReader(@"C:\Practice\ApplicationLogs.txt");

             string str = String.Empty;

             while(reader.EndOfStream == false)
             {
                 str = reader.ReadLine();
                 Console.WriteLine(str);
             }

             reader.Close();
            Console.ReadLine();
        }
    }
}
