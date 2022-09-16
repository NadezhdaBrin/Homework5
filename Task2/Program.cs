// Написать программу масштабирования фигуры
// 

/*string Scaling(double x1, double y1, double x2, double y2, 
double x3, double y3, double x4, double y4, double k)
{
    x1 = x1 * k;
    y1 = y1 * k;
    x2 = x2 * k;
    y2 = y2 * k;
    x3 = x3 * k;
    y3 = y3 * k;
    x4 = x4 * k;
    y4 = y4 * k;
    return $"({x1}, {y1}) ({x2}, {y2}) ({x3}, {y3}) ({x4}, {y4})";
}
Console.WriteLine(Scaling(0, 0, 2, 0, 2, 2, 0, 2, 2));*/

Console.WriteLine("Введите x1");
int x1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y1");
int y1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите x2");
int x2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y2");
int y2 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите x3");
int x3 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y3");
int y3 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите x4");
int x4 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите y4");
int y4 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Вершины фигуры:");
Console.WriteLine($"{(x1,y1)} {(x2,y2)} {(x3,y3)} {(x4,y4)}");
int k=2;
Console.WriteLine($"{(k*x1,k*y1)} {(k*x2,k*y2)} {(k*x3,k*y3)} {(k*x4,k*y4)}");