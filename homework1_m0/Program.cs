// Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// Пример,        0, 7, 8, -2, -2 -> 2                    -1, -7, 567, 89, 223-> 3

Console.Clear();

int[] arr = new int[Promt("Введи количество вводимых чисел = ")];

int PozitiveNum = 0;
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Promt($"Введи {i + 1} число = ");
    if (arr[i] > 0) PozitiveNum++;
}

PromtArray(arr);
Console.Write($" всего {PozitiveNum} положительных чисел.");


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
    for (int index = 0; index < collection.Length - 1; index++)
    {
        Console.Write($"{collection[index]}, ");
    }
    Console.Write($"{collection[collection.Length - 1]}.");
}