Public Class MainForm
    Dim FileName As String = ""
    
    Private Sub mnuSave_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles mnuSave.LinkClicked
        Try
            If FileName.Length = 0 Then
                Dim sfd As New SaveFileDialog()
                sfd.Filter = ("Text Files (*.Txt,*.text)|*.txt;*.text| CSV Files(*.csv)|*.csv")
                If sfd.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    FileName = sfd.FileName
                End If
            End If
            System.IO.File.WriteAllLines(FileName, txtMain.Lines)

            MessageBox.Show("File successfully saved", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error while saving file. Pls. make sure you have necessary rights to the folder.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub mnuOpen_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles mnuOpen.LinkClicked
        Dim ofd As New OpenFileDialog
        ofd.Filter = ("Text Files (*.rxt,*.text)|*.txt;*.text| CSV Files(*.csv)|*.csv")
        If ofd.ShowDialog() = Windows.Forms.DialogResult.OK Then
            FileName = ofd.FileName
            Me.txtMain.Lines = System.IO.File.ReadAllLines(ofd.FileName)
        End If

    End Sub

    Private Sub mnuRemoveDuplicate_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles mnuRemoveDuplicate.LinkClicked

        Dim lines = Me.txtMain.Lines.Length

        Me.txtMain.Lines = Me.txtMain.Lines.Distinct().ToArray()

        Dim duplicates = lines - Me.txtMain.Lines.Length
        If (duplicates) > 0 Then
            MessageBox.Show(duplicates & " duplicates has been removed.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("No duplicate rows found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub
End Class
