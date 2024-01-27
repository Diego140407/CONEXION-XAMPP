Imports MySql.Data.MySqlClient
Public Class Form1
    Private conectarmysqlcomand As Object

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'crear la conexion a xamp'
            conectarmysql = New MySqlConnection("server=localhost;" + "database=ejercicio1;user=root;password=;")
            'abrir la conexion'
            conectarmysql.open()
            'inicializar el objeto command'
            conectarmysqlcomand. = New MySqlCommand
            conectarmysqlcomand.commandtype = CommandType.Text

        Catch ex As Exception

        End Try
    End Sub
End Class
