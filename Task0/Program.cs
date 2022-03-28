using ClassLib;
using System.Collections.Generic;
using System.Linq;

/*
Console.WriteLine(MyClass.Max(55, 45));
Console.WriteLine(MyClass.Max(65, 78, 36));
Console.WriteLine(String.Join(" ", MyClass.GetArr(10)));
Console.WriteLine(String.Join(" ", MyClass.GetArr(20, 10, 1000)));
Console.WriteLine();

// #22 Найти расстояние между точками в пространстве 2D/3D
Console.WriteLine(MyClass.Dist2point(10, 15, 20, 30));
Console.WriteLine(MyClass.Dist2point(10, 15, 20, 30, 40, 50));
Console.WriteLine();

// #24 Найти кубы чисел от 1 до N
Console.WriteLine(String.Join(", ", MyClass.GetCube1N(10)));
Console.WriteLine();

// #25 Найти сумму чисел от 1 до А
Console.WriteLine(MyClass.GetSumm(100));
Console.WriteLine();

// #27 Определить количество цифр в слове
Console.WriteLine(MyClass.GetNumDigInWord("l6lk365lkj8 58po"));
Console.WriteLine();

// #29 Написать программу вычисления произведения чисел от 1 до N
Console.WriteLine(MyClass.GetMultFrom1toN(11));
Console.WriteLine();

// #31 Задать массив из 8 элементов и вывести их на экран
Console.WriteLine(String.Join(", ", MyClass.GetRndArr(10)));
Console.WriteLine();

//Задача 26: Возведите число А в натуральную степень B, используя цикл.
Console.WriteLine(MyClass.PowA(5, 99));
Console.WriteLine();

// Задача 28: Подсчитайте сумму цифр в числе.
Console.WriteLine(MyClass.SumNum(15));
Console.WriteLine();

// Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
int[] arr = Enumerable.Range(1,10).ToArray();
Console.WriteLine(String.Join(", ", arr));
Console.WriteLine(MyClass.ShowCube(arr));
Console.WriteLine();

// Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
Console.WriteLine(MyClass.GetByteArr(10));
Console.WriteLine();

// #33 Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива
int[] rr = MyClass.GetArr(12, -9, 9);
Console.WriteLine(String.Join(", ", rr));
Console.WriteLine(MyClass.PosSum(rr));
Console.WriteLine(MyClass.NegSum(rr));
Console.WriteLine();

// 35. Определить, присутствует ли в заданном массиве, некоторое число
int[] rr1 = MyClass.GetArr(12, -9, 9);
Console.WriteLine(String.Join(", ", rr1));
Console.WriteLine(MyClass.FindNum(rr1, 1));
Console.WriteLine();

// Возвращает сумму цифр числа с помощью РЕКУРСИИ
Console.WriteLine(MyClass.GetSumRecurs(12345));
Console.WriteLine();

// Реверс числа
Console.WriteLine(MyClass.ReversNumRecurs(12345));
Console.WriteLine();

// Возведение в степень с проверкой на 0
Console.WriteLine(MyClass.PowNumRecours(5, 7));
Console.WriteLine();

// Задача 34: Написать программу для замены элементов массива на противоположные.
int[] arr2 = MyClass.GetRndArr(10);
Console.WriteLine(String.Join(", ", arr2));
Console.WriteLine(String.Join(", ", MyClass.ReversArr(arr2)));
Console.WriteLine();

// Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
// Показать количество нечётных/чётных чисел.
Console.WriteLine(MyClass.NumEvenOdd(10));
Console.WriteLine();

// Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
int[] arr3 = MyClass.GetRndArr(5);
Console.WriteLine(String.Join(", ", arr3));
Console.WriteLine(String.Join(", ", MyClass.SumNegPos(arr3)));
Console.WriteLine();

// Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
float[] arr4 = MyClass.GetArrFloat(10, 0, 100);
Console.WriteLine(String.Join(" ", arr4));
Console.WriteLine(MyClass.DiffMaxMin(arr4));
Console.WriteLine();

Console.WriteLine(MyClass.DecToBaseConvert(100, 8));
Console.WriteLine();
Console.WriteLine(MyClass.DecToBaseConvertRecours(100, 8));
Console.WriteLine();

// Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
List<int> myList= new List<int>(){0,1,2,3,0,4,-6,5,6,0,7,0,8,-15,9,0};
/* 
do{
    Console.Write("Enter number: ");
    myList.Add(int.Parse(Console.ReadLine()));
    Console.Write("Continue?: y,n ");
} while (!(Console.ReadLine() == "n")); 


Console.WriteLine(MyClass.NumberMoreZero(myList));
Console.WriteLine();

// Задача 44: Найти точку пересечения двух прямых заданных 
// уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
Console.WriteLine(MyClass.CrossPoint(10, 15, 15, 10));
Console.WriteLine();

/* Задача 46: Написать программу масштабирования фигуры
        Сделать так, чтобы:
        1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
        2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
        3. В результате были выводились полученные координаты.
        При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"

Console.WriteLine(MyClass.ScalingFigure("(0,0) (2,0) (2,2) (0,2)", 2.5f));
Console.WriteLine();

// Показать двумерный массив размером m×n заполненный целыми числами
MyClass.PrintArr2d(MyClass.GetArr2d(10,10));
System.Console.WriteLine();

// В двумерном массиве n×k заменить четные элементы на противоположные
MyClass.PrintArr2d(MyClass.HonestExch2d(MyClass.GetArr2d(10,10)));
System.Console.WriteLine();

// Проверить является строка номером машины!
// Х000ХХ
System.Console.WriteLine(MyClass.IsStrCarID("A235ТУ"));
System.Console.WriteLine(MyClass.IsStrCarID2("O035ТK"));
Console.WriteLine();

// Проверить "Tom Marvolo Riddle" <=> "I am Lord Voldemort"
// MyClass.AnogramTest("Tom Marvolo Riddle", "I am Lord Voldemort");
Console.WriteLine(MyClass.AnogramTest("Tom Marvolo Riddle", "I am Lord Voldemort"));
Console.WriteLine();

// Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
MyClass.PrintArr2df(MyClass.GetArr2df(5,5));
System.Console.WriteLine();

// Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.
MyClass.PrintArr2d(MyClass.GetArrMplusN(10,5));
System.Console.WriteLine();

// Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
int[,] arr5 = MyClass.GetArr2d(10, 5);
MyClass.PrintArr2d(arr5);
System.Console.WriteLine(MyClass.FindNumInArr2d(arr5, 0));
System.Console.WriteLine();

// Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] arr6 = MyClass.GetArr2d(3, 5);
MyClass.PrintArr2d(arr6);
System.Console.WriteLine(MyClass.FindEverageCilumns(arr6));
System.Console.WriteLine();

// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).
int[,] arr7 = MyClass.GetArr2d(5, 5);
MyClass.PrintArr2d(arr7);
System.Console.WriteLine();
MyClass.PrintArr2d(MyClass.TransArr2d(arr7));
System.Console.WriteLine();

//Написать программу, которая обменивает элементы первой строки и последней строки
int[,] arr8 = MyClass.GetArr2d(5, 5);
MyClass.PrintArr2d(arr8);
System.Console.WriteLine();
MyClass.PrintArr2d(MyClass.FirstEndExchangeArr2d(arr8));
System.Console.WriteLine();

// Составить частотный словарь элементов двумерного массива
int[,] arr9 = MyClass.GetArr2d(5, 5, 10);
MyClass.PrintArr2d(arr9);
System.Console.WriteLine();
System.Console.WriteLine(MyClass.FreqDicArr2d(arr9));;
System.Console.WriteLine("-----------------------------");

// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
int[,] arr10 = MyClass.GetArr2d(5, 5, 10);
MyClass.PrintArr2d(arr10);
System.Console.WriteLine();
//System.Console.WriteLine(String.Join(", ", MyClass.FindMinNumArr2d(arr10)));;
//MyClass.PrintArr2d(MyClass.DelStrAndColArr2d(arr10));;
System.Console.WriteLine("-----------------------------");

// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
//MyClass.PrintPsascalTriangIso(MyClass.GetPascalTiang(11));
System.Console.WriteLine("-----------------------------");

// **Задача 57:** Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
int[,] arr11 = MyClass.GetArr2d(5, 5, 10);
MyClass.PrintArr2d(arr11);
System.Console.WriteLine();
MyClass.PrintArr2d(MyClass.SortLineArr2d(arr11));
System.Console.WriteLine("-----------------------------");

// **Задача 59:** В прямоугольной матрице найти строку с наименьшей суммой элементов.
int[,] arr12 = MyClass.GetArr2d(5, 5, 10);
MyClass.PrintArr2d(arr12);
System.Console.WriteLine();
System.Console.WriteLine(MyClass.FindMinStringArr2d(arr12));;
System.Console.WriteLine("-----------------------------");

// **Задача 61:** Сформировать трёхмерный массив с не повторяющимися двузначными числами и вывести его на экран построчно, 
// с индексами элементов.
MyClass.PrintArr3d(MyClass.GetArr3d(4));
System.Console.WriteLine("-----------------------------");

// **Задача 65:** Спирально заполнить двумерный массив:
MyClass.PrintArr2d(MyClass.FillArrSpiral(5, 5));
System.Console.WriteLine("-----------------------------");

// Задача 61: Найти произведение двух матриц.
int[,] arr14 = {{1,0,2},{2,1,3},{3,1,4}};
MyClass.PrintArr2d(arr14);
System.Console.WriteLine();
int[,] arr15 = {{0,1,3},{4,5,6},{1,2,3}};
MyClass.PrintArr2d(arr15);
System.Console.WriteLine();
MyClass.PrintArr2d(MyClass.MultiplicationTwoMatrix(arr14, arr15));
System.Console.WriteLine("-----------------------------");

// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
// MyClass.PrintPsascalTriangIso2(MyClass.GetPascalTiang(32));
System.Console.WriteLine("-----------------------------");

// Показать натуральные числа от 1 до N, N задано (рекурсивно)
MyClass.PrintNaturNum(20);
System.Console.WriteLine();
System.Console.WriteLine("-----------------------------");
System.Console.WriteLine(MyClass.PrintNaturNumStr(15));
System.Console.WriteLine("-----------------------------");

// Найти сумму цифр числа (рекурсивно)
System.Console.WriteLine(MyClass.SumNumOfNumber(123456789));
System.Console.WriteLine("-----------------------------");

// возведение числа в степень (рекурсивно)
System.Console.WriteLine(MyClass.PowNum(5, 3));
System.Console.WriteLine("-----------------------------");

// Сколько раз пробежит собака между двумя людьми идущими навстречу
System.Console.WriteLine(MyClass.RunTimeDogMenToMen(1, 2, 5, 10000));

// Задача 64: Показать натуральные числа от M до N, N и M заданы (рекурсивно)
Console.WriteLine(MyClass.PrintNaturNum(20, 40));
System.Console.WriteLine("-----------------------------");

// **Задача 69:** Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
Console.WriteLine(MyClass.FindSunNaturNums(20, 40));
System.Console.WriteLine("-----------------------------");

// Написать программу вычисления функции Аккермана
Console.WriteLine(MyClass.Akkerman(2, 3));
System.Console.WriteLine("-----------------------------");

// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
    //для которых каждое следующее равно сумме двух предыдущих.
System.Console.WriteLine(MyClass.Furye(5, 7, 6));



// Работа со строками
string text = "(1,2) (2,3) (4,5) (6,7)"
                .Replace("(", "")
                .Replace(")", "");

var data = text.Split(" ")
            .Select(x => x.Split(","))
          //  .Select(x => (int.Parse(x[0]),int.Parse(x[1])))
            .Select(e => (x: int.Parse(e[0]),y: int.Parse(e[1])))
            .Where(e => e.x % 2 == 0)
            .Select(p => (p.x * 10, p.y))
            .ToArray();
for (int i = 0; i < data.Length; i++)
{
 //   Console.WriteLine(data[i].Item2*10);
 //   Console.WriteLine(data[i].x*10);
    Console.WriteLine(data[i]);
}
System.Console.ReadKey();



// Вывод массива CHAR
Console.WriteLine();
char[] s = {'a', 'b', 'c', 'd'};
int count = s.Length;
int n = 1;
for (int i = 0; i < count; i++)
{
    Console.WriteLine($"{n++, -5} {s[i]}");
}
Console.WriteLine();
System.Console.ReadKey();








// Работа с папками
string path = "D:/Роман/Geek Univercity/Lesson_3/Rep2";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for (int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);    
}
System.Console.WriteLine();



// Вывод структуры каталогов с помощью рекурсии (обход директории)
void CatalogInfo(String path, string ident = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);
    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for (int i = 0; i < catalogs.Length; i++)
    {
        Console.WriteLine($"{ident}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, ident + "  ");
    }

    FileInfo[] files = catalog.GetFiles();

    for (int i = 0; i < files.Length; i++)
    {
        Console.WriteLine($"{ident}{files[i].Name}");
    }
}
CatalogInfo("D:/Роман/Geek Univercity/С#/WorkSpace/Examples");



// Игра Ханойские башни
void Towers(string with = "1", string on = "3", string some = "2", int count = 4)
{
    if (count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if (count > 1) Towers(some, on, with, count - 1);
}
Towers();



//Рекурсивный обход дерева
string emp = string.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3"};
//                0    1    2    3     4    5    6    7    8    9    10   11
void InOderTraversal(int pos = 1)
{
    if (pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if (left < tree.Length && !string.IsNullOrEmpty(tree[left])) InOderTraversal(left);
        Console.WriteLine(tree[pos]);
        if (right < tree.Length && !string.IsNullOrEmpty(tree[right])) InOderTraversal(right);
    }
}
InOderTraversal();
*/

// Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
// для которых каждое следующее равно сумме двух предыдущих.
//System.Console.WriteLine(string.Join(" ", MyClass.Furye(5, 7, 10)));

/*// Генерация слов из алфавита
int n = 0;
void FindWords(string alphabet, char[] word, int length = 0)
{
    
    if (length == word.Length)
    {
        Console.WriteLine($"{n++} {new String(word)}"); 
        return;
    }
    for (int i = 0; i < alphabet.Length; i++)
    {
        word[length] = alphabet[i];
        FindWords(alphabet, word, length + 1);
    }
}
FindWords("asdf", new char[2]);
System.Console.WriteLine();
*/


// MyClass.ShowWordsFromAlphabet("asdf", new char[4]);
// MyClass.ShowWordsFromAlphabet2("asdf", 4, "");

// System.Console.WriteLine(5 + ", " + 7 + ", " + MyClass.Furie2(5, 7, 8));

System.Console.WriteLine(string.Join(" ", MyClass.PrintRelativPrimeNums(1, 50, 42)));
MyClass.PrintRelativPrimeNums2(1, 50, 42);


/* Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления нескольких чисел 
(без разделителя). В массиве data хранится информация о количестве бит, которые занимают числа из массива info. 
Напишите программу, которая составит массив десятичных представлений чисел массива data с учётом информации из массива info.
Комментарий: первое число занимает 2 бита (01 -> 1); 
второе число занимает 3 бита (111 -> 7); 
третье число занимает 3 бита (000 -> 0); 
четвёртое число занимает 1 бит (1 -> 1)
входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
*/

// System.Console.WriteLine(MyClass.ConvertBinToIntArr(new int[]{0, 1, 1, 1, 1, 0, 0, 0, 1 }, new int[]{2, 3, 3, 1 }));

