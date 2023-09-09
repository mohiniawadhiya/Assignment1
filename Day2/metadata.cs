using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
           static void Main()
        {
            // Declaring and initializing object of Type
            Type objType = typeof(Student);

            // try-catch block for handling Exception
            try
            {

                // Getting array of Method by
                // using GetMethods() Method
                MethodInfo[] info = objType.GetMethods(BindingFlags.Public | BindingFlags.Instance);

                // Display the Result
                Console.WriteLine("Methods of current type is as Follow: ");
                for (int i = 0; i < info.Length; i++)
                    Console.WriteLine(" {0}", info[i]);
            }

            // catch ArgumentNullException here
            catch (ArgumentNullException e)
            {
                Console.Write("name is null.");
                Console.Write("Exception Thrown: ");
                Console.Write("{0}", e.GetType(), e.Message);
            }

            Console.ReadLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public string Subject { get; set; }

        public void printName()
        {
            Console.WriteLine(" " + Name + " ");
        }

        public void printSubject()
        {
            Console.WriteLine(" " + Subject + " ");
        }

        public void printRoll()
        {
            Console.WriteLine(" " + RollNo + " ");
        }
    }
}
