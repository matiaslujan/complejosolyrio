<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detReserva
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtServiciosTot = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDeuda = New System.Windows.Forms.TextBox
        Me.Pagado = New System.Windows.Forms.Label
        Me.txtPagado = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.dgvPagos = New System.Windows.Forms.DataGridView
        Me.btnEliminarPago = New System.Windows.Forms.Button
        Me.btnModificarPago = New System.Windows.Forms.Button
        Me.btnAgregarPago = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.dgvAlojamientos = New System.Windows.Forms.DataGridView
        Me.btnEliminarAloj = New System.Windows.Forms.Button
        Me.btnModificarAloj = New System.Windows.Forms.Button
        Me.btnAgregarAloj = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.CbxCancelada = New System.Windows.Forms.CheckBox
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox
        Me.cbClientes = New System.Windows.Forms.ComboBox
        Me.Descripcion = New System.Windows.Forms.Label
        Me.btnCalcular = New System.Windows.Forms.Button
        Me.Label12 = New System.Windows.Forms.Label
        Me.dgvServiciosReserva = New System.Windows.Forms.DataGridView
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaEgreso = New System.Windows.Forms.DateTimePicker
        Me.dtpFechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.btnSalir = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.txtImpEstadia = New System.Windows.Forms.TextBox
        Me.txtImpDia = New System.Windows.Forms.TextBox
        Me.txtCantDia = New System.Windows.Forms.TextBox
        Me.txtCantPer = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlojamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvServiciosReserva, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(973, 165)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(31, 13)
        Me.Label15.TabIndex = 162
        Me.Label15.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Location = New System.Drawing.Point(966, 184)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(50, 20)
        Me.txtTotal.TabIndex = 161
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(89, 289)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 160
        Me.Label14.Text = "Subtotal"
        '
        'txtServiciosTot
        '
        Me.txtServiciosTot.Enabled = False
        Me.txtServiciosTot.Location = New System.Drawing.Point(34, 286)
        Me.txtServiciosTot.Name = "txtServiciosTot"
        Me.txtServiciosTot.ReadOnly = True
        Me.txtServiciosTot.Size = New System.Drawing.Size(50, 20)
        Me.txtServiciosTot.TabIndex = 159
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(971, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(39, 13)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "Deuda"
        '
        'txtDeuda
        '
        Me.txtDeuda.Enabled = False
        Me.txtDeuda.Location = New System.Drawing.Point(967, 270)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.ReadOnly = True
        Me.txtDeuda.Size = New System.Drawing.Size(50, 20)
        Me.txtDeuda.TabIndex = 157
        '
        'Pagado
        '
        Me.Pagado.AutoSize = True
        Me.Pagado.Location = New System.Drawing.Point(969, 207)
        Me.Pagado.Name = "Pagado"
        Me.Pagado.Size = New System.Drawing.Size(44, 13)
        Me.Pagado.TabIndex = 156
        Me.Pagado.Text = "Pagado"
        '
        'txtPagado
        '
        Me.txtPagado.Enabled = False
        Me.txtPagado.Location = New System.Drawing.Point(967, 226)
        Me.txtPagado.Name = "txtPagado"
        Me.txtPagado.ReadOnly = True
        Me.txtPagado.Size = New System.Drawing.Size(50, 20)
        Me.txtPagado.TabIndex = 155
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(784, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 16)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Pagos"
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Location = New System.Drawing.Point(671, 181)
        Me.dgvPagos.MultiSelect = False
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.RowHeadersVisible = False
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(289, 102)
        Me.dgvPagos.TabIndex = 153
        '
        'btnEliminarPago
        '
        Me.btnEliminarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPago.Location = New System.Drawing.Point(854, 309)
        Me.btnEliminarPago.Name = "btnEliminarPago"
        Me.btnEliminarPago.Size = New System.Drawing.Size(72, 28)
        Me.btnEliminarPago.TabIndex = 152
        Me.btnEliminarPago.Text = "Eliminar"
        Me.btnEliminarPago.UseVisualStyleBackColor = True
        '
        'btnModificarPago
        '
        Me.btnModificarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPago.Location = New System.Drawing.Point(776, 309)
        Me.btnModificarPago.Name = "btnModificarPago"
        Me.btnModificarPago.Size = New System.Drawing.Size(72, 28)
        Me.btnModificarPago.TabIndex = 151
        Me.btnModificarPago.Text = "Modificar"
        Me.btnModificarPago.UseVisualStyleBackColor = True
        '
        'btnAgregarPago
        '
        Me.btnAgregarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPago.Location = New System.Drawing.Point(698, 309)
        Me.btnAgregarPago.Name = "btnAgregarPago"
        Me.btnAgregarPago.Size = New System.Drawing.Size(72, 28)
        Me.btnAgregarPago.TabIndex = 150
        Me.btnAgregarPago.Text = "Agregar"
        Me.btnAgregarPago.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(455, 155)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Alojamientos"
        '
        'dgvAlojamientos
        '
        Me.dgvAlojamientos.AllowUserToAddRows = False
        Me.dgvAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlojamientos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlojamientos.Location = New System.Drawing.Point(353, 181)
        Me.dgvAlojamientos.MultiSelect = False
        Me.dgvAlojamientos.Name = "dgvAlojamientos"
        Me.dgvAlojamientos.ReadOnly = True
        Me.dgvAlojamientos.RowHeadersVisible = False
        Me.dgvAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlojamientos.Size = New System.Drawing.Size(289, 102)
        Me.dgvAlojamientos.TabIndex = 148
        '
        'btnEliminarAloj
        '
        Me.btnEliminarAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarAloj.Location = New System.Drawing.Point(536, 309)
        Me.btnEliminarAloj.Name = "btnEliminarAloj"
        Me.btnEliminarAloj.Size = New System.Drawing.Size(72, 28)
        Me.btnEliminarAloj.TabIndex = 147
        Me.btnEliminarAloj.Text = "Eliminar"
        Me.btnEliminarAloj.UseVisualStyleBackColor = True
        '
        'btnModificarAloj
        '
        Me.btnModificarAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarAloj.Location = New System.Drawing.Point(458, 309)
        Me.btnModificarAloj.Name = "btnModificarAloj"
        Me.btnModificarAloj.Size = New System.Drawing.Size(72, 28)
        Me.btnModificarAloj.TabIndex = 146
        Me.btnModificarAloj.Text = "Modificar"
        Me.btnModificarAloj.UseVisualStyleBackColor = True
        '
        'btnAgregarAloj
        '
        Me.btnAgregarAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAloj.Location = New System.Drawing.Point(380, 309)
        Me.btnAgregarAloj.Name = "btnAgregarAloj"
        Me.btnAgregarAloj.Size = New System.Drawing.Size(72, 28)
        Me.btnAgregarAloj.TabIndex = 145
        Me.btnAgregarAloj.Text = "Agregar"
        Me.btnAgregarAloj.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(221, 12)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(25, 30)
        Me.btnNuevo.TabIndex = 144
        Me.btnNuevo.Text = "+"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'CbxCancelada
        '
        Me.CbxCancelada.AutoSize = True
        Me.CbxCancelada.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbxCancelada.Location = New System.Drawing.Point(853, 360)
        Me.CbxCancelada.Name = "CbxCancelada"
        Me.CbxCancelada.Size = New System.Drawing.Size(104, 24)
        Me.CbxCancelada.TabIndex = 143
        Me.CbxCancelada.Text = "Cancelada"
        Me.CbxCancelada.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(698, 54)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(270, 57)
        Me.txtDescripcion.TabIndex = 142
        Me.txtDescripcion.Text = ""
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(83, 12)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(125, 28)
        Me.cbClientes.TabIndex = 141
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(793, 114)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(92, 20)
        Me.Descripcion.TabIndex = 140
        Me.Descripcion.Text = "Descripcion"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(530, 71)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(23, 26)
        Me.btnCalcular.TabIndex = 139
        Me.btnCalcular.Text = "$"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(148, 155)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(64, 16)
        Me.Label12.TabIndex = 138
        Me.Label12.Text = "Servicios"
        '
        'dgvServiciosReserva
        '
        Me.dgvServiciosReserva.AllowUserToAddRows = False
        Me.dgvServiciosReserva.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvServiciosReserva.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvServiciosReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvServiciosReserva.Location = New System.Drawing.Point(35, 181)
        Me.dgvServiciosReserva.MultiSelect = False
        Me.dgvServiciosReserva.Name = "dgvServiciosReserva"
        Me.dgvServiciosReserva.ReadOnly = True
        Me.dgvServiciosReserva.RowHeadersVisible = False
        Me.dgvServiciosReserva.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvServiciosReserva.Size = New System.Drawing.Size(289, 102)
        Me.dgvServiciosReserva.TabIndex = 137
        '
        'btnEliminar
        '
        Me.btnEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.Location = New System.Drawing.Point(218, 309)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(72, 28)
        Me.btnEliminar.TabIndex = 136
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.Location = New System.Drawing.Point(140, 309)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 28)
        Me.btnModificar.TabIndex = 135
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'btnAgregar
        '
        Me.btnAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.Location = New System.Drawing.Point(62, 309)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(72, 28)
        Me.btnAgregar.TabIndex = 134
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(800, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(111, 26)
        Me.dtpFecha.TabIndex = 133
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(551, 12)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(111, 26)
        Me.dtpFechaEgreso.TabIndex = 132
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(337, 12)
        Me.dtpFechaIngreso.Name = "dtpFechaIngreso"
        Me.dtpFechaIngreso.Size = New System.Drawing.Size(112, 26)
        Me.dtpFechaIngreso.TabIndex = 131
        '
        'txtId
        '
        Me.txtId.Enabled = False
        Me.txtId.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtId.Location = New System.Drawing.Point(58, -14)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(29, 26)
        Me.txtId.TabIndex = 115
        Me.txtId.Visible = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(22, -10)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 20)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "Id"
        Me.Label11.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnSalir.Location = New System.Drawing.Point(517, 350)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 34)
        Me.btnSalir.TabIndex = 129
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.SystemColors.Control
        Me.btnGuardar.Location = New System.Drawing.Point(326, 350)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar.TabIndex = 128
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtImpEstadia
        '
        Me.txtImpEstadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpEstadia.Location = New System.Drawing.Point(591, 74)
        Me.txtImpEstadia.Name = "txtImpEstadia"
        Me.txtImpEstadia.Size = New System.Drawing.Size(73, 26)
        Me.txtImpEstadia.TabIndex = 127
        '
        'txtImpDia
        '
        Me.txtImpDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpDia.Location = New System.Drawing.Point(452, 70)
        Me.txtImpDia.Name = "txtImpDia"
        Me.txtImpDia.Size = New System.Drawing.Size(72, 26)
        Me.txtImpDia.TabIndex = 126
        '
        'txtCantDia
        '
        Me.txtCantDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantDia.Location = New System.Drawing.Point(285, 70)
        Me.txtCantDia.Name = "txtCantDia"
        Me.txtCantDia.Size = New System.Drawing.Size(42, 26)
        Me.txtCantDia.TabIndex = 125
        '
        'txtCantPer
        '
        Me.txtCantPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantPer.Location = New System.Drawing.Point(143, 69)
        Me.txtCantPer.Name = "txtCantPer"
        Me.txtCantPer.Size = New System.Drawing.Size(38, 26)
        Me.txtCantPer.TabIndex = 124
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(552, 53)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(144, 20)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Importe de Estadia"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(187, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 20)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "Cant de dias"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(485, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Egreso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(333, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Importe por Dia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(28, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Cant. Personas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(261, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(743, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Fecha"
        '
        'detReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Wheat
        Me.ClientSize = New System.Drawing.Size(1064, 478)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txtServiciosTot)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtDeuda)
        Me.Controls.Add(Me.Pagado)
        Me.Controls.Add(Me.txtPagado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgvPagos)
        Me.Controls.Add(Me.btnEliminarPago)
        Me.Controls.Add(Me.btnModificarPago)
        Me.Controls.Add(Me.btnAgregarPago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvAlojamientos)
        Me.Controls.Add(Me.btnEliminarAloj)
        Me.Controls.Add(Me.btnModificarAloj)
        Me.Controls.Add(Me.btnAgregarAloj)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.CbxCancelada)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.cbClientes)
        Me.Controls.Add(Me.Descripcion)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.dgvServiciosReserva)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.dtpFechaEgreso)
        Me.Controls.Add(Me.dtpFechaIngreso)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.txtImpEstadia)
        Me.Controls.Add(Me.txtImpDia)
        Me.Controls.Add(Me.txtCantDia)
        Me.Controls.Add(Me.txtCantPer)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "detReserva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reserva"
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAlojamientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvServiciosReserva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtServiciosTot As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDeuda As System.Windows.Forms.TextBox
    Friend WithEvents Pagado As System.Windows.Forms.Label
    Friend WithEvents txtPagado As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminarPago As System.Windows.Forms.Button
    Friend WithEvents btnModificarPago As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPago As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dgvAlojamientos As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminarAloj As System.Windows.Forms.Button
    Friend WithEvents btnModificarAloj As System.Windows.Forms.Button
    Friend WithEvents btnAgregarAloj As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents CbxCancelada As System.Windows.Forms.CheckBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents cbClientes As System.Windows.Forms.ComboBox
    Friend WithEvents Descripcion As System.Windows.Forms.Label
    Friend WithEvents btnCalcular As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dgvServiciosReserva As System.Windows.Forms.DataGridView
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaEgreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpFechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtImpEstadia As System.Windows.Forms.TextBox
    Friend WithEvents txtImpDia As System.Windows.Forms.TextBox
    Friend WithEvents txtCantDia As System.Windows.Forms.TextBox
    Friend WithEvents txtCantPer As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
