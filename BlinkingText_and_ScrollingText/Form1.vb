Public Class Form1

    Public MessageRL, MessageLR As String
    Const mMessage As String = "Hello world. This is my first program."

    Dim x As String = Chr(36) & Chr(126) & Chr(96)
    Dim y As String = StrReverse(x)

    Private mRadioButton() As RadioButton

    Private mSpeed As Integer = 150
    Private mBlink As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mRadioButton = {sp50, sp100, sp150, sp200, sp250}
        For i As Integer = 0 To mRadioButton.Length - 1
            AddHandler mRadioButton(i).CheckedChanged, AddressOf RadioButton_checkedchanged

        Next
        lbScrollingTextRL.Visible = False
        lbScrollingTextLR.Visible = False

    End Sub

    Private Sub RadioButton_checkedchanged(sender As Object, e As EventArgs)

    End Sub
End Class
