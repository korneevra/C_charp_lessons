using static System.Console;
using System.Linq;

using System.IO;
using static System.Console;


// Работа с файлами
StreamReader sr = new StreamReader("input");
while (!sr.EndOfStream)
{
    WriteLine(sr.ReadLine());
}


// 2

string ss1 = Console.ReadLine();
string ss2 = Console.ReadLine();
int num1 = int.Parse(ss1);
int num2 = int.Parse(ss2);
if (num1 > num2)
{
    Console.WriteLine(num1 + " > " + num2);
}
else if (num1 < num2)
{
    Console.WriteLine(num2 + " > " + num1);
}
else
{
    Console.WriteLine(num2 + " = " + num1);
}

// 3

int num1 = int.Parse(ReadLine());
int num2 = int.Parse(ReadLine());
int num3 = int.Parse(ReadLine());
int max = num1;
if (max < num2) max = num2;
if (max < num3) max = num3;
WriteLine("Max = " + max);

//4

Write("Enter number: ");
int num = int.Parse(ReadLine());
if (num % 2 == 0)
{
    WriteLine("The number " + num + " is even.");
}
else
{
    WriteLine("The number " + num + " is odd.");
}

// 5

Write("Enter N: ");
int n = int.Parse(ReadLine());
int i = 2;
while (i <= n)
{
    Write(i + ", ");
    i += 2;
}

//9

int num = int.Parse(ReadLine());
WriteLine(num % 10);

// #10 Показать вторую цифру трёхзначного числа

string num = ReadLine();
WriteLine(show2num(num));

char show2num(string a)
{
    return a[1];
}

// #12 Удалить вторую цифру трёхзначного числа

string num = ReadLine();
WriteLine(del2num(num));

string del2num(string num)
{
    return Convert.ToString(num[0]) + Convert.ToString(num[2]);
}

// ex. 13

string checkNum(int num1, int num2)
{
    int a = num1 % num2;
    if (a == 0) return $"The number {num1} is devisible by {num2}";
    return $"Remainder of the division is {a}";
}

int num1 = int.Parse(ReadLine());
int num2 = int.Parse(ReadLine());
WriteLine(checkNum(num1, num2));

// #14 Найти третью цифру числа или сообщить, что её нет

int num = Math.Abs(int.Parse(ReadLine()));
if ((num - 100) < 0)
{
    WriteLine("The third number is missing!");
    return;
}
WriteLine(find3num(num));

char find3num(int num)
{
    string ss = num.ToString();
    return ss[2];
}

// ex. 15

string checkNum(int num1)
{
    if ((num1 % 7 == 0) & (num1 % 23 == 0)) return $"The number {num1} is devisible by 7 and 23";
    if (num1 % 7 == 0) return $"The number {num1} is devisible by 7";
    if (num1 % 23 == 0) return $"The number {num1} is devisible by 23";
    return $"The number {num1} is not devisible by 23 and 7";
}

int num1;
if (!int.TryParse(ReadLine(), out num1))
{
    WriteLine("Error entering number");
    return;
}
WriteLine(checkNum(num1));


// #16 Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Write("Enter number day of the week: ");
int day = int.Parse(ReadLine());
if (day > 7 | day < 1)
{
    WriteLine("Wrong number!");
    return;
}
WriteLine(dayCheck(day));


string dayCheck(int n)
{
    if (n == 6 | n == 7)
    {
        return "It is weekend!!!!!";
    }
    else
    {
        return "It is working day!";
    }
}

// #17 По двум заданным числам проверять является ли одно квадратом другого

int num1 = int.Parse(ReadLine());
int num2 = int.Parse(ReadLine());

WriteLine(SqrChk(num1, num2));

string SqrChk(int num1, int num2)
{
    if (num1 * num1 == num2) return $"Number {num2} is square of {num1}";
    if (num2 * num2 == num1) return $"Number {num1} is square of {num2}";
    return "No one of the number is't square of another";
}

// #18 Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool x = true, y = false;

WriteLine(boolChk(x, y));
WriteLine(boolChk(y, x));
WriteLine(boolChk(x, x));
WriteLine(boolChk(y, y));

string boolChk(bool x, bool y)
{
    if (!(x | y) == (!x & !y)) return "Statement true";
    else return "Statement false";
}


// #19 Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

int x = int.Parse(ReadLine());
int y = int.Parse(ReadLine());

WriteLine(QuadChk(x, y));

string QuadChk(int x, int y)
{
    if (x > 0 & y > 0) return "I quadrant";
    if (x < 0 & y > 0) return "II quadrant";
    if (x < 0 & y < 0) return "III quadrant";
    if (x > 0 & y < 0) return "IV quadrant";
    if (x == 0 & y == 0) return "0";
    return "point on axis";
}

// #20 Задать номер четверти, показать диапазоны для возможных координат

Write("Enter quadrant namber: ");
int q = int.Parse(ReadLine());

WriteLine(rangeChk(q));

string rangeChk(int q)
{
    switch (q)
    {
        case 1: return "Coordinate range is: x = 0...N, y = 0...N";
        case 2: return "Coordinate range is: x = 0...-N, y = 0...N";
        case 3: return "Coordinate range is: x = 0...-N, y = 0...-N";
        case 4: return "Coordinate range is: x = 0...N, y = 0...-N";
        default: return "Wrong number!";
    }
}

// #21 Программа проверяет пятизначное число на палиндромом

Write("Enter five-digit number :");
int num = int.Parse(ReadLine());

WriteLine(PlndrChk(num));

string PlndrChk(int num)
{
    string ss = num.ToString();
    return ss[0] == ss[4] & ss[1] == ss[3] ? $"The number {num} is Polindrom" : $"The number {num} is NOT Polindrom";
}

// #23 Показать таблицу квадратов чисел от 1 до N

Write("Enter N: ");
int n = int.Parse(ReadLine());
int[] arr = new int[n];
for (int i = 0; i < arr.Length; i++)
{

    arr[i] = (i + 1) * (i + 1);
}
WriteLine(String.Join(", ", arr));

// Ввести города и температуры через пробел и вывести самый теплый город самый холодный и среднюю темпреатуру

string strAns = "";
int coldTemp = 100;
int hotTemp = -100;
string coldCity = "";
string hotCity = "";
int sum = 0;
int count = 0;

do
{
    WriteLine("Введите Город и температуру через пробел");
    string s = ReadLine();
    string[] arr = s.Split(" ");
    string sity = arr[0];
    int t = int.Parse(arr[1]);
    sum += t;
    if (t < coldTemp)
    {
        coldTemp = t;
        coldCity = sity;
    }
    if (t > hotTemp)
    {
        hotTemp = t;
        hotCity = sity;
    }
    count++;

    WriteLine("Продолжить?");
    strAns = ReadLine();

} while (strAns != "нет");

WriteLine($"Теплый город {hotCity}");
WriteLine($"Холодный город {coldCity}");
WriteLine($"Средняя температура {sum / count}");

// Пример использования стуктур

MyStruct[] sityTemp = new MyStruct[100];
int i = 0;

do
{
    WriteLine("Enter name of sity and temp");
    string[] sity = ReadLine().Split();
    sityTemp[i] = new MyStruct() { Sity = sity[0], Temp = int.Parse(sity[1]) };
    i++;
    WriteLine("Continue?");

} while (!ReadLine().Equals("n"));

MyStruct min = sityTemp.First(x => x.Temp == sityTemp.Min(c => c.Temp)); // возьми первый элемент у которго температуря является мин.
MyStruct max = sityTemp.First(x => x.Temp == sityTemp.Max(c => c.Temp));
WriteLine($"The coldest sity is {min.Sity} - {min.Temp}");
WriteLine($"The hottest sity is {max.Sity} - {max.Temp}");


// Конвертация в системы счисления
DidSys[] didSyss = new DidSys[16]
{
    new DidSys(){num = 0, val = "0"},
    new DidSys(){num = 1, val = "1"},
    new DidSys(){num = 2, val = "2"},
    new DidSys(){num = 3, val = "3"},
    new DidSys(){num = 4, val = "4"},
    new DidSys(){num = 5, val = "5"},
    new DidSys(){num = 6, val = "6"},
    new DidSys(){num = 7, val = "7"},
    new DidSys(){num = 8, val = "8"},
    new DidSys(){num = 9, val = "9"},
    new DidSys(){num = 10, val = "A"},
    new DidSys(){num = 11, val = "B"},
    new DidSys(){num = 12, val = "C"},
    new DidSys(){num = 13, val = "D"},
    new DidSys(){num = 14, val = "E"},
    new DidSys(){num = 15, val = "F"},
};

WriteLine("Enter system base: ");
int n = int.Parse(ReadLine());
WriteLine("Enter number to convert: ");
int num = int.Parse(ReadLine());
string result = string.Empty;
while (num >= n)
{
    result = didSyss.First(x => x.num == num % n).val + result;
    num /= n;
}
result = didSyss.First(x => x.num == num).val + result;
WriteLine(result);

struct DidSys
{
    public int num;
    public string val;
}

struct MyStruct
{
    public string Sity;
    public int Temp;
}


