/*
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
лучше обойтись исключительно массивами.

Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

void PrintMass(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write($"{mass[i]} ");
    Console.WriteLine();
}

string[] FillMass()
{
    Console.Write("Input count of string: ");
    int n = int.Parse(Console.ReadLine()!);
    string[] massiv = new string[n];
    for (int i = 0; i < n; i++)
    {
        Console.Write($"{i + 1}: ");
        massiv[i] = Console.ReadLine();
    }
    return massiv;
}

string[] EditMass(string[] mass)
{
    string[] Emass = new string[] { };
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length > 3)
            continue;
        else
            Emass = Emass.Append(mass[i]).ToArray();
    }
    return Emass;
}

Console.Clear();
string[] Fmass = FillMass();
Console.WriteLine();
Console.Write("Fill array of string: ");
PrintMass(Fmass);
Console.WriteLine();
Console.Write("Result: ");
PrintMass(EditMass(Fmass));