Module Module1

    Sub Main()

        Do
            Console.WriteLine("I can do simple Math")
            Console.Write("Choose the First Number ")
            Dim num1 As Integer
            num1 = Console.ReadLine()
            Console.Write("Choose the Second Number ")
            Dim num2 As Integer
            num2 = Console.ReadLine()
            Console.WriteLine("Choose Computation Type")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Subtract")
            Console.WriteLine("3. Multiply")
            Console.WriteLine("4. Divide")
            Dim type As String
            type = Console.ReadLine()

            Dim response As String = ""
            If type = "1" Then
                response = num1 + num2
            ElseIf type = "2" Then
                response = num1 - num2
            ElseIf type = "3" Then
                response = num1 * num2
            ElseIf type = "4" Then
                response = num1 / num2
            End If
            Console.WriteLine("The Answer is " & response)
        Loop

    End Sub
End Module
