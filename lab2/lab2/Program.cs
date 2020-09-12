using System;
using System.Text; //Stringbuilder

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            byte b8 = 240; //from 0 to 255
            sbyte jb8ed = 127; //-128 to 127
            char symbol = 'c';
            decimal dec = 3.14m; //30-dig precision
            double dub = 3.14;
            float fl = 3.14F;
            int i = 3;
            uint ui = 4294000000; //unsigned from 0 to 4,294,967,295
            long lng = -340000000001234;
            ulong ulng = 53241241242314; //unsigned
            short shrt = 31000;
            ushort ushrt = 0;


            //неявные преобразования
            long convi = i;
            short convb8 = b8;
            double convfl = fl;
            float convui = ui;
            decimal convdec = dec;

            //явные преобразования
            int convertedDub = (int)dub;
            float convertedCh = (float)symbol;
            int convertedChar = (int)symbol;
            double convertedShort = (double)shrt;
            decimal convertedUshrt = (decimal)ushrt;

            //Convert class
            bool convertedLong = Convert.ToBoolean(lng);

            //упаковка и распаковка
            Object flagObj = flag;
            bool flag2 = (bool)flagObj;

            //Неявная типизация
            var number = 123456;
            Console.WriteLine("Number type: {0}", number.GetType());
            

            //Nullable
            int? num = null; // упрощенная форма записи Nullable<T>
            Nullable<bool> flag1 = null; //могут иметь значение null

            //var experiment
            var num1 = "1"; //после определения неявно типизированной переменной
                            //ее тип закрепляется за ней до конца существования
                            //num1 = "1";
            

            //СТРОКИ
            string str1 = "Hello", str2 = ", ", str3 = "World.";
             
            if (string.Compare(str1, str3) == 0)
            {
                Console.WriteLine("Strings are identical");
            }
            else
            {
                Console.WriteLine("Strings aren't identical");
            }

            string str = str1 + str2 + str3; //сцепка строк
            Console.WriteLine(str);

            string interStr = $"{str} Another sentence."; //интерполяция строк
            Console.WriteLine(interStr);

            string substr = interStr.Substring(3); //принимает начальный индекс
            Console.WriteLine(substr);

            string[] splittedStr = interStr.Split(" "); //разбиение и вывод слов в строке
            foreach (string s in splittedStr)
            {
                Console.WriteLine(s);
            }

            //вставка подстроки (позиция, текст)
            string substrInsert = substr.Insert(0, "Substring inserted ");
            Console.WriteLine(substrInsert);

            //удаление подстроки
            string substrDelete = substrInsert.Remove(5, 10);
            Console.WriteLine(substrDelete);

            //пустая строка
            string emptyStr = String.Empty;

            //null строка
            string nullStr = null;

            //проверка на пустую строку
            if (String.IsNullOrEmpty(emptyStr))
            {
                Console.WriteLine("String \"emptyStr\" is Null or empty");
            }
            else
            {
                Console.WriteLine("String isn't empty");
            }


            if (String.IsNullOrEmpty(nullStr))
            {
                Console.WriteLine("String \"nullStr\" is Null or empty");
            }
            else
            {
                Console.WriteLine("String isn't empty");
            }


            //Stringbuilder
            StringBuilder builtStr = new StringBuilder("qwerty", 50);

            builtStr.Append(new char[] { 'A', 'B', 'C' });
            builtStr.Insert(0, " ElijahNoCaptainElijah");
            builtStr.Remove(5, 3);

            Console.WriteLine(builtStr);

            //массивы
            int[,] matrix = new int[,] { { 1, 2 }, { 3, 4 } };

            for (int k = 0; k < 2; k++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"{matrix[k, j]} \t");
                }
                Console.WriteLine();
            }


            //массив строк
            string[] strArray = new string[] { "q", "w", "e", "r", "t", "y" };
            int strArrayLength = strArray.GetLength(0);
            for (int k = 0; k<strArrayLength; k++)
            {
                Console.Write($"{strArray[k]}");
            }

       
            Console.WriteLine($"\nString array length: {strArrayLength}");

            
            Console.WriteLine("Enter the number of the element (up to 6): ");
            int elementNum = int.Parse(Console.ReadLine()); //Как без парсинга?

            while (elementNum > 6)
            {
                if (elementNum <= 6)
                {
                    Console.WriteLine("Enter the string you want to replace with");
                    string addedStr = Console.ReadLine();
                    strArray[elementNum] = addedStr;
                }
                else
                {
                    Console.WriteLine("Enter number less or equal 6");
                    elementNum = int.Parse(Console.ReadLine());
                    continue;
                }
            }

        }
    }
}