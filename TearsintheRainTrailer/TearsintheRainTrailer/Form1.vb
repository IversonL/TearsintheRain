Public Class Form1
    Dim environment() As PictureBox
    Dim revealArray() As PictureBox
    Dim dir As Integer = 0
    Dim moveing As Boolean = False
    Dim tick As Integer = 0
    Dim PluggedIn = False

    'Loads on Startup'
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GameLoop.Start()
        AnimationTimer.Start()
        environment = {Wall1, Wall2, Wall5, Wall8, Wall9, Wall11, Wall16, Wall17}
        revealArray = {Reveal1, Reveal2, Reveal3, Reveal4}

        For x As Integer = 0 To revealArray.Length - 1
            revealArray(x).BringToFront()
        Next
    End Sub

    'Handles call Keydown events
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Tab Then
            If PluggedIn = False Then
                PluggedIn = True
            ElseIf PluggedIn = True Then
                PluggedIn = False
            End If
        End If
        If PluggedIn = False Then
            moveing = True
            If e.KeyCode = Keys.A Then
                dir = 1
                Me.Player.Left -= 10
            ElseIf e.KeyCode = Keys.W Then
                dir = 2
                Me.Player.Top -= 10

            ElseIf e.KeyCode = Keys.D Then
                dir = 3
                Me.Player.Left += 10

            ElseIf e.KeyCode = Keys.S Then
                dir = 4
                Me.Player.Top += 10
            End If

            Call CollisionDetection()
        ElseIf PluggedIn = True Then
            Call ConsoleInput(e)
        End If

    End Sub

    'Handles all keyup events'
    Private Sub Form1_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        moveing = False
    End Sub

    'Animation Loop
    Private Sub AnimationTimer_Tick(sender As Object, e As EventArgs) Handles AnimationTimer.Tick
        tick += 1
    End Sub

    'Game Loop'
    Private Sub GameLoop_Tick(sender As Object, e As EventArgs) Handles GameLoop.Tick
        Call CollisionDetection()
        Call Reveal()
        Call AnimationPlayer()
    End Sub

    'Checks player collision
    Sub CollisionDetection()
        For x As Integer = 0 To environment.Length - 1
            If Player.Bounds.IntersectsWith(environment(x).Bounds) Then
                If dir = 1 Then
                    Me.Player.Left += 10
                ElseIf dir = 2 Then
                    Me.Player.Top += 10
                ElseIf dir = 3 Then
                    Me.Player.Left -= 10
                ElseIf dir = 4 Then
                    Me.Player.Top -= 10
                End If
            End If
        Next
    End Sub

    'Reveals Portions of the Map as the player walks around'
    Sub Reveal()
        For x As Integer = 0 To revealArray.Length - 1
            If Player.Bounds.IntersectsWith(revealArray(x).Bounds) Then
                revealArray(x).Hide()
            End If
        Next
    End Sub

    Sub AnimationPlayer()
        If moveing = False Then
            If dir = 1 Then
                Player.Image = My.Resources.Character_3
            ElseIf dir = 2 Then
                Player.Image = My.Resources.Character_21
            ElseIf dir = 3 Then
                Player.Image = My.Resources.Character_4
            ElseIf dir = 4 Then
                Player.Image = My.Resources.Character_11
            End If
        Else
            If dir = 1 Then
                If (tick Mod 2) = 0 Then
                    Player.Image = My.Resources.Walking_Left_1
                Else
                    Player.Image = My.Resources.Walking_Left_2
                End If
            ElseIf dir = 2 Then
                If (tick Mod 2) = 0 Then
                    Player.Image = My.Resources.Walking_Up_1
                Else
                    Player.Image = My.Resources.Walking_Up_2
                End If
            ElseIf dir = 3 Then
                If (tick Mod 2) = 0 Then
                    Player.Image = My.Resources.Walking_Right_1
                Else
                    Player.Image = My.Resources.Walking_Right_2
                End If
            ElseIf dir = 4 Then
                If (tick Mod 2) = 0 Then
                    Player.Image = My.Resources.Walking_Down_1
                Else
                    Player.Image = My.Resources.Walking_Down_2
                End If

            End If
        End If

    End Sub

    Sub ConsoleInput(ByRef sender As KeyEventArgs)
        If sender.KeyCode = Keys.Escape Then
            Me.lblConsole.Text = Nothing
        Else
            Me.lblConsole.Text &= Chr(sender.KeyCode)
        End If
    End Sub
End Class
