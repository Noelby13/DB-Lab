Public Class Examen
    Dim _idExamen As Integer
    Dim _Nombre As String
    Dim _descripcion As String
    Dim _precio As Decimal
    Dim _estado As Boolean
    Dim _idCategoria As Integer

    Public Sub New()

    End Sub

    Public Sub New(idExamen As Integer, nombre As String, descripcion As String, precio As Decimal, estado As Boolean, idCategoria As Integer)
        _idExamen = idExamen
        _Nombre = nombre
        _descripcion = descripcion
        _precio = precio
        _estado = estado
        _idCategoria = idCategoria
    End Sub

    Public Property IdExamen As Integer
        Get
            Return _idExamen
        End Get
        Set(value As Integer)
            _idExamen = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Public Property Descripcion As String
        Get
            Return _descripcion
        End Get
        Set(value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Precio As Decimal
        Get
            Return _precio
        End Get
        Set(value As Decimal)
            _precio = value
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

    Public Property IdCategoria As Integer
        Get
            Return _idCategoria
        End Get
        Set(value As Integer)
            _idCategoria = value
        End Set
    End Property
End Class
