Imports System.Data.SqlClient

Public Class DCliente

    Dim strConexion = My.Settings.miConexion.ToString()

    Public Function obtenerCliente()
        Try
            Dim cliente As New Cliente()
            Dim ds As New DataTable
            Dim conn As New SqlConnection(strConexion)
            Dim tsql As String = "select * from Tbl_Cliente where idPaciente = @idPaciente"
            Dim da As New SqlDataAdapter(tsql, conn)
            da.SelectCommand.Parameters.AddWithValue("@idFactura", cliente.IdCliente)
            da.Fill(ds)
            cliente.IdCliente = ds.Rows(0).Item("idCliente")
            cliente.PrimerNombre = ds.Rows(0).Item("primerNombre")
            cliente.SegundoNombre = ds.Rows(0).Item("segundoNombre")
            cliente.PrimerApellido = ds.Rows(0).Item("primerApellido")
            cliente.SegundoApellido = ds.Rows(0).Item("segundoApellido")
            cliente.Sexo = ds.Rows(0).Item("sexo")
            cliente.FechaNacimiento = ds.Rows(0).Item("fechaNacimiento")
            cliente.Telefono = ds.Rows(0).Item("telefono")
            cliente.Correo = ds.Rows(0).Item("correo")
            cliente.Direccion = ds.Rows(0).Item("direccion")
            cliente.Cedula = ds.Rows(0).Item("cedula")
            cliente.Estado = ds.Rows(0).Item("estado")
            Return cliente
        Catch
            MsgBox("Ocurrio un error al intentar obtener el cliente", MsgBoxStyle.Information, "Cliente")
        End Try
    End Function

End Class
