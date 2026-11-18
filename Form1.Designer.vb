<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMensaje = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnMensaje
        '
        Me.btnMensaje.Location = New System.Drawing.Point(85, 95)
        Me.btnMensaje.Name = "btnMensaje"
        Me.btnMensaje.Size = New System.Drawing.Size(120, 35)
        Me.btnMensaje.TabIndex = 0
        Me.btnMensaje.Text = "Mostrar mensaje"
        Me.btnMensaje.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(300, 230)
        Me.Controls.Add(Me.btnMensaje)
        Me.Name = "Form1"
        Me.Text = "Mi primera aplicación"
        Me.ResumeLayout(False)
    End Sub

    Friend WithEvents btnMensaje As Button
End Class
