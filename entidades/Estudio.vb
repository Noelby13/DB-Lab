Public Class Estudio

    'Atributos de la clase'
    Dim _idEstudio As Integer
    Dim _nombreEstudio As String
    Dim _valorInferior As Double
    Dim _valorSuperior As Double
    Dim _valorTexto As String
    Dim _estado As Boolean
    Dim _idUnidad As Integer

    'Constructor vacio'
    Public Sub New()

    End Sub

    'Constructor con parametros'
    Public Sub New(idEstudio As Integer, nombreEstudio As String, valorInferior As Double, valorSuperior As Double, valorTexto As String, estado As Boolean, idUnidad As Integer)
        _idEstudio = idEstudio
        _nombreEstudio = nombreEstudio
        _valorInferior = valorInferior
        _valorSuperior = valorSuperior
        _valorTexto = valorTexto
        _estado = estado
        _idUnidad = idUnidad
    End Sub

    'Propiedades'
    'Getter y Setter'
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

    Public Property ValorInferior As Double
        Get
            Return _valorInferior
        End Get
        Set(value As Double)
            _valorInferior = value
        End Set
    End Property

    Public Property ValorSuperior As Double
        Get
            Return _valorSuperior
        End Get
        Set(value As Double)
            _valorSuperior = value
        End Set
    End Property

    Public Property ValorTexto As String
        Get
            Return _valorTexto
        End Get
        Set(value As String)
            _valorTexto = value
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

    Public Property IdUnidad As Integer
        Get
            Return _idUnidad
        End Get
        Set(value As Integer)
            _idUnidad = value
        End Set
    End Property


End Class
