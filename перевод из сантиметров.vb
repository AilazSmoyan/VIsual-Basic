Imports System

Module Program
    Sub Main(args As String())
        Dim sm As Integer
        Dim s As Integer
        Dim m As Integer
        Dim dm As Integer

        Console.WriteLine("������� ����� � �����������:")
        s = Console.ReadLine()

        m = s \ 100
        dm = (s Mod 100) \ 10
        sm = s Mod 10


        Console.WriteLine("���������: {0}� {1}�� {2}��", m, dm, sm)
    End Sub
End Module
