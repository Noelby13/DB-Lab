Public Class Resultado

    Dim _idResultado As Integer
    Dim _resultadoNumerico As Double
    Dim _resultadoTexto As String
    Dim _idFactura As Integer
    Dim _idEstudio As Integer

    Public Sub New()

    End Sub

    Public Sub New(idResultado As Integer, resultadoNumerico As Double, resultadoTexto As String, idFactura As Integer, idEstudio As Integer)
        _idResultado = idResultado
        _resultadoNumerico = resultadoNumerico
        _resultadoTexto = resultadoTexto
        _idFactura = idFactura
        _idEstudio = idEstudio
    End Sub

    Public Property IdResultado As Integer
        Get
            Return _idResultado
        End Get
        Set(value As Integer)
            _idResultado = value
        End Set
    End Property

    Public Property ResultadoNumerico As Double
        Get
            Return _resultadoNumerico
        End Get
        Set(value As Double)
            _resultadoNumerico = value
        End Set
    End Property

    Public Property ResultadoTexto As String
        Get
            Return _resultadoTexto
        End Get
        Set(value As String)
            _resultadoTexto = value
        End Set
    End Property

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property IdEstudio As Integer
        Get
            Return _idEstudio
        End Get
        Set(value As Integer)
            _idEstudio = value
        End Set
    End Property

End Class
