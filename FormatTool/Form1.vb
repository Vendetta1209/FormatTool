Imports System.Text.RegularExpressions
Imports System.Console

Public Class Form1
    Dim valueLeft As String
    Dim valueRight As String
    Dim valueOriginal As String
    Dim valueResult As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles executeEncoding.Click
        valueLeft = initialText.Text
        valueRight = endText.Text
        valueOriginal = textOriginal.Text


        'valueResult = textOriginal.Text.Replace("\n", endText.Text & "\n" & initialText.Text)
        valueResult = Regex.Replace(valueOriginal, "\n", valueRight & vbCrLf & valueLeft)
        valueResult = Regex.Replace(valueResult, "^", valueLeft)
        valueResult = Regex.Replace(valueResult, "$", valueRight)
        ResultText.Text = valueResult
    End Sub


    Private Sub copyText_Click(sender As Object, e As EventArgs) Handles copyText.Click
        Clipboard.SetText(ResultText.Text)
    End Sub

End Class
