//задайте одномерный массив вещественных чисел. Найдите разницу между макс и мин элементов массива
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
int max = numbers[0];
int min = numbers[0];

for (int z = 0; z < numbers.Length; z++)
{
if (numbers[z] > max)
  {
    max = numbers[z];
  }

if (min > numbers[z])
  {
    min = numbers[z];
  } 
}

Console.WriteLine($"всего {numbers.Length} чисел. Макс значение = {max}, Мин значение = {min}");
Console.WriteLine($"разница между МАКС и МИН = {max - min}");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,100);
    }
}

void PrintArray(int[]numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}