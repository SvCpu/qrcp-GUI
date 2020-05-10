Public Class QrSet
    Private Sub cmbEncoding_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMaxVersion.SelectedIndexChanged, cmbErrorCorrectionLevel.SelectedIndexChanged, cmbEncoding.SelectedIndexChanged, nudModuleSize.ValueChanged, chkStructuredAppend.CheckedChanged
        FormShow.UpdateQRCodePanel(FormShow.TextBox2.Text)
    End Sub
End Class