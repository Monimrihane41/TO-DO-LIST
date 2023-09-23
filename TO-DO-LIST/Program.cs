using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TO_DO_LIST
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the TO DO LIST program.");
            List<string> tasklist = new List<string>();
            string option = "";


            while(option !="e")
            {
                Console.WriteLine("What would you like to do ?");
                Console.WriteLine("Enter 1 to add a task to the list");
                Console.WriteLine("Enter 2 to remove a task from the list");
                Console.WriteLine("Enter 3 to view the List");
                Console.WriteLine("Enter e to exi the programme");


                option = Console.ReadLine();

                if(option == "1") 
                {
                    Console.WriteLine("Enter the name of the task TO DO to add to the list");
                    string task = Console.ReadLine();
                    tasklist.Add(task);
                    Console.Write(task + " WAS ADDED SUCCESFULY TO THE LIST");


                }else if(option == "2"){

                    for (int i = 0; i < tasklist.Count;i++)
                    {
                        Console.WriteLine(i+" : " + tasklist[i]);
                    }
                    Console.WriteLine("Please enter the number of the task to remove from the list . ");
                    int taskNumber = Convert.ToInt32(Console.ReadLine());
                    tasklist.RemoveAt(taskNumber);

                }
                else if (option == "3")
                {


                    for (int i = 0; i < tasklist.Count; i++)
                    {
                        Console.WriteLine(tasklist[i]);
                    }
                }
                else if(option == "e") 
                {
                    Console.WriteLine("Exiting program");
                }
                else
                {
                    Console.WriteLine("invalid option, please try again : ");
                }
                


            }
            Console.WriteLine("Thank you for using the program!");








        }
    }
}
 