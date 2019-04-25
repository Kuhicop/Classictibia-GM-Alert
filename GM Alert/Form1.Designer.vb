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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.chkZornak = New System.Windows.Forms.CheckBox()
        Me.chkVassak = New System.Windows.Forms.CheckBox()
        Me.txtmailaddr = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkadmin = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chkclose = New System.Windows.Forms.CheckBox()
        Me.chkmail = New System.Windows.Forms.CheckBox()
        Me.chksound = New System.Windows.Forms.CheckBox()
        Me.chkRid = New System.Windows.Forms.CheckBox()
        Me.chkBlackAdder = New System.Windows.Forms.CheckBox()
        Me.chkAngar = New System.Windows.Forms.CheckBox()
        Me.Checking = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'chkZornak
        '
        Me.chkZornak.AutoSize = True
        Me.chkZornak.Location = New System.Drawing.Point(38, 210)
        Me.chkZornak.Margin = New System.Windows.Forms.Padding(2)
        Me.chkZornak.Name = "chkZornak"
        Me.chkZornak.Size = New System.Drawing.Size(71, 17)
        Me.chkZornak.TabIndex = 34
        Me.chkZornak.Text = "ZORNAK"
        Me.chkZornak.UseVisualStyleBackColor = True
        '
        'chkVassak
        '
        Me.chkVassak.AutoSize = True
        Me.chkVassak.Location = New System.Drawing.Point(38, 188)
        Me.chkVassak.Margin = New System.Windows.Forms.Padding(2)
        Me.chkVassak.Name = "chkVassak"
        Me.chkVassak.Size = New System.Drawing.Size(68, 17)
        Me.chkVassak.TabIndex = 33
        Me.chkVassak.Text = "VASSAK"
        Me.chkVassak.UseVisualStyleBackColor = True
        '
        'txtmailaddr
        '
        Me.txtmailaddr.Location = New System.Drawing.Point(107, 96)
        Me.txtmailaddr.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmailaddr.Name = "txtmailaddr"
        Me.txtmailaddr.Size = New System.Drawing.Size(100, 20)
        Me.txtmailaddr.TabIndex = 32
        Me.txtmailaddr.Text = "Mail Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "ACTIONS:"
        '
        'chkadmin
        '
        Me.chkadmin.AutoSize = True
        Me.chkadmin.Location = New System.Drawing.Point(38, 166)
        Me.chkadmin.Margin = New System.Windows.Forms.Padding(2)
        Me.chkadmin.Name = "chkadmin"
        Me.chkadmin.Size = New System.Drawing.Size(61, 17)
        Me.chkadmin.TabIndex = 30
        Me.chkadmin.Text = "ADMIN"
        Me.chkadmin.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(35, 136)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(166, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "IGNORE THIS STAFF:"
        '
        'chkclose
        '
        Me.chkclose.AutoSize = True
        Me.chkclose.Location = New System.Drawing.Point(107, 72)
        Me.chkclose.Margin = New System.Windows.Forms.Padding(2)
        Me.chkclose.Name = "chkclose"
        Me.chkclose.Size = New System.Drawing.Size(135, 17)
        Me.chkclose.TabIndex = 28
        Me.chkclose.Text = "LOGOUT AND CLOSE"
        Me.chkclose.UseVisualStyleBackColor = True
        '
        'chkmail
        '
        Me.chkmail.AutoSize = True
        Me.chkmail.Location = New System.Drawing.Point(38, 99)
        Me.chkmail.Margin = New System.Windows.Forms.Padding(2)
        Me.chkmail.Name = "chkmail"
        Me.chkmail.Size = New System.Drawing.Size(51, 17)
        Me.chkmail.TabIndex = 27
        Me.chkmail.Text = "MAIL"
        Me.chkmail.UseVisualStyleBackColor = True
        '
        'chksound
        '
        Me.chksound.AutoSize = True
        Me.chksound.Location = New System.Drawing.Point(38, 72)
        Me.chksound.Margin = New System.Windows.Forms.Padding(2)
        Me.chksound.Name = "chksound"
        Me.chksound.Size = New System.Drawing.Size(65, 17)
        Me.chksound.TabIndex = 26
        Me.chksound.Text = "SOUND"
        Me.chksound.UseVisualStyleBackColor = True
        '
        'chkRid
        '
        Me.chkRid.AutoSize = True
        Me.chkRid.Location = New System.Drawing.Point(38, 275)
        Me.chkRid.Margin = New System.Windows.Forms.Padding(2)
        Me.chkRid.Name = "chkRid"
        Me.chkRid.Size = New System.Drawing.Size(65, 17)
        Me.chkRid.TabIndex = 44
        Me.chkRid.Text = "GM RID"
        Me.chkRid.UseVisualStyleBackColor = True
        '
        'chkBlackAdder
        '
        Me.chkBlackAdder.AutoSize = True
        Me.chkBlackAdder.Location = New System.Drawing.Point(38, 253)
        Me.chkBlackAdder.Margin = New System.Windows.Forms.Padding(2)
        Me.chkBlackAdder.Name = "chkBlackAdder"
        Me.chkBlackAdder.Size = New System.Drawing.Size(117, 17)
        Me.chkBlackAdder.TabIndex = 43
        Me.chkBlackAdder.Text = "CM BLACKADDER"
        Me.chkBlackAdder.UseVisualStyleBackColor = True
        '
        'chkAngar
        '
        Me.chkAngar.AutoSize = True
        Me.chkAngar.Location = New System.Drawing.Point(38, 231)
        Me.chkAngar.Margin = New System.Windows.Forms.Padding(2)
        Me.chkAngar.Name = "chkAngar"
        Me.chkAngar.Size = New System.Drawing.Size(84, 17)
        Me.chkAngar.TabIndex = 42
        Me.chkAngar.Text = "GM ANGAR"
        Me.chkAngar.UseVisualStyleBackColor = True
        '
        'Checking
        '
        Me.Checking.Enabled = True
        Me.Checking.Interval = 3000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(264, 316)
        Me.Controls.Add(Me.chkRid)
        Me.Controls.Add(Me.chkBlackAdder)
        Me.Controls.Add(Me.chkAngar)
        Me.Controls.Add(Me.chkZornak)
        Me.Controls.Add(Me.chkVassak)
        Me.Controls.Add(Me.txtmailaddr)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chkadmin)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkclose)
        Me.Controls.Add(Me.chkmail)
        Me.Controls.Add(Me.chksound)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Lucy Watchdog"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkZornak As CheckBox
    Friend WithEvents chkVassak As CheckBox
    Friend WithEvents txtmailaddr As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents chkadmin As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents chkclose As CheckBox
    Friend WithEvents chkmail As CheckBox
    Friend WithEvents chksound As CheckBox
    Friend WithEvents chkRid As CheckBox
    Friend WithEvents chkBlackAdder As CheckBox
    Friend WithEvents chkAngar As CheckBox
    Public WithEvents Checking As Timer
End Class
