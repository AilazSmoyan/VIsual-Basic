Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("1)Вот горизонтальная линия")



        For i As Integer = 0 To 30

            Console.Write("H")

        Next

        Console.SetCursorPosition(0, 4)
        Console.WriteLine("2) Вот теперь я могу нарисовать линию с любого места")


        Console.SetCursorPosition(10, 7)
        For i As Integer = 0 To 30

            Console.Write("H")

        Next

        Console.SetCursorPosition(0, 10)
        Console.WriteLine("3) Я умею задовать функций Left И Top")

        For i = 0 To 4
            Console.Write("G")
            Console.SetCursorPosition(10, Console.GetCursorPosition().Top + 2)
        Next

        Console.SetCursorPosition(1, 21)
        Console.WriteLine("4) Я нарисовал прямоугольник шириной 10 и высотой 5 в любом месте")

        Console.SetCursorPosition(1, 25)
        For j = 1 To 5

            For i = 1 To 10
                Console.Write("O")
            Next
            Console.SetCursorPosition(10, Console.GetCursorPosition().Top + 1)
        Next

    End Sub
End Module
