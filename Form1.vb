Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox11.Text = (Label1.Text + TextBox1.Text + Label2.Text + Label3.Text + TextBox2.Text + Label4.Text + Label5.Text + TextBox3.Text + Label6.Text + Label7.Text + TextBox4.Text + Label8.Text + Label9.Text + TextBox5.Text + Label10.Text + Label11.Text + TextBox6.Text + Label12.Text + TextBox7.Text + Label13.Text + Label14.Text + Label15.Text + TextBox8.Text + Label16.Text + TextBox9.Text + Label17.Text + TextBox10.Text + Label18.Text)
        My.Computer.Clipboard.SetText(TextBox11.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox11.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub
End Class
