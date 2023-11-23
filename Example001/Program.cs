// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

int[] arrayNumbers = new int[2];

void EnterNumber(int[] array)
{
    bool isCorrectValue = false;
    while (isCorrectValue == false)
    {
        Console.WriteLine("Enter first number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number greater than the first");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (secondNumber > firstNumber)
        {
            array[0] = firstNumber;
            array[1] = secondNumber;
            isCorrectValue = true;
        }
        else
        {
            Console.WriteLine("You entered an incorrect range of numbers!");
            Console.WriteLine("Try again:");
        }
    }
}

string GetValues(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber.ToString();
    return (firstNumber + ", " + GetValues(firstNumber + 1, secondNumber));
}

void PrintValues()
{
    Console.WriteLine(GetValues(arrayNumbers[0], arrayNumbers[1]));
}

void Main()
{
    EnterNumber(arrayNumbers);
    PrintValues();
}

Main();