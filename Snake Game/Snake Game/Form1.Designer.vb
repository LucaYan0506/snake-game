<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SnakeMoving = New System.Windows.Forms.Timer(Me.components)
        Me.StartCmd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.TopLimit = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.DownLimit = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.RightLimit = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LeftLimit = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.Snake_head = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SnakeMoving
        '
        Me.SnakeMoving.Interval = 10
        '
        'StartCmd
        '
        Me.StartCmd.Location = New System.Drawing.Point(100, 437)
        Me.StartCmd.Name = "StartCmd"
        Me.StartCmd.Size = New System.Drawing.Size(75, 23)
        Me.StartCmd.TabIndex = 1
        Me.StartCmd.Text = "Start"
        Me.StartCmd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 429)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(227, 475)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.TopLimit, Me.DownLimit, Me.RightLimit, Me.LeftLimit, Me.Snake_head})
        Me.ShapeContainer1.Size = New System.Drawing.Size(620, 406)
        Me.ShapeContainer1.TabIndex = 0
        Me.ShapeContainer1.TabStop = False
        '
        'TopLimit
        '
        Me.TopLimit.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TopLimit.BorderWidth = 5
        Me.TopLimit.Name = "TopLimit"
        Me.TopLimit.X1 = 0
        Me.TopLimit.X2 = 620
        Me.TopLimit.Y1 = 0
        Me.TopLimit.Y2 = 0
        '
        'DownLimit
        '
        Me.DownLimit.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.DownLimit.BorderWidth = 5
        Me.DownLimit.Name = "DownLimit"
        Me.DownLimit.X1 = 0
        Me.DownLimit.X2 = 620
        Me.DownLimit.Y1 = 405
        Me.DownLimit.Y2 = 405
        '
        'RightLimit
        '
        Me.RightLimit.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.RightLimit.BorderWidth = 5
        Me.RightLimit.Name = "RightLimit"
        Me.RightLimit.X1 = 619
        Me.RightLimit.X2 = 619
        Me.RightLimit.Y1 = 0
        Me.RightLimit.Y2 = 406
        '
        'LeftLimit
        '
        Me.LeftLimit.BorderColor = System.Drawing.SystemColors.ControlDarkDark
        Me.LeftLimit.BorderWidth = 5
        Me.LeftLimit.Name = "LeftLimit"
        Me.LeftLimit.X1 = 0
        Me.LeftLimit.X2 = 0
        Me.LeftLimit.Y1 = 0
        Me.LeftLimit.Y2 = 406
        '
        'Snake_head
        '
        Me.Snake_head.BackColor = System.Drawing.Color.Green
        Me.Snake_head.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque
        Me.Snake_head.BorderColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Snake_head.Location = New System.Drawing.Point(453, 107)
        Me.Snake_head.Name = "Snake_head"
        Me.Snake_head.Size = New System.Drawing.Size(44, 42)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Controls.Add(Me.ShapeContainer1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(620, 406)
        Me.Panel1.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 516)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StartCmd)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SnakeMoving As System.Windows.Forms.Timer
    Friend WithEvents StartCmd As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents TopLimit As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents DownLimit As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents RightLimit As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LeftLimit As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents Snake_head As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
