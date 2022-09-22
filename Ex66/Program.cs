// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Summ(int M, int N)
{   
    int sum = 0;
    if (M <= N) return sum = sum + M + Summ(M+1,N);
    else return 1;
} 

int s = Summ(4,8);
System.Console.WriteLine(s-1);

