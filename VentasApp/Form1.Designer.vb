<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnBuscarRegistros = New System.Windows.Forms.Button()
        Me.btnEstadisticasMontos = New System.Windows.Forms.Button()
        Me.btnUnionTablas = New System.Windows.Forms.Button()
        Me.btnListadoCiudad = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMes = New System.Windows.Forms.TextBox()
        Me.txtVehiculo = New System.Windows.Forms.TextBox()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBuscarRegistros
        '
        Me.btnBuscarRegistros.Location = New System.Drawing.Point(12, 12)
        Me.btnBuscarRegistros.Name = "btnBuscarRegistros"
        Me.btnBuscarRegistros.Size = New System.Drawing.Size(120, 23)
        Me.btnBuscarRegistros.TabIndex = 0
        Me.btnBuscarRegistros.Text = "Buscar Registros"
        Me.btnBuscarRegistros.UseVisualStyleBackColor = True
        '
        'btnEstadisticasMontos
        '
        Me.btnEstadisticasMontos.Location = New System.Drawing.Point(138, 12)
        Me.btnEstadisticasMontos.Name = "btnEstadisticasMontos"
        Me.btnEstadisticasMontos.Size = New System.Drawing.Size(120, 23)
        Me.btnEstadisticasMontos.TabIndex = 1
        Me.btnEstadisticasMontos.Text = "Estadísticas Montos"
        Me.btnEstadisticasMontos.UseVisualStyleBackColor = True
        '
        'btnUnionTablas
        '
        Me.btnUnionTablas.Location = New System.Drawing.Point(264, 12)
        Me.btnUnionTablas.Name = "btnUnionTablas"
        Me.btnUnionTablas.Size = New System.Drawing.Size(120, 23)
        Me.btnUnionTablas.TabIndex = 2
        Me.btnUnionTablas.Text = "Unión Tablas"
        Me.btnUnionTablas.UseVisualStyleBackColor = True
        '
        'btnListadoCiudad
        '
        Me.btnListadoCiudad.Location = New System.Drawing.Point(390, 12)
        Me.btnListadoCiudad.Name = "btnListadoCiudad"
        Me.btnListadoCiudad.Size = New System.Drawing.Size(120, 23)
        Me.btnListadoCiudad.TabIndex = 3
        Me.btnListadoCiudad.Text = "Listado por Ciudad"
        Me.btnListadoCiudad.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 80)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(760, 358)
        Me.DataGridView1.TabIndex = 4
        '
        'txtMes
        '
        Me.txtMes.Location = New System.Drawing.Point(50, 41)
        Me.txtMes.Name = "txtMes"
        Me.txtMes.Size = New System.Drawing.Size(100, 20)
        Me.txtMes.TabIndex = 5
        '
        'txtVehiculo
        '
        Me.txtVehiculo.Location = New System.Drawing.Point(210, 41)
        Me.txtVehiculo.Name = "txtVehiculo"
        Me.txtVehiculo.Size = New System.Drawing.Size(100, 20)
        Me.txtVehiculo.TabIndex = 6
        '
        'txtCiudad
        '
        Me.txtCiudad.Location = New System.Drawing.Point(370, 41)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(100, 20)
        Me.txtCiudad.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Vehículo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(316, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Ciudad:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 450)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.txtVehiculo)
        Me.Controls.Add(Me.txtMes)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnListadoCiudad)
        Me.Controls.Add(Me.btnUnionTablas)
        Me.Controls.Add(Me.btnEstadisticasMontos)
        Me.Controls.Add(Me.btnBuscarRegistros)
        Me.Name = "Form1"
        Me.Text = "Sistema de Ventas"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBuscarRegistros As Button
    Friend WithEvents btnEstadisticasMontos As Button
    Friend WithEvents btnUnionTablas As Button
    Friend WithEvents btnListadoCiudad As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtMes As TextBox
    Friend WithEvents txtVehiculo As TextBox
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
