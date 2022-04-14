// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

Console.Clear();

int[] arr = new int[Promt("Введи длину массива = ")];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Promt($"Введи число {i} массива = ");
}

int[] array = new int[arr.Length];

Array.Copy(arr, array, arr.Length);

Console.Write($"Заполненный масив ");
PromtArray(arr);
Console.Write($" -> скопированный массив ");
PromtArray(array);

//-------------------------------------------------------
int Promt(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    int answer = int.Parse(strMassive);
    return answer;
}

void PromtArray(int[] collection)
{
    Console.Write($"[ ");
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.Write($"{collection[collection.Length - 1]} ]");
}