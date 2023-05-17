Public Class Doctor
    'Atributos de la clase'
    Dim _idDoctor As Integer
    Dim _primerNombre As String
    Dim _segundoNombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String

    'Constructor vacio'
    Public Sub New()

    End Sub

    'Constructor con parametros'
    Public Sub New(idDoctor As Integer, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String)
        _idDoctor = idDoctor
        _primerNombre = primerNombre
        _segundoNombre = segundoNombre
        _primerApellido = primerApellido
        _segundoApellido = segundoApellido
    End Sub

    'Propiedades'
    'Getter y Setter'
    Public Property IdDoctor As Integer
        Get
            Return _idDoctor
        End Get
        Set(value As Integer)
            _idDoctor = value
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

End Class


