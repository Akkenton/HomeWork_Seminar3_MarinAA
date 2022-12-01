//     Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.  
//     14212 -> нет  
//     12821 -> да  
//     23432 -> да

int addValue(string message)
{
link1:
    Console.Clear();
    Console.WriteLine(message);
    int value = int.Parse(Console.ReadLine());
    if (value < 10000 || value > 99999)    // прроверка введенного числа на пятизначность
    {
        Console.WriteLine("Вы ввели не пятизначное число! Попробуйте заново. Для этого нажмите на ENTER");
        Console.ReadLine();
        goto link1;
    }
    else return value;
}

void intPalindromMethod(int value)
{
    int numberOrigin = value;  // сохраним оригинальное число в отдельную перменную
    int revNumber = 0; // инициализимурем переменную, куда запишем число в обратном порядке

    int count = 1; // инициализация счетчика цикла
    while (count <= 5)    // запись обратного числа начинается с остатка от деления введеного числа на 10. Само число целочисленно делится на 10 для убирания разряда. И так далее по циклу. 
    {
        revNumber = (value % 10) + revNumber * 10;
        value = value / 10;
        count++;
    }
    Console.WriteLine($"Обратное число получилось таким: {revNumber}. Для проверки его на палиндром с введеным ранее - нажмите ENTER!");
    Console.ReadLine();
    if (revNumber == numberOrigin) Console.WriteLine("Да");
    else Console.WriteLine("Нет");
}

int number = addValue("Введите пятизначное число: ");
intPalindromMethod(number);