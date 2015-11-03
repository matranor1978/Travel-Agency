Public Class Demarrage
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm_principal As New HomePageFrm
        pb.Visible = True
        pb.Value = pb.Minimum
        Do While pb.Value < pb.Maximum
            pb.Value += 20
            System.Threading.Thread.Sleep(1000)
        Loop
        If pb.Value = pb.Maximum Then
            pb.Visible = False
            Me.Visible = False
            frm_principal.Visible = True
        End If
    End Sub

    
End Class