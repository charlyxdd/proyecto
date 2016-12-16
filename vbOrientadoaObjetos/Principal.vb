Imports System.Windows.Forms
Imports System.IO
Imports System.Drawing.Drawing2D
Imports DevComponents.DotNetBar

Public Class Principal 'Hola
    Dim WithEvents ctlMdi As MdiClient = Nothing
    Dim imagen As Image
    Dim col As Color

    Private Sub cmdNuevo_Click(sender As Object, e As EventArgs) Handles cmdNuevo.Click
        activo.Nuevo()
    End Sub

    Private Sub mnuNuevo_Click(sender As Object, e As EventArgs) Handles mnuNuevo.Click
        activo.Nuevo()
    End Sub

    Private Sub mnuEditar_Click(sender As Object, e As EventArgs) Handles mnuEditar.Click
        activo.Editar()
    End Sub

    Private Sub mnuEliminar_Click(sender As Object, e As EventArgs) Handles mnuEliminar.Click
        activo.Eliminar()
    End Sub

    Private Sub mnuBuscar_Click(sender As Object, e As EventArgs) Handles mnuBuscar.Click
        activo.Buscar()
    End Sub

    Private Sub mnuAceptar_Click(sender As Object, e As EventArgs) Handles mnuAceptar.Click
        activo.Aceptar()
    End Sub

    Private Sub mnuCancelar_Click(sender As Object, e As EventArgs) Handles mnuCancelar.Click
        activo.Cancelar()
    End Sub

    Private Sub mnuImprimir_Click(sender As Object, e As EventArgs) Handles mnuImprimir.Click
        activo.Imprimir()
    End Sub

    Private Sub cmdEditar_Click(sender As Object, e As EventArgs) Handles cmdEditar.Click
        activo.Editar()
    End Sub

    Private Sub cmdEliminar_Click(sender As Object, e As EventArgs) Handles cmdEliminar.Click
        activo.Eliminar()
    End Sub

    Private Sub cmdBuscar_Click(sender As Object, e As EventArgs) Handles cmdBuscar.Click
        activo.Buscar()
    End Sub

    Private Sub cmdAceptar_Click(sender As Object, e As EventArgs) Handles cmdAceptar.Click
        activo.Aceptar()
    End Sub

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click
        activo.Cancelar()
    End Sub

    Private Sub cmdImprmir_Click(sender As Object, e As EventArgs) Handles cmdImprmir.Click
        activo.Imprimir()
    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmPrincipal = Me
        Dim frm As New frmLogin
        frm.ShowDialog()
        Me.WindowState = FormWindowState.Maximized
        'verificarPermisos()
        accesosDirectos()
        permisos()
        'barra.Visible = False
    End Sub

    Private Sub barra_click(sender As Object, e As DevComponents.DotNetBar.ClickEventArgs)
        Dim nombre As String = sender.Name
        Dim frm As Form = buscarForm(nombre)

        frm.MdiParent = Me

        frm.Show()
    End Sub

    Private Function buscarForm(nombre As String)
        Try
            Dim frmType As Type = Type.GetType("ZapateriaPuntoVenta." + nombre)
            Dim frm As Form = Activator.CreateInstance(frmType)

            Return frm

        Catch ex As Exception
            MsgBox(ex.Message.ToString)
            Return Nothing
        End Try
    End Function

    'Private Sub verificarPermisos()
    '    Dim cnn As New Conexion(cadConexion)
    '    Dim dt As DataTable = cnn.getConsulta("SELECT * FROM Permisos WHERE Tipo=" & usuario.getNivel & " AND Consulta=0")
    '    If Not IsNothing(dt) Then
    '        For Each row As DataRow In dt.Rows
    '            Dim modulo As DataTable = cnn.getConsulta("SELECT Modulo FROM Modulos WHERE Codigo=" & row.Item("Modulo"))
    '            Select Case modulo.Rows.Item(0).Item("Modulo").ToString.ToLower
    '                Case "Cuentas de Usuarios".ToLower
    '                    mnuSesiones.Enabled = False
    '                    Exit Select
    '                Case "Tipos de cuenta".ToLower
    '                    mnuTipos.Enabled = False
    '                    Exit Select
    '                Case "Proveedores".ToLower
    '                    mnuProveedores.Enabled = False
    '                    Exit Select
    '                Case "Caja".ToLower
    '                    mnuCaja.Enabled = False
    '                    Exit Select
    '                Case "Productos".ToLower
    '                    mnuInsumos.Enabled = False
    '                    Exit Select
    '                Case "Pedidos-Compras".ToLower
    '                    'mnuPedidos.Enabled = False
    '                    Exit Select
    '                Case "Clientes".ToLower
    '                    mnuClientes.Enabled = False
    '                    Exit Select
    '                Case "Empleados".ToLower
    '                    'mnuEmpleados.Enabled = False
    '                    Exit Select
    '            End Select
    '        Next
    '    End If
    'End Sub

    Public Sub accesosDirectos()
        
    End Sub

    Private Sub permisos()
        
    End Sub

    Private Sub _ctlMdiClient_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ctlMdi.Paint
        Call PintarFondo(sender, e)
    End Sub

    Private Sub PintarFondo(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs)
        If Not IsNothing(imagen) Then
            Using gr As Graphics = e.Graphics
                gr.Clear(col)

                Dim x As Single
                Dim y As Single
                Dim ancho As Single
                Dim alto As Single
                Dim entre As Double
                Dim listo As Boolean = False
                ancho = imagen.Width
                alto = imagen.Height
                While Not listo
                    If (imagen.Width <= ctlMdi.Width And imagen.Height <= ctlMdi.Height) Then
                        ancho = imagen.Width
                        alto = imagen.Height
                        listo = True
                    Else
                        If ancho > ctlMdi.Width Then
                            entre = ancho / ctlMdi.Width
                        Else
                            entre = alto / ctlMdi.Height
                        End If
                        ancho = ancho / entre
                        alto = alto / entre

                        If (ancho <= ctlMdi.Width And alto <= ctlMdi.Height) Then
                            listo = True
                        End If
                    End If
                End While
                x = ((ctlMdi.Width / 2) - (ancho / 2))
                y = ((ctlMdi.Height / 2) - (alto / 2))

                gr.DrawImage(imagen, x, y, ancho, alto)
            End Using
        End If
    End Sub

    Private Sub _ctlMdiClient_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles ctlMdi.Resize
        Call PintarFondo(sender, New PaintEventArgs(ctlMdi.CreateGraphics, New Rectangle(ctlMdi.Location, ctlMdi.Size)))
    End Sub

    Private Sub PedidosComprasToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmPedidos
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub mnuInventario_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub mnuEmpleados_Click(sender As Object, e As EventArgs)
        'Dim frm As New frmEmpleados
        'frm.MdiParent = Me
        'frm.Show()
    End Sub

    Private Sub CerrarSesiónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarSesiónToolStripMenuItem.Click
        If MessageBoxEx.Show("¿Está seguro(a) que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cajaAbierta Then
                If MessageBoxEx.Show("La caja está abierta" & vbNewLine & "¿Está seguro que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            usuario = Nothing
            Dim frm As New frmLogin
            frm.Show()
            'Me.Close()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MessageBoxEx.Show("¿Está seguro(a) que desea cerrar la sesión y salir?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If cajaAbierta Then
                If MessageBoxEx.Show("La caja está abierta" & vbNewLine & "¿Está seguro que desea cerrar la sesión?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.No Then
                    Exit Sub
                End If
            End If
            usuario = Nothing

            Me.Close()
        End If
    End Sub

End Class