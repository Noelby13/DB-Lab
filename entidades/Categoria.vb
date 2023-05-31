Public Class Categoria
    'Atributos de la clase'
    Dim _idCategoria As Integer
    Dim _nombre As String
    Dim _descripcion As String
    Dim _estado As Boolean

    Public Sub New()

    End Sub

    Public Sub New(idCategoria As Integer, nombre As String, descripcion As String, estado As Boolean)
        Me.IdCategoria = idCategoria
        Me.Nombre = nombre
        Me.Descripcion = descripcion
        Me.Estado = estado
    End Sub

    Public Property IdCategoria As Integer
        Get
            Return _idCategoria
        End Get
        Set(value As Integer)
            _idCategoria = value
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
