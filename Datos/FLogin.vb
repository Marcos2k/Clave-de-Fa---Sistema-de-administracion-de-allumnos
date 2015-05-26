Imports System.Data.SqlClient
Public Class FLogin
    Inherits Conexion
    Dim Comando As New SqlCommand
    Public Function Validar_usuarios(ByVal Dato As VUsuario)
            Conectar()
            Comando = New SqlCommand("Validar_usuarios")
            Comando.CommandType = CommandType.StoredProcedure
            Comando.Connection = Conector

            Comando.Parameters.AddWithValue("@Usuario", Dato.GUsuario)
            Comando.Parameters.AddWithValue("@Contraseña", Dato.GContraseña)
            Comando.Parameters.AddWithValue("@Acceso", Dato.GAcceso)

            Dim DR As SqlDataReader

            Try
                DR = Comando.ExecuteReader

                If DR.HasRows Then
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
