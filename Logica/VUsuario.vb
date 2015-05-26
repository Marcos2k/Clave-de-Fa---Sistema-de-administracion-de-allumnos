Public Class VUsuario

    Dim ID_Usuario As Integer
    Dim Usuario As String
    Dim Contraseña As String
    Dim Nombre As String
    Dim Apellido As String
    Dim Dni As String
    Dim Domicilio As String
    Dim Telefono As String
    Dim Sueldo As String
    Dim Acceso As String

    Public Property GID_Usuario
        Get
            Return ID_Usuario
        End Get
        Set(value)
            ID_Usuario = value
        End Set
    End Property

    Public Property GUsuario
        Get
            Return Usuario
        End Get
        Set(value)
            Usuario = value
        End Set
    End Property

    Public Property GContraseña
        Get
            Return Contraseña
        End Get
        Set(value)
            Contraseña = value
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

    Public Property GSueldo
        Get
            Return Sueldo
        End Get
        Set(value)
            Sueldo = value
        End Set
    End Property

    Public Property GAcceso
        Get
            Return Acceso
        End Get
        Set(value)
            Acceso = value
        End Set
    End Property

    Public Sub New()
        'contructor en blanco
    End Sub

    Public Sub New(ByVal ID_Usuario As Integer, Usuario As String, Contraseña As String, Nombre As String, Apellido As String, Dni As String, Domicilio As String, Telefono As String, Sueldo As String, Acceso As String)
        'Asiganamos los objetos
        GID_Usuario = ID_Usuario
        GUsuario = Usuario
        GContraseña = Contraseña
        GNombre = Nombre
        GApellido = Apellido
        GDni = Dni
        GDomicilio = Domicilio
        GTelefono = Telefono
        GSueldo = Sueldo
        GAcceso = Acceso
    End Sub
End Class
