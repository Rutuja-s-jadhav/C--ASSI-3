using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace MyStackPushPop

{

    public class MyStack

    {

        int size_of_stack;

        int top_position = 0;

        int[] array = new int[20];

        public void GetSizeOfStack()//for getting size of stack

        {

            WriteLine("Enter Size of Stack");

            size_of_stack = int.Parse(ReadLine());

        }

        public void Push()

        {

            if (top_position == (size_of_stack - 1))

            {

                WriteLine("Stack is Full");

            }

            else

            {

                for (int i = 0; i < size_of_stack; i++)

                {

                    WriteLine("Insert element in stack");

                    int element = int.Parse(ReadLine());

                    array[++top_position] = element;

                    WriteLine("Item pushed Successfully!");

                }

            }

        }

        public object Pop()

        {

            if (top_position == -1)

            {

                WriteLine("Stack is Empty");

                return "No elements";

            }

            else

            {

                return array[top_position--];

            }

        }

        public void Display()

        {

            for (int i = top_position; i > 0; i--)

            {

                WriteLine("Item {0}: |{1}| ", (i), array[i]);

            }

            ReadLine();

        }

    }

    internal class Program

    {

        static void Main(string[] args)

        {

            MyStack stack = new MyStack();

            //stack.GetSizeOfStack();

            while (true)

            {

                Clear();

                WriteLine("Stack Menu Program");

                WriteLine("1. Enter Size of Stack");

                WriteLine("2. Push operation");

                WriteLine("3. Pop Operation");

                WriteLine("4. Display ");

                WriteLine("5. Exit");

                Write("Enter Your Choice");

                int choice = ToInt32(ReadLine());

                switch (choice)

                {

                    case 1:

                        stack.GetSizeOfStack();

                        break;

                    case 2:

                        stack.Push();

                        break;

                    case 3:

                        WriteLine("Element removed: {0}", stack.Pop());

                        ReadLine();

                        break;

                    case 4:

                        stack.Display();

                        break;

                    case 5:

                        Environment.Exit(0);

                        break;

                }

            }

        }

    }

}