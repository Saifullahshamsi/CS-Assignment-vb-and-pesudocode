Module Module1

    Sub Main()
        Dim str1 As String
        Dim str2 As String
        Dim Cstr1 As Char
        Dim Cstr2 As Char
        Dim laststr1 As String
        Dim laststr2 As String

        str1 = ""
        str2 = ""
        Cstr1 = ""
        Cstr2 = ""
        laststr1 = ""
        laststr2 = ""

        Console.Write("Enter string 1 for the calculation")
        str1 = Console.ReadLine
        Console.Write("Enter string 2 for the calculation")
        str2 = Console.ReadLine

        Cstr1 = Left(str1, 2)
        Cstr2 = Left(str2, 2)
        laststr1 = Mid(str1, 3, Len(str1) - 2)
        laststr2 = Mid(str2, 3, Len(str2) - 2)

        Console.Write(Cstr2 & laststr1)
        Console.ReadLine()
        Console.Write(Cstr1 & laststr2)
        Console.ReadLine()
    End Sub

End Module
