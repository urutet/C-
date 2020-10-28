using System;
namespace lab5
{
    public abstract class Animal
    {
        protected int position;
        public abstract int move();
        public virtual void eat()
        {
            Console.WriteLine("Animal eats.");
        }
        public abstract void sleep();
        public abstract void a_method();
    }

    public interface IAnimal
    {
        int move();
        void eat();
        void sleep();
        void hunt()
        {
            Console.WriteLine("Animal hunts");
        }
        void a_method();

    }

    public class Mammals: Animal
    {
        public override void eat()
        {
            Console.WriteLine("Mammal drinks milk.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Mammal moved to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"Mammal sleeps.");
        }

        public override void a_method()
        {

        }

        public override string ToString()
        {
            return @$"Info:
                    Position: {position}
                    Object type: Mammals";
        }

    }

    public class Bird : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Birds eat breadcrumbs and drink water.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Bird moved to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"Bird sleeps.");
        }

        public override void a_method()
        {

        }
    }

    public class Fish : Animal
    {
        public override void eat()
        {
            Console.WriteLine("Fish eats dunno what.");
        }

        public override int move()
        {
            position += 1;
            Console.WriteLine($"Fish moved to {position}.");
            return position;
        }

        public override void sleep()
        {
            Console.WriteLine($"Fish sleeps.");
        }

        public override void a_method()
        {

        }
    }
}
