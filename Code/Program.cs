using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG261_Project_2
{
    public class Program
    {
        enum Menu
        {
            Register = 1,
            View_registered_member,
            Place_an_order,
            View_placed_orders,
            Exit
        }

        static void Main(string[] args)
        {
            string orderName = "";
            string orderNumber = "";
            string studInvoice = "";
            string lectInvoice = "";
            bool Continue = true;
            string studID = "";
            string name;
            string surname;
            string age;
            string empID;


            List<lecturerRegister> lectReg = new List<lecturerRegister>();
            List<studentRegister> studReg = new List<studentRegister>();
            List<studentOrder> studOrder = new List<studentOrder>();
            List<LecturerOrder> lectOrder = new List<LecturerOrder>();

            Console.WriteLine("Welcome to BC Eats! What would you like to do?");
            while (Continue)
            {
                Console.WriteLine("1.Register");
                Console.WriteLine("2.View registered members");
                Console.WriteLine("3.Place an order");
                Console.WriteLine("4.View placed orders");
                Console.WriteLine("5.Exit");
                string answer = Console.ReadLine();


                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Would you like to register the lecturer or student?");
                        answer = Console.ReadLine();
                        if (answer == "lecturer")
                        {
                            Console.WriteLine("Enter your name.");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter your surname.");
                            surname = Console.ReadLine();
                            Console.WriteLine("What is your age?");
                            age = Console.ReadLine();
                            Console.WriteLine("Enter your Employee ID.");
                            empID = Console.ReadLine();
                            lecturerRegister newlectReg = new lecturerRegister(name, surname, age, empID);
                            lectReg.Add(newlectReg);
                        }
                        else if (answer == "student")
                        {
                            Console.WriteLine("Enter your name.");
                            name = Console.ReadLine();
                            Console.WriteLine("Enter your surname.");
                            surname = Console.ReadLine();
                            Console.WriteLine("What is your age?");
                            age = Console.ReadLine();
                            Console.WriteLine("Enter your student ID.");
                            studID = Console.ReadLine();
                            studentRegister newstudReg = new studentRegister(name, surname, age, studID);
                            studReg.Add(newstudReg);
                        }

                        
                        break;

                    case "2":
                        Console.Write("|Lecturers| \n");
                        foreach (lecturerRegister lectRegister in lectReg)
                        {
                            Console.WriteLine(lectRegister.LSRegister());
                        }
                        Console.Write("|Students| \n");
                        foreach (studentRegister studRegister in studReg)
                        {
                            Console.WriteLine(studRegister.LSRegister());
                        }
                        break;

                    case "3":
                        Random random = new Random();
                        Console.WriteLine("Is it a student or Lecturer that will be ordering?");
                        answer = Console.ReadLine();
                        if (answer == "student")
                        {
                            Console.WriteLine("What is the name of the product you want to order?");
                            orderName = Console.ReadLine();
                            int randomNumber = random.Next(0, 9999);
                            orderNumber = randomNumber.ToString();
                            Console.WriteLine("Your order number is #" + orderNumber);
                            Console.WriteLine("Would you like an invoice?");
                            studInvoice = Console.ReadLine();
                            studentOrder newstudOrder = new studentOrder(orderName, orderNumber, studInvoice);
                            studOrder.Add(newstudOrder);
                            
                            
                        }
                        else if (answer == "lecturer")
                        {
                            Console.WriteLine("What is the name of the product you want to order?");
                            orderName = Console.ReadLine();
                            int randomNumber = random.Next(0, 9999);
                            orderNumber = randomNumber.ToString();
                            Console.WriteLine("Your order number is #" + orderNumber);
                            Console.WriteLine("Would you like an invoice?");
                            lectInvoice = Console.ReadLine();
                            
                            
                            LecturerOrder newlectOrder = new LecturerOrder(orderName, orderNumber, lectInvoice);
                            lectOrder.Add(newlectOrder);
                            
                            
                        }
                        break;
                    case "4":
                        Console.WriteLine("|Lecturer Orders| \n");
                        foreach (LecturerOrder lecturerOrder in lectOrder)
                        {
                            Console.WriteLine(lecturerOrder.Orders());
                        }

                        Console.WriteLine("|Student Orders| \n");
                        foreach (studentOrder studentOrder in studOrder)
                        {
                            Console.WriteLine(studentOrder.Orders());
                        }


                        break;
                    case "5":
                        Environment.Exit(0);
                        break;



                }
                Console.ReadKey();
            }
        }
    }
}
