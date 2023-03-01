Imports System

Module Program
    Private brush As Char = "0"c
    Sub Main(args As String())

        Console.WriteLine("¬€¡Œ–:
                           1-empty rectangle
                           2-full rectangle
                           3-Vertical line color Yellow
                           4-Horizonal line
                           5-Abzac line
                           6-Cells")
        Dim N As Integer
        N = CInt(Console.ReadLine())
        Select Case N
            Case 1
                React(8, 8, 40)
            Case 2
                FilReact(10, 15, 19, 22)
            Case 3
                Console.ForegroundColor = ConsoleColor.Yellow
                VLine(10, 20, 30)
                Console.ForegroundColor = ConsoleColor.White
            Case 4
                HLine(8, 8, 40)
            Case 5
                For i As Byte = 0 To 6
                    HLine(8, 8 + i*6, 90)
                Next
            Case 6
                For i As Byte = 0 To 8
                    VLine(8 + i * 10, 8, 37)
                Next

                For i As Byte = 0 To 6
                    HLine(8, 8 + i * 6, 80)
                Next

                Console.WriteLine()
        End Select
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

    Sub React(leftX As Byte, TopY As Byte, length As Byte)
        HLine(leftX, TopY, length)
        VLine(leftX, TopY, length)
        HLine(leftX, TopY + length, length)
        VLine(leftX + length, TopY, length + 1)
    End Sub
End Module
