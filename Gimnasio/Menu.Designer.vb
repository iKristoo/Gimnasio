<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 25F, FontStyle.Bold)
        Label1.Location = New Point(262, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(257, 40)
        Label1.TabIndex = 0
        Label1.Text = "Menu Principal"
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Arial", 9F)
        Button1.Location = New Point(262, 93)
        Button1.Name = "Button1"
        Button1.Size = New Size(257, 40)
        Button1.TabIndex = 1
        Button1.Text = "Registro"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Arial", 9F)
        Button2.Location = New Point(262, 162)
        Button2.Name = "Button2"
        Button2.Size = New Size(257, 40)
        Button2.TabIndex = 2
        Button2.Text = "Asistencias"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Arial", 9F)
        Button3.Location = New Point(262, 225)
        Button3.Name = "Button3"
        Button3.Size = New Size(257, 40)
        Button3.TabIndex = 3
        Button3.Text = "Facturador"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Arial", 9F)
        Button4.Location = New Point(262, 291)
        Button4.Name = "Button4"
        Button4.Size = New Size(257, 40)
        Button4.TabIndex = 4
        Button4.Text = "Gestión de Datos"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Arial", 9F)
        Button5.Location = New Point(262, 358)
        Button5.Name = "Button5"
        Button5.Size = New Size(257, 40)
        Button5.TabIndex = 5
        Button5.Text = "Salir"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Menu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Menu"
        Text = "Menu"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
