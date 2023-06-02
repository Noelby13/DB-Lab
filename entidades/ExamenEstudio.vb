Public Class ExamenEstudio
    Dim _idExamenEstudio As Integer
    Dim _idExamen As Integer
    Dim _idEstudio As Integer

    Public Sub New()
    End Sub

    Public Sub New(idExamenEstudio As Integer, idExamen As Integer, idEstudio As Integer)
        _idExamenEstudio = idExamenEstudio
        _idExamen = idExamen
        _idEstudio = idEstudio
    End Sub

    Public Property IdExamenEstudio As Integer
        Get
            Return _idExamenEstudio
        End Get
        Set(value As Integer)
            _idExamenEstudio = value
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

    Public Property IdEstudio As Integer
        Get
            Return _idEstudio
        End Get
        Set(value As Integer)
            _idEstudio = value
        End Set
    End Property




End Class
