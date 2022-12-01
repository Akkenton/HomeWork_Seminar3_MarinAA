//     Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.  
//     A (3,6,8); B (2,1,-7), -> 15.84  
//     A (7,-5, 0); B (1,-1,9) -> 11.53  

int getCoordinateAB(string message)
{
    Console.Clear();
    Console.WriteLine(message);
    int coordinate = int.Parse(Console.ReadLine());
    return coordinate;
}

void findLength3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    int coordX;
    int coordY;
    int coordZ;
    if (x2 > x1) coordX = x2 - x1;  // здесь и далее в IF идет корректировка большей координаты для расчета длины проекции.
    else coordX = x1 - x2;
    if (y2 > y1) coordY = y2 - y1;
    else coordY = y1 - y2;
    if (z2 > z1) coordZ = z2 - z1;
    else coordZ = z1 - z2;
    double length = Math.Sqrt(Math.Pow(coordX, 2) + Math.Pow(coordY, 2) + Math.Pow(coordZ, 2));  // высчитываем длинну отрезка
    length = Math.Round(length, 2);  // округляем до 2 чисел после запятой (так как тип sqrt принимает double)
    Console.WriteLine($"Длинна отрезка: {length}");
}

int x1 = getCoordinateAB("Введите координату первой точки - X: ");
int y1 = getCoordinateAB("Введите координату первой точки - Y: ");
int z1 = getCoordinateAB("Введите координату первой точки - Z: ");
Console.WriteLine($"Координаты первой точки получились: ({x1},{y1},{z1}). Press ENTER for continue...");
Console.ReadLine();
int x2 = getCoordinateAB("Введите координату второй точки - X: ");
int y2 = getCoordinateAB("Введите координату второй точки - Y: ");
int z2 = getCoordinateAB("Введите координату второй точки - Z: ");
Console.WriteLine($"Координаты первой точки получились: ({x1},{y1},{z1})");
Console.WriteLine($"Координаты второй точки получились: ({x2},{y2},{z2}). Нажмите ENTER для расчета длины соединяющего их отрезка...");
Console.ReadLine();

findLength3D(x1, y1, z1, x2, y2, z2);