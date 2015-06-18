Public Class frm_Loading

    Private Sub timer_Timing_Tick(sender As Object, e As EventArgs) Handles timer_Timing.Tick
        pgb_Loading.Increment(1)
        If pgb_Loading.Value = pgb_Loading.Maximum Then
            Me.Close()
        End If
    End Sub
End Class