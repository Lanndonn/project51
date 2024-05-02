namespace project51;

class Program
{
    private static Customers customers;
    private static List<Appointment> appointments;
    private static List<CustomerAppointment> customerappointments;
    private static Customer authenticatedCustomer;

    static void Main(string[] args)
    {
        System.Console.WriteLine("Loading...");
        Load();
        MenuCommand();
    }

    static void Load()
    {
        var c1 = new Customer
        {
            firstName = "Chad",
            lastName = "LaBore",
            username = "clab",
            password = "1234",
        };

        var c2 = new Customer
        {
            firstName = "Landon",
            lastName = "Traverse",
            username = "Trav",
            password = "1234",
        };

        var a1 = new Appointment();
        var a2 = new Appointment();
        var a3 = new Appointment();

        var ca1 = new CustomerAppointment(c1, a1);
        var ca2 = new CustomerAppointment(c1, a2);
        var ca3 = new CustomerAppointment(c2, a3);

        customers = new Customers();
        customers.customerList.Add(c1);
        customers.customerList.Add(c2);

        customerappointments = new List<CustomerAppointment>();
        customerappointments.Add(ca1);
        customerappointments.Add(ca2);
        customerappointments.Add(ca3);

        appointments.Add(a1);
        appointments.Add(a2);
        appointments.Add(a3);

    }

    static void MenuCommand()
    {
        bool done = false;

        while(!done)
        {
            System.Console.WriteLine("Options: Login:1, Logout:2, Signup:3, Appointments:4, Quit:q");
            Console.Write("Choice: ");
            string choice Console.ReadLine();

            switch (choice)
            { 
                case "1":
                    LoginMenu();
                    break;
                case "2":
                    LogOutMenu();
                    break;
                case "3":
                    SignUpMenu();
                    break;
                case "4":
                    AppointmentsMenu();
                    break;
                case "q":
                    done = true;
                    break;
                default:
                    System.Console.WriteLine("Invalid command!");
                    break;
            }
        }

    }

    static void Menu()
    {

    }

    static void LoginMenu()
    {
        if(authenticatedCustomer == null)
        {
        System.Console.WriteLine("Enter your username: ");
        string username = Console.ReadLine();
        System.Console.WriteLine("Enter your password: ");
        string password = Console.ReadLine();

        authenticatedCustomer = customers.Authenticate(username, password);
        if (authenticatedCustomer != null)
        {
            System.Console.WriteLine($"Welcome {authenticatedCustomer.firstName}");
        }
        else
        {
            System.Console.WriteLine("Invalid username or password");
        }
        }
    }
    static void LogOutMenu()
    {
        authenticatedCustomer = null;
        System.Console.WriteLine("Logged out.");
    }
     static void SignUpMenu()
    {
        System.Console.WriteLine("Enter your first name: ");
        string firstName = Console.ReadLine();

        System.Console.WriteLine("Enter your last name: ");
        string lastNameName = Console.ReadLine();

        System.Console.WriteLine("Create your username: ");
        string username = Console.ReadLine();

        System.Console.WriteLine("Create your fpassword: ");
        string password = Console.ReadLine();

        var newCustomer = new Customer
        {
            firstName = firstName,
            lastName = lastNameName,
            username = username,
            password = password,

        };
        customers.customerList.Add(newCustomer);
        System.Console.WriteLine("Profile created!");
    }

    static void AppointmentsMenu()
    {
        if (authenticatedCustomer == null)
        {
            System.Console.WriteLine("Please log in first!");
            return;
        }

        var appointmentList = customerappointments.Where(o => o.c.username == authenticatedCustomer.username);

        if(appointmentList.Count() == 0)
        {
            System.Console.WriteLine("You have 0 appointments.");
        }
        else
        {
            foreach (var appointment in appointmentList)
            {
                System.Console.WriteLine(appointment.a.dateTime);
            }
        }
    }
}

