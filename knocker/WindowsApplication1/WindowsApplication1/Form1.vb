Public Class Form1
    Dim _HostsFile As String = "ListOfHosts.txt"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            If System.IO.File.Exists(_HostsFile) Then
                Dim _ListaDeIP As New List(Of String)
                _ListaDeIP = Funciones.Leer(_HostsFile)
                ComboBox1.Items.Clear()
                ComboBox1.DataSource = _ListaDeIP
            Else
                MsgBox("File doesn´t exists!")
                Me.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim _Host = ComboBox1.SelectedValue.ToString
        If Funciones.Knockear(_Host) Then
            MsgBox("Ready to connect!" & vbNewLine & "Knocked host " & _Host & vbNewLine & "On ports: " & Funciones._Port1 & " and " & Funciones._Port2)
        Else
            MsgBox("Surgio algun inconveniente", MsgBoxStyle.Critical)
        End If
    End Sub


End Class
