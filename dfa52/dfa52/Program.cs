using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("Выберите класс для выполнения:");
            Console.WriteLine("1. Circle (Круг)");
            Console.WriteLine("2. Rectangle (Прямоугольник)");
            Console.WriteLine("3. Car (Машина)");
            Console.WriteLine("4. Manager (Менеджер)");
            Console.WriteLine("5. Washing Machine (Стиральная машина)");
            Console.WriteLine("6. Dog (Собака)");
            Console.WriteLine("7. Computer (Компьютер)");
            Console.WriteLine("8. Savings Account (Сберегательный счет)");
            Console.WriteLine("9. FullTimeEmployee (Полный рабочий день)");
            Console.WriteLine("10. Sphere (Сфера)");
            Console.WriteLine("11. CarToy (Игрушка-машина)");
            Console.WriteLine("12. Bus (Автобус)");
            Console.WriteLine("13. PrintedBook (Печатная книга)");
            Console.WriteLine("14. Ellipse (Эллипс)");
            Console.WriteLine("15. Appliance (Бытовая техника)");
            Console.WriteLine("16. Exit (Выход)");

            Console.Write("Введите номер выбора: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    HandleCircle();
                    break;
                case "2":
                    HandleRectangle();
                    break;
                case "3":
                    HandleCar();
                    break;
                case "4":
                    HandleManager();
                    break;
                case "5":
                    HandleWashingMachine();
                    break;
                case "6":
                    HandleDog();
                    break;
                case "7":
                    
                    break;
                case "8":
                    HandleSavingsAccount();
                    break;
                case "9":
                    HandleFullTimeEmployee();
                    break;
                case "10":
                    HandleSphere();
                    break;
                case "11":
                    HandleCarToy();
                    break;
                case "12":
                    HandleBus();
                    break;
                case "13":
                    HandlePrintedBook();
                    break;
                case "14":
                    HandleEllipse();
                    break;
                case "15":
                    HandleAppliance();
                    break;
                case "16":
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Неверный выбор. Попробуйте снова.");
                    break;
            }

            if (!exit)
            {
                Console.WriteLine("Нажмите любую клавишу для продолжения...");
                Console.ReadKey();
            }
        }
    }

    // Реализация для выбора "Circle"
    static void HandleCircle()
    {
        Console.Write("Введите радиус круга: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Circle circle = new Circle(radius);
        Console.WriteLine($"Площадь круга: {circle.GetArea()}");
    }

    // Реализация для выбора "Rectangle"
    static void HandleRectangle()
    {
        Console.Write("Введите ширину прямоугольника: ");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите высоту прямоугольника: ");
        double height = Convert.ToDouble(Console.ReadLine());
        Rectangle rectangle = new Rectangle(width, height);
        Console.WriteLine($"Площадь прямоугольника: {rectangle.GetArea()}");
        // Пример перемещения прямоугольника
        Console.Write("Введите координату X для перемещения: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите координату Y для перемещения: ");
        int y = Convert.ToInt32(Console.ReadLine());
        rectangle.Move(x, y);
    }

    // Реализация для выбора "Car"
    static void HandleCar()
    {
        Car car = new Car();
        car.StartEngine();
    }

    // Реализация для выбора "Manager"
    static void HandleManager()
    {
        Manager manager = new Manager();
        manager.Work();
        manager.TakeBreak();
    }

    // Реализация для выбора "Washing Machine"
    static void HandleWashingMachine()
    {
        WashingMachine washingMachine = new WashingMachine();
        washingMachine.Operate();
    }

    // Реализация для выбора "Dog"
    static void HandleDog()
    {
        Dog dog = new Dog();
        dog.MakeSound();
    }

    // Реализация для выбора "Computer"
    

    // Реализация для выбора "Savings Account"
    static void HandleSavingsAccount()
    {
        SavingsAccount savingsAccount = new SavingsAccount();
        Console.Write("Введите сумму депозита: ");
        decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
        savingsAccount.Deposit(depositAmount);
        Console.WriteLine($"Баланс счета: {savingsAccount.Balance}");
    }

    // Реализация для выбора "FullTimeEmployee"
    static void HandleFullTimeEmployee()
    {
        FullTimeEmployee employee = new FullTimeEmployee { Salary = 5000 };
        Console.WriteLine($"Зарплата полного рабочего дня: {employee.CalculateSalary()}");
    }

    // Реализация для выбора "Sphere"
    static void HandleSphere()
    {
        Console.Write("Введите радиус сферы: ");
        double radius = Convert.ToDouble(Console.ReadLine());
        Sphere sphere = new Sphere { Radius = radius };
        Console.WriteLine($"Объем сферы: {sphere.GetVolume()}");
        Console.WriteLine($"Площадь поверхности сферы: {sphere.GetSurfaceArea()}");
    }

    // Реализация для выбора "CarToy"
    static void HandleCarToy()
    {
        CarToy carToy = new CarToy();
        carToy.Play();
    }

    // Реализация для выбора "Bus"
    static void HandleBus()
    {
        Bus bus = new Bus();
        bus.Transport();
    }

    // Реализация для выбора "PrintedBook"
    static void HandlePrintedBook()
    {
        PrintedBook printedBook = new PrintedBook();
        printedBook.Read();
    }

    // Реализация для выбора "Ellipse"
    static void HandleEllipse()
    {
        Console.Write("Введите большую полуось эллипса: ");
        double majorAxis = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите малую полуось эллипса: ");
        double minorAxis = Convert.ToDouble(Console.ReadLine());
        Ellipse ellipse = new Ellipse { MajorAxis = majorAxis, MinorAxis = minorAxis };
        Console.WriteLine($"Площадь эллипса: {ellipse.GetArea()}");
        Console.WriteLine($"Периметр эллипса: {ellipse.GetPerimeter()}");
    }

    // Реализация для выбора "Appliance"
    static void HandleAppliance()
    {
        List<Appliance> appliances = new List<Appliance>
        {
            new WashingMachine(),
            new Oven()
        };

        foreach (var appliance in appliances)
        {
            appliance.Operate();
        }
    }
}

// Абстрактные и интерфейсы с их реализациями:

public abstract class Shape
{
    public abstract double GetArea();
}

public class Circle : Shape
{
    public double Radius { get; set; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double GetArea() => Math.PI * Radius * Radius;
}

public class Rectangle : Shape, IMovable
{
    public double Width { get; set; }
    public double Height { get; set; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }
    public override double GetArea() => Width * Height;

    public void Move(int x, int y)
    {
        Console.WriteLine($"Rectangle moved to position ({x}, {y})");
    }
}

public interface IMovable
{
    void Move(int x, int y);
}

public abstract class Vehicle
{
    public abstract void StartEngine();
}

public class Car : Vehicle
{
    public override void StartEngine() => Console.WriteLine("Car engine started");
}

public interface IWorker
{
    void Work();
    void TakeBreak();
}

public class Manager : IWorker
{
    public void Work() => Console.WriteLine("Manager is working");
    public void TakeBreak() => Console.WriteLine("Manager is taking a break");
}

public abstract class Appliance
{
    public abstract void Operate();
}

public class WashingMachine : Appliance
{
    public override void Operate() => Console.WriteLine("Washing machine is operating");
}

public class Oven : Appliance
{
    public override void Operate() => Console.WriteLine("Oven is operating");
}

public abstract class Animal
{
    public abstract void MakeSound();
}

public class Dog : Animal
{
    public override void MakeSound() => Console.WriteLine("Bark");
}

public class Cat : Animal
{
    public override void MakeSound() => Console.WriteLine("Meow");
}

public interface IAccount
{
    void Deposit(decimal amount);
    void Withdraw(decimal amount);
}

public class SavingsAccount : IAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount) => Balance += amount;
    public void Withdraw(decimal amount) => Balance -= amount;
}

public class CheckingAccount : IAccount
{
    public decimal Balance { get; private set; }

    public void Deposit(decimal amount) => Balance += amount;
    public void Withdraw(decimal amount) => Balance -= amount;
}

public abstract class Employee
{
    public abstract decimal CalculateSalary();
}

public class FullTimeEmployee : Employee
{
    public decimal Salary { get; set; }

    public override decimal CalculateSalary() => Salary;
}

public class PartTimeEmployee : Employee
{
    public decimal HourlyRate { get; set; }
    public int HoursWorked { get; set; }

    public override decimal CalculateSalary() => HourlyRate * HoursWorked;
}

public interface IShape3D
{
    double GetVolume();
    double GetSurfaceArea();
}

public class Sphere : IShape3D
{
    public double Radius { get; set; }

    public double GetVolume() => (4 / 3) * Math.PI * Math.Pow(Radius, 3);
    public double GetSurfaceArea() => 4 * Math.PI * Math.Pow(Radius, 2);
}

public class Cube : IShape3D
{
    public double Side { get; set; }

    public double GetVolume() => Math.Pow(Side, 3);
    public double GetSurfaceArea() => 6 * Math.Pow(Side, 2);
}

public abstract class Toy
{
    public abstract void Play();
}

public class CarToy : Toy
{
    public override void Play() => Console.WriteLine("Playing with car toy");
}

public class Doll : Toy
{
    public override void Play() => Console.WriteLine("Playing with doll");
}

public interface ITransport
{
    void Transport();
}

public class Bus : ITransport
{
    public void Transport() => Console.WriteLine("Bus is transporting passengers");
}

public class Train : ITransport
{
    public void Transport() => Console.WriteLine("Train is transporting passengers");
}

public abstract class Book
{
    public abstract void Read();
}

public class PrintedBook : Book
{
    public override void Read() => Console.WriteLine("Reading a printed book");
}

public class EBook : Book
{
    public override void Read() => Console.WriteLine("Reading an eBook");
}

public interface IShape2D
{
    double GetArea();
    double GetPerimeter();
}

public class Ellipse : IShape2D
{
    public double MajorAxis { get; set; }
    public double MinorAxis { get; set; }

    public double GetArea() => Math.PI * MajorAxis * MinorAxis;
    public double GetPerimeter() => Math.PI * (3 * (MajorAxis + MinorAxis) - Math.Sqrt((3 * MajorAxis + MinorAxis) * (MajorAxis + 3 * MinorAxis)));
}
public class Polygon : IShape2D
{
    public double SideLength { get; set; }
    public int NumberOfSides { get; set; }

    public double GetArea() => (NumberOfSides * Math.Pow(SideLength, 2)) / (4 * Math.Tan(Math.PI / NumberOfSides));
    public double GetPerimeter() => SideLength * NumberOfSides;
}