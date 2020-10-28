using System;

namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion lion1 = new Lion();
            Tiger tiger1 = new Tiger();
            NewClass newClass1 = new NewClass();
            Croc croc1 = new Croc();

            Console.WriteLine("Croc can{0} be converted to object", (croc1 is Object)? "": "not");
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
            foreach(var s in mammalsArr)
            {
                print1.IAmPrinting(s);
                Console.WriteLine();
            }
        }
    }
}
