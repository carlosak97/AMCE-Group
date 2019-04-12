Public Class Lookup
    Dim SQL As New SQLControl
    Private Sub Lookup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Sql.HasConnection = True Then
            SQL.RunQuery("Select Emp_ID AS ID, First_Name AS Name, Last_Name From Employee")
            If Sql.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = Sql.SQLDataset.Tables(0)
            End If
        End If
    End Sub

    Private Sub EmployeesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeesToolStripMenuItem.Click
        If SQL.HasConnection = True Then
            SQL.RunQuery("Select Emp_ID AS ID, First_Name AS Name, Last_Name From Employee")
            If SQL.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub

    Private Sub CustomersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CustomersToolStripMenuItem.Click
        If SQL.HasConnection = True Then
            SQL.RunQuery("Select Cust_Name AS Name, Cust_Age AS Age, Cust_Telephone AS Telephone From Customer")
            If SQL.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub

    Private Sub ItemsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ItemsToolStripMenuItem.Click
        If SQL.HasConnection = True Then
            SQL.RunQuery("Select  Item_Code AS Code, ItemName AS Name, ItemSize AS Size, ItemColor AS Color, Item_Price AS Price, ItemQuantity AS Quantity From Item")
            If SQL.SQLDataset.Tables.Count > 0 Then
                DGVData.DataSource = SQL.SQLDataset.Tables(0)
            End If
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class