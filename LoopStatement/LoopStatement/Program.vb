Imports System

Module Program
    Sub Main(args As String())
        Dim i As Integer
        i = 0
        Do
            Console.WriteLine(i)
            If i >= 2 Then Exit Do
            i = i + 1
        Loop
    End Sub
End Module
