using System;

namespace inheriting
{
    class Program
    {
        static void Main(string[] args)
        {
            Printer[] arg = new Printer[2];
            arg[0] = new Printer();
            arg[1] = new RedPrinter();
            foreach (Printer p in arg)
            {
                p.Print("Hi, ISD");
            }

            arg[1].Print("sf");
            Vehicle[] v = new Vehicle[3];
            v[0] = new Car(100, 170, 3);
            v[1] = new Plane(300, 260, 2, 2000, 40);
            v[2] = new Ship(500, 140, 15, 200, "Dnipro");
            foreach (Vehicle v1 in v)
            {
                v1.print();
            }
            if (Console.ReadLine() == "pass")
            {
                ProDocumentWorker pdw = new ProDocumentWorker();
                pdw.Open();
                pdw.Edit();
                pdw.Save();
            }
            else if (Console.ReadLine() == "propass")
            {
                ExprtDocumentWorkeer edw = new ExprtDocumentWorkeer();
                edw.Open();
                edw.Edit();
                edw.Save();
            }
            else
            {
                DocumentWorker dw = new DocumentWorker();
                dw.Open();
                dw.Edit();
                dw.Save();
            }
            Console.ReadKey();
        }
    }
    class DocumentWorker
    {
        public virtual void Open()
        {
            Console.WriteLine("Документ открыт");
        }
        public virtual void Edit()
        {
            Console.WriteLine("Редактирование документа доступно в версии Про");
        }
        public virtual void Save()
        {
            Console.WriteLine("Сохранение документа доступно в версии Про");
        }
    }
    class ProDocumentWorker :DocumentWorker
    {
        public new void Open()
        {
            Console.WriteLine("Документ открыт");
        }
        public override void Edit()
        {
            Console.WriteLine("Файл отредактирован");
        }
        public override void Save()
        {
            Console.WriteLine("Сохранение документа доступно в версии Эксперт");
        }
    }
    class ExprtDocumentWorkeer:DocumentWorker
    {
        public new void Open()
        {
            Console.WriteLine("Документ открыт");
        }
        public override void Edit()
        {
            Console.WriteLine("Файл отредактирован");
        }
        public override void Save()
        {
            Console.WriteLine("Файл сохранен");
        }
    }
    class Vehicle
    {
        private int price, speed, year;
        public Vehicle(int price,int speed,int year)
        {
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public virtual void print()
        {
               
        }
    }
    class Plane : Vehicle
    {
        private int price, speed, year,height, count;
        public Plane(int price, int speed, int year, int height,int count):base(price,speed,year)
        {
            this.height = height;
            this.year = year;
            this.price = price;
            this.speed = speed;
            this.count = count;
        }
        public override void print()
        {
            Console.WriteLine(price + " "+speed+" "+year+" "+height+" "+count);
        }
    }
    class Car : Vehicle
    {
        private int price, speed, year;
        public Car(int price, int speed, int year) :base(price, speed, year)
        {            
            this.price = price;
            this.speed = speed;
            this.year = year;
        }
        public override void print()
        {
            Console.WriteLine(price + " " + speed + " " + year);
        }
    }
    class Ship : Vehicle
    {
        private int count,price,speed,year;
        private string port;
        public Ship(int price, int speed, int year, int count, string port) : base(price, speed, year)
        {
            this.speed = speed;
            this.year = year;
            this.price = price;
            this.count = count;
            this.port = port;
        }
        public override void print()
        {
            Console.WriteLine(price + " " + speed + " " + year + " " + port+ " " + count);
        }
    }
    class Classroom
    {
        public Classroom(Pupil p)
        {

        }
        public Classroom(Pupil p,Pupil p2)
        {

        }
        public Classroom(Pupil p,Pupil p1, Pupil p2)
        {

        }

    }
    class Pupil
    {
        public virtual void Study()
        {

        }
        public virtual void Read()
        {

        }
        public virtual void Write()
        {

        }
        public virtual void Relax()
        {

        }
    }
    class ExelentPupil:Pupil
    {
        public override void Study()
        {

        }
        public override void Read()
        {

        }
        public override void Write()
        {

        }
        public override void Relax()
        {

        }
    }
    class GoodPupil:Pupil
    {
        public override void Study()
        {

        }
        public override void Read()
        {

        }
        public override void Write()
        {

        }
        public override void Relax()
        {

        }
    }
    class BadPupil:Pupil
    {
        public override void Study()
        {

        }
        public override void Read()
        {

        }
        public override void Write()
        {

        }
        public override void Relax()
        {

        }
    }
    internal class Printer
    {
       public  virtual void Print (string value)
        {
            Console.WriteLine(value);
        }
    }
   internal class RedPrinter :Printer
    {
       public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ResetColor();
        }
    }
}
