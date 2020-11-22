using System;
using System.Collections.Generic;

namespace lab9
{
    class Program
    {
        public delegate void NameDelegate(string str);
        public delegate void FeatureDelegate(string str);

        static void Main(string[] args)
        {
            ProgrammerClass programmer = new ProgrammerClass();
            PLanguagesClass c = new PLanguagesClass();
            
            c.NewFeature += programmer.OnNewFeature;
            c.Rename += programmer.OnRename;

            NameDelegate nameDelegate = c.CommandRename;
            nameDelegate("C#");
            FeatureDelegate featureDelegate = c.CommandNewFeature;
            featureDelegate("no main");

            PLanguagesClass python = new PLanguagesClass();
            python.NewFeature += programmer.OnNewFeature;
            python.CommandNewFeature("New libraries");

            PLanguagesClass kotlin = new PLanguagesClass();
            kotlin.Rename += programmer.OnRename;
            kotlin.CommandRename("Project Kotlin");

            string str = "qwerty uiopa sdfgh. jkl; zxcvb: nm";
            Console.WriteLine($"Default string: {str}");

            Func<string, string> stringModification; //public delegate void Action<T>(T obj) возвращает void
            stringModification = StringFunctions.DeleteSpaces;
            stringModification += StringFunctions.UpperCase;
            string str1 = stringModification(str);
            Console.WriteLine(str1);
        }
    }
}