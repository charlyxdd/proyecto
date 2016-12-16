Public Class Proyectos
    Private Cliente As Integer
    Private Codigo As Integer
    Private CostoFinal As Integer
    Private CostoEstimado As Integer
    Private Estado As Integer
    Private Nombre As String
    Private Usuario As Integer

    Public Sub New(ByVal Cliente As Integer, ByVal Codigo As Integer, ByVal CostoFinal As Integer, ByVal CostoEstimado As Integer, ByVal Estado As Integer, ByVal Nombre As String, ByVal Usuario As Integer)
        Me.Cliente = Cliente
        Me.Codigo = Codigo
        Me.CostoFinal = CostoFinal
        Me.CostoEstimado = CostoEstimado
        Me.Estado = Estado
        Me.Nombre = Nombre
        Me.Usuario = Usuario
    End Sub
    Public Sub New(ByVal Cliente As Integer, ByVal CostoFinal As Integer, ByVal CostoEstimado As Integer, ByVal Estado As Integer, ByVal Nombre As String, ByVal Usuario As Integer)
        Me.Cliente = Cliente
        Me.CostoFinal = CostoFinal
        Me.CostoEstimado = CostoEstimado
        Me.Estado = Estado
        Me.Nombre = Nombre
        Me.Usuario = Usuario
    End Sub
    Public Sub New(ByVal Cliente As Integer, ByVal CostoEstimado As Integer, ByVal Estado As Integer, ByVal Nombre As String, ByVal Usuario As Integer)
        Me.Cliente = Cliente
        Me.CostoEstimado = CostoEstimado
        Me.Estado = Estado
        Me.Nombre = Nombre
        Me.Usuario = Usuario
    End Sub
End Class
