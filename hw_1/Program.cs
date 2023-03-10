// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] FillArray(int size, int min, int max)
{
   int[] array = new int[size];
   Random random = new Random();
   if (min >= 100 && max <= 999)
   {
      for(int i = 0; i < size; i++)
      {
         array[i] = random.Next(min, max + 1);
      }
   }
   else 
   {
      Console.Write("Invalid numbers!");
   }
   return array;
}


void PrintArray(int[] array)
{
   Console.Write("[");
   for(int i = 0; i < array.Length - 1; i++) 
   {
      Console.Write($"{array[i]}, ");
   }
   Console.Write($"{array[array.Length - 1]}");
   Console.WriteLine("]");
}


int Count(int[] array)
{
   int counter = 0;
   for(int i = 0; i < array.Length; i++)
   {
      if(array[i] % 2 == 0 && array[i] != 0)
         {
            counter++;
         }
   }
   Console.WriteLine("Количество четных чисел: " + counter);
   return counter;              
}


Console.WriteLine("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите максимальное трехзначное число: ");
int maxVal = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальное трехзначное число: ");
int minVal = Convert.ToInt32(Console.ReadLine());

int[] array = FillArray(length, minVal, maxVal);
PrintArray(array);
Count(array);