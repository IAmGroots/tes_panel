Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        addCard()
    End Sub

    Private Sub addCard()
        For i = 1 To 10
            Dim card As New Card
            With card
                .label.Text = "Card " & i
            End With
            card.TopLevel = False
            PanelCard.Controls.Add(card)
            card.Show()
        Next
    End Sub
End Class
