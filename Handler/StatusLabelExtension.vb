Imports System.Runtime.CompilerServices

Module StatusLabelExtension
    <Extension()>
    Sub InvokeOnUiThreadIfRequired(ByVal control As Control, ByVal action As Action)
        If control.InvokeRequired Then
            control.BeginInvoke(action)
        Else
            action.Invoke()
        End If
    End Sub
End Module
