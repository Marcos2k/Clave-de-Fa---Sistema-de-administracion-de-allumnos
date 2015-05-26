Public Class VClases

    Dim ID_Clase As Integer
    Dim ID_Profesor As Integer
    Dim ID_Alumno As Integer
    Dim Fecha As Date

    Public Property GID_Clase As Integer
        Get
            Return ID_Clase
        End Get
        Set(value As Integer)
            ID_Clase = value
        End Set
    End Property

    Public Property GID_Profesor As Integer
        Get
            Return ID_Profesor
        End Get
        Set(value As Integer)
            ID_Profesor = value
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

    Public Sub New()
        'Constructor en blanco 
    End Sub

    Public Sub New(ID_Clase As Integer, ID_Profesor As Integer, ID_Alumno As Integer, Fecha As Date)
        GID_Clase = ID_Clase
        GID_Profesor = ID_Profesor
        GID_Alumno = ID_Alumno
        GFecha = Fecha
    End Sub
End Class
