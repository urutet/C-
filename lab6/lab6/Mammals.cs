﻿using System;

namespace lab6
{
    struct Smth
    {
        public string name;
        public int age;
        public string smth;
        public enum Month
        {
            January = 1,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }
    }

    public partial class Lion : Mammals, IAnimal
    {
        public Lion(){}
        public Lion(int pos, int yob, bool isPred)
        {
            position = pos;
            YearOfBirth = yob;
            IsPredator = isPred;
        }
        public override void eat()
        {
            Console.WriteLine("Lion drinks milk.");
        }

        public override void sleep()
        {
            Console.WriteLine($"Lion sleeps.");
        }

        public void hunt()
        {
            Console.WriteLine("Hunt in progress...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Hunt complete!");
        }

        public override string ToString()
        {
            return @$"Info:
                    Position: {position}
                    Date of birth: {YearOfBirth}
                    Object type: Lion";
        }
    }

    public class Tiger : Mammals, IAnimal
    {
        public Tiger() { }
        public Tiger(int pos, int yob, bool isPred)
        {
            position = pos;
            YearOfBirth = yob;
            IsPredator = isPred;
        }
        public override void eat()
        {
            Console.WriteLine("Tiger drinks milk.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Tiger moved to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"Tiger sleeps.");
        }

        public void hunt()
        {
            Console.WriteLine("Hunt in progress...");
            System.Threading.Thread.Sleep(1000); //наохотился и спит
            Console.WriteLine("Hunt complete!");
        }

        public override string ToString()
        {
            return @$"Info:
                    Position: {position}
                    Date of birth: {YearOfBirth}
                    Object type: Tiger";
        }
    }

    public class Owl : Bird, IAnimal
    {
        public Owl() { }
        public override void eat()
        {
            Console.WriteLine("Owl eats insects.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Owl moved to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"OWL'S WATCHIN YA.");
        }

        public void hunt()
        {
            Console.WriteLine("Hunt in progress...");
            System.Threading.Thread.Sleep(1000); //наохотился и спит
            Console.WriteLine("Hunt complete!");
        }

        public override string ToString()
        {
            return @$"Info:
                    Position: {position}
                    Date of birth: {YearOfBirth}
                    Predator: {IsPredator}
                    Object type: Owl";
        }
    }

    public class Croc : IAnimal
    {
        int position;
        public Croc() { }
        public void eat()
        {
            Console.WriteLine("Owl eats insects.");
        }

        public int move()
        {
            position += 1;
            Console.WriteLine($"Owl moved to {position}.");
            return position;
        }

        public void sleep()
        {
            Console.WriteLine($"OWL'S WATCHIN YA.");
        }

        public void hunt()
        {
            Console.WriteLine("Hunt in progress...");
            System.Threading.Thread.Sleep(1000); //наохотился и спит
            Console.WriteLine("Hunt complete!");
        }

        public void a_method()
        {
            Console.WriteLine("a_method worked.");
        }
    }

    public class Shark : Fish
    {
        public Shark() { }
        public override void eat()
        {
            Console.WriteLine("Shark eats fish.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Shark moved to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"Shark sleeps.");
        }

        public void hunt()
        {
            Console.WriteLine("Hunt in progress...");
            System.Threading.Thread.Sleep(1000); //наохотился и спит
            Console.WriteLine("Hunt complete!");
        }
    }

    public sealed class Parrot : Bird
    {
        public Parrot() { }
        public override void eat()
        {
            Console.WriteLine("Parrot eat breadcrumbs and drink water.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Parrot flies to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"Parrot sleeps.");
        }

        public void hunt()
        {
            Console.WriteLine("Hunt in progress...");
            System.Threading.Thread.Sleep(1000); //наохотился и спит
            Console.WriteLine("Hunt complete!");
        }

        public override string ToString()
        {
            return @$"Info:
                    Position: {position}
                    Date of birth: {YearOfBirth}
                    Predator: {IsPredator}
                    Object type: Parrot";
        }
    }

    //public class AnotherTypeOfParrot: Parrot { } Попугай запечатан, поэтоиу невозможно создать производный класс

    public class NewClass : Animal, IAnimal
    {
        public NewClass() { }
        public override void eat()
        {
            Console.WriteLine("Parrot eat breadcrumbs and drink water.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Parrot flies to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"Parrot sleeps.");
        }

        public void hunt()
        {
            Console.WriteLine("Hunt in progress...");
            System.Threading.Thread.Sleep(1000); //наохотился и спит
            Console.WriteLine("Hunt complete!");
        }

        void IAnimal.a_method()
        {
            Console.WriteLine("Ianimal.a_method worked.");
        }

        public override void a_method()
        {
            Console.WriteLine("Animal.a_method worked.");

        }
    }

    public class Print
    {
        public void IAmPrinting(Animal obj)
        {
            Console.WriteLine(obj.ToString());
        }
    }
}
