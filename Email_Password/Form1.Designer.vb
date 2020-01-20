<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnStore = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.inpEmailName = New System.Windows.Forms.TextBox()
        Me.inpEmailPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.msgMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStore
        '
        Me.btnStore.Location = New System.Drawing.Point(99, 114)
        Me.btnStore.Name = "btnStore"
        Me.btnStore.Size = New System.Drawing.Size(147, 23)
        Me.btnStore.TabIndex = 0
        Me.btnStore.Text = "Encrypt and Store"
        Me.btnStore.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(26, 45)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(63, 13)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Email Name"
        '
        'inpEmailName
        '
        Me.inpEmailName.Location = New System.Drawing.Point(99, 42)
        Me.inpEmailName.Name = "inpEmailName"
        Me.inpEmailName.Size = New System.Drawing.Size(147, 20)
        Me.inpEmailName.TabIndex = 2
        '
        'inpEmailPassword
        '
        Me.inpEmailPassword.Location = New System.Drawing.Point(99, 72)
        Me.inpEmailPassword.Name = "inpEmailPassword"
        Me.inpEmailPassword.Size = New System.Drawing.Size(147, 20)
        Me.inpEmailPassword.TabIndex = 3
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(26, 75)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 4
        Me.lblPassword.Text = "Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(74, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Insert Password "
        '
        'msgMessage
        '
        Me.msgMessage.AutoSize = True
        Me.msgMessage.Location = New System.Drawing.Point(39, 161)
        Me.msgMessage.Name = "msgMessage"
        Me.msgMessage.Size = New System.Drawing.Size(40, 13)
        Me.msgMessage.TabIndex = 6
        Me.msgMessage.Text = "Result:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(316, 450)
        Me.Controls.Add(Me.msgMessage)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.inpEmailPassword)
        Me.Controls.Add(Me.inpEmailName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnStore)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStore As Button
    Friend WithEvents lblName As Label
    Friend WithEvents inpEmailName As TextBox
    Friend WithEvents inpEmailPassword As TextBox
    Friend WithEvents lblPassword As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents msgMessage As Label
End Class
