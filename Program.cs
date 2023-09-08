// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

// Console.WriteLine ("give me a number m");
// int m = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine ("give me a number n");
// int n = Convert.ToInt32 (Console.ReadLine());

// Console.WriteLine (Ackermann(m,n));

//       static int Ackermann(int m, int n)
//     {
    
//     if ( m==0)
//     {
//         return n + 1;
//     }
    
//     if ( m>0 && n==0)
    
//     {
//         return Ackermann (m-1,1);
//     }
    
//     else 
    
//     {
//         return Ackermann (m-1,Ackermann (m, n - 1));
//     }
//     }

// Задача 64: Задайте значение N. Напишите программу, которая выведет все
//  натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// Console.WriteLine ("give me a number n");
// int n = Convert.ToInt32 (Console.ReadLine());

// PrintNumbers(n);

//       static void PrintNumbers(int n)
//     {
//       Console.Write( n + " " );  
//       if (n>1)
//         {
//         PrintNumbers (n-1);
//         }
        
//     }

// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine ("give me M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("give me N");
int n = Convert.ToInt32(Console.ReadLine());

int result = PrintSumm (m,n);
Console.WriteLine (result);

PrintSumm (m,n);

static int PrintSumm (int m, int n)
{
    if (m==n)
    {
        return m;
    }
    
    return m + PrintSumm (m+1, n);
    
}