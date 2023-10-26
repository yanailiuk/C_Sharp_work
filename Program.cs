/* Визначити клас Car з полями назва, колір, ціна, const полем CompanyName
Створити два конструктори – дефолтний і з параметрами.
Визначити методи Input() –  для введення даних про автомобіль з консолі,
Print() - для виведення даних про машину на консоль
ChangePrice(double x) – для зміни ціни на х%

Ввести дані про 3 авто.
Зменшити їх ціну на 10%, вивести дані про авто.
Ввести новий колір і пофарбувати авто з кольором white у вказаний колір
Створити метод PrintInfo, який повертає рядок з даними про авто
*/


// use PascalCase 
class Car
{
    // Fields
    private string name;
    private string color;
    private double price;

    // Constant field
    private const string CompanyName = "TheBestCarCompany";

    // Constructors
    public Car()
    {
        // 1. Default constructor
    }


    // 2. with parameters 
    public Car(string name, string color, double price)
    {
        this.name = name;
        this.color = color;
        this.price = price;
    }

    // Methods
    public void Input()
    {
        Console.Write("Enter car name: ");
        name = Console.ReadLine();

        Console.Write("Enter car color: ");
        color = Console.ReadLine();

        Console.Write("Enter car price: ");
        double.TryParse(Console.ReadLine(), out price);
    }

    public void Print()
    {
        Console.WriteLine($"Car Details:\nName: {name}\nColor: {color}\nPrice: {price:C}\nCompany: {CompanyName}\n");
    }

    public void ChangePrice(double percentage)
    {
        price -= price * (percentage / 100);
    }

    public void PaintCar(string newColor)
    {
        if (color.ToLower() == "white")
        {
            color = newColor;
            Console.WriteLine($"Car has been painted to {newColor}.");
        }
        else
        {
            Console.WriteLine("Car can only be painted if the current color is white.");
        }
    }

    public string PrintInfo()
    {
        return $"Name: {name}, Color: {color}, Price: {price:C}, Company: {CompanyName}";
    }
}

class Program
{
    static void Main()
    {
        // Creating 3 car objects
        Car car1 = new Car();
        Car car2 = new Car("Toyota", "Blue", 25000);
        Car car3 = new Car();

        // Input data for car1 and car3
        car1.Input();
        car3.Input();

        // Printing initial car details
        Console.WriteLine("Initial Car Details:");
        car1.Print();
        car2.Print();
        car3.Print();

        // Decrease prices by 10%
        car1.ChangePrice(10);
        car2.ChangePrice(10);
        car3.ChangePrice(10);

        // Printing car details after price change
        Console.WriteLine("Car Details After Price Change:");
        car1.Print();
        car2.Print();
        car3.Print();

        // Input new color and paint car with white color
        Console.Write("Enter new color to paint white cars: ");
        string newColor = Console.ReadLine();

        car1.PaintCar(newColor);
        car3.PaintCar(newColor);

        // Printing car details after painting
        Console.WriteLine("Car Details After Painting:");
        car1.Print();
        car2.Print();
        car3.Print();

        // Printing car info using the PrintInfo method
        Console.WriteLine("Car Info:");
        Console.WriteLine(car1.PrintInfo());
        Console.WriteLine(car2.PrintInfo());
        Console.WriteLine(car3.PrintInfo());
    }
}