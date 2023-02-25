using static Library;
/* Задача 19
Напишите программу, 
которая принимает на вход пятизначное 
число и проверяет, является ли оно 
палиндромом. */

// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Решение задачи
int index = 0;
int size = GetNumber("Введите размер массива ");
int num = GetNumber("Введите число для проверки палиндромности ");
int [] value = CreateArray(size);
while (num > 0)
{
  value[index] = num % 10;
  num = num / 10;
  Console.Write(value[index]);
  index++;
}

if (value[0] == value[4] && value[1] == value[3])
{
  Console.WriteLine(" - Число палиндром!");
}
else
{
  Console.WriteLine(" - Число не палиндром!");
}