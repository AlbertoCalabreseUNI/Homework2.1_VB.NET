Public Class Form1
    Private random As Random
    Private timer As Timer
    Public Property mean As Double
    Public Property n As Integer

    Public Sub New()
        InitializeComponent()
        random = New Random()
        timer = New Timer()

        timer.Enabled = True
        AddHandler timer.Tick, AddressOf Timer1_Tick

        timer.Interval = 400
        timer.Stop()

        mean = 0
        n = 0

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        timer.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        timer.Stop()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim generatedValue As Integer = random.[Next](18, 31)
        updateMean(generatedValue)
        Me.TextBox1.AppendText("Generated Number: " & generatedValue)
        Me.TextBox1.AppendText(Environment.NewLine)
        Me.TextBox1.AppendText("New mean = " & mean.ToString())
        Me.TextBox1.AppendText(Environment.NewLine)
    End Sub

    Private Sub updateMean(ByVal nextNumber As Integer)
        n += 1
        mean = mean + ((1D / n) * (nextNumber - mean))
    End Sub
End Class
