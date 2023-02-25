public class Library
{
  // 1. метод ввода числа с терминала
public static int GetNumber(string text)
{
  Console.WriteLine(text);
  return Convert.ToInt32(Console.ReadLine());
}
// 2. метод создания массива
public static int[] CreateArray(int size)
{
  return new int[size];
}

// 3. метод записи чисел
public static string Evennumbers(int N)
{
  string output = String.Empty;
  int index = 2;
  while (index <= N )
  {
    output = output + index + " ";
    index++;
  }
  return output;
}

// 3.1 метод заполнения массива руками
public static void FillByUser(int[] array)
{
  int size = array.Length;
  int index = 0;
  while (index < size)
  {
    array[index] = GetNumber("Введите " + index + "элемент: ");
    index++;
  }

}

// 3.2 метод заполнения массива рандомно
public static void FillArrayRandom(int[] collection)
{
  int size = collection.Length;
  int index = 0;
  while (index < size)
  {
    collection[index] = new Random().Next(0, 10);
    index++;
  }

}

// 5. метод печати массива
public static string Print(int[] array)
{
  string result = String.Empty;
  int len = array.Length;
  int index = 0;
  while (index < len)
  {
    result = result + " " + array[index];
    index++;
  }
  return result;
}
}