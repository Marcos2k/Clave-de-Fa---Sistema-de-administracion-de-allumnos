Imports System.Data.SqlClient
Public Class FAlumno
    Inherits Conexion 'Hereda todo de la clase conexion

    Dim Tabla As New DataTable
    Dim Comando As New SqlCommand

    Public Function MostrarAlumnos()
        Try
            Conectar() 'llama al proceso de la clase "Conexion"
            Comando = New SqlCommand("Mostrar_Alumnos") 'proceso almacenado en la BD SQL Server 
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
    ''' <summary>
    ''' Graba un alumno en la base de datos
    ''' </summary>
    ''' <param name="Dato"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Guardar_Alumnos(ByVal Dato As VAlumnos) As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Agregar_Alumno")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            'Pasamos los parametros 
            Comando.Parameters.AddWithValue("@Nombre", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Apellido", Dato.GApellido)
            Comando.Parameters.AddWithValue("@Dni", Dato.GDni)
            Comando.Parameters.AddWithValue("@Domicilio", Dato.GDomicilio)
            Comando.Parameters.AddWithValue("@Telefono", Dato.GTelefono)
            Comando.Parameters.AddWithValue("@Instrumento_Clase", Dato.GInstrumento_clase)
            Comando.Parameters.AddWithValue("@Observaciones", Dato.GObservaciones)
            Comando.Parameters.AddWithValue("@Saldo", Dato.GSaldo)
            Comando.Parameters.AddWithValue("@Estado", Dato.GEstado)
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

    Public Function Editar_Alumno(ByVal Dato As VAlumnos)
        Try
            Conectar()
            Comando = New SqlCommand("Editar_Alumno")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            'Pasamos los parametros 
            Comando.Parameters.AddWithValue("@ID_Alumno", Dato.GID_Alumno)
            Comando.Parameters.AddWithValue("@Nombre", Dato.GNombre)
            Comando.Parameters.AddWithValue("@Apellido", Dato.GApellido)
            Comando.Parameters.AddWithValue("@Dni", Dato.GDni)
            Comando.Parameters.AddWithValue("@Domicilio", Dato.GDomicilio)
            Comando.Parameters.AddWithValue("@Telefono", Dato.GTelefono)
            Comando.Parameters.AddWithValue("@Instrumento_Clase", Dato.GInstrumento_clase)
            Comando.Parameters.AddWithValue("@Observaciones", Dato.GObservaciones)
            Comando.Parameters.AddWithValue("@Saldo", Dato.GSaldo)
            Comando.Parameters.AddWithValue("@Estado", Dato.GEstado)

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

    Public Function Eliminar_Alumno(ByVal Dato As VAlumnos) As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Eliminar_Alumno")
            Comando.CommandType = CommandType.StoredProcedure 'Indicamos que es un procedimiento almacenado
            Comando.Connection = Conector

            Comando.Parameters.Add("@ID_Alumno", SqlDbType.NVarChar, 50).Value = Dato.GID_Alumno

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
