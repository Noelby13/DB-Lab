Public Class Doctor
    'Atributos de la clase'
    Dim _idDoctor As Integer
    Dim _primerNombre As String
    Dim _segundoNombre As String
    Dim _primerApellido As String
    Dim _segundoApellido As String
    Dim _especialidad As String
    Dim _estado As Boolean

    Public Sub New()
    End Sub

    Public Sub New(idDoctor As Integer, primerNombre As String, segundoNombre As String, primerApellido As String, segundoApellido As String, especialidad As String, estado As Boolean)
        _idDoctor = idDoctor
        _primerNombre = primerNombre
        _segundoNombre = segundoNombre
        _primerApellido = primerApellido
        _segundoApellido = segundoApellido
        _especialidad = especialidad
        _estado = estado
    End Sub

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

    Public Property Especialidad As String
        Get
            Return _especialidad
        End Get
        Set(value As String)
            _especialidad = value
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


