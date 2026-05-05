using EmployeeWageApp;

namespace Review
{
    internal class Program

    {
        public static object LineComparison1 { get; private set; }

        static void Main(string[] args)
        {
            //Console.Write("Enter Basic Salary: ");
            //double basic = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter Allowance: ");
            //double allowance = Convert.ToDouble(Console.ReadLine());

            //EmployeeWage1 emp = new EmployeeWage1(basic, allowance);


            //emp.DisplaySalary();

            //Console.ReadLine();

            //Console.WriteLine("Enter coordinates for Line 1:");
            //int x1 = Convert.ToInt32(Console.ReadLine());
            //int y1 = Convert.ToInt32(Console.ReadLine());
            //int x2 = Convert.ToInt32(Console.ReadLine());
            //int y2 = Convert.ToInt32(Console.ReadLine());

            //double length1 = LineComparision1.CalculateLength(x1, y1, x2, y2);

            //Console.WriteLine("\nEnter coordinates for Line 2:");
            //int x3 = Convert.ToInt32(Console.ReadLine());
            //int y3 = Convert.ToInt32(Console.ReadLine());
            //int x4 = Convert.ToInt32(Console.ReadLine());
            //int y4 = Convert.ToInt32(Console.ReadLine());

            //double length2 = LineComparision1.CalculateLength(x3, y3, x4, y4);

            //Console.WriteLine($"\nLength of Line 1: {length1}");
            //Console.WriteLine($"Length of Line 2: {length2}");

            //LineComparision1.CompareLines(length1, length2);

            //Console.ReadLine();






            //SnakeAndLadder game = new SnakeAndLadder();
            //game.Play();

            //Console.ReadLine();


            //EmployeeWage2 emp = new EmployeeWage2();
            //emp.CalculateWage();

            //Console.ReadLine();

            AddressBook book = new AddressBook();

            while (true)
            {
                Console.WriteLine("\n1. Add Person");
                Console.WriteLine("2. Display All");
                Console.WriteLine("3. Edit Person");
                Console.WriteLine("4. Delete Person");
                Console.WriteLine("5. Search by City");
                Console.WriteLine("6. Sort by Name");
                Console.WriteLine("7. Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.Write("First Name: ");
                    string fn = Console.ReadLine();

                    Console.Write("Last Name: ");
                    string ln = Console.ReadLine();

                    Console.Write("City: ");
                    string city = Console.ReadLine();

                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();

                    book.AddPerson(new Person(fn, ln, city, phone));
                }
                else if (choice == 2)
                {
                    book.DisplayAll();
                }
                else if (choice == 3)
                {
                    Console.Write("Enter First Name to Edit: ");
                    book.EditPerson(Console.ReadLine());
                }
                else if (choice == 4)
                {
                    Console.Write("Enter First Name to Delete: ");
                    book.DeletePerson(Console.ReadLine());
                }
                else if (choice == 5)
                {
                    Console.Write("Enter City: ");
                    book.SearchByCity(Console.ReadLine());
                }
                else if (choice == 6)
                {
                    book.SortByName();
                }
                else if (choice == 7)
                {
                    break;
                }
            }




        }
    }


}
