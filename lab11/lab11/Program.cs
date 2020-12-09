using System;
using System.Linq;
using System.Collections.Generic;
namespace lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] months = { "January", "February", "March", "April", "May", "June",
                "July", "August", "September", "October", "November", "December" };

            Console.WriteLine("Enter the length of the months");
            int n = System.Convert.ToInt32(Console.ReadLine());

            var monthsWithNLetters = from m in months
                                     where m.Length == n
                                     select m;

            if (monthsWithNLetters == null)
            {
                Console.WriteLine($"There are no months with {n} letters.");
            }
            else
            {
                Console.WriteLine($"Months with {n} letters:");
                foreach (var m in monthsWithNLetters)
                {
                    Console.WriteLine(m);
                }
                Console.WriteLine();
            }

            var selectedSummerMonths = months.Where(m => m == "June" || m == "July" || m == "August");

            Console.WriteLine("Summer months: ");

            foreach(var m in selectedSummerMonths)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            var selectedWinterMonths = months.Where(m => m == "December" || m == "January" || m == "February");

            Console.WriteLine("Winter months: ");

            foreach (var m in selectedWinterMonths)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            var alphabeticMonths = from m in months
                                   orderby m
                                   select m;

            Console.WriteLine("Months in ascending order:");

            foreach(var m in alphabeticMonths)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            var monthsWithULessThanFour = from m in months
                                          where m.Contains('u') && m.Length <= 4
                                          select m;

            Console.WriteLine("Months with \"u\" and less than 4 symbols long: ");

            foreach(var m in months)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            List<Stack> listOfStacks = new List<Stack>();

            Stack stack1 = new Stack();
            stack1.Push(1);
            stack1.Push(-1);
            Stack stack2 = new Stack();
            stack2.Push(3);
            stack2.Push(0);
            Stack stack3 = new Stack();
            stack3.Push(10);
            stack3.Push(-5);
            Stack stack4 = new Stack();
            stack4.Push(7);
            stack4.Push(12);
            Stack stack5 = new Stack();
            stack5.Push(1);
            stack5.Push(-1);
            Stack stack6 = new Stack();
            stack6.Push(15);
            stack6.Push(-2);
            stack6.Push(11);
            stack6.Push(13);
            Stack stack7 = new Stack();
            stack7.Push(3);
            stack7.Push(-14);
            Stack stack8 = new Stack();
            stack8.Push(15);

            listOfStacks.Add(stack1);
            listOfStacks.Add(stack2);
            listOfStacks.Add(stack3);
            listOfStacks.Add(stack4);
            listOfStacks.Add(stack5);
            listOfStacks.Add(stack6);
            listOfStacks.Add(stack7);
            listOfStacks.Add(stack8);

            var stackWithMinTop = listOfStacks.Where(stack => stack.Peek() == listOfStacks.Select(stack => stack.Peek()).Min());
            Console.WriteLine("Stack with the lowest number on top");
            foreach(var stack in stackWithMinTop)
            {
                Console.WriteLine(stack);
            }

            var stackWithMaxTop = listOfStacks.Where(stack => stack.Peek() == listOfStacks.Select(stack => stack.Peek()).Max());

            Console.WriteLine("Stack with the highest number on top");
            foreach (var stack in stackWithMaxTop)
            {
                Console.WriteLine(stack);
            }

            var stacksWithNegativeItems = from stack in listOfStacks
                                          where stack.HasNegativeItems() == true
                                          select stack;
            Console.WriteLine();

            Console.WriteLine("Stacks with negative numbers: ");
            foreach(var stack in stacksWithNegativeItems)
            {
                Console.WriteLine(stack);
            }
            Console.WriteLine();
                
            Console.WriteLine("Stack with minimum amount of numbers: ");
            var minStack = listOfStacks.Where(stack => stack.Count == listOfStacks.Select(stack => stack.Count).Min());
            foreach (var stack in minStack)
            {
                Console.WriteLine(stack);
            }

            Console.WriteLine();

            Console.WriteLine("Stack with [1-3] length: ");
            var lengthEquals1To3 = listOfStacks.Where(stack => stack.Count >= 1 && stack.Count <= 3);
            foreach (var stack in lengthEquals1To3)
            {
                Console.WriteLine(stack);
            }
            Console.WriteLine();

            Console.WriteLine("First stack with 0: ");
            var firstStackWith0 = listOfStacks.Where(stack => stack.HasZeros()).First();
            Console.WriteLine(firstStackWith0);
            Console.WriteLine();

            Console.WriteLine("Stacks ascending sort depending on sum: ");
            var ascendingSort = listOfStacks.OrderBy(stack => stack.StackSum);
            foreach (var stack in ascendingSort)
            {
                Console.WriteLine(stack);
            }
            Console.WriteLine();

            Console.WriteLine("Months selected with 5 different operators: ");
            var someMonths = months.Where(m => m.Length >= 3).Select(m => m).Skip(1).Intersect(months.Where(m => m.Contains("u")));
            foreach(var m in someMonths)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            Console.WriteLine("Join operator: ");
            Organization org1 = new Organization("Qwerty");
            Organization org2 = new Organization("Asdfgh");
            Organization org3 = new Organization("Zxcvbn");
            Organization[] organizations = new Organization[] { org1, org2, org3 };

            Concert[] concerts = new Concert[] { new Concert("Concert 1", org1), new Concert("Concert 2", org2),
                new Concert("Concert 3", org3) };

            var allConcerts = organizations.Join(concerts, organization => organization, concert => concert.org,
                (organization, concert) => new { orgName = organization.Name, concertName = concert.Name });

            foreach(var c in allConcerts)
            {
                Console.WriteLine($"Organization: {c.orgName}, Concert: {c.concertName}");
            }
        }
    }
}
