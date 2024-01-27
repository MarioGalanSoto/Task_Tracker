using System.Collections.Generic;
class taskTracker
{
    static List<string> tasks = new List<string>();
    static void Main()
    {
        Console.WriteLine("\nWelcome to the Task Tracker!\n");
        bool exit = false;

        while(!exit){

            DisplayMenu();

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    MarkTaskAsCompleted();
                    break;
                case "3":
                    ViewTasks();
                    break;
                case "4":
                    exit = true;
                    Console.WriteLine("Exiting Task Tracker. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n1. Add Task");
        Console.WriteLine("2. Mark Task as Completed");
        Console.WriteLine("3. View Tasks");
        Console.WriteLine("4. Exit");
        Console.Write("Enter your choice: ");
    }

    static void AddTask()
    {
        Console.Write("Enter task description: ");
        string taskDescription = Console.ReadLine();
        tasks.Add($"[ ] {taskDescription}");

        Console.WriteLine("Task added successfully!");
    }

    static void MarkTaskAsCompleted()
    {

        bool validInput = false;

        while(!validInput){
            ViewTasks();//print the tasks
            Console.Write("Enter the task number to mark as completed or 0 to return: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber))
            {
                if (taskNumber == 0)
                {
                    validInput = true; // Exit the loop and return to the menu
                }
                else if (taskNumber >= 1 && taskNumber <= tasks.Count)
                {
                    tasks[taskNumber - 1] = tasks[taskNumber - 1].Replace("[ ]", "[X]");
                    Console.WriteLine("Task marked as completed!");
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Invalid task number. Please try again.");
                }
            }
            else{
                Console.WriteLine("Invalid input. Please enter a valid task number or 0 to return to the menu.");
            }
        }

    }

    static void ViewTasks()
    {
        Console.WriteLine("\nTasks:");

        for (int i = 0; i < tasks.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {tasks[i]}");
        }
    }


}




// Add a task with a description.
// Mark tasks as completed.
// View the list of tasks.
// Optional: Set due dates for tasks.
// Optional: Save tasks to a file for persistence.

