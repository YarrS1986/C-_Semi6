// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101             3  -> 11               2  -> 10

Console.Clear();

int Num = Promt("Введи число = ");
Console.Write($"Число {Num} в двоичной системе -> ");

int Len = 0;
for (int number = Num; number > 0; Len++)
{
    number = number / 2;
}

int[] arr = new int[Len];
for (int i = 0; i < Len; i++)
{
    arr[i] = Num % 2;
    Num = Num / 2;
}
SwapArray(arr);
PrintArray(arr);


//--------------------------------------------

int Promt(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    int answer = int.Parse(strMassive);
    return answer;
}

void PrintArray(int[] collection)
{
    for (int index = 0; index <= collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}");
    }
}

void SwapArray(int[] array)
{
    int temp = 0;
    for (int index = 0; index < arr.Length / 2; index++)
    {
        temp = arr[index];
        arr[index] = arr[arr.Length - 1 - index];
        arr[arr.Length - 1 - index] = temp;
    }
}