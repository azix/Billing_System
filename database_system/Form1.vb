Public Class Form1
    Dim firstvalue As Double
    Dim secondvalue As Double
    Dim answer As Double
    Dim operations As String

    Const iTax = 0.2

    Dim American_Dollar As Double = 1.52
    Dim Nigerian_Naira As Double = 302.96
    Dim Canadian_Dollar As Double = 2.03
    Dim Brazilian_Real As Double = 5.86
    Dim Kenyan_shilling As Double = 156.21
    Dim Philippine_Peso As Double = 71.74
    Dim Indonesian_Rupiah As Double = 20746.75
    Dim Indian_Rupee As Double = 100.68

    Private Sub Button_click(sender As Object, e As EventArgs) Handles TabPage1.Click, Button9.Click, Button7.Click, Button6.Click, Button5.Click, Button18.Click, Button16.Click, Button14.Click, Button13.Click, Button11.Click, Button10.Click
        'Code for 0 to 9
        Dim b As Button = sender
        If lblDisplay.Text = "0" Then
            lblDisplay.Text = b.Text
        Else
            lblDisplay.Text = lblDisplay.Text + b.Text

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Order_dataDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Order_dataDataSet.Table)
        'TODO: This line of code loads data into the 'Order_dataDataSet.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.Order_dataDataSet.Table)




        Cmbcurrency.Text = "Choose one .... "
        Cmbcurrency.Items.Add("USA")
        Cmbcurrency.Items.Add("Kenya")
        Cmbcurrency.Items.Add("Canada")
        Cmbcurrency.Items.Add("Nigeria")
        Cmbcurrency.Items.Add("Brazil")
        Cmbcurrency.Items.Add("India")
        Cmbcurrency.Items.Add("Philippines")
        Cmbcurrency.Items.Add("Indonesia")

        txtConversion.Text = "0"


        Unit_Price1TextBox.Text = "0"
        Unit_Price2TextBox.Text = "0"
        Unit_Price3TextBox.Text = "0"

        Sub_Total1TextBox.Text = "0"
        Sub_Total2TextBox.Text = "0"
        Sub_Total3TextBox.Text = "0"

        Qty1TextBox.Text = "0"
        Qty2TextBox.Text = "0"
        Qty3TextBox.Text = "0"


    End Sub

    Private Sub arithmetic_function(sender As Object, e As EventArgs) Handles MyBase.Click, Button8.Click, Button4.Click, Button15.Click, Button12.Click
        Dim ops As Button = sender
        firstvalue = lblDisplay.Text
        lblShowCal.Text = lblDisplay.Text
        lblDisplay.Text = ""
        operations = ops.Text
        lblShowCal.Text = lblShowCal.Text + "" + operations
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        lblDisplay.Text = "0"
        lblShowCal.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If InStr(lblDisplay.Text, ".") = 0 Then
            lblDisplay.Text = lblDisplay.Text + "."
        End If
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        secondvalue = lblDisplay.Text
        If operations = "+" Then
            answer = firstvalue + secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        ElseIf operations = "-" Then
            answer = firstvalue - secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        ElseIf operations = "*" Then
            answer = firstvalue * secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        ElseIf operations = "/" Then
            answer = firstvalue / secondvalue
            lblDisplay.Text = answer
            lblShowCal.Text = ""
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        btnCC.Visible = True
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles btnCC.Click
        btnCC.Visible = False
    End Sub

    Private Sub TableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Order_dataDataSet)

    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        Order_DateTextBox.Text = Today
        Order_TimeTextBox.Text = TimeOfDay


        Ref_NoTextBox.Text = Rnd() * 3056


        Sub_Total1TextBox.Text = Unit_Price1TextBox.Text * Qty1TextBox.Text
        Sub_Total2TextBox.Text = Unit_Price2TextBox.Text * Qty2TextBox.Text
        Sub_Total3TextBox.Text = Unit_Price3TextBox.Text * Qty3TextBox.Text

        OrderSubTotalTextBox.Text = Val(Sub_Total1TextBox.Text) + Val(Sub_Total2TextBox.Text) + Val(Sub_Total3TextBox.Text)
        TaxTextBox.Text = OrderSubTotalTextBox.Text * iTax
        SubTotalTextBox.Text = Val(OrderSubTotalTextBox.Text) + Val(TaxTextBox.Text)

        Unit_Price1TextBox.Text = FormatCurrency(Unit_Price1TextBox.Text)
        Unit_Price2TextBox.Text = FormatCurrency(Unit_Price2TextBox.Text)
        Unit_Price3TextBox.Text = FormatCurrency(Unit_Price3TextBox.Text)

        Sub_Total1TextBox.Text = FormatCurrency(Sub_Total1TextBox.Text)
        Sub_Total2TextBox.Text = FormatCurrency(Sub_Total2TextBox.Text)
        Sub_Total3TextBox.Text = FormatCurrency(Sub_Total3TextBox.Text)


        OrderSubTotalTextBox.Text = FormatCurrency(OrderSubTotalTextBox.Text)
        TaxTextBox.Text = FormatCurrency(TaxTextBox.Text)
        SubTotalTextBox.Text = FormatCurrency(SubTotalTextBox.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Customer_idTextBox.Text = ""
        Customer_nameTextBox.Text = ""
        Customer_PhoneTextBox.Text = ""
        Ref_NoTextBox.Text = ""
        Order_DateTextBox.Text = ""
        Order_TimeTextBox.Text = ""
        OrderSubTotalTextBox.Text = ""

        Qty1TextBox.Text = "0"
        Qty2TextBox.Text = "0"
        Qty3TextBox.Text = "0"

        Unit_Price1TextBox.Text = "0"
        Unit_Price2TextBox.Text = "0"
        Unit_Price3TextBox.Text = "0"


        Sub_Total1TextBox.Text = "0"
        Sub_Total2TextBox.Text = "0"
        Sub_Total3TextBox.Text = "0"


        OrderSubTotalTextBox.Text = ""
        TaxTextBox.Text = ""
        SubTotalTextBox.Text = ""
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Validate()
        Me.TableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Order_dataDataSet)

    End Sub

    Private Sub btnCal_Click(sender As Object, e As EventArgs) Handles btnCal.Click
        TabControl1.SelectedTab = TabPage1
    End Sub

    Private Sub btnReicept_Click(sender As Object, e As EventArgs) Handles btnReicept.Click
        TabControl1.SelectedTab = TabPage2
    End Sub

    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        TabControl1.SelectedTab = TabPage3
    End Sub

    Private Sub btnCart_Click(sender As Object, e As EventArgs) Handles btnCart.Click
        TabControl1.SelectedTab = TabPage2
        Order_TimeTextBox.Text = TimeOfDay


        txtReicept.AppendText(vbTab + vbTab + vbTab + "  ONLINE SHOPPING SYSTEM")
        txtReicept.AppendText(vbTab + vbTab + vbTab + "=============================================")
        txtReicept.AppendText("" + vbNewLine)

        txtReicept.AppendText(vbTab + vbTab + vbTab + "  ONLINE SHOPPING SYSTEM")
        txtReicept.AppendText(vbTab + vbTab + vbTab + "================================================================")
        txtReicept.AppendText("" + vbNewLine)
        txtReicept.AppendText(vbNewLine + "Name:" + vbTab + Customer_nameTextBox.Text + vbTab + "Phone: " + vbTab + Customer_PhoneTextBox.Text + vbTab + "Ref_No:" + Ref_NoTextBox.Text + vbNewLine)

        txtReicept.AppendText(vbNewLine + "Order Date:" + vbTab + Order_DateTextBox.Text + vbTab + "Order Time:" + vbTab + Order_TimeTextBox.Text + vbNewLine)


        txtReicept.AppendText(vbNewLine + "Item Type:" + vbTab + vbTab + vbTab + "Qty" + vbTab + "Unit Price" + vbTab + "SubTotal" + vbNewLine)
        txtReicept.AppendText(vbNewLine + "Cellphones:" + vbTab + vbTab + vbTab + Qty1TextBox.Text + vbTab + Unit_Price1TextBox.Text + vbTab + Sub_Total1TextBox.Text + vbNewLine)
        txtReicept.AppendText(vbNewLine + "Laptops:" + vbTab + vbTab + vbTab + vbTab & Qty2TextBox.Text + vbTab + Unit_Price2TextBox.Text + vbTab + Sub_Total2TextBox.Text + vbNewLine)
        txtReicept.AppendText(vbNewLine + "Computers:" + vbTab + vbTab + vbTab + Qty3TextBox.Text + vbTab + Unit_Price3TextBox.Text + vbTab + Sub_Total3TextBox.Text + vbNewLine)

        txtReicept.AppendText(vbNewLine + vbTab + vbTab + vbTab + "Order SubTotal:" + vbTab + OrderSubTotalTextBox.Text + vbNewLine)
        txtReicept.AppendText(vbNewLine + vbTab + vbTab + vbTab + "Tax:" + vbTab + TaxTextBox.Text + vbNewLine)
        txtReicept.AppendText(vbNewLine + vbTab + vbTab + vbTab + "Total:" + vbTab + SubTotalTextBox.Text + vbNewLine)


        txtReicept.AppendText(vbNewLine + "===========================================================================" + vbNewLine)
        txtReicept.AppendText(vbNewLine + "Online shopping system" + vbNewLine)
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim British_Pounds As Double = CDbl(txtConversion.Text)
        LblConvert.Text = CStr(CursorConverter(British_Pounds))

        If Cmbcurrency.Text = "Nigeria" Then
            LblConvert.Text = "NGN:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "USA" Then
            LblConvert.Text = "$:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Brazil" Then
            LblConvert.Text = "RBL:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Canada" Then
            LblConvert.Text = "C$:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "kenya" Then
            LblConvert.Text = "KES:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Philippines" Then
            LblConvert.Text = "PHP:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "Indonesia" Then
            LblConvert.Text = "IDR:" & " " & Val(LblConvert.Text)
        ElseIf Cmbcurrency.Text = "India" Then
            LblConvert.Text = "INR:" & " " & Val(LblConvert.Text)



        End If

    End Sub
    Function CursorConverter(ByVal money As Double) As Double
        If Cmbcurrency.Text = "Nigeria" Then
            Return Math.Round(Nigerian_Naira * money, 2)
        ElseIf Cmbcurrency.Text = "USA" Then
            Return Math.Round(American_Dollar * money, 2)
        ElseIf Cmbcurrency.Text = "Canada" Then
            Return Math.Round(Canadian_Dollar * money, 2)
        ElseIf Cmbcurrency.Text = "Brazil" Then
            Return Math.Round(Brazilian_Real * money, 2)
        ElseIf Cmbcurrency.Text = "Kenya" Then
            Return Math.Round(Kenyan_shilling * money, 2)
        ElseIf Cmbcurrency.Text = "Philppines" Then
            Return Math.Round(Philippine_Peso * money, 2)
        ElseIf Cmbcurrency.Text = "Indonesia" Then
            Return Math.Round(Indonesian_Rupiah * money, 2)
        ElseIf Cmbcurrency.Text = "India" Then
            Return Math.Round(Indian_Rupee * money, 2)
        End If


    End Function

    Private Sub Qty1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Qty1TextBox.TextChanged

    End Sub

    Private Sub Qty1TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Qty1TextBox.MouseDown
        Qty1TextBox.Text = ""
    End Sub

    Private Sub Qty2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Qty2TextBox.TextChanged

    End Sub

    Private Sub Qty2TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Qty2TextBox.MouseDown
        Qty2TextBox.Text = ""
    End Sub

    Private Sub Qty3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Qty3TextBox.TextChanged

    End Sub

    Private Sub Qty3TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Qty3TextBox.MouseDown
        Qty3TextBox.Text = ""
    End Sub

    Private Sub Sub_Total1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Sub_Total1TextBox.TextChanged

    End Sub

    Private Sub Sub_Total1TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Sub_Total1TextBox.MouseDown
        Sub_Total1TextBox.Text = ""
    End Sub

    Private Sub Sub_Total2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Sub_Total2TextBox.TextChanged

    End Sub

    Private Sub Sub_Total2TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Sub_Total2TextBox.MouseDown
        Sub_Total2TextBox.Text = ""
    End Sub

    Private Sub Sub_Total3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Sub_Total3TextBox.TextChanged

    End Sub

    Private Sub Sub_Total3TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Sub_Total3TextBox.MouseDown
        Sub_Total3TextBox.Text = ""
    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

        Customer_idTextBox.Text = ""
        txtConversion.Text = "0"


        Unit_Price1TextBox.Text = "0"
        Unit_Price2TextBox.Text = "0"
        Unit_Price3TextBox.Text = "0"

        Sub_Total1TextBox.Text = "0"
        Sub_Total2TextBox.Text = "0"
        Sub_Total3TextBox.Text = "0"

        Qty1TextBox.Text = "0"
        Qty2TextBox.Text = "0"
        Qty3TextBox.Text = "0"

    End Sub

    Private Sub txtConversion_TextChanged(sender As Object, e As EventArgs) Handles txtConversion.TextChanged

    End Sub

    Private Sub txtConversion_MouseDown(sender As Object, e As MouseEventArgs) Handles txtConversion.MouseDown
        txtConversion.Text = ""
    End Sub

    Private Sub Unit_Price1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Unit_Price1TextBox.TextChanged

    End Sub

    Private Sub Unit_Price1TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Unit_Price1TextBox.MouseDown
        Unit_Price1TextBox.Text = ""
    End Sub

    Private Sub Unit_Price2TextBox_TextChanged(sender As Object, e As EventArgs) Handles Unit_Price2TextBox.TextChanged

    End Sub

    Private Sub Unit_Price2TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Unit_Price2TextBox.MouseDown
        Unit_Price2TextBox.Text = ""
    End Sub

    Private Sub Unit_Price3TextBox_TextChanged(sender As Object, e As EventArgs) Handles Unit_Price3TextBox.TextChanged

    End Sub

    Private Sub Unit_Price3TextBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Unit_Price3TextBox.MouseDown
        Unit_Price3TextBox.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
