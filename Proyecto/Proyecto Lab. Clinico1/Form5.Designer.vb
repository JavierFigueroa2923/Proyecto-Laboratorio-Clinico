<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button2.Location = New System.Drawing.Point(74, 252)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(209, 40)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Agregar Empleado"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(80, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(678, 442)
        Me.Panel1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button1.Location = New System.Drawing.Point(74, 196)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(209, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Cotizacion"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!)
        Me.Label2.Location = New System.Drawing.Point(197, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 32)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Menu de Administrador"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(294, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button3.Location = New System.Drawing.Point(74, 302)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(209, 40)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "Agregar Paciente"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button4.Location = New System.Drawing.Point(411, 196)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(209, 40)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "Reporte Examenes"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button5.Location = New System.Drawing.Point(244, 364)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(209, 40)
        Me.Button5.TabIndex = 21
        Me.Button5.Text = "Reporte examen de paciente"
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button7.Location = New System.Drawing.Point(411, 252)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(209, 40)
        Me.Button7.TabIndex = 19
        Me.Button7.Text = "Reporte Ganancias"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.SystemColors.ControlDark
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!)
        Me.Button8.Location = New System.Drawing.Point(411, 302)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(209, 40)
        Me.Button8.TabIndex = 18
        Me.Button8.Text = "Reporte de Pagos"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(837, 525)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.Text = "Menu Administrador"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button5 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button8 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
