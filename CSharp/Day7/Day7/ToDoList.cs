using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day7
{
    internal class ToDoList
    {
        public string Task { get; set; }
        public string Priority { get; set; }

        ArrayList todoArray = new ArrayList();

        //adding tasks with priority into the arraylist
        public void AddTask(string usertask, string userpriority)
        {
            todoArray.Add(new ToDoList { Task = usertask, Priority = userpriority });
        }

        //show the task with priority
        public ArrayList DisplayingToDoList()
        {
            return todoArray;
        }


        //remove task from the arraylist
        public void RemoveTask(string usertask)
        {
            foreach (ToDoList item in todoArray)
            {
                if (item.Task == usertask)
                {
                    todoArray.Remove(item);
                }
            }
        }
    }

    class CheckToDo
    {
        static void Main()
        {
            ToDoList toDoList = new ToDoList();
            int choice;
            do
            {
                Console.WriteLine("Enter your Choice  1. Add Task   2. DisplayTask   3. RemoveTask");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        toDoList.AddTask("Meeting with Client", "1");
                        toDoList.AddTask("Training the Participants", "2");
                        toDoList.AddTask("Visiting Bank", "3");
                        Console.WriteLine("Added Task Successfully..");
                        break;
                    case 2:
                        ArrayList displayList = toDoList.DisplayingToDoList();

                        foreach (ToDoList item in displayList)
                        {
                            Console.WriteLine(item.Task + " " + item.Priority);
                        }
                        break;
                    case 3:
                        toDoList.RemoveTask("Visiting Bank");
                        Console.WriteLine("Task Completed and Removed Successfully");
                        break;
                    default:
                        break;
                }
            } while (choice <= 3);
        }
    }
}
