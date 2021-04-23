
Imports System.Windows.Forms.DataGridView


Public Class Pedido

    Dim dtDetalle As New DataTable
    Dim SentPedidos As SentVentas.Pedidos
    Dim myDataSet = New DataSet("myDataSet")

    Private Sub Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        MakeTable()
        LimpiarCabecera()
    End Sub

    Private Sub MakeTable()
        dtDetalle = New DataTable("dDetalle")

        Dim colLin As DataColumn
        colLin = New DataColumn("Lin", GetType(System.Int64))

        Dim colCodigo As DataColumn
        colCodigo = New DataColumn("Codigo", GetType(System.String))

        Dim colDescripcion As DataColumn
        colDescripcion = New DataColumn("Descripcion", GetType(System.String))

        Dim colCantidad As DataColumn
        colCantidad = New DataColumn("Cantidad", GetType(System.String))

        Dim colPrecio As DataColumn
        colPrecio = New DataColumn("Precio", GetType(System.Int16))

        Dim colTotalLinea As DataColumn
        colTotalLinea = New DataColumn("TotalLinea", GetType(System.String))

        dtDetalle.Columns.Add(colLin)
        dtDetalle.Columns.Add(colCodigo)
        dtDetalle.Columns.Add(colDescripcion)
        dtDetalle.Columns.Add(colCantidad)
        dtDetalle.Columns.Add(colPrecio)
        dtDetalle.Columns.Add(colTotalLinea)
    End Sub
    Private Sub AgregarLinea()
        Dim newRow1 As DataRow
        Dim i As Long
        i = dtDetalle.Rows.Count + 1
        newRow1 = dtDetalle.NewRow
        newRow1("Lin") = i
        dtDetalle.Rows.Add(newRow1)
        dtDetalle.Rows(i - 1)("Codigo") = TextBox7.Text
        dtDetalle.Rows(i - 1)("Descripcion") = TextBox8.Text
        dtDetalle.Rows(i - 1)("Cantidad") = TextBox9.Text
        dtDetalle.Rows(i - 1)("Precio") = TextBox10.Text
        dtDetalle.Rows(i - 1)("TotalLinea") = TextBox11.Text


        DgDetalle.DataSource = dtDetalle
        BtnEnviar.Focus()
    End Sub
    Private Sub CargarDt()

    End Sub
    Private Sub LimpiarCabecera()
        dtDetalle.Clear()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        Label12.Visible = False
    End Sub

    Private Sub LimpiarDetallle()
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
    End Sub

    Private Sub BtnEnviar_Click(sender As Object, e As EventArgs) Handles BtnEnviar.Click
        Label12.Visible = False
        If dtDetalle.Rows.Count = 0 Then
            Label12.Visible = True
            Label12.Text = "DEBE CARGAR DETALLES DEL PEDIDO"
            Exit Sub
        End If
        CargarDt()
        dtDetalle = DgDetalle.DataSource
        SentPedidos.Enviar(TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, dtDetalle)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox1_Validated(sender As Object, e As EventArgs) Handles TextBox1.Validated
        Label12.Visible = False
        If Len(TextBox1.Text) = 0 Then
            TextBox1.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        End If
    End Sub

    Private Sub TextBox2_Validated(sender As Object, e As EventArgs) Handles TextBox2.Validated
        Label12.Visible = False
        If Len(TextBox2.Text) = 0 Then
            TextBox2.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        End If
    End Sub

    Private Sub TextBox3_Validated(sender As Object, e As EventArgs) Handles TextBox3.Validated
        Dim FechaActual As String
        Label12.Visible = False
        If Len(TextBox3.Text) = 0 Then
            TextBox3.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        Else
            If IsDate(TextBox3.Text) = False Then
                TextBox3.Focus()
                TextBox3.Text = ""
                Label12.Visible = True
                Label12.Text = "Debe cargar una fecha valida"
            Else
                FechaActual = Date.Now
                FechaActual = CDate(FechaActual).ToString("dd/MM/yyyy")
                If TextBox3.Text < FechaActual Then
                    TextBox3.Focus()
                    TextBox3.Text = ""
                    Label12.Visible = True
                    Label12.Text = "Debe cargar una fecha valida"
                End If
            End If
        End If

    End Sub

    Private Sub TextBox4_Validated(sender As Object, e As EventArgs) Handles TextBox4.Validated
        Dim FechaActual As String
        Label12.Visible = False
        If Len(TextBox4.Text) = 0 Then
            TextBox4.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        End If
        If IsDate(TextBox4.Text) = False Then
            TextBox4.Focus()
            TextBox4.Text = ""
            Label12.Visible = True
            Label12.Text = "Debe cargar una fecha valida"
        Else
            FechaActual = Date.Now
            FechaActual = CDate(FechaActual).ToString("dd/MM/yyyy")
            If TextBox4.Text < FechaActual Then
                TextBox4.Focus()
                TextBox4.Text = ""
                Label12.Visible = True
                Label12.Text = "Debe cargar una fecha valida"
            End If
            If TextBox4.Text < TextBox3.Text Then
                TextBox4.Focus()
                TextBox4.Text = ""
                Label12.Visible = True
                Label12.Text = "Debe cargar una fecha valida"
            End If
        End If
    End Sub
    Private Sub TextBox5_Validated(sender As Object, e As EventArgs) Handles TextBox5.Validated
        Label12.Visible = False
        If Len(TextBox2.Text) = 0 Then
            TextBox5.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        End If
    End Sub

    Private Sub TextBox6_Validated(sender As Object, e As EventArgs) Handles TextBox6.Validated
        Label12.Visible = False
        If Len(TextBox6.Text) = 0 Then
            TextBox2.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        End If
    End Sub
    Private Sub TextBox8_Validated(sender As Object, e As EventArgs) Handles TextBox8.Validated
        Label12.Visible = False
        If Len(TextBox7.Text) = 0 Then
            TextBox7.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        End If
    End Sub
    Private Sub TextBox9_Validated(sender As Object, e As EventArgs) Handles TextBox9.Validated
        Label12.Visible = False
        If Len(TextBox8.Text) = 0 Then
            TextBox8.Focus()
            Label12.Visible = True
            Label12.Text = "Este campo no puede estar vacio"
        End If
    End Sub
    Private Sub TextBox10_Validated(sender As Object, e As EventArgs) Handles TextBox10.Validated


    End Sub

    Private Sub TextBox10_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox10.KeyPress
        If e.KeyChar = vbCr Then
            Label12.Visible = False
            If Len(TextBox10.Text) = 0 Then
                TextBox10.Focus()
                Label12.Visible = True
                Label12.Text = "Este campo no puede estar vacio"
            End If
            If IsNumeric(TextBox9.Text) = True And IsNumeric(TextBox10.Text) = True Then
                TextBox11.Text = TextBox9.Text * TextBox10.Text
            Else
                TextBox9.Focus()
                TextBox10.Text = ""
                TextBox9.Text = ""
                Exit Sub
            End If
            AgregarLinea()
        End If
    End Sub
End Class