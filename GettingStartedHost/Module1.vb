Imports System.ServiceModel
Imports System.ServiceModel.Description
Imports GettingStartedLib.GettingStartedLib

Module Service
    Class Program
        Shared Sub Main()
        'Step 1: Create a URI to serve as the base address.
        Dim baseAddress As New Uri("http://localhost:8000/GettingStarted/")

        'Step 2: Create a ServiceHost instance.
        Dim selfHost As New ServiceHost(GetType(CalculatorService), baseAddress)
            Try
                'Step 3: Add a service endpoint.
                selfHost.AddServiceEndpoint(GetType(ICalculator), New WSHttpBinding(), "CalculatorService")

                'Step 4: Enable metadata exchange.
                Dim smb As New ServiceMetadataBehavior()
                smb.HttpGetEnabled = True
                selfHost.Description.Behaviors.Add(smb)

                'Step 5: Start the Service.
                selfHost.Open()
                Console.WriteLine("The service is ready-")

                'Close the ServiceHost to stop the service.
                Console.WriteLine("Press <Enter> to terminate the service.")
                Console.WriteLine()
                Console.ReadLine()
                selfHost.Close()

            Catch ce As CommunicationException
                Console.WriteLine("An exception occurred: {0}", ce.Message)
                selfHost.Abort()
            End Try
        End Sub
    End Class
End Module
