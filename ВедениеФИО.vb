


Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Введите ФИО ребенка")
        Dim a As String = Console.ReadLine()

        Console.WriteLine("Введите рост ребенка")
        Dim b As Integer = Console.ReadLine()

        Console.WriteLine("Введите вес ребенка")
        Dim c As Double = Console.ReadLine()


        Dim u = b
        Console.WriteLine("Результат: ")
        Console.WriteLine("ФИО: {0}", a)
        Console.WriteLine($"Рост и вес ребенка: {b }см и {c }кг")

    End Sub
End Module
