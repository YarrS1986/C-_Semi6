// Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


Console.Clear();

int A = Promt("Введи длину стороны А = ");
int B = Promt("Введи длину стороны B = ");
int C = Promt("Введи длину стороны C = ");

if (A + B > C && A + C > B && B + C > A)
{
    Console.WriteLine($"Такой треугольник может существовать");
}
else Console.WriteLine($"Такой треугольник не может существовать");




int Promt(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    int answer = int.Parse(strMassive);
    return answer;
}
