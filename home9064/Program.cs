/// 64 Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
int NaturalNumber(int num)
{
    if (num==1) return 1;
    else 
    {
        Console.Write($"{NaturalNumber(num-1)}, ");
        return num;
    }
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
} 
// Ввести число N
int num = EnterData("Введите число N: ");
// найти натуральные числа
NaturalNumber(num);
// вывести натуральные числа
Console.WriteLine(num); 
