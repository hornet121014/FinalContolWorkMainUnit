# Описание решения задачи

## Условие задачи:
Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

## Результат выполнения программы:

|№ п/п|**Входные данные:**|**Выходные данные:**|
|:---:|:---|:---|
|1|[“Hello”, “2”, “world”, “:-)”]|[“2”, “:-)”]|
|2|[“1234”, “1567”, “-2”, “computer science”]|[“-2”]|
|3|[“Russia”, “Denmark”, “Kazan”]|[ ]|

## Порядок решения задачи:

Для выполнения условий данной задачи будем использовать 3 метода работы с массивами:
1. Вывод массива на экран
2. Заполнение массива данными, введенных с клавиатуры пользователем
3. Выборка элементов массива, удовлетворяющих условию задачи

## Код программы:

1. Создаем метод вывода массива на экран:

```c#
void PrintMass(string[] mass)
{
    for (int i = 0; i < mass.Length; i++)
        Console.Write($"{mass[i]} ");
    Console.WriteLine();
}
```

2. Создаем метод заполнения массива элементами, вводимых с клавиатуры пользователем:

```c#
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
```
3. Создаем метод выборки элементов массива, удовлетворяющих условию задачи:

```c#
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
```
4. Очищаем консоль при запуске программы:

```c#
Console.Clear();
```
5. Создаем массив Fmass и выводим его на экран:

```c#
string[] Fmass = FillMass();
Console.WriteLine();
Console.Write("Fill array of string: ");
PrintMass(Fmass);
```
6. Выводим на экран массив, элементы которого удовлетворяют условию задачи:

```c#
Console.WriteLine();
Console.Write("Result: ");
PrintMass(EditMass(Fmass));
```