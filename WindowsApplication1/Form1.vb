Public Class Form1

    Dim pre_val As Double
    Dim opr As String
    Dim post_val As Double

    Private Sub no0_Click(sender As Object, e As EventArgs) Handles no0.Click
        Input.Text = Input.Text + "0"
    End Sub

    Private Sub Button_decimal_Click(sender As Object, e As EventArgs) Handles Button_decimal.Click
        pre_val = Val(Input.Text)
        Input.Text = " "
        opr = "."
    End Sub

    Private Sub Button_ans_Click(sender As Object, e As EventArgs) Handles Button_ans.Click
        Select Case (opr)
            Case "+"
                Input.Text = pre_val + Val(Input.Text)
            Case "-"
                Input.Text = pre_val - Val(Input.Text)
            Case "*"
                Input.Text = pre_val * Val(Input.Text)
            Case "/"
                Input.Text = pre_val / Val(Input.Text)
           
        End Select
    End Sub

    Private Sub no1_Click(sender As Object, e As EventArgs) Handles no1.Click
        Input.Text = Input.Text + "1"
    End Sub

    Private Sub no2_Click(sender As Object, e As EventArgs) Handles no2.Click
        Input.Text = Input.Text + "2"
    End Sub

    Private Sub no3_Click(sender As Object, e As EventArgs) Handles no3.Click
        Input.Text = Input.Text + "3"
    End Sub


    Private Sub no4_Click(sender As Object, e As EventArgs) Handles no4.Click
        Input.Text = Input.Text + "4"
    End Sub

    Private Sub no5_Click(sender As Object, e As EventArgs) Handles no5.Click
        Input.Text = Input.Text + "5"
    End Sub

    Private Sub no6_Click(sender As Object, e As EventArgs) Handles no6.Click
        Input.Text = Input.Text + "6"
    End Sub

    Private Sub Button_sub_Click(sender As Object, e As EventArgs) Handles Button_sub.Click
        Input.Text = Input.Text + "-"
    End Sub

    Private Sub no7_Click(sender As Object, e As EventArgs) Handles no7.Click
        Input.Text = Input.Text + "7"
    End Sub

    Private Sub no8_Click(sender As Object, e As EventArgs) Handles no8.Click
        Input.Text = Input.Text + "8"
    End Sub

    Private Sub no9_Click(sender As Object, e As EventArgs) Handles no9.Click
        Input.Text = Input.Text + "9"
    End Sub

    Private Sub Button_add_Click(sender As Object, e As EventArgs) Handles Button_add.Click
        pre_val = Val(Input.Text)
        Input.Text = " "
        opr = "+"

    End Sub

    Private Sub Button_multi_Click(sender As Object, e As EventArgs) Handles Button_multi.Click
        pre_val = Val(Input.Text)
        Input.Text = " "
        opr = "*"
    End Sub

    Private Sub Button_mod_Click(sender As Object, e As EventArgs)
        pre_val = Val(Input.Text)
        Input.Text = " "
        opr = "%"
    End Sub

    Private Sub Button_divide_Click(sender As Object, e As EventArgs) Handles Button_divide.Click
        pre_val = Val(Input.Text)
        Input.Text = " "
        opr = "/"
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs)
        Input.Text = " "
    End Sub

    
    

End Class
