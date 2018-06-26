Imports System.Data.SqlClient
Public Class CData
    'Private Shared strConn As String '= "Server=CHARLESP-6430U\CHARLES; Database=LRDISAM; User ID=SYSADM; Password=ardisam1!"
    'Private Shared strConn As String = "Server=ARVI; Database=SANDBOX; User ID=macros; Password=macros"
    Dim cmd As New SqlClient.SqlCommand
    Dim rdr As SqlClient.SqlDataReader
    'get the username of the logged in user
    Dim strUserName As String = Environment.UserName

    Public Function getDBString(DB) As String
        Dim _env As String = "TEST"
        'Dim _env As String = "PRODUCTION"
        Dim _db As String = DB
        'Dim ConnString As String = "Server=ARSQL; Database=ARDISAM; User ID=pro.ship; Password=Neo1post@"
        Dim ConnString As String = ""

        'Dim ConnString As String = "Driver={MySQL ODBC 5.1 Driver};server=192.168.200.18;uid=root;pwd=11proship11;database=proship;option=3"

        Select Case _db
            Case "ARD"
                Console.WriteLine("ARDISAM")
                If _env = "TEST" Then
                    ConnString = "Server=ARSQL; Database=V9TEST; User ID=pro.ship; Password=Neo1post@"
                Else
                    'ConnString = "Server=ARSQL; Database=ARDISAM; User ID=pro.ship; Password=Neo1post@"
                    Console.WriteLine("ARDISAM")
                End If


            Case "RIVER"
                Console.WriteLine("RIVER")
                If _env = "TEST" Then
                    ConnString = "Server=ARSQL; Database=V9TESTRE; User ID=pro.ship; Password=Neo1post@"
                Else
                    'ConnString = "Server=ARSQL; Database=RIVER; User ID=pro.ship; Password=Neo1post@"
                    Console.WriteLine("RIVER")
                End If


                'Case "RE"
                '    Console.WriteLine("RIVER")
                '    If _env = "TEST" Then
                '        ConnString = "Server=ARVI; Database=RESAND; User ID=macros; Password=macros"
                '    Else
                '        ConnString = "Server=ARVI; Database=RIVER; User ID=macros; Password=macros"
                '    End If
                'Case "SANDBOX"
                '    Console.WriteLine("SANDBOX")
                '    ConnString = "Server=ARVI; Database=SANDBOX; User ID=macros; Password=macros"

                'Case "RESAND"
                '    Console.WriteLine("RESAND")
                '    ConnString = "Server=ARVI; Database=RESAND; User ID=macros; Password=macros"

        End Select

        Return ConnString
    End Function

    Function GetThirdPartyAddress(ByVal strCustNum As String, ByVal strCarrier As String, ByVal strDatabase As String) As DataTable
        'Dim DB As String = "ARD"
        Dim conn As New SqlClient.SqlConnection(getDBString(strDatabase)) 'changed from DB to strDatabase
        Dim dataOrders As New DataTable
        Dim adpt As New SqlClient.SqlDataAdapter
        Dim rowCount As Integer = 0
        'Dim row As DataRow
        Console.WriteLine(getDBString(strDatabase))
        With cmd
            .CommandType = CommandType.Text
            .CommandText = "exec [pnp].[z3RD_GetThirdPartyAddress] "
            '.CommandText = .CommandText + "'" + strDatabase + "', "
            .CommandText = .CommandText + "'" + strCustNum.ToString() + "', "
            .CommandText = .CommandText + "'" + strCarrier + "' "
            Debug.Print(.CommandText)
            With cmd
                .CommandTimeout = 0
            End With

            .Connection = conn
        End With

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            adpt.SelectCommand = cmd
            adpt.Fill(dataOrders)
            rowCount = dataOrders.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")
        Finally
            conn.Close()
        End Try

        Return dataOrders
    End Function


    Function UpdateThirdPartyAddress(custnum, carrier, companyname, acctnum, address1, address2, city, state, zip, country, strDatabase)

        'Dim DB As String = "ARD"
        Dim conn As New SqlClient.SqlConnection(getDBString(strDatabase))
        'Dim dataOrders As New DataTable
        Dim adpt As New SqlClient.SqlDataAdapter
        'Dim rowCount As Integer = 0
        'Dim row As DataRow

        With cmd
            .CommandType = CommandType.Text
            .CommandText = "exec [pnp].[z3RD_UpdateThirdPartyAddress] "
            '.CommandText = .CommandText + "'" + strDatabase + "', "
            .CommandText = .CommandText + "'" + custnum.ToString() + "', "
            .CommandText = .CommandText + "'" + carrier.ToString() + "', "
            .CommandText = .CommandText + "'" + Replace(companyname.ToString(), "'", "''") + "', "
            .CommandText = .CommandText + "'" + acctnum.ToString() + "', "
            .CommandText = .CommandText + "'" + address1.ToString() + "', "
            If Len(address2.ToString()) < 1 Then 'Changed address2 to address2.ToString()
                address2 = "NULL"
            End If
            .CommandText = .CommandText + "'" + address2.ToString() + "', "
            .CommandText = .CommandText + "'" + city.ToString() + "', "
            .CommandText = .CommandText + "'" + state.ToString() + "', "
            .CommandText = .CommandText + "'" + zip.ToString() + "', "
            .CommandText = .CommandText + "'" + country.ToString + "' "
            Debug.Print(.CommandText)
            With cmd
                .CommandTimeout = 0
            End With

            .Connection = conn
        End With

        Try
            'If conn.State = ConnectionState.Closed Then
            '    conn.Open()
            'End If
            'adpt.SelectCommand = cmd
            'adpt.UpdateCommand()

            'adpt.Fill(dataOrders)
            'rowCount = dataOrders.Rows.Count
            'executeVisualSQL("ARD", cmd.CommandText)
            executeVisualSQL(strDatabase, cmd.CommandText)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")
        Finally
            'conn.Close()
        End Try

        Return 0
    End Function

    Function InsertThirdPartyAddress(custnum, carrier, companyname, acctnum, address1, address2, city, state, zip, country, strDatabase)

        Dim DB As String = "ARD"
        Dim conn As New SqlClient.SqlConnection(getDBString(strDatabase))
        'Dim dataOrders As New DataTable
        Dim adpt As New SqlClient.SqlDataAdapter
        'Dim rowCount As Integer = 0
        'Dim row As DataRow

        With cmd
            .CommandType = CommandType.Text
            .CommandText = "exec [pnp].[z3RD_InsertThirdPartyAddress] "
            '.CommandText = .CommandText + "'" + strDatabase + "', "
            .CommandText = .CommandText + "'" + custnum.ToString() + "', "
            .CommandText = .CommandText + "'" + carrier.ToString() + "', "
            .CommandText = .CommandText + "'" + Replace(companyname.ToString(), "'", "''") + "', "
            .CommandText = .CommandText + "'" + acctnum.ToString() + "', "
            .CommandText = .CommandText + "'" + address1.ToString() + "', "
            If Len(address2.ToString()) < 1 Then
                address2 = "NULL"
            End If
            .CommandText = .CommandText + "'" + address2.ToString() + "', "
            .CommandText = .CommandText + "'" + city.ToString() + "', "
            .CommandText = .CommandText + "'" + state.ToString() + "', "
            .CommandText = .CommandText + "'" + zip.ToString() + "', "
            .CommandText = .CommandText + "'" + country.ToString + "' "
            Debug.Print(.CommandText)
            With cmd
                .CommandTimeout = 0
            End With

            .Connection = conn
        End With

        Try
            'If conn.State = ConnectionState.Closed Then
            '    conn.Open()
            'End If
            'adpt.SelectCommand = cmd
            'adpt.UpdateCommand()

            'adpt.Fill(dataOrders)
            'rowCount = dataOrders.Rows.Count
            'executeVisualSQL("ARD", cmd.CommandText)
            executeVisualSQL(strDatabase, cmd.CommandText)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")
        Finally
            'conn.Close()
        End Try

        Return 0
    End Function

    Function executeVisualSQL(ByVal DB As String, ByVal sqlString As String) As Int16
        Dim _SPROC As String = sqlString
        Dim _DB As String = DB
        Dim _return_value As Object
        'Dim _params As SqlParameterCollection
        Dim resultSet As New DataTable()

        Dim strConn As String = getDBString(DB)

        Dim conn As New SqlClient.SqlConnection(strConn)
        Dim adpt As New SqlClient.SqlDataAdapter
        Dim cmd As New SqlCommand()

        'For Each p In params
        '    MsgBox(p)
        'Next
        With cmd
            .CommandType = CommandType.Text
            .CommandText = _SPROC
            .Connection = conn
        End With

        Try
            If cmd.Connection.State = ConnectionState.Closed Then
                cmd.Connection.Open()
            End If

            _return_value = cmd.ExecuteScalar()
            If IsDBNull(_return_value) Then
                _return_value = 0
            End If

            If _return_value Is Nothing Then
                _return_value = 0
            End If

            'resultSet = cmd.
            '_returnVal = cmd.Parameters.Item()
            Return _return_value.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error")
            Return -1
        Finally
            conn.Close()
        End Try
    End Function


    'Function GetThirdPartyAddress(ByVal strCustNum As String, ByVal strCarrier As String) As DataTable
    '    Dim DB As String = "ARD"
    '    Dim conn As New SqlClient.SqlConnection(getDBString(DB))
    '    Dim dataOrders As New DataTable
    '    Dim adpt As New SqlClient.SqlDataAdapter
    '    Dim rowCount As Integer = 0
    '    'Dim row As DataRow

    '    With cmd
    '        .CommandType = CommandType.Text
    '        .CommandText = "exec [pnp].[z3RD_GetThirdPartyAddress] "
    '        .CommandText = .CommandText + "'" + strCustNum.ToString() + "', "
    '        .CommandText = .CommandText + "'" + strCarrier + "' "
    '        Debug.Print(.CommandText)
    '        With cmd
    '            .CommandTimeout = 0
    '        End With

    '        .Connection = conn
    '    End With

    '    Try
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '        End If
    '        adpt.SelectCommand = cmd
    '        adpt.Fill(dataOrders)
    '        rowCount = dataOrders.Rows.Count
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message, "Database Error")
    '    Finally
    '        conn.Close()
    '    End Try

    '    Return dataOrders
    'End Function
End Class
