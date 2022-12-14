/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */


int size = ReadInt("Введите размер массива: ");
int[] numbers = new int[size];
int count = 0; 
int sum = 0; 

FillArrayRandomNumbers(numbers, -10, 10);
WriteArray(numbers);

for (int i=0; i < numbers.Length; i++)
{
   if (i % 2 == 0)
    {
       
        count = count + 1;
    }
    else
    {
        sum = sum + numbers[i];
        count=count+0;
    }
}

Console.WriteLine("Сцмма элементов, стоящих на нечетных позициях " + sum);




void FillArrayRandomNumbers(int[] array, int min, int max)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
