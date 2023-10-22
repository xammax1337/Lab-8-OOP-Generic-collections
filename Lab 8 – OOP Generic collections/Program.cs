using System.Security.Cryptography.X509Certificates;

namespace Lab_8___OOP_Generic_collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Temporary stack storage for items popped.
            Stack<Employee> temp = new Stack<Employee>();

            Employee Emp1 = new Employee("E1", "Magnus", "Male", 25000);
            Employee Emp2 = new Employee("E2", "Jonas", "Male", 27000);
            Employee Emp3 = new Employee("E3", "Nova", "Female", 25020);
            Employee Emp4 = new Employee("E4", "Maria", "Female", 29700);
            Employee Emp5 = new Employee("E5", "Arnold", "Male", 25000);

            Stack<Employee> stack = new Stack<Employee>(); //creates a Stack called stack and push all our objects into it
            stack.Push(Emp1);
            stack.Push(Emp2);
            stack.Push(Emp3);
            stack.Push(Emp4);
            stack.Push(Emp5);

            //Prints out every item in the stack using a foreach loop that runs the same amount of times as there is items.
            foreach (Employee item in stack)
            {
                Console.WriteLine(item);
                Console.WriteLine($"Items left in the stack = {stack.Count}");
            }


            //Use the Pop Method to retrieve items
            Console.WriteLine("\nRetrieve using Pop Method:");
            //When the amount of items in the stack are above 0 this loop runs. This also pushes items in to a temp stack.
            while (stack.Count > 0)
            {
                Employee item = stack.Pop();
                Console.WriteLine(item);
                Console.WriteLine($"Items left in the stack = {stack.Count}");
                temp.Push(item);
            }

            //After popping items and storing them in temp stack we use this loop to push them back to the original stack.
            foreach (Employee item in temp)
            {
                stack.Push(item);
            }
            Console.WriteLine($"{stack.Count} Items pushed back!");


            //Get 2 items using the Peek method with a loop
            Console.WriteLine("\nRetrieve using Peek Method:");
            for (int i = 0; i < 2; i++) 
            {
                Console.WriteLine(stack.Peek());
                Console.WriteLine($"Items left in the stack = {stack.Count}");
            }


            Console.WriteLine("\nChecking if someone is in the stack:");
            
            string checkId = "E1"; //input the id you want to search for

            bool found = false; //Starts at false since it's not found yet then starts loop.
            
            foreach (Employee item in stack) //loops through the stack until one of the item in stack matches our input
            {
                if (item.ID == checkId) //if the item.ID matches our input the bool becomes true and breaks the loop.
                {
                    found = true; break;
                }
            }

            if (found) //if found (bool = true) print which id was found in the stack.
            {
                Console.WriteLine(checkId + " is in the Stack!");
            }
            else
            {
                Console.WriteLine(checkId + " is not in the Stack!");
            }



            //Del 2 - List
            Console.WriteLine("\n---------------------- Del 2 - List ---------------------------\n");

            List<Employee> employees = new List<Employee>(); //Make new list called employees and add all the old objects created to it.
            employees.Add(Emp1);
            employees.Add(Emp2);
            employees.Add(Emp3);
            employees.Add(Emp4);
            employees.Add(Emp5);

            Employee employeeToCheck = Emp1; //Makes it so i can use employeeToCheck instead of having to type Emp1 when printing in console.

            if (employees.Contains(employeeToCheck))
            {
                Console.WriteLine($"{employeeToCheck.ID} object exists in the list");
            }
            else
            { 
                Console.WriteLine($"{employeeToCheck.ID} object does not exist in the list"); 
            }


            //Use Find method to find the first object with Male as gender.
            Employee maleEmployee = employees.Find(employee => employee.Gender == "Male");

            Console.WriteLine($"\nThis is the first male employee found: {maleEmployee}");


            //Using FindAll method to find all objects with Male as gender
            List<Employee> maleEmployees = employees.FindAll(employee => employee.Gender == "Male");

            Console.WriteLine($"\nThese are all the male employees found: ");

            foreach (Employee item in maleEmployees) //Needs to loop to print out every male.
            {
                Console.WriteLine(item);
            }



        }
    }
}