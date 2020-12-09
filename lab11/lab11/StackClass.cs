using System;
using System.Collections.Generic;
namespace lab11
{
    public class Stack
    {
        static int number = 0;
        int numberOfStack = 0;
        float stackSum;
        Stack<float> stack;
        public int Count { get => stack.Count; }
        public float StackSum { get => stackSum; }

        public Stack()
        {
            stack = new Stack<float>();
            number++;
            numberOfStack = number;
        }

        

        public override string ToString()
        {
            return $"Stack {numberOfStack}";
        }

        public void Push(float num)
        {
            stack.Push(num);
            stackSum += num;
        }

        public float Pop()
        {
            return stack.Pop();
        }

        public float Peek()
        {
            return stack.Peek();
        }

        public bool HasNegativeItems()
        {
            Stack<float> stack1 = new Stack<float>();
            bool hasNegativeItems = false;
            for(int i = 0; i < stack.Count;)
            {
                if(stack.Peek() < 0)
                {
                    hasNegativeItems = true;
                    stack1.Push(stack.Pop());
                }
                else
                {
                    stack1.Push(stack.Pop());
                }
            }

            for(int i = 0; i < stack1.Count;)
            {    
                    stack.Push(stack1.Pop());
            }
            return hasNegativeItems;

        }

        public bool HasZeros()
        {
            Stack<float> stack1 = new Stack<float>();
            bool hasZeros = false;
            for (int i = 0; i < stack.Count;)
            {
                if (stack.Peek() == 0)
                {
                    hasZeros = true;
                    stack1.Push(stack.Pop());
                }
                else
                {
                    stack1.Push(stack.Pop());
                }
            }

            for (int i = 0; i < stack1.Count;)
            {
                stack.Push(stack1.Pop());
            }
            return hasZeros;
        }
    }

    public class Organization
    {
        public string Name { get; set; }

        public Organization(string name)
        {
            Name = name;
        }
    }

    public class Concert
    {
        public string Name { get; set; }
        public Organization org { get; set; }
        public Concert(string name, Organization organization)
        {
            Name = name;
            org = organization;
        }
    }
}
