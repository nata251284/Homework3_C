/*
Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/ 
Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
string ThreeDigit = Convert.ToString(number);

if (ThreeDigit[0]==ThreeDigit[4] && ThreeDigit[1]==ThreeDigit[3])
Console.WriteLine ("Число является палиндромом");

else Console.WriteLine ("Число не является палиндромом");
