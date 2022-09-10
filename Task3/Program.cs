// Написать программу копирования массива

int[] array = new int[8];
int arrayCopy;

Console.Write("Оригинал ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.Write(array[i] + " ");
}
Console.WriteLine();
Console.Write("   Копия ");
for (int i = 0; i < array.Length; i++)
{
    arrayCopy = array[i];
    Console.Write(arrayCopy + " ");
}
