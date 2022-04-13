// Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// Пример        [1 2 3 4 5] -> [5 4 3 2 1]            [6 7 3 6] -> [6 3 7 6]

Console.Clear();
int[] arr = new int[Promt("Введи длину массива = ")];

FillArray(arr);
PromtArray(arr);


int tempNum = 0;
for (int index = 0; index < arr.Length / 2; index++)
{
    tempNum = arr[index];
    arr[index] = arr[arr.Length - 1 - index];
    arr[arr.Length - 1 - index] = tempNum;
}

PromtArray(arr);


//--------------------------------------------
int Promt(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    int answer = int.Parse(strMassive);
    return answer;
}

void FillArray(int[] array)
{
    for (int index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(100, 1000);
    }
}

void PromtArray(int[] collection)
{
    Console.Write($"[ ");
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.WriteLine($"{collection[collection.Length - 1]} ]");
}