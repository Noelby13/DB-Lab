Public Class Funcion

    'Atributos de la clase'
    Dim _idFuncion As Integer
    Dim _nombreFuncion As String


    'Constructor vacio'
    Public Sub New()

    End Sub


    'Constructor con parametros'
    Public Sub New(idFuncion As Integer, nombreFuncion As String)
        _idFuncion = idFuncion
        _nombreFuncion = nombreFuncion
    End Sub


    'Propiedades'
    'Getters y Setters'
    Public Property IdFuncion As Integer
        Get
            Return _idFuncion
        End Get
        Set(value As Integer)
            _idFuncion = value
        End Set
    End Property

End Class
