// 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
int FindSumNumbers(int m, int n)
{
    if (m==n) return m;
    return (m + FindSumNumbers(m+1, n));  
}

int EnterData(string text)
{
    Console.WriteLine(text);
    int num = int.Parse(Console.ReadLine());
    return num;
} 
// Ввести число A
int m = EnterData("Введите число M: ");
int n = EnterData("Введите число N: ");

// найти степень числа
FindSumNumbers(m, n);
// вывести результат
Console.WriteLine(FindSumNumbers(m, n));