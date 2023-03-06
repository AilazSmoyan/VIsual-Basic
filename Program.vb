Imports System

Module Module1
    Sub Main(args As String())
        Dim numbers(6) As Integer

        For i = 0 To numbers.Length - 1

            numbers(i) = Console.ReadLine()
        Next

        For i = numbers.Length - 1 To 0 Step -1

            Console.WriteLine(numbers(i))
        Next

        printRevers(numbers)

        Dim Strings(4) As String
        For i = 0 To Strings.Length - 1

            Strings(i) = Console.ReadLine()
        Next
        printRevers(Strings)
        Console.ReadLine()
    End Sub

    Sub printRevers(list As Integer())
        For i = list.Length To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub

    Sub printRevers(list As String())
        For i = list.Length To 0 Step -1
            Console.WriteLine(list(i))
        Next
    End Sub
End Module
