Imports System.ServiceModel

Namespace GettingStartedLib
    <ServiceContract(Namespace:="http://Microsoft.ServiceModel.Samples")>
    Public Interface ICalculator

        <OperationContract()>
        Function Add(ByVal n1 As Double, ByVal n2 As Double) As Double

        <OperationContract()>
        Function Subtract(ByVal n1 As Double, ByVal n2 As Double) As Double

        <OperationContract()>
        Function Multiply(ByVal n1 As Double, ByVal n2 As Double) As Double

        <OperationContract()>
        Function Divide(ByVal n1 As Double, ByVal n2 As Double) As Double

    End Interface
End Namespace
