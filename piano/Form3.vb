
Public Class Form3

    Private Sub Form3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.A Then
            Me.Button1.PerformClick()
            PictureBox1.Visible = True

        End If
        If e.KeyCode = Keys.S Then
            Me.Button2.PerformClick()
            PictureBox2.Visible = True

        End If
        If e.KeyCode = Keys.D Then
            Me.Button3.PerformClick()
            PictureBox3.Visible = True

        End If
        If e.KeyCode = Keys.F Then
            Me.Button4.PerformClick()
            PictureBox4.Visible = True

        End If
        If e.KeyCode = Keys.G Then
            Me.Button8.PerformClick()
            PictureBox8.Visible = True

        End If
        If e.KeyCode = Keys.H Then
            Me.Button6.PerformClick()
            PictureBox6.Visible = True

        End If
        If e.KeyCode = Keys.J Then
            Me.Button5.PerformClick()
            PictureBox5.Visible = True

        End If
        If e.KeyCode = Keys.K Then
            Me.Button12.PerformClick()
            PictureBox12.Visible = True

        End If
        If e.KeyCode = Keys.L Then
            Me.Button11.PerformClick()
            PictureBox11.Visible = True

        End If
        If e.KeyCode = Keys.Q Then
            Me.Button10.PerformClick()
            PictureBox10.Visible = True

        End If
        If e.KeyCode = Keys.W Then
            Me.Button14.PerformClick()
            PictureBox18.Visible = True

        End If
        If e.KeyCode = Keys.E Then
            Me.Button15.PerformClick()
            PictureBox17.Visible = True

        End If
        If e.KeyCode = Keys.R Then
            Me.Button16.PerformClick()
            PictureBox15.Visible = True

        End If
        If e.KeyCode = Keys.T Then
            Me.Button17.PerformClick()
            PictureBox14.Visible = True

        End If
        If e.KeyCode = Keys.Y Then
            Me.Button18.PerformClick()
            PictureBox13.Visible = True

        End If
        If e.KeyCode = Keys.U Then
            Me.Button13.PerformClick()
            PictureBox6.Visible = True

        End If
        If e.KeyCode = Keys.I Then
            Me.Button9.PerformClick()
            PictureBox9.Visible = True

        End If

    End Sub

    Private Sub Form3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        If e.KeyCode = Keys.A Then

            PictureBox1.Visible = False

        End If
        If e.KeyCode = Keys.S Then

            PictureBox2.Visible = False

        End If
        If e.KeyCode = Keys.D Then

            PictureBox3.Visible = False

        End If
        If e.KeyCode = Keys.F Then

            PictureBox4.Visible = False

        End If
        If e.KeyCode = Keys.G Then

            PictureBox8.Visible = False

        End If
        If e.KeyCode = Keys.H Then

            PictureBox6.Visible = False

        End If
        If e.KeyCode = Keys.J Then

            PictureBox5.Visible = False

        End If
        If e.KeyCode = Keys.K Then

            PictureBox12.Visible = False

        End If
        If e.KeyCode = Keys.L Then

            PictureBox11.Visible = False

        End If
        If e.KeyCode = Keys.Q Then

            PictureBox10.Visible = False

        End If
        If e.KeyCode = Keys.W Then

            PictureBox18.Visible = False

        End If
        If e.KeyCode = Keys.E Then

            PictureBox17.Visible = False

        End If
        If e.KeyCode = Keys.R Then

            PictureBox15.Visible = False

        End If
        If e.KeyCode = Keys.T Then

            PictureBox14.Visible = False

        End If
        If e.KeyCode = Keys.Y Then

            PictureBox13.Visible = False

        End If
        If e.KeyCode = Keys.U Then

            PictureBox6.Visible = False

        End If
        If e.KeyCode = Keys.I Then

            PictureBox9.Visible = False

        End If
    End Sub


    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        PictureBox7.Visible = False
        PictureBox8.Visible = False
        PictureBox9.Visible = False
        PictureBox10.Visible = False
        PictureBox11.Visible = False
        PictureBox12.Visible = False
        PictureBox13.Visible = False
        PictureBox14.Visible = False
        PictureBox15.Visible = False
        PictureBox16.Visible = False
        PictureBox17.Visible = False
        PictureBox18.Visible = False
    End Sub

    Private Sub Button1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseEnter
        PictureBox1.Visible = True
    End Sub

    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.MouseLeave
        PictureBox1.Visible = False
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        My.Computer.Audio.Play(My.Resources.c, AudioPlayMode.Background)





    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        My.Computer.Audio.Play(My.Resources.d, AudioPlayMode.Background)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        My.Computer.Audio.Play(My.Resources._e, AudioPlayMode.Background)

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        My.Computer.Audio.Play(My.Resources.f, AudioPlayMode.Background)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click

        My.Computer.Audio.Play(My.Resources.g, AudioPlayMode.Background)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click

        My.Computer.Audio.Play(My.Resources.a, AudioPlayMode.Background)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click

        My.Computer.Audio.Play(My.Resources.b, AudioPlayMode.Background)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

        My.Computer.Audio.Play(My.Resources._c, AudioPlayMode.Background)

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click

        My.Computer.Audio.Play(My.Resources.d, AudioPlayMode.Background)

    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click

        My.Computer.Audio.Play(My.Resources.eb, AudioPlayMode.Background)

    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click

        My.Computer.Audio.Play(My.Resources.f, AudioPlayMode.Background)

    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click

        My.Computer.Audio.Play(My.Resources._c, AudioPlayMode.Background)

    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click

        My.Computer.Audio.Play(My.Resources.d, AudioPlayMode.Background)

    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click

        My.Computer.Audio.Play(My.Resources.f, AudioPlayMode.Background)

    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click

        My.Computer.Audio.Play(My.Resources.g_, AudioPlayMode.Background)

    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click

        My.Computer.Audio.Play(My.Resources.bb, AudioPlayMode.Background)

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click

        My.Computer.Audio.Play(My.Resources._c, AudioPlayMode.Background)

    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click

        My.Computer.Audio.Play(My.Resources.d, AudioPlayMode.Background)

    End Sub

    Private Sub Button2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseEnter
        PictureBox2.Visible = True
    End Sub

    Private Sub Button2_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.MouseLeave
        PictureBox2.Visible = False
    End Sub

    Private Sub Button3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseEnter
        PictureBox3.Visible = True

    End Sub

    Private Sub Button3_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.MouseLeave
        PictureBox3.Visible = False
    End Sub

    Private Sub Button4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseEnter
        PictureBox4.Visible = True
    End Sub

    Private Sub Button4_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.MouseLeave
        PictureBox4.Visible = False
    End Sub

    Private Sub Button8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseEnter
        PictureBox8.Visible = True
    End Sub

    Private Sub Button8_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button8.MouseLeave
        PictureBox8.Visible = False

    End Sub

    Private Sub Button7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseEnter
        PictureBox7.Visible = True

    End Sub

    Private Sub Button7_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button7.MouseLeave
        PictureBox7.Visible = False

    End Sub

    Private Sub Button6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseEnter
        PictureBox6.Visible = True

    End Sub

    Private Sub Button6_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.MouseLeave
        PictureBox6.Visible = False

    End Sub

    Private Sub Button5_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseEnter
        PictureBox5.Visible = True

    End Sub

    Private Sub Button5_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.MouseLeave
        PictureBox5.Visible = False

    End Sub

    Private Sub Button12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseEnter
        PictureBox12.Visible = True

    End Sub

    Private Sub Button12_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button12.MouseLeave
        PictureBox12.Visible = False

    End Sub

    Private Sub Button11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseEnter
        PictureBox11.Visible = True

    End Sub

    Private Sub Button11_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button11.MouseLeave
        PictureBox11.Visible = False

    End Sub

    Private Sub Button10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseEnter
        PictureBox10.Visible = True

    End Sub

    Private Sub Button10_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button10.MouseLeave
        PictureBox10.Visible = False

    End Sub


    Private Sub Button14_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseEnter
        PictureBox18.Visible = True

    End Sub

    Private Sub Button14_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button14.MouseLeave
        PictureBox18.Visible = False
    End Sub

    Private Sub Button15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseEnter
        PictureBox17.Visible = True
    End Sub

    Private Sub Button15_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button15.MouseLeave
        PictureBox17.Visible = False
    End Sub

    Private Sub Button16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.MouseEnter
        PictureBox15.Visible = True
    End Sub

    Private Sub Button16_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button16.MouseLeave
        PictureBox15.Visible = False
    End Sub

    Private Sub Button17_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseEnter
        PictureBox14.Visible = True
    End Sub

    Private Sub Button17_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button17.MouseLeave
        PictureBox14.Visible = False
    End Sub



    Private Sub Button18_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.MouseEnter
        PictureBox13.Visible = True
    End Sub

    Private Sub Button18_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button18.MouseLeave
        PictureBox13.Visible = False
    End Sub

    Private Sub Button13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseEnter
        PictureBox16.Visible = True
    End Sub

    Private Sub Button13_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button13.MouseLeave
        PictureBox16.Visible = False
    End Sub

    Private Sub Button9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseEnter
        PictureBox9.Visible = True
    End Sub

    Private Sub Button9_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button9.MouseLeave
        PictureBox9.Visible = False
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        If RadioButton1.Checked = True Then
            My.Computer.Audio.Play(My.Resources._325611__shadydave__my_love_piano_loop, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Play(My.Resources._110216__cheesepuff__sad_song, AudioPlayMode.Background)
        End If
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button20.Click
        My.Computer.Audio.Play(My.Resources.Windows_Exclamation, AudioPlayMode.Background)
        Me.Close()




    End Sub
End Class