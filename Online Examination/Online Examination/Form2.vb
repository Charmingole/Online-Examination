Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckBox1.Checked = True
        CheckBox2.Checked = True
        GroupBox1.BackColor = Color.CornflowerBlue

        GroupBox2.BackColor = Color.DarkGray
        CheckBox3.Checked = False
        CheckBox4.Checked = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GroupBox2.BackColor = Color.CornflowerBlue
        CheckBox3.Checked = True
        CheckBox4.Checked = True

        GroupBox1.BackColor = Color.DarkGray
        CheckBox1.Checked = False
        CheckBox2.Checked = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox1.Checked Then
            Form3.Show()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
