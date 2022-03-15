<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
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

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Snake_move = New System.Windows.Forms.Timer(Me.components)
        Me.StartCmd = New System.Windows.Forms.Button()
        Me.ScoreLbl = New System.Windows.Forms.Label()
        Me.Background = New System.Windows.Forms.PictureBox()
        Me.LevelLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NextLevel_scoreLbl = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Snake_move
        '
        '
        'StartCmd
        '
        Me.StartCmd.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.StartCmd.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StartCmd.Location = New System.Drawing.Point(881, 449)
        Me.StartCmd.Name = "StartCmd"
        Me.StartCmd.Size = New System.Drawing.Size(180, 51)
        Me.StartCmd.TabIndex = 1
        Me.StartCmd.Text = "Start"
        Me.StartCmd.UseVisualStyleBackColor = False
        '
        'ScoreLbl
        '
        Me.ScoreLbl.AutoSize = True
        Me.ScoreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreLbl.ForeColor = System.Drawing.Color.RoyalBlue
        Me.ScoreLbl.Location = New System.Drawing.Point(939, 46)
        Me.ScoreLbl.Name = "ScoreLbl"
        Me.ScoreLbl.Size = New System.Drawing.Size(36, 37)
        Me.ScoreLbl.TabIndex = 4
        Me.ScoreLbl.Text = "0"
        Me.ScoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Background
        '
        Me.Background.BackgroundImage = Global.Snake_Game__1._1_.My.Resources.Resources.Background
        Me.Background.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Background.Location = New System.Drawing.Point(0, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(875, 500)
        Me.Background.TabIndex = 2
        Me.Background.TabStop = False
        '
        'LevelLbl
        '
        Me.LevelLbl.AutoSize = True
        Me.LevelLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LevelLbl.ForeColor = System.Drawing.Color.Maroon
        Me.LevelLbl.Location = New System.Drawing.Point(939, 121)
        Me.LevelLbl.Name = "LevelLbl"
        Me.LevelLbl.Size = New System.Drawing.Size(34, 37)
        Me.LevelLbl.TabIndex = 5
        Me.LevelLbl.Text = "1"
        Me.LevelLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(913, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 37)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Score"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(913, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 37)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Level"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(881, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 58)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Score for the" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "next level"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NextLevel_scoreLbl
        '
        Me.NextLevel_scoreLbl.AutoSize = True
        Me.NextLevel_scoreLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NextLevel_scoreLbl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.NextLevel_scoreLbl.Location = New System.Drawing.Point(941, 224)
        Me.NextLevel_scoreLbl.Name = "NextLevel_scoreLbl"
        Me.NextLevel_scoreLbl.Size = New System.Drawing.Size(41, 29)
        Me.NextLevel_scoreLbl.TabIndex = 7
        Me.NextLevel_scoreLbl.Text = "10"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(881, 292)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 29)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Bonus"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(889, 324)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(49, 31)
        Me.NumericUpDown1.TabIndex = 8
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(1069, 506)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NextLevel_scoreLbl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LevelLbl)
        Me.Controls.Add(Me.ScoreLbl)
        Me.Controls.Add(Me.Background)
        Me.Controls.Add(Me.StartCmd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Snake by ZYan"
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Snake_move As Timer
    Friend WithEvents StartCmd As Button
    Friend WithEvents Background As PictureBox
    Friend WithEvents ScoreLbl As Label
    Friend WithEvents LevelLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents NextLevel_scoreLbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
End Class
