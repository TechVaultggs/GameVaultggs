Imports System.Data.SqlClient
Imports System.Configuration

Public Class Form1
    Private connectionString As String

    Public Sub New()
        InitializeComponent()
        ' Leer la cadena de conexión desde App.config
        connectionString = ConfigurationManager.ConnectionStrings("VentasDB").ConnectionString
    End Sub

    Private Function GetData(query As String, Optional params As Dictionary(Of String, Object) = Nothing) As DataTable
        Dim dt As New DataTable()
        Try
            Using conn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand(query, conn)
                    If params IsNot Nothing Then
                        For Each param In params
                            cmd.Parameters.AddWithValue(param.Key, param.Value)
                        Next
                    End If
                    conn.Open()
                    Using adapter As New SqlDataAdapter(cmd)
                        adapter.Fill(dt)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al conectar a la base de datos: " & ex.Message)
        End Try
        Return dt
    End Function

    Private Sub btnBuscarRegistros_Click(sender As Object, e As EventArgs) Handles btnBuscarRegistros.Click
        If String.IsNullOrWhiteSpace(txtMes.Text) OrElse String.IsNullOrWhiteSpace(txtVehiculo.Text) Then
            MessageBox.Show("Por favor, ingrese el mes y el vehículo.")
            Return
        End If

        Dim mes As Integer
        If Not Integer.TryParse(txtMes.Text, mes) Then
            MessageBox.Show("Por favor, ingrese un número válido para el mes.")
            Return
        End If

        Dim query As String = "SELECT * FROM Operacion WHERE mes = @mes AND vehiculo = @vehiculo"
        Dim params As New Dictionary(Of String, Object) From {
            {"@mes", mes},
            {"@vehiculo", txtVehiculo.Text}
        }

        DataGridView1.DataSource = GetData(query, params)
    End Sub

    Private Sub btnEstadisticasMontos_Click(sender As Object, e As EventArgs) Handles btnEstadisticasMontos.Click
        Dim query As String = "SELECT mes, SUM(monto) AS TotalPorMes FROM Operacion GROUP BY mes ORDER BY mes"
        DataGridView1.DataSource = GetData(query)
    End Sub

    Private Sub btnUnionTablas_Click(sender As Object, e As EventArgs) Handles btnUnionTablas.Click
        Dim query As String = "SELECT e.nom_empleado, e.telefono, o.vehiculo, o.monto, o.ano " &
                              "FROM Operacion o " &
                              "JOIN Empleado e ON o.cod_empleado = e.cod_empleado"
        DataGridView1.DataSource = GetData(query)
    End Sub

    Private Sub btnListadoCiudad_Click(sender As Object, e As EventArgs) Handles btnListadoCiudad.Click
        If String.IsNullOrWhiteSpace(txtCiudad.Text) Then
            MessageBox.Show("Por favor, ingrese la ciudad.")
            Return
        End If

        Dim query As String = "SELECT e.nom_empleado AS Vendedor, o.vehiculo, o.mes, o.monto " &
                              "FROM Operacion o " &
                              "JOIN Empleado e ON o.cod_empleado = e.cod_empleado " &
                              "WHERE e.ciudad = @ciudad"
        Dim params As New Dictionary(Of String, Object) From {
            {"@ciudad", txtCiudad.Text}
        }

        DataGridView1.DataSource = GetData(query, params)
    End Sub
End Class
