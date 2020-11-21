Public Class LoginForm1

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If PasswordTextBox.Text = "1526" Then
            MsgBox("Login successfully !", vbExclamation, "<<<<<<QYL3X>>>>>>")
            End
        Else
            If PasswordTextBox.Text = "crack" Then
                Shell("D:\login-reset\login_reset.bat")
            Else
                MsgBox("This is not the password !", vbCritical, "LOGIN ERROR")

            End If


        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        MsgBox("This is a second security for Laptop or Desktop", vbExclamation, "Security Infos")
    End Sub

End Class
