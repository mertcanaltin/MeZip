<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BipZipFormu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BipZipFormu))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DosyaKlasorTextBox = New System.Windows.Forms.TextBox()
        Me.KlasorRadioButton = New System.Windows.Forms.RadioButton()
        Me.DosyaRadioButton = New System.Windows.Forms.RadioButton()
        Me.BipZipStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ArsiviAyiklaButton = New System.Windows.Forms.Button()
        Me.ArsiveEkleButton = New System.Windows.Forms.Button()
        Me.BipZipOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.BipZipFolderBrowserDialog = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seçilen Dosya(lar)/Klasör(ler)"
        '
        'DosyaKlasorTextBox
        '
        Me.DosyaKlasorTextBox.Location = New System.Drawing.Point(28, 37)
        Me.DosyaKlasorTextBox.Multiline = True
        Me.DosyaKlasorTextBox.Name = "DosyaKlasorTextBox"
        Me.DosyaKlasorTextBox.ReadOnly = True
        Me.DosyaKlasorTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DosyaKlasorTextBox.Size = New System.Drawing.Size(539, 71)
        Me.DosyaKlasorTextBox.TabIndex = 1
        Me.DosyaKlasorTextBox.TabStop = False
        '
        'KlasorRadioButton
        '
        Me.KlasorRadioButton.AutoSize = True
        Me.KlasorRadioButton.Checked = True
        Me.KlasorRadioButton.Location = New System.Drawing.Point(28, 114)
        Me.KlasorRadioButton.Name = "KlasorRadioButton"
        Me.KlasorRadioButton.Size = New System.Drawing.Size(172, 21)
        Me.KlasorRadioButton.TabIndex = 4
        Me.KlasorRadioButton.TabStop = True
        Me.KlasorRadioButton.Text = "Seçilen Klasörü Sıkıştır"
        Me.KlasorRadioButton.UseVisualStyleBackColor = True
        '
        'DosyaRadioButton
        '
        Me.DosyaRadioButton.AutoSize = True
        Me.DosyaRadioButton.Location = New System.Drawing.Point(205, 114)
        Me.DosyaRadioButton.Name = "DosyaRadioButton"
        Me.DosyaRadioButton.Size = New System.Drawing.Size(183, 21)
        Me.DosyaRadioButton.TabIndex = 5
        Me.DosyaRadioButton.Text = "Seçilen Dosyaları Sıkıştır"
        Me.DosyaRadioButton.UseVisualStyleBackColor = True
        '
        'BipZipStatusStrip
        '
        Me.BipZipStatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.BipZipStatusStrip.Location = New System.Drawing.Point(0, 217)
        Me.BipZipStatusStrip.Name = "BipZipStatusStrip"
        Me.BipZipStatusStrip.Size = New System.Drawing.Size(596, 22)
        Me.BipZipStatusStrip.TabIndex = 6
        Me.BipZipStatusStrip.Text = "StatusStrip1"
        '
        'ArsiviAyiklaButton
        '
        Me.ArsiviAyiklaButton.Image = Global.BipZip.My.Resources.Resources.unzip
        Me.ArsiviAyiklaButton.Location = New System.Drawing.Point(305, 141)
        Me.ArsiviAyiklaButton.Name = "ArsiviAyiklaButton"
        Me.ArsiviAyiklaButton.Size = New System.Drawing.Size(262, 61)
        Me.ArsiviAyiklaButton.TabIndex = 3
        Me.ArsiviAyiklaButton.Text = "Arşivi Ayıkla"
        Me.ArsiviAyiklaButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ArsiviAyiklaButton.UseVisualStyleBackColor = True
        '
        'ArsiveEkleButton
        '
        Me.ArsiveEkleButton.Image = Global.BipZip.My.Resources.Resources.zip
        Me.ArsiveEkleButton.Location = New System.Drawing.Point(28, 141)
        Me.ArsiveEkleButton.Name = "ArsiveEkleButton"
        Me.ArsiveEkleButton.Size = New System.Drawing.Size(262, 61)
        Me.ArsiveEkleButton.TabIndex = 2
        Me.ArsiveEkleButton.Text = "Arşive Ekle"
        Me.ArsiveEkleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ArsiveEkleButton.UseVisualStyleBackColor = True
        '
        'BipZipOpenFileDialog
        '
        Me.BipZipOpenFileDialog.Filter = "Tüm Dosyalar|*.*"
        Me.BipZipOpenFileDialog.Multiselect = True
        Me.BipZipOpenFileDialog.Title = "Sıkıştırma yapılacak Dosyaları Seçiniz"
        '
        'BipZipFolderBrowserDialog
        '
        Me.BipZipFolderBrowserDialog.Description = "Sıkıştırma Yapılacak Klasörü Seçiniz"
        Me.BipZipFolderBrowserDialog.ShowNewFolderButton = False
        '
        'BipZipFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 239)
        Me.Controls.Add(Me.BipZipStatusStrip)
        Me.Controls.Add(Me.DosyaRadioButton)
        Me.Controls.Add(Me.KlasorRadioButton)
        Me.Controls.Add(Me.ArsiviAyiklaButton)
        Me.Controls.Add(Me.ArsiveEkleButton)
        Me.Controls.Add(Me.DosyaKlasorTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BipZipFormu"
        Me.Text = "BipZip Dosya Sıkıştırma Programı"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DosyaKlasorTextBox As TextBox
    Friend WithEvents ArsiveEkleButton As Button
    Friend WithEvents ArsiviAyiklaButton As Button
    Friend WithEvents KlasorRadioButton As RadioButton
    Friend WithEvents DosyaRadioButton As RadioButton
    Friend WithEvents BipZipStatusStrip As StatusStrip
    Friend WithEvents BipZipOpenFileDialog As OpenFileDialog
    Friend WithEvents BipZipFolderBrowserDialog As FolderBrowserDialog
End Class
