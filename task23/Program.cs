/*
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

5 ->
1 | 1
2 | 8
3 | 27
4 | 64
5 | 125
*/
//метод ввода данных
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
//метод вывода данных
void PrintData(string result)
{
    Console.WriteLine(result);
}
//метод в котором числа можно сложить в строку с табуляцией, 
//позволяющий при измении параметра запроса выводить числа возведенные в любые степени
string LineNum(int numN, int p)
{
    string outline = "1";
    for (int i = 2; i <= numN; i++)
    {
        outline = outline + "\t" + Math.Pow(i, p);
    }
    return outline;
}

int numN = ReadData("Введите число N: ");
string lineTop = LineNum(numN, 1);
string lineDown = LineNum(numN, 3);

if (numN > 0)
{
//вывод чисел от одного до N
PrintData(lineTop);
//вывод чисел возведенных в 3 степень от 1 до N
PrintData(lineDown);
}
else 
PrintData("Число не является натуральным");