<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.btnReservas = New System.Windows.Forms.ToolStripMenuItem
        Me.MatiasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnClientes = New System.Windows.Forms.ToolStripMenuItem
        Me.btnAdministracion = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.MenuStrip1.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.SandyBrown
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(30, 30)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnReservas, Me.btnClientes, Me.btnAdministracion})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(608, 40)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'btnReservas
        '
        Me.btnReservas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnReservas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MatiasToolStripMenuItem})
        Me.btnReservas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReservas.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReservas.Name = "btnReservas"
        Me.btnReservas.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.btnReservas.Padding = New System.Windows.Forms.Padding(4)
        Me.btnReservas.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
        Me.btnReservas.Size = New System.Drawing.Size(100, 36)
        Me.btnReservas.Text = "Reservas"
        '
        'MatiasToolStripMenuItem
        '
        Me.MatiasToolStripMenuItem.Name = "MatiasToolStripMenuItem"
        Me.MatiasToolStripMenuItem.Size = New System.Drawing.Size(152, 28)
        Me.MatiasToolStripMenuItem.Text = "Matias"
        '
        'btnClientes
        '
        Me.btnClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClientes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Padding = New System.Windows.Forms.Padding(4)
        Me.btnClientes.Size = New System.Drawing.Size(89, 36)
        Me.btnClientes.Text = "Clientes"
        '
        'btnAdministracion
        '
        Me.btnAdministracion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAdministracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdministracion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAdministracion.Name = "btnAdministracion"
        Me.btnAdministracion.Padding = New System.Windows.Forms.Padding(4)
        Me.btnAdministracion.Size = New System.Drawing.Size(146, 36)
        Me.btnAdministracion.Text = "Administracion"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 40)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.MonthCalendar1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel2.Padding = New System.Windows.Forms.Padding(20)
        Me.SplitContainer1.Size = New System.Drawing.Size(608, 385)
        Me.SplitContainer1.SplitterDistance = 153
        Me.SplitContainer1.TabIndex = 3
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(1, 2)
        Me.MonthCalendar1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MonthCalendar1.Location = New System.Drawing.Point(0, 0)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MonthCalendar1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Top
        Me.DataGridView1.Location = New System.Drawing.Point(20, 20)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 192)
        Me.DataGridView1.TabIndex = 0
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 425)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "Inicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents btnReservas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MatiasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAdministracion As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
