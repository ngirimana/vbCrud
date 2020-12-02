Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim stud_id As Integer
    Dim con As OleDbConnection
    Public Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Schadrack\Desktop\students.accdb")
        con.Open()
        dataGridShow()

    End Sub
    Public Sub Clear()
        txtFullName.Text = ""
        txtIdNo.Text = ""
        txtManufacturer.Text = ""
        txtPhoneNumber.Text = ""
        txtSerialNumber.Text = ""
        txtRegNumber.Text = ""
    End Sub
    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Try
            Dim InsertQuery As String = "insert into students(FullName,IdNumber,PhoneNumber,RegNumber,Manufacturer,SerialNumber)
                values(@name,@IdNbr,@phone,@regg,@manu,@serial)"
            RunQquery(InsertQuery)
            Clear()
            MsgBox("Record Added Succesully")
            dataGridShow()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub RunQquery(ByVal query As String)
        con = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Schadrack\Desktop\students.accdb")
        Dim cmd As New OleDbCommand(query, con)
        cmd.Parameters.AddWithValue("@name", txtFullName.Text)
        cmd.Parameters.AddWithValue("@IdNbr", txtIdNo.Text)
        cmd.Parameters.AddWithValue("@reg", txtRegNumber.Text)
        cmd.Parameters.AddWithValue("@phone", txtPhoneNumber.Text)
        cmd.Parameters.AddWithValue("@manu", txtManufacturer.Text)
        cmd.Parameters.AddWithValue("@serial", txtSerialNumber.Text)
        cmd.Parameters.AddWithValue("@id", stud_id)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()



    End Sub


    Private Sub dataGridShow()
        Dim ds As New DataSet
        Dim dt As New DataTable
        ds.Tables.Add(dt)
        Dim da As OleDbDataAdapter
        da = New OleDbDataAdapter("select * from students", con)
        da.Fill(dt)
        dtgStusentsData.DataSource = dt.DefaultView
        con.Close()

    End Sub
    Public Sub dtgStusentsData_CellClick(Sender As Object, e As DataGridViewCellEventArgs) Handles dtgStusentsData.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = dtgStusentsData.Rows(index)
        stud_id = selectedRow.Cells(0).Value.ToString()
        txtFullName.Text = selectedRow.Cells(1).Value.ToString()
        txtIdNo.Text = selectedRow.Cells(2).Value.ToString()
        txtPhoneNumber.Text = selectedRow.Cells(3).Value.ToString()
        txtRegNumber.Text = selectedRow.Cells(4).Value.ToString()
        txtManufacturer.Text = selectedRow.Cells(5).Value.ToString()
        txtSerialNumber.Text = selectedRow.Cells(6).Value.ToString()



    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            Dim UpdateQuery As String = "update students Set FullName=@name,IdNumber=@IdNbr,PhoneNumber=@phone,RegNumber=@regg,Manufacturer=@manu,SerialNumber=@serial where ID=@id"

            RunQquery(UpdateQuery)
            MsgBox("Record Updated Succesully")
            Clear()
            dataGridShow()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim deleteQuery As String = "DELETE from students where ID=" & stud_id
            RunQquery(deleteQuery)
            MsgBox("Record Deleted Successfully")
            Clear()
            dataGridShow()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
