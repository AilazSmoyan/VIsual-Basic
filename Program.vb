Imports System

Module Program
    Private brush As Char = "0"c
    Sub Main(args As String())

        Dim leftX, TopY, length, width As Byte


        Console.Write("leftX=")
        leftX = Console.ReadLine()
        Console.Write("TopY=")
        TopY = Console.ReadLine()
        Console.Write("length=")
        length = Console.ReadLine()

        HLine(leftX, TopY, length)
        VLine(leftX, TopY, length)
        HLine(leftX, TopY + length, length)
        VLine(leftX + length, TopY, length + 1)

        Console.WriteLine()
    End Sub

    Sub HLine(leftX As Byte, TopY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, TopY)
        For i = 0 To length - 1
            Console.Write("0")
        Next
    End Sub

    Sub VLine(leftX As Byte, TopY As Byte, length As Byte)
        Console.SetCursorPosition(leftX, TopY + 1)
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
