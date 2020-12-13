Imports System.Threading

Public Class Form1

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Try

        
        If TextBox1.Text = "Sher" Or TextBox1.Text = "P@th@n$k" Then

                Process.Start("D:\Local Disk(D)\M")


            Me.Close()

        End If






        If TextBox1.Text.Length = 5 Then


            Me.Close()

        End If

        Catch ex As Exception

            MsgBox(ex.ToString())


        End Try

    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetDesktopLocation(500, 330)





    End Sub

    Private Shared Sub ResetText(ByVal p1 As String)
        Throw New NotImplementedException
    End Sub



End Class
