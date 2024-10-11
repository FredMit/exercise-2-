<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnClick = New Button()
        lblEnterAnyNumber = New Label()
        txtNumber = New TextBox()
        SuspendLayout()
        ' 
        ' btnClick
        ' 
        btnClick.Location = New Point(310, 109)
        btnClick.Name = "btnClick"
        btnClick.Size = New Size(75, 23)
        btnClick.TabIndex = 0
        btnClick.Text = "Click"
        btnClick.UseVisualStyleBackColor = True
        ' 
        ' lblEnterAnyNumber
        ' 
        lblEnterAnyNumber.AutoSize = True
        lblEnterAnyNumber.Location = New Point(290, 43)
        lblEnterAnyNumber.Name = "lblEnterAnyNumber"
        lblEnterAnyNumber.Size = New Size(119, 15)
        lblEnterAnyNumber.TabIndex = 1
        lblEnterAnyNumber.Text = "ENTER ANY NUMBER"
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(257, 71)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(201, 23)
        txtNumber.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNumber)
        Controls.Add(lblEnterAnyNumber)
        Controls.Add(btnClick)
        Name = "Form1"
        Text = "Exercise2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClick As Button
    Friend WithEvents lblEnterAnyNumber As Label
    Friend WithEvents txtNumber As TextBox

End Class
