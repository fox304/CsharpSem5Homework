/* 
Написать программу масштабирования фигуры 
Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой) 
например: "(0,0) (2,0) (2,2) (0,2)" коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5 
В результате показать координаты, которые получатся. при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
*/

using System.Globalization;
IFormatProvider f = new NumberFormatInfo{NumberDecimalSeparator = "."}; //для замены запятой на точку при вводе вещественного числа 

Console.OutputEncoding=System.Text.Encoding.UTF8;                       //для отображения кирилицы

string [] InputData()
{
    Console.WriteLine(@"Введите как минимум три пары координат вершин фиуры 2D , пользуясь крулыми скобками
Например: (2,3)(-4,6)(7.4,3)
Для ввода десятичного числа используйте точку '.' ");
    string str = Console.ReadLine() ?? "";
    char[] delimiterChars = { ' ', ',', '\t' , '(', ')','/'};
    string [] str2 = str.Split(delimiterChars,StringSplitOptions.RemoveEmptyEntries); // удаление символов (строка 19) из массива str2
    return str2;
}
void Calculation(string [] s1)
{
    Console.WriteLine("Введите коэффициент масштабирования ");
    double ratio = double.Parse(Console.ReadLine() ?? "",f);
    double ratio2,ratio3=0;
    Console.WriteLine("Расчёты показали,что" );
    Console.WriteLine($"после применения коэффициента k = {Convert.ToString(ratio).Replace(",",".")}  ");//замена запятой на точку
    Console.WriteLine("координаты фигуры стали такими:");
    for (int i = 0; i < s1.Length; i+=2)
    {
        ratio2 = double.Parse(s1[i],f)*ratio;
        ratio3 = double.Parse(s1[i+1],f)*ratio;
        Console.Write($"({Convert.ToString(ratio2).Replace(",",".")},{Convert.ToString(ratio3).Replace(",",".")}) ");//замена запятой на точку
    }
}
void Condition(string [] s)
{   
   
    while (s.Length%2!=0 || s.Length < 4) //проверка на чётность(должны быть пары) и более 4 (иначе это будут окружность или отрезок)
    {
        Console.WriteLine("Неправильный ввод ! ");
        s = InputData();  
    }
    
    if (s.Length == 6) Console.WriteLine("Ваша фигура треугольник  ");
    else if (s.Length == 8) Console.WriteLine("Ваша фигура четырехугольник  ");
    else if (s.Length > 9 ) Console.WriteLine("Ваша фигура многоугольник  ");
    Calculation(s);
}

string [] massivedigit = InputData();

Condition(massivedigit);