Module Module1

    Sub Main()
        Dim str1 As String
        Dim Count As Integer
        Dim X As String


        COUNT = 0
        str1 = ""
        x = ""

        Console.Write(" Enter a string:")
        str1 = Console.ReadLine
        If Len(str1) > 2 Then
            If Right(str1, 3) = "ing" Then
                X = X + "ly"
            Else
                X = X + "ING"
                Console.Write(X & str1)
                Console.ReadKey()
            End If
        Else
            Console.Write(str1)
            Console.ReadKey()
        End If

    End Sub

End Module
