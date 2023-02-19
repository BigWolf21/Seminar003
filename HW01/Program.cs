/* Задача 19
Напишите программу, 
которая принимает на вход пятизначное 
число и проверяет, является ли оно 
палиндромом. */

// 14212 -> нет
// 12821 -> да
// 23432 -> да

int[] value = new int[5];
int index;
index = 0;
while (index < 5)
{
  value[index] = new Random().Next(0, 10);
  index++;
}
Console.WriteLine(value[0].ToString() + value[1] + value[2] + value[3] + value[4]);

if (value[0] == value[4])
{
  if (value[1] == value[3])
  {
    Console.WriteLine("Число палиндром!");
  }
  else
  {
    Console.WriteLine("Число не палиндром!");
  }
}
else
{
  Console.WriteLine("Число не палиндром!");
}