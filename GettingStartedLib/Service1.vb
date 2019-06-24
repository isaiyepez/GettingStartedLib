Imports System.ServiceModel

Namespace GettingStartedLib
    Public Class CalculatorService
        Implements ICalculator

        Public Function Add(n1 As Double, n2 As Double) As Double Implements ICalculator.Add
            Dim result As Double = n1 + n2
            'Code added to write output to the console window
            Console.WriteLine("Received add({0},{1})", n1, n2)
            Console.WriteLine("Return: {0}", result)
            Return result
        End Function

        Public Function Subtract(n1 As Double, n2 As Double) As Double Implements ICalculator.Subtract
            Dim result As Double = n1 - n2
            Console.WriteLine("Received Subtract({0}, {1}", n1, n2)
            Console.WriteLine("Return: {0}", result)
            Return result
        End Function

        Public Function Multiply(n1 As Double, n2 As Double) As Double Implements ICalculator.Multiply
            Dim result As Double = n1 * n2
            Console.WriteLine("Received Multiply({0}, {1})", n1, n2)
            Console.WriteLine("Return: {0}", result)
            Return result
        End Function

        Public Function Divide(n1 As Double, n2 As Double) As Double Implements ICalculator.Divide
            Dim result As Double = n1 / n2
            Console.WriteLine("Received Divide({0}, {1})", n1, n2)
            Console.WriteLine("Return: {0}", result)
            Return result
        End Function
    End Class
End Namespace
