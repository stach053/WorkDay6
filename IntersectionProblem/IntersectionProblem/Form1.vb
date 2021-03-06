﻿Option Strict On

Public Class Form1

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim Ast, Bst, Cst, Dst As String
        Dim A, B, C, D As Double

        ' Read the input from the user
        Ast = txtA.Text
        Bst = txtB.Text
        Cst = txtC.Text
        Dst = txtD.Text

        ' All input must be numbers
        If Not (IsNumeric(Ast) And IsNumeric(Bst) And IsNumeric(Cst) _
                And IsNumeric(Dst)) Then
            MessageBox.Show("Please enter valid numbers", "Error!")
            Return
        End If

        ' Convert to double
        A = CDbl(Ast)
        B = CDbl(Bst)
        C = CDbl(Cst)
        D = CDbl(Dst)

        If (B < A Or D < C) Then
            MessageBox.Show("Please enter a valid number")
        End If

        txtResult.Text = FindIntersection(A, B, C, D)
    End Sub

    Function FindIntersection(A As Double, b As Double, c As Double, d As Double) As String
        Dim result As String
        If (b < c) Or (d < A) Then
            result = "no intersection"
        Else
            Dim begpoint As Double
            begpoint = Math.Max(A, c)

            Dim endpoint As Double
            endpoint = Math.Min(b, d)

            result = "The intersection is from " & begpoint & " to " & endpoint
        End If

        Return result

    End Function
















End Class
