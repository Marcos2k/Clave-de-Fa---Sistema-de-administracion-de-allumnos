Imports System.Data.SqlClient 'importamos libreria para usar SQL Server 
Public Class FUsuario
    Inherits Conexion 'Hereda la Clase "Conexion"

    Dim Tabla As New DataTable
    Dim Comando As New SqlCommand


    Public Function MostrarAlumnos()
        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Mostrar_usuarios") 'proceso almacenado en la BD SQL Server 
            Comando.CommandType = CommandType.StoredProcedure 'seleciona procedimiento almacenado
            Comando.Connection = Conector    ' pasa la varible conector igual/similar que en ADO.net 

            If Comando.ExecuteNonQuery Then 'Si el Comando ejecuta la Consulta
                Dim Tabla As New DataTable 'creamos el objeto/variable de la tabla
                Dim Adaptador As New SqlDataAdapter(Comando) 'paso el comando al Adaptador 
                Adaptador.Fill(Tabla) 'Fill = Llenar en Inglés 
                Return Tabla 'Devuelve la tabla llena en caso de ser verdadero 
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar() 'una vez realizada la tarea me desconecto de la BD 
        End Try
    End Function

    Public Function Agregar_usuario(ByRef Dato As VUsuario) As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Agregar_usuario")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Usuario", Dato.GUsuario)
            Comando.Parameters.AddWithValue("@Contraseña", Dato.GContraseña)
            Comando.Parameters.AddWithValue("@Nombre", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Apellido", Dato.GApellido)
            Comando.Parameters.AddWithValue("@Dni", Dato.GDni)
            Comando.Parameters.AddWithValue("@Domicilio", Dato.GDomicilio)
            Comando.Parameters.AddWithValue("@Telefono", Dato.GTelefono)
            Comando.Parameters.AddWithValue("@Sueldo", Dato.GSueldo)
            Comando.Parameters.AddWithValue("@Acceso", Dato.GAcceso)

            If Comando.ExecuteNonQuery Then 'Ejecutamos la consulta
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Editar_usuario(ByVal Dato As VUsuario)
        Try
            Conectar()
            Comando = New SqlCommand("Editar_usuario")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID_Usuario", Dato.GID_Usuario)
            Comando.Parameters.AddWithValue("@Usuario", Dato.GUsuario)
            Comando.Parameters.AddWithValue("@Contraseña", Dato.GContraseña)
            Comando.Parameters.AddWithValue("@Nombre", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Apellido", Dato.GApellido)
            Comando.Parameters.AddWithValue("@Dni", Dato.GDni)
            Comando.Parameters.AddWithValue("@Domicilio", Dato.GDomicilio)
            Comando.Parameters.AddWithValue("@Telefono", Dato.GTelefono)
            Comando.Parameters.AddWithValue("@Sueldo", Dato.GSueldo)
            Comando.Parameters.AddWithValue("@Acceso", Dato.GAcceso)

            If Comando.ExecuteNonQuery Then 'Ejecutamos la consulta
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Eliminar_usuario(ByRef Dato As VUsuario) As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Eliminar_usuario")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.Add("@ID_Usuario", SqlDbType.NVarChar, 50).Value = Dato.GID_Usuario

            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar()
        End Try

    End Function
End Class
