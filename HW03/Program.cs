/* Задача 23

Напишите программу, которая принимает на вход число (N) 
и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

// Функция ввода данных оператором
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int numberN = ReadInt("Введите число N - ");

for (int i = 1; i <= numberN; i++)
{ 
    Console.Write($"{i*i*i} ");
}
