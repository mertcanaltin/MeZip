Public Class BipZipFormu
    Private Sub ArsiveEkleButton_Click(sender As Object, e As EventArgs) Handles ArsiveEkleButton.Click
        DosyaKlasorTextBox.Clear()
        If DosyaRadioButton.Checked Then
            If BipZipOpenFileDialog.ShowDialog = DialogResult.OK Then
                DosyaKlasorTextBox.Text = String.Join(vbCrLf, BipZipOpenFileDialog.FileNames)
            End If
        Else
            If BipZipFolderBrowserDialog.ShowDialog = DialogResult.OK Then
                DosyaKlasorTextBox.Text = BipZipFolderBrowserDialog.SelectedPath
            End If
        End If
    End Sub
End Class
