// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""

int[] WriteNubmers(int M, int N)
{   
    int[] mas = new int[N-M+1];
    while (M <= N)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = M;
            M++;   
        }  
        
    }
    
    return mas;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


int[] array = WriteNubmers(4,8);
PrintArray(array);