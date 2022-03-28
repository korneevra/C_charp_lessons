namespace ClassLib;
using System.Collections.Generic;

public class MyClass
{
    // Определяет максимальное число из двух
    public static int Max(int a, int b)
    {
        if (a > b) return a;
        else
        {
            return b;
        }
    }

    // Определяет максимальное число из трех

    public static int Max(int a, int b, int c)
    {
        if (a > b)
        {
            if (a > c) return a;
            else return c;
        }
        else
        {
            if (b > c) return b;
            else return c;
        }

    }
    ///<summary>
    /// Get array with defined size
    ///</summary>
    public static int[] GetArr(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(100);
        }
        return arr;
    }

    ///<summary>
    /// Get array with defined size and range
    ///</summary>
    public static int[] GetArr(int size, int min, int max)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(min, max + 1);
        }
        return arr;
    }

    // Get Float array with defined size and range
    public static float[] GetArrFloat(int size, int min, int max)
    {
        float[] arr = new float[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = new Random().Next(min, max + 1);
        }
        return arr;
    }


    // #22 Найти расстояние между точками в пространстве 2D/3D
    public static double Dist2point(double x1, double y1, double x2, double y2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    }

    public static double Dist2point(double x1, double y1, double z1, double x2, double y2, double z2)
    {
        return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    }

    // #24 Найти кубы чисел от 1 до N
    public static double[] GetCube1N(int n)
    {
        double[] arr = new double[n];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Math.Pow(Convert.ToDouble(i + 1), 3);
        }
        return arr;
    }

    // #25 Найти сумму чисел от 1 до А
    public static int GetSumm(int a)
    {
        return (a * (a + 1)) / 2;
    }

    // #27 Определить количество цифр в слове
    public static int GetNumDigInWord(string s)
    {
        int n = 0;
        // int r;
        for (int i = 0; i < s.Length; i++)
        {
            // if (int.TryParse(s[i].ToString(), out r)) n++;
            if (char.IsDigit(s[i])) n++;
        }
        // foreach (char c in s)
        // {
        //    if(((byte)c > 47 && (byte)c < 58)) n++;
        // }
        return n;
    }

    // #29 Написать программу вычисления произведения чисел от 1 до N
    public static int GetMultFrom1toN(int n)
    {
        int res = 1;
        for (int i = 2; i <= n; i++)
        {
            res = res * i;
        }
        return res;
    }

    // #31 Задать массив из 8 элементов и вывести их на экран
    public static int[] GetRndArr(int n)
    {
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = new Random().Next(0, 100);
        }
        return arr;
    }

    // Задача 26: Возведите число А в натуральную степень B, используя цикл.
    public static double PowA(int a, int b)
    {
        if (b < 0) return -1;
        if (b == 0) return 1;
        double res = a;
        for (int i = 1; i < b; i++)
        {
            res *= a;
        }
        return res;
    }

    // Задача 28: Подсчитайте сумму цифр в числе.
    public static int SumNum(int a)
    {
        string ss = Math.Abs(a).ToString();
        int sum = 0;
        for (int i = 0; i < ss.Length; i++)
        {
            sum += (int)Char.GetNumericValue(ss[i]);
        }
        return sum;
    }

    // Задача 30: Покажите кубы чисел, заканчивающихся на чётную цифру.
    public static string ShowCube(int[] arr)
    {
        string ss = "";
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                ss += Math.Pow(arr[i], 3).ToString() + ", ";
            }
        }
        return ss;
    }

    // Задача 32: Задайте массив из восьми элементов, заполненных нулями и единицами. Выведите их на экран
    public static string GetByteArr(int size)
    {
        byte[] arr = new byte[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = (byte)new Random().Next(0, 2);
        }
        return String.Join(", ", arr);
    }

    // Находит сумму положительных элементов массива
    public static int PosSum(int[] arr)
    {
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] > 0) res += arr[i];
        }
        return res;
    }
    // Находит сумму отрицательных элементов массива
    public static int NegSum(int[] arr)
    {
        int res = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0) res += arr[i];
        }
        return res;
    }

    // 35. Определить, присутствует ли в заданном массиве, некоторое число
    public static string FindNum(int[] arr, int n)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == n) return "Yes";
        }
        return "No!";
    }

    // Возвращает сумму цифр числа с помощью РЕКУРСИИ
    public static int GetSumRecurs(int n)
    {
        if (n < 10) return n;
        else
        {
            return n % 10 + GetSumRecurs(n / 10);
        }
    }

    // Реверс числа
    public static string ReversNumRecurs(int n)
    {
        if (n < 10) return n.ToString();
        else
        {
            return (n % 10).ToString() + ReversNumRecurs(n / 10).ToString();
        }
    }

    // Возведение в степень с проверкой на 0
    public static int PowNumRecours(int a, int n)
    {
        if (n == 0) return 1;
        if (n == 1) return a;
        return a *= PowNumRecours(a, n - 1);
    }

    // Задача 34: Написать программу для замены элементов массива на противоположные.
    public static int[] ReversArr(int[] arr)
    {
        int[] res = new int[arr.Length];
        int j = arr.Length - 1;
        for (int i = 0; i < arr.Length; i++)
        {
            res[i] = arr[j - i];
        }
        return res;
    }

    // Revers string.
    public static string ReversStr(string ss)
    {
        string ress = "";
        for (int i = ss.Length - 1; i >= 0; i--)
        {
            ress += ss[i];
        }
        return ress;
    }


    // Задача 36: Задать массив, заполнить случайными положительными трёхзначными числами. 
    // Показать количество нечётных/чётных чисел.
    public static string NumEvenOdd(int N)
    {
        int[] arr = new int[N].Select(x => new Random().Next(1, 1000)).ToArray();
        int e = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0) e += 1;
        }
        return $"В массиве: {String.Join(", ", arr)}, содержится {e} четных и {arr.Length - e} нечетных чисел.";
    }

    // Задача 38: Найти сумму чисел одномерного массива, стоящих на нечётной позиции.
    public static int SumNegPos(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i += 2)
        {
            sum += arr[i];
        }
        return sum;
    }

    // Задача 40: В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
    public static float DiffMaxMin(float[] arr)
    {
        float min = 0;
        float max = 0;
        if (arr[0] > arr[1])
        {
            max = arr[0];
            min = arr[1];
        }
        else
        {
            max = arr[1];
            min = arr[0];
        }
        for (int i = 2; i < arr.Length; i++)
        {
            if (arr[i] > max) max = arr[i];
            else if (arr[i] < min) min = arr[i];
        }
        return max - min;
    }

    // Перевести десятичное число в двоичный код
    public static string DecToBaseConvert(int num, int b)
    {
        string ress = "";
        while (num >= b)
        {
            ress = (num % b).ToString() + ress;
            num = num / b;
        }
        return num.ToString() + ress;
    }
    public static string DecToBaseConvertRecours(int num, int b)
    {
        if (num < b) return num.ToString();
        return DecToBaseConvertRecours(num / b, b) + (num % b).ToString();
    }

    // Задача 42: Определить, сколько чисел больше 0 введено с клавиатуры.
    public static int NumberMoreZero(List<int> input)
    {
        return input.Where(x => x > 0).ToArray().Length;
    }

    // Задача 44: Найти точку пересечения двух прямых заданных 
    // уравнением y = k1 * x + b1, y = k2 * x + b2, если b1, k1, b2 и k2 заданы
    public static string CrossPoint(int k1, int k2, int b1, int b2)
    {
        int x = (b2 - b1) / (k1 - k2);
        int y = (k1 * x) + b1;
        return $"Coordinates of crosspoint is: ({x}, {y})";
    }

    /* Задача 46: Написать программу масштабирования фигуры
        Сделать так, чтобы:
        1. Вершины фигуры задавались списком (в одну строку). Например: "(0,0) (2,0) (2,2) (0,2)".
        2. Коэффициент масштабирования k задавался отдельно — 2 или 4 или 0.5.
        3. В результате были выводились полученные координаты.
        При k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
    */
    public static string ScalingFigure(string coord, float k)
    {
        float[] a = coord.Where(x => Char.IsDigit(x)).Select(x => (x - '0') * k).ToArray();
        return $"If k = {k} the coordinates is: ({a[0]},{a[1]}) ({a[2]},{a[3]}) ({a[4]},{a[5]}) ({a[6]},{a[7]})";
    }

    // Возвращает случайно заполненный 2Д массив
    public static int[,] GetArr2d(int sizeM, int sizeN)
    {
        int[,] arr = new int[sizeM, sizeN];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(100);
            }
        }
        return arr;
    }
    public static int[,] GetArr2d(int sizeM, int sizeN, int max)
    {
        int[,] arr = new int[sizeM, sizeN];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().Next(max);
            }
        }
        return arr;
    }
    // Возвращает случайно заполненный 2Д массив Float
    public static float[,] GetArr2df(int sizeM, int sizeN)
    {
        float[,] arr = new float[sizeM, sizeN];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                arr[i, j] = new Random().NextSingle() * 100;
            }
        }
        return arr;
    }

    // Показать двумерный массив размером m×n заполненный целыми числами

    public static void PrintArr2d(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j],5}");
            }
            Console.WriteLine();
        }
    }


    // В двумерном массиве n×k заменить четные элементы на противоположные
    public static int[,] HonestExch2d(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] % 2 == 0) arr[i, j] *= -1;
            }
        }
        return arr;
    }


    // Проверить является строка номером машины!
    // Х000ХХ
    // A, B, C, E, H, K, M, O, P, T, X, Y
    public static bool CarIDLetterChk(char s)
    {
        string ss = "ABCEHKMOPTXYАВСЕНКМОРТХУ";
        for (int i = 0; i < ss.Length; i++)
        {
            if (s == ss[i]) return true;
        }
        return false;

    }
    public static bool IsStrCarID(string carID)
    {
        if (carID.Length < 7 &&
            CarIDLetterChk(carID[0]) &&
            Char.IsDigit(carID[1]) &&
            Char.IsDigit(carID[2]) &&
            Char.IsDigit(carID[3]) &&
            CarIDLetterChk(carID[4]) &&
            CarIDLetterChk(carID[5]))
            return true;
        return false;

    }
    public static bool IsStrCarID2(string carID)
    {
        string ss = "0123456789ABCEHKMOPTXYАВСЕНКМОРТХУ";
        if (carID.Length < 7
        && (ss.IndexOf(carID[0]) > 9)
        && (ss.IndexOf(carID[1]) < 10)
        && (ss.IndexOf(carID[2]) < 10)
        && (ss.IndexOf(carID[3]) < 10)
        && (ss.IndexOf(carID[4]) > 9)
        && (ss.IndexOf(carID[5]) > 9))
            return true;
        return false;
    }
    // Проверить "Tom Marvolo Riddle" <=> "I am Lord Voldemort"
    public static bool AnogramTest(string ss1, string ss2)
    {
        char[] ch1 = ss1.Replace(" ", "").ToLower().ToArray().OrderBy(x => x).ToArray();
        char[] ch2 = ss2.Replace(" ", "").ToLower().ToArray().OrderBy(x => x).ToArray();
        /*ss2 = ss2.Replace(" ", "").ToLower();
        char[] ch1 = ss1.ToCharArray();
        char[] ch2 = ss2.ToCharArray();
        Array.Sort(ch2);
        Array.Sort(ch1);*/
        return (String.Join("", ch1) == String.Join("", ch2));
    }

    // Задача 49: Показать двумерный массив размером m×n, заполненный вещественными числами.
    public static void PrintArr2df(float[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"{arr[i, j]} \t");
            }
            Console.WriteLine();
        }
    }

    // Задача 51: Задать двумерный массив следующим правилом: Aₘₙ = m+n.
    public static int[,] GetArrMplusN(int m, int n)
    {
        int[,] arr = new int[m, n];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                arr[i, j] = i + j;
            }
        }
        return arr;
    }

    // Задача 53: В двумерном массиве показать позиции числа, заданного пользователем, или указать, что такого элемента нет.
    public static string FindNumInArr2d(int[,] arr, int n)
    {
        string res = "";
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] == n) res += $"({i + 1}, {j + 1})  ";
            }
        }
        return res != "" ? res : "No such element!";

    }

    // Задача 55: Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
    public static string FindEverageCilumns(int[,] arr)
    {
        int str = arr.GetLength(0);
        string res = string.Empty;
        int sum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            for (int j = 0; j < str; j++)
            {
                sum += arr[j, i];
            }
            res += $"{i + 1}). {(float)sum / str};   ";
            sum = 0;
        }
        return res;
    }

    // Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
    // что это невозможно (в случае, если матрица не квадратная).
    public static int[,] TransArr2d(int[,] arr)
    {
        int[,] res = new int[arr.GetLength(0), arr.GetLength(1)];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                res[i, j] = arr[j, i];
            }
        }
        return res;
    }

    //Написать программу, которая обменивает элементы первой строки и последней строки
    public static int[,] FirstEndExchangeArr2d(int[,] arr)
    {
        //int temp = 0;
        int n = arr.GetLength(0) - 1;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            /*temp = arr[n, i];
            arr[n, i] = arr[0, i];
            arr[0, i] = temp;*/
            (arr[n, i], arr[0, i]) = (arr[0, i], arr[n, i]);
        }
        return arr;
    }

    // Составить частотный словарь элементов двумерного массива
    public static string FreqDicArr2d(int[,] arr)
    {
        int[] res = new int[10];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                res[arr[i, j]] += 1;
            }
        }
        return string.Join(", ", res);
    }


    // В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.
    public static int[] FindMinNumArr2d(int[,] arr)
    {
        int min = arr[0, 0];
        int[] res = new int[2];
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                    res[0] = i;
                    res[1] = j;
                }
            }
        }
        return res;
    }
    public static int[,] DelStrAndColArr2d(int[,] arr)
    {
        int i, j, n, m;
        int[] coord = new int[2];
        coord = FindMinNumArr2d(arr);
        int[,] res = new int[arr.GetLength(0) - 1, arr.GetLength(1) - 1];
        for (i = n = 0; i < arr.GetLength(0); i++, n++)
        {
            for (j = m = 0; j < arr.GetLength(0); j++, m++)
            {
                if (j == coord[1]) j++;
                if (i == coord[0]) i++;
                res[n, m] = arr[i, j];
            }
        }
        return res;
    }

    // Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника
    public static int[,] GetPascalTiang(int n)
    {
        int[,] arr = new int[n, n];
        arr[0, 0] = 1;
        for (int i = 1; i < n; i++)
        {
            arr[i, 0] = 1;
            arr[i, i] = 1;
        }
        for (int i = 2; i < n; i++)
        {
            for (int j = 1; j < n - 1; j++)
            {
                if (arr[i, j] != 1) arr[i, j] = arr[i - 1, j] + arr[i - 1, j - 1];
            }
        }
        return arr;

    }
    public static void PrintPsascalTriangIso(int[,] arr)
    {
        Console.Clear();
        int n = arr.GetLength(0);
        int x = Console.BufferWidth / 2;
        int d = arr[n - 1, n / 2].ToString().Length;
        int p, j;
        for (int i = 0; i < n; i++)
        {
            for (j = p = 0; j < n; j++, p += d + 1)
            {
                if (arr[i, j] != 0)
                {
                    Console.SetCursorPosition(x + p, i);
                    System.Console.WriteLine(arr[i, j]);
                }
            }
            x -= d - 1;
        }
    }
    public static void PrintPsascalTriangIso2(int[,] arr) // Вариант 2ой из лекции
    {
        Console.Clear();
        int cellWidth = 1;
        int row = arr.GetLength(0);
        int col = cellWidth * row;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.SetCursorPosition(col, i + 1);
                // if (arr[i, j] != 0) Console.Write($"{arr[i, j]}");
                if (arr[i, j] % 2 != 0) Console.Write("*"); // Вывод триугольника серпинского
                col += cellWidth * 2;
            }
            col = cellWidth * row - cellWidth * (i + 1);
            Console.WriteLine();
        }
    }

    // **Задача 57:** Написать программу, которая упорядочивает по убыванию элементы каждой строки двумерного массива.
    public static int[,] SortLineArr2d(int[,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            int k = arr.GetLength(1) - 1;
            int temp;
            while (k > 0)
            {
                for (int j = 0; j < k; j++)
                {
                    if (arr[i, j] < arr[i, j + 1])
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, j + 1];
                        arr[i, j + 1] = temp;
                    }
                }
                k--;
            }
            /* int temp;
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                for (int k = j + 1; k < arr.GetLength(1); k++)
                {
                    if (arr[i, j] < arr[i, k]) 
                    {
                        temp = arr[i, j];
                        arr[i, j] = arr[i, k];
                        arr[i, k] = temp;
                    }
                } 
            }  */
        }
        return arr;
    }

    // **Задача 59:** В прямоугольной матрице найти строку с наименьшей суммой элементов.
    public static int FindSumInString(int[,] arr, int strInd)
    {
        int sum = 0;
        for (int i = 0; i < arr.GetLength(1); i++)
        {
            sum += arr[strInd, i];
        }
        return sum;
    }
    public static string FindMinStringArr2d(int[,] arr)
    {
        int min = FindSumInString(arr, 0);
        string res = $"Min string is: 0";
        int sum;
        for (int i = 1; i < arr.GetLength(0); i++)
        {
            sum = FindSumInString(arr, i);
            if (min > sum)
            {
                min = sum;
                res = $"Min string is: {i}";
            }
        }
        return res;
    }

    // Задача 61: Найти произведение двух матриц.
    public static int[,] MultiplicationTwoMatrix(int[,] arr1, int[,] arr2)
    {
        int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
        int[,] temp = new int[arr2.GetLength(1), arr2.GetLength(0)];
        for (int i = 0; i < arr2.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                temp[j, i] = arr2[i, j];
            }
        }
        for (int i = 0; i < res.GetLength(0); i++)
        {
            for (int j = 0; j < res.GetLength(1); j++)
            {
                for (int k = 0; k < temp.GetLength(1); k++)
                {
                    res[i, j] += arr1[i, k] * temp[j, k];
                }
            }
        }
        return res;

    }


    // **Задача 63:** Сформировать трёхмерный массив с не повторяющимися двузначными числами и вывести его на экран построчно, 
    // с индексами элементов.
    public static int[,,] GetArr3d(int n)
    {
        int[,,] arr = new int[n, n, n];
        int a = 10;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    arr[i, j, k] = a;
                    a++;
                }
            }
        }
        return arr;
    }
    public static void PrintArr3d(int[,,] arr)
    {
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            Console.WriteLine("--------------------------");
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write($"({i},{j})");
                for (int k = 0; k < arr.GetLength(2); k++)
                {
                    Console.Write($"{arr[i, j, k],5}");
                }
                Console.WriteLine();
            }
        }
        Console.WriteLine("--------------------------");
    }


    // **Задача 65:** Спирально заполнить двумерный массив:
    public static int[,] FillArrSpiral(int n, int m)
    {
        int[,] arr = new int[n, m];
        int num = 1;
        FillArr(0, 0);

        void FillArr(int row, int col)
        {
            if (row < n
             && row >= 0
             && col < m
             && col >= 0
             && arr[row, col] == 0)
            {
                arr[row, col] = num++;
                if (row == 0 || arr[row - 1, col] != 0) FillArr(row, col + 1);
                FillArr(row + 1, col);
                FillArr(row, col - 1);
                FillArr(row - 1, col);
            }
        }
        return arr;
    }

    // Показать натуральные числа от 1 до N, N задано (рекурсивно)
    public static void PrintNaturNum(int n)
    {
        /*int x = 1;
        PrintNum(x);

        void PrintNum(int x)
        {
            if (x > n) return;
            System.Console.Write($"{x}, ");
            PrintNum(x + 1);
        }
        System.Console.WriteLine();*/
        if (n == 1) System.Console.Write(n + ", ");
        else
        {
            PrintNaturNum(n - 1);
            System.Console.Write(n + ", ");
        }
    }
    public static string PrintNaturNumStr(int n)
    {
        return (n == 1) ? n + " " : PrintNaturNumStr(n - 1) + n + " ";
    }



    // Найти сумму цифр числа (рекурсивно)
    public static int SumNumOfNumber(int n)
    {
        if (n < 10) return n;
        return n % 10 + SumNumOfNumber(n / 10);
    }

    // возведение числа в степень (рекурсивно)
    public static int PowNum(int a, int n)
    {
        return (n == 0) ? 1 : a * PowNum(a, n - 1);
    }

    // Сколько раз пробежит собака между двумя людьми идущими навстречу
    public static int RunTimeDogMenToMen(int speedFs, int speedSd, int vDog, int dist)
    {
        int time;
        int count = 0;
        while (true)
        {
            time = dist / (speedSd + vDog);
            dist = dist - (speedSd + speedFs) * time;
            count++;
            if (dist <= 10) return count;

            time = dist / (speedFs + vDog);
            dist = dist - (speedSd + speedFs) * time;
            count++;
            if (dist <= 10) return count;
        }
    }


    // **Задача 64:** Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
    public static string PrintNaturNum(int m, int n)
    {
        return (m == n) ? m + ";" : m + ", " + PrintNaturNum(m + 1, n);
    }

    // **Задача 66:** Задайте значения M и N. Напишите программу, 
    // которая найдёт сумму натуральных элементов в промежутке от M до N.
    public static int FindSunNaturNums(int m, int n)
    {
        return (m == n) ? m : m + FindSunNaturNums(m + 1, n);
    }


    // **Задача 68:** Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
    public static int Akkerman(int m, int n)
    {
        if (m == 0) return n + 1;
        if (m > 0 && n == 0) return Akkerman(m - 1, 1);
        if (m > 0 && n > 0) return Akkerman(m - 1, Akkerman(m, n - 1));
        return 1;
    }

    // Задача 70: Напишите программу, которая на вход принимает два числа и выдаёт первые N чисел, 
    // для которых каждое следующее равно сумме двух предыдущих.
    public static int[] Furye(int m, int n, int k)
    {
        int[] res = new int[k + 2];
        res[0] = m;
        res[1] = n;
        for (int i = 2; i < res.Length; i++)
        {
            res[i] = res[i - 1] + res[i - 2];
        }
        return res;
    }
    public static string Furie2(int m, int n, int k)
    {
        return (k == 1) ? m + n + ";" : m + n + ", " + Furie2(n, m + n, k - 1);
    }

    // Задача 71: В некотором машинном алфавите имеются четыре буквы «а», «и», «с» и «в». 
    // Покажите все слова, состоящие из n букв, которые можно построить из букв этого алфавита.
    public static void ShowWordsFromAlphabet(string alphabet, char[] word, int n = 0)
    {
        if (n == word.Length)
        {
            System.Console.WriteLine(new String(word));
            return;
        }
        for (int i = 0; i < alphabet.Length; i++)
        {
            word[n] = alphabet[i];
            ShowWordsFromAlphabet(alphabet, word, n + 1);
        }
    }
    // решение с помощью рекурсии
    public static void ShowWordsFromAlphabet2(string alphabet, int length, string prefix)
    {
        if (length == 0) System.Console.WriteLine(prefix);
        else foreach (char c in alphabet) ShowWordsFromAlphabet2(alphabet, length - 1, prefix + c);
    }
    // решение с помощью четверичной системы счисления
    string ShowWords(string[] chars, string quaternaryNum, int charsNum)
    {
        if (charsNum == 1) return chars[Convert.ToInt32(quaternaryNum[^1].ToString())];
        else return chars[Convert.ToInt32(quaternaryNum[^charsNum].ToString())]
        + ShowWords(chars, quaternaryNum, --charsNum);

        string ConvertToQuaternary(int inputDecimal)
        {
            if (inputDecimal < 4) return inputDecimal.ToString();
            else return (ConvertToQuaternary(inputDecimal / 4)).ToString()
            + (inputDecimal % 4).ToString();
        }
    }

    // В указанном диапазоне, вывести все взаимнопростые числа заданному числу
    public static List<int> PrintRelativPrimeNums(int a, int b, int n)
    {
        List<int> ls = new List<int>(); 
        for (int i = a; i <= b; i++)
        {
            ls.Add(i);
        }
        for (int i = a; i <= b; i++)
        {
            for (int j = 2; j <= n; j++)
            {
                if (i % j == 0 && n % j == 0) 
                ls.Remove(i);
            }
        }
        return ls;
    }

    public static void PrintRelativPrimeNums2(int s, int e, int x)
    {
        for (int i = s; i < e + 1; i++)
        {
            if (IsCoprime(x, i))
            {
                System.Console.Write("{0} ", i);
            }
        }
        bool IsCoprime(int num1, int num2)
        {
            if(num1 == num2)
            {
                return num1 == 1;
            }
            else
            {
                if (num1 > num2)
                {
                    return IsCoprime(num1 - num2, num2);
                }
                else
                {
                    return IsCoprime(num2 - num1, num1);
                }
            }
        }
    }


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

    public static string ConvertBinToIntArr(int[] data, int[] info)
    {
        string res = string.Empty;
        int k = 0;
        for (int i = 0; i < info.Length; i++)
        {
            string temp = string.Empty;
            for (int j = 0; j < info[i]; j++)
            {
                temp += data[k];
                k++;
            }
            res += Convert.ToInt32(temp, 2) + ", ";
        }
        return res;
    }

}
