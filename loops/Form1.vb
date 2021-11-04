Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 0
        Dim input As Integer
        Dim Sum As Integer = 0
        Dim DataInput As String

        DataInput = InputBox("How many testscores do you want to average?")
        input = CInt(DataInput)

        Do While (i < input)
            DataInput = InputBox("Enter a number.")
            Sum += CInt(DataInput)
            Label2.Text = Sum
            i += 1

        Loop
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub
End Class
