/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит 
расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//данный метод создан для получения вводных данных
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

//метод для нахождения длины отрезка в трехмерном пространстве
double Findlength(int xa, int ya, int za, int xb, int yb, int zb)
{
    return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2) + Math.Pow(zb - za, 2));
}

//метод для вывода полученных данных
void PrintData(string prefix, string result)
{
    Console.WriteLine(prefix + result);
}
//получение координат двух точек
int x1 = ReadData("Введите координату X первой точки: ");
int y1 = ReadData("Введите координату Y первой точки: ");
int z1 = ReadData("Введите координату Z первой точки: ");
int x2 = ReadData("Введите координату X второй точки: ");
int y2 = ReadData("Введите координату X второй точки: ");
int z2 = ReadData("Введите координату X второй точки: ");
//получение округленного результата с использованием метода нахождения длины
double result = Math.Round(Findlength(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero);
//вывод результата с использованием метода
PrintData("Расстояние между указанными координатами: ", result.ToString());