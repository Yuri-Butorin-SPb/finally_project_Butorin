string[] arr = new string [4];
int count = arr.Length;

for (int i = 0; i < count; i++)
{
    Console.WriteLine($"Введите {i+1} слово: ");
    arr[i] = Console.ReadLine();
}

int sum = 0; // Считаю, сколько элементов массива имеют 3 и менее символов

for (int i = 0; i < count; i++)
{
    if (arr[i].Length <= 3) sum++;
}


string[] arr2 = new string [sum]; // Добавляю элементы с первого массива во второй

for (int i = 0; i < count; i++) 
{
    if (arr[i].Length <= 3) arr2[i] = arr[i];
}


PrintArray(arr2);


void PrintArray(string[] array) // Печатаю второй массив
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
