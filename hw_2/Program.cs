// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] FillArray(int size)
{
   int[] array = new int[size];
   Random random = new Random();
   for(int i = 0; i < size; i++)
   {
    array[i] = random.Next(0, 50);
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

int SumEvenPosition(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2 == 1 && i != 0)
        {
            sum = sum + array[i];
        }
    }
    Console.WriteLine("Сумма элементов, стоящих на нечётных позициях: " + sum);
    return sum;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(size);
PrintArray(arr);
SumEvenPosition(arr);