// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы

using System.Globalization;
IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };// для ввода данных через точку или запятую
Console.OutputEncoding = System.Text.Encoding.UTF8; // для отображения кирилицы в консоли

/*

                    { y = k1 * x + b1     ===>                  "вычитаем из одного другое"
                    { y = k2 * x + b2

                    | 0 = (k1 * x - k2 * x) + (b1 - b2)   ===>  "упрощаем" 
                    | b2 - b1 = x * (k1 -k2)

                    | x = (b2 - b1)/(k1 - k2)     ===>          "воспользуемся этой формулой для просчета икса"

                                                                "подставим  значение  х в уравнение , и вычислим  y"
                                                                
                    | если   значения  k1 и k2   одинаковы,  то это параллельные прямые и они не пересекутся                                      
*/


void IntersectionStriteLine (double k1,double k2,double b1,double b2) // вычисления точки пересечения
{
    double x1 = (b2 - b1)/(k1 - k2); 
    double y1 = k1 * x1 + b1;
    Console.WriteLine($"Прямые,описанные уравнениями y = {k1} * x + {b1}, y = {k2} * x + {b2}"); 
    Console.WriteLine($"пересекаются в точке ({x1} , {y1})");

}

void InputDataAndCheckingForNonParallel() //  ввод данных и проверка на непараллельность прямых
{
    Console.WriteLine("Введите значение k1 ");
    double k1 = double.Parse(Console.ReadLine(),formatter);
    Console.WriteLine("Введите значение k2 ");
    double k2 = double.Parse(Console.ReadLine(),formatter);
    Console.WriteLine("Введите значение b1 ");
    double b1 = double.Parse(Console.ReadLine(),formatter);
    Console.WriteLine("Введите значение b2 ");
    double b2 = double.Parse(Console.ReadLine(),formatter);
    if (k1 == k2)
    { 
        Console.WriteLine($"Прямые,описанные уравнениями y = {k1} * x + {b1}, y = {k2} * x + {b2}");
        Console.WriteLine("не пересекутся т.к. они параллельны ");
    }
    else IntersectionStriteLine (k1, k2, b1 ,b2);
}
Console.WriteLine(@"Найдём точку пересечения двух прямых ,
заданных уравнениями:
y = k1 * x + b1
y = k2 * x + b2
Зададим коэффициенты :");
InputDataAndCheckingForNonParallel(); 