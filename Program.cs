using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Class Adress:_______________________________________________");
            Address first = new Address();
            first.Country = "Ukraine";
            first.City = "Dnepr";
            first.House = 22;
            first.Street = "Gagarina";
            first.Index = 67822;
            first.Apartment = "7B";
            Console.WriteLine(first.Country + "\n" + first.City + "\n" + first.Street + "\n" + first.House + "\n" + first.Apartment + "\n" + first.Index);
            Console.WriteLine("Class Rectangle_______________________________________________");
            Rectangle r1 = new Rectangle(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine(r1.Area + " " + r1.Perimetre);
            Console.WriteLine("Class Book:___________________________________________________");
            Book b1 = new Book();
            b1.Title = "b1";
            b1.Author = "a1";
            b1.Content= "Hello world!";
            b1.Show();
            Console.WriteLine("Class Point&Figure:______________________________________________");
            Point A = new Point(10, 20);
            Point B = new Point(15, 17);
            Point C = new Point(1, 30);
            Figure f1 = new Figure(A,B,C);
            Console.WriteLine("Class User:______________________________________________________");
            User u = new User();
            u.Username = "Vladisalvow";
            u.Name = "Vlad";
            u.Surname = "Skliar";
            u.Age = "18";
            Console.WriteLine(u.Username + " " + u.Name + " " + u.Surname + " " + u.Age + " " + u.Date);
            Console.WriteLine("Class Converter:__________________________________________________");
            Converter conv = new Converter(24.00, 26.00, 0.33);
            conv.convert(1000);
            Console.WriteLine("Class Employee:___________________________________________________");
            Employee employee = new Employee("Vlad", "Sklyar", "Работник", 20);
            Console.WriteLine(employee.Name + " " + employee.Surname + " " + employee.Post + " " + employee.Salary + " " + employee.Taxes + " " + employee.Exp);
            Console.WriteLine("Class Invoice:____________________________________________________");
            Invoice invoice = new Invoice(Console.ReadLine(),Console.ReadLine());
            invoice.buy("car", 100, true);
            Console.ReadKey();
        }
    }
    class Invoice
    {
        private int account, quantity;
        private string customer, article, provider;
        public Invoice(string cuustomer, string provider)
        {
            this.customer = cuustomer;
            this.provider = provider;
        }
        public void buy(string article,int quantity,bool nds)
        {
            if (article == "car")
            {
                account = 100 * quantity;
            }
            else if(article =="plane"){ account = 200 * quantity; } else if (article == "pan") { account = 10 * quantity; }
            if (nds)
            {
                account += (int)(account * 0.15);
            }
            else
            {

            }
            Console.WriteLine(account);
        }
    }
    class Employee
    {
        private string name, surname,post;
        private double salary,taxes;
        private int exp;    
        public string Post
        {
            get { return post; }
            set { post = value; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Surname
        {
            get { return surname; }
        }
        public string Salary
        {
            get { return salary.ToString(); }
        }
        public string Taxes
        {
            get { return taxes.ToString(); }
        }
        public string Exp
        {
            get { return exp.ToString(); }
            set { exp = Convert.ToInt32(value); }
        }
        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
            getSalaryAndTaxes("", 0);
        }
        public Employee(string name, string surname,string post)
        {
            this.name = name;
            this.surname = surname;
            this.post = post;
            getSalaryAndTaxes(post,0);
        }  
        public Employee(string name, string surname, string post,int exp)
        {
            this.name = name;
            this.surname = surname;
            this.post = post;
            this.exp = exp;
            getSalaryAndTaxes(post,exp);
        }
        void getSalaryAndTaxes(string post, int exp)
        {
             salary = 18000;
            if (post.ToLower() == "работник")
            {
                salary += 3000;
            }
            else if (post.ToLower() == "шеф")
            {
                salary += 8000;
            }
            else { }
            if (exp > 10) { salary += salary * 0.1; } else if (exp > 20) { salary += salary * 0.17; } else if (exp > 30) { salary += salary * 0.25; }
            taxes = salary * 0.15;
        }
    }
    class Converter
    {
        double usd, eur, rub;
        public Converter(double usd, double eur,double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }
        public void convert(double summ)
        {
            Console.WriteLine("uah-usd:" + (summ / usd) + "uah-eur:" + (summ / eur) + "uah-rub:" + (summ / rub) + "usd-uah:" + (summ * usd) + "eur-uah:" + (summ * eur) + "rub-uah:" + (summ * rub));
        }
    }
    class User
    {
        private string username, name, surname, age, date=DateTime.Now.ToString();
        public string Date
        {
            get
            {
                return date;
            }            
        }
        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                username = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }   
        }
        public string Surname
        {
            get
            {
                return surname;
            }
            set
            {
                surname = value;
            }
        }
        public string Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
    class Point
    {
        private int x, y;
        private string name;
        public int X
        {
            get
            {
                return x;
            }
        }
        public int Y
        {
            get
            {
                return y;
            }
        }
        public int Comment
        {
            get
            {
                return Comment;
            }
        }
        public Point(int X,int Y)
        {
            this.x = X;
            this.y = Y;
        }
        public Point(int X, int Y,string Name)
        {
            this.x = X;
            this.y = Y;
            this.name = Name;
        }
    }
    class Figure
    {
        double perimetr = 0;
        double[] length=new double[5];
        public Figure(Point A, Point B, Point C)
        {
            length[0] = LengthSide(A, B);
            length[1] = LengthSide(B, C);
            length[2] = LengthSide(C,A);
            PerimetrCalculator();
            Console.WriteLine("Треугольник" + "Периметр:" + perimetr);
        }
        public Figure(Point A, Point B, Point C,Point D)
        {
            length[0] = LengthSide(A, B);
            length[1] = LengthSide(B, C);
            length[2] = LengthSide(C,D);
            length[3] = LengthSide(D, A);
            PerimetrCalculator();
            Console.WriteLine("Четырехугольник" + "Периметр:" + perimetr);
        }
        public Figure(Point A, Point B, Point C,Point D,Point E)
        {
            length[0] = LengthSide(A, B);
            length[1] = LengthSide(B, C);
            length[2] = LengthSide(C, D);
            length[3] = LengthSide(D, E);
            length[4] = LengthSide(E, A);
            PerimetrCalculator();
            Console.WriteLine("Пентагон" + "Периметр:" + perimetr);
        }
        double LengthSide(Point A, Point B)
        {
            double Lenght = Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
            return Lenght;
        }
        void PerimetrCalculator()
        {
            perimetr=0;
            for(int i = 0; i < 5;i++)
            {
                perimetr += length[i];
            }
        }
    }
    class Book
    {
        private string title, author, content;
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }
        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public string Content
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;            
            Console.WriteLine(title);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(content);
            Console.ResetColor();
        }
}
    class Rectangle
    {
        private double side1, side2;
        public Rectangle(double side1,double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
        }
        private double AreaCalculator()
        {
            double area=side1*side2;
            return area;
        }
        private double PerimeterCalculator()
        {
            double area = 2*(side1 +side2);
            return area;
        }
        public double Area
        {
            get
            {
               return AreaCalculator();
            }
        }
        public double Perimetre
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
     class Address
    {
        private int index, house;
        private string country, city, street,apartment;
        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }
        public int House
        {
            get
            {
                return house;
            }
            set
            {
                house = value;
            }
        }
        public string Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }
        public string Apartment
        {
            get
            {
                return apartment;
            }
            set
            {
                apartment = value;
            }
        }
    }
}
