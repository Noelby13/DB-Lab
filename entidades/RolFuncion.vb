Public Class RolFuncion

    'Atributos de la clase'
    Dim _idRolFuncion As Integer
    Dim _idFuncion As Integer
    Dim _idRol As Integer


    'Constructor Vacio'
    Public Sub New()

    End Sub


    'Constructor con parametros'
    Public Sub New(idRolFuncion As Integer, idFuncion As Integer, idRol As Integer)
        _idRolFuncion = idRolFuncion
        _idFuncion = idFuncion
        _idRol = idRol
    End Sub


    'Propiedades'
    'Getters y Setters'
    Public Property IdRolFuncion As Integer
        Get
            Return _idRolFuncion
        End Get
        Set(value As Integer)
            _idRolFuncion = value
        End Set
    End Property

    Public Property IdFuncion As Integer
        Get
            Return _idFuncion
        End Get
        Set(value As Integer)
            _idFuncion = value
        End Set
    End Property

    Public Property IdRol As Integer
        Get
            Return _idRol
        End Get
        Set(value As Integer)
            _idRol = value
        End Set
    End Property

End Class