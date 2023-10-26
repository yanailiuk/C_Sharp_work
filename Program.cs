using System.Linq;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// 1. Калькулятор: Створіть функцію, яка приймає два операнди і операцію (додавання, віднімання, множення, ділення)
// в якості аргументів і повертає результат операції.

double operand1 = 15;
double operand2 = 3;
char operation = '+';
static double Calculate(double operand1, double operand2, char operation)
        {
            switch (operation)
            {
                case '+':
                    return operand1 + operand2;
                case '-':
                    return operand1 - operand2;
                case '*':
                    return operand1 * operand2;
                case '/':

                    if (operand2 != 0)
                        return operand1 / operand2;
                    else
                    {
                        Console.WriteLine("Ділення на нуль!");
                        return double.NaN; // NaN - Not a Number
                    }
                default:
                    Console.WriteLine("Помилка: Невідома операція");
                    return double.NaN;
            }
        }
double result = Calculate(operand1, operand2, operation);
Console.WriteLine($"Результат: {result}");


// 2. Перевірка простого числа: Розробіть функцію, яка перевіряє, чи є задане число простим і повертає булеве значення.

int numberToCheck = 17;   
bool isPrime = IsPrime(numberToCheck);

Console.WriteLine($"{numberToCheck} є простим числом: {isPrime}");
    
static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }


// 3. Створіть функцію, яка конвертує суму з однієї валюти до іншої, використовуючи поточний обмінний курс.

double amountInUSD = 100.0;
double exchangeRate = 36.5; 

double amountInUAH = ConvertCurrency(amountInUSD, exchangeRate);

Console.WriteLine($"{amountInUSD} USD дорівнює {amountInUAH} UAH за обмінним курсом {exchangeRate}");

static double ConvertCurrency(double amount, double exchangeRate)
{
    return amount * exchangeRate;
}



// 4. Напишіть функцію, яка знаходить найменший і найбільший елементи в заданому масиві та повертає їх.

int[] array = { 4, 7, 1, 9 };
static (int min, int max) FindMinMax(int[] array)
{

    int min = array.Min();
    int max = array.Max();

    return (min, max);
}

var (min, max) = FindMinMax(array);

Console.WriteLine($"Мінімальний елемент: {min}");
Console.WriteLine($"Максимальний елемент: {max}");


// 5. Створіть функцію, яка приймає рядок і підраховує кількість голосних та приголосних букв у ньому.

string inputString = "hello world";
var result1 = CountVowelsAndConsonants(inputString);
Console.WriteLine($"Голосних:{result1.vowelCount}  Приголосних:{result1.consonantCount}");
static (int vowelCount, int consonantCount) CountVowelsAndConsonants(string input)
{
    int vowelCount = 0;
    int consonantCount = 0;

    foreach (char c in input.ToLower())
    {
        if (char.IsLetter(c))
        {
            if ("aeiou".Contains(c))
            {
                vowelCount++;
            }
            else
            {
                consonantCount++;
            }
        }
    }
    return (vowelCount, consonantCount);
}



// 6. Створіть програму, яка обчислює площу та об'єм геометричних фігур (наприклад, круга, прямокутника, куба) на основі введених параметрів.

Console.WriteLine("Обчислення площі та об'єму геометричних фігур");
Console.WriteLine("1. Круг");
Console.WriteLine("2. Прямокутник");
Console.WriteLine("3. Куб");

Console.Write("Виберіть фігуру (1, 2 або 3): ");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        CalculateCircle();
        break;
    case 2:
        CalculateRectangle();
        break;
    case 3:
        CalculateCube();
        break;
    default:
        Console.WriteLine("Невірний вибір");
        break;
}
    
    static void CalculateCircle()
{
    Console.Write("Введіть радіус круга: ");
    double radius = double.Parse(Console.ReadLine());

    double area = Math.PI * Math.Pow(radius, 2);
    Console.WriteLine($"Площа круга: {area:F2}");
}

static void CalculateRectangle()
{
    Console.Write("Введіть довжину прямокутника: ");
    double length = double.Parse(Console.ReadLine());

    Console.Write("Введіть ширину прямокутника: ");
    double width = double.Parse(Console.ReadLine());

    double area = length * width;
    Console.WriteLine($"Площа прямокутника: {area:F2}");
}

static void CalculateCube()
{
    Console.Write("Введіть довжину ребра куба: ");
    double side = double.Parse(Console.ReadLine());

    double volume = Math.Pow(side, 3);
    Console.WriteLine($"Об'єм куба: {volume:F2}");
}


