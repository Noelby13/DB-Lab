Public Class DetalleFactura

    Dim _idDetalleFactura As Integer
    Dim _cantidad As Integer
    Dim _precioUnitario As Decimal
    Dim _idFactura As Integer
    Dim _idExamen As Integer

    Private Sub New()

    End Sub

    Private Sub New(idDetalleFactura As Integer, cantidad As Integer, precioUnitario As Decimal, idFactura As Integer, idExamen As Integer)
        _idDetalleFactura = idDetalleFactura
        _cantidad = cantidad
        _precioUnitario = precioUnitario
        _idFactura = idFactura
        _idExamen = idExamen
    End Sub

    Public Property IdDetalleFactura As Integer
        Get
            Return _idDetalleFactura
        End Get
        Set(value As Integer)
            _idDetalleFactura = value
        End Set
    End Property

    Public Property Cantidad As Integer
        Get
            Return _cantidad
        End Get
        Set(value As Integer)
            _cantidad = value
        End Set
    End Property

    Public Property PrecioUnitario As Decimal
        Get
            Return _precioUnitario
        End Get
        Set(value As Decimal)
            _precioUnitario = value
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

    Public Property IdExamen As Integer
        Get
            Return _idExamen
        End Get
        Set(value As Integer)
            _idExamen = value
        End Set
    End Property
End Class
