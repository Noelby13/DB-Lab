Public Class Usuario

    'Atributos de la clase'
    Dim _idUsuario As Integer
    Dim _primerNombre As String
    Dim _segundoNombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String
    Dim _username As String
    Dim _telefono As String
    Dim _correo As String
    Dim _fechaIngreso As DateTime
    Dim _cedula As String
    Dim _pwd As String
    Dim _estado As Boolean
    Dim _idRol As Integer


    'Constructor vacio'
    Public Sub New()

    End Sub


    'Constructor con parametros'
    Public Sub New(idUsuario As Integer, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, username As String, telefono As String, correo As String, fechaIngreso As Date, cedula As String, pwd As String, estado As Boolean, idRol As Integer)
        _idUsuario = idUsuario
        _primerNombre = primerNombre
        _segundoNombre = segundoNombre
        _primerApellido = primerApellido
        _segundoApellido = segundoApellido
        _username = username
        _telefono = telefono
        _correo = correo
        _fechaIngreso = fechaIngreso
        _cedula = cedula
        _pwd = pwd
        _estado = estado
        _idRol = idRol
    End Sub


    'Propiedades'
    'Getters y Setters'
    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property PrimerNombre As String
        Get
            Return _primerNombre
        End Get
        Set(value As String)
            _primerNombre = value
        End Set
    End Property

    Public Property SegundoNombre As String
        Get
            Return _segundoNombre
        End Get
        Set(value As String)
            _segundoNombre = value
        End Set
    End Property

    Public Property PrimerApellido As String
        Get
            Return _primerApellido
        End Get
        Set(value As String)
            _primerApellido = value
        End Set
    End Property

    Public Property SegundoApellido As String
        Get
            Return _segundoApellido
        End Get
        Set(value As String)
            _segundoApellido = value
        End Set
    End Property

    Public Property Username As String
        Get
            Return _username
        End Get
        Set(value As String)
            _username = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Correo As String
        Get
            Return _correo
        End Get
        Set(value As String)
            _correo = value
        End Set
    End Property

    Public Property FechaIngreso As Date
        Get
            Return _fechaIngreso
        End Get
        Set(value As Date)
            _fechaIngreso = value
        End Set
    End Property

    Public Property Cedula As String
        Get
            Return _cedula
        End Get
        Set(value As String)
            _cedula = value
        End Set
    End Property

    Public Property Pwd As String
        Get
            Return _pwd
        End Get
        Set(value As String)
            _pwd = value
        End Set
    End Property

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

    Public Property IdRol As Integer
        Get
            Return _idRol
        End Get
        Set(value As Integer)
            _idRol = value
        End Set
    End Property

End Class