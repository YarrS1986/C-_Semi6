// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Пример,      Если N = 5 -> 0 1 1 2 3            Если N = 3 -> 0 1 1        Если N = 7 -> 0 1 1 2 3 5 8

Console.Clear();
int Num = Promt("Введи число = ");

if (Num > 0)
{
    double[] arr = new double[Num + 1];
    arr[2] = 1;
    arr[1] = 0;
    Console.WriteLine($"f({1}) = {arr[1]}");
    Console.WriteLine($"f({2}) = {arr[2]}");
    for (int i = 3; i <= arr.Length - 1; i++)
    {
        arr[i] = arr[i - 1] + arr[i - 2];
        Console.WriteLine($"f({i}) = {arr[i]}");
    }
}
else Console.WriteLine($"Введи положительное число!");


//------------------------------
int Promt(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    int answer = int.Parse(strMassive);
    return answer;
}