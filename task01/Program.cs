// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int Num (string arg)
{
    System.Console.WriteLine($"Введите {arg} ");
    return int.Parse(System.Console.ReadLine());
}

int Length = Num("количество вводимых цифр");

System.Console.WriteLine();

int [] numbers = new int [Length];

for (int i = 0; i < numbers.Length; i++)
{
        numbers[i] = Num("число");
}

System.Console.WriteLine();

void PrintArray(int [] numbers)
{
System.Console.Write("[");
for (int i = 0; i < numbers.Length -1; i++)
{
    System.Console.Write(numbers[i] + "; ");
}
System.Console.WriteLine(numbers[numbers.Length -1] + "]");
}

PrintArray(numbers);
System.Console.WriteLine();

int PosNumb = 0;
for (int j = 0; j < numbers.Length; j++)
{
    if (numbers[j] > 0) PosNumb++;
}
System.Console.WriteLine("Количество положительных чисел: " + PosNumb);