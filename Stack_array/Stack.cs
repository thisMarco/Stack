using System;

namespace Stack_array
{
    class Stack : StackInterface
    {
        //Marco Picchillo - HND Software Dev. - 2018/2019 - West Lothian College

        public int[] stack = new int[10]; //Create an array of max 10 integer.
        public int LastElement { get; set; } //This keep track of the last element in the array.
        
        public Stack() //Stack Constructor
        {
            LastElement = -1;
        }
        
        public void push(int newElement)
        {
            if (!stackFull()) //If the stack is not full add a new element to the stack.
            {
                LastElement += 1;
                stack[LastElement] = newElement;
            }
            else
            {                
                System.Console.Write("\t The Stack is Full!\n\t " + newElement + " has not been added to the Stack!");
                Console.ReadKey();                
            }               
        }

        public void pop()
        {
            if (!stackEmpty()) //If the stack is not empty pop out the last element from the stack.
            {                
                System.Console.Write("\t The element " + stack[LastElement] + " has been popped out from the stack!");
                LastElement -= 1;
                Console.Write("\n\t Press any key to continue..");                
                Console.ReadKey();
            }
            else
            {                
                System.Console.Write("\t The Stack is Empty!\n\t No element to pop out from the Stack!");
                Console.Write("\n\t Press any key to continue..");
                Console.ReadKey();                       
            }
        }

        public bool stackFull() //Check is the stack is full.
        {
            if (LastElement == 9)
                return true;
            else
                return false;
        }

        public bool stackEmpty() //Check if the stack is empty.
        {
            if (LastElement < 0)
                return true;
            else
                return false;
        }

        public void displayStack() //Displays all the element in the stack (IF NOT EMPTY).
        {
            if (!stackEmpty())
            {                
                System.Console.WriteLine("\n\t The stack contains:");
                for(int i=LastElement; i>=0; i--)
                    System.Console.WriteLine("\t\t" + stack[i]);
                Console.Write("\n\t Press any key to continue..");                
                Console.ReadKey();
            }
            else
            {             
                Console.WriteLine("\n\t The stack is empty!\n\t Press a key to continue..");
                Console.ReadKey();
            }
        }

        public void destroyStack() //If the stack contains elements sets the lastElement value to -1.
        {
            if (!stackEmpty())
            {
                LastElement = -1;                
                Console.WriteLine("\n\t The stack has been destroyed!");
                Console.Write("\n\t Press any key to continue..");                
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\n\t The stack is empty! Nothing to destroy!\n\t Press a key to continue..");
                Console.ReadKey();
            }
        }
    }
}
