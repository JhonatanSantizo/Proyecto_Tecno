Public Class Form1
    Private Sub TablaLoginBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TablaLoginBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TablaLoginBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.LoginCrudDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginCrudDataSet.TablaLogin' table. You can move, or remove it, as needed.
        Me.TablaLoginTableAdapter.Fill(Me.LoginCrudDataSet.TablaLogin)
        IdTextBox.Text = ""
        ContraseñaTextBox.Text = ""
        RollTextBox.Text = ""

    End Sub

    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Dim fn = frmAdministrador
        If Me.TablaLoginTableAdapter.Login(Me.LoginCrudDataSet.TablaLogin, IdTextBox.Text, ContraseñaTextBox.Text, RollTextBox.Text) Then
            If RollTextBox.Text = "Administrador" Then
                Dim strCadena As String = IdTextBox.Text
                Dim frmAdministrador As New frmAdministrador(strCadena)
                frmAdministrador.Show()
                Me.Hide()
            End If
            If RollTextBox.Text = "Secretario" Then
                Dim strCadena As String = IdTextBox.Text
                Dim frmSecretario As New frmAdministrador(strCadena)
                frmAdministrador.Show()
                Me.Hide()
                fn.btn_eliminar.Visible = False
                fn.btn_actualizar.Visible = False
            End If
            If RollTextBox.Text = "Usuario" Then
                Dim strCadena As String = IdTextBox.Text
                Dim frmUsuario As New frmAdministrador(strCadena)
                frmAdministrador.Show()
                Me.Hide()
                fn.btn_actualizar.Visible = False
                fn.btn_eliminar.Visible = False
                fn.btn_insertar.Visible = False
            End If
        Else
            MsgBox("Id, contraseña o roll equivocado")
        End If
    End Sub
End Class
