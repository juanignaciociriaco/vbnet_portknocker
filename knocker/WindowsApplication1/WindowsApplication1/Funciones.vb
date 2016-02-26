Imports System.IO
Imports System.Net.Sockets


Public Class Funciones
    Public Shared _Port1 As Integer
    Public Shared _Port2 As Integer
    Sub New()

    End Sub

    Public Shared Function Leer(_Archivo As String) As List(Of String)
        Try
            Dim _ListaIP As New List(Of String)
            Dim _r As StreamReader = New StreamReader(_Archivo)
            While _r.Peek >= 0
                _ListaIP.Add(_r.ReadLine)
            End While
            Return _ListaIP
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Function
    Public Shared Function Knockear(_Host As String) As Boolean
        Try

            Dim _Client1 As New TcpClient
            Dim _Client2 As New TcpClient
            _Port1 = 65000
            _Port2 = 2
            My.Computer.Network.Ping(_Host, 1000)
            _Client1.ConnectAsync(_Host, _Port1)
            _Client2.ConnectAsync(_Host, _Port2)

            Return True

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try


    End Function
End Class
