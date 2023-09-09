using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {



            List<Products> prodList = new List<Products>()
            {
                new Products() {ProductId = int.Parse(Console.ReadLine()), ProductName = Console.ReadLine(), Price = int.Parse(Console.ReadLine()), Quantity = int.Parse(Console.ReadLine())},
                new Products() {ProductId = int.Parse(Console.ReadLine()), ProductName = Console.ReadLine(), Price = int.Parse(Console.ReadLine()), Quantity = int.Parse(Console.ReadLine())},
                new Products() {ProductId = int.Parse(Console.ReadLine()), ProductName = Console.ReadLine(), Price = int.Parse(Console.ReadLine()), Quantity = int.Parse(Console.ReadLine())},
                new Products() {ProductId = int.Parse(Console.ReadLine()), ProductName = Console.ReadLine(), Price = int.Parse(Console.ReadLine()), Quantity = int.Parse(Console.ReadLine())},
                new Products() {ProductId = int.Parse(Console.ReadLine()), ProductName = Console.ReadLine(), Price = int.Parse(Console.ReadLine()), Quantity = int.Parse(Console.ReadLine())}
            };



            Console.WriteLine("-------------------------");

            foreach(Products pr in prodList)
            {
                Console.WriteLine(pr);
            }

            Console.WriteLine("--------------------------");


            Console.WriteLine("Enter product name: ");

            string search = Console.ReadLine();

             int index = -1;

             for(int i = 0; i < prodList.Count; i++)
             {
                 if (prodList[i].ProductName == search)
                 {
                     index = i; break;
                 }
             }

            if (index >= 0)
            {
                prodList.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Invalid product name");
            }

            Console.WriteLine("UPDATED LIST :");
            Console.WriteLine("-----------------------");

             foreach (Products pr in prodList)
             {
                 Console.WriteLine(pr);
             }

             Console.ReadLine();
        }
    }

    class Products
    {

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            string str = string.Format("{0},{1},{2},{3}", ProductId, ProductName, Price, Quantity);
            return str;

        }
    }

    
}
