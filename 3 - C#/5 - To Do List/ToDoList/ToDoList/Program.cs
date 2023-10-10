using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the to do list program");
            Console.WriteLine("");
            List<string>  taskList = new List<string>();
            string option = "";

            while (option != "e")
            {
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("");
                Console.WriteLine("> Enter 1 to ADD a task to the list");
                Console.WriteLine("> Enter 2 to DELETE a task to the list");
                Console.WriteLine("> Enter 3 to VIEW the list");
                Console.WriteLine("> Enter e to exit");
                Console.WriteLine("");
                Console.WriteLine("");

                option = Console.ReadLine();

                if(option == "1")
                {
                    Console.WriteLine("Please enter your task:");
                    string task = Console.ReadLine();
                    taskList.Add(task);
                    Console.WriteLine($"Task \"{task}\" was added");
                }
                else if (option == "2")
                {
                    for (int i = 0; i < taskList.Count; i++)
                    {
                        Console.WriteLine(i + " " + taskList[i]);
                    }

                    Console.WriteLine("Please enter the number of the task to remove from the list");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    taskList.RemoveAt(taskNumber);
                }
                else if (option == "3")
                {
                    Console.WriteLine("Current tasks in the list: ");

                    for (int i = 0;i < taskList.Count; i++)
                    {
                        Console.WriteLine(taskList[i]);
                    }
                }
                else if (option == "e") {
                    Console.WriteLine("Exiting program");
                }
                else
                {
                    Console.WriteLine("Invalid option, please try again");
                }
            }
            Console.WriteLine("Thank you, see soon !");
        }
    }
}