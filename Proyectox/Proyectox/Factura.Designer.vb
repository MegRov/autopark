<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Factura
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
        Me.components = New System.ComponentModel.Container()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LBVminuto = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBIngreso = New System.Windows.Forms.TextBox()
        Me.TBHsalida = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBTotal = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(172, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 36)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Factura"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(12, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 36)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "valor minuto"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(18, 150)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 26)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Hora Ingreso"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(29, 71)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 36)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Placa"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(247, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 15
        '
        'LBVminuto
        '
        Me.LBVminuto.AutoSize = True
        Me.LBVminuto.Location = New System.Drawing.Point(265, 220)
        Me.LBVminuto.Name = "LBVminuto"
        Me.LBVminuto.Size = New System.Drawing.Size(25, 13)
        Me.LBVminuto.TabIndex = 16
        Me.LBVminuto.Text = "100"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(498, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(12, 268)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(211, 36)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Hora Desalida"
        '
        'TBIngreso
        '
        Me.TBIngreso.Location = New System.Drawing.Point(247, 156)
        Me.TBIngreso.Name = "TBIngreso"
        Me.TBIngreso.Size = New System.Drawing.Size(100, 20)
        Me.TBIngreso.TabIndex = 19
        '
        'TBHsalida
        '
        Me.TBHsalida.Location = New System.Drawing.Point(247, 283)
        Me.TBHsalida.Name = "TBHsalida"
        Me.TBHsalida.Size = New System.Drawing.Size(100, 20)
        Me.TBHsalida.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(100, 418)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(149, 26)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Facturar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(20, 345)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(203, 36)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Valor a Pagar"
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(247, 360)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.Size = New System.Drawing.Size(100, 20)
        Me.TBTotal.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(380, 418)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(162, 26)
        Me.Button3.TabIndex = 24
        Me.Button3.Text = "Cerrar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 485)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TBTotal)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TBHsalida)
        Me.Controls.Add(Me.TBIngreso)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LBVminuto)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Name = "Factura"
        Me.Text = "Factura"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents LBVminuto As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBIngreso As System.Windows.Forms.TextBox
    Friend WithEvents TBHsalida As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBTotal As System.Windows.Forms.TextBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
