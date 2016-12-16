Public Class Usuarios
    Private codigo As Integer
    Private nivel As Integer
    Private nombre As String
    Private pass As String
    Private Activo As Boolean

    Public Sub New(ByVal codigo As Integer, ByVal nivel As Integer, ByVal nombre As String, ByVal pass As String, ByVal Activo As Boolean)
        Me.codigo = codigo
        Me.nivel = nivel
        Me.nombre = nombre
        Me.pass = pass
        Me.Activo = Activo
    End Sub

    Public Sub New(ByVal nivel As Integer, ByVal nombre As String, ByVal pass As String)
        Me.nivel = nivel
        Me.nombre = nombre
        Me.pass = pass
    End Sub

    Public Sub New(ByVal nombre As String, ByVal pass As String)
        Me.nombre = nombre
        Me.pass = pass
    End Sub

    Public Function consultar()

    End Function

    Public Sub eliminar()

    End Sub

    Public Sub guardar()

    End Sub

    Public Function getCodigo()
        Return Me.codigo
    End Function

    Public Function getNivel()
        Return Me.nivel
    End Function

    Public Function getNombre()
        Return Me.nombre
    End Function

    Public Function getPass()
        Return Me.pass
    End Function

    Public Sub setNivel(ByVal nivel As Integer)
        Me.nivel = nivel
    End Sub

    Public Sub setNombre(ByVal nombre As String)
        Me.nombre = nombre
    End Sub

    Public Sub setPass(ByVal pass As String)
        Me.pass = pass
    End Sub

End Class
