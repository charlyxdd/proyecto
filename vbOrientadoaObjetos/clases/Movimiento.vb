Public Class Movimiento
    Private Cantidad As Integer
    Private Codigo As Integer
    Private Fecha As Date
    Private Material As Integer
    Private Proyecto As Integer
    Private Tipo As Integer
    Private Usuario As Integer

    Public Sub New(ByVal Cantidad As Integer, ByVal Codigo As Integer, ByVal Fecha As Date, ByVal Material As Integer, ByVal Proyecto As Integer, ByVal Tipo As Integer, ByVal Usuario As Integer)
        Me.Cantidad = Cantidad
        Me.Codigo = Codigo
        Me.Fecha = Fecha
        Me.Material = Material
        Me.Proyecto = Proyecto
        Me.Tipo = Tipo
        Me.Usuario = Usuario

    End Sub

    Public Sub New(ByVal Cantidad As Integer, ByVal Fecha As Date, ByVal Material As Integer, ByVal Proyecto As Integer, ByVal Tipo As Integer, ByVal Usuario As Integer)
        Me.Cantidad = Cantidad
        Me.Fecha = Fecha
        Me.Material = Material
        Me.Proyecto = Proyecto
        Me.Tipo = Tipo
        Me.Usuario = Usuario

    End Sub

    Public Function consultar()

    End Function

    Public Sub eliminar()

    End Sub

    Public Sub guardar()

    End Sub

    Public Function getCantidad()
        Return Me.Cantidad
    End Function

    Public Function getFecha()
        Return Me.Fecha
    End Function

    Public Function getMaterial()
        Return Me.Material
    End Function

    Public Function getProyecto()
        Return Me.Proyecto
    End Function

    Public Function getTipo()
        Return Me.Tipo
    End Function

    Public Function getUsuario()
        Return Me.Usuario
    End Function

    Public Sub setCantidad(ByVal Cantidad As Integer)
        Me.Cantidad = Cantidad
    End Sub

    Public Sub setFecha(ByVal Fecha As Date)
        Me.Fecha = Fecha
    End Sub

    Public Sub setMaterial(ByVal Material As Integer)
        Me.Material = Material
    End Sub

    Public Sub setProyecto(ByVal Proyecto As Integer)
        Me.Proyecto = Proyecto
    End Sub

    Public Sub setTipo(ByVal Tipo As Integer)
        Me.Tipo = Tipo
    End Sub

    Public Sub setUsuario(ByVal Usuario As Integer)
        Me.Usuario = Usuario
    End Sub


End Class
