<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Suma = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Potencia = New System.Windows.Forms.RadioButton()
        Me.Division = New System.Windows.Forms.RadioButton()
        Me.Producto = New System.Windows.Forms.RadioButton()
        Me.Resta = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Num1 = New System.Windows.Forms.TextBox()
        Me.Num2 = New System.Windows.Forms.TextBox()
        Me.Resultado = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BotonLimpiar = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Suma
        '
        Me.Suma.AutoSize = True
        Me.Suma.Location = New System.Drawing.Point(17, 23)
        Me.Suma.Name = "Suma"
        Me.Suma.Size = New System.Drawing.Size(52, 17)
        Me.Suma.TabIndex = 0
        Me.Suma.TabStop = True
        Me.Suma.Text = "Suma"
        Me.Suma.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Potencia)
        Me.GroupBox1.Controls.Add(Me.Division)
        Me.GroupBox1.Controls.Add(Me.Producto)
        Me.GroupBox1.Controls.Add(Me.Resta)
        Me.GroupBox1.Controls.Add(Me.Suma)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(135, 150)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Operaciones"
        '
        'Potencia
        '
        Me.Potencia.AutoSize = True
        Me.Potencia.Location = New System.Drawing.Point(17, 115)
        Me.Potencia.Name = "Potencia"
        Me.Potencia.Size = New System.Drawing.Size(67, 17)
        Me.Potencia.TabIndex = 4
        Me.Potencia.TabStop = True
        Me.Potencia.Text = "Potencia"
        Me.Potencia.UseVisualStyleBackColor = True
        '
        'Division
        '
        Me.Division.AutoSize = True
        Me.Division.Location = New System.Drawing.Point(17, 92)
        Me.Division.Name = "Division"
        Me.Division.Size = New System.Drawing.Size(62, 17)
        Me.Division.TabIndex = 3
        Me.Division.TabStop = True
        Me.Division.Text = "División"
        Me.Division.UseVisualStyleBackColor = True
        '
        'Producto
        '
        Me.Producto.AutoSize = True
        Me.Producto.Location = New System.Drawing.Point(17, 69)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(68, 17)
        Me.Producto.TabIndex = 2
        Me.Producto.TabStop = True
        Me.Producto.Text = "Producto"
        Me.Producto.UseVisualStyleBackColor = True
        '
        'Resta
        '
        Me.Resta.AutoSize = True
        Me.Resta.Location = New System.Drawing.Point(17, 46)
        Me.Resta.Name = "Resta"
        Me.Resta.Size = New System.Drawing.Size(53, 17)
        Me.Resta.TabIndex = 1
        Me.Resta.TabStop = True
        Me.Resta.Text = "Resta"
        Me.Resta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Número 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Número 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Resultado"
        '
        'Num1
        '
        Me.Num1.Location = New System.Drawing.Point(15, 29)
        Me.Num1.Name = "Num1"
        Me.Num1.Size = New System.Drawing.Size(100, 20)
        Me.Num1.TabIndex = 5
        '
        'Num2
        '
        Me.Num2.Location = New System.Drawing.Point(15, 78)
        Me.Num2.Name = "Num2"
        Me.Num2.Size = New System.Drawing.Size(100, 20)
        Me.Num2.TabIndex = 6
        '
        'Resultado
        '
        Me.Resultado.Location = New System.Drawing.Point(15, 139)
        Me.Resultado.Name = "Resultado"
        Me.Resultado.Size = New System.Drawing.Size(100, 20)
        Me.Resultado.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(322, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calcular"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BotonLimpiar
        '
        Me.BotonLimpiar.Location = New System.Drawing.Point(322, 78)
        Me.BotonLimpiar.Name = "BotonLimpiar"
        Me.BotonLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.BotonLimpiar.TabIndex = 9
        Me.BotonLimpiar.Text = "Limpiar"
        Me.BotonLimpiar.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(322, 137)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Salir"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 169)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.BotonLimpiar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Resultado)
        Me.Controls.Add(Me.Num2)
        Me.Controls.Add(Me.Num1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Ejercicio RadioButton"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Suma As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Potencia As RadioButton
    Friend WithEvents Division As RadioButton
    Friend WithEvents Producto As RadioButton
    Friend WithEvents Resta As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Num1 As TextBox
    Friend WithEvents Num2 As TextBox
    Friend WithEvents Resultado As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BotonLimpiar As Button
    Friend WithEvents Button3 As Button
End Class
