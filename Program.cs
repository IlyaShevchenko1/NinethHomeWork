// Nineth homework.

// Task 64. Задайте значение N. Напишите программу, которая выведет все натуральные числа
// в промежутке от N до 1. Выполнить с помощью рекурсии.

/*

void PrintNumbers(int number)
{
    if(number == 1) Console.Write(1);
    else
    {
        Console.Write(number + " ");
        PrintNumbers(number - 1);      
    } 
}

Console.Write("Введите положительное натуральное число: ");
int num = Convert.ToInt32(Console.ReadLine());
PrintNumbers(num);

*/

// Task 66. Задайте значения M и N. Напишите программу, которая найдет сумму натуральных
// элементов в промежутке от M до N. 

/*

int SumOfNumbers(int numberM, int numberN)
{
    int sum = 0;
    if(numberM == numberN) return numberN;   
    else
    {
        sum = sum + numberM;
        return sum + SumOfNumbers(numberM + 1, numberN);               
    }
}

Console.Write("Input a first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Input a second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int start = 0;
int finish = 0;

if(num1 >= num2)
{
    finish = num1;
    start = num2;
}
else
{
    finish = num2;
    start = num1;
}

Console.WriteLine(SumOfNumbers(start, finish));

*/


// Task 68. Напишите программму вычисления функции Аккермана с помощью рекурсии. Даны
// два неотрицательных числа m и n. 

/*

int AckermannFunction(int m, int n)
{
  if (m == 0) return n + 1;
  else if((m != 0) && (n == 0)) return AckermannFunction(m - 1, 1);
  else return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
}

int firstNumber = new Random().Next(0, 5);
int secondNumber = new Random().Next(0, 5);

int Acker = AckermannFunction(firstNumber, secondNumber);
Console.WriteLine($"Функция Аккермана для пары чисел {firstNumber} и {secondNumber} равна {Acker}");

*/