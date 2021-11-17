



Module

    Sub Main()

        Dim Str1 As String
        Dim S2F As Char
        Dim myChar As Char

        Console.WriteLine("Enter a statement")
        str1 = Console.ReadLine
        S2F = Left(str1, 1)
        Console.Write(S2F)
        For COUNT = 1 To Len(S2) - 1
            myChar = Mid(str1, (COUNT + 1), 1)
            If myChar = S2F Then
                myChar = "*"
            End If
            Console.Write(myChar)
        Next
        Console.ReadKey()
    End Sub
End Module