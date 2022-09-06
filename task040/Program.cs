// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. Определить , является ли это сторонами треугольника.
// Если да, то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах, 
// является ли он прямоугольным, равнобедренным, равносторонним.
Console.Write("Введите длину первой строны треугольника: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину второй строны треугольника: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите длину третей строны треугольника: ");
double c = Convert.ToInt32(Console.ReadLine());
double P = a + b + c;
double P1 = (a + b + c) / 2;
double cosA = Math.Round(Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math.PI, 3);
double cosB = Math.Round(Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math.PI, 3);
double cosY = Math.Round(Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math.PI, 3);
double S = Math.Round(Math.Sqrt(P1 * (P1 - a) * (P1 - b) * (P1 - c)), 2);
if (a < b + c && b < a + c && c < a + b && a == b && a == c && c == b)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует и он является равносторонним");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else if (a < b + c && b < a + c && c < a + b && a == b)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует и он является равнобедренным");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else if (a < b + c && b < a + c && c < a + b && a == c)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует и он является равнобедренным");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else if (a < b + c && b < a + c && c < a + b && b == c)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует и он является равнобедренным");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else if (a < b + c && b < a + c && c < a + b && cosA == 90)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует и он является прямоугольным");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else if (a < b + c && b < a + c && c < a + b && cosB == 90)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует и он является прямоугольным");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else if (a < b + c && b < a + c && c < a + b && cosY == 90)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует и он является прямоугольным");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else if (a < b + c && b < a + c && c < a + b)
{
    Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует");
    Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: cos(a)= {cosA}; cos(b)= {cosB}; cos(y)= {cosY}");
}
else Console.WriteLine($"Треугольник со сторонами {a} {b} {c} НЕ существует");
















// if (a == b & a == c & c == b)
// {
//     Console.WriteLine("Данный треугольник является равносторонним");
// }
// else if (a == b | a == c | b == c)
// {
//     Console.WriteLine("Данный треугольник является равнобедренным");
// }
// else if ((a * a) + (b * b) == (c * c) | (a * a) + (c * c) == (b * b) | (c * c) + (b * b) == (a * a))
// {
//     Console.WriteLine("Данный треугольник является прямоугольным");
// }
// Console.WriteLine($"Площадь: {S}; Периметр: {P}; Углы: {cosA} {cosB} {cosC}");





















//Console.WriteLine($"Треугольник со сторонами {a} {b} {c} существует");
//else Console.WriteLine($"Треугольник со сторонами {a} {b} {c} НЕ существует");
