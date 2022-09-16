// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы


/*string X(int k1, int k2, int b1, int b2)
{
    string result = string.Empty;
    int x = 0;
    int y = 0;
    x = (b2 - b1) / (k1 - k2);
    y = (k1 * (b2 - b1) / (k1 - k2)) + b1;
    result = $"({x}, {y})";
    return result;
}
Console.WriteLine(X(4, -1, 9, -8));*/


int b1 =  4;
int b2 =  4;
int k1 =  8;
int k2 =  3;

Solve(b1, b2, k1, k2);

void Solve (int b1, int b2, int k1, int k2) 
{
if (k1==k2) 
{
    if (k1==k2 && b1==b2) 
        System.Console.WriteLine($"Прямые совпадают");
    else 
        System.Console.WriteLine($"Прямые параллельны");
}
else
{ 
    int x=(b2-b1)/(k1-k2);  
    int y=k1*x+b1;
    System.Console.WriteLine($"Точка пересечения прямых:  x={x},  y={y}");
}
}
