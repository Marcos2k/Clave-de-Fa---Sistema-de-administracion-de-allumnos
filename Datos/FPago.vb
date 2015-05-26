Imports System.Data.SqlClient
Public Class FPago

    Inherits Conexion

    Dim Comando As New SqlCommand ' Declaramos un comando que se ejectura desde el SQLSERVER    

    Public Function Mostrar_pago()
        Try
            Conectar()
            Comando = New SqlCommand("Mostrar_pagos")
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

    Public Function Guardar_pago(ByVal Dato As VPago) As Boolean
        Try
            Conectar()
            Comando = New SqlCommand("Guardar_pago")
            Comando.CommandType = CommandType.StoredProcedure 'indicamos que es procedimiento almacenado
            Comando.Connection = Conector 'establecemos la conexion

            Comando.Parameters.AddWithValue("@ID_Alumno", Dato.GID_Alumno)
            Comando.Parameters.AddWithValue("@Fecha", Dato.GFecha)
            Comando.Parameters.AddWithValue("@Monto", Dato.GMonto)

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

    Public Function Editar_pago(ByVal Dato As VPago)
        Try
            Conectar()
            Comando = New SqlCommand("Editar_pago")
            Comando.CommandType = CommandType.StoredProcedure 'indicamos que es procedimiento almacenado
            Comando.Connection = Conector 'establecemos la conexion

            Comando.Parameters.AddWithValue("@ID_Pago", Dato.GID_Pago)
            Comando.Parameters.AddWithValue("@ID_Alumno", Dato.GID_Alumno)
            Comando.Parameters.AddWithValue("@Fecha", Dato.GFecha)
            Comando.Parameters.AddWithValue("@Monto", Dato.GMonto)

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

    Public Function Reporte_del_dia(ByVal Dato As VPago)
        'Muestra todos los cobros realizados en el dia
        Try
            Conectar()
            Comando = New SqlCommand("Reporte_del_dia")
            Comando.CommandType = CommandType.StoredProcedure 'indicamos que es procedimiento almacenado
            Comando.Connection = Conector 'establecemos la conexion

            Comando.Parameters.AddWithValue("@Fecha", Dato.GFecha)

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
End Class
