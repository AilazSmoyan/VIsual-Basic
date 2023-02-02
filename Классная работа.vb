Imports System

Module Program


    Sub Main(args As String())

        Console.WriteLine("Для умножения введите число N: ")
        Dim N As Long
        Dim proiz2 As Long
        proiz2 = 1
        N = 0
        While N <> 1
            N = CInt(Console.ReadLine)
            proiz2 = proiz2 * N

        End While
        Console.WriteLine(proiz2)

    End Sub
End Module
