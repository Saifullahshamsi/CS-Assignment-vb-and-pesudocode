Module Module1

    Sub Main()
        Dim Ndonuts As Integer

        Ndonuts = 0

        Console.Write("enter number of donuts:")
        Ndonuts = Console.ReadLine

        If Ndonuts > 10 Then
            Console.Write("Many donuts")
        Else
            Console.Write("the number of donuts are : " & Ndonuts)
            Console.ReadLine()

        End If
    End Sub

End Module
