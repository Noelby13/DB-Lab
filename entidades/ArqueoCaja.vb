Public Class ArqueoCaja
    Dim _idArqueo As Integer
    Dim _montoInicial As Decimal
    Dim _montoFinal As Decimal
    Dim _fechaApertura As DateTime
    Dim _fechaCierra As DateTime
    Dim _fechaCierre As DateTime
    Dim _estatus As Boolean
    Dim _idUsuario As Boolean

    Public Sub New()

    End Sub

    Public Sub New(idArqueo As Integer, montoInicial As Decimal, montoFinal As Decimal, fechaApertura As Date, fechaCierra As Date, fechaCierre As Date, estatus As Boolean, idUsuario As Boolean)
        _idArqueo = idArqueo
        _montoInicial = montoInicial
        _montoFinal = montoFinal
        _fechaApertura = fechaApertura
        _fechaCierra = fechaCierra
        _fechaCierre = fechaCierre
        _estatus = estatus
        _idUsuario = idUsuario
    End Sub

    Public Property IdArqueo As Integer
        Get
            Return _idArqueo
        End Get
        Set(value As Integer)
            _idArqueo = value
        End Set
    End Property

    Public Property MontoInicial As Decimal
        Get
            Return _montoInicial
        End Get
        Set(value As Decimal)
            _montoInicial = value
        End Set
    End Property

    Public Property MontoFinal As Decimal
        Get
            Return _montoFinal
        End Get
        Set(value As Decimal)
            _montoFinal = value
        End Set
    End Property

    Public Property FechaApertura As Date
        Get
            Return _fechaApertura
        End Get
        Set(value As Date)
            _fechaApertura = value
        End Set
    End Property

    Public Property FechaCierra As Date
        Get
            Return _fechaCierra
        End Get
        Set(value As Date)
            _fechaCierra = value
        End Set
    End Property

    Public Property FechaCierre As Date
        Get
            Return _fechaCierre
        End Get
        Set(value As Date)
            _fechaCierre = value
        End Set
    End Property

    Public Property Estatus As Boolean
        Get
            Return _estatus
        End Get
        Set(value As Boolean)
            _estatus = value
        End Set
    End Property

    Public Property IdUsuario As Boolean
        Get
            Return _idUsuario
        End Get
        Set(value As Boolean)
            _idUsuario = value
        End Set
    End Property
End Class
