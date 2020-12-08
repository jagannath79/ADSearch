Option Strict On
Imports System.DirectoryServices
Imports System.IO
Imports System.DirectoryServices.AccountManagement





Public Class Form1
    Private result As Object

    Private Sub btnSearch_Click(sender As System.Object, e As System.EventArgs) Handles btnSearch.Click 'This is what runs when you click the search button.
        Hourglass(True) 'Calls the sub to turn on the wait cursor.
        ListView1.Items.Clear() 'Clear the items from the previous search.  

        Using Root As New DirectoryEntry 'Establish connection to current loged on users Active Directory
            Using Searcher As New DirectorySearcher(Root) 'Start at the top
                'If a first or last name isn't present search using the user ID field.
                If Not (tbFirst.Text.Length + tbLast.Text.Length) > 1 Then
                    Searcher.Filter = "(&(objectCategory=user)(ANR=" & tbUserID.Text & " * ))"
                Else
                    Searcher.Filter = "(&(objectCategory=user)(givenName=" & tbFirst.Text & "*" & ")(sn=" & tbLast.Text & "*" & "))"
                End If

                Searcher.SearchScope = SearchScope.Subtree 'Start at the top and keep drilling down
                Searcher.PropertiesToLoad.Add("sAMAccountName") 'Load User ID
                Searcher.PropertiesToLoad.Add("displayName") 'Load Display Name
                Searcher.PropertiesToLoad.Add("givenName") 'Load Users first name
                Searcher.PropertiesToLoad.Add("sn")   'Load Users last name
                Searcher.PropertiesToLoad.Add("distinguishedName")   'Users Distinguished name
                Searcher.Sort.PropertyName = "sAMAccountName" 'Sort by user ID
                Searcher.Sort.Direction = System.DirectoryServices.SortDirection.Ascending 'A-Z
                Using users = Searcher.FindAll 'Users contains our searh results
                    'MsgBox(users.Count)
                    If users.Count > 0 Then 'If it's zero then no matches were found
                        'Item 1 through Item 5 are the columns in our 1st listview control
                        Dim Item1 As String = Nothing 'User or Contact
                        Dim Item2 As String = Nothing 'sAMAccountName
                        Dim Item3 As String = Nothing 'givenName
                        Dim Item4 As String = Nothing 'sn
                        Dim Item5 As String = Nothing 'distinguishedName
                        Dim strDisplyName As String = Nothing

                        For Each User As SearchResult In users 'goes throug each user in the search results
                            If User.Properties.Contains("displayName") Then '<--This makes sure the property actually exists and has a value
                                strDisplyName = CStr(User.Properties("displayName").Item(0)) '<-- we need to use 0 here because this attribute only has one value
                            End If

                            Dim lv As ListViewItem = (ListView1.Items.Add(strDisplyName)) 'Display name goes in the first column of the listview.

                            If User.Properties.Contains("sAMAccountName") Then '<--This makes sure the property actually exists and has a value
                                Item1 = CStr(User.Properties("sAMAccountName").Item(0)) 'If it's got a sAMAcountName it's a user object.
                                Item1 = "User" 'The second column is user or contact
                            Else 'If there's no sAMAccountName I assume it's a contact
                                Item1 = "Contact" 'The second column user or contact
                            End If
                            lv.SubItems.Add(Item1) 'Add it to the listview
                            Try  'If this property is Null/Empty it will throw an exception. This traps it.
                                Item2 = CStr(User.Properties("sAMAccountName").Item(0))
                            Catch
                                Item2 = "" 'Since it's null set it to blank.
                            End Try
                            lv.SubItems.Add(Item2) 'Add it to the listview
                            Try  'If this property is Null/Empty it will throw an exception. This traps it.
                                Item3 = User.Properties("givenName").Item(0).ToString
                            Catch
                                Item3 = "" 'Since it's null set it to blank.
                            End Try
                            lv.SubItems.Add(Item3) 'Add it to the listview
                            Try  'If this property is Null/Empty it will throw an exception. This traps it.
                                Item4 = User.Properties("sn").Item(0).ToString
                            Catch
                                Item4 = "" 'Since it's null set it to blank.
                            End Try
                            lv.SubItems.Add(Item4) 'Add it to the listview
                            'Item 5


                            lv.SubItems.Add(User.Properties("distinguishedName").Item(0).ToString) 'Okay this item is added to the listview BUT thers's no column defind to display it. 
                            'I've found this to be very handy way of storing a value to use at a later point.
                        Next
                    Else
                        Hourglass(False)
                        Exit Sub
                    End If
                End Using
            End Using
        End Using
        Hourglass(False)
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListView1.SelectedIndexChanged ' A line in the listview has been clicked!

        If ListView1.SelectedItems.Count = 1 Then 'I have to do this check or I'll get an index out of range on SelectedItems(0) in the following line.
            lblUserDN.Text = ListView1.SelectedItems(0).SubItems(5).Text 'I display the users DN in a label on the main form.
            'Note: I pulled this from the listviw data stored durring btnSearch_Click sub above.
        End If

        Hourglass(True)
        ListView2.Items.Clear() 'Clear email addresses from previous selection
        'Establish connection to specific (The user or contact clicked on) AD object.
        Using user As New DirectoryEntry("LDAP://" & lblUserDN.Text) 'Here we get to use the data I pulled from the listviw durring btnSearch_Click sub above.

            For Each eAddress As String In user.Properties("proxyAddresses") 'removes any occurances of matching eMail address.              
                Dim parts As String() = eAddress.Split(New Char() {":"c})
                AddItemToListView(parts(0), parts(1))
            Next

            If user.Properties.Contains("CanonicalName") Then '<--This makes sure the property actually exists and has a value
                Dim strUserCanonicalName = CStr(user.Properties("CanonicalName")(0)) '<-- we need to use 0 here because this attribute only has one value
            End If
            If user.Properties.Contains("description") Then '<--This makes sure the property actually exists and has a value
                Dim strDescription = CStr(user.Properties("description")(0)) '<-- we need to use 0 here because this attribute only has one value
                Me.rtbDescription.Text = strDescription
            Else
                Me.rtbDescription.Text = Nothing
            End If

            If user.Properties.Contains("sAMAccountName") Then '<--This makes sure the property actually exists and has a value
                Me.tbUserID.Text = CStr(user.Properties("sAMAccountName")(0)) '<-- we need to use 0 here because this attribute only has one value
            Else
                Me.tbUserID.Text = Nothing
            End If

            If user.Properties.Contains("employeeID") Then '<--This makes sure the property actually exists and has a value
                Me.tbEmpID.Text = CStr(user.Properties("employeeID")(0)) '<-- we need to use 0 here because this attribute only has one value
            Else
                Me.tbEmpID.Text = Nothing
            End If
            If user.Properties.Contains("department") Then '<--This makes sure the property actually exists and has a value
                Me.lblCDepartment.Text = CStr(user.Properties("department")(0)) '<-- we need to use 0 here because this attribute only has one value
            End If
            If user.Properties.Contains("title") Then '<--This makes sure the property actually exists and has a value
                Me.lblCRole.Text = CStr(user.Properties("title")(0)) '<-- we need to use 0 here because this attribute only has one value
            Else
                Me.lblCRole.Text = Nothing
            End If


            'With these next few properties I get the values using a GetADProperty function I wrote. It's does the exact same thing as above.
            tbHome.Text = GetADProperty(user, "DisplayName")
            tbPager.Text = GetADProperty(user, "mail")
            tbMobile.Text = GetADProperty(user, "c")
            tbFax.Text = GetADProperty(user, "SamAccountName")
            tbIPPhone.Text = GetADProperty(user, "whenCreated")
            tbAcctExpiry.Text = GetADProperty(user, "AccountExpirationDate")


            'tbAcctExpiry.Text = GetADProperty(user, "accountExpires")



            Dim strMgrDN As String = GetADProperty(user, "manager") 'The manager property is stored as the distinguished name to the manager. Here we go get it.
            If Not strMgrDN = "" Then  'Check if it's empty
                Using Manager As New DirectoryEntry("LDAP://" & strMgrDN) 'if it's not, set a directory entry point to it.
                    tbManager.Text = GetADProperty(Manager, "displayName") 'Get the display name of the manager and put it in the textbox.
                End Using 'close the connection to AD for this object.
            Else
                tbManager.Text = ""
            End If

            rtbNotes.Text = GetADProperty(user, "info")

            If user.Properties.Contains("thumbnailPhoto") Then '<--This makes sure the property actually exists and has a value
                Dim bytBLOBData() As Byte = CType((user.Properties("thumbnailPhoto")(0)), Byte()) '<-- we need to use 0 here because this attribute only has one value
                Using stmBLOBData As New MemoryStream(bytBLOBData) 'Create new memory stream.
                    pbUserImg.Image = Image.FromStream(stmBLOBData) 'Load image from stream
                End Using
            Else
                Me.pbUserImg.Image = Nothing
                pbUserImg.Tag = "NoPicture"
            End If

            If ListView1.SelectedItems.Count = 1 Then 'I have to do this check or I'll get an index out of range on SelectedItems(0) in the following line.
                If ListView1.SelectedItems(0).SubItems(1).Text = "User" Then
                    lblConjunction.Text = "and"
                    'Check User Account control flags to check if user is disabled
                    If user.Properties.Contains("userAccountControl") Then
                        If IsAccountActive(CInt(user.Properties("userAccountControl")(0))) Then 'calls IsAccountActive function (See end )
                            lblAccountStatus.Text = " Enabled"
                            lblAccountStatus.ForeColor = System.Drawing.Color.Green 'Sets the text color
                        Else
                            lblAccountStatus.Text = "Disabled"
                            lblAccountStatus.ForeColor = System.Drawing.Color.Red 'Sets the text color
                        End If
                    End If
                    'Use System.DirectoryServices.AccountManagement to determine lockout status
                    Dim UserObject As AccountManagement.UserPrincipal = AccountManagement.UserPrincipal.FindByIdentity(New AccountManagement.PrincipalContext(AccountManagement.ContextType.Domain), Me.tbUserID.Text)
                    If UserObject.IsAccountLockedOut Then
                        lblLocked.Text = "Locked."
                        lblLocked.ForeColor = System.Drawing.Color.Red 'Sets the text color
                    Else
                        lblLocked.Text = "Unlocked."
                        lblLocked.ForeColor = System.Drawing.Color.Green 'Sets the text color
                    End If
                Else
                    lblAccountStatus.Text = "Contact"
                    lblAccountStatus.ForeColor = System.Drawing.Color.Black 'Sets the text color
                    lblLocked.Text = Nothing
                    lblConjunction.Text = Nothing
                End If
                'End use of System.DirectoryServices.AccountManagement to determin lockout status
            End If

            If user.Properties.Contains("extensionAttribute2") Then 'if this is present.
                lblHMB.Text = CStr(user.Properties("extensionAttribute2")(0))
            Else
                lblHMB.Text = "No Type Updated"
            End If

            If user.Properties.Contains("UserPrincipalName") Then 'if this is present.

                lblExpiry.Text = CStr(user.Properties("UserPrincipalName")(0))
            Else
                lblExpiry.Text = "Not Set"
            End If

            If user.Properties.Contains("mailnickname") Then 'if this is present.

                lblMailNickName.Text = CStr(user.Properties("mailnickname")(0))
            Else
                lblMailNickName.Text = "Not Set"
            End If



        End Using 'Close the directory entry to the user object

        Hourglass(False) 'Turn off wait cursor

    End Sub

    Private Function DateTime(v As Object) As String
        Throw New NotImplementedException()
    End Function

    Public Sub Hourglass(ByVal Show As Boolean) 'Used to toggel wait cursor
        If (Show = True) Then
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Else
            System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        End If
    End Sub

    Private Sub AddItemToListView(ByVal Item As String, ByVal Item2 As String)
        Dim lv As ListViewItem = (ListView2.Items.Add(Item))
        If Item = "SMTP" Then
            lv.Font = New Font(lv.Font, FontStyle.Bold)
        End If
        lv.SubItems.Add(Item2)
    End Sub

    Public Shared Function IsAccountActive(ByVal userAccountControl As Integer) As Boolean
        Dim flagExists As Integer = userAccountControl And &H2 'This does a binary AND of userAccountControl and 2 if the flag is set the outcome is 0 if not it's 2
        'if a match is found, then the disabled flag exists within the control flags
        If flagExists > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Helper method that gets properties for AD users.
    ''' </summary>
    ''' <param name="de">DirectoryEntry to use</param>
    ''' <param name="pName">Property name to get</param>
    Public Shared Function GetADProperty(ByVal de As DirectoryEntry, ByVal pName As String) As String
        Dim pValue As String
        Try
            pValue = de.Properties(pName).Value.ToString() 'When value is found return it. . .
        Catch
            pValue = "" 'When property dosn't exist set value to null and return . . .
            'MsgBox("Property Notfound =" & pName)
        End Try
        Return (pValue) '. . .here
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LblEmpID_Click(sender As Object, e As EventArgs) Handles lblEmpID.Click

    End Sub

    Private Sub LblIPPhone_Click(sender As Object, e As EventArgs) Handles lblIPPhone.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles tbAcctExpiry.TextChanged

    End Sub
End Class
