Public Class Estudio
    Dim _idEstudio As Integer
    Dim _nombreEstudio As String
    Dim _valorInferiorH As Decimal
    Dim _valorSuperiorH As Decimal
    Dim _valorTextoH As String
    Dim _valorInferiorM As Decimal
    Dim _valorSuperiorM As Decimal
    Dim _valorTextoM As String
    Dim _estado As Integer
    Dim _idUnidad As Integer

    Public Sub New()

    End Sub

    Public Sub New(idEstudio As Integer, nombreEstudio As String, valorInferiorH As Decimal, valorSuperiorH As Decimal, valorTextoH As String, valorInferiorM As Decimal, valorSuperiorM As Decimal, valorTextoM As String, estado As Integer, idUnidad As Integer)
        _idEstudio = idEstudio
        _nombreEstudio = nombreEstudio
        _valorInferiorH = valorInferiorH
        _valorSuperiorH = valorSuperiorH
        _valorTextoH = valorTextoH
        _valorInferiorM = valorInferiorM
        _valorSuperiorM = valorSuperiorM
        _valorTextoM = valorTextoM
        _estado = estado
        _idUnidad = idUnidad
    End Sub

    Public Property IdEstudio As Integer
        Get
            Return _idEstudio
        End Get
        Set(value As Integer)
            _idEstudio = value
        End Set
    End Property

    Public Property NombreEstudio As String
        Get
            Return _nombreEstudio
        End Get
        Set(value As String)
            _nombreEstudio = value
        End Set
    End Property

    Public Property ValorInferiorH As Decimal
        Get
            Return _valorInferiorH
        End Get
        Set(value As Decimal)
            _valorInferiorH = value
        End Set
    End Property

    Public Property ValorSuperiorH As Decimal
        Get
            Return _valorSuperiorH
        End Get
        Set(value As Decimal)
            _valorSuperiorH = value
        End Set
    End Property

    Public Property ValorTextoH As String
        Get
            Return _valorTextoH
        End Get
        Set(value As String)
            _valorTextoH = value
        End Set
    End Property

    Public Property ValorInferiorM As Decimal
        Get
            Return _valorInferiorM
        End Get
        Set(value As Decimal)
            _valorInferiorM = value
        End Set
    End Property

    Public Property ValorSuperiorM As Decimal
        Get
            Return _valorSuperiorM
        End Get
        Set(value As Decimal)
            _valorSuperiorM = value
        End Set
    End Property

    Public Property ValorTextoM As String
        Get
            Return _valorTextoM
        End Get
        Set(value As String)
            _valorTextoM = value
        End Set
    End Property

    Public Property Estado As Integer
        Get
            Return _estado
        End Get
        Set(value As Integer)
            _estado = value
        End Set
    End Property

    Public Property IdUnidad As Integer
        Get
            Return _idUnidad
        End Get
        Set(value As Integer)
            _idUnidad = value
        End Set
    End Property
End Class
