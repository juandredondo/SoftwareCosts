Imports System.Data
Imports System.Data.OleDb
Public Class FormEstadoCostos
    Dim objeto As New BibliotecaClases.MisClases
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub



    Private Sub FormEstadoCostos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'declaramos un objeto de la clase MIsclases que esta en la Boblioteca de Clases

        '  objeto.conectarse()
        objeto.llenarGrid(Me.DataGridView1)
    End Sub



    
    'Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click


    '    Button4.Enabled = True
    '    Button1.Enabled = False
    '    Button2.Enabled = False




    '    'Try


    '    '    objeto.conectarse()
    '    '    objeto.Insertar(CInt(Txt1.Text), CInt(Txt2.Text))
    '    '    objeto.CerrarConexion()
    '    'Catch ex As Exception
    '    '    MsgBox(ex.ToString, MsgBoxStyle.Critical)
    '    'End Try
    'End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        objeto.llenarGrid(Me.DataGridView1)

    End Sub

 

    Private Sub Txt19_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Txt9.KeyPress, Txt8.KeyPress, Txt7.KeyPress, Txt6.KeyPress, Txt5.KeyPress, Txt4.KeyPress, Txt3.KeyPress, Txt27.KeyPress, Txt26.KeyPress, Txt25.KeyPress, Txt24.KeyPress, Txt23.KeyPress, Txt22.KeyPress, Txt21.KeyPress, Txt20.KeyPress, Txt2.KeyPress, Txt19.KeyPress, Txt18.KeyPress, Txt17.KeyPress, Txt16.KeyPress, Txt15.KeyPress, Txt14.KeyPress, Txt13.KeyPress, Txt12.KeyPress, Txt11.KeyPress, Txt10.KeyPress, Txt1.KeyPress
        If Char.IsLetter(e.KeyChar) Or Char.IsSymbol(e.KeyChar) Or Char.IsPunctuation(e.KeyChar) Then
            e.Handled = True
            MsgBox("En este Campo solo se puede digitar numeros ", MsgBoxStyle.Exclamation)
        End If
    End Sub

    Private Sub SalirBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()

    End Sub

    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click

        habilitar(False, True, False, True, True)
        Try
            Dim j As Integer
            For i As Integer = 0 To Val(Me.DataGridView1.RowCount) - 1
                j = Me.DataGridView1.Rows(i).Cells(26).Value
            Next

            objeto.llenarGrid(Me.DataGridView1)
            If j = 0 Then
                ' MsgBox("No hay Datos en la bd,Guarde a continuacion ingrese los datos ", MsgBoxStyle.Information)
            Else
                Txt1.Text = j

            End If

        Catch ex As Exception
            MsgBox(ex.ToString)

        End Try

    End Sub

    Public Sub habilitar(ByVal NuevoBtn As Boolean, ByVal CalculatBtn As Boolean, ByVal GuardarBtn As Boolean, ByVal cancelarBtn As Boolean, ByVal SalirBt As Boolean)

        BtnNuevo.Enabled = NuevoBtn
        BtnCalcular.Enabled = CalculatBtn
        BtnGuardar.Enabled = GuardarBtn
        BtnCancelar.Enabled = cancelarBtn
        BtnSalir.Enabled = SalirBt
    End Sub

    Private Sub BtnCalcular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCalcular.Click
        habilitar(False, True, True, True, False)
        If Txt1.Text = "" Or Txt2.Text = "" Or Txt4.Text = "" Or Txt6.Text = "" Or Txt9.Text = "" Or Txt13.Text = "" Or Txt14.Text = "" Or Txt15.Text = "" Or Txt16.Text = "" Or Txt17.Text = "" Or Txt18.Text = "" Or Txt20.Text = "" Or Txt24.Text = "" Or Txt26.Text = "" Or Txt28.Text = "" Or Txt29.Text = "" Then

            MsgBox("Los campos con * son obligatorios", MsgBoxStyle.Exclamation)
        Else
            Try
                Txt3.Text = CStr((CInt(Txt1.Text) + CInt(Txt2.Text)))
                Txt5.Text = CStr((CInt(Txt3.Text) - CInt(Txt4.Text)))
                Txt7.Text = CStr((CInt(Txt5.Text) - CInt(Txt6.Text)))
                Txt8.Text = CStr((CInt(Txt9.Text) - CInt(Txt10.Text)))
                Txt11.Text = CStr((CInt(Txt7.Text) + CInt(Txt8.Text)))
                Txt12.Text = CStr((CInt(Txt13.Text) + CInt(Txt14.Text) + CInt(Txt15.Text) + CInt(Txt16.Text) + CInt(Txt17.Text) + CInt(Txt18.Text)))
                Txt19.Text = CStr((CInt(Txt11.Text) + CInt(Txt12.Text)))
                Txt21.Text = CStr((CInt(Txt19.Text) + CInt(Txt20.Text)))
                Txt23.Text = CStr((CInt(Txt21.Text) - CInt(Txt22.Text)))
                Txt25.Text = CStr((CInt(Txt23.Text) + CInt(Txt24.Text)))
                Txt27.Text = CStr((CInt(Txt25.Text) - CInt(Txt26.Text)))
                MsgBox("Calculos generados correctamente", MsgBoxStyle.Information)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If



    End Sub

    Private Sub BtnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnGuardar.Click
        habilitar(True, False, False, False, True)
        'a traves de un objeto accedemos al metodo llenargrid en misclases en la biblioteca de clases
        Try
            objeto.conectarse()
            objeto.Insertar(CInt(Txt1.Text), CInt(Txt2.Text), CInt(Txt3.Text), CInt(Txt4.Text), CInt(Txt5.Text), CInt(Txt6.Text), CInt(Txt7.Text), CInt(Txt8.Text), CInt(Txt9.Text), CInt(Txt10.Text), CInt(Txt11.Text), CInt(Txt12.Text), CInt(Txt13.Text), CInt(Txt14.Text), CInt(Txt15.Text), CInt(Txt16.Text), CInt(Txt17.Text), CInt(Txt18.Text), CInt(Txt19.Text), CInt(Txt20.Text), CInt(Txt21.Text), CInt(Txt22.Text), CInt(Txt23.Text), CInt(Txt24.Text), CInt(Txt25.Text), CInt(Txt26.Text), CInt(Txt27.Text), CStr(Txt28.Text), CStr(Txt29.Text))
            objeto.CerrarConexion()
            objeto.llenarGrid(DataGridView1)


            Txt1.Text = "0"
            Txt2.Text = "0"
            Txt3.Text = "0"
            Txt4.Text = "0"
            Txt5.Text = "0"
            Txt6.Text = "0"
            Txt7.Text = "0"
            Txt8.Text = "0"
            Txt9.Text = "0"
            Txt10.Text = "0"
            Txt1.Text = "0"
            Txt11.Text = "0"
            Txt12.Text = "0"
            Txt13.Text = "0"
            Txt14.Text = "0"
            Txt15.Text = "0"
            Txt16.Text = "0"

            Txt17.Text = "0"
            Txt18.Text = "0"
            Txt19.Text = "0"
            Txt20.Text = "0"
            Txt21.Text = "0"
            Txt22.Text = "0"
            Txt23.Text = "0"
            Txt24.Text = "0"

            Txt25.Text = "0"
            Txt26.Text = "0"
            Txt27.Text = "0"








        Catch ex As Exception
            MsgBox(ex.ToString, MsgBoxStyle.Critical)
            objeto.CerrarConexion()
        End Try

    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        habilitar(True, False, False, False, True)

    End Sub
End Class