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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtTotal = New System.Windows.Forms.TextBox
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
        Me.btnServicios = New System.Windows.Forms.Button
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlojamientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(98, 183)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(44, 20)
        Me.Label15.TabIndex = 162
        Me.Label15.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal.Location = New System.Drawing.Point(143, 183)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.ReadOnly = True
        Me.txtTotal.Size = New System.Drawing.Size(112, 26)
        Me.txtTotal.TabIndex = 161
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(375, 183)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 20)
        Me.Label13.TabIndex = 158
        Me.Label13.Text = "Deuda"
        '
        'txtDeuda
        '
        Me.txtDeuda.Enabled = False
        Me.txtDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeuda.Location = New System.Drawing.Point(438, 183)
        Me.txtDeuda.Name = "txtDeuda"
        Me.txtDeuda.ReadOnly = True
        Me.txtDeuda.Size = New System.Drawing.Size(111, 26)
        Me.txtDeuda.TabIndex = 157
        '
        'Pagado
        '
        Me.Pagado.AutoSize = True
        Me.Pagado.Location = New System.Drawing.Point(829, 347)
        Me.Pagado.Name = "Pagado"
        Me.Pagado.Size = New System.Drawing.Size(44, 13)
        Me.Pagado.TabIndex = 156
        Me.Pagado.Text = "Pagado"
        '
        'txtPagado
        '
        Me.txtPagado.Enabled = False
        Me.txtPagado.Location = New System.Drawing.Point(823, 324)
        Me.txtPagado.Name = "txtPagado"
        Me.txtPagado.ReadOnly = True
        Me.txtPagado.Size = New System.Drawing.Size(50, 20)
        Me.txtPagado.TabIndex = 155
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(697, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 18)
        Me.Label9.TabIndex = 154
        Me.Label9.Text = "Pagos"
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPagos.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvPagos.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvPagos.Location = New System.Drawing.Point(584, 216)
        Me.dgvPagos.MultiSelect = False
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        Me.dgvPagos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvPagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPagos.Size = New System.Drawing.Size(289, 102)
        Me.dgvPagos.TabIndex = 153
        '
        'btnEliminarPago
        '
        Me.btnEliminarPago.BackColor = System.Drawing.Color.White
        Me.btnEliminarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarPago.FlatAppearance.BorderSize = 2
        Me.btnEliminarPago.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarPago.Location = New System.Drawing.Point(740, 324)
        Me.btnEliminarPago.Name = "btnEliminarPago"
        Me.btnEliminarPago.Size = New System.Drawing.Size(72, 28)
        Me.btnEliminarPago.TabIndex = 152
        Me.btnEliminarPago.Text = "Eliminar"
        Me.btnEliminarPago.UseVisualStyleBackColor = False
        '
        'btnModificarPago
        '
        Me.btnModificarPago.BackColor = System.Drawing.Color.White
        Me.btnModificarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarPago.FlatAppearance.BorderSize = 2
        Me.btnModificarPago.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarPago.Location = New System.Drawing.Point(662, 324)
        Me.btnModificarPago.Name = "btnModificarPago"
        Me.btnModificarPago.Size = New System.Drawing.Size(72, 28)
        Me.btnModificarPago.TabIndex = 151
        Me.btnModificarPago.Text = "Modificar"
        Me.btnModificarPago.UseVisualStyleBackColor = False
        '
        'btnAgregarPago
        '
        Me.btnAgregarPago.BackColor = System.Drawing.Color.White
        Me.btnAgregarPago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarPago.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarPago.FlatAppearance.BorderSize = 2
        Me.btnAgregarPago.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarPago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarPago.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarPago.Location = New System.Drawing.Point(584, 324)
        Me.btnAgregarPago.Name = "btnAgregarPago"
        Me.btnAgregarPago.Size = New System.Drawing.Size(72, 28)
        Me.btnAgregarPago.TabIndex = 150
        Me.btnAgregarPago.Text = "Agregar"
        Me.btnAgregarPago.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(687, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Alojamientos"
        '
        'dgvAlojamientos
        '
        Me.dgvAlojamientos.AllowUserToAddRows = False
        Me.dgvAlojamientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlojamientos.BackgroundColor = System.Drawing.SystemColors.ActiveBorder
        Me.dgvAlojamientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvAlojamientos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvAlojamientos.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.dgvAlojamientos.Location = New System.Drawing.Point(585, 35)
        Me.dgvAlojamientos.MultiSelect = False
        Me.dgvAlojamientos.Name = "dgvAlojamientos"
        Me.dgvAlojamientos.ReadOnly = True
        Me.dgvAlojamientos.RowHeadersVisible = False
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.White
        Me.dgvAlojamientos.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvAlojamientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlojamientos.Size = New System.Drawing.Size(289, 102)
        Me.dgvAlojamientos.TabIndex = 148
        '
        'btnEliminarAloj
        '
        Me.btnEliminarAloj.BackColor = System.Drawing.Color.White
        Me.btnEliminarAloj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEliminarAloj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarAloj.FlatAppearance.BorderSize = 2
        Me.btnEliminarAloj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarAloj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarAloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnEliminarAloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEliminarAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminarAloj.Location = New System.Drawing.Point(741, 143)
        Me.btnEliminarAloj.Name = "btnEliminarAloj"
        Me.btnEliminarAloj.Size = New System.Drawing.Size(72, 28)
        Me.btnEliminarAloj.TabIndex = 147
        Me.btnEliminarAloj.Text = "Eliminar"
        Me.btnEliminarAloj.UseVisualStyleBackColor = False
        '
        'btnModificarAloj
        '
        Me.btnModificarAloj.BackColor = System.Drawing.Color.White
        Me.btnModificarAloj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificarAloj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarAloj.FlatAppearance.BorderSize = 2
        Me.btnModificarAloj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarAloj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarAloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnModificarAloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificarAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarAloj.Location = New System.Drawing.Point(663, 143)
        Me.btnModificarAloj.Name = "btnModificarAloj"
        Me.btnModificarAloj.Size = New System.Drawing.Size(72, 28)
        Me.btnModificarAloj.TabIndex = 146
        Me.btnModificarAloj.Text = "Modificar"
        Me.btnModificarAloj.UseVisualStyleBackColor = False
        '
        'btnAgregarAloj
        '
        Me.btnAgregarAloj.BackColor = System.Drawing.Color.White
        Me.btnAgregarAloj.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAgregarAloj.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarAloj.FlatAppearance.BorderSize = 2
        Me.btnAgregarAloj.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarAloj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarAloj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnAgregarAloj.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgregarAloj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarAloj.Location = New System.Drawing.Point(585, 143)
        Me.btnAgregarAloj.Name = "btnAgregarAloj"
        Me.btnAgregarAloj.Size = New System.Drawing.Size(72, 28)
        Me.btnAgregarAloj.TabIndex = 145
        Me.btnAgregarAloj.Text = "Agregar"
        Me.btnAgregarAloj.UseVisualStyleBackColor = False
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(331, 12)
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
        Me.CbxCancelada.Location = New System.Drawing.Point(143, 336)
        Me.CbxCancelada.Name = "CbxCancelada"
        Me.CbxCancelada.Size = New System.Drawing.Size(104, 24)
        Me.CbxCancelada.TabIndex = 143
        Me.CbxCancelada.Text = "Cancelada"
        Me.CbxCancelada.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(149, 235)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(336, 83)
        Me.txtDescripcion.TabIndex = 142
        Me.txtDescripcion.Text = ""
        '
        'cbClientes
        '
        Me.cbClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbClientes.FormattingEnabled = True
        Me.cbClientes.Location = New System.Drawing.Point(143, 12)
        Me.cbClientes.Name = "cbClientes"
        Me.cbClientes.Size = New System.Drawing.Size(182, 28)
        Me.cbClientes.TabIndex = 141
        '
        'Descripcion
        '
        Me.Descripcion.AutoSize = True
        Me.Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Descripcion.Location = New System.Drawing.Point(50, 235)
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.Size = New System.Drawing.Size(92, 20)
        Me.Descripcion.TabIndex = 140
        Me.Descripcion.Text = "Descripcion"
        '
        'btnCalcular
        '
        Me.btnCalcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalcular.Location = New System.Drawing.Point(261, 141)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(23, 26)
        Me.btnCalcular.TabIndex = 139
        Me.btnCalcular.Text = "$"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(438, 12)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(111, 26)
        Me.dtpFecha.TabIndex = 133
        '
        'dtpFechaEgreso
        '
        Me.dtpFechaEgreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEgreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEgreso.Location = New System.Drawing.Point(438, 56)
        Me.dtpFechaEgreso.Name = "dtpFechaEgreso"
        Me.dtpFechaEgreso.Size = New System.Drawing.Size(111, 26)
        Me.dtpFechaEgreso.TabIndex = 132
        '
        'dtpFechaIngreso
        '
        Me.dtpFechaIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaIngreso.Location = New System.Drawing.Point(143, 56)
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
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSalir.FlatAppearance.BorderSize = 3
        Me.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalir.Location = New System.Drawing.Point(501, 388)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 34)
        Me.btnSalir.TabIndex = 129
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.White
        Me.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGuardar.FlatAppearance.BorderSize = 3
        Me.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(199, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Location = New System.Drawing.Point(312, 388)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(100, 34)
        Me.btnGuardar.TabIndex = 128
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'txtImpEstadia
        '
        Me.txtImpEstadia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpEstadia.Location = New System.Drawing.Point(438, 141)
        Me.txtImpEstadia.Name = "txtImpEstadia"
        Me.txtImpEstadia.Size = New System.Drawing.Size(112, 26)
        Me.txtImpEstadia.TabIndex = 127
        '
        'txtImpDia
        '
        Me.txtImpDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImpDia.Location = New System.Drawing.Point(143, 141)
        Me.txtImpDia.Name = "txtImpDia"
        Me.txtImpDia.Size = New System.Drawing.Size(112, 26)
        Me.txtImpDia.TabIndex = 126
        '
        'txtCantDia
        '
        Me.txtCantDia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantDia.Location = New System.Drawing.Point(438, 100)
        Me.txtCantDia.Name = "txtCantDia"
        Me.txtCantDia.Size = New System.Drawing.Size(111, 26)
        Me.txtCantDia.TabIndex = 125
        '
        'txtCantPer
        '
        Me.txtCantPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantPer.Location = New System.Drawing.Point(143, 100)
        Me.txtCantPer.Name = "txtCantPer"
        Me.txtCantPer.Size = New System.Drawing.Size(112, 26)
        Me.txtCantPer.TabIndex = 124
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(363, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 20)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Subtotal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(334, 100)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 20)
        Me.Label8.TabIndex = 122
        Me.Label8.Text = "Cant de dias"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(372, 56)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(60, 20)
        Me.Label7.TabIndex = 121
        Me.Label7.Text = "Egreso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "Importe por Dia"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(84, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 20)
        Me.Label5.TabIndex = 119
        Me.Label5.Text = "Cliente"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 118
        Me.Label3.Text = "Cant. Personas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(79, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 20)
        Me.Label2.TabIndex = 117
        Me.Label2.Text = "Ingreso"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 116
        Me.Label1.Text = "Fecha"
        '
        'btnServicios
        '
        Me.btnServicios.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnServicios.Location = New System.Drawing.Point(331, 336)
        Me.btnServicios.Name = "btnServicios"
        Me.btnServicios.Size = New System.Drawing.Size(75, 23)
        Me.btnServicios.TabIndex = 163
        Me.btnServicios.Text = "Servicios"
        Me.btnServicios.UseVisualStyleBackColor = False
        '
        'detReserva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(898, 439)
        Me.Controls.Add(Me.btnServicios)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtTotal)
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
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtTotal As System.Windows.Forms.TextBox
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
    Friend WithEvents btnServicios As System.Windows.Forms.Button
End Class
