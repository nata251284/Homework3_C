﻿/*
Задача 21

Напишите программу, которая принимает на вход координаты двух точек 
и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
*/ 

int GetNumber(string message)
{
    int result = 0;

    while(true)
    {
        Console.Write(message);

        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }

    return result;
}

double Distance (int x1, int y1, int z1, int x2, int y2,  int z2)
{
    double dist = Math.Sqrt (Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2) + Math.Pow((z2-z1),2));
    //double dist = Math.Pow((x2-x1),2);
    //double dist = Math.Pow((y2-y1),2);
    //double dist = Math.Pow((z1-z2), 2);
    return dist; 
}

int x1 = GetNumber ("Введите значение x1: ");
int y1 = GetNumber ("Введите значение y1: ");
int z1 = GetNumber ("Введите значение z1: ");
int x2 = GetNumber ("Введите значение x2: ");
int y2 = GetNumber ("Введите значение y2: ");
int z2 = GetNumber ("Введите значение z2: ");

double result = Distance(x1, y1, z1, x2, y2, z2);
Console.WriteLine($"расстояние между ними в 3D пространстве {result:0.###}");
