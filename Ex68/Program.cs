// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29
int Akkerman(int m, int n)
{   
    int res = 0;
    if (m == 0) return res = res + n+1;
    if (m > 0 && n == 0) return res = res + Akkerman(m-1,1);
    if (m > 0 && n > 0) return res = res + Akkerman(m-1,Akkerman(m,n-1));
    else return 0;
}

System.Console.WriteLine("Enter m");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter n");
int n = Convert.ToInt32(Console.ReadLine());
int res = Akkerman(n,m);
System.Console.WriteLine(res);