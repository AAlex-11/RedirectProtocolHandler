Imports System.Reflection
Imports System.Threading
Imports Microsoft.VisualBasic.ApplicationServices
Imports Microsoft.VisualBasic.Devices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public Shared Sub ThreadExceptionEventHandler(ByVal sender As Object, ByVal e As ThreadExceptionEventArgs)
            Dim Data() As Byte = System.Text.UTF8Encoding.UTF8.GetBytes("ThreadException Error" & e.Exception.Message)
            My.Computer.FileSystem.WriteAllBytes(IO.Path.Combine(IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), Now.ToBinary.ToString & ".txt"), Data, True)
        End Sub

        Protected Overrides Function OnStartup(e As StartupEventArgs) As Boolean
            AddHandler System.Windows.Forms.Application.ThreadException, AddressOf ThreadExceptionEventHandler
            Return MyBase.OnStartup(e)
        End Function
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            My.Application.DoEvents()
        End Sub
        Private Sub MyApplication_UnhandledException(sender As Object, e As UnhandledExceptionEventArgs) Handles Me.UnhandledException
            Dim Data() As Byte = System.Text.UTF8Encoding.UTF8.GetBytes("UnhandledException Error" & e.Exception.Message)
            My.Computer.FileSystem.WriteAllBytes(IO.Path.Combine(IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), Now.ToBinary.ToString & ".txt"), Data, True)
        End Sub

        Private Sub MyApplication_NetworkAvailabilityChanged(sender As Object, e As NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            Dim Data() As Byte = System.Text.UTF8Encoding.UTF8.GetBytes("NetworkAvailability Error")
            My.Computer.FileSystem.WriteAllBytes(IO.Path.Combine(IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), Now.ToBinary.ToString & ".txt"), Data, True)
        End Sub
    End Class
End Namespace
