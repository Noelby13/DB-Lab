Public Class Cliente
    'Atributos de la clase'
    Dim _idCliente As Integer
    Dim _primerNombre As String
    Dim _segundoNombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String
    Dim _sexo As Boolean 'True = Masculino, False = Femenino
    Dim _fechaNacimiento As DateTime
    Dim _telefono As String
    Dim _correo As String
    Dim _direccion As String
    Dim _cedula As String
    Dim _estado As Boolean

    'Constructor vacio'
    Public Sub New()

    End Sub

    'Constructor con parametros'
    Public Sub New(idCliente As String, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, sexo As Boolean, fechaNacimiento As DateTime, telefono As String, correo As String, direccion As String, cedula As String, estado As Boolean)
        _idCliente = idCliente
        _primerNombre = primerNombre
        _segundoNombre = segundoNombre
        _primerApellido = primerApellido
        _segundoApellido = segundoApellido
        _sexo = sexo
        _fechaNacimiento = fechaNacimiento
        _telefono = telefono
        _correo = correo
        _direccion = direccion
        _cedula = cedula
        _estado = estado
    End Sub

    'Propiedades'
    'Getter y Setter'
    Public Property IdCliente As Integer
        Get
            Return _idCliente
        End Get
        Set(value As Integer)
            _idCliente = value
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

    Public Property Sexo As Boolean
        Get
            Return _sexo
        End Get
        Set(value As Boolean)
            _sexo = value
        End Set
    End Property

    Public Property FechaNacimiento As DateTime
        Get
            Return _fechaNacimiento
        End Get
        Set(value As DateTime)
            _fechaNacimiento = value
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

    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
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

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property

End Class
