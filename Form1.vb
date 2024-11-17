Public Class Form1
    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim taille = lstTaille.SelectedItem : ToString()
        Dim ingredient As String = ""
        If rd_1.Checked Then
            ingredient = "Croute fine"
        ElseIf rd_2.Checked Then
            ingredient = "Croute classique"
        ElseIf rd_3.Checked Then
            ingredient = "Croute épaisse"
        End If
        Dim IngSupp As String = ""
        If chk_1.Checked Then
            IngSupp = IngSupp + "Champignons"
        ElseIf chk_2.Checked Then
            IngSupp = IngSupp + "Olives"
        ElseIf chk_3.Checked Then
            IngSupp = IngSupp + "Poivrons"
        ElseIf chk_4.Checked Then
            IngSupp = IngSupp + "Fromage supplémentaire"
        End If
        Dim msg As String = "Taille :" + taille + "Type de croute :" + ingredient + "Ingredient"


    End Sub



End Class