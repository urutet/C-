using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Diagnostics;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logs = new Logger(); //Logger

            Lion lion1 = new Lion();
            Tiger tiger1 = new Tiger();
            NewClass newClass1 = new NewClass();
            Croc croc1 = new Croc();
            Parrot parrot1 = new Parrot();
            parrot1.IsPredator = false;
            parrot1.YearOfBirth = 1993;
            Owl owl1 = new Owl();
            owl1.IsPredator = true;
            owl1.YearOfBirth = 2013;

            Console.WriteLine("Croc can{0} be converted to object", (croc1 is Object) ? "" : "not");
            Console.WriteLine("Croc can{0} be converted to ValueType", (croc1 is ValueType) ? "" : "not"); //is - проверка на конвертацию

            Mammals mammal1 = new Mammals();
            Lion pLion = mammal1 as Lion;
            Console.WriteLine("Mammals to Lion conversion is {0} completed", (pLion != null) ? "" : "not"); //as - конвертация

            Mammals pTiger = tiger1 as Mammals;
            Console.WriteLine("Tiger to mammals conversion is {0} completed", (pTiger != null) ? "" : "not"); //as - конвертация
            Console.WriteLine(pTiger); //после переопределения ToString выводит info

            Console.WriteLine(lion1.ToString());

            Print print1 = new Print();
            Mammals[] mammalsArr = new Mammals[] { lion1, tiger1 };
            foreach (var s in mammalsArr)
            {
                print1.IAmPrinting(s);
                Console.WriteLine();
            }

            NewClass new1 = new NewClass();
            ((IAnimal)new1).a_method();
            new1.a_method();

            Smth struct1;
            struct1.smth = "Smth";
            Console.WriteLine(struct1.smth);
            Smth.Month month1;
            month1 = Smth.Month.January;
            Console.Write(month1 + " ");
            Console.WriteLine((int)month1);


            Zoo zoo1 = new Zoo();
            tiger1.YearOfBirth = 2001;
            zoo1.Add(tiger1);
            zoo1.Add(lion1);
            zoo1.Add(owl1);
            zoo1.Add(parrot1);
            zoo1.ShowList();
            zoo1.Remove(tiger1);

            ZooController yearCmp = new ZooController();
            zoo1.ZooGS.Sort(yearCmp);
            Console.WriteLine("After sorting");
            zoo1.ShowList();
            /*var sortedList = from animal in zoo1.ZooGS
                             orderby animal.YearOfBirth descending
                             select animal;

            foreach(Animal animal in zoo1.ZooGS)
            {
                Console.WriteLine(animal);
            }*/


            //ADDITIONAL TASKS
            Console.WriteLine("Read from txt");
            string path = @"/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab6/lab6.";
            try
            {
                List<Animal> collection = ZooController.ReadFile(path);
                foreach (Animal i in collection)
                {
                    Console.WriteLine(i);
                }
            }
            catch (FileCannotBeFoundException e)
            {
                Console.WriteLine(e.Message);               //Exception 1
                logs.AddException(e);
            }


            Console.WriteLine("Read from JSON \n");
            string path1 = @"/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab6/lab6.json";
            using (StreamReader sr = new StreamReader(path1))
            {
                string file = sr.ReadToEnd();
                try
                {
                    Mammals animal2 = JsonConvert.DeserializeObject<Mammals>(file);
                    Console.WriteLine(animal2);
                }
                catch (JsonSerializationException e)
                {
                    Console.WriteLine(e.Message);               //Exception 2
                    logs.AddException(e);
                }
            }

            //Lab7
            Tiger tiger2 = new Tiger();
            Console.WriteLine("Enter tiger's age: ");
            try
            {
                tiger2.YearOfBirth = Convert.ToInt32(Console.ReadLine());
                if (tiger2.YearOfBirth == 0)
                {
                    throw new InvalidNumberException("Invalid year of birth", tiger2.YearOfBirth);
                }
            }
            catch (InvalidNumberException e)
            {
                Console.WriteLine(e.Message);
                tiger2.YearOfBirth = 2001;                                              //Exception 3
                Console.WriteLine($"Year of birth set to default: {tiger2.YearOfBirth}");
                logs.AddException(e);
            }

            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Enter the number of element: ");
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                if (i >= 5)
                {
                    throw new IndexOutOfRangeException("Index out of range");           //Exception 4
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                logs.AddException(e);
            }


            Console.WriteLine("Enter password: ");
            try
            {
                string password = Console.ReadLine();
                foreach (char ch in password)
                {
                    if (ch == '!' || ch == '$' || ch == '#' || ch == '#' || ch == 'ˆ')
                    {
                        throw new InvalidSymbolException($"Invalid symbol {ch} entered");       //Exception 5
                    }
                }
            }
            catch (InvalidSymbolException e)
            {
                Console.WriteLine(e.Message);
                logs.AddException(e);

            }
            catch
            {
                Console.WriteLine("Unhandled exceptions...");
            }
            finally
            {
                Console.WriteLine("Program is sleeping...");
                System.Threading.Thread.Sleep(1000);
            }

            Debug.Assert(true, "Program finished."); //outputs stack if the condition is false
                                                     //works only in debug builds

            //ADDITIONAL TASK (Logger)
            string loggerFilePath = @"/Users/elijah/БГТУ/2 Курс/ООП/Лабораторные работы/Лабораторная работа 1/C-/lab7/lab7.txt";

            logs.LogToFile(loggerFilePath);
        }
    }
}
