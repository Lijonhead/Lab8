namespace Lab8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee one = new(1, "Steve", "Male", 50000);
            Employee two = new (2, "Emi", "Female", 100000);
            Employee three = new (3, "Jared", "Male", 20000);
            Employee four = new (4, "Anna", "Female", 5000);
            Employee five = new (5, "Hugo", "Male", 40);
            Stack<Employee> stack = new();
            stack.Push(one);
            stack.Push(two);
            stack.Push(three);
            stack.Push(four);
            stack.Push(five);
            foreach (Employee item in stack)
            {
                Console.WriteLine($"Items left in the stack: " + stack.Count);
                Console.WriteLine(item.Id + " " + item.Name + " " + item.Gender + " " + item.Salary);

            }
            Console.WriteLine("_________________________");

            for (int i = 0; i < 5; i++)

            {

                Employee currentpop = stack.Pop();
                Console.WriteLine($"Items left in the stack: " + stack.Count);
                Console.WriteLine(currentpop.Id + " " + currentpop.Name + " " + currentpop.Gender + " " + currentpop.Salary);
            }
            stack.Push(one);
            stack.Push(two);
            stack.Push(three);
            stack.Push(four);
            stack.Push(five);

            Console.WriteLine("_________________________");

            for (int i = 0; i < 2; i++)

            {

                Employee employeePeek = stack.Peek();
                Console.WriteLine($"Items left in the stack: " + stack.Count);
                Console.WriteLine(employeePeek.Id + " " + employeePeek.Name + " " + employeePeek.Gender + " " + employeePeek.Salary);
            }

            Console.WriteLine("_________________________");

            foreach (Employee item in stack)
            {
                if (item == three)
                {
                    Console.WriteLine("Emp3 is in stack");
                }

                

            }
            Console.WriteLine("_________________________");
            List<Employee> list = new()
            {
                one,
                two,
                three,
                four,
                five
            };

            if (list.Contains(two) == true) 
            {
                Console.WriteLine("Employee2 object exists in the list");
            }
            else 
            {
            Console.WriteLine("Employee2 object does not exist in the list");
            }
            Console.WriteLine("_________________________");

            Employee firstMale = list.Find(e => e.Gender == "Male");
            
            Console.WriteLine("First Male Employee found: " +firstMale.Id + " " + firstMale.Name + " " + firstMale.Gender + " " + firstMale.Salary);
            Console.WriteLine("_________________________");
            List<Employee> AllMales = list.FindAll(e => e.Gender == "Male");
            Console.WriteLine("All males in the list");
            foreach (Employee emp in AllMales) 
            {
                Console.WriteLine( emp.Id + " " + emp.Name + " " + emp.Gender + " " + emp.Salary);
            }
        }
    }
}