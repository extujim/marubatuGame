Public Class Form1

    Dim flg As Boolean


    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Image = System.Drawing.Image.FromFile("player1.png")
        PictureBox2.Image = System.Drawing.Image.FromFile("player2.png")
        flg = False
        Label1.Text = "Player1からスタートです"

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If flg = False Then
            Button1.Text = "○"
            flg = True
            If Button2.Text = "○" And Button3.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button4.Text = "○" And Button7.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "○" And Button9.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player2の番です"
            End If

        ElseIf flg = True Then
            Button1.Text = "×"
            flg = False
            If Button2.Text = "×" And Button3.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button4.Text = "×" And Button7.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "×" And Button9.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button1.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If flg = False Then
            Button2.Text = "○"
            flg = True
            If Button1.Text = "○" And Button3.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "○" And Button8.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player2の番です"
            End If
        elseIf flg = True Then
        Button2.Text = "×"
            flg = False
            If Button1.Text = "×" And Button3.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "×" And Button8.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
           
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button2.Enabled = False
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If flg = False Then
            Button3.Text = "○"
            flg = True
            If Button2.Text = "○" And Button1.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button6.Text = "○" And Button9.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button7.Text = "○" And Button5.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player2の番です"
            End If
        elseIf flg = True Then
        Button3.Text = "×"
            flg = False
            If Button2.Text = "×" And Button1.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button6.Text = "×" And Button9.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "×" And Button7.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button3.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        If flg = False Then
            Button7.Text = "○"
            flg = True
            If Button8.Text = "○" And Button9.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button1.Text = "○" And Button4.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "○" And Button3.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player2の番です"
            End If
        elseIf flg = True Then
        Button7.Text = "×"
            flg = False
            If Button8.Text = "×" And Button9.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button4.Text = "×" And Button1.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "×" And Button3.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button7.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If flg = False Then
            Button5.Text = "○"
            flg = True
            If Button2.Text = "○" And Button8.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button4.Text = "○" And Button6.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button1.Text = "○" And Button9.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button3.Text = "○" And Button7.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player2の番です"
            End If
        ElseIf flg = True Then
            Button5.Text = "×"
            flg = False
            If Button2.Text = "×" And Button8.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button4.Text = "×" And Button6.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button1.Text = "×" And Button9.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button3.Text = "×" And Button7.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button5.Enabled = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        If flg = False Then
            Button4.Text = "○"
            flg = True
            If Button1.Text = "○" And Button7.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "○" And Button6.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            
            Else : Label1.Text = "Player2の番です"
            End If
        ElseIf flg = True Then
            Button4.Text = "×"
            flg = False
            If Button1.Text = "×" And Button7.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "×" And Button6.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button4.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        If flg = False Then
            Button9.Text = "○"
            flg = True
            If Button8.Text = "○" And Button7.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button3.Text = "○" And Button6.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button1.Text = "○" And Button5.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player2の番です"
            End If
        ElseIf flg = True Then
            Button9.Text = "×"
            flg = False
            If Button8.Text = "×" And Button7.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button3.Text = "×" And Button6.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button5.Text = "×" And Button1.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button9.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        If flg = False Then
            Button8.Text = "○"
            flg = True
            If Button7.Text = "○" And Button9.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button2.Text = "○" And Button5.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            
            Else : Label1.Text = "Player2の番です"
            End If
       elseif flg = True Then
            Button8.Text = "×"
            flg = False
            If Button7.Text = "×" And Button9.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button2.Text = "×" And Button5.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
           
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button8.Enabled = False
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        If flg = False Then
            Button6.Text = "○"
            flg = True
            If Button3.Text = "○" And Button9.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False

            ElseIf Button4.Text = "○" And Button5.Text = "○" Then
                Label1.Text = "Player1の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ure.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ao.png")
                PictureBox3.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False

            Else : Label1.Text = "Player2の番です"
            End If
       elseif flg = True Then
            Button6.Text = "×"
            flg = False
            If Button3.Text = "×" And Button9.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
            ElseIf Button4.Text = "×" And Button5.Text = "×" Then
                Label1.Text = "Player2の勝ちです！"
                PictureBox1.Image = System.Drawing.Image.FromFile("player1ao.png")
                PictureBox2.Image = System.Drawing.Image.FromFile("player2ure.png")
                PictureBox4.BackColor = Color.Yellow
                Button1.Enabled = False
                Button2.Enabled = False
                Button3.Enabled = False
                Button4.Enabled = False
                Button5.Enabled = False
                Button6.Enabled = False
                Button7.Enabled = False
                Button8.Enabled = False
                Button9.Enabled = False
           
            Else : Label1.Text = "Player1の番です"
            End If
        End If
        Button6.Enabled = False
    End Sub

    Private Sub 新しいゲームToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 新しいゲームToolStripMenuItem.Click

    End Sub

    Private Sub 新しいゲームToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles 新しいゲームToolStripMenuItem1.Click
        PictureBox3.BackColor = Color.Lime
        PictureBox4.BackColor = Color.Lime
        PictureBox1.Image = System.Drawing.Image.FromFile("player1.png")
        PictureBox2.Image = System.Drawing.Image.FromFile("player2.png")
        Dim o As Control

        For Each o In Me.Controls

            If o.GetType Is GetType(Button) Then

                o.Text = ""

            End If

        Next
        For Each o In Me.Controls

            If o.GetType Is GetType(Button) Then

                o.Enabled = True

            End If

        Next
        Label1.Text = "Player1からスタートです"
        flg = False

    End Sub

    Private Sub 終了ToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles 終了ToolStripMenuItem.Click
        End
    End Sub
End Class
