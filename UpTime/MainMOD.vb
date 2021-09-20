Public Module MainMOD
    Public Sub Main()
        Using p As New PerformanceCounter("System", "System Up Time")
            p.NextValue()
            Dim t As TimeSpan = TimeSpan.FromSeconds(p.NextValue())
            MsgBox($"UpTime: {t.Days} days, {t.Hours} hours {t.Minutes} minutes!",
                   MsgBoxStyle.Information + MsgBoxStyle.OkOnly + MsgBoxStyle.DefaultButton1,
                   "UpTime...")
        End Using
    End Sub
End Module