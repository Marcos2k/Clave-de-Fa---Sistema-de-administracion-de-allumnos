Public Class VDetalle

    Dim ID_Detalle As Integer
    Dim ID_Pago As Integer
    Dim ID_Clase As Integer

    Public Property GID_Detalle As Integer
        Get
            Return ID_Detalle
        End Get
        Set(value As Integer)
            ID_Detalle = value
        End Set
    End Property

    Public Property GID_Pago As Integer
        Get
            Return ID_Pago
        End Get
        Set(value As Integer)
            ID_Pago = value
        End Set
    End Property

    Public Property GID_Clase As Integer
        Get
            Return ID_Clase
        End Get
        Set(value As Integer)
            ID_Clase = value
        End Set
    End Property

    Public Sub New()
        'Constructor en blanco 
    End Sub

    Public Sub New(ID_Detalle As Integer, ID_Pago As Integer, ID_Clase As Integer)
        GID_Detalle = ID_Detalle
        GID_Pago = ID_Pago
        GID_Clase = ID_Clase
    End Sub
End Class
