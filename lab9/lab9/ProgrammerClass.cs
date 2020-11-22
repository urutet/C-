using System;
namespace lab9
{
    public class ProgrammerClass
    {
        public ProgrammerClass()
        {
        }

        public void OnRename(object sender, EventArgs e)
        {
            Console.WriteLine("Language has been renamed!");
        }

        public void OnNewFeature(object sender, EventArgs e)
        {
            Console.WriteLine("New feature has been added!");
        }
    }

    public static class StringFunctions
    {
        public static string SymbolDelete(string str)
        { 
            return str.Trim(new char[] { ',', '.', '-', ':', ';' });
        }

        public static string SymbolAdd(string str)
        {
            Console.WriteLine("Enter string:");
            string ch = Console.ReadLine();
            return str.Insert(str.Length, ch);
        }

        public static string UpperCase(string str)
        {
            return str.ToUpper();
        }

        public static string LowerCase(string str)
        {
            return str.ToLower();
        }

        public static string DeleteSpaces(string str)
        {
            return str.Trim(' ');
        }
    }
}
