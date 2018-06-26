Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        'check to see if a Carrier button is checked
        'Dim ischecked As Boolean = isCarrierChecked()
        If isCarrierChecked() = False Then
            MsgBox("Select Carrier")
            Exit Sub
        End If

        If isDatabaseChecked() = False Then
            MsgBox("Select Database")
            Exit Sub
        End If

        'check to make sure there is a value in custid
        If isCustIDValue() = False Then
            MsgBox("Enter Customer ID")
            Exit Sub
        End If

        'look up Current records
        Dim dobj As New CData
        Dim dtable As New DataTable
        'Dim strsql As String = ""
        'strsql = "exec [pnp].[z3RD_GetThirdPartyAddress] "
        'strsql = strsql + "'" + txtCustID.Text.ToString() + "', "
        'strsql = strsql + "'" + getCarrier() + "' "
        dtable = dobj.GetThirdPartyAddress(txtCustID.Text, getCarrier(), getDatabase())
        'dtable = dobj.executeVisualSQL_ReturnString
        dgThirdParty.DataSource = dtable
        'Debug.Write(dtable)
        dgThirdParty.Enabled = False
        dgThirdParty.Visible = True
        btnEdit.Visible = True
        btnSave.Visible = True
        btnSaveNew.Visible = False
        GroupBox1.Visible = False
        If Not dgThirdParty.RowCount > 1 Then
            If (MsgBox("No 3rd Party account found.   Would you like to create one?", vbYesNo, "Create 3rd Party")) = vbYes Then
                'MsgBox("yes")
                dgThirdParty.DataSource = Nothing
                dgThirdParty.Visible = False
                btnEdit.Visible = False
                btnSave.Visible = False
                btnSaveNew.Visible = True
                'dgThirdParty.Enabled = True
                'dgThirdParty.EditMode = DataGridViewEditMode.EditOnEnter
                'Dim custnumcol As DataGridViewColumn = New DataGridViewColumn()
                'custnumcol.HeaderText = "custnum"
                'custnumcol.CellTemplate = Text
                'dgThirdParty.Columns.Add(custnumcol)
                ''dgThirdParty.Columns.Add("companyname")
                ''dgThirdParty.Columns.Add("carrier")
                ''dgThirdParty.Columns.Add("acctnum")
                ''dgThirdParty.Columns.Add("address1")
                ''dgThirdParty.Columns.Add("address2")
                ''dgThirdParty.Columns.Add("city")
                ''dgThirdParty.Columns.Add("state")
                ''dgThirdParty.Columns.Add("zip")
                ''dgThirdParty.Columns.Add("country")
                ''dgThirdParty.Rows.Add()
                'Dim row As DataGridViewRow
                'row = dgThirdParty.Rows.Item(0)
                'row.Cells.Item("custnum").Value = txtCustID.Text
                GroupBox1.Visible = True
                txtcustnum.Text = txtCustID.Text
                txtcarrier.Text = getCarrier()

                Dim bob As String = ""

                If bob = "test" Then
                    txtcompanyname.Text = "Blain"
                    'txtcarrier.Text = "UPS"
                    txtacctnum.Text = "BOBOB"
                    txtaddress1.Text = "BOX 9999"
                    txtaddress2.Text = ""
                    txtcity.Text = "CITY"
                    txtstate.Text = "ST"
                    txtzip.Text = "59911"
                    txtcountry.Text = "US"
                End If
            Else
                'MsgBox("no")
                Exit Sub
            End If

        End If
    End Sub

    Private Function getCarrier() As String
        Dim carrier As String = ""
        If rdoUPS.Checked = True Then
            carrier = "UPS"
        Else
            carrier = "FED"
        End If
        Return carrier
    End Function

    Private Function getDatabase() As String
        Dim database As String = ""
        If rdoArdisam.Checked = True Then
            database = "ARD"
        Else
            database = "RIVER"
        End If
        Return database
    End Function

    Private Function isCustIDValue() As Boolean
        Dim checked As Boolean = False
        If Len(txtCustID.Text) > 0 Then
            checked = True
        End If
        Return checked
    End Function

    Private Function isCarrierChecked() As Boolean
        Dim checked As Boolean = False
        If rdoFedEx.Checked = True Then
            checked = True
        ElseIf rdoUPS.Checked = True Then
            checked = True
        End If

        Return checked

    End Function

    Private Function isDatabaseChecked() As Boolean
        Dim checked As Boolean = False
        If rdoArdisam.Checked = True Then
            checked = True
        ElseIf rdoRiver.Checked = True Then
            checked = True
        End If

        Return checked

    End Function

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        dgThirdParty.Enabled = True
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'validate the data
        'custid
        'Account num       


        Dim dobj As New CData
        Dim row As DataGridViewRow
        row = dgThirdParty.Rows.Item(0)
        If Len(row.Cells.Item("custnum").Value) < 1 Then
            MsgBox("Need a customerID")
            Exit Sub
        End If
        If Len(row.Cells.Item("acctnum").Value) < 1 Then
            MsgBox("Need an account number")
            Exit Sub
        End If
        'call sproc



        'custnum
        'carrier
        'acctnum
        '[address1]
        '[address2]
        '[city]
        '[state]
        '[zip]
        '[country]
        'MsgBox(row.Cells.Item("custnum").Value)
        'MsgBox("About to run the update")
        dobj.UpdateThirdPartyAddress(row.Cells.Item("custnum").Value,
                                     row.Cells.Item("carrier").Value,
                                     row.Cells.Item("companyname").Value,
                                     row.Cells.Item("acctnum").Value,
                                     row.Cells.Item("address1").Value,
                                     row.Cells.Item("address2").Value,
                                     row.Cells.Item("city").Value,
                                     row.Cells.Item("state").Value,
                                     row.Cells.Item("zip").Value,
                                     row.Cells.Item("country").Value,
                                     getDatabase())
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click

        With dgThirdParty
            .DataSource = Nothing
            .Refresh()
        End With
        'dgThirdParty.Columns.Add("custnum", "custnum")
        'dgThirdParty.Rows.Add()
        ' grid.Columns.Add()
        'With grid

        '    .Columns.Item(0).HeaderText = "Bob"
        'End With
        'dgThirdParty = grid
        'dgThirdParty.Refresh()
    End Sub

    Private Sub btnSaveNew_Click(sender As Object, e As EventArgs) Handles btnSaveNew.Click
        'MsgBox("save")
        Dim _custnum As String = ""
        Dim _companyname As String = ""
        Dim _carrier As String = ""
        Dim _acctnum As String = ""
        Dim _address1 As String = ""
        Dim _address2 As String = ""
        Dim _city As String = ""
        Dim _state As String = ""
        Dim _zip As String = ""
        Dim _country As String = ""

        Dim dobj As New CData

        If txtcustnum.Text = "" Or txtcarrier.Text = "" Or txtacctnum.Text = "" Then
            MsgBox("Please enter data")
        Else
            _custnum = txtcustnum.Text
            _companyname = txtcompanyname.Text
            _carrier = txtcarrier.Text
            _acctnum = txtacctnum.Text
            _address1 = txtaddress1.Text
            _address2 = txtaddress2.Text
            _city = txtcity.Text
            _state = txtstate.Text
            _zip = txtzip.Text
            _country = txtcountry.Text

            dobj.InsertThirdPartyAddress(_custnum, _carrier, _companyname, _acctnum, _address1, _address2, _city, _state, _zip, _country, getDatabase())

        End If

    End Sub
End Class
