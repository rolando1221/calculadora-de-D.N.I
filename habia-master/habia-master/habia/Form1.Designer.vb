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
        Button1 = New Button()
        dni = New TextBox()
        mujer = New RadioButton()
        varon = New RadioButton()
        TextBox1 = New TextBox()
        cuil = New TextBox()
        TextBox3 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.HotTrack
        Button1.Location = New Point(318, 13)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 0
        Button1.Text = "convertir"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' dni
        ' 
        dni.BackColor = SystemColors.InactiveCaption
        dni.Location = New Point(19, 13)
        dni.Name = "dni"
        dni.Size = New Size(267, 27)
        dni.TabIndex = 1
        ' 
        ' mujer
        ' 
        mujer.AutoSize = True
        mujer.Location = New Point(122, 46)
        mujer.Name = "mujer"
        mujer.Size = New Size(93, 24)
        mujer.TabIndex = 2
        mujer.TabStop = True
        mujer.Text = "femenino"
        mujer.UseVisualStyleBackColor = True
        ' 
        ' varon
        ' 
        varon.AutoSize = True
        varon.Location = New Point(19, 46)
        varon.Name = "varon"
        varon.Size = New Size(97, 24)
        varon.TabIndex = 3
        varon.TabStop = True
        varon.Text = "masculino"
        varon.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.InactiveCaption
        TextBox1.Location = New Point(19, 92)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(268, 27)
        TextBox1.TabIndex = 4
        ' 
        ' cuil
        ' 
        cuil.BackColor = SystemColors.InactiveCaption
        cuil.Location = New Point(19, 146)
        cuil.Name = "cuil"
        cuil.Size = New Size(268, 27)
        cuil.TabIndex = 5
        ' 
        ' TextBox3
        ' 
        TextBox3.BackColor = SystemColors.InactiveCaption
        TextBox3.Location = New Point(19, 199)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(267, 27)
        TextBox3.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.BackColor = SystemColors.InactiveCaption
        TextBox2.Location = New Point(19, 252)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(268, 27)
        TextBox2.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MediumSlateBlue
        ClientSize = New Size(427, 341)
        Controls.Add(TextBox2)
        Controls.Add(TextBox3)
        Controls.Add(cuil)
        Controls.Add(TextBox1)
        Controls.Add(varon)
        Controls.Add(mujer)
        Controls.Add(dni)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents dni As TextBox
    Friend WithEvents mujer As RadioButton
    Friend WithEvents varon As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cuil As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
