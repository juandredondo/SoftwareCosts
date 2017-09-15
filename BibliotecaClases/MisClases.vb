Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Public Class MisClases

    Public conn As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\BDsoftwareCost.accdb")
    Public cmd As New OleDb.OleDbCommand
    Dim comandos As New OleDbCommand
    Public dr As OleDb.OleDbDataReader

    Public Sub conectarse()

        Try
            conn.Open()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub CerrarConexion()
        Try
            conn.Close()
            'MsgBox("conexion exitosa", MsgBoxStyle.Information)

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Public Sub Insertar(ByVal v1 As Integer, ByVal v2 As Integer, ByVal v3 As Integer, ByVal v4 As Integer, ByVal v5 As Integer, ByVal v6 As Integer, ByVal v7 As Integer, ByVal v8 As Integer, ByVal v9 As Integer, ByVal v10 As Integer, ByVal v11 As Integer, ByVal v12 As Integer, ByVal v13 As Integer, ByVal v14 As Integer, ByVal v15 As Integer, ByVal v16 As Integer, ByVal v17 As Integer, ByVal v18 As Integer, ByVal v19 As Integer, ByVal v20 As Integer, ByVal v21 As Integer, ByVal v22 As Integer, ByVal v23 As Integer, ByVal v24 As Integer, ByVal v25 As Integer, ByVal v26 As Integer, ByVal v27 As Integer, ByVal v28 As String, ByVal v29 As String)
        Try
            cmd.CommandType = CommandType.Text
            cmd.Connection = conn
            cmd.CommandText = "insert into Tabla1  values (" & v1 & "," & v2 & "," & v3 & "," & v4 & "," & v5 & "," & v6 & "," & v7 & "," & v8 & "," & v9 & "," & v10 & "," & v11 & "," & v12 & "," & v13 & "," & v14 & "," & v15 & "," & v16 & "," & v17 & "," & v18 & "," & v19 & "," & v20 & "," & v21 & "," & v22 & "," & v23 & "," & v24 & "," & v25 & "," & v26 & "," & v27 & ",'" & v28 & "','" & v29 & "')"
            cmd.ExecuteNonQuery()
            MsgBox("Registro Insertado Correctamente", MsgBoxStyle.Information)
            CerrarConexion() 'funcion ue cuerra la conexion al abases de datos 
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            CerrarConexion()
        End Try

    End Sub
    'funcion para llenar un grid 
    Public Sub llenarGrid(ByVal datagrid As DataGridView)
        Try
            Dim adaptador As New OleDbDataAdapter
            Dim registroas As New DataSet
            Dim consulta As String
            consulta = "SELECT * FROM Tabla1"
            adaptador = New OleDbDataAdapter(consulta, conn)
            registroas.Tables.Add("Tabla1")
            adaptador.Fill(registroas.Tables("Tabla1"))
            datagrid.DataSource = registroas.Tables("Tabla1")
        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
        End Try
       
    End Sub

End Class
