// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

int[] arrayNumbers = new int[2];

void EnterNumber(int[] array)
{
    bool isCorrectValue = false;
    while (isCorrectValue == false)
    {
        Console.WriteLine("Enter first number greater 0");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number greater 0");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (secondNumber >= 0 && firstNumber >= 0)
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


int AckermannFunction(int m, int n)
{
    if (m == 0) return n + 1;
    if (n == 0) return AckermannFunction(m - 1, 1);
    if (true) return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

void main()
{
    EnterNumber(arrayNumbers);
    Console.WriteLine($"A({arrayNumbers[0]},{arrayNumbers[1]}) = {AckermannFunction(arrayNumbers[0], arrayNumbers[1])}");
}
main();