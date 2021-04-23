<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Pedido
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GbCabecera = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GbDetalle = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.DgDetalle = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalLinea = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnEnviar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GbCabecera.SuspendLayout()
        Me.GbDetalle.SuspendLayout()
        CType(Me.DgDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GbCabecera
        '
        Me.GbCabecera.Controls.Add(Me.Label6)
        Me.GbCabecera.Controls.Add(Me.Label5)
        Me.GbCabecera.Controls.Add(Me.Label4)
        Me.GbCabecera.Controls.Add(Me.Label3)
        Me.GbCabecera.Controls.Add(Me.Label2)
        Me.GbCabecera.Controls.Add(Me.Label1)
        Me.GbCabecera.Controls.Add(Me.TextBox6)
        Me.GbCabecera.Controls.Add(Me.TextBox5)
        Me.GbCabecera.Controls.Add(Me.TextBox4)
        Me.GbCabecera.Controls.Add(Me.TextBox3)
        Me.GbCabecera.Controls.Add(Me.TextBox2)
        Me.GbCabecera.Controls.Add(Me.TextBox1)
        Me.GbCabecera.Location = New System.Drawing.Point(13, 12)
        Me.GbCabecera.Name = "GbCabecera"
        Me.GbCabecera.Size = New System.Drawing.Size(457, 203)
        Me.GbCabecera.TabIndex = 0
        Me.GbCabecera.TabStop = False
        Me.GbCabecera.Text = "Cabecera"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(93, 161)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Moneda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(84, 128)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(256, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Fecha Entrega"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(60, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Fecha Pedido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(43, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nombre Cliente"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Codigo Cliente"
        '
        'TextBox6
        '
        Me.TextBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox6.Location = New System.Drawing.Point(163, 158)
        Me.TextBox6.MaxLength = 10
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(87, 27)
        Me.TextBox6.TabIndex = 5
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Location = New System.Drawing.Point(163, 125)
        Me.TextBox5.MaxLength = 200
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(282, 27)
        Me.TextBox5.TabIndex = 4
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Location = New System.Drawing.Point(358, 92)
        Me.TextBox4.MaxLength = 10
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(87, 27)
        Me.TextBox4.TabIndex = 3
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Location = New System.Drawing.Point(163, 92)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(87, 27)
        Me.TextBox3.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Location = New System.Drawing.Point(163, 59)
        Me.TextBox2.MaxLength = 200
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(282, 27)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Location = New System.Drawing.Point(163, 26)
        Me.TextBox1.MaxLength = 20
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(87, 27)
        Me.TextBox1.TabIndex = 0
        '
        'GbDetalle
        '
        Me.GbDetalle.Controls.Add(Me.Label11)
        Me.GbDetalle.Controls.Add(Me.Label10)
        Me.GbDetalle.Controls.Add(Me.Label9)
        Me.GbDetalle.Controls.Add(Me.Label8)
        Me.GbDetalle.Controls.Add(Me.Label7)
        Me.GbDetalle.Controls.Add(Me.TextBox11)
        Me.GbDetalle.Controls.Add(Me.TextBox10)
        Me.GbDetalle.Controls.Add(Me.TextBox9)
        Me.GbDetalle.Controls.Add(Me.TextBox8)
        Me.GbDetalle.Controls.Add(Me.TextBox7)
        Me.GbDetalle.Controls.Add(Me.DgDetalle)
        Me.GbDetalle.Location = New System.Drawing.Point(12, 221)
        Me.GbDetalle.Name = "GbDetalle"
        Me.GbDetalle.Size = New System.Drawing.Size(961, 320)
        Me.GbDetalle.TabIndex = 1
        Me.GbDetalle.TabStop = False
        Me.GbDetalle.Text = "Detalle"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(61, 23)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(114, 20)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Codigo Articulo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(232, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 20)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Descripcion"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(522, 23)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Cantidad"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(666, 23)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(806, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 20)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Total"
        '
        'TextBox11
        '
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox11.Enabled = False
        Me.TextBox11.Location = New System.Drawing.Point(806, 53)
        Me.TextBox11.MaxLength = 10
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(146, 27)
        Me.TextBox11.TabIndex = 9
        '
        'TextBox10
        '
        Me.TextBox10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox10.Location = New System.Drawing.Point(664, 53)
        Me.TextBox10.MaxLength = 10
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(143, 27)
        Me.TextBox10.TabIndex = 7
        '
        'TextBox9
        '
        Me.TextBox9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox9.Location = New System.Drawing.Point(522, 53)
        Me.TextBox9.MaxLength = 10
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(143, 27)
        Me.TextBox9.TabIndex = 8
        '
        'TextBox8
        '
        Me.TextBox8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox8.Location = New System.Drawing.Point(232, 53)
        Me.TextBox8.MaxLength = 10
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(291, 27)
        Me.TextBox8.TabIndex = 7
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Location = New System.Drawing.Point(61, 53)
        Me.TextBox7.MaxLength = 10
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(172, 27)
        Me.TextBox7.TabIndex = 6
        '
        'DgDetalle
        '
        Me.DgDetalle.AllowUserToAddRows = False
        Me.DgDetalle.AllowUserToDeleteRows = False
        Me.DgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Descripcion, Me.Cantidad, Me.Precio, Me.TotalLinea})
        Me.DgDetalle.Location = New System.Drawing.Point(6, 53)
        Me.DgDetalle.Name = "DgDetalle"
        Me.DgDetalle.ReadOnly = True
        Me.DgDetalle.RowHeadersWidth = 51
        Me.DgDetalle.RowTemplate.Height = 29
        Me.DgDetalle.Size = New System.Drawing.Size(946, 255)
        Me.DgDetalle.TabIndex = 0
        '
        'Codigo
        '
        Me.Codigo.HeaderText = "Codigo Articulo"
        Me.Codigo.MaxInputLength = 20
        Me.Codigo.MinimumWidth = 6
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 150
        '
        'Descripcion
        '
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.MaxInputLength = 200
        Me.Descripcion.MinimumWidth = 6
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 250
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.MaxInputLength = 18
        Me.Cantidad.MinimumWidth = 6
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        Me.Cantidad.Width = 125
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio"
        Me.Precio.MaxInputLength = 18
        Me.Precio.MinimumWidth = 6
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 125
        '
        'TotalLinea
        '
        Me.TotalLinea.HeaderText = "Total"
        Me.TotalLinea.MaxInputLength = 18
        Me.TotalLinea.MinimumWidth = 6
        Me.TotalLinea.Name = "TotalLinea"
        Me.TotalLinea.ReadOnly = True
        Me.TotalLinea.Width = 125
        '
        'BtnEnviar
        '
        Me.BtnEnviar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnEnviar.Location = New System.Drawing.Point(812, 186)
        Me.BtnEnviar.Name = "BtnEnviar"
        Me.BtnEnviar.Size = New System.Drawing.Size(152, 29)
        Me.BtnEnviar.TabIndex = 3
        Me.BtnEnviar.Text = "Enviar"
        Me.BtnEnviar.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.DarkRed
        Me.Label12.Location = New System.Drawing.Point(492, 12)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 20)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Label12"
        '
        'Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 553)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BtnEnviar)
        Me.Controls.Add(Me.GbDetalle)
        Me.Controls.Add(Me.GbCabecera)
        Me.Name = "Pedido"
        Me.Text = "Pedidos"
        Me.GbCabecera.ResumeLayout(False)
        Me.GbCabecera.PerformLayout()
        Me.GbDetalle.ResumeLayout(False)
        Me.GbDetalle.PerformLayout()
        CType(Me.DgDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GbCabecera As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GbDetalle As GroupBox
    Friend WithEvents DgDetalle As DataGridView
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Codigo As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents Precio As DataGridViewTextBoxColumn
    Friend WithEvents TotalLinea As DataGridViewTextBoxColumn
    Friend WithEvents BtnEnviar As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
End Class
