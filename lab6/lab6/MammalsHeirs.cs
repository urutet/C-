﻿using System;
using System.Collections.Generic;
namespace lab6
{
    public abstract class Animal
    {
        protected int position;
        private int yearOfBirth;
        public int YearOfBirth { get => yearOfBirth; set => yearOfBirth = value; }
        public abstract int move();
        bool isPredator;
        public bool IsPredator { get => isPredator; set => isPredator = value; }
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

    public class Mammals : Animal
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

    public partial class Lion
    {
        public override int move()
        {
            position += 1;
            Console.WriteLine($"Lion moved to {position}.");
            return position;
        }
    }

    public class YearCompare: IComparer<Animal>
    {
        public int Compare(Animal obj1, Animal obj2)
        {
            if (obj1.YearOfBirth > obj2.YearOfBirth)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
    }

    public class Zoo
    {
        List<Animal> zoo = new List<Animal>();
        public List<Animal> ZooGS { get => zoo; }

        public void Add(Animal obj)
        {
            zoo.Add(obj);
        }

        public Animal Remove(Animal obj)
        {
            foreach (Animal animal in zoo)
            {
                if (obj == animal)
                {
                    zoo.Remove(obj);
                    return obj;
                }
            }
            return null;
        }

        public void ShowList()
        {
            foreach(Animal animal in zoo)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
