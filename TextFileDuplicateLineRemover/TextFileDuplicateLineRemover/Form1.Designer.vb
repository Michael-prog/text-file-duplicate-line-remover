<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtMain = New System.Windows.Forms.TextBox
        Me.mnuOpen = New System.Windows.Forms.LinkLabel
        Me.mnuSave = New System.Windows.Forms.LinkLabel
        Me.mnuRemoveDuplicate = New System.Windows.Forms.LinkLabel
        Me.SuspendLayout()
        '
        'txtMain
        '
        Me.txtMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMain.Location = New System.Drawing.Point(13, 36)
        Me.txtMain.Multiline = True
        Me.txtMain.Name = "txtMain"
        Me.txtMain.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtMain.Size = New System.Drawing.Size(690, 284)
        Me.txtMain.TabIndex = 1
        '
        'mnuOpen
        '
        Me.mnuOpen.AutoSize = True
        Me.mnuOpen.Location = New System.Drawing.Point(13, 13)
        Me.mnuOpen.Name = "mnuOpen"
        Me.mnuOpen.Size = New System.Drawing.Size(50, 13)
        Me.mnuOpen.TabIndex = 2
        Me.mnuOpen.TabStop = True
        Me.mnuOpen.Text = "Load File"
        '
        'mnuSave
        '
        Me.mnuSave.AutoSize = True
        Me.mnuSave.Location = New System.Drawing.Point(84, 13)
        Me.mnuSave.Name = "mnuSave"
        Me.mnuSave.Size = New System.Drawing.Size(32, 13)
        Me.mnuSave.TabIndex = 3
        Me.mnuSave.TabStop = True
        Me.mnuSave.Text = "Save"
        '
        'mnuRemoveDuplicate
        '
        Me.mnuRemoveDuplicate.AutoSize = True
        Me.mnuRemoveDuplicate.Location = New System.Drawing.Point(141, 13)
        Me.mnuRemoveDuplicate.Name = "mnuRemoveDuplicate"
        Me.mnuRemoveDuplicate.Size = New System.Drawing.Size(100, 13)
        Me.mnuRemoveDuplicate.TabIndex = 4
        Me.mnuRemoveDuplicate.TabStop = True
        Me.mnuRemoveDuplicate.Text = "Remove Duplicates"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 332)
        Me.Controls.Add(Me.mnuRemoveDuplicate)
        Me.Controls.Add(Me.mnuSave)
        Me.Controls.Add(Me.mnuOpen)
        Me.Controls.Add(Me.txtMain)
        Me.Name = "MainForm"
        Me.Text = "Text File Duplicate Line Remover"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtMain As System.Windows.Forms.TextBox
    Friend WithEvents mnuOpen As System.Windows.Forms.LinkLabel
    Friend WithEvents mnuSave As System.Windows.Forms.LinkLabel
    Friend WithEvents mnuRemoveDuplicate As System.Windows.Forms.LinkLabel

End Class
