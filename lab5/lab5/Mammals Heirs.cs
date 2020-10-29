using System;

namespace lab5
{
    public class Lion: Mammals, IAnimal
    {
        public Lion() { }
        public override void eat()
        {
            Console.WriteLine("Lion drinks milk.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Lion moved to {position}.");
            return position;
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
                    Object type: Lion";
        }
    }

    public class Tiger : Mammals, IAnimal
    {
        public Tiger() { }
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
    }

    public class Owl: Bird, IAnimal
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

    public sealed class Parrot: Bird
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
    }

    //public class AnotherTypeOfParrot: Parrot { } Попугай запечатан, поэтоиу невозможно создать производный класс

    public class NewClass: Animal, IAnimal
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
