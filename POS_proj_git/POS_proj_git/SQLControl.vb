Imports System.Data.Sql
Imports System.Data.SqlClient


Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server= USER\POSSERVER;Database=POS;Trusted_Connection=True;"}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet



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
    Public Sub RunQuery(Query As String)
        Try
            SQLCon.Open()
            SQLCmd = New SqlCommand(Query, SQLCon)
            SQLDA = New SqlDataAdapter(SQLCmd)
            SQLDataset = New DataSet
            SQLDA.Fill(SQLDataset)
            SQLCon.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
            If SQLCon.State = ConnectionState.Open Then
                SQLCon.Close()
            End If
        End Try
    End Sub
End Class
