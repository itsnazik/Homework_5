// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива

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

int FindMaxMinDiff(int[] array)
{
    int i = 0;
    int max = array[i];
    int min = array[i];

    for(i = 0; i < array.Length; i++)
    {
        if(array[i] > max) 
        {
            max = array[i];
        }
        else if(array[i] < min)
        {
            min = array[i];
        }
    }
    Console.WriteLine("Разница между максимальным и минимальным элементом: " + $"{max-min}");
    return 0;
}

Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = FillArray(size);
PrintArray(arr);
FindMaxMinDiff(arr);