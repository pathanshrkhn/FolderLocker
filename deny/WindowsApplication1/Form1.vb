Imports System.IO
Imports System.FlagsAttribute
Imports System.Windows.Forms
Imports System.String
Imports System.Security.AccessControl



Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As Object
        FolderBrowserDialog1.ShowDialog()


        s = FolderBrowserDialog1.SelectedPath



        Dim ToHideDir As New System.IO.DirectoryInfo(s)
        'Then Change the Attribute To Hidden Which will Hide the Folder
        ToHideDir.Attributes = IO.FileAttributes.Hidden
        Dim fs As FileSystemSecurity = File.GetAccessControl(s)
        fs.AddAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(s, fs)


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

        
        Dim s As Object
        FolderBrowserDialog1.ShowDialog()


        s = FolderBrowserDialog1.SelectedPath




        Dim fs2 As FileSystemSecurity = File.GetAccessControl(s)
        fs2.RemoveAccessRule(New FileSystemAccessRule(Environment.UserName, FileSystemRights.FullControl, AccessControlType.Deny))
        File.SetAccessControl(s, fs2)
        Catch ex As Exception

        End Try
    End Sub

  
End Class
