Public Class EstadoFactura
    Dim _idEstadoFactura As Integer
    Dim _estado As String

    Public Sub New()

    End Sub

    Public Sub New(idEstadoFactura As Integer, estado As String)
        _idEstadoFactura = idEstadoFactura
        _estado = estado
    End Sub

    Public Property IdEstadoFactura As Integer
        Get
            Return _idEstadoFactura
        End Get
        Set(value As Integer)
            _idEstadoFactura = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property
End Class
