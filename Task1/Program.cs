/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/

int GetNumber(string msg)                                                   // Метод проверки ввода пользователем числа
{
    while (true)
    {
        Console.WriteLine(msg);
        string valueFromConsole = Console.ReadLine();

        if (int.TryParse(valueFromConsole, out int number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Вы ввели не число. Нужно ввести число.");
        }
    }
}

void GetPositiveCount(string msg)                                            // Метод перевода строки в массив и поиск чисел > 0
{
    int[] array = msg.Split(' ').Select(int.Parse).ToArray();
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
    }
    Console.WriteLine(count);
}

int n = GetNumber("Введите количество чисел, которое хотите ввести:");
Console.WriteLine("Введите числа в строчку через пробел: ");
string msg = Console.ReadLine();
GetPositiveCount(msg);