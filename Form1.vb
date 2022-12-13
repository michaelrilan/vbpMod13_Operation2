Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Button

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles start_btn.Click
        Dim random As New Random()
        Dim randomNumber As Integer = random.Next(1, 1000)
        random_label.Text = randomNumber
        new_calc_label.Text = randomNumber
    End Sub


    Private Sub again_btn_Click(sender As Object, e As EventArgs) Handles again_btn.Click
        random_label.Text = 0
        new_calc_label.Text = 0
        counter_label.Text = 0
        add_2.Checked = False
        sub_2.Checked = False
        mul_2.Checked = False
        div_2.Checked = False
        sq_2.Checked = False
        sqroot_2.Checked = False
    End Sub

    Private Sub done_btn_Click(sender As Object, e As EventArgs) Handles done_btn.Click
        Me.Close()
    End Sub

    Private Sub apply_math_Click(sender As Object, e As EventArgs) Handles apply_math.Click
        Dim random_num As Integer
        Dim cnt As Integer
        Dim new_cal As Integer


        cnt = counter_label.Text
        random_num = random_label.Text
        new_cal = new_calc_label.Text


        If (add_2.Checked = True) Then
            counter_label.Text = cnt + 1
            new_calc_label.Text = new_cal + 2
            If (new_cal = 100) Then
                MsgBox("Congratulations!!")
                random_label.Text = 0
                new_calc_label.Text = 0
                counter_label.Text = 0
                add_2.Checked = False
                sub_2.Checked = False
                mul_2.Checked = False
                div_2.Checked = False
                sq_2.Checked = False
                sqroot_2.Checked = False

            End If

        ElseIf (sub_2.Checked = True) Then
                counter_label.Text = cnt + 1
            new_calc_label.Text = new_cal - 2
            If (new_cal = 100) Then
                MsgBox("Congratulations!!")
                random_label.Text = 0
                new_calc_label.Text = 0
                counter_label.Text = 0
                add_2.Checked = False
                sub_2.Checked = False
                mul_2.Checked = False
                div_2.Checked = False
                sq_2.Checked = False
                sqroot_2.Checked = False

            End If
        ElseIf (mul_2.Checked = True) Then
                counter_label.Text = cnt + 1
            new_calc_label.Text = new_cal * 2
            If (new_cal = 100) Then
                MsgBox("Congratulations!!")
                random_label.Text = 0
                new_calc_label.Text = 0
                counter_label.Text = 0
                add_2.Checked = False
                sub_2.Checked = False
                mul_2.Checked = False
                div_2.Checked = False
                sq_2.Checked = False
                sqroot_2.Checked = False

            End If
        ElseIf (div_2.Checked = True) Then
                counter_label.Text = cnt + 1
            new_calc_label.Text = new_cal / 2
            If (new_cal = 100) Then
                MsgBox("Congratulations!!")
                random_label.Text = 0
                new_calc_label.Text = 0
                counter_label.Text = 0
                add_2.Checked = False
                sub_2.Checked = False
                mul_2.Checked = False
                div_2.Checked = False
                sq_2.Checked = False
                sqroot_2.Checked = False

            End If
        ElseIf (sq_2.Checked = True) Then
                counter_label.Text = cnt + 1
            new_calc_label.Text = new_cal ^ 2
            If (new_cal = 100) Then
                MsgBox("Congratulations!!")
                random_label.Text = 0
                new_calc_label.Text = 0
                counter_label.Text = 0
                add_2.Checked = False
                sub_2.Checked = False
                mul_2.Checked = False
                div_2.Checked = False
                sq_2.Checked = False
                sqroot_2.Checked = False

            End If
        ElseIf (sqroot_2.Checked = True) Then
                counter_label.Text = cnt + 1
            new_calc_label.Text = new_cal ^ (1 / 2)
            If (new_cal = 100) Then
                MsgBox("Congratulations!!")
                random_label.Text = 0
                new_calc_label.Text = 0
                counter_label.Text = 0
                add_2.Checked = False
                sub_2.Checked = False
                mul_2.Checked = False
                div_2.Checked = False
                sq_2.Checked = False
                sqroot_2.Checked = False

            End If

        End If

    End Sub
End Class
