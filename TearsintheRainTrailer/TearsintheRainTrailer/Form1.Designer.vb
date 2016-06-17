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
        Me.components = New System.ComponentModel.Container()
        Me.GameLoop = New System.Windows.Forms.Timer(Me.components)
        Me.AnimationTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Player = New System.Windows.Forms.PictureBox()
        Me.Wall10 = New System.Windows.Forms.PictureBox()
        Me.Wall9 = New System.Windows.Forms.PictureBox()
        Me.Wall11 = New System.Windows.Forms.PictureBox()
        Me.Wall8 = New System.Windows.Forms.PictureBox()
        Me.Wall7 = New System.Windows.Forms.PictureBox()
        Me.Wall4 = New System.Windows.Forms.PictureBox()
        Me.Wall6 = New System.Windows.Forms.PictureBox()
        Me.Wall5 = New System.Windows.Forms.PictureBox()
        Me.Wall3 = New System.Windows.Forms.PictureBox()
        Me.Wall2 = New System.Windows.Forms.PictureBox()
        Me.Wall1 = New System.Windows.Forms.PictureBox()
        Me.Reveal2 = New System.Windows.Forms.PictureBox()
        Me.Reveal1 = New System.Windows.Forms.PictureBox()
        Me.Reveal3 = New System.Windows.Forms.PictureBox()
        Me.Background = New System.Windows.Forms.PictureBox()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reveal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reveal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reveal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GameLoop
        '
        '
        'AnimationTimer
        '
        Me.AnimationTimer.Interval = 200
        '
        'Player
        '
        Me.Player.BackColor = System.Drawing.Color.Transparent
        Me.Player.Image = Global.TearsintheRainTrailer.My.Resources.Resources.Character_21
        Me.Player.Location = New System.Drawing.Point(61, 473)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(42, 76)
        Me.Player.TabIndex = 10
        Me.Player.TabStop = False
        '
        'Wall10
        '
        Me.Wall10.BackColor = System.Drawing.Color.DimGray
        Me.Wall10.Location = New System.Drawing.Point(494, 370)
        Me.Wall10.Name = "Wall10"
        Me.Wall10.Size = New System.Drawing.Size(16, 78)
        Me.Wall10.TabIndex = 27
        Me.Wall10.TabStop = False
        '
        'Wall9
        '
        Me.Wall9.BackColor = System.Drawing.Color.DimGray
        Me.Wall9.Location = New System.Drawing.Point(272, 533)
        Me.Wall9.Name = "Wall9"
        Me.Wall9.Size = New System.Drawing.Size(460, 16)
        Me.Wall9.TabIndex = 26
        Me.Wall9.TabStop = False
        '
        'Wall11
        '
        Me.Wall11.BackColor = System.Drawing.Color.DimGray
        Me.Wall11.Location = New System.Drawing.Point(716, 370)
        Me.Wall11.Name = "Wall11"
        Me.Wall11.Size = New System.Drawing.Size(16, 179)
        Me.Wall11.TabIndex = 25
        Me.Wall11.TabStop = False
        '
        'Wall8
        '
        Me.Wall8.BackColor = System.Drawing.Color.DimGray
        Me.Wall8.Location = New System.Drawing.Point(494, 369)
        Me.Wall8.Name = "Wall8"
        Me.Wall8.Size = New System.Drawing.Size(238, 16)
        Me.Wall8.TabIndex = 21
        Me.Wall8.TabStop = False
        '
        'Wall7
        '
        Me.Wall7.BackColor = System.Drawing.Color.DimGray
        Me.Wall7.Location = New System.Drawing.Point(272, 206)
        Me.Wall7.Name = "Wall7"
        Me.Wall7.Size = New System.Drawing.Size(16, 343)
        Me.Wall7.TabIndex = 19
        Me.Wall7.TabStop = False
        '
        'Wall4
        '
        Me.Wall4.BackColor = System.Drawing.Color.DimGray
        Me.Wall4.Location = New System.Drawing.Point(109, 190)
        Me.Wall4.Name = "Wall4"
        Me.Wall4.Size = New System.Drawing.Size(333, 16)
        Me.Wall4.TabIndex = 17
        Me.Wall4.TabStop = False
        '
        'Wall6
        '
        Me.Wall6.BackColor = System.Drawing.Color.DimGray
        Me.Wall6.Location = New System.Drawing.Point(39, 61)
        Me.Wall6.Name = "Wall6"
        Me.Wall6.Size = New System.Drawing.Size(471, 16)
        Me.Wall6.TabIndex = 16
        Me.Wall6.TabStop = False
        '
        'Wall5
        '
        Me.Wall5.BackColor = System.Drawing.Color.DimGray
        Me.Wall5.Location = New System.Drawing.Point(494, 76)
        Me.Wall5.Name = "Wall5"
        Me.Wall5.Size = New System.Drawing.Size(16, 309)
        Me.Wall5.TabIndex = 15
        Me.Wall5.TabStop = False
        '
        'Wall3
        '
        Me.Wall3.BackColor = System.Drawing.Color.DimGray
        Me.Wall3.Location = New System.Drawing.Point(39, 76)
        Me.Wall3.Name = "Wall3"
        Me.Wall3.Size = New System.Drawing.Size(16, 130)
        Me.Wall3.TabIndex = 14
        Me.Wall3.TabStop = False
        '
        'Wall2
        '
        Me.Wall2.BackColor = System.Drawing.Color.DimGray
        Me.Wall2.Location = New System.Drawing.Point(109, 206)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(16, 343)
        Me.Wall2.TabIndex = 12
        Me.Wall2.TabStop = False
        '
        'Wall1
        '
        Me.Wall1.BackColor = System.Drawing.Color.DimGray
        Me.Wall1.Location = New System.Drawing.Point(39, 206)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(16, 343)
        Me.Wall1.TabIndex = 11
        Me.Wall1.TabStop = False
        '
        'Reveal2
        '
        Me.Reveal2.Location = New System.Drawing.Point(272, 206)
        Me.Reveal2.Name = "Reveal2"
        Me.Reveal2.Size = New System.Drawing.Size(238, 343)
        Me.Reveal2.TabIndex = 24
        Me.Reveal2.TabStop = False
        '
        'Reveal1
        '
        Me.Reveal1.Location = New System.Drawing.Point(39, 61)
        Me.Reveal1.Name = "Reveal1"
        Me.Reveal1.Size = New System.Drawing.Size(471, 145)
        Me.Reveal1.TabIndex = 23
        Me.Reveal1.TabStop = False
        '
        'Reveal3
        '
        Me.Reveal3.Location = New System.Drawing.Point(510, 369)
        Me.Reveal3.Name = "Reveal3"
        Me.Reveal3.Size = New System.Drawing.Size(222, 180)
        Me.Reveal3.TabIndex = 28
        Me.Reveal3.TabStop = False
        '
        'Background
        '
        Me.Background.Location = New System.Drawing.Point(1, 0)
        Me.Background.Name = "Background"
        Me.Background.Size = New System.Drawing.Size(950, 584)
        Me.Background.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Background.TabIndex = 18
        Me.Background.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(954, 561)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Wall10)
        Me.Controls.Add(Me.Wall9)
        Me.Controls.Add(Me.Wall11)
        Me.Controls.Add(Me.Wall8)
        Me.Controls.Add(Me.Wall7)
        Me.Controls.Add(Me.Wall4)
        Me.Controls.Add(Me.Wall6)
        Me.Controls.Add(Me.Wall5)
        Me.Controls.Add(Me.Wall3)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Wall1)
        Me.Controls.Add(Me.Reveal2)
        Me.Controls.Add(Me.Reveal1)
        Me.Controls.Add(Me.Reveal3)
        Me.Controls.Add(Me.Background)
        Me.Name = "Form1"
        Me.Text = "Tears in the Rain"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reveal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reveal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reveal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Player As PictureBox
    Friend WithEvents Wall1 As PictureBox
    Friend WithEvents Wall2 As PictureBox
    Friend WithEvents GameLoop As Timer
    Friend WithEvents Wall3 As PictureBox
    Friend WithEvents Wall5 As PictureBox
    Friend WithEvents Wall6 As PictureBox
    Friend WithEvents Wall4 As PictureBox
    Friend WithEvents Background As PictureBox
    Friend WithEvents Wall7 As PictureBox
    Friend WithEvents Wall8 As PictureBox
    Friend WithEvents Reveal1 As PictureBox
    Friend WithEvents Reveal2 As PictureBox
    Friend WithEvents Wall11 As PictureBox
    Friend WithEvents Wall9 As PictureBox
    Friend WithEvents Wall10 As PictureBox
    Friend WithEvents Reveal3 As PictureBox
    Friend WithEvents AnimationTimer As Timer
End Class
