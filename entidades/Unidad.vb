Public Class Unidad
    Dim _idUnidad As Integer
    Dim _nombre As String
    Dim _descripcion As String
    Dim _estado As Boolean

    Public Sub New()

    End Sub
    Public Sub New(idUnidad As Integer, nombre As String, descripcion As String, estado As Boolean)
        _idUnidad = idUnidad
        _nombre = nombre
        _descripcion = descripcion
        _estado = estado
    End Sub

    Public Property IdUnidad As Integer
        Get
            Return _idUnidad
        End Get
        Set(value As Integer)
            _idUnidad = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
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

    Public Property Estado As Boolean
        Get
            Return _estado
        End Get
        Set(value As Boolean)
            _estado = value
        End Set
    End Property
End Class
