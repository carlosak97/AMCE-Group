Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=USER\POSSERVER;Database=POS;Trusted_Connection=True;"}
    Public SQLCmd As SqlCommand


    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()
            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

End Class
