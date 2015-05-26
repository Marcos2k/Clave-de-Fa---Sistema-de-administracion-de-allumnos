Public Class VPago
    Dim ID_Pago As Integer
    Dim ID_Alumno As Integer
    Dim Fecha As Date
    Dim Monto As Decimal
    'Metodo para asignar propiedades a nuestros objetos
    Public Property GID_Pago As Integer
        Get
            Return ID_Pago
        End Get
        Set(value As Integer)
            ID_Pago = value
        End Set
    End Property

    Public Property GID_Alumno As Integer
        Get
            Return ID_Alumno
        End Get
        Set(value As Integer)
            ID_Alumno = value
        End Set
    End Property

    Public Property GFecha As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property

    Public Property GMonto As Decimal
        Get
            Return Monto
        End Get
        Set(value As Decimal)
            Monto = value
        End Set
    End Property

    Public Sub New()
        'Constructor en blanco
    End Sub

    Public Sub New(ID_Pago As Integer, ID_Alumno As Integer, Fecha As Date, Monto As Decimal)
        'Asiganamos los valores a los objetos 
        GID_Pago = ID_Pago
        GID_Alumno = ID_Alumno
        GFecha = Fecha
        GMonto = Monto
    End Sub
End Class
