using System;

namespace lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Assembly Name");
            System.Console.WriteLine(Reflector.AssemblyName(typeof(PLanguagesClass)));
            Console.WriteLine();
            Console.WriteLine("Methods with string param");
            foreach (var s in Reflector.GetMethodsWithParam(typeof(PLanguagesClass), typeof(string)))
            {
                System.Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Public methods");
            foreach (var s in Reflector.GetPublicMethods(typeof(Logger)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Fields and properties");
            foreach (var s in Reflector.GetFieldsAndProperties(typeof(Logger)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Has public containers");
            Console.WriteLine(Reflector.HasPublicContainers(typeof(PLanguagesClass)));
            Console.WriteLine();

            Console.WriteLine("Interfaces");
            foreach (var s in Reflector.GetInterfaces(typeof(PLanguagesClass)))
            {
                Console.WriteLine(s);
            }
            Console.WriteLine();

            Console.WriteLine("Invoke");
            Console.WriteLine(Reflector.Invoke(typeof(PLanguagesClass), "CommandRename", "/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab12/lab12/s.txt"));
        }
    }
}
