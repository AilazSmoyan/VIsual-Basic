Imports System

Module Program
    Sub Main(args As String())
        Dim t As String

        Console.WriteLine("Введите время в секундах")
        t = Console.ReadLine
        Dim sec As String
        Dim min As Integer
        Dim hrs As String


        hrs = t \ 3600
        min = (t - hrs * 3600) \ 60
        sec = t - hrs * 3600 - min * 60

        Dim u
        u = TimeSerial(hrs, min, sec)
        Console.WriteLine("Результат: {0}", u)
    End Sub
End Module
