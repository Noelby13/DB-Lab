Public Class Factura
    Dim _idFactura As Integer
    Dim _total As Decimal
    Dim _fechaEmision As DateTime
    Dim _idPaciente As Integer
    Dim _idUsuario As Integer
    Dim _idMetodoPago As Integer
    Dim _idDoctor As Integer

    Public Sub New()

    End Sub

    Public Sub New(idFactura As Integer, total As Decimal, fechaEmision As DateTime, idPaciente As Integer, idUsuario As Integer, idMetodoPago As Integer, idDoctor As Integer)
        _idFactura = idFactura
        _total = total
        _fechaEmision = fechaEmision
        _idPaciente = idPaciente
        _idUsuario = idUsuario
        _idMetodoPago = idMetodoPago
        _idDoctor = idDoctor
    End Sub

    Public Property IdFactura As Integer
        Get
            Return _idFactura
        End Get
        Set(value As Integer)
            _idFactura = value
        End Set
    End Property

    Public Property Total As Decimal
        Get
            Return _total
        End Get
        Set(value As Decimal)
            _total = value
        End Set
    End Property

    Public Property FechaEmision As DateTime
        Get
            Return _fechaEmision
        End Get
        Set(value As Date)
            _fechaEmision = value
        End Set
    End Property

    Public Property IdPaciente As Integer
        Get
            Return _idPaciente
        End Get
        Set(value As Integer)
            _idPaciente = value
        End Set
    End Property

    Public Property IdUsuario As Integer
        Get
            Return _idUsuario
        End Get
        Set(value As Integer)
            _idUsuario = value
        End Set
    End Property

    Public Property IdMetodoPago As Integer
        Get
            Return _idMetodoPago
        End Get
        Set(value As Integer)
            _idMetodoPago = value
        End Set
    End Property

    Public Property IdDoctor As Integer
        Get
            Return _idDoctor
        End Get
        Set(value As Integer)
            _idDoctor = value
        End Set
    End Property
End Class
