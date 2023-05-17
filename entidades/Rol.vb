Public Class Rol

    'Atributos de la clase'
    Dim _idRol As Integer
    Dim _nombre As String
    Dim _descripcion As String
    Dim _estado As Boolean


    'Constructor vacio'
    Public Sub New()
    End Sub


    'Constructor con parametros'
    Public Sub New(idRol As Integer, nombre As String, descripcion As String, estado As Boolean)
        _idRol = idRol
        _nombre = nombre
        _descripcion = descripcion
        _estado = estado
    End Sub


    'Propiedades'
    'Getters y Setters'
    Public Property IdRol As Integer
        Get
            Return _idRol
        End Get
        Set(value As Integer)
            _idRol = value
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
