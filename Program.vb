'Xavier Hoskins
'RCET 0265
'Fall 2022
'Better Calculator
'https://github.com/hoskxavi/BetterCalculator

Imports System

Module Program
    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userInput As String
        Dim result As Decimal
        Dim retry As Boolean = True

        Do
            Console.WriteLine("Please enter two numbers. Enter Q at any time to quit.")

            Do While retry = True
                Console.Write("Enter a number:")
                userInput = Console.ReadLine()
                Try
                    firstNumber = CInt(userInput)
                    Console.Write("You entered: ")
                    Console.WriteLine(firstNumber)
                    retry = False
                Catch ex As Exception
                    If userInput = "Q" Or userInput = "q" Then
                        Console.Write("You entered: ")
                        Console.WriteLine(userInput)
                        Console.WriteLine("Have a nice day.")
                        Exit Sub
                    End If
                    Console.Write("You entered: ")
                    Console.Write(userInput)
                    Console.WriteLine(", please enter a whole number.")
                End Try
            Loop

            Do While retry = False
                Console.Write("Enter a number:")
                userInput = Console.ReadLine()
                Try
                    secondNumber = CInt(userInput)
                    Console.Write("You entered: ")
                    Console.WriteLine(secondNumber)
                    retry = True
                Catch ex As Exception
                    If userInput = "Q" Or userInput = "q" Then
                        Console.Write("You entered: ")
                        Console.WriteLine(userInput)
                        Console.WriteLine("Have a nice day.")
                        Exit Sub
                    End If
                    Console.Write("You entered ")
                    Console.Write(userInput)
                    Console.WriteLine(", please enter a whole number.")

                End Try
            Loop

            Do While retry = True
                Console.WriteLine("Choose one of the following options:")
                Console.WriteLine("1. Add")
                Console.WriteLine("2. Subtract")
                Console.WriteLine("3. Multiply")
                Console.WriteLine("4. Divide")
                userInput = Console.ReadLine()

                Select Case userInput
                    Case "1"
                        Console.Write("You entered: ")
                        Console.WriteLine(userInput)
                        result = firstNumber + secondNumber
                        Console.Write(firstNumber)
                        Console.Write("+")
                        Console.Write(secondNumber)
                        Console.Write("=")
                        Console.WriteLine(result)
                        retry = False
                    Case "2"
                        Console.Write("You entered: ")
                        Console.WriteLine(userInput)
                        result = firstNumber - secondNumber
                        Console.Write(firstNumber)
                        Console.Write("-")
                        Console.Write(secondNumber)
                        Console.Write("=")
                        Console.WriteLine(result)
                        retry = False
                    Case "3"
                        Console.Write("You entered: ")
                        Console.WriteLine(userInput)
                        result = firstNumber * secondNumber
                        Console.Write(firstNumber)
                        Console.Write("*")
                        Console.Write(secondNumber)
                        Console.Write("=")
                        Console.WriteLine(result)
                        retry = False
                    Case "4"
                        Console.Write("You entered: ")
                        Console.WriteLine(userInput)
                        result = firstNumber / secondNumber
                        Console.Write(firstNumber)
                        Console.Write("/")
                        Console.Write(secondNumber)
                        Console.Write("=")
                        Console.WriteLine(result)
                        retry = False
                    Case Else
                        If userInput = "Q" Or userInput = "q" Then
                            Console.Write("You entered: ")
                            Console.WriteLine(userInput)
                            Console.WriteLine("Have a nice day.")
                            Exit Sub
                        End If
                        Console.Write("You entered: ")
                        Console.Write(userInput)
                End Select
            Loop
        Loop

    End Sub
End Module
