﻿//Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.


int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int k1 = Num("k1");
int b1 = Num("b1");
int k2 = Num("k2");
int b2 = Num("b2");


//не решено, разобраться не получилось. Все варианты подобных программ используют классы и ключевые слова, которые я не проходил. Скорее всего я не понял что то из семинаров на базовом уровне.
