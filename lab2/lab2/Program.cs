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
            foreach (string v in splittedStr)
            {
                Console.WriteLine(v);
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


            while (true)
            {
                if (elementNum <= 6)
                {
                    Console.WriteLine("Enter the string you want to replace with");
                    string addedStr = Console.ReadLine();

                    strArray[elementNum - 1] = addedStr;
                    break;
                }
                else
                {
                    Console.WriteLine("Enter number less or equal 6");
                    elementNum = int.Parse(Console.ReadLine());
                    continue;
                }
            }


            for(int k = 0; k < strArrayLength; k++)
            {
                Console.Write($"{strArray[k]} ");
            }

            Console.WriteLine();

            int[][] jaggedArr = new int[3][];
            jaggedArr[0] = new int[] { 2, 3 };
            jaggedArr[1] = new int[] { 4, 5, 6 };
            jaggedArr[2] = new int[] { 7, 8, 9, 10 };

            for (int k = 0; k < jaggedArr.Length; k++)
            {
                switch (k)
                {
                    case 0:
                        for (int n = 0; n < jaggedArr[k].Length; n++)
                        {
                            Console.Write($"{jaggedArr[k][n]} ");
                        }
                        Console.WriteLine();
                        break;
                    case 1:
                        for (int n = 0; n < jaggedArr[k].Length; n++)
                        {
                            Console.Write($"{jaggedArr[k][n]} ");
                        }
                        Console.Write("\n");
                        break;
                    case 2:
                        for (int n = 0; n < jaggedArr[k].Length; n++)
                        {
                            Console.Write($"{jaggedArr[k][n]} ");
                        }
                        Console.Write("\n");
                        break;
                }
            }

            //var str & arr
            var undefStr = "Undef qwerty str";
            var undefArr = new[] { 4, 5, 6 };

            Console.WriteLine(undefStr);

            foreach (var f in undefArr)
            {
                Console.Write($"{f}");
            }

            //кортежи tuple
            (int, string, char, string, ulong) tuple = (215, "qwertized", 'c', "Elijah", 514124812);

            Console.WriteLine($"{tuple.Item1}, {tuple.Item2}, {tuple.Item3}, {tuple.Item4}, {tuple.Item5} ");
            Console.WriteLine($"{tuple.Item1}, {tuple.Item3}, {tuple.Item4}");

            //является ли распаковкой, если не из var?
            int x = tuple.Item1;
            string s = tuple.Item2;
            char ch = tuple.Item3;
            string unpackedStr = tuple.Item4;
            ulong uln = tuple.Item5;

            (int TupInt, string TupStr, char TupCh, string TupStr1, ulong TupLong) = tuple;

            (int, string, char, string, ulong) tuple1 = (4214, "ASDAF", 's', "Elijah", 218414);

            (TupInt, _, _, _, TupLong) = tuple1;

            if(tuple.Equals(tuple1))
            {
                Console.WriteLine("Кортежи равны");
            }
            else
            {
                Console.WriteLine("Кортежи не равны");
            }

            //functions

            (int, int, int, char) firstFunc(int[] intArr, string newStr)
            {
                int max = 0;
                int min = 99;
                int sum = 0;
                for(int i = 0; i < intArr.Length; i++)
                {
                    sum += intArr[i];
                    if (intArr[i] <= min)
                    {
                        min = intArr[i];
                    }
                    if (intArr[i] >= max)
                    {
                        max = intArr[i];
                    }
                }

                (int, int, int, char) tuple = (max, min, sum, newStr[0]);
                return tuple;
            }

            int[] funcArr = new int[]{ 3, 4, 5, 6, 7, 8, 9, 10 };
            string funcStr = "qwertized";
            (int, int, int, char) funcTuple = firstFunc(funcArr, funcStr);

            Console.WriteLine($"{funcTuple.Item1}, {funcTuple.Item2}, {funcTuple.Item3}, {funcTuple.Item4}");

            int checkedFunc()
            {
                checked
                {
                    int maxCheckedInt = 2147483647;
                    return maxCheckedInt; // выдает ошибку при ++

                }
            }

            int uncheckedFunc()
            {
                unchecked
                {
                    int maxUncheckedInt = 2147483647;
                    return maxUncheckedInt; //выдает отрицательное число при ++
                }
                
            }

            Console.WriteLine(checkedFunc());
            Console.WriteLine(uncheckedFunc());


        }
    }
}

