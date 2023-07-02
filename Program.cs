// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


void numExp (int numberA, int numberB)
{
    int res = 1;
    for (int i = 1; i <= numberB; i++)
    {
        res = res * numberA;
    }
    Console.WriteLine($"Результат возведения в {numberB} степень числа {numberA} равен {res}");
}

Console.WriteLine("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень: ");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB > 0)
    numExp(numA, numB);
else
    Console.WriteLine("Степень должна быть больше 0");



// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


int sumofElem (int number)
{
    int sum = 0;

    while (number > 0)
    {
        sum = sum + number % 10;
        number = number/10;
    }
    return sum;
}

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int result = sumofElem(num);
Console.Write($"Сумма цифр числа {num} равна {result}");



// Задача 29: Напишите программу, которая задаёт массив из произвольного кличества элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int [] CreateNewArray (int size_array)
{
    int [] randomArray = new int[size_array];    
    for (int i = 0; i < size_array; i++)
    {
        randomArray[i] = new Random().Next(0,100);
    }
    return randomArray;
}

void PrintArray (int [] array_to_print)
{
    Console.Write("Ваш массив [");
    for (int i = 0; i < array_to_print.Length; i++)
        Console.Write (array_to_print[i] + ", ");
    Console.WriteLine("\b\b]");
}

Console.WriteLine("Введите количество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int [] firstArray = CreateNewArray(size);
PrintArray(firstArray);

