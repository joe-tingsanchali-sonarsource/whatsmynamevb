Option Base On
Option Explicit On
Imports System

Module Program
'    Sub Main(args As String())
'        Console.WriteLine("Hello World!")
'    End Sub

'    Sub Main(args as String())
'        Console.WriteLine(vbCrLf + "What is your name? ")
'        Dim name = Console.ReadLine()
'        Dim currentDate = DateTime.Now
'        Console.WriteLine($"{vbCrLf}Hello, {name}, on {currentDate:d} at {currentDate:t}!")
'        Console.Write(vbCrLf + "Press any key to exit... ")
'        Console.ReadKey(True)
'    End Sub

    Private _num1 As Integer
    Private _num2 As Integer
    Private _answer As Integer
    Public Class Sample
        Private Const Condition As Boolean = 3

        Public Sub MySub()
            If Condition Then
                Exit Sub                  ' Noncompliant
            End If
        End Sub
        Function MyFunction() As Object
            ' ...
            MyFunction = 42
            Exit Function              ' Noncompliant
        End Function
    End Class
    Sub Main()
        Console.WriteLine("Type a number and press Enter")
        _num1 = Console.ReadLine()
        Console.WriteLine("Type another number to add to it and press Enter")
        _num2 = Console.ReadLine()
        _answer = _num1 + _num2
        Console.WriteLine("The answer is " & _answer)
'        Console.ReadLine()
        Console.Write(vbCrLf + "Press any key to exit... ")
        Console.ReadKey(True)

        ' This is non-compliant code for VB.NET, not VB!
        ' But this isn't working for https://rules.sonarsource.com/vbnet/type/Code%20Smell/RSPEC-2340
        Dim i = 1

        Do
            If i = 10 Then
                Exit Do
            End If
            Console.WriteLine(i)
            i = i + 1
        Loop
    End Sub
End Module

' This is non-compliant code for VB.NET, not VB!
' See https://rules.sonarsource.com/vbnet/type/Code%20Smell/RSPEC-2368
Module Module1
    Sub WriteMatrix(ByVal matrix As Integer()())
        ' ...
    End Sub
End Module
