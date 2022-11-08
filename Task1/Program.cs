// Задача 25: Напишите метод, который принимает на вход два числа (A и B)
// и возводит число A в целую степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// без использования math.pow

int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);

void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
} 

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}