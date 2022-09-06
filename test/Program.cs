
// тестовый режим
// вывод точки вместо запятой
using System.Globalization;
IFormatProvider formatter = new NumberFormatInfo { NumberDecimalSeparator = "." };
double number = double.Parse("23.56", formatter);