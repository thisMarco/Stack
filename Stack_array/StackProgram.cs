using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_array
{
    class StackProgram
    {
        //Marco Picchillo - HND Software Dev. - 2018/2019 - West Lothian College
        static void Main(string[] args)
        {
            Stack theStack = new Stack();
            string menuChoice;

            Console.WriteLine("Welcome to the Stack Test Program.\nThe Stack has been created empty.\nWhat do you want to do?");
            do
            {
                displayMenu(); //Displays the Menu.
                Console.Write("\t ");
                menuChoice = Console.ReadLine();
                menuChoice.ToUpper();
                switch (menuChoice)
                {
                    case "1":
                        {
                            theStack.displayStack();
                            break;
                        }
                    case "2":
                        {
                            Console.Write("\t Please insert an integer number: ");
                            try
                            {
                                int newElement = int.Parse(Console.ReadLine());
                                theStack.push(newElement);
                            }
                            catch
                            {                                
                                Console.WriteLine("\n\tYou have inserted an invalid value!");                                
                            }
                            break;
                        }
                    case "3":
                        {
                            theStack.pop();
                            break;
                        }
                    case "4":
                        {
                            theStack.destroyStack();
                            break;
                        }
                    case "5":
                        {
                            Console.WriteLine("\n\t The program will be terminated.\n\t Press any key to continue..");
                            Console.ReadKey();
                            break;
                        }
                    default:
                        {                            
                            Console.Clear();
                            Console.WriteLine("\t You have entered an invalid option! Press any key to reload the menu..");
                            Console.ReadKey();                            
                            break;
                        }
                }
                Console.Clear();
            } while(menuChoice!="5");             
                
        }

        static public void displayMenu()
        {            
            Console.WriteLine("\n\t \\* MARCO PICCHILLO - HND SOFTWARE DEV. - WEST LOTHIAN COLLEGE */\n");            
            System.Console.WriteLine("\t MENU:\n");
            System.Console.WriteLine("\t 1. Display Stack\n" +
                                     "\t 2. Push Element\n" +
                                     "\t 3. Pop Element\n\n" +
                                     "\t 4. Destroy Stack\n\n" +
                                     "\t 5. Terminate Program\n\t ");
        }
    }
}
