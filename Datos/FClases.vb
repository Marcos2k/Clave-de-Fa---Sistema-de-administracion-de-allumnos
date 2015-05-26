Imports System.Data.SqlClient
Public Class FClases
    Inherits Conexion

    Dim Comando As New SqlCommand
    Public Function Mostrar_Clases()
        Try
            Conectar()
            Comando = New SqlCommand("Mostrar_clases")
            Comando.CommandType = CommandType.StoredProcedure 'indicamos que es procedimiento almacenado
            Comando.Connection = Conector 'establecemos la conexion

            If Comando.ExecuteNonQuery Then
                Dim Tabla As New DataTable
                Dim Adaptador As New SqlDataAdapter(Comando)
                Adaptador.Fill(Tabla)
                Return Tabla
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            Desconectar()
        End Try
    End Function

    Public Function Guardar_Clase(ByVal Dato As VClases) As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Guardar_clase")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID_Profesor", Dato.GID_Profesor)
            Comando.Parameters.AddWithValue("@ID_Alumno", Dato.GID_Alumno)
            Comando.Parameters.AddWithValue("@Fecha", Dato.GFecha)

            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar() 'me desconecto de la BD 
        End Try
    End Function

    Public Function Editar_Clase(Dato As VClases)
        Try
            Conectar()
            Comando = New SqlCommand("Editar_clase")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@ID_Clase", Dato.GID_Profesor)
            Comando.Parameters.AddWithValue("@ID_Profesor", Dato.GID_Profesor)
            Comando.Parameters.AddWithValue("@ID_Alumno", Dato.GID_Alumno)
            Comando.Parameters.AddWithValue("@Fecha", Dato.GFecha)

            If Comando.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            Desconectar() 'me desconecto de la BD 
        End Try
    End Function

    Public Function Eliminar_clase(Dato As VClases) As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Eliminar_Clase")
            Comando.CommandType = CommandType.StoredProcedure 'Indicamos que es un procedimiento almacenado
            Comando.Connection = Conector

            Comando.Parameters.Add("@ID_Clase", SqlDbType.NVarChar, 50).Value = Dato.GID_Clase

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
