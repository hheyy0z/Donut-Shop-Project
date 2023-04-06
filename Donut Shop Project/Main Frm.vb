Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub ClearoOutput(sender As Object, e As EventArgs) Handles RadBTNCap.CheckedChanged,
    radbtnNone.CheckedChanged, RadBtnReg.CheckedChanged, radbtnGlazed.CheckedChanged, RadBtnChoco.CheckedChanged,
    RadbtnFilled.CheckedChanged, RadBtnSugar.CheckedChanged

    End Sub

    Private Sub FindSubtotal(ByRef subtotalcost As Decimal)

        Select Case True
            Case radbtnGlazed.Checked, RadBtnSugar.Created checked 
                subtotalcost = 1.05D
            Case RadbtnFilled.Checked
                subtotalcost = 1.5D
            Case Else
                subtotalcost = 1.25D
        End Select

        Select Case True
            Case RadBtnReg.Checked
                subtotalcost += 1.5D
            Case RadBTNCap.Checked
                subtotalcost += 2.75D
        End Select
    End Sub
    Private Sub btnCalculate_Click() Handles btnCalculate.Click

    End Sub
End Class

