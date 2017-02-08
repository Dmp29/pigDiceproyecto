<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.lblJugador = New System.Windows.Forms.Label()
        Me.txtJugador = New System.Windows.Forms.TextBox()
        Me.lblComp = New System.Windows.Forms.Label()
        Me.txtComputadora = New System.Windows.Forms.TextBox()
        Me.lblAcum = New System.Windows.Forms.Label()
        Me.txtAcum = New System.Windows.Forms.TextBox()
        Me.lblDado = New System.Windows.Forms.Label()
        Me.txtDado = New System.Windows.Forms.TextBox()
        Me.btnTirar = New System.Windows.Forms.Button()
        Me.btnParar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJugador
        '
        Me.lblJugador.AutoSize = True
        Me.lblJugador.Location = New System.Drawing.Point(23, 23)
        Me.lblJugador.Name = "lblJugador"
        Me.lblJugador.Size = New System.Drawing.Size(45, 13)
        Me.lblJugador.TabIndex = 0
        Me.lblJugador.Text = "Jugador"
        '
        'txtJugador
        '
        Me.txtJugador.Location = New System.Drawing.Point(26, 53)
        Me.txtJugador.Name = "txtJugador"
        Me.txtJugador.Size = New System.Drawing.Size(100, 20)
        Me.txtJugador.TabIndex = 1
        '
        'lblComp
        '
        Me.lblComp.AutoSize = True
        Me.lblComp.Location = New System.Drawing.Point(169, 23)
        Me.lblComp.Name = "lblComp"
        Me.lblComp.Size = New System.Drawing.Size(70, 13)
        Me.lblComp.TabIndex = 2
        Me.lblComp.Text = "Computadora"
        '
        'txtComputadora
        '
        Me.txtComputadora.Location = New System.Drawing.Point(172, 53)
        Me.txtComputadora.Name = "txtComputadora"
        Me.txtComputadora.Size = New System.Drawing.Size(100, 20)
        Me.txtComputadora.TabIndex = 3
        '
        'lblAcum
        '
        Me.lblAcum.AutoSize = True
        Me.lblAcum.Location = New System.Drawing.Point(120, 76)
        Me.lblAcum.Name = "lblAcum"
        Me.lblAcum.Size = New System.Drawing.Size(60, 13)
        Me.lblAcum.TabIndex = 4
        Me.lblAcum.Text = "Acumulado"
        '
        'txtAcum
        '
        Me.txtAcum.Location = New System.Drawing.Point(98, 92)
        Me.txtAcum.Name = "txtAcum"
        Me.txtAcum.Size = New System.Drawing.Size(100, 20)
        Me.txtAcum.TabIndex = 5
        '
        'lblDado
        '
        Me.lblDado.AutoSize = True
        Me.lblDado.Location = New System.Drawing.Point(129, 115)
        Me.lblDado.Name = "lblDado"
        Me.lblDado.Size = New System.Drawing.Size(33, 13)
        Me.lblDado.TabIndex = 6
        Me.lblDado.Text = "Dado"
        '
        'txtDado
        '
        Me.txtDado.Location = New System.Drawing.Point(98, 131)
        Me.txtDado.Name = "txtDado"
        Me.txtDado.Size = New System.Drawing.Size(100, 20)
        Me.txtDado.TabIndex = 7
        '
        'btnTirar
        '
        Me.btnTirar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnTirar.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTirar.Location = New System.Drawing.Point(26, 175)
        Me.btnTirar.Name = "btnTirar"
        Me.btnTirar.Size = New System.Drawing.Size(75, 23)
        Me.btnTirar.TabIndex = 8
        Me.btnTirar.Text = "Tirar"
        Me.btnTirar.UseVisualStyleBackColor = False
        '
        'btnParar
        '
        Me.btnParar.BackColor = System.Drawing.SystemColors.HighlightText
        Me.btnParar.ForeColor = System.Drawing.SystemColors.Highlight
        Me.btnParar.Location = New System.Drawing.Point(197, 175)
        Me.btnParar.Name = "btnParar"
        Me.btnParar.Size = New System.Drawing.Size(75, 23)
        Me.btnParar.TabIndex = 9
        Me.btnParar.Text = "Parar"
        Me.btnParar.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AccessibleDescription = ""
        Me.AccessibleName = ""
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnParar)
        Me.Controls.Add(Me.btnTirar)
        Me.Controls.Add(Me.txtDado)
        Me.Controls.Add(Me.lblDado)
        Me.Controls.Add(Me.txtAcum)
        Me.Controls.Add(Me.lblAcum)
        Me.Controls.Add(Me.txtComputadora)
        Me.Controls.Add(Me.lblComp)
        Me.Controls.Add(Me.txtJugador)
        Me.Controls.Add(Me.lblJugador)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Pig Dice"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJugador As Label
    Friend WithEvents txtJugador As TextBox
    Friend WithEvents lblComp As Label
    Friend WithEvents txtComputadora As TextBox
    Friend WithEvents lblAcum As Label
    Friend WithEvents txtAcum As TextBox
    Friend WithEvents lblDado As Label
    Friend WithEvents txtDado As TextBox
    Friend WithEvents btnTirar As Button
    Friend WithEvents btnParar As Button
End Class
