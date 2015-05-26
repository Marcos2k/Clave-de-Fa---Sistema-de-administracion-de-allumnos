Public Class VAlumnos
    Dim ID_Alumno As Integer
    Dim Nombre As String
    Dim Apellido As String
    Dim Dni As String
    Dim Domicilio As String
    Dim Telefono As String
    Dim Instrumento_clase As String
    Dim Observaciones As String
    Dim Saldo As String
    Dim Estado As String
    'metodos Setter And Getter

    Public Property GID_Alumno
        Get
            Return ID_Alumno
        End Get
        Set(value)
            ID_Alumno = value
        End Set
    End Property

    Public Property GNombre
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value
        End Set
    End Property

    Public Property GApellido
        Get
            Return Apellido
        End Get
        Set(value)
            Apellido = value
        End Set
    End Property

    Public Property GDni
        Get
            Return Dni
        End Get
        Set(value)
            Dni = value
        End Set
    End Property

    Public Property GDomicilio
        Get
            Return Domicilio
        End Get
        Set(value)
            Domicilio = value
        End Set
    End Property

    Public Property GTelefono
        Get
            Return Telefono
        End Get
        Set(value)
            Telefono = value
        End Set
    End Property

    Public Property GInstrumento_clase
        Get
            Return Instrumento_clase
        End Get
        Set(value)
            Instrumento_clase = value
        End Set
    End Property

    Public Property GObservaciones
        Get
            Return Observaciones
        End Get
        Set(value)
            Observaciones = value
        End Set
    End Property

    Public Property GSaldo
        Get
            Return Saldo
        End Get
        Set(value)
            Saldo = value
        End Set
    End Property

    Public Property GEstado
        Get
            Return Estado
        End Get
        Set(value)
            Estado = value
        End Set
    End Property
    Public Sub New() 'dejamos constructor en blanco 

    End Sub

    Public Sub New(ByVal ID_Alumno As Integer, Nombre As String, Apellido As String, Dni As String, Telefono As String, Domicilio As String, Instrumento_clase As String, Observaciones As String, Saldo As String, Estado As String)
        'Asiganmos los objetos
        GID_Alumno = ID_Alumno
        GNombre = Nombre
        GApellido = Apellido
        GDni = Dni
        GDomicilio = Domicilio
        GTelefono = Telefono
        GInstrumento_clase = Instrumento_clase
        GObservaciones = Observaciones
        GSaldo = Saldo
        GEstado = Estado
    End Sub
End Class
