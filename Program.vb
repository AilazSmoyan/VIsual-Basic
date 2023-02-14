Imports System

Module Program
    Private brush As Char = "0"c
    Sub Main(args As String())


        HLine(10, 10, 7)
        VLine(10, 10, 8)
        HLine(10, 17, 7)
        VLine(17, 10, 8)
        Console.SetCursorPosition(1, 18)
        Console.WriteLine("1)This is KVADRAT PUSTOI")


        Console.ForegroundColor = ConsoleColor.Blue
        FilReact(2, 20, 40, 30)
        Console.SetCursorPosition(1, 52)
        Console.ForegroundColor = ConsoleColor.White
        Console.WriteLine("2)This is KVADRAT POLNAYA")

        HLine(2, 60, 20)
        Console.SetCursorPosition(1, 61)
        Console.WriteLine("3)This is LINIYA GORIZONTALNAYA")

        VLine(10, 65, 10)
        Console.SetCursorPosition(1, 78)
        Console.WriteLine("4)This is LINIYA VERTICALNAYA")

    End Sub

    Sub HLine(leftX As Byte, TopY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, TopY)
        For i = 0 To length - 1
            Console.Write("0")
        Next
    End Sub

    Sub VLine(leftX As Byte, TopY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, TopY)
        For i = 0 To length
            Console.Write("0")
            Console.SetCursorPosition(leftX, TopY + i)
        Next
    End Sub


    Sub FilReact(leftX As Byte, TopY As Byte, length As Byte, width As Byte)
        Console.SetCursorPosition(leftX, TopY + 1)

        For j = 0 To width
            HLine(leftX, TopY + j, width)
            Console.SetCursorPosition(leftX, TopY + j)
        Next

    End Sub
End Module
