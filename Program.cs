//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B
Console.Clear();

int DataEntry(string str)
{
    Console.Write(str);
    int number = int.Parse(Console.ReadLine());
    return number;
}

int DegreeNumber(int a, int b)
{
    int i = 1;
    int result = 1;
    for (i = 1; i <= b; i ++)
    {
        result = result * a;    
    }
    return result;
}

int a = DataEntry("Введите число a: ");
int b = DataEntry("Введите число b: ");
int result = DegreeNumber(a, b);
Console.WriteLine(result);





