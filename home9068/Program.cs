// 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkerman(int m, int n)
{
    if (m==0) return n+1;
    if (m > 0 & n==0) return FunctionAkkerman(m-1, 1);
    else return FunctionAkkerman(m-1, FunctionAkkerman(m, n-1));
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
Console.WriteLine(FunctionAkkerman(m, n));