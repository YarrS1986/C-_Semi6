// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем. 

// Пример,  b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Clear();

double b1 = Promt("Введи точку b1 = ");
double k1 = Promt("Введи точку k1 = ");
double b2 = Promt("Введи точку b2 = ");
double k2 = Promt("Введи точку k2 = ");

double x = (b2 - b1) / (k2 - k1);
double y = k2 * x + b2;

Console.WriteLine((x, y));



//-------------------------------------------------------
double Promt(string messsage)
{
    Console.Write(messsage);
    string strMassive = Console.ReadLine();
    double answer = double.Parse(strMassive);
    return answer;
}