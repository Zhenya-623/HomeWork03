﻿/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).

14212 -> нет

12821 -> да

23432 -> да
*/


//данный метод создан для получения вводных данных
int ReadData(string line)
{
    Console.WriteLine(line);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}
//метод для проверки является ли пятизначное число палиндромом
string PolyTest(int num)
{
    if (num/10000 == num%10 && (num/1000)%10 == (num/10)%10)
    return "Число является палиндромом";
    else
    return "Число не является палиндромом";
}
//метод для вывода полученных данных
void PrintData(string result)
{
    Console.WriteLine(result);
}
//строчка кода, в которой мы обращаемся к методу ввода данных  
//и просим у пользователя ввести пятизначное число
int number = ReadData("Введите пятизначное число");
//создал переменную, которая будет формировать строку (string) с ответом после использования
//метода проверки пятизначного числа
string answer = PolyTest(number);
//проверка, чтобы пользователь вводил корректное значение для проверки
if (number>9999 && number <100000)
{
PrintData(answer);
}
else
PrintData("Вы ввели не корректное значение");