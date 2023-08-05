// Task 1. Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
/* Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

/* void ShowNums (int num) // метод рекурсии
{
    Console.Write(num + " ");
    if (num > 1 ) ShowNums(num-1);
    
}
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
ShowNums(n); */ 

// Task 2. Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
//  в промежутке от M до N.
//M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

/* int SumElement (int n, int m)
{
    if (n<=m) return SumElement(n+1, m)+n; 
    else return 0; 
}
Console.WriteLine("Введите  начало числового промежутка ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конец числового промежутка ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write(SumElement (n,m)); */

/* Task 3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int Akerman ( int m, int n)
{
    if (m == 0) return n+1;
    if (n == 0) return Akerman(m - 1, 1);
    else return Akerman(m - 1, Akerman(m, n - 1));
}
Console.WriteLine("Введите первый аргумент функции ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второй аргумент функции ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write(Akerman (m,n)); 