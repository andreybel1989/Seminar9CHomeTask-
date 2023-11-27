// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


int[] arrayNumbers = new int[2];
int[] EnterNumber(int[] array)
{   
    bool isCorrectValue = false;
    while (isCorrectValue == false)
    {
        Console.WriteLine("Enter first number");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number greater than the first");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (secondNumber >= firstNumber)
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
    return arrayNumbers;
}

int sumNumber(int firstNumber, int secondNumber)
{
    
    if(firstNumber == secondNumber) return firstNumber;
    return firstNumber + sumNumber(firstNumber + 1, secondNumber);
}

void main()
{
    EnterNumber(arrayNumbers);
    Console.WriteLine($"sum natural numbers in the interval from {arrayNumbers[0]} : {arrayNumbers[1]} => {sumNumber(arrayNumbers[0],arrayNumbers[1])}");
}
main();