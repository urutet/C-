using System;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = false;
            byte b8 = 240; //from 0 to 255
            char symbol = 'c';
            decimal dec = 3.14m; //30-dig precision
            double dub = 3.14;
            float fl = 2.314F;
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
            Console.ReadLine();

            //Nullable
            int? num = null; // упрощенная форма записи Nullable<T>
            Nullable<bool> flag1 = null; //могут иметь значение null

            //var experiment
            var num1 = 1; //после определения неявно типизированной переменной
                            //ее тип закрепляется за ней до конца существования
            //num1 = "c";

        }
    }
}
