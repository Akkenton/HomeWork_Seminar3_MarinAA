//     Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.  
//     3 -> 1, 8, 27  
//     5 -> 1, 8, 27, 64, 125

void cubeMethod(int number)
{
    double count = 1;
    while (count <= number)
    {
        if (count == 1) Console.Write(count);
        else
        {
            Console.Write($", {Math.Round(Math.Pow(count, 3), 0)}"); // Здесь мы выводим возведенный в степень 3 и округленный count
        }
        count++;
    }
}

Console.Clear();
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

cubeMethod(N);