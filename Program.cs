
using System;

class Program
{
    static void Main()
    {
        Student student = new Student();

        student.FIO = "Иванов";
        student.Ocenka1 = 3;
        student.Ocenka2 = 5;

        student.Show();

        Console.WriteLine("Средняя оценка: " + student.SredOcenka());
    }
}

class Student
{
    public string FIO;
    public float Ocenka1;
    public float Ocenka2;

    public void Show()
    {
        Console.WriteLine("ФИО: " + FIO);
        Console.WriteLine("Оценка 1: " + Ocenka1);
        Console.WriteLine("Оценка 2: " + Ocenka2);
    }

    public float SredOcenka()
    {
        return (Ocenka1 + Ocenka2) / 2;
    }
}
