Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("1)��� �������������� �����")



        For i As Integer = 0 To 30

            Console.Write("H")

        Next

        Console.SetCursorPosition(0, 4)
        Console.WriteLine("2) ��� ������ � ���� ���������� ����� � ������ �����")


        Console.SetCursorPosition(10, 7)
        For i As Integer = 0 To 30

            Console.Write("H")

        Next

        Console.SetCursorPosition(0, 10)
        Console.WriteLine("3) � ���� �������� ������� Left � Top")

        For i = 0 To 4
            Console.Write("G")
            Console.SetCursorPosition(10, Console.GetCursorPosition().Top + 2)
        Next

        Console.SetCursorPosition(1, 21)
        Console.WriteLine("4) � ��������� ������������� ������� 10 � ������� 5 � ����� �����")

        Console.SetCursorPosition(1, 25)
        For j = 1 To 5

            For i = 1 To 10
                Console.Write("O")
            Next
            Console.SetCursorPosition(10, Console.GetCursorPosition().Top + 1)
        Next

    End Sub
End Module
