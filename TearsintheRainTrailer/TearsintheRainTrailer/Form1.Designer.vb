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
        Me.Wall11 = New System.Windows.Forms.PictureBox()
        Me.Wall8 = New System.Windows.Forms.PictureBox()
        Me.Wall5 = New System.Windows.Forms.PictureBox()
        Me.Wall1 = New System.Windows.Forms.PictureBox()
        Me.Door2 = New System.Windows.Forms.PictureBox()
        Me.Floor1 = New System.Windows.Forms.PictureBox()
        Me.Floor4 = New System.Windows.Forms.PictureBox()
        Me.Wall12 = New System.Windows.Forms.PictureBox()
        Me.Wall9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Reveal2 = New System.Windows.Forms.PictureBox()
        Me.Reveal4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.Enemy1 = New System.Windows.Forms.PictureBox()
        Me.Enemy2 = New System.Windows.Forms.PictureBox()
        Me.Reveal1 = New System.Windows.Forms.PictureBox()
        Me.Reveal3 = New System.Windows.Forms.PictureBox()
        Me.Floor2 = New System.Windows.Forms.PictureBox()
        Me.Floor3 = New System.Windows.Forms.PictureBox()
        Me.Wall4 = New System.Windows.Forms.PictureBox()
        Me.Wall6 = New System.Windows.Forms.PictureBox()
        Me.Wall2 = New System.Windows.Forms.PictureBox()
        Me.Wall13 = New System.Windows.Forms.PictureBox()
        Me.Wall16 = New System.Windows.Forms.PictureBox()
        Me.Door1 = New System.Windows.Forms.PictureBox()
        Me.Wall17 = New System.Windows.Forms.PictureBox()
        Me.lblConsole = New System.Windows.Forms.Label()
        Me.lblHackTerminal = New System.Windows.Forms.Label()
        CType(Me.Player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Door2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reveal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reveal4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reveal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Reveal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Floor3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Door1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wall17, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Player.Location = New System.Drawing.Point(53, 315)
        Me.Player.Name = "Player"
        Me.Player.Size = New System.Drawing.Size(42, 76)
        Me.Player.TabIndex = 10
        Me.Player.TabStop = False
        '
        'Wall11
        '
        Me.Wall11.BackColor = System.Drawing.Color.DarkGray
        Me.Wall11.Location = New System.Drawing.Point(708, 274)
        Me.Wall11.Name = "Wall11"
        Me.Wall11.Size = New System.Drawing.Size(16, 314)
        Me.Wall11.TabIndex = 25
        Me.Wall11.TabStop = False
        '
        'Wall8
        '
        Me.Wall8.BackColor = System.Drawing.Color.DimGray
        Me.Wall8.Location = New System.Drawing.Point(486, 274)
        Me.Wall8.Name = "Wall8"
        Me.Wall8.Size = New System.Drawing.Size(238, 82)
        Me.Wall8.TabIndex = 21
        Me.Wall8.TabStop = False
        '
        'Wall5
        '
        Me.Wall5.BackColor = System.Drawing.Color.DarkGray
        Me.Wall5.Location = New System.Drawing.Point(486, 30)
        Me.Wall5.Name = "Wall5"
        Me.Wall5.Size = New System.Drawing.Size(16, 558)
        Me.Wall5.TabIndex = 15
        Me.Wall5.TabStop = False
        '
        'Wall1
        '
        Me.Wall1.BackColor = System.Drawing.Color.DarkGray
        Me.Wall1.Location = New System.Drawing.Point(31, 30)
        Me.Wall1.Name = "Wall1"
        Me.Wall1.Size = New System.Drawing.Size(16, 551)
        Me.Wall1.TabIndex = 11
        Me.Wall1.TabStop = False
        '
        'Door2
        '
        Me.Door2.BackColor = System.Drawing.Color.Firebrick
        Me.Door2.Location = New System.Drawing.Point(433, 210)
        Me.Door2.Name = "Door2"
        Me.Door2.Size = New System.Drawing.Size(55, 76)
        Me.Door2.TabIndex = 30
        Me.Door2.TabStop = False
        '
        'Floor1
        '
        Me.Floor1.BackColor = System.Drawing.Color.LightGray
        Me.Floor1.Location = New System.Drawing.Point(47, 245)
        Me.Floor1.Name = "Floor1"
        Me.Floor1.Size = New System.Drawing.Size(54, 400)
        Me.Floor1.TabIndex = 31
        Me.Floor1.TabStop = False
        '
        'Floor4
        '
        Me.Floor4.BackColor = System.Drawing.Color.LightGray
        Me.Floor4.Location = New System.Drawing.Point(502, 349)
        Me.Floor4.Name = "Floor4"
        Me.Floor4.Size = New System.Drawing.Size(207, 239)
        Me.Floor4.TabIndex = 34
        Me.Floor4.TabStop = False
        '
        'Wall12
        '
        Me.Wall12.BackColor = System.Drawing.Color.DarkGray
        Me.Wall12.Location = New System.Drawing.Point(502, 258)
        Me.Wall12.Name = "Wall12"
        Me.Wall12.Size = New System.Drawing.Size(222, 16)
        Me.Wall12.TabIndex = 35
        Me.Wall12.TabStop = False
        '
        'Wall9
        '
        Me.Wall9.BackColor = System.Drawing.Color.DimGray
        Me.Wall9.Location = New System.Drawing.Point(101, 581)
        Me.Wall9.Name = "Wall9"
        Me.Wall9.Size = New System.Drawing.Size(623, 64)
        Me.Wall9.TabIndex = 26
        Me.Wall9.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DarkGray
        Me.PictureBox1.Location = New System.Drawing.Point(115, 565)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(609, 16)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'Reveal2
        '
        Me.Reveal2.Location = New System.Drawing.Point(115, 287)
        Me.Reveal2.Name = "Reveal2"
        Me.Reveal2.Size = New System.Drawing.Size(387, 358)
        Me.Reveal2.TabIndex = 39
        Me.Reveal2.TabStop = False
        '
        'Reveal4
        '
        Me.Reveal4.Location = New System.Drawing.Point(502, 258)
        Me.Reveal4.Name = "Reveal4"
        Me.Reveal4.Size = New System.Drawing.Size(222, 387)
        Me.Reveal4.TabIndex = 41
        Me.Reveal4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.DimGray
        Me.PictureBox2.Location = New System.Drawing.Point(31, 581)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(18, 64)
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.OrangeRed
        Me.PictureBox3.Location = New System.Drawing.Point(115, 365)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(41, 69)
        Me.PictureBox3.TabIndex = 44
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(224, 290)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(129, 114)
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.SaddleBrown
        Me.PictureBox5.Location = New System.Drawing.Point(181, 515)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(225, 50)
        Me.PictureBox5.TabIndex = 46
        Me.PictureBox5.TabStop = False
        '
        'Enemy1
        '
        Me.Enemy1.BackColor = System.Drawing.Color.Gold
        Me.Enemy1.Location = New System.Drawing.Point(311, 112)
        Me.Enemy1.Name = "Enemy1"
        Me.Enemy1.Size = New System.Drawing.Size(42, 76)
        Me.Enemy1.TabIndex = 47
        Me.Enemy1.TabStop = False
        '
        'Enemy2
        '
        Me.Enemy2.BackColor = System.Drawing.Color.Gold
        Me.Enemy2.Location = New System.Drawing.Point(364, 412)
        Me.Enemy2.Name = "Enemy2"
        Me.Enemy2.Size = New System.Drawing.Size(42, 76)
        Me.Enemy2.TabIndex = 48
        Me.Enemy2.TabStop = False
        '
        'Reveal1
        '
        Me.Reveal1.Location = New System.Drawing.Point(31, 19)
        Me.Reveal1.Name = "Reveal1"
        Me.Reveal1.Size = New System.Drawing.Size(471, 191)
        Me.Reveal1.TabIndex = 38
        Me.Reveal1.TabStop = False
        '
        'Reveal3
        '
        Me.Reveal3.Location = New System.Drawing.Point(115, 19)
        Me.Reveal3.Name = "Reveal3"
        Me.Reveal3.Size = New System.Drawing.Size(387, 271)
        Me.Reveal3.TabIndex = 40
        Me.Reveal3.TabStop = False
        '
        'Floor2
        '
        Me.Floor2.BackColor = System.Drawing.Color.LightGray
        Me.Floor2.Location = New System.Drawing.Point(47, 90)
        Me.Floor2.Name = "Floor2"
        Me.Floor2.Size = New System.Drawing.Size(455, 120)
        Me.Floor2.TabIndex = 32
        Me.Floor2.TabStop = False
        '
        'Floor3
        '
        Me.Floor3.BackColor = System.Drawing.Color.LightGray
        Me.Floor3.Location = New System.Drawing.Point(115, 210)
        Me.Floor3.Name = "Floor3"
        Me.Floor3.Size = New System.Drawing.Size(373, 378)
        Me.Floor3.TabIndex = 33
        Me.Floor3.TabStop = False
        '
        'Wall4
        '
        Me.Wall4.BackColor = System.Drawing.Color.DimGray
        Me.Wall4.Location = New System.Drawing.Point(101, 210)
        Me.Wall4.Name = "Wall4"
        Me.Wall4.Size = New System.Drawing.Size(333, 76)
        Me.Wall4.TabIndex = 17
        Me.Wall4.TabStop = False
        '
        'Wall6
        '
        Me.Wall6.BackColor = System.Drawing.Color.DimGray
        Me.Wall6.Location = New System.Drawing.Point(31, 30)
        Me.Wall6.Name = "Wall6"
        Me.Wall6.Size = New System.Drawing.Size(471, 76)
        Me.Wall6.TabIndex = 16
        Me.Wall6.TabStop = False
        '
        'Wall2
        '
        Me.Wall2.BackColor = System.Drawing.Color.DarkGray
        Me.Wall2.Location = New System.Drawing.Point(101, 210)
        Me.Wall2.Name = "Wall2"
        Me.Wall2.Size = New System.Drawing.Size(16, 378)
        Me.Wall2.TabIndex = 12
        Me.Wall2.TabStop = False
        '
        'Wall13
        '
        Me.Wall13.BackColor = System.Drawing.Color.DarkGray
        Me.Wall13.Location = New System.Drawing.Point(47, 194)
        Me.Wall13.Name = "Wall13"
        Me.Wall13.Size = New System.Drawing.Size(441, 16)
        Me.Wall13.TabIndex = 36
        Me.Wall13.TabStop = False
        '
        'Wall16
        '
        Me.Wall16.BackColor = System.Drawing.Color.DarkGray
        Me.Wall16.Location = New System.Drawing.Point(31, 19)
        Me.Wall16.Name = "Wall16"
        Me.Wall16.Size = New System.Drawing.Size(471, 16)
        Me.Wall16.TabIndex = 43
        Me.Wall16.TabStop = False
        '
        'Door1
        '
        Me.Door1.BackColor = System.Drawing.Color.Firebrick
        Me.Door1.Location = New System.Drawing.Point(47, 210)
        Me.Door1.Name = "Door1"
        Me.Door1.Size = New System.Drawing.Size(54, 76)
        Me.Door1.TabIndex = 29
        Me.Door1.TabStop = False
        '
        'Wall17
        '
        Me.Wall17.BackColor = System.Drawing.Color.DimGray
        Me.Wall17.Location = New System.Drawing.Point(115, 210)
        Me.Wall17.Name = "Wall17"
        Me.Wall17.Size = New System.Drawing.Size(319, 1)
        Me.Wall17.TabIndex = 49
        Me.Wall17.TabStop = False
        '
        'lblConsole
        '
        Me.lblConsole.AutoSize = True
        Me.lblConsole.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblConsole.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblConsole.Location = New System.Drawing.Point(730, 365)
        Me.lblConsole.Name = "lblConsole"
        Me.lblConsole.Size = New System.Drawing.Size(0, 13)
        Me.lblConsole.TabIndex = 51
        '
        'lblHackTerminal
        '
        Me.lblHackTerminal.AutoSize = True
        Me.lblHackTerminal.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHackTerminal.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblHackTerminal.Location = New System.Drawing.Point(730, 30)
        Me.lblHackTerminal.Name = "lblHackTerminal"
        Me.lblHackTerminal.Size = New System.Drawing.Size(0, 13)
        Me.lblHackTerminal.TabIndex = 52
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(970, 646)
        Me.Controls.Add(Me.lblHackTerminal)
        Me.Controls.Add(Me.lblConsole)
        Me.Controls.Add(Me.Wall17)
        Me.Controls.Add(Me.Enemy2)
        Me.Controls.Add(Me.Enemy1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Door2)
        Me.Controls.Add(Me.Door1)
        Me.Controls.Add(Me.Wall16)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Wall13)
        Me.Controls.Add(Me.Wall12)
        Me.Controls.Add(Me.Wall9)
        Me.Controls.Add(Me.Wall2)
        Me.Controls.Add(Me.Wall5)
        Me.Controls.Add(Me.Wall1)
        Me.Controls.Add(Me.Player)
        Me.Controls.Add(Me.Wall11)
        Me.Controls.Add(Me.Wall8)
        Me.Controls.Add(Me.Wall6)
        Me.Controls.Add(Me.Floor1)
        Me.Controls.Add(Me.Wall4)
        Me.Controls.Add(Me.Floor3)
        Me.Controls.Add(Me.Reveal2)
        Me.Controls.Add(Me.Floor2)
        Me.Controls.Add(Me.Reveal3)
        Me.Controls.Add(Me.Reveal1)
        Me.Controls.Add(Me.Floor4)
        Me.Controls.Add(Me.Reveal4)
        Me.Name = "Form1"
        Me.Text = "Tears in the Rain"
        CType(Me.Player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Door2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reveal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reveal4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Enemy2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reveal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Reveal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Floor3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Door1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wall17, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Player As PictureBox
    Friend WithEvents Wall1 As PictureBox
    Friend WithEvents GameLoop As Timer
    Friend WithEvents Wall5 As PictureBox
    Friend WithEvents Wall8 As PictureBox
    Friend WithEvents Wall11 As PictureBox
    Friend WithEvents AnimationTimer As Timer
    Friend WithEvents Door2 As PictureBox
    Friend WithEvents Floor1 As PictureBox
    Friend WithEvents Floor4 As PictureBox
    Friend WithEvents Wall12 As PictureBox
    Friend WithEvents Wall9 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Reveal2 As PictureBox
    Friend WithEvents Reveal4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Enemy1 As PictureBox
    Friend WithEvents Enemy2 As PictureBox
    Friend WithEvents Reveal1 As PictureBox
    Friend WithEvents Reveal3 As PictureBox
    Friend WithEvents Floor2 As PictureBox
    Friend WithEvents Floor3 As PictureBox
    Friend WithEvents Wall4 As PictureBox
    Friend WithEvents Wall6 As PictureBox
    Friend WithEvents Wall2 As PictureBox
    Friend WithEvents Wall13 As PictureBox
    Friend WithEvents Wall16 As PictureBox
    Friend WithEvents Door1 As PictureBox
    Friend WithEvents Wall17 As PictureBox
    Friend WithEvents lblConsole As Label
    Friend WithEvents lblHackTerminal As Label
End Class
