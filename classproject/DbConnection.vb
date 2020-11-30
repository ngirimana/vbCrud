Option Explicit On
Option Strict On

Imports System.Data
Imports System.Data.OleDb



Module DbConnection
    Public Function GetConnection() As String
        Dim StrConn As String = "Provider=Microsoft.ACE.OELDB.12.0;Data Souce= " & Application.StartupPath
        StrConn &= "\VB_CLASS_PROJECT Security Info=False;"
        Return StrConn
    End Function

    Public Con As New OleDbConnection(GetConnection())
    Public Cmd As OleDbCommand
    Public SQL As String = String.Empty

    Public Function PerformCrude(Com As OleDbCommand) As DataTable
        Dim da As OleDbDataAdapter
        Dim dt As New DataTable()

        Try
            da = New OleDbDataAdapter
            da.SelectCommand = Com
            da.Fill(dt)
            Return dt

        Catch ex As Exception
            MessageBox.Show("An error Occurred" & ex.Message, "CRUDE Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dt = Nothing
        End Try
        Return dt

    End Function





End Module
